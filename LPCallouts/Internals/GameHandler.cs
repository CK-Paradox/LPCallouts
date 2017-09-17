﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//LSPDFR
using Rage;
using Rage.Native;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Mod.Callouts;
using LSPD_First_Response.Engine.Scripting.Entities;

namespace LPCallouts.Internals
{
    public class GameHandler
    {
        public static string ini_username { get; set; }
        public static string ini_division { get; set; }
        public static string ini_unittype { get; set; }
        public static string ini_beat { get; set; }
        public static int ini_department { get; set; }
        public static Keys ini_action { get; set; }
        public static Keys ini_menu { get; set; }
        public static Keys ini_menu_mod { get; set; }
        public static float ini_radius { get; set; }
        public static bool ini_custommodels { get; set; }
        public static int ini_occurrence { get; set; }

        public static string _dialog_dept;
        public static bool _lights_on = false;

        public static string _dept_lspd = "LSPD - Los Santos Police Department";
        public static string _dept_lssd = "LSSD - Los Santos Sheriff Department";
        public static string _dept_lscs = "LSCS - Los Santos County Sheriff";
        public static string _dept_bcso = "BCSO - Blaine County Sheriff Office";
        public static string _dept_sahp = "SAHP - San Andreas Highway Patrol";
        public static string _dept_sapr = "SAPR - San Andreas Park Ranger";
        public static string _usernotice = "Please return to the accident scene and finish the conversation!";

        public static int _displaytime = 8000;
        public static float _minimumdistance = 2f;
        public static float _driveoffdistance = 100f;

        public static InitializationFile initialiseFile()
        {
            //InitializationFile is a Rage class.
            InitializationFile ini = new InitializationFile("Plugins/LSPDFR/LPCallouts.ini");
            ini.Create();
            return ini;
        }

        public static void GetIniValues()
        {
            InitializationFile ini = initialiseFile();

            #region username
            //USERNAME
            string username = ini.ReadString("USER", "OfficerName", "HotActionCop");
            if (string.IsNullOrWhiteSpace(username))
            {
                ini_username = "HotActionCop";
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Username~w~ is empty, default value loaded");
            }
            else if (username.Length > 15)
            {
                ini_username = "HotActionCop";
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Username~w~ is to long (max. 15char), default value loaded");
            }
            else
            {
                ini_username = username;
            }
            #endregion username

            #region division
            //CHECK IF DIVISION IS BETWEEN 1 and 10
            string unit = ini.ReadString("UNIT", "Division", "01");
            if (string.IsNullOrWhiteSpace(unit))
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Division~w~ is empty, default value loaded");
            }
            else
            {
                int readdivision = Int32.Parse(unit);
                if (Enumerable.Range(1, 10).Contains(readdivision))
                {
                    ini_division = unit;
                }
                else
                {
                    ini_division = "01";
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Division~w~ is invalid or out of range, default value loaded");
                }
            }
            #endregion division

            #region unittype
            //CHECK IF UNITTYPE IS EXISTING
            string unittype = ini.ReadString("UNIT", "UnitType", "LINCOLN");
            if (string.IsNullOrWhiteSpace(unittype))
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~UnitType~w~ is empty, default value loaded");
            }
            else
            {
                switch (unittype)
                {
                    case "ADAM":
                    case "BOY":
                    case "CHARLES":
                    case "DAVID":
                    case "EDWARD":
                    case "FRANK":
                    case "GEORGE":
                    case "HENRY":
                    case "IDA":
                    case "JOHN":
                    case "KING":
                    case "LINCOLN":
                    case "MARY":
                    case "NORA":
                    case "OCEAN":
                    case "PAUL":
                    case "QUEEN":
                    case "ROBERT":
                    case "SAM":
                    case "TOM":
                    case "UNION":
                    case "VICTOR":
                    case "WILLIAM":
                    case "XRAY":
                    case "YOUNG":
                    case "ZEBRA":
                        ini_unittype = unittype;
                        break;
                    default:
                        ini_unittype = "LINCOLN";
                        Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~UnitType~w~ is invalid or not existing, default value loaded");
                        break;
                }
            }
            #endregion unittype

            #region beat
            //CHECK IF BEAT IS BETWEEN 1-24
            string beat = ini.ReadString("UNIT", "Beat", "18");
            if (string.IsNullOrWhiteSpace(beat))
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Beat~w~ is empty, default value loaded");
            }
            else
            {
                int readbeat = Int32.Parse(beat);
                if (Enumerable.Range(1, 24).Contains(readbeat))
                {
                    ini_beat = beat;
                }
                else
                {
                    ini_beat = "18";
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Beat~w~ is invalid or out of range, default value loaded");
                }
            }
            #endregion beat

            #region department
            string department = ini.ReadString("UNIT", "Department", "1");
            if (string.IsNullOrWhiteSpace(department))
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Department~w~ is empty, default value loaded");
            }
            else
            {
                int readdepartment = Int32.Parse(department);
                if (Enumerable.Range(1, 6).Contains(readdepartment))
                {
                    ini_department = int.Parse(department);
                    switch (ini_department)
                    {
                        case 1:
                            _dialog_dept = _dept_lspd;
                            break;
                        case 2:
                            _dialog_dept = _dept_lssd;
                            break;
                        case 3:
                            _dialog_dept = _dept_lscs;
                            break;
                        case 4:
                            _dialog_dept = _dept_bcso;
                            break;
                        case 5:
                            _dialog_dept = _dept_sahp;
                            break;
                        case 6:
                            _dialog_dept = _dept_sapr;
                            break;
                    }
                }
                else
                {
                    ini_department = 1;
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Department~w~ is invalid or out of range, default value loaded");
                }
            }
            #endregion department

            #region actionkey
            try
            {
                string actionkey = ini.ReadString("KEYBINDING", "ActionKey", "Y");
                if (string.IsNullOrWhiteSpace(actionkey))
                {
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Actionkey~w~ is empty, default value 'Y' loaded");
                }
                else if (!Regex.IsMatch(actionkey, @"^[A-Z0-9]+$"))
                {
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Actionkey~w~ value is invalid (A-Z 0-9), default value 'Y' loaded");
                }
                else
                {
                    KeysConverter kc_action = new KeysConverter();
                    ini_action = (Keys)kc_action.ConvertFromString(actionkey);
                }
            }
            catch
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Actionkey~w~ is invalid, default value 'Y' loaded");
                ini_action = Keys.Y;
            }
            #endregion actionkey

            #region menukey
            try
            {
                string menukey = ini.ReadString("KEYBINDING", "MenuKey", "F11");
                if (string.IsNullOrWhiteSpace(menukey))
                {
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~MenuKey~w~ is empty, default value 'F11' loaded");
                }
                else
                {
                    switch (menukey)
                    {
                        case "F1":
                        case "F2":
                        case "F3":
                        case "F4":
                        case "F5":
                        case "F6":
                        case "F7":
                        case "F8":
                        case "F9":
                        case "F10":
                        case "F11":
                        case "F12":
                            KeysConverter kc_menu = new KeysConverter();
                            ini_menu = (Keys)kc_menu.ConvertFromString(menukey);
                            break;
                        default:
                            Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~MenuKey~w~ value is invalid (F1-F12), default value 'F11' loaded");
                            ini_menu = Keys.F11;
                            break;
                    }
                }
            }
            catch
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~MenuKey~w~ is invalid, default value 'F11' loaded");
                ini_menu = Keys.F11;
            }
            #endregion menukey

            #region menu modifier key
            try
            {
                string menumodkey = ini.ReadString("KEYBINDING", "MenuModifier", "NONE");
                if (string.IsNullOrWhiteSpace(menumodkey))
                {
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Menu Modifier Key~w~ is empty, default value 'NONE' loaded");
                }
                else
                {
                    switch (menumodkey)
                    {
                        case "LeftCtrl":
                            ini_menu_mod = Keys.LControlKey;
                            break;
                        case "RightCtrl":
                            ini_menu_mod = Keys.RControlKey;
                            break;
                        case "LeftAlt":
                            ini_menu_mod = Keys.LMenu;
                            break;
                        case "RightAlt":
                            ini_menu_mod = Keys.RMenu;
                            break;
                        case "LeftShift":
                            ini_menu_mod = Keys.LShiftKey;
                            break;
                        case "RightShift":
                            ini_menu_mod = Keys.RShiftKey;
                            break;
                        case "NONE":
                            ini_menu_mod = Keys.None;
                            break;
                        default:
                            Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Menu Modifier Key~w~ value is invalid, default value 'NONE' loaded");
                            ini_menu_mod = Keys.None;
                            break;
                    }
                }
            }
            catch
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Menu Modifier Key~w~ value read error, default value 'NONE' loaded");
                ini_menu_mod = Keys.None;
            }
            #endregion menu modifier key

            #region radius
            //CHECK IF DIVISION IS BETWEEN 1 and 10
            string spawnradius = ini.ReadString("SCENE", "SpawnRadius", "1500");
            if (string.IsNullOrWhiteSpace(spawnradius))
            {
                Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~SpawnRadius~w~ is empty, default value loaded");
            }
            else
            {
                int readspawnradius = Int32.Parse(spawnradius);
                if (Enumerable.Range(500, 4000).Contains(readspawnradius))
                {
                    ini_radius = float.Parse(spawnradius);
                }
                else
                {
                    ini_radius = 1500f;
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~SpawnRadius~w~ is invalid or out of range, default value loaded");
                }
            }
            #endregion

            #region Occurrence
            string spawnoccurrence = ini.ReadString("SCENE", "Occurrence", "2");
            switch (spawnoccurrence)
            {
                case "1":
                    ini_occurrence = 1;
                    break;
                case "2":
                    ini_occurrence = 2;
                    break;
                case "3":
                    ini_occurrence = 3;
                    break;
                default:
                    ini_occurrence = 2;
                    break;
            }

            #endregion

            #region RDE
            //CHECK IF DIVISION IS BETWEEN 1 and 10
            string _rde = ini.ReadString("EXTSUPPORT", "CustomModels", "0");
            switch (_rde)
            {
                case "0":
                    ini_custommodels = false;
                    break;
                case "1":
                    ini_custommodels = true;
                    break;
                default:
                    ini_custommodels = false;
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~RDE Value~w~ is invalid or out of range, default value loaded");
                    break;
            }
            #endregion RDE
        }

        public static void WriteIniValue(int dept)
        {
            GameFiber.StartNew(delegate
            {
                try
                {
                    InitializationFile ini = initialiseFile();
                    string writedept = dept.ToString();
                    ini.Write("UNIT", "Department", writedept);
                    ini_department = int.Parse(writedept);
                }
                catch
                {
                    Game.DisplayNotification("~r~LPCallouts~w~ ini file error: ~y~Department~w~ value could not be written, check access rights on ini file");
                }
                DispatchMessage("10-4, " + ini_division + "-" + ini_unittype + "-" + ini_beat + " is 10-8.");
                GameFiber.Yield();
            }, "Write to INI");

        }

        public static void CleanUp(object _instance, int calloutid, ref LHandle pursuit, bool isarrested, uint speedzone = 0, bool Suspect = true, Globals.CalloutEnd Ending = Globals.CalloutEnd.NORMAL)
        {
            if (isarrested == true)
            {
                Functions.PlayScannerAudio("SUSPECT_UNDER_ARREST NO_FURTHER_UNITS_REQUIRED OUTRO_01");
            }

            #region remove speedzone
            if (speedzone != 0)
            {
                World.RemoveSpeedZone(speedzone);
            }
            #endregion remove speedzone

            #region check pursuit
            //CHECK IF PURSUIT STILL EXISTS
            if (pursuit != null)
            {
                try
                {
                    if (Functions.IsPursuitStillRunning(pursuit))
                    {
                        Functions.ForceEndPursuit(pursuit);
                    }
                }
                catch
                {
                    ErrorHandler.LogMessage(_instance.GetType().Name + " Pursuit was not cleaned up at callout end", 303);
                }
            }
            #endregion check pursuit

            #region Rage.Ped cleanup
            //CLEANUP OF PEDS
            try
            {
                if (Suspect && Ending == Globals.CalloutEnd.NORMAL)
                {
                    Ped _suspectPed = (_instance as ISuspect)._ped_suspect;
                    _suspectPed.Dismiss();
                    _suspectPed.IsPersistent = false;
                    Content.HumanList.Where(t => t._calloutid == calloutid && t._model != _suspectPed).AsParallel().ForAll(f => { RemoveObject(f._model); });
                }
                else
                {
                    Content.HumanList.Where(t => t._calloutid == calloutid).AsParallel().ForAll(f => { RemoveObject(f._model); });
                }
            }
            catch
            {
                ErrorHandler.LogMessage(_instance.GetType().Name + " Ped Entity could not be deleted", 104);
            }
            #endregion

            #region vehicles cleanup
            //CLEANUP OF VEHICLES
            try
            {
                if (Suspect)
                {
                    Vehicle _suspectCar = (_instance as ISuspect)._veh_suspect;
                    _suspectCar.Dismiss();
                    _suspectCar.IsPersistent = false;
                    Content.CarList.Where(t => t._calloutid == calloutid && t._model != _suspectCar).AsParallel().ForAll(f => { RemoveObject(f._model); });
                }
                else
                {
                    Content.CarList.Where(t => t._calloutid == calloutid).AsParallel().ForAll(f => { RemoveObject(f._model); });
                }
            }
            catch
            {
                ErrorHandler.LogMessage(_instance.GetType().Name + " Vehicle Entity could not be deleted", 103);
            }
            #endregion vehicles cleanup

            #region objects cleanup
            //CLEANUP OF OBJECTS
            try
            {
                Content.ObjectList.Where(t => t._calloutid == calloutid).AsParallel().ForAll(f =>
                {
                    RemoveObject(f._model);
                    RemoveObject(f._model_inv);
                });
            }
            catch
            {
                ErrorHandler.LogMessage(_instance.GetType().Name + " Object Entity could not be deleted", 105);
            }
            #endregion objects cleanup

            #region blips cleanup
            // CLEANUP OF BLIPS
            try
            {
                if (Suspect)
                {
                    (_instance as ISuspect)._blip_list.AsParallel().ForAll(t =>
                            {
                                if (t != null)
                                    try
                                    {
                                        if (t.Exists())
                                            t.Delete();
                                    }
                                    catch (Exception ex)
                                    {
                                        ErrorHandler.LogMessage(t + " " + ex, 123);
                                    }
                            });
                    (_instance as ISuspect)._blip_list.Clear();
                }
            }
            catch
            {
                ErrorHandler.LogMessage(_instance.GetType().Name + " Blip Entity could not be deleted", 102);
            }
            #endregion blips cleanup
        }

        public static void DispatchAudio(string area, int type)
        {
            switch (type)
            {
                case 1:
                    Functions.PlayScannerAudio("DIV_" + ini_division + " " + ini_unittype + " BEAT_" + ini_beat + " ASSISTANCE_REQUIRED IN " + area + " UNITS_RESPOND_CODE_03_02");
                    break;
                case 2:
                    Functions.PlayScannerAudio("DIV_" + ini_division + " " + ini_unittype + " BEAT_" + ini_beat + " CITIZENS_REPORT_01 DISTURBANCE_LPC IN_01 " + area);
                    break;
                case 3:
                    Functions.PlayScannerAudio("DIV_" + ini_division + " " + ini_unittype + " BEAT_" + ini_beat + " WE_HAVE_01 LPC_EM_CALL " + area);
                    break;
                default:
                    break;
            }
        }

        public static void DrawMarker(int type, Vector3 pos, Vector3 rot, Vector3 scale, Color color)
        {
            NativeFunction.CallByName<uint>("DRAW_MARKER", type, pos.X, pos.Y, pos.Z, 0f, 0f, 0f,
                    rot.X, rot.Y, rot.Z, scale.X, scale.Y, scale.Z, (int)color.R, (int)color.G, (int)color.B, (int)color.A, true, false,
                    2, false, false, false, false);
        }

        public static void DispatchMessage(string _text)
        {
            switch (ini_department)
            {
                case 1:
                    Game.DisplayNotification("web_lossantospolicedept", "web_lossantospolicedept", "Los Santos Police~w~", "~y~DISPATCH~w~", _text);
                    break;
                case 2:
                    Game.DisplayNotification("3dtextures", "mpgroundlogo_cops", "Los Santos Sheriff~w~", "~b~DISPATCH~w~", _text);
                    break;
                case 3:
                    Game.DisplayNotification("dia_police", "dia_police", "Los Santos County~w~", "~g~DISPATCH~w~", _text);
                    break;
                case 4:
                    Game.DisplayNotification("dia_police", "dia_police", "Blaine County~w~", "~o~DISPATCH~w~", _text);
                    break;
                case 5:
                    Game.DisplayNotification("char_call911", "char_call911", "Highway Patrol~w~", "~p~DISPATCH~w~", _text);
                    break;
                case 6:
                    Game.DisplayNotification("char_call911", "char_call911", "Park Rangers~w~", "~r~DISPATCH~w~", _text);
                    break;
                default:
                    Game.DisplayNotification("3dtextures", "mpgroundlogo_cops", "San Andreas Police~w~", "~c~DISPATCH~w~", _text);
                    break;
            }
        }

        public static void PlayerChat(int type, string text)
        {
            switch (type)
            {
                //PLAYER
                case 1:
                    Game.DisplaySubtitle("~b~" + GameHandler.ini_username + ":~w~ " + text, GameHandler._displaytime);
                    break;
                //OFFICER
                case 2:
                    Game.DisplaySubtitle("~g~Officer:~w~ " + text, GameHandler._displaytime);
                    break;
                //WITNESS
                case 3:
                    Game.DisplaySubtitle("~y~Witness:~w~ " + text, GameHandler._displaytime);
                    break;
                //VICTIM
                case 4:
                    Game.DisplaySubtitle("~y~Victim:~w~ " + text, GameHandler._displaytime);
                    break;
                //CIVILIAN
                case 5:
                    Game.DisplaySubtitle("~y~Civilian:~w~ " + text, GameHandler._displaytime);
                    break;
                //PARAMEDIC
                case 6:
                    Game.DisplaySubtitle("~g~Paramedic:~w~ " + text, GameHandler._displaytime);
                    break;
                //CALLER
                case 7:
                    Game.DisplaySubtitle("~y~Caller:~w~ " + text, GameHandler._displaytime);
                    break;
                //OWNER
                case 8:
                    Game.DisplaySubtitle("~y~Owner:~w~ " + text, GameHandler._displaytime);
                    break;
                //OWNER
                case 9:
                    Game.DisplaySubtitle("~r~Suspect:~w~ " + text, GameHandler._displaytime);
                    break;
            }

        }

        public static void VehicleLightsControl(object _instance, int calloutid)
        {
            //Time
            TimeSpan _day_start = new TimeSpan(05, 15, 00);
            TimeSpan _day_end = new TimeSpan(20, 30, 00);

            if (World.TimeOfDay < _day_start || World.TimeOfDay > _day_end)
            {
                if (_lights_on == false)
                {
                    Vehicle _suspectCar = (_instance as ISuspect)._veh_suspect;
                    foreach (Vehicle car in Content.CarList.Where(t => t._calloutid == calloutid && t._model != _suspectCar).Select(t => t._model))
                    {
                        try
                        {
                            NativeFunction.CallByName<uint>("SET_VEHICLE_LIGHTS", car, 2);
                        }
                        catch (Exception ex)
                        {
                            ErrorHandler.LogMessage(ex.ToString(), 111);
                        }

                    }
                    _lights_on = true;
                }
            }
            else
            {
                if (_lights_on == true)
                {
                    Vehicle _suspectCar = (_instance as ISuspect)._veh_suspect;
                    foreach (Vehicle car in Content.CarList.Where(t => t._calloutid == calloutid && t._model != _suspectCar).Select(t => t._model))
                    {
                        NativeFunction.CallByName<uint>("SET_VEHICLE_LIGHTS", car, 0);
                    }
                    _lights_on = false;
                }
            }
        }

        public static float PedtoPlayerAngle(Ped ped)
        {
            double delta_x = ped.Position.X - Game.LocalPlayer.Character.Position.X;
            double delta_y = ped.Position.Y - Game.LocalPlayer.Character.Position.Y;
            double radians = Math.Atan2(delta_y, delta_x);
            double angle = (radians * (180 / Math.PI)) + 90;
            return (float)angle;
        }

        public static float VolumeControl(float distance, double factor, int divider)
        {
            float _volume = (float)Math.Pow(10, (distance * factor) / divider);
            return _volume;
        }

        public static bool IsLSPDFRPluginRunning(string Plugin, Version minversion = null)
        {
            foreach (Assembly assembly in Functions.GetAllUserPlugins())
            {
                AssemblyName an = assembly.GetName();
                if (an.Name.ToLower() == Plugin.ToLower())
                {
                    if (minversion == null || an.Version.CompareTo(minversion) >= 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void LoadIPLs()
        {
            //TREQULA-LA
            uint inter_id = NativeFunction.CallByName<uint>("GET_INTERIOR_AT_COORDS", -556.508f, 286.318f, 81.176f);
            NativeFunction.CallByName<uint>("DISABLE_INTERIOR", inter_id, false);
            NativeFunction.CallByName<uint>("CAP_INTERIOR", inter_id, false);
            NativeFunction.CallByName<uint>("REQUEST_IPL", "v_rockclub");
            //LifeInvader
            NativeFunction.CallByName<uint>("REQUEST_IPL", "facelobby");
            NativeFunction.CallByName<uint>("REMOVE_IPL", "facelobbyfake");
            //Lesters Factory
            NativeFunction.CallByName<uint>("REQUEST_IPL", "id2_14_during_door");
            NativeFunction.CallByName<uint>("REQUEST_IPL", "id2_14_during1");
            //Jewlery Store
            uint inter_id1 = NativeFunction.CallByName<uint>("GET_INTERIOR_AT_COORDS", -630.4f, -236.7f, 40.0f);
            NativeFunction.CallByName<uint>("CAP_INTERIOR", inter_id1, false);
            NativeFunction.CallByName<uint>("UNPIN_INTERIOR", inter_id1);
            NativeFunction.CallByName<uint>("DISABLE_INTERIOR", inter_id1, false);
            NativeFunction.CallByName<uint>("REQUEST_IPL", "post_hiest_unload");
            NativeFunction.CallByName<uint>("REMOVE_IPL", "jewel2fake");
            NativeFunction.CallByName<uint>("REMOVE_IPL", "bh1_16_refurb");
        }

        public static void UnlockLifeInvaderDoors()
        {
            uint lifeinvader_doorleft = NativeFunction.CallByName<uint>("GET_HASH_KEY", "v_ilev_fb_door01");
            uint lifeinvader_doorright = NativeFunction.CallByName<uint>("GET_HASH_KEY", "v_ilev_fb_door02");

            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", lifeinvader_doorleft, -1083.62f, -260.4167f, 38.1867f, false, 1, 0);
            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", lifeinvader_doorright, -1080.974f, -259.0204f, 38.1867f, false, 1, 0);
        }

        public static void UnlockTequillaDoors()
        {
            uint teq_door1 = NativeFunction.CallByName<uint>("GET_HASH_KEY", "v_ilev_roc_door4");

            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", teq_door1, -565.1712f, 276.6259f, 83.2863f, false, 1, 0);
            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", teq_door1, -561.2863f, 293.5043f, 87.7771f, false, 1, 0);
        }

        public static void UnlockJewleryStore()
        {
            uint door_front = NativeFunction.CallByName<uint>("GET_HASH_KEY", "p_jewel_door_l");
            uint door_rear = NativeFunction.CallByName<uint>("GET_HASH_KEY", "p_jewel_door_r1");

            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", door_front, -631.96f, -236.33f, 38.21f, false, 1, 0);
            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", door_rear, -630.43f, -238.44f, 38.21f, false, 1, 0);
        }

        public static void UnlockLesterFactory()
        {
            uint door1 = NativeFunction.CallByName<uint>("GET_HASH_KEY", "v_ilev_ss_door7");
            uint door2 = NativeFunction.CallByName<uint>("GET_HASH_KEY", "v_ilev_ss_door8");
            uint door3 = NativeFunction.CallByName<uint>("GET_HASH_KEY", "v_ilev_ss_door02");
            uint door4 = NativeFunction.CallByName<uint>("GET_HASH_KEY", "v_ilev_ss_door03");

            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", door1, 719.0f, -975.0f, 25.0f, false, 1, 0);
            NativeFunction.CallByName<uint>("SET_STATE_OF_CLOSEST_DOOR_OF_TYPE", door2, 717.0f, -975.0f, 25.0f, false, 1, 0);
        }

        public static void SetRelationShip()
        {
            Game.SetRelationshipBetweenRelationshipGroups("COP", "CIVMALE", Relationship.Respect);
            Game.SetRelationshipBetweenRelationshipGroups("COP", "CIVFEMALE", Relationship.Respect);
            Game.SetRelationshipBetweenRelationshipGroups("MEDIC", "CIVMALE", Relationship.Respect);
            Game.SetRelationshipBetweenRelationshipGroups("MEDIC", "CIVFEMALE", Relationship.Respect);
            Game.SetRelationshipBetweenRelationshipGroups("FIREMAN", "CIVMALE", Relationship.Respect);
            Game.SetRelationshipBetweenRelationshipGroups("FIREMAN", "CIVFEMALE", Relationship.Respect);
        }

        public static void RemoveBlip(Blip _blip, List<Blip> _bliplist)
        {
            _bliplist.Remove(_blip);
            if (_blip.Exists())
                _blip.Delete();
        }

        public static void RemoveObject(Ped _object)
        {
            if (_object.Exists())
                _object.Delete();
        }

        public static void RemoveObject(Vehicle _object)
        {
            if (_object.Exists())
                _object.Delete();
        }

        public static void RemoveObject(Rage.Object _object)
        {
            if (_object.Exists())
                _object.Delete();
        }

        public static void SpawnWitness(out Ped Witness, int CalloutID, ref Blip Marker, List<Blip> BlipList, ref int PedID)
        {
            List<Globals.Humans> witnesslist = Content.HumanList.Where(t => t._calloutid == CalloutID && t._type == Globals.HumanType.WITNESS).ToList();
            Globals.Humans Person = witnesslist[Main.LPCRandom.Next(witnesslist.Count)];
            PedID = Person._id;
            Witness = new Ped(Person._modelname, Person._position, Person._heading);
            Witness.IsPersistent = true;
            Witness.BlockPermanentEvents = true;
            Witness.Tasks.PlayAnimation(Person._animdir, Person._animname, 1f, Person._animflag);
            Marker = Witness.AttachBlip();
            Marker.Alpha = 0.0f;
            Marker.Color = System.Drawing.Color.Yellow;
            BlipList.Add(Marker);
        }

        public static void ConversationTrafficStop(ref int Loop, int DialogID, ref bool Talking, Ped Person, int Ending, ref Globals.PlayerState Status, ref Blip CopMarker, ref Blip SuspectMarker, List<Blip> BlipList)
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                int i = Loop;
                string Dialog = Suspects.SuspectDialogs.First(t => t._callouttype == Globals.CalloutType._TrafficStop && t._dialogid == DialogID && t._counter == i)._text;

                switch (Loop)
                {
                    case 0:
                        Talking = true;
                        GameHandler.PlayerChat(1, Dialog);
                        Loop = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(2, Dialog);
                        Loop = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog);
                        Loop = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(2, Dialog);
                        Loop = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog);
                        SuspectMarker.Alpha = 1.0f;
                        Loop = 5;
                        Talking = false;
                        GameFiber.StartNew(delegate
                        {
                            Globals.SuspectPositions _gotopos = Suspects.SuspectPositions.First(t => t._id == Ending && t._type == Globals.PositionType.PED_WAIT);
                            Person.Tasks.GoStraightToPosition(_gotopos._position, 1.0f, _gotopos._heading, 2f, 5000);
                            GameFiber.Wait(5500);
                            Game.DisplaySubtitle("Talk to the driver by pressing ~o~'" + GameHandler.ini_action.ToString() + "", 5000);
                            Person.Tasks.PlayAnimation("amb@code_human_police_investigate@idle_a", "idle_b", 1f, AnimationFlags.Loop);
                        }, FiberHandler._fiber_request);
                        GameHandler.RemoveBlip(CopMarker, BlipList);
                        Status = Globals.PlayerState.TALK_DRIVER;
                        break;
                }
            }
        }

        public static void ConversationAbandon(ref int Loop, int DialogID, ref bool Talking, Ped Person, Vehicle Car, ref Blip Marker, List<Blip> BlipList)
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action) && Loop < 6)
            {
                int i = Loop;
                string Dialog = Suspects.SuspectDialogs.First(t => t._callouttype == Globals.CalloutType._NoSuspect && t._dialogid == DialogID && t._counter == i)._text;

                switch (Loop)
                {
                    case 0:
                        Talking = true;
                        GameHandler.PlayerChat(1, Dialog);
                        Loop = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(2, Dialog);
                        Loop = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog);
                        Loop = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(2, Dialog);
                        Loop = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog);
                        Loop = 5;
                        break;
                    case 5:
                        Talking = false;
                        GameHandler.PlayerChat(2, Dialog);
                        Loop = 6;
                        GameHandler.RemoveBlip(Marker, BlipList);
                        GameFiber.StartNew(delegate
                        {
                            Person.Tasks.ClearImmediately();
                            NativeFunction.CallByName<ulong>("TASK_ENTER_VEHICLE", Person, Car, 12000, -1, 1.0f, 1, 0);
                            GameFiber.Wait(12500);
                            Car.IsPositionFrozen = true;
                            Car.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Off;
                            Person.Tasks.CruiseWithVehicle(Car, 20f, VehicleDrivingFlags.Normal);
                            GameFiber.Wait(2000);
                            Car.IsPositionFrozen = false;
                            GameFiber.Wait(2000);
                            Car.IsPersistent = false;
                            Person.IsPersistent = false;
                            Car.Dismiss();
                            Person.Dismiss();
                            GameFiber.Wait(2000);
                            Functions.StopCurrentCallout();
                        }, FiberHandler._fiber_move);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}