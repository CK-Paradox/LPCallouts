using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
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
    [CalloutInfo("MVA_Freeway.Spawn.Low", CalloutProbability.Low)]
    class AssistFreeway_LOW : AssistFreeway
    {
    }
    [CalloutInfo("MVA_Freeway.Spawn.Medium", CalloutProbability.Medium)]
    class AssistFreeway_MED : AssistFreeway
    {
    }
    [CalloutInfo("MVA_Freeway.Spawn.High", CalloutProbability.High)]
    class AssistFreeway_HIGH : AssistFreeway
    {
    }

    class AssistFreeway : Callout, ISuspect
    {
        public Globals.Scenery _area;
        public Globals.SuspectLocation _suspect_location;
        public Globals.SuspectCar _suspect_veh;
        public Globals.SuspectCar _possible_veh;
        public Globals.SuspectPerson _suspect_ped;
        public Globals.SuspectDialog _suspect_conversation;

        public Globals.SuspectPositions _unitcar;
        public Globals.SuspectPositions _unitped;

        //PEDS
        public Ped _ped_suspect { get; set; }
        public Ped _ped_cop;
        public Ped _ped_ems;
        public Ped _ped_civ1;
        public Ped _ped_civ2;
        public Ped _ped_civ3;

        public Ped _ped_unit;

        //VEHICLES
        public Vehicle _veh_suspect { get; set; }
        public Vehicle _veh_ems;
        public Vehicle _veh_civ1;
        public Vehicle _veh_civ2;
        public Vehicle _veh_civ3;

        public Vehicle _veh_unit;

        //VECTOR 3s
        public Vector3 _ve3_poi;
        public Vector3 _player;

        //Blips
        public List<Blip> _blip_list { get; set; }
        public Blip _blip_poi;
        public Blip _blip_cop;
        public Blip _blip_unit;
        public Blip _blip_suspect;
        public Blip _blip_witness01;
        public Blip _blip_witness02;
        public Blip _blip_witness03;

        //Handles
        public LHandle _pursuit;

        public Globals.PlayerState statusmachine;
        public Globals.CalloutEnd endingvariant;
        public Globals.PursuitEnd suspectending;

        //Speedzones
        public uint _speedzone;

        //int
        public int _mlog_loop1 = 0;
        public int _mlog_loop2 = 0;
        public int _mlog_loop3 = 0;
        public int _mlog_loop4 = 0;
        public int _mlog_loop5 = 0;
        public int _end_pos_id = 0;
        public int _end_dialog_id = 0;

        //bool
        public bool CalloutActive = false;
        public bool _isarrested = false;
        public bool _getintocar = false;
        public bool _pursuitcreated = false;
        public bool _contentisloaded = false;
        public bool _isinformed = false;

        public bool _talking_cop = false;
        public bool _talking_unit = false;
        public bool _talking_witness1 = false;
        public bool _talking_witness2 = false;
        public bool _talking_witness3 = false;
        public bool _talking_suspect = false;
        public bool _player_at_scene = false;
        public bool _unit_exit = false;

        //Computer+
        public Guid _callout_id;
        public bool _cplus_active;
        public bool _arrived_at_suspect = false;
        public Persona SuspectData;

        public override bool OnBeforeCalloutDisplayed()
        {
            try
            {
                //Get Callout in Range:
                Vector3 CurrentPlayerPosition = Game.LocalPlayer.Character.Position;
                List<Globals.Scenery> CalloutsInRange = Content.CalloutLocations.Where(t => t._type == Globals.CalloutType.Freeway && t._poi.DistanceTo(CurrentPlayerPosition) <= GameHandler.ini_radius).ToList();

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

            GameFiber.StartNew(delegate
            {
                #region speedzone
                try
                {
                    _speedzone = World.AddSpeedZone(_area._poi, _area._speedzone_radius, _area._speedzone_speed);
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Problem with speedzone area", 001);
                }
                #endregion speedzone

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

                #region Random Ending / Pursuit

                Array _tmpary1 = Enum.GetValues(typeof(Globals.CalloutEnd));
                endingvariant = (Globals.CalloutEnd)_tmpary1.GetValue(Main.LPCRandom.Next(_tmpary1.Length));

                Array _tmpary2 = Enum.GetValues(typeof(Globals.PursuitEnd));
                suspectending = (Globals.PursuitEnd)_tmpary2.GetValue(Main.LPCRandom.Next(_tmpary2.Length));

                #endregion

                switch (endingvariant)
                {
                    case Globals.CalloutEnd.NORMAL:

                        #region generate suspect
                        try
                        {
                            SuspectHandler.GenerateSuspect(this, ref _suspect_veh, ref _suspect_ped, ref _suspect_location, ref _suspect_conversation, _area._region, Globals.CalloutType._Default);
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

                        break;

                    case Globals.CalloutEnd.ABANDON:

                        #region spawn supsect vehicle
                        try
                        {
                            SuspectHandler.SpawnVehicle(out Vehicle tmpcar, out int _postion_id, _area._region, ref _blip_suspect, _blip_list, endingvariant);
                            _end_pos_id = _postion_id;
                            _veh_suspect = tmpcar;
                            _unitcar = Suspects.SuspectPositions.First(t => t._id == _end_pos_id && t._type == Globals.PositionType.CAR_UNIT);
                            _unitped = Suspects.SuspectPositions.First(t => t._id == _end_pos_id && t._type == Globals.PositionType.PED_UNIT);

                            List<int> _idList = Suspects.SuspectDialogs.Where(t => t._callouttype == Globals.CalloutType._NoSuspect).Select(t => t._dialogid).Distinct().ToList();
                            Random rnd_dialog = new Random(Environment.TickCount);
                            _end_dialog_id = _idList[rnd_dialog.Next(_idList.Count())];
                        }
                        catch
                        {
                            ErrorHandler.LogMessage(this.GetType().Name + " Suspect vehicle could not be placed", 005);
                        }
                        #endregion

                        break;
                    case Globals.CalloutEnd.TRAFFICSTOP:

                        #region spawn supsect vehicle
                        try
                        {
                            SuspectHandler.SpawnVehicle(out Vehicle tmpcar, out int _position_id, _area._region, ref _blip_suspect, _blip_list, endingvariant);
                            _end_pos_id = _position_id;
                            _veh_suspect = tmpcar;
                            _unitcar = Suspects.SuspectPositions.First(t => t._id == _end_pos_id && t._type == Globals.PositionType.CAR_UNIT);
                            _unitped = Suspects.SuspectPositions.First(t => t._id == _end_pos_id && t._type == Globals.PositionType.PED_UNIT);

                            List<int> _idList = Suspects.SuspectDialogs.Where(t => t._callouttype == Globals.CalloutType._TrafficStop).Select(t => t._dialogid).Distinct().ToList();
                            Random rnd_dialog = new Random(Environment.TickCount);
                            _end_dialog_id = _idList[rnd_dialog.Next(_idList.Count())];
                        }
                        catch
                        {
                            ErrorHandler.LogMessage(this.GetType().Name + " Suspect vehicle could not be placed", 005);
                        }
                        #endregion

                        #region spawn suspect
                        try
                        {
                            SuspectHandler.SpawnPed(out Ped tmpped, _area._region, _end_pos_id, ref SuspectData, _veh_suspect);
                            _ped_suspect = tmpped;
                            _ped_suspect.WarpIntoVehicle(_veh_suspect, -1);
                        }
                        catch
                        {
                            ErrorHandler.LogMessage(this.GetType().Name + " Suspect ped could not be placed", 006);
                        }
                        #endregion

                        break;
                }

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
                    case Globals.PlayerState.CALLED:
                        #region Load  Models
                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) < 200f)
                        {
                            try
                            {
                                #region spawn objects
                                //SPAWN OBJECTS
                                try
                                {
                                    foreach (Globals.Objects newobject in Content.ObjectList.Where(t => t._calloutid == _area._calloutid))
                                    {
                                        newobject._model = new Rage.Object(newobject._modelname, newobject._position, newobject._heading);
                                        if (newobject._hitmodel)
                                        {
                                            newobject._model_inv = new Rage.Object(Globals.HitModel, newobject._position, newobject._heading);
                                            newobject._model_inv.IsVisible = false;
                                        }
                                    }
                                }
                                catch
                                {
                                    ErrorHandler.LogMessage(this.GetType().Name + " Static objects could not be placed", 001);
                                }
                                #endregion spawn objects

                                #region spawn peds
                                //SPAWN PEDS
                                try
                                {
                                    foreach (Globals.Humans newped in Content.HumanList.Where(t => t._calloutid == _area._calloutid))
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
                                                newped._model.RelationshipGroup = "MEDIC";
                                                break;
                                            case Globals.HumanType.FIREMAN:
                                                newped._model.RelationshipGroup = "FIREMAN";
                                                break;
                                            default:
                                                newped._model.RelationshipGroup = "CIVMALE";
                                                break;
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
                                            case Globals.CarType.FIRE:
                                                newcar._model.IsSirenOn = true;
                                                newcar._model.IsSirenSilent = true;
                                                break;
                                            case Globals.CarType.CIV:
                                                if (newcar._id == 6)
                                                {
                                                    newcar._model.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                                                    newcar._model.SetRotationRoll(newcar._roll);
                                                    newcar._model.EngineHealth = 100.0f;
                                                    NativeFunction.CallByName<ulong>("SMASH_VEHICLE_WINDOW", newcar._model, 6);
                                                    NativeFunction.CallByName<ulong>("SET_VEHICLE_DAMAGE", newcar._model, 0.7f, 0.5f, 0.5f, 1000.0f, 100.0f, true);
                                                    newcar._model.Wheels[0].BurstTire();
                                                }
                                                else if (newcar._id == 7)
                                                {
                                                    newcar._model.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                                                    NativeFunction.CallByName<ulong>("SET_VEHICLE_DAMAGE", newcar._model, 0.7f, 0.5f, 0.5f, 1000.0f, 100.0f, true);
                                                    newcar._model.Wheels[0].BurstTire();
                                                    newcar._model.Wheels[1].BurstTire();
                                                }
                                                else
                                                {
                                                    newcar._model.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                                                }
                                                break;
                                            case Globals.CarType.TRUCK:
                                                newcar._model.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                                                newcar._model.IsSirenOn = true;
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
                                ErrorHandler.LogMessage(this.GetType().Name + " Models could not be loaded", 010);
                            }
                            statusmachine = Globals.PlayerState.ONROUTE;
                        }
                        #endregion
                        break;
                    //VALUE = 0 -> ONROUTE THE FIRST TIME
                    case Globals.PlayerState.ONROUTE:

                        _ped_cop = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1)._model;
                        _ped_ems = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 11)._model;
                        _ped_civ1 = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 4)._model;
                        _ped_civ2 = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 5)._model;
                        _ped_civ3 = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 6)._model;

                        _veh_ems = Content.CarList.First(t => t._calloutid == _area._calloutid && t._id == 4)._model;
                        _veh_civ1 = Content.CarList.First(t => t._calloutid == _area._calloutid && t._id == 6)._model;
                        _veh_civ2 = Content.CarList.First(t => t._calloutid == _area._calloutid && t._id == 7)._model;
                        _veh_civ3 = Content.CarList.First(t => t._calloutid == _area._calloutid && t._id == 8)._model;

                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) < 50f)
                        {
                            Game.DisplaySubtitle("Talk to the officer and witnesses by pressing ~o~'" + GameHandler.ini_action.ToString() + "'~w~ to gain information about the accident.", GameHandler._displaytime);
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
                    //VALUE = 2 -> ARRIVED AT SCENE -> CONVERSATION WITNESSES 1
                    case Globals.PlayerState.TALK_WITNESS1:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_civ1.Position) < 2f)
                        {
                            Conversation_Witness1();
                        }
                        break;
                    //VALUE = 3 -> CONVERSATION WITNESSES 2
                    case Globals.PlayerState.TALK_WITNESS2:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_civ2.Position) < 2f)
                        {
                            Conversation_Witness2();
                        }
                        break;
                    //VALUE = 4 -> CONVERSATION WITNESSES 2
                    case Globals.PlayerState.TALK_WITNESS3:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_civ3.Position) < 2f)
                        {
                            Conversation_Witness3();
                        }
                        break;
                    //VALUE = 3 -> SUSPECT INTERACTION
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


                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 5f && _pursuitcreated == false && _getintocar == false && _isarrested == false)
                        {
                            SuspectHandler.Conversation(_ped_suspect, _blip_suspect, ref _pursuit, _suspect_conversation, _pursuitcreated, ref _mlog_loop5, ref _talking_suspect);
                        }

                        if (Game.LocalPlayer.Character.LastVehicle.Exists() && _veh_suspect.Exists())
                        {
                            if (suspectending == Globals.PursuitEnd.PURSUIT && _pursuitcreated == false && _isarrested == false && _getintocar == false && Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 100f && Game.LocalPlayer.Character.LastVehicle.IsSirenOn && !Game.LocalPlayer.Character.LastVehicle.IsSirenSilent)
                            {
                                Game.DisplaySubtitle("Suspect had heard your sirens and is fleeing their home.", GameHandler._displaytime);
                                _ped_suspect.Tasks.ClearImmediately();
                                _ped_suspect.Tasks.EnterVehicle(_veh_suspect, 10000, -1);
                                _getintocar = true;
                                GameFiber.Wait(12000);

                                _blip_suspect.Alpha = 1.0f;
                                _blip_suspect.IsFriendly = false;
                                _pursuit = Functions.CreatePursuit();
                                _ped_suspect.Tasks.CruiseWithVehicle(_veh_suspect, 30f, VehicleDrivingFlags.Emergency);
                                Functions.AddPedToPursuit(_pursuit, _ped_suspect);
                                Functions.SetPursuitIsActiveForPlayer(_pursuit, true);
                                _pursuitcreated = true;
                            }
                        }
                        break;
                    //ABANDONED CAR
                    case Globals.PlayerState.SEARCHING:
                        #region Searching
                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) > GameHandler._driveoffdistance)
                        {
                            if (_isinformed == false)
                            {
                                FiberHandler.PlayerSearchingAbandon(ref _blip_suspect);
                                _isinformed = true;
                                statusmachine = Globals.PlayerState.TO_SCENERY;
                            }
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.TO_SCENERY:
                        #region ToScenery
                        if (Game.LocalPlayer.Character.DistanceTo(_veh_suspect.Position) < 250f)
                        {
                            _veh_unit = new Vehicle(_unitcar._modelname, _unitcar._position, _unitcar._heading);
                            _ped_unit = new Ped(_unitped._modelname, _unitped._position, _unitped._heading);
                            _veh_unit.IsPersistent = true;
                            _veh_unit.IsEngineOn = true;
                            _veh_unit.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                            _ped_unit.IsPersistent = true;
                            _ped_unit.BlockPermanentEvents = true;
                            _ped_unit.Tasks.PlayAnimation("amb@code_human_police_investigate@idle_a", "idle_b", 1f, AnimationFlags.Loop);
                            _blip_unit = _ped_unit.AttachBlip();
                            _blip_unit.Color = Color.Blue;
                            _blip_unit.Alpha = 1.0f;
                            _blip_list.Add(_blip_unit);
                            GameHandler.RemoveBlip(_blip_suspect, _blip_list);
                            statusmachine = Globals.PlayerState.NEAR_SCENERY;
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.NEAR_SCENERY:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_unit.Position) < 2f)
                        {
                            GameHandler.ConversationAbandon(ref _mlog_loop5, _end_dialog_id, ref _talking_unit, _ped_unit, _veh_unit, ref _blip_unit, _blip_list);
                        }
                        break;
                    //TRAFFICSTOP
                    case Globals.PlayerState.TO_TRAFFICSTOP:
                        #region Drive to Trafficstop
                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) > GameHandler._driveoffdistance)
                        {
                            if (_isinformed == false)
                            {
                                FiberHandler.PlayerToTrafficstop(ref _blip_unit, _blip_list, _unitped._position);
                                _isinformed = true;
                                statusmachine = Globals.PlayerState.NEAR_TRAFFICSTOP;
                            }
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.NEAR_TRAFFICSTOP:
                        #region Near to Trafficstop
                        if (Game.LocalPlayer.Character.DistanceTo(_veh_suspect.Position) < 250f)
                        {
                            _veh_unit = new Vehicle(_unitcar._modelname, _unitcar._position, _unitcar._heading);
                            _ped_unit = new Ped(_unitped._modelname, _unitped._position, _unitped._heading);
                            _veh_unit.IsPersistent = true;
                            _veh_unit.IsEngineOn = true;
                            _veh_unit.IsSirenOn = true;
                            _veh_unit.IsSirenSilent = true;
                            _veh_unit.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                            _ped_unit.IsPersistent = true;
                            _ped_unit.BlockPermanentEvents = true;
                            _ped_unit.WarpIntoVehicle(_veh_unit, -1);
                            statusmachine = Globals.PlayerState.TRAFFICSTOP;
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.TRAFFICSTOP:
                        #region At Trafficstop
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_unit.Position) < 30f && _unit_exit == false)
                        {
                            FiberHandler.PlayerAtTrafficstop(_ped_unit, _veh_unit, ref _talking_unit, _end_pos_id);
                            _unit_exit = true;
                        }

                        if (Game.LocalPlayer.Character.DistanceTo(_ped_unit.Position) < 2f)
                        {
                            GameHandler.ConversationTrafficStop(ref _mlog_loop5, _end_dialog_id, ref _talking_unit, _ped_unit, _end_pos_id, ref statusmachine, ref _blip_unit, ref _blip_suspect, _blip_list);
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.TALK_DRIVER:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 5f && _pursuitcreated == false && _isarrested == false)
                        {
                            SuspectHandler.ConversationTrafficStop(ref _mlog_loop5, _end_dialog_id, _ped_unit, _ped_suspect, _veh_unit, _veh_suspect, ref _blip_suspect, _blip_list, ref _pursuitcreated, ref _pursuit);
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
                //WITNESS 1
                if (_talking_witness1 == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_civ1);
                        Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._id == 4).First()._model.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                //WITNESS 2 
                if (_talking_witness2 == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_civ2);
                        Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._id == 5).First()._model.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                //WITNESS 3
                if (_talking_witness3 == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_civ3);
                        Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._id == 6).First()._model.Tasks.AchieveHeading(_faceangle);
                        _player = Game.LocalPlayer.Character.Position;
                    }
                }
                //UNIT
                if (endingvariant == Globals.CalloutEnd.ABANDON || endingvariant == Globals.CalloutEnd.TRAFFICSTOP)
                {
                    if (_talking_unit == true)
                    {
                        if (_player != Game.LocalPlayer.Character.Position)
                        {
                            float _faceangle = GameHandler.PedtoPlayerAngle(_ped_unit);
                            _ped_unit.Tasks.AchieveHeading(_faceangle);
                            _player = Game.LocalPlayer.Character.Position;
                        }
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
                    if (_talking_cop != true || _talking_witness1 != true || _talking_witness2 != true || _talking_witness3 != true)
                    {
                        Game.DisplaySubtitle(GameHandler._usernotice);
                    }
                }

                #region PursuitHanlder
                if (endingvariant == Globals.CalloutEnd.NORMAL || endingvariant == Globals.CalloutEnd.TRAFFICSTOP)
                {
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
                #endregion
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
                GameHandler.CleanUp(this, _area._calloutid, ref _pursuit, _isarrested, _speedzone, true, endingvariant);
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
                        _blip_witness01 = _ped_civ1.AttachBlip();
                        _blip_witness01.Color = System.Drawing.Color.Orange;
                        _blip_list.Add(_blip_witness01);

                        //Computer+
                        if (_cplus_active)
                        {
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Contact with officer on scene. Two Victims, one with serious injuries, possible one Witness");
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Following up with questioning witness and victim.");
                        }

                        FiberHandler.EMSLeaveArea(_veh_ems, _ped_ems);

                        _mlog_loop1 = 5;
                        break;
                    case 5:
                        GameHandler.RemoveBlip(_blip_cop, _blip_list);
                        GameHandler.PlayerChat(2, Dialog);
                        _talking_cop = false;
                        statusmachine = Globals.PlayerState.TALK_WITNESS1;
                        FiberHandler.BackToAnimation(_ped_cop, Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1)._heading, "missheist_agency3aig_24", "agent01_conversation", AnimationFlags.Loop);
                        break;

                }
            }
        }

        public void Conversation_Witness1()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 2 && t._counter == _mlog_loop2)._text;

                switch (_mlog_loop2)
                {
                    case 0:
                        _talking_witness1 = true;
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop2 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(3, Dialog);
                        _mlog_loop2 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop2 = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(3, Dialog);
                        _mlog_loop2 = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop2 = 5;
                        break;
                    case 5:
                        Random rnd_car = new Random();
                        _possible_veh = Suspects.SuspectCars[rnd_car.Next(Suspects.SuspectCars.Count)];
                        GameHandler.PlayerChat(3, Dialog + _possible_veh._modelname);
                        _mlog_loop2 = 6;
                        break;
                    case 6:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop2 = 7;
                        break;
                    case 7:
                        GameHandler.PlayerChat(3, Dialog);
                        _blip_witness02 = _ped_civ2.AttachBlip();
                        _blip_witness02.Color = System.Drawing.Color.Orange;
                        _blip_list.Add(_blip_witness02);
                        //Computer+
                        if (_cplus_active)
                        {
                            Persona _victim = Functions.GetPersonaForPed(_ped_civ1);
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Victim Name: " + _victim.FullName + ", Vehicle: " + _veh_civ1.Model.Name + ", Licence Plate: " + _veh_civ1.LicensePlate);
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Accident was hit and run, possible car model described by victimthat caused the accident: " + _veh_suspect.Model.Name);
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Going on with gathering information.");
                        }

                        _mlog_loop2 = 8;
                        break;
                    case 8:
                        GameHandler.RemoveBlip(_blip_witness01, _blip_list);
                        GameHandler.PlayerChat(3, Dialog);
                        _talking_witness1 = false;
                        statusmachine = Globals.PlayerState.TALK_WITNESS2;
                        FiberHandler.BackToAnimation(_ped_civ1, Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 4)._heading, "missmic_4premierejimwaitbef_prem", "wait_idle_b", AnimationFlags.Loop);
                        break;

                }

            }
        }

        public void Conversation_Witness2()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 3 && t._counter == _mlog_loop3)._text;

                switch (_mlog_loop3)
                {
                    case 0:
                        _talking_witness2 = true;
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop3 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(3, Dialog);
                        _mlog_loop3 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop3 = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(3, Dialog);
                        _mlog_loop3 = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop3 = 5;
                        break;
                    case 5:
                        GameHandler.PlayerChat(1, Dialog);
                        _blip_witness03 = _ped_civ3.AttachBlip();
                        _blip_witness03.Color = System.Drawing.Color.Orange;
                        _blip_list.Add(_blip_witness03);
                        //Computer+
                        if (_cplus_active)
                        {
                            Persona _victim = Functions.GetPersonaForPed(_ped_civ2);
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Victim Two Name: " + _victim.FullName + ", Vehicle: " + _veh_civ1.Model.Name + ", Licence Plate: " + _veh_civ1.LicensePlate);
                            CPlusFunctions.AddUpdateToCallout(_callout_id, "Accident is Hit and Run, no information available from second victim");
                        }
                        _mlog_loop3 = 6;
                        break;
                    case 6:
                        GameHandler.RemoveBlip(_blip_witness02, _blip_list);
                        GameHandler.PlayerChat(3, Dialog);
                        _talking_witness2 = false;
                        statusmachine = Globals.PlayerState.TALK_WITNESS3;
                        FiberHandler.BackToAnimation(_ped_civ2, Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 5)._heading, "missmic_4premierejimwaitbef_prem", "wait_idle_b", AnimationFlags.Loop);
                        break;
                }
            }
        }

        public void Conversation_Witness3()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 4 && t._counter == _mlog_loop4)._text;

                switch (_mlog_loop4)
                {
                    case 0:
                        _talking_witness3 = true;
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop4 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(3, Dialog);
                        _mlog_loop4 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog + _possible_veh._modelname);
                        _mlog_loop4 = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(3, Dialog + _possible_veh._modelname);
                        _mlog_loop4 = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop4 = 5;
                        break;
                    case 5:
                        GameHandler.PlayerChat(3, Dialog + _veh_suspect.Model.Name + " with licence plate " + _veh_suspect.LicensePlate);
                        _mlog_loop4 = 6;
                        switch (endingvariant)
                        {
                            case Globals.CalloutEnd.NORMAL:
                                SuspectHandler.GetLocation(_callout_id, _cplus_active, _veh_suspect.Model.Name, _veh_suspect.LicensePlate, _veh_suspect, _ped_suspect, _ped_civ3, _blip_suspect, _suspect_location._ped_position, SuspectData.FullName);
                                break;
                            case Globals.CalloutEnd.ABANDON:
                            case Globals.CalloutEnd.TRAFFICSTOP:
                                SuspectHandler.GetLocation(_callout_id, _cplus_active, _veh_suspect.Model.Name, _veh_suspect.LicensePlate, _veh_suspect, _ped_civ3);
                                break;
                        }
                        break;
                    case 6:
                        GameHandler.PlayerChat(1, Dialog);
                        _mlog_loop4 = 7;
                        break;
                    case 7:
                        GameHandler.RemoveBlip(_blip_witness03, _blip_list);
                        GameHandler.PlayerChat(3, Dialog);
                        _talking_witness3 = false;
                        _player_at_scene = false;
                        FiberHandler.CivCarLeaveArea(_veh_civ3, _ped_civ3);
                        switch (endingvariant)
                        {
                            case Globals.CalloutEnd.NORMAL:
                                statusmachine = Globals.PlayerState.TO_SUSPECT;
                                break;
                            case Globals.CalloutEnd.ABANDON:
                                statusmachine = Globals.PlayerState.SEARCHING;
                                break;
                            case Globals.CalloutEnd.TRAFFICSTOP:
                                statusmachine = Globals.PlayerState.TO_TRAFFICSTOP;
                                break;
                        }
                        break;

                }

            }
        }
    }
}
