using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
//LPC
using LPCallouts.Externals;
using LPCallouts.Internals;
//LSPDFR
using Rage;
using Rage.Native;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Mod.Callouts;
using LSPD_First_Response.Engine.Scripting.Entities;
//External
using ComputerPlus;

namespace LPCallouts.Callouts
{
    [CalloutInfo("HR_Beach.Spawn.Low", CalloutProbability.Low)]
    class AssistBeach_LOW : AssistBeach
    {
    }

    [CalloutInfo("HR_Beach.Spawn.Medium", CalloutProbability.Medium)]
    class AssistBeach_MED : AssistBeach
    {
    }

    [CalloutInfo("HR_Beach.Spawn.High", CalloutProbability.High)]
    class AssistBeach_HIGH : AssistBeach
    {
    }

    class AssistBeach : Callout, ISuspect
    {
        public Globals.Scenery _area;
        public Globals.SuspectLocation _suspect_location;
        public Globals.SuspectCar _suspect_veh;
        public Globals.SuspectPerson _suspect_ped;
        public Globals.SuspectDialog _suspect_conversation;

        //PEDS
        public Ped _ped_suspect { get; set; }
        public Ped _ped_cop;
        public Ped _ped_civ1;
        public Ped _ped_civ2;
        public Ped _ped_witness;

        //VEHICLES
        public Vehicle _veh_suspect { get; set; }

        //VECTOR 3s
        public Vector3 _ve3_poi;
        public Vector3 _player;

        //Blips
        public List<Blip> _blip_list { get; set; }
        public Blip _blip_poi;
        public Blip _blip_cop;
        public Blip _blip_suspect;
        public Blip _blip_witness;
        public Blip _blip_civ01;
        public Blip _blip_civ02;
        public Blip _blip_searcharea;

        //Handles
        public LHandle _pursuit;

        public Globals.PlayerState statusmachine;
        public Globals.PursuitEnd suspectending;

        //int
        public int _mlog_loop1 = 0;
        public int _mlog_loop2 = 0;
        public int _mlog_loop3 = 0;
        public int _mlog_loop4 = 0;
        public int _mlog_loop5 = 0;
        public int _witness_id = 0;

        //bool
        public bool CalloutActive = false;
        public bool _isarrested = false;
        public bool _getintocar = false;
        public bool _initaudio = false;
        public bool _text_civ01 = false;
        public bool _text_civ02 = false;
        public bool _dispatched = false;
        public bool _pursuitcreated = false;
        public bool _contentisloaded = false;

        public bool _talking_cop = false;
        public bool _talking_civ01 = false;
        public bool _talking_civ02 = false;
        public bool _talking_witness = false;
        public bool _talking_suspect = false;
        public bool _player_at_scene = false;
        public bool _player_at_witness = false;

        //Computer+
        public Guid _callout_id;
        public bool _cplus_active;
        public bool _arrived_at_witness = false;
        public bool _arrived_at_suspect = false;
        public Persona SuspectData;

        public override bool OnBeforeCalloutDisplayed()
        {
            try
            {
                //Get Callout in Range:
                Vector3 CurrentPlayerPosition = Game.LocalPlayer.Character.Position;
                List<Globals.Scenery> CalloutsInRange = Content.CalloutLocations.Where(t => t._type == Globals.CalloutType.BeachScene && t._poi.DistanceTo(CurrentPlayerPosition) <= GameHandler.ini_radius).ToList();

                //Get Random Callout from List in range, otherwise terminate
                if (CalloutsInRange.Count != 0)
                {
                    _area = CalloutsInRange.ElementAt(Main.LPCRandom.Next(CalloutsInRange.Count()));
                    _ve3_poi = _area._poi;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogMessage(ex.ToString(), 777);
            }

            _cplus_active = GameHandler.IsLSPDFRPluginRunning("ComputerPlus", new Version("1.3.0.0"));

            if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) < GameHandler._minimumdistance || Game.LocalPlayer.Character.DistanceTo(_ve3_poi) > GameHandler.ini_radius)
            {
                return false;
            }
            else
            {
                ShowCalloutAreaBlipBeforeAccepting(_ve3_poi, 50f);

                CalloutMessage = "Assistance required";
                CalloutPosition = _ve3_poi;

                GameHandler.DispatchAudio(_area._area, 1);

                //Computer+
                if (_cplus_active)
                {
                    _callout_id = CPlusFunctions.CreateCallout("Traffic accident with possible hit and run", "ASSIST", _ve3_poi, (int)EResponseType.Code_3, "Officer requires assistance");
                }
            }
            return base.OnBeforeCalloutDisplayed();
        }

        public override void OnCalloutDisplayed()
        {
            // Updates the callout's status to "Dispatched" when the player sees the callout on screen
            if (_cplus_active)
                CPlusFunctions.UpdateCalloutStatus(_callout_id, (int)ECallStatus.Dispatched);
            base.OnCalloutDisplayed();
        }

        public override bool OnCalloutAccepted()
        {
            _blip_list = new List<Blip>();
            statusmachine = Globals.PlayerState.CALLED;

            // Updates the callout's status to "Unit Responding" when the player accepts
            if (_cplus_active)
                CPlusFunctions.SetCalloutStatusToUnitResponding(_callout_id);

            GameHandler.DispatchMessage(_area._dispatchtext + " " + _area._street);

            Array _tmpary2 = Enum.GetValues(typeof(Globals.PursuitEnd));
            suspectending = (Globals.PursuitEnd)_tmpary2.GetValue(Main.LPCRandom.Next(_tmpary2.Length));

            GameFiber.StartNew(delegate
            {
                #region spawn blips
                try
                {
                    _blip_poi = new Blip(_area._poi, 30f);
                    _blip_poi.Color = System.Drawing.Color.LightBlue;
                    _blip_poi.EnableRoute(System.Drawing.Color.LightBlue);
                    _blip_poi.Flash(2, 0);
                    _blip_list.Add(_blip_poi);
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Blips could not be created", 004);
                }
                #endregion spawn blips

                #region generate suspect
                try
                {
                    SuspectHandler.GenerateSuspect(this, ref _suspect_veh, ref _suspect_ped, ref _suspect_location, ref _suspect_conversation, _area._region, Globals.CalloutType._Water);
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Suspect vehicle could not be placed", 005);
                }
                #endregion

                #region spawn supsect vehicle
                try
                {
                    SuspectHandler.SpawnVehicle(out Vehicle tmpcar, _suspect_veh, _suspect_location);
                    _veh_suspect = tmpcar;
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Suspect vehicle could not be placed", 005);
                }
                #endregion

                #region spawn suspect
                try
                {
                    SuspectHandler.SpawnPed(out Ped tmpped, _suspect_ped, _suspect_location, ref _blip_suspect, ref SuspectData, _blip_list, _veh_suspect);
                    _ped_suspect = tmpped;
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Suspect ped could not be placed", 006);
                }
                #endregion 

                GameHandler.SpawnWitness(out Ped _tmp_witness, _area._calloutid, ref _blip_witness, _blip_list, ref _witness_id);
                _ped_witness = _tmp_witness;

                _contentisloaded = true;
            }, FiberHandler._fiber_content);

            return base.OnCalloutAccepted();
        }

        public override void OnCalloutNotAccepted()
        {
            if (_cplus_active)
                CPlusFunctions.AssignCallToAIUnit(_callout_id);
            base.OnCalloutNotAccepted();
        }

        public override void Process()
        {
            if (_contentisloaded == true)
            {
                CalloutActive = true;
                #region statusmachine
                //////////////////////////////////////////////
                //  C A L L O U T - S T A T U S M A C H I N E
                //////////////////////////////////////////////
                switch (statusmachine)
                {
                    //INIT
                    case Globals.PlayerState.CALLED:
                        #region Load Models
                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) < 200f)
                        {
                            try
                            {
                                #region spawn peds
                                //SPAWN PEDS
                                try
                                {
                                    foreach (Globals.Humans newped in Content.HumanList.Where(t => t._calloutid == _area._calloutid))
                                    {
                                        if (newped._type != Globals.HumanType.WITNESS)
                                        {
                                            newped._model = new Rage.Ped(newped._modelname, newped._position, newped._heading);
                                            newped._model.IsPersistent = true;
                                            newped._model.BlockPermanentEvents = true;
                                            if (!string.IsNullOrEmpty(newped._animname))
                                                newped._model.Tasks.PlayAnimation(newped._animdir, newped._animname, 1f, newped._animflag);
                                            //SET RELATIONSHIPS
                                            switch (newped._type)
                                            {
                                                case Globals.HumanType.COP:
                                                    newped._model.RelationshipGroup = "COP";
                                                    Functions.SetPedAsCop(newped._model);
                                                    break;
                                                case Globals.HumanType.MEDIC:
                                                case Globals.HumanType.LIFEGUARD:
                                                    newped._model.RelationshipGroup = "MEDIC";
                                                    break;
                                                default:
                                                    newped._model.RelationshipGroup = "CIVMALE";
                                                    break;
                                            }
                                        }
                                    }
                                    GameHandler.SetRelationShip();
                                }
                                catch
                                {
                                    ErrorHandler.LogMessage(this.GetType().Name + " Static peds could not be placed", 002);
                                }
                                #endregion spawn peds

                                #region spawn vehicles
                                //SPAWN VEHICLES
                                try
                                {
                                    foreach (Globals.Cars newcar in Content.CarList.Where(t => t._calloutid == _area._calloutid))
                                    {
                                        newcar._model = new Rage.Vehicle(newcar._modelname, newcar._position, newcar._heading);
                                        newcar._model.IsPersistent = true;
                                        newcar._model.IsEngineOn = true;
                                        switch (newcar._type)
                                        {
                                            case Globals.CarType.POLICE:
                                            case Globals.CarType.EMS:
                                                newcar._model.IsSirenOn = true;
                                                newcar._model.IsSirenSilent = true;
                                                break;
                                            case Globals.CarType.CIV:
                                            case Globals.CarType.TRUCK:
                                                newcar._model.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                                                break;
                                            case Globals.CarType.AIRUNIT:
                                                NativeFunction.CallByName<ulong>("SET_VEHICLE_LIVERY", newcar._model, 1);
                                                newcar._model.SetRotationPitch(newcar._pitch);
                                                newcar._model.SetRotationRoll(newcar._roll);
                                                newcar._model.SetRotationYaw(newcar._yaw);
                                                newcar._model.IsPositionFrozen = true;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                                catch
                                {
                                    ErrorHandler.LogMessage(this.GetType().Name + " Static vehicles could not be placed", 003);
                                }
                                #endregion spawn vehicles

                                GameHandler.VehicleLightsControl(this, _area._calloutid);
                            }
                            catch
                            {
                                ErrorHandler.LogMessage(this.GetType().Name + " model could not be loaded", 010);
                            }
                            statusmachine = Globals.PlayerState.ONROUTE;
                        }
                        #endregion

                        break;
                    //VALUE = 0 -> ONROUTE THE FIRST TIME
                    case Globals.PlayerState.ONROUTE:

                        _ped_cop = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1)._model;
                        _ped_civ1 = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 10)._model;
                        _ped_civ2 = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 13)._model;

                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) < 50f)
                        {
                            Game.DisplaySubtitle("Talk to the officer by pressing ~o~'" + GameHandler.ini_action.ToString() + "'~w~ to gain information about the accident.", GameHandler._displaytime);
                            _blip_poi.DisableRoute();
                            GameHandler.RemoveBlip(_blip_poi, _blip_list);
                            _blip_cop = _ped_cop.AttachBlip();
                            _blip_cop.Color = Color.Blue;
                            _blip_list.Add(_blip_cop);

                            if (_cplus_active)
                            {
                                CPlusFunctions.SetCalloutStatusToAtScene(_callout_id);
                            }
                            _player_at_scene = true;
                            statusmachine = Globals.PlayerState.TALK_COP;
                        }
                        break;
                    //VALUE = 1 -> ARRIVED AT SCENE -> CONVERSATION COP
                    case Globals.PlayerState.TALK_COP:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_cop.Position) < 2f)
                        {
                            Conversation_Cop();
                        }
                        break;
                    //VALUE = 2 -> ARRIVED AT SCENE -> CONVERSATION CIVS
                    case Globals.PlayerState.TALK_CIV:
                        //CIV 1 CONVERSATION
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_civ1.Position) < 2f)
                        {
                            Conversation_Civ01();
                        }

                        //CIV 2 CONVERSATION
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_civ2.Position) < 2f)
                        {
                            Conversation_Civ02();
                        }

                        if (_text_civ01 == true && _text_civ02 == true)
                        {
                            _player_at_scene = false;
                            statusmachine = Globals.PlayerState.TO_WITNESS;
                        }
                        break;
                    //VALUE = 3 -> RUN DIALOG WITH DISPATCH FOR WITNESS
                    case Globals.PlayerState.TO_WITNESS:
                        if (_dispatched == false)
                        {
                            GameFiber.StartNew(delegate
                            {
                                _dispatched = true;
                                GameFiber.Wait(2000);
                                Functions.PlayScannerAudio("DISP_ATTENTION_UNIT_02 DIV_" + GameHandler.ini_division + " " + GameHandler.ini_unittype + " BEAT_" + GameHandler.ini_beat + " CITIZENS_REPORT_03 CRIME_HITRUN UNITS_RESPOND_CODE_02_01");
                                GameFiber.Wait(6000);
                                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ 10-4, go ahead.");
                                GameFiber.Wait(2000);
                                GameHandler.DispatchMessage(Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 5)._text);
                                GameFiber.Wait(5000);
                                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ 10-4. Can you give me the location of the caller?");
                                GameFiber.Wait(5000);
                                uint _streethash = World.GetStreetHash(_ped_witness.Position);
                                string _street = World.GetStreetName(_streethash);
                                GameHandler.DispatchMessage("10-4. Showing you 10-76. Respond to ~y~" + _street + "~w~ Code 2.");
                                _blip_witness.Alpha = 1.0f;
                                _blip_witness.EnableRoute(System.Drawing.Color.Orange);

                                //Computer+
                                if (_cplus_active)
                                {
                                    CPlusFunctions.AddUpdateToCallout(_callout_id, "Report of a crime that is connected to this accident, responding to witness at " + _street);
                                    CPlusFunctions.UpdateCalloutStatus(_callout_id, (int)ECallStatus.Unit_Responding);
                                }

                                statusmachine = Globals.PlayerState.TALK_WITNESS1;
                            }, FiberHandler._fiber_request);
                        }
                        break;
                    //VALUE = 4 -> WITNESS CONVERSATION
                    case Globals.PlayerState.TALK_WITNESS1:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_witness.Position) < 30f && _arrived_at_witness == false)
                        {
                            if (_cplus_active)
                            {
                                CPlusFunctions.UpdateCalloutStatus(_callout_id, (int)ECallStatus.At_Scene);
                                CPlusFunctions.AddUpdateToCallout(_callout_id, "Making contact with witness");
                            }
                            _player_at_witness = true;
                            _arrived_at_witness = true;
                        }

                        if (Game.LocalPlayer.Character.DistanceTo(_ped_witness.Position) < 2f && _dispatched == true)
                        {
                            Conversation_Witness();
                        }
                        break;
                    //VALUE = 5 -> GOTO SEARCHAREA
                    case Globals.PlayerState.SEARCHING:
                        if (Game.LocalPlayer.Character.DistanceTo(_suspect_location._searcharea) < 200f)
                        {
                            if (_blip_searcharea.Exists())
                            {
                                _blip_searcharea.DisableRoute();
                                statusmachine = Globals.PlayerState.TO_SUSPECT;
                            }
                        }
                        break;
                    //VALUE = 5 -> SUSPECT CONVERSATION
                    case Globals.PlayerState.TO_SUSPECT:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 30f && _arrived_at_suspect == false)
                        {
                            if (_cplus_active)
                            {
                                CPlusFunctions.UpdateCalloutStatus(_callout_id, (int)ECallStatus.At_Scene);
                                CPlusFunctions.AddUpdateToCallout(_callout_id, "Searching for possbile suspect");
                            }
                            _arrived_at_suspect = true;
                        }

                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 20f && _pursuitcreated == false && _getintocar == false)
                        {
                            if (_initaudio == false)
                            {
                                GameFiber.StartNew(delegate
                                {
                                    _initaudio = true;
                                    Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ Dispatch, possible suspect identified");
                                    GameHandler.RemoveBlip(_blip_searcharea, _blip_list);
                                    _blip_suspect.Alpha = 1.0f;
                                    GameFiber.Wait(3000);
                                    GameHandler.DispatchMessage("10-4.");
                                    Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_01 PROCEED_WITH_CAUTION_ASSORTED");
                                    _initaudio = true;
                                }, FiberHandler._fiber_request);
                            }
                            SuspectHandler.Conversation(_ped_suspect, _blip_suspect, ref _pursuit, _suspect_conversation, _pursuitcreated, ref _mlog_loop5, ref _talking_suspect);
                        }

                        if (Game.LocalPlayer.Character.LastVehicle.Exists() && _veh_suspect.Exists())
                        {
                            if (suspectending == Globals.PursuitEnd.PURSUIT && _pursuitcreated == false && _isarrested == false && _getintocar == false && Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 100f && Game.LocalPlayer.Character.LastVehicle.IsSirenOn && !Game.LocalPlayer.Character.LastVehicle.IsSirenSilent)
                            {
                                Game.DisplaySubtitle("Suspect had heard your sirens and is fleeing their home.", GameHandler._displaytime);
                                _ped_suspect.Tasks.ClearImmediately();
                                _ped_suspect.Tasks.EnterVehicle(_veh_suspect, 10000, -2);
                                _getintocar = true;
                                _ped_suspect.Tasks.CruiseWithVehicle(_veh_suspect, 30f, VehicleDrivingFlags.Emergency);
                                GameFiber.Wait(12000);

                                _blip_suspect.Alpha = 1.0f;
                                _blip_suspect.IsFriendly = false;
                                _pursuit = Functions.CreatePursuit();
                                Functions.AddPedToPursuit(_pursuit, _ped_suspect);
                                Functions.SetPursuitIsActiveForPlayer(_pursuit, true);
                                _pursuitcreated = true;
                            }
                        }
                        break;
                }
                #endregion statusmachine

                #region angle control
                //COP
                if (_talking_cop == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_cop);
                        Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._id == 1).First()._model.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                //CIVILIAN 1
                if (_talking_civ01 == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_civ1);
                        Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._id == 10).First()._model.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                //CIVILIAN 2
                if (_talking_civ02 == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_civ2);
                        Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._id == 13).First()._model.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                //WITNESS
                if (_talking_witness == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_witness);
                        _ped_witness.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                //SUSPECT
                if (_talking_suspect == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_suspect);
                        _ped_suspect.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                #endregion angle control

                if (_player_at_scene == true && Game.LocalPlayer.Character.DistanceTo(_ve3_poi) > 150f)
                {
                    if (_talking_cop != true || _talking_civ01 != true || _talking_civ02 != true)
                    {
                        Game.DisplaySubtitle(GameHandler._usernotice);
                    }
                }


                if (_player_at_witness == true && Game.LocalPlayer.Character.DistanceTo(_ped_witness.Position) > 150f)
                {
                    if (_talking_witness != true)
                    {
                        Game.DisplaySubtitle(GameHandler._usernotice);
                    }
                }

                //IF PURSUIT WAS RUNNING AND IS NO LONGER ACTIVE THE END
                if (_pursuitcreated && !Functions.IsPursuitStillRunning(_pursuit))
                {
                    if (Functions.IsPedArrested(_ped_suspect))
                        _isarrested = true;
                    End();
                }

                if (!_pursuitcreated && Functions.IsPedArrested(_ped_suspect))
                {
                    _isarrested = true;
                    End();
                }
            }
            base.Process();
        }

        public override void End()
        {
            if (CalloutActive)
            {
                if (_cplus_active)
                {
                    // Changes the call's status to "Concluded" when the callout ends
                    CPlusFunctions.AddUpdateToCallout(_callout_id, "Suspect has been arrested and is in custody");
                    CPlusFunctions.ConcludeCallout(_callout_id);
                }
                GameHandler.CleanUp(this, _area._calloutid, ref _pursuit, _isarrested);
            }
            _area = null;
            base.End();
        }

        public void Conversation_Cop()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 1 && t._counter == _mlog_loop1)._text;

                switch (_mlog_loop1)
                {
                    case 0:
                        _talking_cop = true;
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop1 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(2, Dialog);
                        _mlog_loop1 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop1 = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(2, Dialog);
                        _mlog_loop1 = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog);

                        _blip_civ01 = _ped_civ1.AttachBlip();
                        _blip_civ02 = _ped_civ2.AttachBlip();
                        _blip_civ01.Color = Color.Yellow;
                        _blip_civ02.Color = Color.Yellow;
                        _blip_list.Add(_blip_civ01);
                        _blip_list.Add(_blip_civ02);
                        //Computer+
                        if (_cplus_active)
                        {
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Contact with officers on scene. One Victim, no information available about what happend");
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Following up with questioning attendant crowd.");
                        }
                        _mlog_loop1 = 5;
                        break;
                    case 5:
                        _talking_cop = false;
                        GameHandler.RemoveBlip(_blip_cop, _blip_list);
                        statusmachine = Globals.PlayerState.TALK_CIV;
                        GameHandler.PlayerChat(2, Dialog);

                        GameFiber.StartNew(delegate
                        {
                            Globals.Humans _endcop = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1);
                            _ped_cop.Tasks.ClearImmediately();
                            _ped_cop.Tasks.GoStraightToPosition(_endcop._position, 1f, _endcop._heading, 1f, 3000);
                            GameFiber.Wait(2000);
                            _ped_cop.Tasks.PlayAnimation(_endcop._animdir, _endcop._animname, 1f, _endcop._animflag);
                        }, FiberHandler._fiber_anim);
                        break;


                }
            }
        }

        public void Conversation_Civ01()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 2 && t._counter == _mlog_loop2)._text;

                switch (_mlog_loop2)
                {
                    case 0:
                        _talking_civ01 = true;
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop2 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(5, Dialog);
                        _mlog_loop2 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop2 = 3;
                        break;
                    case 3:
                        _talking_civ01 = false;
                        GameHandler.PlayerChat(5, Dialog);
                        _ped_civ1.Tasks.AchieveHeading(Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 10)._heading);
                        GameHandler.RemoveBlip(_blip_civ01, _blip_list);
                        _text_civ01 = true;
                        break;
                }
            }
        }

        public void Conversation_Civ02()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 3 && t._counter == _mlog_loop3)._text;

                switch (_mlog_loop3)
                {
                    case 0:
                        _talking_civ02 = true;
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop3 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(5, Dialog);
                        _mlog_loop3 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop3 = 3;
                        break;
                    default:
                        _talking_civ02 = false;

                        //Computer+
                        if (_cplus_active)
                        {
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "No ID of victim available. No witnesses at the moment");
                        }

                        GameHandler.PlayerChat(5, Dialog);
                        _ped_civ2.Tasks.AchieveHeading(Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 13)._heading);
                        GameHandler.RemoveBlip(_blip_civ02, _blip_list);
                        _text_civ02 = true;
                        break;
                }
            }
        }

        public void Conversation_Witness()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 4 && t._counter == _mlog_loop4)._text;

                ColorConverter color = new ColorConverter();
                string color1 = color.ConvertToString(_suspect_location._veh_color1);
                string color2 = color.ConvertToString(_suspect_location._veh_color2);

                switch (_mlog_loop4)
                {
                    case 0:
                        _talking_witness = true;
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop4 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(3, Dialog);
                        _mlog_loop4 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog); ;
                        _mlog_loop4 = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(3, "I believe it was a ~y~" + color1 + "/" + color2 + Dialog);
                        GameFiber.Wait(1000);
                        _mlog_loop4 = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop4 = 5;
                        break;
                    case 5:
                        GameHandler.PlayerChat(3, Dialog + _suspect_location._areaname);
                        GameFiber.StartNew(delegate
                        {
                            //Computer+
                            if (_cplus_active)
                            {
                                Persona _victim = Functions.GetPersonaForPed(_ped_witness);
                                CPlusFunctions.AddUpdateToCallout(_callout_id, "Witness Name: " + _victim.FullName);
                                CPlusFunctions.AddUpdateToCallout(_callout_id, "Boat model that caused the accident: " + _veh_suspect.Model.Name + ", Color " + color1 + "/" + color2);
                                CPlusFunctions.AddUpdateToCallout(_callout_id, "Accident was hit and run, responding to " + _suspect_location._areaname);
                                CPlusFunctions.AddPedToCallout(_callout_id, _ped_suspect);
                                CPlusFunctions.AddVehicleToCallout(_callout_id, _veh_suspect);
                                CPlusFunctions.UpdateCalloutStatus(_callout_id, (int)ECallStatus.Unit_Responding);
                            }

                            GameFiber.Wait(2000);
                            Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ Dispatch, heading to " + _suspect_location._areaname);
                            GameFiber.Wait(3000);
                            GameHandler.DispatchMessage("10-4.");
                            Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_01 " + _suspect_location._audioarea);
                            GameFiber.Wait(3000);
                            _blip_searcharea = new Blip(_suspect_location._searcharea, 200f);
                            _blip_searcharea.Alpha = 0.3f;
                            _blip_searcharea.Color = System.Drawing.Color.Yellow;
                            _blip_searcharea.EnableRoute(System.Drawing.Color.Yellow);
                            _blip_list.Add(_blip_searcharea);
                        }, FiberHandler._fiber_request);
                        _mlog_loop4 = 6;
                        break;
                    case 6:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop4 = 7;
                        break;
                    case 7:
                        GameHandler.PlayerChat(3, Dialog);
                        GameHandler.RemoveBlip(_blip_witness, _blip_list);
                        _talking_witness = false;
                        _player_at_witness = false;
                        statusmachine = Globals.PlayerState.SEARCHING;
                        Globals.Humans _data = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == _witness_id);
                        FiberHandler.BackToAnimation(_ped_witness, _data._heading, _data._animdir, _data._animname, _data._animflag);
                        break;
                }
            }
        }
    }
}
