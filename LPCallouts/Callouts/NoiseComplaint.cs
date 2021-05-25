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
//External
using Un4seen.Bass;


namespace LPCallouts.Callouts
{
    [CalloutInfo("NoiseComplaint.Spawn.Low", CalloutProbability.Low)]
    class NoiseComplaint_LOW : NoiseComplaint
    {
    }
    [CalloutInfo("NoiseComplaint.Spawn.Medium", CalloutProbability.Medium)]
    class NoiseComplaint_MED : NoiseComplaint
    {
    }
    [CalloutInfo("NoiseComplaint.Spawn.High", CalloutProbability.High)]
    class NoiseComplaint_HIGH : NoiseComplaint
    {
    }

    class NoiseComplaint : Callout
    {
        public Globals.Scenery _area;
        public Globals.Dialogs _dialog;
        public List<Globals.Positions> _waypoints;

        //Peds
        public Ped _ped_caller;
        public Ped _ped_owner;

        //VECTOR 3s
        public Vector3 _ve3_poi;
        public Vector3 _player;

        //Blips
        public Blip _blip_caller;
        public Blip _blip_owner;
        public Blip _blip_bell;
        public Blip _blip_talk;
        public Blip _blip_area;
        public List<Blip> _blip_list;

        //Handles
        public LHandle _pursuit;

        public Globals.PlayerState statusmachine;
        public Globals.DisturbanceEnd ownerending;
        public Globals.PursuitEnd suspectending;

        //Int
        public int _mloop_caller = 0;
        public int _mloop_owner = 0;
        public int _audio_music;
        public int _audio_ambient;
        public int _audio_doorbell;
        public int _audio_music_control = 20;

        //bool
        public bool _isarrested = false;
        public bool _contentisloaded = false;
        public bool _marker_bell = false;
        public bool _marker_talk = false;
        public bool _marker_music = false;
        public bool _playmusic = false;
        public bool _playambient = false;
        public bool _freezeposition = false;
        public bool _owner_to_player = false;
        public bool _owner_to_volume = false;
        public bool _talking_caller = false;
        public bool _pursuitcreated = false;

        public bool _arrived_at_caller = false;

        public override bool OnBeforeCalloutDisplayed()
        {
            //Get Callout in Range:
            Vector3 CurrentPlayerPosition = Game.LocalPlayer.Character.Position;
            List<Globals.Scenery> CalloutsInRange = Content.CalloutLocations.Where(t => t._type == Globals.CalloutType.Disturbance && t._poi.DistanceTo(CurrentPlayerPosition) <= GameHandler.ini_radius).ToList();

            //Get Random Callout from List in range, otherwise terminate
            if (CalloutsInRange.Count != 0)
            {
                if (Main._nc_rerun == false || Main._nc_id == 0)
                {
                    _area = CalloutsInRange.ElementAt(Main.LPCRandom.Next(CalloutsInRange.Count()));
                    statusmachine = Globals.PlayerState.ONROUTE;
                }
                else
                {
                    _area = Content.CalloutLocations.First(t => t._calloutid == Main._nc_id);
                    statusmachine = Globals.PlayerState.RERUN;
                }
                _ve3_poi = _area._poi;
                Main._nc_id = _area._calloutid;
                _dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid);
                _waypoints = Content.PositionList.Where(t => t._calloutid == _area._calloutid).ToList();
            }
            else
            {
                return false;
            }

            if (Game.LocalPlayer.Character.DistanceTo(_ve3_poi) < GameHandler._minimumdistance || Game.LocalPlayer.Character.DistanceTo(_ve3_poi) > GameHandler.ini_radius)
            {
                return false;
            }
            else
            {
                AddMinimumDistanceCheck(20f, _ve3_poi);
                ShowCalloutAreaBlipBeforeAccepting(_ve3_poi, 50f);

                CalloutMessage = "Disturbance";
                CalloutPosition = _ve3_poi;

                GameHandler.DispatchAudio(_area._area, 2);

                return base.OnBeforeCalloutDisplayed();
            }
        }

        public override void OnCalloutDisplayed()
        {
            // Updates the callout's status to "Dispatched" when the player sees the callout on screen

            base.OnCalloutDisplayed();
        }

        public override bool OnCalloutAccepted()
        {

            _blip_list = new List<Blip>();
            // Updates the callout's status to "Unit Responding" when the player accepts


            Vector3 Bell = _waypoints.First(t => t._type == Globals.PositionType.DOORBELL)._position;

            NativeFunction.CallByName<ulong>("CLEAR_AREA_OF_PEDS", Bell.X, Bell.Y, Bell.Y, 10f, 1);
            NativeFunction.CallByName<ulong>("CLEAR_AREA_OF_VEHICLES", Bell.X, Bell.Y, Bell.Y, 20f, false, false, false, false, false);

            if (Main._nc_rerun == false || Main._nc_id == 0)
            {
                GameHandler.DispatchMessage("Caller is waiting at " + _area._street + ".");
            }
            else
            {
                GameFiber.StartNew(delegate
                {
                    GameHandler.DispatchMessage("Location " + _area._street + ". It should be the party from before.");
                    GameFiber.Wait(2000);
                    Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ 10-4. I will take care about this.");
                    GameFiber.Wait(2000);
                    GameHandler.DispatchMessage("10-4.");
                    Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_01 PROCEED_WITH_CAUTION_ASSORTED");
                }, FiberHandler._fiber_request);
            }

            GameFiber.StartNew(delegate
            {
                #region spawn blips
                try
                {
                    if (Main._nc_rerun == false || Main._nc_id == 0)
                    {
                        _blip_caller = new Blip(Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1)._position);
                        _blip_caller.Color = System.Drawing.Color.LightBlue;
                        _blip_caller.EnableRoute(System.Drawing.Color.LightBlue);
                        _blip_list.Add(_blip_caller);
                    }
                    else
                    {
                        _blip_area = new Blip(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position);
                        _blip_area.Color = System.Drawing.Color.Aqua;
                        _blip_area.EnableRoute(System.Drawing.Color.LightBlue);
                        _blip_list.Add(_blip_area);
                    }
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Blips could not be created", 004);
                }
                #endregion spawn blips

                #region spawn objects
                //SPAWN OBJECTS
                try
                {
                    foreach (Globals.Objects newobject in Content.ObjectList.Where(t => t._calloutid == _area._calloutid))
                    {
                        newobject._model = new Rage.Object(newobject._modelname, newobject._position, newobject._heading);
                        newobject._model.IsPositionFrozen = true;
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
                    List<string> _bottles = new List<string> { "prop_cs_beer_bot_01", "prop_sh_beer_pissh_01" };
                    foreach (Globals.Humans newped in Content.HumanList.Where(t => t._calloutid == _area._calloutid && (t._type == Globals.HumanType.CIVILIAN || t._type == Globals.HumanType.CALLER || t._type == Globals.HumanType.OWNER)))
                    {
                        newped._model = new Rage.Ped(newped._modelname, newped._position, newped._heading);
                        newped._model.IsPersistent = true;
                        newped._model.BlockPermanentEvents = true;
                        newped._model.RelationshipGroup = "CIVMALE";
                        if (!string.IsNullOrEmpty(newped._animname))
                        {
                            switch (newped._type)
                            {
                                case Globals.HumanType.CALLER:
                                case Globals.HumanType.OWNER:
                                    newped._model.Tasks.PlayAnimation(newped._animdir, newped._animname, 1f, newped._animflag);
                                    break;
                                case Globals.HumanType.OWNER_IN:
                                case Globals.HumanType.OWNER_OUT:
                                    break;
                                default:
                                    try
                                    {
                                        Random rnd = new Random(Environment.TickCount);
                                        string beer = _bottles.OrderBy(t => rnd.Next()).First();
                                        int BoneIndex14 = NativeFunction.Natives.GET_PED_BONE_INDEX<int>(newped._model, (int)PedBoneId.RightIndexFinger0);
                                        if (beer == "prop_cs_beer_bot_01")
                                            NativeFunction.CallByName<uint>("ATTACH_ENTITY_TO_ENTITY", new Rage.Object(beer, newped._position), newped._model, BoneIndex14, 0.04f, 0.06f, 0f, 0f, 0f, 0f, true, false, false, false, 2, 1);
                                        else
                                            NativeFunction.CallByName<uint>("ATTACH_ENTITY_TO_ENTITY", new Rage.Object(beer, newped._position), newped._model, BoneIndex14, 0.04f, -0.05f, -0.1f, 0f, 0f, 0f, true, false, false, false, 2, 1);
                                        newped._model.Tasks.PlayAnimation(newped._animdir, newped._animname, 1f, newped._animflag);
                                    }
                                    catch (Exception ex)
                                    {
                                        ErrorHandler.LogMessage(ex.ToString(), 919);
                                    }
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
                    }
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Static vehicles could not be placed", 003);
                }
                #endregion spawn vehicles

                #region define main characters
                try
                {
                    _ped_caller = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 1)._model;
                    _ped_owner = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 2)._model;
                }
                catch
                {
                    ErrorHandler.LogMessage("Main Characters could not be generated", 111);
                }
                #endregion

                #region audio
                try
                {
                    string _audiopath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
                    {
                        // create a stream channel from a file
                        _audio_music = Bass.BASS_StreamCreateFile(_audiopath + _area._audio, 0L, 0L, BASSFlag.BASS_DEFAULT);
                        if (_audio_music != 0)
                        {
                            // play the channel
                            Bass.BASS_ChannelSetAttribute(_audio_music, BASSAttribute.BASS_ATTRIB_VOL, 0.0f);
                            Bass.BASS_ChannelPlay(_audio_music, false);
                            Bass.BASS_ChannelFlags(_audio_music, BASSFlag.BASS_SAMPLE_LOOP, BASSFlag.BASS_SAMPLE_LOOP);

                            _playmusic = true;
                        }
                        _audio_ambient = Bass.BASS_StreamCreateFile(_audiopath + @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\crowd.wav", 0L, 0L, BASSFlag.BASS_DEFAULT);
                        if (_audio_ambient != 0)
                        {
                            // play the channel
                            Bass.BASS_ChannelSetAttribute(_audio_ambient, BASSAttribute.BASS_ATTRIB_VOL, 0.0f);
                            Bass.BASS_ChannelPlay(_audio_ambient, false);
                            Bass.BASS_ChannelFlags(_audio_ambient, BASSFlag.BASS_SAMPLE_LOOP, BASSFlag.BASS_SAMPLE_LOOP);

                            _playambient = true;
                        }
                    }
                }
                catch
                {
                    ErrorHandler.LogMessage(this.GetType().Name + " Audio could not be loaded", 306);
                }
                #endregion audio

                #region Random Ending / Pursuit

                Array _tmpary = Enum.GetValues(typeof(Globals.DisturbanceEnd));
                ownerending = (Globals.DisturbanceEnd)_tmpary.GetValue(Main.LPCRandom.Next(_tmpary.Length));

                Array _tmpary2 = Enum.GetValues(typeof(Globals.PursuitEnd));
                suspectending = (Globals.PursuitEnd)_tmpary2.GetValue(Main.LPCRandom.Next(_tmpary2.Length));

                #endregion

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
                #region statusmachine
                //////////////////////////////////////////////
                //  C A L L O U T - S T A T U S M A C H I N E
                //////////////////////////////////////////////
                switch (statusmachine)
                {
                    case Globals.PlayerState.ONROUTE:

                        if (Game.LocalPlayer.Character.DistanceTo(_ped_caller.Position) < 50f)
                        {
                            Game.DisplaySubtitle("Talk to the caller by pressing ~o~'" + GameHandler.ini_action.ToString() + "'~w~ to gain information.", GameHandler.ini_displaytime);
                            if (_blip_caller.Exists()) { _blip_caller.DisableRoute(); }

                            if (Game.LocalPlayer.Character.DistanceTo(_ped_caller.Position) < 30f && _arrived_at_caller == false)
                            {
                                _arrived_at_caller = true;
                            }

                            statusmachine = Globals.PlayerState.TALK_WITNESS1;
                        }
                        break;

                    case Globals.PlayerState.TALK_WITNESS1:
                        if (Game.LocalPlayer.Character.DistanceTo(_ped_caller.Position) < 2f)
                        {
                            Conversation_Caller();
                        }
                        break;
                    //VALUE = 2 -> TALKED TO CALLER, DOORBELL MARKER SET
                    case Globals.PlayerState.TO_SCENERY:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.DOORBELL)._position) < 20f)
                        {
                            Game.DisplaySubtitle("Step into the marker and press ~o~'" + GameHandler.ini_action.ToString() + "'~w~ to ring the doorbell.", GameHandler.ini_displaytime);

                            statusmachine = Globals.PlayerState.FRONTDOOR;
                        }
                        break;
                    //VALUE = 3 -> STANDING IN DOORBELL MARKER, WAITING FOR USER KEY TRIGGER
                    case Globals.PlayerState.FRONTDOOR:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.DOORBELL)._position) < 2f && Rage.Game.IsKeyDown(GameHandler.ini_action))
                        {
                            statusmachine = Globals.PlayerState.BACKYARD;
                            GameFiber.StartNew(delegate
                            {
                                Game.LocalPlayer.Character.Tasks.PlayAnimation("mp_doorbell", "ring_bell_a", 1f, AnimationFlags.None);
                                GameFiber.Wait(1100);
                                string _audiopath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                                _audio_doorbell = Bass.BASS_StreamCreateFile(_audiopath + @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\doorbell.wav", 0L, 0L, BASSFlag.BASS_DEFAULT);
                                if (_audio_doorbell != 0)
                                {
                                    Bass.BASS_ChannelSetAttribute(_audio_doorbell, BASSAttribute.BASS_ATTRIB_VOL, 0.9f);
                                    Bass.BASS_ChannelPlay(_audio_doorbell, false);
                                }
                                _marker_bell = false;
                                if (_blip_bell.Exists()) { _blip_bell.Alpha = 0.0f; }
                                GameFiber.Wait(3000);
                                Game.DisplaySubtitle("No one has heard the doorbell. Check the backyard of this property!", GameHandler.ini_displaytime);
                                _blip_talk = new Blip(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position);
                                _blip_talk.Color = Color.Aqua;
                                _blip_list.Add(_blip_talk);
                                _marker_talk = true;
                            }, FiberHandler._fiber_bell);
                        }
                        break;
                    //VALUE = 4 -> DOORBELL RANG -> GOING TO TALK MARKER POSITION
                    case Globals.PlayerState.BACKYARD:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) < 10f)
                        {
                            Game.DisplaySubtitle("Step into the marker and press ~o~'" + GameHandler.ini_action.ToString() + "'~w~ to talk.", GameHandler.ini_displaytime);
                            statusmachine = Globals.PlayerState.SEARCHING;
                        }
                        break;
                    //VALUE = 5 -> AT TALK MARKER POSITION
                    case Globals.PlayerState.SEARCHING:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) < 1.5f)
                        {
                            _freezeposition = true;
                            _marker_talk = false;
                            statusmachine = Globals.PlayerState.TALK_CIV;
                            if (_ped_caller.Exists())
                            {
                                _ped_caller.IsPersistent = false;
                                _ped_caller.Delete();
                            }
                        }
                        break;
                    //VALUE = 6 -> OWNER CONVERSATION
                    case Globals.PlayerState.TALK_CIV:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) < 2f)
                        {
                            Conversation_Owner_Warning();
                        }
                        break;
                    //VALUE = 7 -> END OF CALLOUT ( RANDOM GENERATOR FOR SECOND RUN )
                    case Globals.PlayerState.NICEEND:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) > 150f)
                        {
                            switch (ownerending)
                            {
                                case Globals.DisturbanceEnd.REVISIT:
                                    Main._nc_rerun = true;
                                    Main._nc_id = _area._calloutid;
                                    End();
                                    break;
                                case Globals.DisturbanceEnd.NOVISIT:
                                    Main._nc_rerun = false;
                                    Main._nc_id = 0;
                                    End();
                                    break;
                            }
                        }
                        break;
                    //VALUE = 8 -> STARTING POINT SECOND ATEMPT
                    case Globals.PlayerState.RERUN:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) < 50f)
                        {
                            Game.DisplaySubtitle("Go to the backyard and step into the marker. Press ~o~'" + GameHandler.ini_action.ToString() + "'~w~ to talk.", GameHandler.ini_displaytime);
                            _blip_area.DisableRoute();
                            _marker_talk = true;
                            statusmachine = Globals.PlayerState.BACKYARD2;
                        }
                        break;
                    //VALUE = 9 -> ARRIVED SECOND TIME AT MARKER IN BACKYARD
                    case Globals.PlayerState.BACKYARD2:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) < 1.5f)
                        {
                            _freezeposition = true;
                            _marker_talk = false;
                            statusmachine = Globals.PlayerState.MUSICOFF;
                        }
                        break;
                    //VALUE = 10 -> OWNER CONVERSATION SECOND TIME
                    case Globals.PlayerState.MUSICOFF:
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) < 2f)
                        {
                            Conversation_Owner_End();
                        }
                        break;
                    //VALUE = 11 -> END OF CALLOUT
                    case Globals.PlayerState.BADEND:
                        _freezeposition = false;
                        if (Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position) > 150f)
                        {
                            Main._nc_rerun = false;
                            Main._nc_id = 0;
                            End();
                        }
                        break;
                }
                #endregion #statusmachine

                #region audio control
                //VOLUMECONTROL MUSIC
                try
                {
                    if (_playmusic == true)
                    {
                        float volume = GameHandler.VolumeControl(Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.MUSIC)._position), -0.43, _audio_music_control);
                        Bass.BASS_ChannelSetAttribute(_audio_music, BASSAttribute.BASS_ATTRIB_VOL, volume);
                    }
                    //VOLUMECONTROL AMBIENT
                    if (_playambient == true)
                    {
                        float volume = GameHandler.VolumeControl(Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.MUSIC)._position), -0.75, 20);
                        Bass.BASS_ChannelSetAttribute(_audio_ambient, BASSAttribute.BASS_ATTRIB_VOL, volume);
                    }

                    //TURN OFF MUSIC
                    if (_marker_music == true && Game.LocalPlayer.Character.DistanceTo(_waypoints.First(t => t._type == Globals.PositionType.MUSIC)._position) < 2f && Rage.Game.IsKeyDown(GameHandler.ini_action))
                    {
                        Bass.BASS_StreamFree(_audio_music);
                        _marker_music = false;
                    }
                }
                catch
                {
                    ErrorHandler.LogMessage("AudioControl was aborted!", 112);
                }
                #endregion volume control

                #region marker control
                //MARKER DOORBELL
                try
                {
                    if (_marker_bell == true)
                    {
                        GameHandler.DrawMarker(1, (_waypoints.First(t => t._type == Globals.PositionType.DOORBELL)._position), new Vector3(0f, 0f, 0f), new Vector3(1.5f, 1.5f, 1.5f), Color.FromArgb(6, 148, 204));
                    }

                    //MARKER TALKINGPOSITION
                    if (_marker_talk == true)
                    {
                        GameHandler.DrawMarker(1, (_waypoints.First(t => t._type == Globals.PositionType.BACKYARD)._position), new Vector3(0f, 0f, 0f), new Vector3(1.5f, 1.5f, 1.5f), Color.FromArgb(6, 148, 204));
                    }

                    //MARKER MUSIC
                    if (_marker_music == true)
                    {
                        GameHandler.DrawMarker(1, (_waypoints.First(t => t._type == Globals.PositionType.MUSIC)._position), new Vector3(0f, 0f, 0f), new Vector3(1.5f, 1.5f, 1.5f), Color.FromArgb(6, 148, 204));
                    }
                }
                catch
                {
                    ErrorHandler.LogMessage("Markers could not be set!", 113);
                }
                #endregion marker control


                #region angle control
                try
                {
                    if (_talking_caller == true)
                    {
                        if (_player != Game.LocalPlayer.Character.Position)
                        {
                            float _faceangle = GameHandler.PedtoPlayerAngle(_ped_caller);
                            _ped_caller.Tasks.AchieveHeading(_faceangle);
                            _player = Game.LocalPlayer.Character.Position;
                        }
                    }
                }
                catch
                {
                    ErrorHandler.LogMessage("Angle Control interrupted!", 114);
                }
                #endregion angle control

                #region player control
                //FREEZE PLAYER POSITION
                if (_freezeposition == true)
                {
                    Game.LocalPlayer.Character.IsPositionFrozen = true;
                }
                else
                {
                    Game.LocalPlayer.Character.IsPositionFrozen = false;
                }
                #endregion player control

                //ARRESTED
                if (Functions.IsPedArrested(_ped_owner))
                {
                    _isarrested = true;
                    GameHandler.RemoveBlip(_blip_owner, _blip_list);
                    End();
                }
            }
            base.Process();
        }

        public override void End()
        {
            Bass.BASS_StreamFree(_audio_music);
            Bass.BASS_StreamFree(_audio_ambient);
            Bass.BASS_StreamFree(_audio_doorbell);
            Bass.BASS_Free();
            Game.LocalPlayer.Character.IsPositionFrozen = false;

            if (_isarrested)
            {
                foreach (var person in Content.HumanList.Where(t => t._calloutid == _area._calloutid && t._type == Globals.HumanType.CIVILIAN))
                {
                    if (person._model.Exists())
                    {
                        person._model.IsPersistent = false;
                        person._model.Dismiss();
                    }
                }
                foreach (var car in Content.CarList.Where(t => t._calloutid == _area._calloutid))
                {
                    if (car._model.Exists())
                    {
                        car._model.IsPersistent = false;
                        car._model.Dismiss();
                    }
                }
                foreach (var obj in Content.ObjectList.Where(t => t._calloutid == _area._calloutid))
                {
                    if (obj._model.Exists())
                    {
                        obj._model.IsPersistent = false;
                        obj._model.Dismiss();
                    }
                }
            }
            else
                GameHandler.CleanUp(this, _area._calloutid, ref _pursuit, _isarrested, 0, false);

            if (_blip_list != null)
            {
                foreach (var _blip in _blip_list)
                {
                    if (_blip.Exists()) { _blip.Delete(); }
                }
                _blip_list.Clear();
            }
            _area = null;
            base.End();
        }

        public void Conversation_Caller()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 1 && t._counter == _mloop_caller)._text;

                switch (_mloop_caller)
                {
                    case 0:
                        _talking_caller = true;
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_caller = 1;
                        break;
                    case 1:
                        GameHandler.PlayerChat(7, Dialog, GameHandler.ini_displaytime);
                        _mloop_caller = 2;
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_caller = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(7, Dialog, GameHandler.ini_displaytime);
                        _mloop_caller = 4;
                        _talking_caller = false;
                        GameFiber.StartNew(delegate
                        {
                            Globals.Humans _start = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._type == Globals.HumanType.CALLER);
                            Globals.Humans _intro = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._type == Globals.HumanType.OWNER_IN);
                            Globals.Humans _outro = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._type == Globals.HumanType.OWNER_OUT);

                            _ped_caller.Tasks.AchieveHeading(_start._heading);
                            GameFiber.Wait(1000);
                            _ped_caller.Tasks.PlayAnimation(_intro._animdir, _intro._animname, 1f, _intro._animflag);
                            GameFiber.Wait(1000);
                            _ped_caller.Tasks.PlayAnimation(_outro._animdir, _outro._animname, 1f, _outro._animflag);
                            GameFiber.Wait(3000);
                            _ped_caller.Tasks.PlayAnimation(_start._animdir, _start._animname, 1f, _start._animflag);
                        }, FiberHandler._fiber_anim);
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_caller = 5;
                        break;
                    case 5:
                        GameHandler.PlayerChat(7, Dialog, GameHandler.ini_displaytime);
                        _blip_bell = new Blip(_waypoints.First(t => t._type == Globals.PositionType.DOORBELL)._position);
                        _blip_bell.Color = Color.Aqua;
                        _blip_list.Add(_blip_bell);
                        GameHandler.RemoveBlip(_blip_caller, _blip_list);
                        _marker_bell = true;
                        statusmachine = Globals.PlayerState.TO_SCENERY;
                        break;
                }

            }
        }

        public void Conversation_Owner_Warning()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 2 && t._counter == _mloop_owner)._text;

                switch (_mloop_owner)
                {
                    case 0:
                        if (_owner_to_player == false)
                        {
                            _owner_to_player = true;
                            GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                            GameFiber.StartNew(delegate
                            {

                                _ped_owner.Tasks.GoStraightToPosition(_waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._position, 1f, _waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._heading, 1f, 10000);
                                GameFiber.Wait(4000);
                                GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 2 && t._counter == _mloop_owner + 1)._text, GameHandler.ini_displaytime);
                                _mloop_owner = 2;
                            }, FiberHandler._fiber_move);
                        }
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(8, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 5;
                        break;
                    case 5:
                        if (_owner_to_volume == false)
                        {
                            _owner_to_volume = true;
                            GameFiber.StartNew(delegate
                            {
                                GameHandler.PlayerChat(8, Dialog, GameHandler.ini_displaytime);
                                _ped_owner.Tasks.GoStraightToPosition(_waypoints.First(t => t._type == Globals.PositionType.MUSIC)._position, 1f, _waypoints.First(t => t._type == Globals.PositionType.MUSIC)._heading, 1f, 10000);
                                GameFiber.Wait(6000);
                                _ped_owner.Tasks.PlayAnimation("anim@narcotics@trash", "drop_front", 1f, AnimationFlags.None);
                                GameFiber.Wait(1000);
                                _audio_music_control = 6;
                                GameFiber.Wait(1000);
                                _ped_owner.Tasks.GoStraightToPosition(_waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._position, 1f, _waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._heading, 1f, 10000);
                                GameFiber.Wait(6000);
                                GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 2 && t._counter == _mloop_owner + 1)._text, GameHandler.ini_displaytime);
                                _mloop_owner = 7;
                            }, FiberHandler._fiber_move);
                        }
                        break;
                    case 7:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);

                        _freezeposition = false;
                        statusmachine = Globals.PlayerState.NICEEND;
                        GameFiber.StartNew(delegate
                        {
                            Globals.Humans _endtask = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 2);
                            GameFiber.Wait(2000);
                            GameHandler.DispatchMessage("10-4. Proceed with Patrol");
                            Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_01 PROCEED_WITH_PATROL");
                            GameHandler.RemoveBlip(_blip_talk, _blip_list);
                            GameFiber.Wait(2000);
                            Game.DisplayHelp("Leave the area");
                            _ped_owner.Tasks.GoStraightToPosition(_endtask._position, 1f, _endtask._heading, 1f, 10000);
                            GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 2 && t._counter == _mloop_owner + 1)._text, GameHandler.ini_displaytime);
                            GameFiber.Wait(4000);
                            _ped_owner.Tasks.PlayAnimation(_endtask._animdir, _endtask._animname, 1f, _endtask._animflag);
                            _mloop_owner = 9;
                        }, FiberHandler._fiber_request);
                        break;
                    default:
                        break;
                }

            }
        }

        public void Conversation_Owner_End()
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                string Dialog;
                if (_mloop_owner <= 7)
                    Dialog = Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 3 && t._counter == _mloop_owner)._text;
                else
                    Dialog = "NONE";

                switch (_mloop_owner)
                {
                    case 0:
                        if (_owner_to_player == false)
                        {
                            _owner_to_player = true;
                            GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                            GameFiber.StartNew(delegate
                            {
                                _ped_owner.Tasks.GoStraightToPosition(_waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._position, 1f, _waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._heading, 1f, 10000);
                                GameFiber.Wait(4000);
                                GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 3 && t._counter == _mloop_owner + 1)._text, GameHandler.ini_displaytime);
                                _mloop_owner = 2;
                            }, FiberHandler._fiber_move);
                        }
                        break;
                    case 2:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 3;
                        break;
                    case 3:
                        GameHandler.PlayerChat(8, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 4;
                        break;
                    case 4:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 5;
                        break;
                    case 5:
                        GameHandler.PlayerChat(8, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 6;
                        break;
                    case 6:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 7;
                        break;
                    case 7:
                        GameHandler.PlayerChat(1, Dialog, GameHandler.ini_displaytime);
                        _mloop_owner = 8;
                        break;
                    case 8:
                        switch (suspectending)
                        {
                            case Globals.PursuitEnd.GIVEUP:
                                if (_owner_to_volume == false)
                                {
                                    _owner_to_volume = true;
                                    GameFiber.StartNew(delegate
                                    {
                                        GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 4 && t._counter == 0)._text, GameHandler.ini_displaytime);
                                        _ped_owner.Tasks.GoStraightToPosition(_waypoints.First(t => t._type == Globals.PositionType.MUSIC)._position, 1f, _waypoints.First(t => t._type == Globals.PositionType.MUSIC)._heading, 1f, 10000);
                                        GameFiber.Wait(6000);
                                        _ped_owner.Tasks.PlayAnimation("anim@narcotics@trash", "drop_front", 1f, AnimationFlags.None);
                                        GameFiber.Wait(1000);
                                        Bass.BASS_StreamFree(_audio_music);
                                        GameFiber.Wait(1000);
                                        _ped_owner.Tasks.GoStraightToPosition(_waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._position, 1f, _waypoints.First(t => t._type == Globals.PositionType.PEDTALK)._heading, 1f, 10000);
                                        GameFiber.Wait(6000);
                                        GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 4 && t._counter == 1)._text, GameHandler.ini_displaytime);
                                    }, FiberHandler._fiber_move);
                                }
                                break;
                            case Globals.PursuitEnd.PURSUIT:
                                GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 5 && t._counter == 0)._text, GameHandler.ini_displaytime);
                                break;
                        }
                        _mloop_owner = 9;
                        break;
                    case 9:
                        switch (suspectending)
                        {
                            case Globals.PursuitEnd.GIVEUP:
                                GameHandler.PlayerChat(1, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 4 && t._counter == 2)._text, GameHandler.ini_displaytime);
                                break;
                            case Globals.PursuitEnd.PURSUIT:
                                GameHandler.PlayerChat(1, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 5 && t._counter == 1)._text, GameHandler.ini_displaytime);
                                break;
                        }
                        _mloop_owner = 10;
                        break;
                    case 10:
                        switch (suspectending)
                        {
                            case Globals.PursuitEnd.GIVEUP:
                                statusmachine = Globals.PlayerState.BADEND;
                                GameFiber.StartNew(delegate
                                {
                                    Globals.Humans _endtask = Content.HumanList.First(t => t._calloutid == _area._calloutid && t._id == 2);
                                    GameHandler.RemoveBlip(_blip_area, _blip_list);
                                    _freezeposition = false;
                                    _ped_owner.Tasks.GoStraightToPosition(_endtask._position, 1f, _endtask._heading, 1f, 10000);
                                    GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 4 && t._counter == 3)._text, GameHandler.ini_displaytime);
                                    GameFiber.Wait(4000);
                                    _ped_owner.Tasks.PlayAnimation(_endtask._animdir, _endtask._animname, 1f, _endtask._animflag);
                                    Game.DisplayHelp("Leave the area");
                                    _mloop_owner = 11;
                                }, FiberHandler._fiber_anim);
                                break;
                            case Globals.PursuitEnd.PURSUIT:
                                statusmachine = Globals.PlayerState.BADEND;
                                GameHandler.PlayerChat(8, Content.DialogList.First(t => t._calloutid == _area._calloutid && t._contactid == 5 && t._counter == 2)._text, GameHandler.ini_displaytime);
                                GameFiber.StartNew(delegate
                                {
                                    Game.DisplaySubtitle("Arrest the owner and turn off the music by steping into the marker and press ~o~'" + GameHandler.ini_action.ToString(), GameHandler.ini_displaytime);
                                    _marker_music = true;
                                    GameHandler.RemoveBlip(_blip_area, _blip_list);
                                    _blip_owner = _ped_owner.AttachBlip();
                                    _blip_owner.Color = Color.Red;
                                    _blip_list.Add(_blip_owner);
                                    _freezeposition = false;
                                    _ped_owner.Tasks.PlayAnimation("anim@move_m@prisoner_cuffed", "idle_intro", 1f, AnimationFlags.StayInEndFrame);
                                    GameFiber.Wait(3000);
                                    _ped_owner.Tasks.PlayAnimation("anim@move_m@prisoner_cuffed", "idle", 1f, AnimationFlags.Loop);
                                    _mloop_owner = 11;
                                }, FiberHandler._fiber_anim);
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}