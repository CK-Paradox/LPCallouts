using System;
using System.Reflection;
//LPC
using LPCallouts.Internals;
using LPCallouts.Externals;
using LPCallouts.Menu;
//LSPDFR
using Rage;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Engine.Scripting.Entities;

namespace LPCallouts
{
    public class Main : Plugin
    {
        public static readonly Random LPCRandom = new Random(RandomProvider.Next() ^ Environment.TickCount);

        public static ModelDef.ModelDefinition model_def;
        public static bool _nc_rerun { get; set; }
        public static int _nc_id { get; set; }

        public static bool _plugin_loaded = false;
        public static Persona _UserData { get; set; }

        public override void Initialize()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(LSPDFRResolveEventHandler);
            model_def = new ModelDef.ModelDefinition();

            _nc_rerun = false;
            _nc_id = 0;

            //LOAD INI CONTENT
            try
            {
                GameHandler.GetIniValues();
            }
            catch
            {
                ErrorHandler.LogMessage("INI file could not be loaded", 994);
            }
            //CHECK CUSTOM MODEL SUPPORT

            try
            {
                if (GameHandler.ini_custommodels == true)
                    ModelDef.LoadModelStrings();
                else
                    ModelDef.InitList();
            }
            catch
            {
                ErrorHandler.LogMessage("ModelDef Strings not loaded", 999);
            }

            //LOAD CONTENT
            try
            {
                    Suspects.GenerateContent();
                    Content.GenerateContent();
            }
            catch
            {
                ErrorHandler.LogMessage("Content not loaded", 991);
            }
            //INIT PLUGIN
            try
            {
                Functions.OnOnDutyStateChanged += Functions_OnOnDutyStateChanged;
                Game.LogTrivial("LPCallouts registered.");
                Game.DisplayNotification("crosstheline", "timer_largetick_32", "Successful loaded", "~o~LPCallouts ~c~Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(), "");
                _plugin_loaded = true;
            }
            catch
            {
                ErrorHandler.LogMessage("DLL not loaded", 992);
            }

            //LOAD MENU
            try
            {
                LPCMenu.Main();
            }
            catch
            {
                ErrorHandler.LogMessage("Menu could not be loaded", 991);
            }

            //LOAD IPLS
            try
            {
                GameHandler.LoadIPLs(); 
            }
            catch
            {
                ErrorHandler.LogMessage("IPLS could not be loaded", 998);
            }

        }

        public static Assembly LSPDFRResolveEventHandler(object sender, ResolveEventArgs args)
        {
            foreach (Assembly assembly in Functions.GetAllUserPlugins())
            {
                if (args.Name.ToLower().Contains(assembly.GetName().Name.ToLower()))
                {
                    return assembly;
                }
            }
            return null;
        }

        public override void Finally()
        {
            Game.LogTrivial("LPCallouts unregistered.");
        }

        private static void Functions_OnOnDutyStateChanged(bool onDuty)
        {
            if (onDuty)
            {
                RegisterCallouts();
                if(_plugin_loaded)
                { 
                    Game.DisplayNotification("web_lossantospolicedept", "web_lossantospolicedept", "LPCallouts Active", "", "");

                    //Get Playear character name
                    _UserData = Functions.GetPersonaForPed(Game.LocalPlayer.Character);
                    Globals.CharacterName = _UserData.Forename + " " + _UserData.Surname;
                }
            }
        }

        private static void RegisterCallouts()
        {
            try
            {
                //Occurence Selection
                switch (GameHandler.ini_occurrence)
                {
                    case 1:
                        Functions.RegisterCallout(typeof(Callouts.AssistAvoidDrifer_HIGH));
                        Functions.RegisterCallout(typeof(Callouts.AssistBeach_HIGH));
                        Functions.RegisterCallout(typeof(Callouts.AssistCornerCut_HIGH));
                        Functions.RegisterCallout(typeof(Callouts.AssistCyclist_HIGH));
                        Functions.RegisterCallout(typeof(Callouts.AssistFreeway_HIGH));
                        Functions.RegisterCallout(typeof(Callouts.AssistTruckCrash_HIGH));
                        Functions.RegisterCallout(typeof(Callouts.AssistRunOver_HIGH));
                        Functions.RegisterCallout(typeof(Callouts.NoiseComplaint_HIGH));
                        break;
                    case 2:
                        Functions.RegisterCallout(typeof(Callouts.AssistAvoidDrifer_MED));
                        Functions.RegisterCallout(typeof(Callouts.AssistBeach_MED));
                        Functions.RegisterCallout(typeof(Callouts.AssistCornerCut_MED));
                        Functions.RegisterCallout(typeof(Callouts.AssistCyclist_MED));
                        Functions.RegisterCallout(typeof(Callouts.AssistFreeway_MED));
                        Functions.RegisterCallout(typeof(Callouts.AssistTruckCrash_MED));
                        Functions.RegisterCallout(typeof(Callouts.AssistRunOver_MED));
                        Functions.RegisterCallout(typeof(Callouts.NoiseComplaint_MED));
                        break;
                    case 3:
                        Functions.RegisterCallout(typeof(Callouts.AssistAvoidDrifer_LOW));
                        Functions.RegisterCallout(typeof(Callouts.AssistBeach_LOW));
                        Functions.RegisterCallout(typeof(Callouts.AssistCornerCut_LOW));
                        Functions.RegisterCallout(typeof(Callouts.AssistCyclist_LOW));
                        Functions.RegisterCallout(typeof(Callouts.AssistFreeway_LOW));
                        Functions.RegisterCallout(typeof(Callouts.AssistTruckCrash_LOW));
                        Functions.RegisterCallout(typeof(Callouts.AssistRunOver_LOW));
                        Functions.RegisterCallout(typeof(Callouts.NoiseComplaint_LOW));
                        break;
                }
            }
            catch
            {
                ErrorHandler.LogMessage("Callouts could not be registered", 997);
            }
        }

    }
}