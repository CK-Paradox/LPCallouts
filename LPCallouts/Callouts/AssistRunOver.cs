using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
//LPC
using LPCallouts.Externals;
using LPCallouts.Internals;
//LSPDFR
using Rage;
using Rage.Native;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Mod.Callouts;
using LSPD_First_Response.Engine.Scripting.Entities;


namespace LPCallouts.Callouts
{
    [CalloutInfo("HR_RunOver.Spawn.Low", CalloutProbability.Low)]
    class AssistRunOver_LOW : AssistRunOver
    {
    }
    [CalloutInfo("HR_RunOver.Spawn.Medium", CalloutProbability.Medium)]
    class AssistRunOver_MED : AssistRunOver
    {
    }
    [CalloutInfo("HR_RunOver.Spawn.High", CalloutProbability.High)]
    class AssistRunOver_HIGH : AssistRunOver
    {
    }

    class AssistRunOver : Callout, ISuspect
    {
        public Globals.Scenery _area;
        public Globals.SuspectLocation _suspect_location;
        public Globals.SuspectCar _suspect_veh;
        public Globals.SuspectPerson _suspect_ped;
        public Globals.SuspectDialog _suspect_conversation;

        public Globals.SuspectPositions _unitcar;
        public Globals.SuspectPositions _unitped;

        public List<Globals.SuspectLocation> _suspect_area;

        //PEDS
        public Ped _ped_suspect { get; set; }
        public Ped _ped_cop;
        public Ped _ped_civ;

        //Backup Units
        public Ped _ped_backup1;
        public Ped _ped_backup2;
        public Vehicle _veh_backup1;
        public Vehicle _veh_backup2;
        public Blip _blip_backup1;
        public Blip _blip_backup2;
        public List<Ped> _backupCops;
        public List<Vehicle> _backupCars;

        //VEHICLES
        public Vehicle _veh_suspect { get; set; }

        //VECTOR 3s
        public Vector3 _ve3_poi;
        public Vector3 _player;

        //Blips
        public Blip _blip_poi;
        public Blip _blip_cop;
        public Blip _blip_witness;
        public Blip _blip_suspect;
        public Blip _blip_area1;
        public Blip _blip_area2;
        public Blip _blip_area3;
        public List<Blip> _blip_list { get; set; }

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
        public int _selectedarea;
        public int _handover1;
        public int _handover2;
        public int _end_pos_id = 0;
        public int _end_dialog_id = 0;

        //uint
        public uint _streethash01;
        public uint _streethash02;
        public uint _streethash03;

        //bool
        public bool CalloutActive = false;
        public bool _isarrested = false;
        public bool _getintocar = false;
        public bool _selection = false;
        public bool _assist01 = false;
        public bool _assist02 = false;
        public bool _area_checked = false;
        public bool _pursuitcreated = false;
        public bool _contentisloaded = false;
        public bool _terminate = false;
        public bool _isinformed = false;

        public bool _talking_cop = false;
        public bool _talking_unit = false;
        public bool _talking_witness = false;
        public bool _talking_suspect = false;
        public bool _player_at_scene = false;
        public bool _unit_exit = false;

        public bool _arrived_at_suspect = false;

        //string
        public string _street01;
        public string _street02;
        public string _street03;

        public string _BackUpUnit01;
        public string _BackUpUnit02;

        public Persona SuspectData;

        public override bool OnBeforeCalloutDisplayed()
        {
            try
            {
                //Get Callout in Range:
                Vector3 CurrentPlayerPosition = Game.LocalPlayer.Character.Position;
                List<Globals.Scenery> CalloutsInRange = Content.CalloutLocations.Where(t => t._type == Globals.CalloutType.RunOver && t._poi.DistanceTo(CurrentPlayerPosition) <= GameHandler.ini_radius).ToList();

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

            }
            return base.OnBeforeCalloutDisplayed();
        }

        public override bool OnCalloutAccepted()
        {
            _blip_list = new List<Blip>();
            statusmachine = Globals.PlayerState.CALLED;
            // Updates the callout's status to "Unit Responding" when the player accepts


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
                    _blip_poi.Color = Color.LightBlue;
                    _blip_poi.EnableRoute(Color.LightBlue);
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
                            SuspectHandler.GenerateSuspect(this, ref _suspect_veh, ref _suspect_ped, ref _suspect_location, ref _suspect_conversation, _area._region, Globals.CalloutType._Default, ref _suspect_area);
                        }
                        catch
                        {
                            ErrorHandler.LogMessage(this.GetType().Name + " Suspect vehicle could not be placed", 004);
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

                        #region streetnames
                        try
                        {
                            _streethash01 = World.GetStreetHash(_suspect_area[0]._ped_position);
                            _street01 = World.GetStreetName(_streethash01);

                            _streethash02 = World.GetStreetHash(_suspect_area[1]._ped_position);
                            _street02 = World.GetStreetName(_streethash02);

                            _streethash03 = World.GetStreetHash(_suspect_area[2]._ped_position);
                            _street03 = World.GetStreetName(_streethash03);
                        }
                        catch
                        {
                            ErrorHandler.LogMessage(this.GetType().Name + " Streetnames could not be loaded", 305);
                        }
                        #endregion streetnames

                        #region area spawn blips
                        try
                        {
                            _blip_area1 = new Blip(_suspect_area[0]._ped_position, 30f);
                            _blip_area1.Alpha = 0.0f;
                            _blip_area1.Color = Color.Green;
                            _blip_list.Add(_blip_area1);

                            _blip_area2 = new Blip(_suspect_area[1]._ped_position, 30f);
                            _blip_area2.Alpha = 0.0f;
                            _blip_area2.Color = Color.Purple;
                            _blip_list.Add(_blip_area2);

                            _blip_area3 = new Blip(_suspect_area[2]._ped_position, 30f);
                            _blip_area3.Alpha = 0.0f;
                            _blip_area3.Color = Color.Yellow;
                            _blip_list.Add(_blip_area3);
                        }
                        catch
                        {
                            ErrorHandler.LogMessage(this.GetType().Name + " Blips could not be created", 004);
                        }
                        #endregion spawn blips

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

                _BackUpUnit01 = GameHandler.ini_division_1 + "-" + GameHandler.ini_unittype_1 + "-" + GameHandler.ini_beat_1;
                _BackUpUnit02 = GameHandler.ini_division_2 + "-" + GameHandler.ini_unittype_2 + "-" + GameHandler.ini_beat_2;


                switch (statusmachine)
                {
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
                                        newcar._model.IsSirenOn = true;
                                        newcar._model.IsSirenSilent = true;
                                        newcar._model.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
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
                                ErrorHandler.LogMessage(this.GetType().Name + " Cop models could not be loaded", 010);
                            }
                            statusmachine = Globals.PlayerState.ONROUTE;
                        }
                        #endregion
                        break;
                    //VALUE = 0 -> ONROUTE THE FIRST TIME
                    case Globals.PlayerState.ONROUTE:

                        _ped_cop = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1)._model;
                        _ped_civ = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 5)._model;

                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) < 50f)
                        {
                            Game.DisplaySubtitle("Talk to the officer and witnesses by pressing ~o~'" + GameHandler.ini_action.ToString() + "'~w~ to gain information about the accident.", GameHandler.ini_displaytime);
                            GameHandler.RemoveBlip(_blip_poi, _blip_list);
                            _blip_cop = _ped_cop.AttachBlip();
                            _blip_cop.Color = Color.Blue;
                            _blip_list.Add(_blip_cop);

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
                    //VALUE = 2 -> ARRIVED AT SCENE -> CONVERSATION WITNESSES 1 AND SELECTION
                    case Globals.PlayerState.TALK_WITNESS1:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_civ.Position) < 2f)
                        {
                            Conversation_Witness();
                        }
                        break;
                    case Globals.PlayerState.WAIT_FOR_USERINPUT:
                        if (_selection == true)
                        {
                            #region Player pressed 1
                            if (Rage.Game.IsKeyDown(Keys.NumPad1))
                            {
                                _player_at_scene = false;
                                _selection = false;
                                _selectedarea = 0;
                                Game.DisplaySubtitle("You are heading to ~g~" + _street01, GameHandler.ini_displaytime);
                                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ Dispatch, Heading to ~g~" + _street01);
                                _blip_area1.EnableRoute(System.Drawing.Color.LightBlue);

                                SendBackUp(1, 2);
                                _handover1 = 1;
                                _handover2 = 2;
                                if (_suspect_area[0]._ped_position == _suspect_location._ped_position)
                                    statusmachine = Globals.PlayerState.SELECTION_PLAYER;
                                else
                                    statusmachine = Globals.PlayerState.SELECTION_AI;
                            }
                            #endregion Player pressed 1

                            #region Player pressed 2
                            if (Rage.Game.IsKeyDown(Keys.NumPad2))
                            {
                                _player_at_scene = false;
                                _selection = false;
                                _selectedarea = 1;
                                Game.DisplaySubtitle("You are heading to ~p~" + _street02, GameHandler.ini_displaytime);
                                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ Dispatch, 10-76 to ~p~" + _street02);
                                _blip_area2.EnableRoute(System.Drawing.Color.LightBlue);

                                SendBackUp(0, 2);
                                _handover1 = 0;
                                _handover2 = 2;
                                if (_suspect_area[1]._ped_position == _suspect_location._ped_position)
                                    statusmachine = Globals.PlayerState.SELECTION_PLAYER;
                                else
                                    statusmachine = Globals.PlayerState.SELECTION_AI;
                            }
                            #endregion Player pressed 2

                            #region Player pressed 3
                            if (Rage.Game.IsKeyDown(Keys.NumPad3))
                            {
                                _player_at_scene = false;
                                _selection = false;
                                _selectedarea = 2;
                                Game.DisplaySubtitle("You are heading to ~y~" + _street03, GameHandler.ini_displaytime);
                                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ Dispatch, 10-76 to ~y~" + _street03);
                                _blip_area3.EnableRoute(System.Drawing.Color.LightBlue);

                                SendBackUp(0, 1);
                                _handover1 = 0;
                                _handover2 = 1;
                                if (_suspect_area[2]._ped_position == _suspect_location._ped_position)
                                    statusmachine = Globals.PlayerState.SELECTION_PLAYER;
                                else
                                    statusmachine = Globals.PlayerState.SELECTION_AI;
                            }
                            #endregion Player pressed 3
                        }
                        break;
                    //VALUE = 3 -> PLAYER TO AREA WITH SUSPECT
                    case Globals.PlayerState.SELECTION_PLAYER:
                        //Terminate AI One if at area or triggered by player
                        #region terminate AI one
                        if (_assist01 == true)
                        {
                            if (_veh_backup1.DistanceTo(_suspect_area[_handover1]._ped_position) < 90f || _terminate == true)
                            {
                                TerminateAI(1, _handover1, ref _assist01, _terminate, ref _blip_backup1, _ped_backup1, _veh_backup1);
                            }
                        }
                        #endregion terminate AI one
                        //Terminate AI Two if at area or triggered by player
                        #region terminate AI two
                        if (_assist02 == true)
                        {
                            if (_veh_backup2.DistanceTo(_suspect_area[_handover2]._ped_position) < 90f || _terminate == true)
                            {
                                TerminateAI(2, _handover2, ref _assist02, _terminate, ref _blip_backup2, _ped_backup2, _veh_backup2);
                            }
                        }
                        #endregion terminate AI two
                        //IF Player is at suspect location, remove area blip an terminate AI
                        #region player at suspect
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 30f)
                        {
                            if (_terminate == false)
                            {
                                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ Dispatch, 10-23, I will make contact with the person");
                                _terminate = true;
                                switch (_selectedarea)
                                {
                                    case 0:
                                        if (_blip_area1.Exists()) { _blip_area1.Delete(); }
                                        break;
                                    case 1:
                                        if (_blip_area2.Exists()) { _blip_area2.Delete(); }
                                        break;
                                    case 2:
                                        if (_blip_area3.Exists()) { _blip_area3.Delete(); }
                                        break;
                                }
                                //ENABLE SUSPECT BLIP
                                if (_blip_suspect.Exists())
                                {
                                    _blip_suspect.Alpha = 1f;
                                }
                                else
                                {
                                    _blip_suspect = _ped_suspect.AttachBlip();
                                    _blip_suspect.Color = System.Drawing.Color.Red;
                                    _blip_suspect.Alpha = 1f;
                                }

                                GameFiber.StartNew(delegate
                                {
                                    GameFiber.Wait(3000);
                                    statusmachine = Globals.PlayerState.TO_SUSPECT;
                                    GameHandler.DispatchMessage("10-4.");
                                    Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_01 PROCEED_WITH_CAUTION_ASSORTED");
                                }, FiberHandler._fiber_request);
                            }
                        }
                        #endregion player at suspect
                        break;
                    //VALUE = 4 -> SUSPECT INSIGHT OF PLAYER
                    case Globals.PlayerState.SELECTION_AI:
                        //AI ONE AT SUSPECT LOCATION
                        #region AI one at suspect, terminate AI two and Player
                        if (_assist01 == true)
                        {
                            if (_veh_backup1.DistanceTo(_suspect_area[_handover1]._ped_position) < 90f && _suspect_location._ped_position == _suspect_area[_handover1]._ped_position)
                            {
                                _assist01 = false;
                                _terminate = true;
                                Game.DisplayNotification("~b~" +_BackUpUnit01+ "~w~ Dispatch, we're at the residence. Possible suspect located.");
                                Functions.PlayScannerAudio("REPORT_SUSPECT_SPOTTED_01");

                                _veh_backup1.SetPositionWithSnap(_suspect_area[_handover1]._police_position);
                                _veh_backup1.Heading = _suspect_area[_handover1]._police_heading;
                                _veh_backup1.IsSirenOn = false;
                                if (_assist02 == true)
                                    TerminateAI(2, _handover2, ref _assist02, _terminate, ref _blip_backup2, _ped_backup2, _veh_backup2);
                            }
                            else if (_veh_backup1.DistanceTo(_suspect_area[_handover1]._ped_position) < 90f)
                            {
                                TerminateAI(1, _handover1, ref _assist01, _terminate, ref _blip_backup1, _ped_backup1, _veh_backup1);
                            }
                        }
                        #endregion
                        //AI TWO AT SUSPECT LOCAITON
                        #region AI two at suspect, terminate AI one and Player
                        if (_assist02 == true)
                        {
                            if (_veh_backup2.DistanceTo(_suspect_area[_handover2]._ped_position) < 90f && _suspect_location._ped_position == _suspect_area[_handover2]._ped_position)
                            {
                                _assist02 = false;
                                _terminate = true;
                                Game.DisplayNotification("~b~" + _BackUpUnit02 + "~w~ Dispatch, we're at the residence. Possible suspect located.");
                                Functions.PlayScannerAudio("REPORT_SUSPECT_SPOTTED_01");

                                _veh_backup2.SetPositionWithSnap(_suspect_area[_handover2]._police_position);
                                _veh_backup2.Heading = _suspect_area[_handover2]._police_heading;
                                _veh_backup2.IsSirenOn = false;
                                if (_assist01 == true)
                                    TerminateAI(1, _handover1, ref _assist01, _terminate, ref _blip_backup1, _ped_backup1, _veh_backup1);
                            }
                            else if (_veh_backup2.DistanceTo(_suspect_area[_handover2]._ped_position) < 90f)
                            {
                                TerminateAI(2, _handover2, ref _assist02, _terminate, ref _blip_backup2, _ped_backup2, _veh_backup2);
                            }
                        }
                        #endregion
                        //PLAYER AT LOCATION -> NO SUSPECT
                        #region player at location with no suspect
                        if (Game.LocalPlayer.Character.DistanceTo(_suspect_area[_selectedarea]._ped_position) < 20f && _area_checked == false && _terminate == false)
                        {
                            _area_checked = true;
                            switch (_selectedarea)
                            {
                                case 0:
                                    GameHandler.RemoveBlip(_blip_area1, _blip_list);
                                    break;
                                case 1:
                                    GameHandler.RemoveBlip(_blip_area2, _blip_list);
                                    break;
                                case 2:
                                    GameHandler.RemoveBlip(_blip_area3, _blip_list);
                                    break;
                            }
                            GameFiber.StartNew(delegate
                            {
                                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ Dispatch, nobody is home or i'm at the wrong adress.");
                                Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_04");
                                GameHandler.DispatchMessage("10-4, wait for further instructions.");
                            }, FiberHandler._fiber_request);
                        }
                        #endregion player at location with no suspect
                        //Termination of player
                        #region terminate player on route
                        if (_terminate == true)
                        {
                            _area_checked = true;
                            GameHandler.RemoveBlip(_blip_area1, _blip_list);
                            GameHandler.RemoveBlip(_blip_area2, _blip_list);
                            GameHandler.RemoveBlip(_blip_area3, _blip_list);
                            //ENABLE SUSPECT BLIP
                            if (_blip_suspect.Exists())
                            {
                                _blip_suspect.Alpha = 1f;
                            }
                            else
                            {
                                _blip_suspect = _ped_suspect.AttachBlip();
                                _blip_suspect.Color = System.Drawing.Color.Red;
                                _blip_suspect.Alpha = 1f;
                            }
                            GameHandler.DispatchMessage(GameHandler.ini_division_p + "-" + GameHandler.ini_unittype_p + "-" + GameHandler.ini_beat_p + " Suspect located. Respond Code 3");
                            _blip_suspect.EnableRoute(Color.Red);
                            statusmachine = Globals.PlayerState.TO_SUSPECT;
                        }
                        #endregion terminate player onn route
                        break;
                    //VALUE 5 =  -> PLAYER AT SUSPECT LOCATION
                    case Globals.PlayerState.TO_SUSPECT:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 30f && _arrived_at_suspect == false)
                        {
                            _arrived_at_suspect = true;
                        }

                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 5f && _pursuitcreated == false && _getintocar == false)
                        {
                            SuspectHandler.Conversation(_ped_suspect, _blip_suspect, ref _pursuit, _suspect_conversation, _pursuitcreated, ref _mlog_loop3, ref _talking_suspect);
                        }

                        if (Game.LocalPlayer.Character.LastVehicle.Exists() && _veh_suspect.Exists())
                        {
                            if (suspectending == Globals.PursuitEnd.PURSUIT && _pursuitcreated == false && _isarrested == false && _getintocar == false && Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 100f && Game.LocalPlayer.Character.LastVehicle.IsSirenOn && !Game.LocalPlayer.Character.LastVehicle.IsSirenSilent)
                            {
                                Game.DisplaySubtitle("Suspect had heard your sirens and is fleeing their home.", GameHandler.ini_displaytime);
                                _ped_suspect.Tasks.ClearImmediately();
                                _ped_suspect.Tasks.EnterVehicle(_veh_suspect, 10000, -2);
                                _getintocar = true;
                                GameFiber.Wait(12000);

                                _blip_suspect.Alpha = 1.0f;
                                _blip_suspect.IsFriendly = false;
                                _pursuit = Functions.CreatePursuit();
                                _ped_suspect.Tasks.CruiseWithVehicle(_veh_suspect, 30f, VehicleDrivingFlags.Emergency);
                                Functions.AddCopToPursuit(_pursuit, _ped_suspect);
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
                            _veh_backup1 = new Vehicle(_unitcar._modelname, _unitcar._position, _unitcar._heading);
                            _ped_backup1 = new Ped(_unitped._modelname, _unitped._position, _unitped._heading);
                            _veh_backup1.IsPersistent = true;
                            _veh_backup1.IsEngineOn = true;
                            _veh_backup1.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                            _ped_backup1.IsPersistent = true;
                            _ped_backup1.BlockPermanentEvents = true;
                            _ped_backup1.Tasks.PlayAnimation("amb@code_human_police_investigate@idle_a", "idle_b", 1f, AnimationFlags.Loop);
                            _blip_backup1 = _ped_backup1.AttachBlip();
                            _blip_backup1.Color = Color.Blue;
                            _blip_backup1.Alpha = 1.0f;
                            _blip_list.Add(_blip_backup1);
                            GameHandler.RemoveBlip(_blip_suspect, _blip_list);
                            statusmachine = Globals.PlayerState.NEAR_SCENERY;
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.NEAR_SCENERY:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_backup1.Position) < 2f)
                        {
                            GameHandler.ConversationAbandon(ref _mlog_loop3, _end_dialog_id, ref _talking_unit, _ped_backup1, _veh_backup1, ref _blip_backup1, _blip_list);
                        }
                        break;
                    //TRAFFICSTOP
                    case Globals.PlayerState.TO_TRAFFICSTOP:
                        #region Drive to Trafficstop
                        if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) > GameHandler._driveoffdistance)
                        {
                            if (_isinformed == false)
                            {
                                FiberHandler.PlayerToTrafficstop(ref _blip_backup1, _blip_list, _unitped._position);
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
                            _veh_backup1 = new Vehicle(_unitcar._modelname, _unitcar._position, _unitcar._heading);
                            _ped_backup1 = new Ped(_unitped._modelname, _unitped._position, _unitped._heading);
                            _veh_backup1.IsPersistent = true;
                            _veh_backup1.IsEngineOn = true;
                            _veh_backup1.IsSirenOn = true;
                            _veh_backup1.IsSirenSilent = true;
                            _veh_backup1.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Both;
                            _ped_backup1.IsPersistent = true;
                            _ped_backup1.BlockPermanentEvents = true;
                            _ped_backup1.WarpIntoVehicle(_veh_backup1, -1);
                            statusmachine = Globals.PlayerState.TRAFFICSTOP;
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.TRAFFICSTOP:
                        #region At Trafficstop
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_backup1.Position) < 30f && _unit_exit == false)
                        {
                            FiberHandler.PlayerAtTrafficstop(_ped_backup1, _veh_backup1, ref _talking_unit, _end_pos_id);
                            _unit_exit = true;
                        }

                        if (Game.LocalPlayer.Character.DistanceTo(_ped_backup1.Position) < 2f)
                        {
                            GameHandler.ConversationTrafficStop(ref _mlog_loop3, _end_dialog_id, ref _talking_unit, _ped_backup1, _end_pos_id, ref statusmachine, ref _blip_backup1, ref _blip_suspect, _blip_list);
                        }
                        #endregion
                        break;
                    case Globals.PlayerState.TALK_DRIVER:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_suspect.Position) < 5f && _pursuitcreated == false && _isarrested == false)
                        {
                            SuspectHandler.ConversationTrafficStop(ref _mlog_loop3, _end_dialog_id, _ped_backup1, _ped_suspect, _veh_backup1, _veh_suspect, ref _blip_suspect, _blip_list, ref _pursuitcreated, ref _pursuit);
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
                //WITNESS
                if (_talking_witness == true)
                {
                    if (_player != Game.LocalPlayer.Character.Position)
                    {
                        float _faceangle = GameHandler.PedtoPlayerAngle(_ped_civ);
                        Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._id == 5).First()._model.Tasks.AchieveHeading(_faceangle);
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

                //UNIT
                if (endingvariant == Globals.CalloutEnd.ABANDON || endingvariant == Globals.CalloutEnd.TRAFFICSTOP)
                {
                    if (_talking_unit == true)
                    {
                        if (_player != Game.LocalPlayer.Character.Position)
                        {
                            float _faceangle = GameHandler.PedtoPlayerAngle(_ped_backup1);
                            _ped_backup1.Tasks.AchieveHeading(_faceangle);
                            _player = Game.LocalPlayer.Character.Position;
                        }
                    }
                }

                #endregion angle control

                #region PlayerNotice Conversation not finished
                if (_player_at_scene == true && Game.LocalPlayer.Character.DistanceTo(_ve3_poi) > 150f)
                {
                    if (_talking_cop != true || _talking_witness != true)
                    {
                        Game.DisplaySubtitle(GameHandler._usernotice);
                    }
                }
                #endregion

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
                switch (endingvariant)
                {
                    case Globals.CalloutEnd.NORMAL:
                        foreach (var item in _backupCars)
                        {
                            if (item.Exists())
                            {
                                item.IsPersistent = false;
                                item.Dismiss();
                                item.IsSirenOn = false;
                                item.IsSirenSilent = false;
                            }
                        }

                        foreach (var item in _backupCops)
                        {
                            if (item.Exists())
                            {
                                item.IsPersistent = false;
                                item.Dismiss();
                            }
                        }
                        GameHandler.CleanUp(this, _area._calloutid, ref _pursuit, _isarrested, _speedzone);
                        break;
                    case Globals.CalloutEnd.ABANDON:
                    case Globals.CalloutEnd.TRAFFICSTOP:
                        GameHandler.CleanUp(this, _area._calloutid, ref _pursuit, _isarrested, _speedzone, true, endingvariant);
                        break;
                }
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
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop1 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(2, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop1 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop1 = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(2, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop1 = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _blip_witness = _ped_civ.AttachBlip();
                        _blip_witness.Color = System.Drawing.Color.Orange;
                        _blip_list.Add(_blip_witness);

                        _mlog_loop1 = 5;
                        break;
                    case 5:
                        GameHandler.RemoveBlip(_blip_cop, _blip_list);
                        GameHandler.PlayerChat(2, Dialog, GameHandler.ini_displaytime);
                        _talking_cop = false;
                        Globals.Humans _endcop = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1);
                        FiberHandler.BackToAnimation(_ped_cop, _endcop._heading, _endcop._animdir, _endcop._animname, _endcop._animflag);
                        statusmachine = Globals.PlayerState.TALK_WITNESS1;
                        break;
                }
            }
        }

        public void Conversation_Witness()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 2 && t._counter == _mlog_loop2)._text;

                switch (_mlog_loop2)
                {
                    case 0:
                        _talking_witness = true;
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop2 = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(3, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop2 = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime); ;
                        _mlog_loop2 = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(3, "A ~y~" + _veh_suspect.Model.Name + Dialog, GameHandler.ini_displaytime);
                        _mlog_loop2 = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop2 = 5;
                        break;
                    case 5:
                        string _car_plate = _veh_suspect.LicensePlate.Remove(1, 5);
                        GameHandler.PlayerChat(3, Dialog + _car_plate, GameHandler.ini_displaytime);
                        _mlog_loop2 = 6;
                        switch (endingvariant)
                        {
                            case Globals.CalloutEnd.NORMAL:
                                SuspectHandler.GetLocation(_veh_suspect.Model.Name, _car_plate, _ped_civ, _blip_area1, _blip_area2, _blip_area3, _street01, _street02, _street03);
                                break;
                            case Globals.CalloutEnd.ABANDON:
                            case Globals.CalloutEnd.TRAFFICSTOP:
                                SuspectHandler.GetLocation(_veh_suspect.Model.Name, _veh_suspect.LicensePlate, _veh_suspect, _ped_civ);
                                break;
                        }
                        break;
                    case 6:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mlog_loop2 = 7;
                        break;
                    case 7:
                        GameHandler.PlayerChat(3, Dialog, GameHandler.ini_displaytime);
                        GameHandler.RemoveBlip(_blip_witness, _blip_list);
                        _mlog_loop2 = 8;
                        break;
                    case 8:
                        GameHandler.PlayerChat(3, Dialog, GameHandler.ini_displaytime);
                        FiberHandler.PedLeaveArea(_ped_civ);
                        _talking_witness = false;
                        _player_at_scene = false;
                        switch (endingvariant)
                        {
                            case Globals.CalloutEnd.NORMAL:
                                _selection = true;
                                statusmachine = Globals.PlayerState.WAIT_FOR_USERINPUT;
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

        public void SendBackUp(int area1, int area2)
        {
            GameFiber.StartNew(delegate
            {
                    #region spawn assistance
                    try
                {
                    _veh_backup1 = new Vehicle(_suspect_area[area1]._backup_veh_model, _suspect_area[area1]._backup_position, _suspect_area[area1]._backup_heading);
                    _veh_backup1.IsPersistent = true;
                    _veh_backup1.IsEngineOn = true;
                    _veh_backup1.IsVisible = true;

                    _veh_backup2 = new Vehicle(_suspect_area[area2]._backup_veh_model, _suspect_area[area2]._backup_position, _suspect_area[area2]._backup_heading);
                    _veh_backup2.IsPersistent = true;
                    _veh_backup2.IsEngineOn = true;
                    _veh_backup2.IsVisible = true;

                    _backupCars = new List<Vehicle> { _veh_backup1, _veh_backup2 };

                    _ped_backup1 = new Ped(_suspect_area[area1]._backup_ped_model, _veh_backup1.Position, 0f);
                    _ped_backup1.IsPersistent = true;
                    _ped_backup1.IsVisible = true;
                    _ped_backup1.WarpIntoVehicle(_veh_backup1, -1);

                    _ped_backup2 = new Ped(_suspect_area[area2]._backup_ped_model, _veh_backup2.Position, 0f);
                    _ped_backup2.IsPersistent = true;
                    _ped_backup2.IsVisible = true;
                    _ped_backup2.WarpIntoVehicle(_veh_backup2, -1);

                    _backupCops = new List<Ped> { _ped_backup1, _ped_backup1 };

                    _blip_backup1 = _veh_backup1.AttachBlip();
                    _blip_backup1.Alpha = 0.0f;
                    _blip_backup1.Color = Color.Blue;
                    _blip_list.Add(_blip_backup1);

                    _blip_backup2 = _veh_backup2.AttachBlip();
                    _blip_backup2.Alpha = 0.0f;
                    _blip_backup2.Color = Color.Blue;
                    _blip_list.Add(_blip_backup2);
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Assistant Cops could not be loaded", 009);
                }

                Functions.SetPedAsCop(_ped_backup1);
                Functions.SetPedAsCop(_ped_backup2);
                _ped_backup1.RelationshipGroup = "COP";
                _ped_backup2.RelationshipGroup = "COP";

                    #endregion spawn assistance

                    GameFiber.Wait(200);

                _veh_backup1.IsSirenOn = true;
                _veh_backup1.IsSirenSilent = true;
                _assist01 = true;
                Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_04");
                GameHandler.DispatchMessage("10-24 , sending additional units to the other locations.");
                GameFiber.Wait(3000);
                Functions.PlayScannerAudio("DISP_ATTENTION_UNIT_01 DIV_" + GameHandler.ini_division_1 + " " + GameHandler.ini_unittype_1 + " BEAT_" + GameHandler.ini_beat_1 + " ASSISTANCE_REQUIRED_02");
                _blip_backup1.Alpha = 1.0f;

                NativeFunction.CallByName<uint>("TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE", _ped_backup1, _veh_backup1, _suspect_area[area1]._police_position.X, _suspect_area[area1]._police_position.Y, _suspect_area[area1]._police_position.Z, 25f, 1, 1074528293, 2f);
                GameFiber.Wait(6000);
                Functions.PlayScannerAudio("LPC_BACKUP_01");

                _veh_backup2.IsSirenOn = true;
                _veh_backup2.IsSirenSilent = true;
                _assist02 = true;
                GameFiber.Wait(5000);
                Functions.PlayScannerAudio("DISP_ATTENTION_UNIT_02 DIV_" + GameHandler.ini_division_2 + " " + GameHandler.ini_unittype_2 + " BEAT_" + GameHandler.ini_beat_2 + " ASSISTANCE_REQUIRED_04");
                _blip_backup2.Alpha = 1.0f;

                NativeFunction.CallByName<uint>("TASK_VEHICLE_DRIVE_TO_COORD_LONGRANGE", _ped_backup2, _veh_backup2, _suspect_area[area2]._police_position.X, _suspect_area[area2]._police_position.Y, _suspect_area[area2]._police_position.Z, 25f, 1, 1074528293, 2f);
                GameFiber.Wait(6000);
                Functions.PlayScannerAudio("LPC_BACKUP_02");
            }, FiberHandler._fiber_backup);
        }

        public void TerminateAI(int unit, int area, ref bool assist, bool terminate, ref Blip blip_unit, Ped ped_unit, Vehicle veh_unit)
        {
            assist = false;
            veh_unit.IsPersistent = false;
            ped_unit.IsPersistent = false;
            veh_unit.Dismiss();
            ped_unit.Dismiss();

            switch (area)
            {
                case 0:
                    GameHandler.RemoveBlip(_blip_area1, _blip_list);
                    break;
                case 1:
                    GameHandler.RemoveBlip(_blip_area2, _blip_list);
                    break;
                case 2:
                    GameHandler.RemoveBlip(_blip_area3, _blip_list);
                    break;
            }

            GameHandler.RemoveBlip(blip_unit, _blip_list);
            GameFiber.StartNew(delegate
            {
                switch (unit)
                {
                    case 1:
                        if (terminate == true)
                        {
                            Functions.PlayScannerAudio("NO_FURTHER_UNITS_REQUIRED PROCEED_WITH_PATROL");
                        }
                        else
                        {
                            Game.DisplayNotification("~b~" + _BackUpUnit01 + "~w~ Dispatch, 10-23, No match, 10-19 returning to patrol");
                            GameFiber.Wait(3000);
                            Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_01 DIV_" + GameHandler.ini_division_1 + " " + GameHandler.ini_unittype_1 + " BEAT_" + GameHandler.ini_beat_1 + " PROCEED_WITH_PATROL");
                        }
                        break;
                    case 2:
                        if (terminate == true)
                        {
                            Functions.PlayScannerAudio("NO_FURTHER_UNITS_REQUIRED PROCEED_WITH_PATROL");
                        }
                        else
                        {
                            Game.DisplayNotification("~b~" + _BackUpUnit02 + "~w~ Dispatch, 10-23, No match, 10-19 returning to patrol");
                            GameFiber.Wait(3000);
                            Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_02 DIV_" + GameHandler.ini_division_2 + " " + GameHandler.ini_unittype_2 + " BEAT_" + GameHandler.ini_beat_2 + " PROCEED_WITH_PATROL");
                        }
                        break;
                }
            }, FiberHandler._fiber_request);
        }
    }
}

