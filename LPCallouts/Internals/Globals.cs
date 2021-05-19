using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LSPDFR
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Mod.Callouts;
using LSPD_First_Response.Engine.Scripting.Entities;
//RageHook
using Rage;

namespace LPCallouts.Internals
{
    public static class RandomProvider
    {

        private static Random _rnd = new Random();
        private static object _sync = new object();

        public static int Next()
        {
            lock (_sync)
            {
                return _rnd.Next();
            }
        }

        public static int Next(int max)
        {
            lock (_sync)
            {
                return _rnd.Next(max);
            }
        }

        public static int Next(int min, int max)
        {
            lock (_sync)
            {
                return _rnd.Next(min, max);
            }
        }

    }

    public interface ISuspect
    {
        Ped _ped_suspect { get; set; }
        Vehicle _veh_suspect { get; set; }
        List<Blip> _blip_list { get; set; }
    }

    public class Globals
    {
        public static string HitModel = "prop_sign_road_04r";

        public static string CharacterName = "Undefined";

        #region Callout Classes
        public class Scenery
        {
            public CalloutType _type { get; set; }
            public int _calloutid { get; set; }
            public int _region { get; set; }
            public Vector3 _poi { get; set; }
            public string _area { get; set; }
            public string _street { get; set; }
            public float _speedzone_radius { get; set; }
            public float _speedzone_speed { get; set; }
            public string _dispatchtext { get; set; }
            public string _audio { get; set; }
        }

        public class Humans
        {
            public Rage.Ped _model { get; set; }
            public HumanType _type { get; set; }
            public int _calloutid { get; set; }
            public int _id { get; set; }
            public Vector3 _position { get; set; }
            public float _heading { get; set; }
            public string _modelname { get; set; }
            public AnimationDictionary _animdir { get; set; }
            public string _animname { get; set; }
            public AnimationFlags _animflag { get; set; }
        }

        public class Cars
        {
            public Rage.Vehicle _model { get; set; }
            public int _calloutid { get; set; }
            public int _id { get; set; }
            public CarType _type { get; set; }
            public Vector3 _position { get; set; }
            public float _heading { get; set; }
            public string _modelname { get; set; }
            public float _pitch { get; set; }
            public float _roll { get; set; }
            public float _yaw { get; set; }
        }

        public class Objects
        {
            public Rage.Object _model { get; set; }
            public Rage.Object _model_inv { get; set; }
            public int _calloutid { get; set; }
            public bool _hitmodel { get; set; }
            public Vector3 _position { get; set; }
            public float _heading { get; set; }
            public string _modelname { get; set; }
        }



        public class Dialogs
        {
            public int _calloutid { get; set; }
            public int _contactid { get; set; }
            public int _counter { get; set; }
            public string _text { get; set; }
        }

        public class Positions
        {
            public int _calloutid { get; set; }
            public PositionType _type { get; set; }
            public Vector3 _position { get; set; }
            public float _heading { get; set; }
        }
        #endregion

        #region Suspect Classes
        public class SuspectLocation
        {
            public int _region { get; set; }
            public CalloutType _callouttype { get; set; }

            public Vector3 _ped_position { get; set; }
            public float _ped_heading { get; set; }

            public Vector3 _veh_position { get; set; }
            public float _veh_heading { get; set; }
            public Color _veh_color1 { get; set; }
            public Color _veh_color2 { get; set; }

            public Vector3 _police_position { get; set; }
            public float _police_heading { get; set; }

            public Vector3 _backup_position { get; set; }
            public float _backup_heading { get; set; }
            public string _backup_veh_model { get; set; }
            public string _backup_ped_model { get; set; }

            public Vector3 _searcharea { get; set; }
            public string _areaname { get; set; }
            public string _audioarea { get; set; }
        }

        public class SuspectCar
        {
            public CarType _type { get; set; }
            public string _modelname { get; set; }
        }

        public class SuspectPerson
        {
            public HumanType _type { get; set; }
            public string _modelname { get; set; }
            public string _scenario { get; set; }
        }

        public class SuspectDialog
        {
            public CalloutType _callouttype { get; set; }
            public int _dialogid { get; set; }
            public int _counter { get; set; }
            public string _text { get; set; }
        }

        public class SuspectPositions
        {
            public CalloutType _callouttype { get; set; }
            public int _id { get; set; }
            public PositionType _type { get; set; }
            public float _heading { get; set; }
            public Vector3 _position { get; set; }
            public string _modelname { get; set; }
            public int _region { get; set; }
        }
        #endregion

        #region Enums
        public enum PlayerState
        {
            CALLED,
            ONROUTE,
            SEARCHING,
            NEAR_SCENERY,
            TO_SCENERY,
            TO_SUSPECT,
            TO_WITNESS,
            TALK_CIV,
            TALK_COP,
            TALK_VICTIM,
            TALK_WITNESS1,
            TALK_WITNESS2,
            TALK_WITNESS3,
            //RUNOVER
            SELECTION_PLAYER,
            SELECTION_AI,
            WAIT_FOR_USERINPUT,
            //NOISECOMPLAINT
            RERUN,
            FRONTDOOR,
            BACKYARD,
            BACKYARD2,
            MUSICOFF,
            NICEEND,
            BADEND,
            //TRAFFICSTOP
            TO_TRAFFICSTOP,
            NEAR_TRAFFICSTOP,
            TRAFFICSTOP,
            TALK_DRIVER
        }

        public enum CarType
        {
            POLICE,
            EMS,
            FIRE,
            TRUCK,
            AIRUNIT,
            CIV,
            _Normal,
            _County,
            _Rich,
            _Water
        }

        public enum HumanType
        {
            COP,
            MEDIC,
            FIREMAN,
            CIVILIAN,
            LIFEGUARD,
            WITNESS,
            OWNER,
            OWNER_IN,
            OWNER_OUT,
            CALLER,
            _Normal,
            _County,
            _Rich,
        }

        public enum CalloutType
        {
            DrifterScene,
            CyclistScene,
            CornerCut,
            TruckCrash,
            Freeway,
            BeachScene,
            RunOver,
            Disturbance,
            _Default,
            _Water,
            _NoSuspect,
            _TrafficStop
        }

        public enum PositionType
        {
            DOORBELL,
            BACKYARD,
            PEDTALK,
            MUSIC,
            CAR_ABANDON,
            CAR_UNIT,
            CAR_SUSPECT,
            PED_UNIT,
            PED_SUSPECT,
            PED_WAIT
        }

        public enum CalloutEnd
        {
            NORMAL,
            ABANDON,
            TRAFFICSTOP
        }

        public enum PursuitEnd
        {
            GIVEUP,
            PURSUIT
        }

        public enum DisturbanceEnd
        {
            NOVISIT,
            REVISIT
        }
        #endregion
    }
}
