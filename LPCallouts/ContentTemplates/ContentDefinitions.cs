using System;
using System.Collections.Generic;
using System.Linq;
//LPC
using LPCallouts.Externals;
using LPCallouts.Internals;
//LSPDFR
using Rage;

namespace LPCallouts
{
	public class Content
	{
		public static List<Globals.Scenery> CalloutLocations = new List<Globals.Scenery>();
        public static List<Globals.Objects> ObjectList = new List<Globals.Objects>();
        public static List<Globals.Humans> HumanList = new List<Globals.Humans>();
        public static List<Globals.Cars> CarList = new List<Globals.Cars>();
        public static List<Globals.Dialogs> DialogList = new List<Globals.Dialogs>();
		public static List<Globals.Positions> PositionList = new List<Globals.Positions>();
		
		public static void GenerateContent()
		{
			try
			{
					ModelDef.ModelStrings DrifterScene_01 = Main.model_def.DrifterScene.Where(t => t.Location == 1).First();
					ModelDef.ModelStrings DrifterScene_02 = Main.model_def.DrifterScene.Where(t => t.Location == 2).First();
					ModelDef.ModelStrings DrifterScene_03 = Main.model_def.DrifterScene.Where(t => t.Location == 3).First();
					ModelDef.ModelStrings CyclistScene_04 = Main.model_def.CyclistScene.Where(t => t.Location == 4).First();
					ModelDef.ModelStrings CyclistScene_05 = Main.model_def.CyclistScene.Where(t => t.Location == 5).First();
					ModelDef.ModelStrings CyclistScene_06 = Main.model_def.CyclistScene.Where(t => t.Location == 6).First();
					ModelDef.ModelStrings CornerCut_07 = Main.model_def.CornerCut.Where(t => t.Location == 7).First();
					ModelDef.ModelStrings CornerCut_08 = Main.model_def.CornerCut.Where(t => t.Location == 8).First();
					ModelDef.ModelStrings CornerCut_09 = Main.model_def.CornerCut.Where(t => t.Location == 9).First();
					ModelDef.ModelStrings TruckCrash_10 = Main.model_def.TruckCrash.Where(t => t.Location == 10).First();
					ModelDef.ModelStrings TruckCrash_11 = Main.model_def.TruckCrash.Where(t => t.Location == 11).First();
					ModelDef.ModelStrings TruckCrash_12 = Main.model_def.TruckCrash.Where(t => t.Location == 12).First();
					ModelDef.ModelStrings Freeway_13 = Main.model_def.Freeway.Where(t => t.Location == 13).First();
					ModelDef.ModelStrings Freeway_14 = Main.model_def.Freeway.Where(t => t.Location == 14).First();
					ModelDef.ModelStrings Freeway_15 = Main.model_def.Freeway.Where(t => t.Location == 15).First();
					ModelDef.ModelStrings Freeway_16 = Main.model_def.Freeway.Where(t => t.Location == 16).First();
					ModelDef.ModelStrings BeachScene_17 = Main.model_def.BeachScene.Where(t => t.Location == 17).First();
					ModelDef.ModelStrings BeachScene_18 = Main.model_def.BeachScene.Where(t => t.Location == 18).First();
					ModelDef.ModelStrings RunOver_19 = Main.model_def.RunOver.Where(t => t.Location == 19).First();
					ModelDef.ModelStrings RunOver_20 = Main.model_def.RunOver.Where(t => t.Location == 20).First();
					ModelDef.ModelStrings RunOver_21 = Main.model_def.RunOver.Where(t => t.Location == 21).First();
					ModelDef.ModelStrings RunOver_22 = Main.model_def.RunOver.Where(t => t.Location == 22).First();
					ModelDef.ModelStrings RunOver_23 = Main.model_def.RunOver.Where(t => t.Location == 23).First();
					ModelDef.ModelStrings RunOver_24 = Main.model_def.RunOver.Where(t => t.Location == 24).First();
					ModelDef.ModelStrings RunOver_25 = Main.model_def.RunOver.Where(t => t.Location == 25).First();
					ModelDef.ModelStrings RunOver_26 = Main.model_def.RunOver.Where(t => t.Location == 26).First();
					ModelDef.ModelStrings RunOver_27 = Main.model_def.RunOver.Where(t => t.Location == 27).First();
					ModelDef.ModelStrings RunOver_28 = Main.model_def.RunOver.Where(t => t.Location == 28).First();
					ModelDef.ModelStrings RunOver_29 = Main.model_def.RunOver.Where(t => t.Location == 29).First();
					ModelDef.ModelStrings RunOver_30 = Main.model_def.RunOver.Where(t => t.Location == 30).First();

				#region Locations
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 1,
					_type = Globals.CalloutType.DrifterScene,
					_region = 1,
					_area = "AREA_VINEWOOD_HILLS_01",
					_street = "Marlowe Drive",
					_poi = new Vector3(-1071.284f, 1172.085f, 215.472f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 2,
					_type = Globals.CalloutType.DrifterScene,
					_region = 2,
					_area = "AREA_GRAPESEED_01",
					_street = "Union Road",
					_poi = new Vector3(2330.917f, 5213.484f, 59.487f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 3,
					_type = Globals.CalloutType.DrifterScene,
					_region = 3,
					_area = "STREET_GREAT_OCEAN_HWY_01",
					_street = "US Route 1",
					_poi = new Vector3(-1289.924f, 5262.836f, 51.926f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 4,
					_type = Globals.CalloutType.CyclistScene,
					_region = 1,
					_area = "AREA_VINEWOOD_HILLS_01",
					_street = "Mt.Haan Road",
					_poi = new Vector3(1204.949f, 1317.503f, 145f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Reported 10-33 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 5,
					_type = Globals.CalloutType.CyclistScene,
					_region = 2,
					_area = "AREA_THE_ALAMO_SEA_01",
					_street = "Calafia Road",
					_poi = new Vector3(-231.899f, 3879.420f, 37.520f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Reported 10-33 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 6,
					_type = Globals.CalloutType.CyclistScene,
					_region = 3,
					_area = "AREA_THE_CHILLIAD_MOUNTAIN_STATE_WILDERNESS_01",
					_street = "Cassidy Trail",
					_poi = new Vector3(-1289.563f, 4610.563f, 121.169f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Reported 10-33 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 7,
					_type = Globals.CalloutType.CornerCut,
					_region = 1,
					_area = "AREA_TONGVA_HILLS_01",
					_street = "Buen Vino Road",
					_poi = new Vector3(-2044.588f, 1935.916f, 187.063f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Officers report 10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 8,
					_type = Globals.CalloutType.CornerCut,
					_region = 2,
					_area = "AREA_SAN_CHIANSKI_MOUNTAINS_01",
					_street = "Chianski Passage",
					_poi = new Vector3(3015.512f, 3387.339f, 73.763f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Officers report 10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 9,
					_type = Globals.CalloutType.CornerCut,
					_region = 3,
					_area = "STREET_GREAT_OCEAN_HWY_01",
					_street = "US Route 1",
					_poi = new Vector3(-2047.778f, 4460.698f, 57.999f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Officers report 10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 10,
					_type = Globals.CalloutType.TruckCrash,
					_region = 1,
					_area = "AREA_EL_BURRO_HEIGHTS_01",
					_street = "El Burro Blvd.",
					_poi = new Vector3(1902.545f, -1264.719f, 126.943f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Possible 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 11,
					_type = Globals.CalloutType.TruckCrash,
					_region = 2,
					_area = "STREET_ROUTE_68_01",
					_street = "US Route 68",
					_poi = new Vector3(-973.384f, 2755.694f, 25.413f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Possible 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 12,
					_type = Globals.CalloutType.TruckCrash,
					_region = 3,
					_area = "AREA_THE_CHILLIAD_MOUNTAIN_STATE_WILDERNESS_01",
					_street = "Cassidy Trail",
					_poi = new Vector3(-815.327f, 5263.136f, 87.946f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Possible 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 13,
					_type = Globals.CalloutType.Freeway,
					_region = 1,
					_area = "STREET_PALOMINO_FWY_01",
					_street = "US Route 15",
					_poi = new Vector3(1790.720f, -852.161f, 73.584f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 14,
					_type = Globals.CalloutType.Freeway,
					_region = 2,
					_area = "AREA_BRADDOCK_PASS_01 STREET_SENORA_FWY_01",
					_street = "US Route 13",
					_poi = new Vector3(2518.239f, 5523.961f, 44.725f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 15,
					_type = Globals.CalloutType.Freeway,
					_region = 1,
					_area = "STREET_DEL_PERRO_FWY_01",
					_street = "Interstate 2",
					_poi = new Vector3(-499.429f, -505.729f, 25.667f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 16,
					_type = Globals.CalloutType.Freeway,
					_region = 3,
					_area = "AREA_PROCOPIO_BEACH_01 STREET_GREAT_OCEAN_HWY_01",
					_street = "US Route 1",
					_poi = new Vector3(975.302f, 6499.112f, 21.012f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-50 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 17,
					_type = Globals.CalloutType.BeachScene,
					_region = 1,
					_area = "AREA_VESPUCCI_BEACH_01",
					_street = "Vespucci Beach",
					_poi = new Vector3(-1460.925f, -1491.310f, 2.034f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Lifegurards report a 10-33 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 18,
					_type = Globals.CalloutType.BeachScene,
					_region = 1,
					_area = "AREA_EL_BURRO_HEIGHTS_01",
					_street = "El Burro Beach",
					_poi = new Vector3(1265.187f, -2717.728f, 2.097f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Lifegurards report a 10-33 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 19,
					_type = Globals.CalloutType.RunOver,
					_region = 1,
					_area = "AREA_HAWICK_01",
					_street = "Spanish Ave",
					_poi = new Vector3(197.050f, -44.891f, 68.490f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 20,
					_type = Globals.CalloutType.RunOver,
					_region = 1,
					_area = "AREA_VESPUCCI_01",
					_street = "Magellan Ave",
					_poi = new Vector3(-1296.696f, -1138.873f, 5.432f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 21,
					_type = Globals.CalloutType.RunOver,
					_region = 1,
					_area = "AREA_DEL_PERRO_02",
					_street = "Cougar Ave",
					_poi = new Vector3(-1631.315f, -438.017f, 38.695f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 22,
					_type = Globals.CalloutType.RunOver,
					_region = 1,
					_area = "AREA_PILLBOX_HILL_01",
					_street = "San Andreas Ave",
					_poi = new Vector3(193.365f, -806.784f, 31.053f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 23,
					_type = Globals.CalloutType.RunOver,
					_region = 2,
					_area = "AREA_GRAPESEED_01",
					_street = "Main Street",
					_poi = new Vector3(1672.352f, 4842.334f, 41.774f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 24,
					_type = Globals.CalloutType.RunOver,
					_region = 2,
					_area = "AREA_MOUNT_CHILLIAD_01",
					_street = "North Calafia Way",
					_poi = new Vector3(849.619f, 4332.132f, 51.697f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 25,
					_type = Globals.CalloutType.RunOver,
					_region = 2,
					_area = "AREA_HARMONY_01",
					_street = "US Route 68",
					_poi = new Vector3(595.182f, 2731.190f, 42.018f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 26,
					_type = Globals.CalloutType.RunOver,
					_region = 2,
					_area = "AREA_GRAPESEED_01",
					_street = "East Joshua Road",
					_poi = new Vector3(2490.199f, 4087.419f, 38.028f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 27,
					_type = Globals.CalloutType.RunOver,
					_region = 3,
					_area = "AREA_PALETO_FOREST_01",
					_street = "Procopio Promenade",
					_poi = new Vector3(-721.776f, 5783.615f, 17.868f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 28,
					_type = Globals.CalloutType.RunOver,
					_region = 3,
					_area = "AREA_MOUNT_CHILLIAD_01",
					_street = "US Route 13",
					_poi = new Vector3(1695.102f, 6404.390f, 32.089f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 29,
					_type = Globals.CalloutType.RunOver,
					_region = 3,
					_area = "AREA_THE_CHILLIAD_MOUNTAIN_STATE_WILDERNESS_01",
					_street = "US Route 1",
					_poi = new Vector3(-1525.297f, 4920.376f, 66.648f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 30,
					_type = Globals.CalloutType.RunOver,
					_region = 3,
					_area = "AREA_PALETO_BAY_01",
					_street = "Cascabel Ave",
					_poi = new Vector3(-94.168f, 6430.299f, 31.356f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "Backup requested, 10-57 at",
					_audio = @"0"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 31,
					_type = Globals.CalloutType.Disturbance,
					_region = 1,
					_area = "AREA_VINEWOOD_HILLS_01",
					_street = "North Sheldon Ave",
					_poi = new Vector3(-960.665f, 802.342f, 177.430f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-15 at",
					_audio = @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\music_01.wav"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 32,
					_type = Globals.CalloutType.Disturbance,
					_region = 1,
					_area = "AREA_RICHMAN_01",
					_street = "Rockford Drive",
					_poi = new Vector3(-1957.251f, 351.642f, 90.761f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-15 at",
					_audio = @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\music_02.wav"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 33,
					_type = Globals.CalloutType.Disturbance,
					_region = 1,
					_area = "AREA_VINEWOOD_HILLS_01",
					_street = "Whispymound Drive",
					_poi = new Vector3(28.611f, 564.187f, 178.758f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-15 at",
					_audio = @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\music_03.wav"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 34,
					_type = Globals.CalloutType.Disturbance,
					_region = 1,
					_area = "AREA_MIRROR_PARK_01",
					_street = "W Mirror Drive",
					_poi = new Vector3(909.33f, -495.73f, 58.55f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-15 at",
					_audio = @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\music_04.wav"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 35,
					_type = Globals.CalloutType.Disturbance,
					_region = 1,
					_area = "AREA_PACIFIC_BLUFFS_01",
					_street = "Interstate 2",
					_poi = new Vector3(-1898.226f, -556.283f, 11.741f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-15 at",
					_audio = @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\music_05.wav"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 36,
					_type = Globals.CalloutType.Disturbance,
					_region = 1,
					_area = "AREA_BANHAM_CANYON_01",
					_street = "US Route 1",
					_poi = new Vector3(-3025.912f, 718.948f, 22.857f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-15 at",
					_audio = @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\music_06.wav"
				});
				
				CalloutLocations.Add(new Globals.Scenery
				{
					_calloutid = 37,
					_type = Globals.CalloutType.Disturbance,
					_region = 3,
					_area = "AREA_PALETO_BAY_01",
					_street = "Procopio Drive",
					_poi = new Vector3(-228.124f, 6414.138f, 31.355f),
					_speedzone_radius = 80f,
					_speedzone_speed = 8f,
					_dispatchtext = "We have 10-15 at",
					_audio = @"\lspdfr\audio\LPCallouts Audio\NoiseComplaint\music_07.wav"
				});
				
				#endregion Locations

				#region Objects
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1040.806f, 1182.763f, 216.031f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1043.510f, 1182.324f, 215.921f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1046.864f, 1181.791f, 215.780f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1050.913f, 1181.065f, 215.599f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1054.713f, 1180.270f, 215.422f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1058.081f, 1179.316f, 215.252f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1061.680f, 1178.175f, 215.062f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1065.587f, 1176.875f, 214.850f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 1,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 99.459f,
					_position = new Vector3(-1069.410f, 1175.882f, 214.634f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2340.113f, 5225.933f, 58.979f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2337.552f, 5222.913f, 58.960f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2335.175f, 5219.979f, 58.950f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2332.913f, 5218.246f, 58.938f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2330.367f, 5216.373f, 58.924f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2328.202f, 5214.682f, 58.914f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2326.055f, 5213.000f, 58.905f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2323.768f, 5211.207f, 58.898f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 2,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 128.012f,
					_position = new Vector3(2319.862f, 5209.357f, 58.879f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1283.026f, 5270.815f, 50.479f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1283.888f, 5268.502f, 50.576f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1284.801f, 5266.769f, 50.664f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1285.964f, 5264.557f, 50.777f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1287.355f, 5261.302f, 50.935f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1290.270f, 5257.699f, 51.183f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1292.982f, 5255.065f, 51.431f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1295.172f, 5252.679f, 51.669f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 3,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 155.706f,
					_position = new Vector3(-1297.993f, 5249.367f, 51.994f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1223.192f, 1300.234f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1224.539f, 1295.803f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1225.719f, 1291.308f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1226.683f, 1286.505f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1227.254f, 1281.574f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1227.725f, 1275.996f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1211.605f, 1314.603f, 143.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1214.003f, 1312.392f, 143.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1216.788f, 1309.806f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 4,
					_hitmodel = true,
					_modelname = "prop_roadcone01a",
					_heading = 191.394f,
					_position = new Vector3(1219.312f, 1306.938f, 142.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-231.900f, 3875.040f, 36.889f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-231.700f, 3878.419f, 36.631f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-231.859f, 3881.216f, 36.524f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-231.699f, 3883.954f, 36.416f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-231.751f, 3887.103f, 36.423f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-231.476f, 3890.135f, 36.420f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-222.974f, 3890.081f, 36.702f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-223.061f, 3887.224f, 36.700f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-223.028f, 3884.574f, 36.694f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 5,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 350.322f,
					_position = new Vector3(-223.064f, 3881.370f, 36.733f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1304.682f, 4618.526f, 117.057f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1303.465f, 4619.642f, 116.875f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1302.223f, 4620.642f, 116.475f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1300.020f, 4621.812f, 116.996f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1298.890f, 4622.862f, 117.280f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1245.958f, 4614.029f, 130.446f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1244.962f, 4612.869f, 130.385f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1243.819f, 4611.540f, 130.256f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1242.980f, 4610.563f, 130.397f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 6,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 301.989f,
					_position = new Vector3(-1241.744f, 4609.129f, 130.815f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2011.501f, 1921.370f, 185.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2015.077f, 1922.078f, 185.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2019.623f, 1922.931f, 185.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2024.985f, 1923.965f, 185.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2030.752f, 1925.325f, 185.5f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2035.248f, 1926.934f, 186f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2039.782f, 1928.948f, 186f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 7,
					_hitmodel = true,
					_modelname = "prop_roadcone02a",
					_heading = 76.788f,
					_position = new Vector3(-2045.627f, 1932.491f, 186f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3009.770f, 3389.580f, 72.441f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3013.500f, 3386.681f, 72.760f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3017.679f, 3382.841f, 73.180f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3020.521f, 3380.441f, 73.441f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3023.257f, 3378.357f, 73.685f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3026.279f, 3376.092f, 73.963f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3029.919f, 3373.048f, 74.280f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 8,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(3033.528f, 3370.115f, 74.557f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2074.077f, 4449.037f, 58.123f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2070.408f, 4450.271f, 57.891f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2066.139f, 4452.290f, 57.617f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2062.811f, 4453.991f, 57.410f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2059.576f, 4455.631f, 57.238f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2056.677f, 4457.335f, 57.086f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2053.018f, 4459.554f, 56.903f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 9,
					_hitmodel = true,
					_modelname = "prop_mp_cone_03",
					_heading = 226.600f,
					_position = new Vector3(-2049.332f, 4462.107f, 56.743f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1912.471f, -1286.550f, 129.482f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1912.158f, -1282.678f, 128.903f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1911.570f, -1279.442f, 128.417f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1910.883f, -1275.452f, 127.805f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1910.144f, -1271.446f, 127.182f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1909.376f, -1267.600f, 126.560f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1908.995f, -1263.783f, 125.908f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1908.486f, -1259.526f, 125.180f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1907.726f, -1254.351f, 124.283f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1907.236f, -1250.419f, 123.588f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1898.615f, -1278.038f, 127.916f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1898.886f, -1280.223f, 128.239f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1899.218f, -1282.391f, 128.553f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1899.738f, -1284.930f, 128.937f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1900.054f, -1287.129f, 129.247f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 10,
					_hitmodel = true,
					_modelname = "prop_roadcone02c",
					_heading = 273.653f,
					_position = new Vector3(1900.348f, -1289.664f, 129.592f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-937.073f, 2763.698f, 24.187f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-941.029f, 2762.754f, 24.280f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-944.203f, 2762.021f, 24.352f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-947.882f, 2761.171f, 24.418f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-952.107f, 2760.101f, 24.486f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-955.981f, 2759.248f, 24.522f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-996.708f, 2757.493f, 24.545f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-961.130f, 2758.320f, 24.545f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-964.918f, 2757.668f, 24.547f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-969.373f, 2756.903f, 24.526f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-974.326f, 2755.976f, 24.479f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-978.928f, 2754.969f, 24.413f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-982.706f, 2754.744f, 24.350f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-986.435f, 2755.088f, 24.276f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-990.475f, 2755.210f, 24.185f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 11,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 100.164f,
					_position = new Vector3(-994.525f, 2755.421f, 24.094f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-847.244f, 5265.395f, 85.806f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-847.091f, 5263.264f, 85.841f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-846.903f, 5261.711f, 85.863f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-846.698f, 5260.026f, 85.861f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-845.896f, 5253.608f, 85.861f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-846.526f, 5258.603f, 85.836f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-846.371f, 5257.329f, 85.826f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-846.177f, 5255.765f, 85.811f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-758.048f, 5266.953f, 91.344f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-757.112f, 5264.577f, 91.469f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-755.882f, 5261.359f, 91.764f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-755.084f, 5259.270f, 92.030f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-754.239f, 5257.059f, 92.283f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-753.123f, 5254.755f, 92.669f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-751.980f, 5253.051f, 92.975f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 12,
					_hitmodel = true,
					_modelname = "prop_mp_cone_01",
					_heading = 200.931f,
					_position = new Vector3(-750.400f, 5250.958f, 93.446f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1778.495f, -852.458f, 71.902f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1781.375f, -851.981f, 72.047f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1784.758f, -851.954f, 72.307f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1789.258f, -851.176f, 72.610f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1793.686f, -849.214f, 72.909f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1798.126f, -846.093f, 73.222f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1802.314f, -842.988f, 73.545f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1807.342f, -839.245f, 73.933f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1811.109f, -836.408f, 74.240f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1814.606f, -833.964f, 74.517f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1818.075f, -831.166f, 74.813f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1821.634f, -828.664f, 75.106f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1825.500f, -825.722f, 75.445f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1830.865f, -821.552f, 75.922f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1834.354f, -818.831f, 76.242f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1837.943f, -816.358f, 76.554f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1842.144f, -813.250f, 76.934f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1845.759f, -810.501f, 77.273f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1849.279f, -807.825f, 77.603f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 13,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 304.887f,
					_position = new Vector3(1853.005f, -804.994f, 77.957f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2527.803f, 5475.347f, 43.652f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2527.333f, 5481.275f, 43.662f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2527.628f, 5486.286f, 43.690f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2527.214f, 5492.589f, 43.713f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2526.806f, 5498.460f, 43.726f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2525.339f, 5504.960f, 43.743f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2523.352f, 5510.686f, 43.761f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2521.448f, 5515.582f, 43.776f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2519.510f, 5522.218f, 43.795f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2518.088f, 5526.086f, 43.806f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2516.553f, 5530.674f, 43.818f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2514.897f, 5535.162f, 43.830f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2513.074f, 5539.551f, 43.842f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2510.354f, 5547.135f, 43.860f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2508.694f, 5550.833f, 43.869f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2486.226f, 5550.962f, 43.864f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2486.576f, 5546.141f, 43.855f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2488.082f, 5541.285f, 43.847f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2489.287f, 5535.738f, 43.844f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 14,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(2490.895f, 5530.459f, 43.835f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-449.439f, -511.812f, 24.200f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-453.726f, -510.078f, 24.247f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-456.791f, -508.758f, 24.290f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-459.292f, -507.680f, 24.325f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-462.059f, -506.487f, 24.364f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-465.076f, -505.187f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-467.780f, -504.022f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-470.868f, -502.690f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-474.158f, -501.272f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-477.017f, -500.039f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-479.857f, -499.599f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-483.519f, -499.532f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-487.744f, -499.559f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-491.661f, -499.552f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-495.542f, -499.770f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-500.985f, -499.699f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-506.149f, -499.613f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-511.794f, -499.467f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-516.699f, -499.457f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 15,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 130.072f,
					_position = new Vector3(-521.594f, -499.602f, 24.399f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(999.281f, 6501.523f, 20.066f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(995.976f, 6499.474f, 20.069f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(992.568f, 6497.406f, 20.062f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(989.305f, 6495.425f, 20.060f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(985.432f, 6493.075f, 20.061f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(981.451f, 6492.018f, 20.065f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(976.748f, 6492.095f, 20.071f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(972.723f, 6492.250f, 20.078f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(967.989f, 6492.258f, 20.087f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(963.894f, 6492.260f, 20.096f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(959.541f, 6492.261f, 20.107f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(955.820f, 6492.409f, 20.118f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(951.829f, 6492.610f, 20.131f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(948.185f, 6492.730f, 20.144f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(943.749f, 6492.859f, 20.162f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(940.076f, 6492.995f, 20.178f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(936.121f, 6493.126f, 20.197f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(932.535f, 6493.167f, 20.217f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(928.709f, 6493.282f, 20.238f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 16,
					_hitmodel = true,
					_modelname = "prop_mp_cone_02",
					_heading = 87.707f,
					_position = new Vector3(924.925f, 6493.444f, 20.262f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 31,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 20f,
					_position = new Vector3(-1017.889f, 771.0f, 170.3f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 31,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 20f,
					_position = new Vector3(-1014.034f, 772.2f, 170.3f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 31,
					_hitmodel = false,
					_modelname = "prop_office_desk_01",
					_heading = 200f,
					_position = new Vector3(-1016.105f, 771.7f, 170.3f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 31,
					_hitmodel = false,
					_modelname = "prop_dj_deck_02",
					_heading = 20f,
					_position = new Vector3(-1016.3f, 771.4f, 171f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 32,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 10f,
					_position = new Vector3(-1926.191f, 397.574f, 95.483f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 32,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 10f,
					_position = new Vector3(-1930.007f, 397f, 95.483f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 32,
					_hitmodel = false,
					_modelname = "prop_office_desk_01",
					_heading = 10f,
					_position = new Vector3(-1927.977f, 397f, 95.483f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 32,
					_hitmodel = false,
					_modelname = "prop_dj_deck_02",
					_heading = 10f,
					_position = new Vector3(-1928.277f, 397f, 96.207f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 33,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 210.396f,
					_position = new Vector3(25.195f, 532.376f, 169.6f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 33,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 111.776f,
					_position = new Vector3(22.283f, 533.875f, 169.6f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 33,
					_hitmodel = false,
					_modelname = "prop_office_desk_01",
					_heading = 296.470f,
					_position = new Vector3(23.760f, 532.702f, 169.6f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 33,
					_hitmodel = false,
					_modelname = "prop_dj_deck_02",
					_heading = 296.470f,
					_position = new Vector3(23.560f, 532.702f, 170.3f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 34,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 8.90f,
					_position = new Vector3(893.99f, -476.19f, 58.10f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 34,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 34.01f,
					_position = new Vector3(899.30f, -474.26f, 58.50f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 34,
					_hitmodel = false,
					_modelname = "prop_office_desk_01",
					_heading = 25.00f,
					_position = new Vector3(895.03f, -475.76f, 58.05f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 34,
					_hitmodel = false,
					_modelname = "prop_dj_deck_02",
					_heading = 25.00f,
					_position = new Vector3(894.58f, -475.97f, 58.75f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 35,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 216.423f,
					_position = new Vector3(-1904.309f, -577.434f, 21.9f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 35,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 227.252f,
					_position = new Vector3(-1906.014f, -579.238f, 21.9f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 35,
					_hitmodel = false,
					_modelname = "prop_office_desk_01",
					_heading = 231f,
					_position = new Vector3(-1905.265f, -578.224f, 21.9f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 35,
					_hitmodel = false,
					_modelname = "prop_dj_deck_02",
					_heading = 231f,
					_position = new Vector3(-1905.0f, -578.0f, 22.6f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 36,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 112f,
					_position = new Vector3(-3007.525f, 753.328f, 26.6f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 36,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 112f,
					_position = new Vector3(-3009.030f, 757.051f, 26.6f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 36,
					_hitmodel = false,
					_modelname = "prop_office_desk_01",
					_heading = 112f,
					_position = new Vector3(-3007.979f, 755.160f, 26.6f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 36,
					_hitmodel = false,
					_modelname = "prop_dj_deck_02",
					_heading = 112f,
					_position = new Vector3(-3007.679f, 754.8f, 27.3f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 37,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 45f,
					_position = new Vector3(-204.305f, 6382.048f, 30.833f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 37,
					_hitmodel = false,
					_modelname = "prop_hifi_01",
					_heading = 160.628f,
					_position = new Vector3(-200.740f, 6383.517f, 30.833f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 37,
					_hitmodel = false,
					_modelname = "prop_office_desk_01",
					_heading = 45f,
					_position = new Vector3(-203.132f, 6383.193f, 30.833f)
				});		
				
				ObjectList.Add(new Globals.Objects
				{
					_calloutid = 37,
					_hitmodel = false,
					_modelname = "prop_dj_deck_02",
					_heading = 45f,
					_position = new Vector3(-203.332f, 6382.993f, 31.533f)
				});		
				
				#endregion Objects

				#region Vehicles
				CarList.Add(new Globals.Cars
				{
					_calloutid = 1,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = DrifterScene_01.Vehicle1,
					_heading = 103.066f,
					_position = new Vector3(-1049.494f, 1183.143f, 216.239f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 1,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = DrifterScene_01.Vehicle2,
					_heading = 99.448f,
					_position = new Vector3(-1038.006f, 1184.424f, 216.850f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 1,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "BISON",
					_heading = 121.31f,
					_position = new Vector3(-1064.50f, 1191.51f, 221.93f),
					_pitch =  0f,
					_roll = 180f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 1,
					_id = 4,
					_type = Globals.CarType.TRUCK,
					_modelname = "FLATBED",
					_heading = 119.384f,
					_position = new Vector3(-1076.920f, 1174.091f, 215.276f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 2,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = DrifterScene_02.Vehicle1,
					_heading = 120.915f,
					_position = new Vector3(2342.582f, 5228.750f, 59.463f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 2,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = DrifterScene_02.Vehicle2,
					_heading = 127.667f,
					_position = new Vector3(2318.881f, 5210.524f, 59.500f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 2,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "HABANERO",
					_heading = 108.796f,
					_position = new Vector3(2314.432f, 5216.966f, 59.343f),
					_pitch =  0f,
					_roll = 180f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 2,
					_id = 4,
					_type = Globals.CarType.TRUCK,
					_modelname = "FLATBED",
					_heading = 292.429f,
					_position = new Vector3(2325.760f, 5219.547f, 59.869f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 3,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = DrifterScene_03.Vehicle1,
					_heading = 136.50f,
					_position = new Vector3(-1295.90f, 5253.83f, 52.18f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 3,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = DrifterScene_03.Vehicle2,
					_heading = 109.360f,
					_position = new Vector3(-1290.711f, 5262.526f, 51.700f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 3,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "TAXI",
					_heading = 129.990f,
					_position = new Vector3(-1298.578f, 5258.469f, 52.113f),
					_pitch =  0f,
					_roll = 180f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 3,
					_id = 4,
					_type = Globals.CarType.TRUCK,
					_modelname = "FLATBED",
					_heading = 145.937f,
					_position = new Vector3(-1305.541f, 5246.211f, 53.581f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 4,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = CyclistScene_04.Vehicle1,
					_heading = 232.389f,
					_position = new Vector3(1207.343f, 1315.722f, 144.374f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 4,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = CyclistScene_04.Vehicle2,
					_heading = 76.179f,
					_position = new Vector3(1217.441f, 1304.354f, 143.584f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 4,
					_id = 3,
					_type = Globals.CarType.AIRUNIT,
					_modelname = CyclistScene_04.Vehicle3,
					_heading = 47.795f,
					_position = new Vector3(1220.011f, 1294.865f, 142.4f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 4,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "ISSI2",
					_heading = 239.403f,
					_position = new Vector3(1199.866f, 1320.879f, 144.887f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 4,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "JACKAL",
					_heading = 24.509f,
					_position = new Vector3(1232.801f, 1306.366f, 143.276f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 4,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "TRIBIKE3",
					_heading = 195.253f,
					_position = new Vector3(1214.313f, 1310.214f, 143.698f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 5,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = CyclistScene_05.Vehicle1,
					_heading = 158.662f,
					_position = new Vector3(-234.211f, 3892.026f, 37.085f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 5,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = CyclistScene_05.Vehicle2,
					_heading = 359.814f,
					_position = new Vector3(-233.593f, 3883.720f, 37.230f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 5,
					_id = 3,
					_type = Globals.CarType.AIRUNIT,
					_modelname = CyclistScene_05.Vehicle3,
					_heading = 311.359f,
					_position = new Vector3(-252.012f, 3878.350f, 40.253f),
					_pitch =  10f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 5,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "RANCHERXL",
					_heading = 309.132f,
					_position = new Vector3(-218.913f, 3886.984f, 37.144f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 5,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "RHAPSODY",
					_heading = 176.705f,
					_position = new Vector3(-232.742f, 3910.579f, 37.260f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 5,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "SANCHEZ",
					_heading = 177.015f,
					_position = new Vector3(-235.064f, 3863.109f, 34.354f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 6,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = CyclistScene_06.Vehicle1,
					_heading = 191.002f,
					_position = new Vector3(-1302.890f, 4614.000f, 118.588f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 6,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = CyclistScene_06.Vehicle2,
					_heading = 264.445f,
					_position = new Vector3(-1276.187f, 4610.320f, 123.799f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 6,
					_id = 3,
					_type = Globals.CarType.AIRUNIT,
					_modelname = CyclistScene_06.Vehicle3,
					_heading = 351.910f,
					_position = new Vector3(-1292.021f, 4609.761f, 120.000f),
					_pitch =  -5f,
					_roll = -7f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 6,
					_id = 4,
					_type = Globals.CarType.TRUCK,
					_modelname = "BULLDOZER",
					_heading = 293.354f,
					_position = new Vector3(-1251.239f, 4608.118f, 130.681f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 6,
					_id = 5,
					_type = Globals.CarType.TRUCK,
					_modelname = "TIPTRUCK",
					_heading = 234.813f,
					_position = new Vector3(-1267.600f, 4604.927f, 126.168f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 6,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "SCORCHER",
					_heading = 359.133f,
					_position = new Vector3(-1281.937f, 4610.486f, 122.751f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 7,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = CornerCut_07.Vehicle1,
					_heading = 49.237f,
					_position = new Vector3(-2018.984f, 1927.090f, 185.982f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 7,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = CornerCut_07.Vehicle2,
					_heading = 22.707f,
					_position = new Vector3(-2011.968f, 1926.712f, 185.506f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 7,
					_id = 3,
					_type = Globals.CarType.FIRE,
					_modelname = CornerCut_07.Vehicle3,
					_heading = 168.832f,
					_position = new Vector3(-2046.508f, 1948.092f, 188.234f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 7,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "WASHINGTON",
					_heading = 318.817f,
					_position = new Vector3(-2018.404f, 1953.719f, 173.204f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 7,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "GRESLEY",
					_heading = 68.160f,
					_position = new Vector3(-2028.124f, 1927.155f, 186.449f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 7,
					_id = 6,
					_type = Globals.CarType.TRUCK,
					_modelname = "TOWTRUCK",
					_heading = 128.701f,
					_position = new Vector3(-2043.193f, 1935.710f, 186.804f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 8,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = CornerCut_08.Vehicle1,
					_heading = 218.565f,
					_position = new Vector3(3007.410f, 3390.121f, 72.806f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 8,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = CornerCut_08.Vehicle2,
					_heading = 240.045f,
					_position = new Vector3(3028.339f, 3370.805f, 74.937f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 8,
					_id = 3,
					_type = Globals.CarType.FIRE,
					_modelname = CornerCut_08.Vehicle3,
					_heading = 212.652f,
					_position = new Vector3(3008.332f, 3374.985f, 74.032f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 8,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "ASTEROPE",
					_heading = 211.117f,
					_position = new Vector3(3021.993f, 3370.316f, 74.306f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 8,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "DILETTANTE2",
					_heading = 55.813f,
					_position = new Vector3(3011.717f, 3382.808f, 73.234f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 8,
					_id = 6,
					_type = Globals.CarType.TRUCK,
					_modelname = "TOWTRUCK2",
					_heading = 27.221f,
					_position = new Vector3(3017.760f, 3377.907f, 73.914f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 9,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = CornerCut_09.Vehicle1,
					_heading = 287.023f,
					_position = new Vector3(-2076.445f, 4446.418f, 58.594f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 9,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = CornerCut_09.Vehicle2,
					_heading = 306.518f,
					_position = new Vector3(-2040.326f, 4466.304f, 57.097f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 9,
					_id = 3,
					_type = Globals.CarType.FIRE,
					_modelname = CornerCut_09.Vehicle3,
					_heading = 253.030f,
					_position = new Vector3(-2049.768f, 4447.828f, 56.847f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 9,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "SCHAFTER2",
					_heading = 296.298f,
					_position = new Vector3(-2039.690f, 4461.199f, 56.648f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 9,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "BALLER",
					_heading = 115.739f,
					_position = new Vector3(-2067.070f, 4463.200f, 58.488f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 9,
					_id = 6,
					_type = Globals.CarType.TRUCK,
					_modelname = "TOWTRUCK",
					_heading = 111.629f,
					_position = new Vector3(-2049.652f, 4456.173f, 57.628f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 10,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = TruckCrash_10.Vehicle1,
					_heading = 343.210f,
					_position = new Vector3(1915.990f, -1297.256f, 131.552f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 10,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = TruckCrash_10.Vehicle2,
					_heading = 171.465f,
					_position = new Vector3(1907.896f, -1227.316f, 119.798f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 10,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = TruckCrash_10.Vehicle3,
					_heading = 0.829f,
					_position = new Vector3(1907.715f, -1245.740f, 123.509f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 10,
					_id = 4,
					_type = Globals.CarType.TRUCK,
					_modelname = "BENSON",
					_heading = 158.134f,
					_position = new Vector3(1917.884f, -1248.013f, 125.768f),
					_pitch =  0f,
					_roll = 270f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 10,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "PONY",
					_heading = 24.509f,
					_position = new Vector3(1897.318f, -1288.881f, 130.060f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 10,
					_id = 6,
					_type = Globals.CarType.FIRE,
					_modelname = TruckCrash_10.Vehicle4,
					_heading = 8.318f,
					_position = new Vector3(1913.163f, -1267.820f, 128.163f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 11,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = TruckCrash_11.Vehicle1,
					_heading = 108.490f,
					_position = new Vector3(-953.869f, 2762.304f, 24.995f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 11,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = TruckCrash_11.Vehicle2,
					_heading = 282.794f,
					_position = new Vector3(-972.625f, 2745.046f, 25.142f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 11,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = TruckCrash_11.Vehicle3,
					_heading = 103.581f,
					_position = new Vector3(-981.562f, 2758.325f, 25.060f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 11,
					_id = 4,
					_type = Globals.CarType.TRUCK,
					_modelname = "POUNDER",
					_heading = 83.735f,
					_position = new Vector3(-987.599f, 2763.984f, 26.440f),
					_pitch =  0f,
					_roll = 90f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 11,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "UTILLITRUCK3",
					_heading = 264.371f,
					_position = new Vector3(-960.006f, 2746.664f, 25.363f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 11,
					_id = 6,
					_type = Globals.CarType.FIRE,
					_modelname = TruckCrash_11.Vehicle4,
					_heading = 88.218f,
					_position = new Vector3(-961.865f, 2763.821f, 25.514f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 12,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = TruckCrash_12.Vehicle1,
					_heading = 269.599f,
					_position = new Vector3(-839.594f, 5258.758f, 86.385f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 12,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = TruckCrash_12.Vehicle2,
					_heading = 18.878f,
					_position = new Vector3(-760.623f, 5261.601f, 91.410f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 12,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = TruckCrash_12.Vehicle3,
					_heading = 91.695f,
					_position = new Vector3(-820.835f, 5265.771f, 87.111f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 12,
					_id = 4,
					_type = Globals.CarType.TRUCK,
					_modelname = "HAULER",
					_heading = 88.861f,
					_position = new Vector3(-838.739f, 5274.097f, 78.747f),
					_pitch =  0f,
					_roll = 90f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 12,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "TRAILERLOGS",
					_heading = 39.782f,
					_position = new Vector3(-831.430f, 5268.207f, 81.139f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 12,
					_id = 6,
					_type = Globals.CarType.FIRE,
					_modelname = TruckCrash_12.Vehicle4,
					_heading = 290.486f,
					_position = new Vector3(-806.317f, 5262.846f, 88.413f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_13.Vehicle1,
					_heading = 286.309f,
					_position = new Vector3(1786.665f, -850.312f, 73.176f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_13.Vehicle2,
					_heading = 303.249f,
					_position = new Vector3(1813.979f, -846.053f, 74.272f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = Freeway_13.Vehicle3,
					_heading = 300.558f,
					_position = new Vector3(1793.742f, -844.599f, 73.600f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 4,
					_type = Globals.CarType.EMS,
					_modelname = Freeway_13.Vehicle3,
					_heading = 304.019f,
					_position = new Vector3(1826.977f, -822.001f, 76.295f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 5,
					_type = Globals.CarType.FIRE,
					_modelname = Freeway_13.Vehicle5,
					_heading = 306.283f,
					_position = new Vector3(1807.452f, -836.713f, 74.994f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "SERRANO",
					_heading = 257.500f,
					_position = new Vector3(1813.468f, -829.652f, 74.924f),
					_pitch =  0f,
					_roll = 180f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "INGOT",
					_heading = 314.080f,
					_position = new Vector3(1798.749f, -838.393f, 73.930f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 8,
					_type = Globals.CarType.CIV,
					_modelname = "BLISTA",
					_heading = 309.813f,
					_position = new Vector3(1820.828f, -840.307f, 75.166f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 9,
					_type = Globals.CarType.TRUCK,
					_modelname = "FLATBED",
					_heading = 308.691f,
					_position = new Vector3(1820.475f, -822.857f, 76.125f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 13,
					_id = 10,
					_type = Globals.CarType.TRUCK,
					_modelname = "TOWTRUCK",
					_heading = 300.552f,
					_position = new Vector3(1802.212f, -853.532f, 73.861f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_14.Vehicle1,
					_heading = 14.871f,
					_position = new Vector3(2524.150f, 5498.210f, 44.194f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_14.Vehicle2,
					_heading = 209.364f,
					_position = new Vector3(2493.192f, 5536.108f, 44.086f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = Freeway_14.Vehicle3,
					_heading = 16.062f,
					_position = new Vector3(2518.510f, 5518.033f, 44.440f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 4,
					_type = Globals.CarType.AIRUNIT,
					_modelname = Freeway_14.Vehicle4,
					_heading = 219.358f,
					_position = new Vector3(2502.169f, 5541.096f, 43.770f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 5,
					_type = Globals.CarType.FIRE,
					_modelname = Freeway_14.Vehicle5,
					_heading = 33.644f,
					_position = new Vector3(2515.485f, 5504.484f, 44.676f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "PRIMO",
					_heading = 83.378f,
					_position = new Vector3(2510.140f, 5522.511f, 44.204f),
					_pitch =  0f,
					_roll = 180f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "REGINA",
					_heading = 27.298f,
					_position = new Vector3(2513.537f, 5519.205f, 44.380f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 8,
					_type = Globals.CarType.CIV,
					_modelname = "FUGITIVE",
					_heading = 198.934f,
					_position = new Vector3(2499.869f, 5518.604f, 44.354f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 9,
					_type = Globals.CarType.TRUCK,
					_modelname = "FLATBED",
					_heading = 220.434f,
					_position = new Vector3(2499.467f, 5526.640f, 44.785f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 14,
					_id = 10,
					_type = Globals.CarType.TRUCK,
					_modelname = "TOWTRUCK",
					_heading = 17.744f,
					_position = new Vector3(2526.591f, 5531.026f, 44.640f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_15.Vehicle1,
					_heading = 65.423f,
					_position = new Vector3(-472.314f, -505.942f, 24.958f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_15.Vehicle2,
					_heading = 87.681f,
					_position = new Vector3(-497.433f, -501.307f, 25.139f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = Freeway_15.Vehicle3,
					_heading = 86.373f,
					_position = new Vector3(-478.963f, -510.782f, 24.882f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 4,
					_type = Globals.CarType.EMS,
					_modelname = Freeway_15.Vehicle3,
					_heading = 72.725f,
					_position = new Vector3(-500.902f, -506.146f, 25.026f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 5,
					_type = Globals.CarType.FIRE,
					_modelname = Freeway_15.Vehicle5,
					_heading = 80.495f,
					_position = new Vector3(-485.336f, -503.996f, 25.394f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "FACTION",
					_heading = 95.981f,
					_position = new Vector3(-494.282f, -511.936f, 24.595f),
					_pitch =  0f,
					_roll = 180f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "BALLER",
					_heading = 157.271f,
					_position = new Vector3(-485.993f, -510.918f, 24.631f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 8,
					_type = Globals.CarType.CIV,
					_modelname = "JACKAL",
					_heading = 90.209f,
					_position = new Vector3(-505.738f, -501.612f, 24.788f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 9,
					_type = Globals.CarType.TRUCK,
					_modelname = "FLATBED",
					_heading = 88.162f,
					_position = new Vector3(-505.849f, -511.388f, 25.237f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 15,
					_id = 10,
					_type = Globals.CarType.TRUCK,
					_modelname = "TOWTRUCK",
					_heading = 51.786f,
					_position = new Vector3(-492.222f, -506.642f, 25.244f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_16.Vehicle1,
					_heading = 98.642f,
					_position = new Vector3(986.878f, 6497.579f, 20.353f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = Freeway_16.Vehicle2,
					_heading = 86.302f,
					_position = new Vector3(940.859f, 6494.330f, 20.462f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = Freeway_16.Vehicle3,
					_heading = 64.212f,
					_position = new Vector3(944.642f, 6500.654f, 20.824f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 4,
					_type = Globals.CarType.AIRUNIT,
					_modelname = Freeway_16.Vehicle4,
					_heading = 232.257f,
					_position = new Vector3(928.211f, 6503.833f, 20.258f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 5,
					_type = Globals.CarType.FIRE,
					_modelname = Freeway_16.Vehicle5,
					_heading = 51.898f,
					_position = new Vector3(959.018f, 6510.366f, 21.125f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "PRAIRIE",
					_heading = 36.367f,
					_position = new Vector3(944.332f, 6531.506f, 17.286f),
					_pitch =  0f,
					_roll = 180f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "YOUGA",
					_heading = 75.851f,
					_position = new Vector3(949.970f, 6505.972f, 20.605f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 8,
					_type = Globals.CarType.CIV,
					_modelname = "PENUMBRA",
					_heading = 91.166f,
					_position = new Vector3(931.336f, 6495.219f, 20.601f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 9,
					_type = Globals.CarType.TRUCK,
					_modelname = "FLATBED",
					_heading = 81.392f,
					_position = new Vector3(933.571f, 6524.186f, 19.318f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 16,
					_id = 10,
					_type = Globals.CarType.TRUCK,
					_modelname = "TOWTRUCK",
					_heading = 85.651f,
					_position = new Vector3(972.486f, 6495.400f, 20.970f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 17,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = BeachScene_17.Vehicle1,
					_heading = 103.529f,
					_position = new Vector3(-1469.534f, -1484.073f, 1.645f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 17,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = BeachScene_17.Vehicle2,
					_heading = 149.921f,
					_position = new Vector3(-1456.508f, -1493.975f, 1.625f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 17,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = BeachScene_17.Vehicle3,
					_heading = 164.831f,
					_position = new Vector3(-1475.311f, -1493.202f, 1.337f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 17,
					_id = 4,
					_type = Globals.CarType.EMS,
					_modelname = BeachScene_17.Vehicle4,
					_heading = 5.663f,
					_position = new Vector3(-1464.719f, -1489.411f, 1.559f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 17,
					_id = 5,
					_type = Globals.CarType.EMS,
					_modelname = BeachScene_17.Vehicle5,
					_heading = 155.153f,
					_position = new Vector3(-1461.632f, -1498.331f, 1.353f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 18,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = BeachScene_18.Vehicle1,
					_heading = 223.057f,
					_position = new Vector3(1259.571f, -2720.845f, 1.765f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 18,
					_id = 2,
					_type = Globals.CarType.POLICE,
					_modelname = BeachScene_18.Vehicle2,
					_heading = 214.492f,
					_position = new Vector3(1279.570f, -2721.151f, 1.825f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 18,
					_id = 3,
					_type = Globals.CarType.EMS,
					_modelname = BeachScene_18.Vehicle3,
					_heading = 195.861f,
					_position = new Vector3(1270.882f, -2725.300f, 1.844f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 18,
					_id = 4,
					_type = Globals.CarType.EMS,
					_modelname = BeachScene_18.Vehicle4,
					_heading = 196.313f,
					_position = new Vector3(1264.145f, -2728.974f, 1.400f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 18,
					_id = 5,
					_type = Globals.CarType.EMS,
					_modelname = BeachScene_18.Vehicle5,
					_heading = 143.615f,
					_position = new Vector3(1276.552f, -2728.071f, 1.528f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 19,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_19.Vehicle1,
					_heading = 71.618f,
					_position = new Vector3(201.245f, -47.310f, 68.225f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 19,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_19.Vehicle2,
					_heading = 50.293f,
					_position = new Vector3(192.137f, -41.139f, 68.238f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 20,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_20.Vehicle1,
					_heading = 64.414f,
					_position = new Vector3(-1287.977f, -1134.500f, 5.794f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 20,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_20.Vehicle2,
					_heading = 358.204f,
					_position = new Vector3(-1295.550f, -1125.820f, 6.049f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 21,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_21.Vehicle1,
					_heading = 337.598f,
					_position = new Vector3(-1624.427f, -434.905f, 38.932f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 21,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_21.Vehicle2,
					_heading = 220.558f,
					_position = new Vector3(-1621.928f, -447.045f, 38.601f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 22,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_22.Vehicle1,
					_heading = 353.453f,
					_position = new Vector3(192.238f, -805.462f, 30.547f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 22,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_22.Vehicle2,
					_heading = 340.074f,
					_position = new Vector3(198.180f, -796.702f, 31.204f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 23,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_23.Vehicle1,
					_heading = 125.912f,
					_position = new Vector3(1663.164f, 4828.806f, 41.614f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 23,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_23.Vehicle2,
					_heading = 185.990f,
					_position = new Vector3(1666.736f, 4817.709f, 41.686f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 24,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_24.Vehicle1,
					_heading = 356.389f,
					_position = new Vector3(858.809f, 4326.983f, 50.942f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 24,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_24.Vehicle2,
					_heading = 205.469f,
					_position = new Vector3(855.992f, 4338.159f, 51.377f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 25,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_25.Vehicle1,
					_heading = 334.299f,
					_position = new Vector3(596.711f, 2725.525f, 41.295f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 25,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_25.Vehicle2,
					_heading = 76.221f,
					_position = new Vector3(602.201f, 2732.125f, 41.751f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 26,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_26.Vehicle1,
					_heading = 185.920f,
					_position = new Vector3(2501.489f, 4094.654f, 37.819f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 26,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_26.Vehicle2,
					_heading = 258.531f,
					_position = new Vector3(2498.874f, 4082.164f, 38.041f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 27,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_27.Vehicle1,
					_heading = 291.038f,
					_position = new Vector3(-717.183f, 5776.953f, 17.335f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 27,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_27.Vehicle2,
					_heading = 246.050f,
					_position = new Vector3(-707.627f, 5780.820f, 17.066f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 28,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_28.Vehicle1,
					_heading = 85.662f,
					_position = new Vector3(1695.542f, 6415.463f, 32.026f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 28,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_28.Vehicle2,
					_heading = 7.288f,
					_position = new Vector3(1686.275f, 6421.746f, 32.100f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 29,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_29.Vehicle1,
					_heading = 341.797f,
					_position = new Vector3(-1524.389f, 4907.434f, 65.985f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 29,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_29.Vehicle2,
					_heading = 144.985f,
					_position = new Vector3(-1517.592f, 4920.370f, 66.350f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 30,
					_id = 1,
					_type = Globals.CarType.POLICE,
					_modelname = RunOver_30.Vehicle1,
					_heading = 312.544f,
					_position = new Vector3(-98.823f, 6423.154f, 30.988f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 30,
					_id = 2,
					_type = Globals.CarType.EMS,
					_modelname = RunOver_30.Vehicle2,
					_heading = 274.477f,
					_position = new Vector3(-81.841f, 6428.882f, 31.220f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 31,
					_id = 1,
					_type = Globals.CarType.CIV,
					_modelname = "WINDSOR2",
					_heading = 291.573f,
					_position = new Vector3(-1000.132f, 785.339f, 171.131f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 31,
					_id = 2,
					_type = Globals.CarType.CIV,
					_modelname = "JACKAL",
					_heading = 206.850f,
					_position = new Vector3(-998.377f, 792.699f, 171.598f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 31,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "FELON2",
					_heading = 35.148f,
					_position = new Vector3(-995.638f, 788.295f, 171.835f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 31,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "F620",
					_heading = 220.886f,
					_position = new Vector3(-991.897f, 783.610f, 172.315f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 31,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "GRESLEY",
					_heading = 224.036f,
					_position = new Vector3(-987.817f, 779.246f, 173.338f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 31,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "CAVALCADE",
					_heading = 38.762f,
					_position = new Vector3(-988.223f, 791.421f, 172.810f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 31,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "NINEF2",
					_heading = 41.683f,
					_position = new Vector3(-984.905f, 787.070f, 172.973f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 32,
					_id = 1,
					_type = Globals.CarType.CIV,
					_modelname = "BUFFALO2",
					_heading = 278.449f,
					_position = new Vector3(-1944.181f, 384.616f, 96.027f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 32,
					_id = 2,
					_type = Globals.CarType.CIV,
					_modelname = "BODHI2",
					_heading = 278.369f,
					_position = new Vector3(-1950.282f, 384.080f, 95.233f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 32,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "ALPHA",
					_heading = 85.040f,
					_position = new Vector3(-1956.279f, 383.580f, 94.091f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 32,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "COMET2",
					_heading = 277.910f,
					_position = new Vector3(-1949.348f, 400.593f, 95.906f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 32,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "CARBONIZZARE",
					_heading = 276.591f,
					_position = new Vector3(-1955.606f, 399.694f, 95.798f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 32,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "JESTER",
					_heading = 6.867f,
					_position = new Vector3(-1958.000f, 393.515f, 95.169f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 32,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "MAMBA",
					_heading = 5.169f,
					_position = new Vector3(-1959.660f, 406.132f, 96.374f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 33,
					_id = 1,
					_type = Globals.CarType.CIV,
					_modelname = "NIGHTSHADE",
					_heading = 307.126f,
					_position = new Vector3(0.458f, 542.591f, 173.553f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 33,
					_id = 2,
					_type = Globals.CarType.CIV,
					_modelname = "BUFFALO2",
					_heading = 237.035f,
					_position = new Vector3(16.414f, 549.334f, 175.924f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 33,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "TAMPA",
					_heading = 245.350f,
					_position = new Vector3(15.084f, 546.495f, 175.541f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 33,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "VIRGO",
					_heading = 122.161f,
					_position = new Vector3(10.931f, 550.032f, 175.535f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 33,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "KHAMELION",
					_heading = 80.773f,
					_position = new Vector3(11.170f, 544.563f, 175.087f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 33,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "BANSHEE",
					_heading = 300.822f,
					_position = new Vector3(15.868f, 553.347f, 176.390f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 33,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "DUBSTA2",
					_heading = 121.673f,
					_position = new Vector3(4.622f, 545.994f, 174.506f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 1,
					_type = Globals.CarType.CIV,
					_modelname = "SLAMVAN2",
					_heading = 203.97f,
					_position = new Vector3(912.66f, -484.59f, 58.67f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 2,
					_type = Globals.CarType.CIV,
					_modelname = "TORNADO6",
					_heading = 25.44f,
					_position = new Vector3(915.15f, -490.21f, 58.73f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "DAEMON",
					_heading = 205.08f,
					_position = new Vector3(912.51f, -492.51f, 58.42f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "INNOVATION",
					_heading = 206.61f,
					_position = new Vector3(911.43f, -492.90f, 58.40f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "HEXER",
					_heading = 203.47f,
					_position = new Vector3(910.29f, -493.25f, 58.37f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "SOVEREIGN",
					_heading = 75.40f,
					_position = new Vector3(910.86f, -479.36f, 58.49f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "SANCTUS",
					_heading = 205.57f,
					_position = new Vector3(907.59f, -479.88f, 58.53f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 8,
					_type = Globals.CarType.CIV,
					_modelname = "ZOMBIEB",
					_heading = 113.71f,
					_position = new Vector3(909.73f, -489.99f, 58.45f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 9,
					_type = Globals.CarType.CIV,
					_modelname = "DEFILER",
					_heading = 70.11f,
					_position = new Vector3(909.67f, -477.18f, 58.53f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 34,
					_id = 10,
					_type = Globals.CarType.CIV,
					_modelname = "BAGGER",
					_heading = 74.53f,
					_position = new Vector3(910.14f, -478.19f, 58.50f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 35,
					_id = 1,
					_type = Globals.CarType.CIV,
					_modelname = "COMET2",
					_heading = 231.618f,
					_position = new Vector3(-1893.725f, -565.024f, 11.346f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 35,
					_id = 2,
					_type = Globals.CarType.CIV,
					_modelname = "COQUETTE3",
					_heading = 113.386f,
					_position = new Vector3(-1904.042f, -558.801f, 11.222f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 35,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "ROCOTO",
					_heading = 142.470f,
					_position = new Vector3(-1901.548f, -560.752f, 11.665f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 35,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "SURANO",
					_heading = 201.991f,
					_position = new Vector3(-1897.735f, -562.150f, 11.410f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 35,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "SUPERD",
					_heading = 229.922f,
					_position = new Vector3(-1891.122f, -563.038f, 11.239f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 35,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "VACCA",
					_heading = 233.298f,
					_position = new Vector3(-1896.131f, -559.021f, 11.247f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 35,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "VOLTIC",
					_heading = 220.988f,
					_position = new Vector3(-1899.927f, -555.999f, 11.323f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 36,
					_id = 1,
					_type = Globals.CarType.CIV,
					_modelname = "VERLIERER2",
					_heading = 284.633f,
					_position = new Vector3(-3018.389f, 741.100f, 27.093f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 36,
					_id = 2,
					_type = Globals.CarType.CIV,
					_modelname = "KHAMELION",
					_heading = 286.336f,
					_position = new Vector3(-3017.818f, 738.280f, 26.840f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 36,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "CHEETAH",
					_heading = 272.798f,
					_position = new Vector3(-3024.027f, 740.000f, 25.862f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 36,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "T20",
					_heading = 269.865f,
					_position = new Vector3(-3024.455f, 737.059f, 25.881f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 36,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "ADDER",
					_heading = 263.501f,
					_position = new Vector3(-3030.598f, 737.108f, 24.035f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 36,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "OSIRIS",
					_heading = 258.816f,
					_position = new Vector3(-3030.403f, 740.378f, 23.947f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 36,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "ZENTORNO",
					_heading = 230.975f,
					_position = new Vector3(-3035.830f, 740.402f, 22.258f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 37,
					_id = 1,
					_type = Globals.CarType.CIV,
					_modelname = "HOTKNIFE",
					_heading = 217.850f,
					_position = new Vector3(-190.215f, 6389.914f, 31.179f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 37,
					_id = 2,
					_type = Globals.CarType.CIV,
					_modelname = "VOODOO",
					_heading = 224.829f,
					_position = new Vector3(-193.624f, 6394.687f, 31.362f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 37,
					_id = 3,
					_type = Globals.CarType.CIV,
					_modelname = "GAUNTLET2",
					_heading = 226.167f,
					_position = new Vector3(-195.581f, 6392.640f, 31.445f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 37,
					_id = 4,
					_type = Globals.CarType.CIV,
					_modelname = "BUCCANEER2",
					_heading = 214.131f,
					_position = new Vector3(-199.891f, 6397.063f, 31.049f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 37,
					_id = 5,
					_type = Globals.CarType.CIV,
					_modelname = "DOMINATOR2",
					_heading = 225.075f,
					_position = new Vector3(-198.753f, 6400.061f, 31.152f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 37,
					_id = 6,
					_type = Globals.CarType.CIV,
					_modelname = "BRAWLER",
					_heading = 218.096f,
					_position = new Vector3(-203.639f, 6404.204f, 31.713f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				CarList.Add(new Globals.Cars
				{
					_calloutid = 37,
					_id = 7,
					_type = Globals.CarType.CIV,
					_modelname = "SANDKING2",
					_heading = 205.913f,
					_position = new Vector3(-207.967f, 6410.284f, 31.378f),
					_pitch =  0f,
					_roll = 0f,
					_yaw = 	0f
				});

				#endregion Vehicles

				#region Peds
				HumanList.Add(new Globals.Humans
				{
					_calloutid = 1,
					_type = Globals.HumanType.COP,
					_modelname = DrifterScene_01.Ped1,
					_heading = 247.183f,
					_position = new Vector3(-1045.254f, 1183.144f, 216.830f),
					_animdir = "amb@world_human_cop_idles@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 1,
					_type = Globals.HumanType.COP,
					_modelname = DrifterScene_01.Ped2,
					_heading = 276.67f,
					_position = new Vector3(-1063.37f, 1178.48f, 215.98f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 1,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_ktown_02",
					_heading = 21.609f,
					_position = new Vector3(-1052.018f, 1183.869f, 216.535f),
					_animdir = "friends@frt@ig_1",
					_animname = "trevor_impatient_wait_4",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 1,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_garbage",
					_heading = 292.99f,
					_position = new Vector3(-1060.13f, 1183.09f, 216.38f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 1,
					_type = Globals.HumanType.MEDIC,
					_modelname = DrifterScene_01.Ped3,
					_heading = 198.840f,
					_position = new Vector3(-1052.047f, 1184.679f, 216.602f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 2,
					_type = Globals.HumanType.COP,
					_modelname = DrifterScene_02.Ped1,
					_heading = 263.418f,
					_position = new Vector3(2337.813f, 5225.198f, 59.880f),
					_animdir = "amb@world_human_cop_idles@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 2,
					_type = Globals.HumanType.COP,
					_modelname = DrifterScene_02.Ped2,
					_heading = 80.129f,
					_position = new Vector3(2317.369f, 5216.044f, 59.661f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 2,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_eastsa_02",
					_heading = 271.579f,
					_position = new Vector3(2321.593f, 5214.175f, 59.696f),
					_animdir = "friends@frt@ig_1",
					_animname = "trevor_impatient_wait_4",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 2,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_dockwork_01",
					_heading = 134.358f,
					_position = new Vector3(2316.845f, 5218.127f, 59.903f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 2,
					_type = Globals.HumanType.MEDIC,
					_modelname = DrifterScene_02.Ped3,
					_heading = 79.519f,
					_position = new Vector3(2323.364f, 5213.459f, 59.814f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 3,
					_type = Globals.HumanType.COP,
					_modelname = DrifterScene_03.Ped1,
					_heading = 7.199f,
					_position = new Vector3(-1293.762f, 5258.086f, 52.278f),
					_animdir = "amb@world_human_cop_idles@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 3,
					_type = Globals.HumanType.COP,
					_modelname = DrifterScene_03.Ped2,
					_heading = 275.440f,
					_position = new Vector3(-1285.550f, 5267.719f, 51.595f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 3,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_indian_01",
					_heading = 237.264f,
					_position = new Vector3(-1293.895f, 5259.494f, 52.221f),
					_animdir = "friends@frt@ig_1",
					_animname = "trevor_impatient_wait_4",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 3,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_trucker_01",
					_heading = 344.882f,
					_position = new Vector3(-1300.590f, 5255.784f, 52.698f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 3,
					_type = Globals.HumanType.MEDIC,
					_modelname = DrifterScene_03.Ped3,
					_heading = 72.873f,
					_position = new Vector3(-1292.280f, 5258.943f, 52.168f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_04.Ped1,
					_heading = 114.838f,
					_position = new Vector3(1204.078f, 1317.481f, 144.922f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_04.Ped2,
					_heading = 182.015f,
					_position = new Vector3(1212.726f, 1311.980f, 144.223f),
					_animdir = "amb@world_human_cop_idles@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_malibu_01",
					_heading = 286.359f,
					_position = new Vector3(1203.031f, 1316.959f, 145.020f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_bevhills_01",
					_heading = 66.182f,
					_position = new Vector3(1232.041f, 1309.477f, 143.741f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "u_m_y_cyclist_01",
					_heading = 44.732f,
					_position = new Vector3(1212.212f, 1308.882f, 144.207f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_victim",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_04.Ped3,
					_heading = 316.921f,
					_position = new Vector3(1212.079f, 1308.352f, 144.215f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_paramedic",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_04.Ped3,
					_heading = 116.964f,
					_position = new Vector3(1213.333f, 1308.708f, 144.122f),
					_animdir = "mini@cpr@char_a@cpr_str",
					_animname = "cpr_kol_idle",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_04.Ped3,
					_heading = 191.010f,
					_position = new Vector3(1212.071f, 1310.278f, 144.228f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 4,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_04.Ped4,
					_heading = 15.699f,
					_position = new Vector3(1216.588f, 1294.832f, 143.495f),
					_animdir = "missbigscore2aig_3",
					_animname = "wait_for_van_c",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_05.Ped1,
					_heading = 307.651f,
					_position = new Vector3(-221.438f, 3882.257f, 37.604f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_05.Ped2,
					_heading = 182.015f,
					_position = new Vector3(-238.790f, 3861.241f, 33.330f),
					_animdir = "amb@world_human_cop_idles@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_downtown_01",
					_heading = 104.445f,
					_position = new Vector3(-220.274f, 3883.289f, 37.469f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_ktown_01",
					_heading = 164.291f,
					_position = new Vector3(-235.399f, 3873.515f, 37.226f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_motox_01",
					_heading = 172.926f,
					_position = new Vector3(-235.640f, 3857.292f, 32.700f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_victim",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_05.Ped3,
					_heading = 81.120f,
					_position = new Vector3(-234.889f, 3857.426f, 32.612f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_paramedic",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_05.Ped3,
					_heading = 112.678f,
					_position = new Vector3(-234.884f, 3858.355f, 32.464f),
					_animdir = "mini@cpr@char_a@cpr_str",
					_animname = "cpr_kol_idle",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_05.Ped3,
					_heading = 325.482f,
					_position = new Vector3(-236.297f, 3855.736f, 32.498f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 5,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_05.Ped4,
					_heading = 208.101f,
					_position = new Vector3(-249.378f, 3880.697f, 39.830f),
					_animdir = "missbigscore2aig_3",
					_animname = "wait_for_van_c",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_06.Ped1,
					_heading = 201.035f,
					_position = new Vector3(-1291.771f, 4616.263f, 120.495f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_06.Ped2,
					_heading = 238.811f,
					_position = new Vector3(-1282.680f, 4609.482f, 122.673f),
					_animdir = "amb@world_human_cop_idles@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_construct_01",
					_heading = 84.842f,
					_position = new Vector3(-1272.138f, 4606.448f, 125.035f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_construct_02",
					_heading = 98.471f,
					_position = new Vector3(-1272.063f, 4607.672f, 125.039f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_dhill_01",
					_heading = 171.093f,
					_position = new Vector3(-1278.969f, 4606.341f, 123.613f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_victim",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_06.Ped3,
					_heading = 268.178f,
					_position = new Vector3(-1279.491f, 4606.726f, 123.491f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_paramedic",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_06.Ped3,
					_heading = 220.507f,
					_position = new Vector3(-1279.054f, 4607.395f, 123.475f),
					_animdir = "mini@cpr@char_a@cpr_str",
					_animname = "cpr_kol_idle",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.MEDIC,
					_modelname = CyclistScene_06.Ped3,
					_heading = 72.509f,
					_position = new Vector3(-1277.918f, 4606.016f, 123.837f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 6,
					_type = Globals.HumanType.COP,
					_modelname = CyclistScene_06.Ped4,
					_heading = 257.246f,
					_position = new Vector3(-1293.051f, 4615.092f, 120.096f),
					_animdir = "missbigscore2aig_3",
					_animname = "wait_for_van_c",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.COP,
					_modelname = CornerCut_07.Ped1,
					_heading = 175.786f,
					_position = new Vector3(-2019.386f, 1925.350f, 186.261f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.COP,
					_modelname = CornerCut_07.Ped2,
					_heading = 354.733f,
					_position = new Vector3(-2018.811f, 1949.172f, 173.838f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_hairdress_01",
					_heading = 101.643f,
					_position = new Vector3(-2013.544f, 1926.649f, 185.797f),
					_animdir = "amb@world_human_stupor@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_bevhills_04",
					_heading = 251.113f,
					_position = new Vector3(-2025.760f, 1928.252f, 186.045f),
					_animdir = "mini@hookers_spvanilla",
					_animname = "idle_wait",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_garbage",
					_heading = 294.281f,
					_position = new Vector3(-2029.477f, 1946.693f, 179.308f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.MEDIC,
					_modelname = CornerCut_07.Ped3,
					_heading = 16.158f,
					_position = new Vector3(-2044.184f, 1945.188f, 187.254f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.MEDIC,
					_modelname = CornerCut_07.Ped3,
					_heading = 29.219f,
					_position = new Vector3(-2013.375f, 1925.699f, 185.922f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.FIREMAN,
					_modelname = CornerCut_07.Ped4,
					_heading = 273.578f,
					_position = new Vector3(-2029.136f, 1948.219f, 179.179f),
					_animdir = "missfbi_s4mop",
					_animname = "guard_idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 7,
					_type = Globals.HumanType.FIREMAN,
					_modelname = CornerCut_07.Ped4,
					_heading = 190.180f,
					_position = new Vector3(-2044.264f, 1946.008f, 187.360f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male2",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.COP,
					_modelname = CornerCut_08.Ped1,
					_heading = 29.103f,
					_position = new Vector3(3011.251f, 3386.991f, 73.559f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.COP,
					_modelname = CornerCut_08.Ped2,
					_heading = 309.816f,
					_position = new Vector3(3021.733f, 3368.067f, 74.887f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "u_f_y_comjane",
					_heading = 65.111f,
					_position = new Vector3(3024.616f, 3373.269f, 74.888f),
					_animdir = "amb@world_human_stupor@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_chemsec_01",
					_heading = 156.232f,
					_position = new Vector3(3011.987f, 3380.560f, 73.836f),
					_animdir = "amb@world_human_stand_guard@male@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_trucker_01",
					_heading = 236.486f,
					_position = new Vector3(3017.656f, 3374.783f, 74.374f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.MEDIC,
					_modelname = CornerCut_08.Ped3,
					_heading = 309.557f,
					_position = new Vector3(3010.960f, 3379.623f, 73.883f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.MEDIC,
					_modelname = CornerCut_08.Ped3,
					_heading = 327.989f,
					_position = new Vector3(3023.985f, 3372.323f, 74.865f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.FIREMAN,
					_modelname = CornerCut_08.Ped4,
					_heading = 261.262f,
					_position = new Vector3(3017.045f, 3373.650f, 74.439f),
					_animdir = "missfbi_s4mop",
					_animname = "guard_idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 8,
					_type = Globals.HumanType.FIREMAN,
					_modelname = CornerCut_08.Ped4,
					_heading = 359.973f,
					_position = new Vector3(3012.075f, 3379.056f, 73.946f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male2",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.COP,
					_modelname = CornerCut_09.Ped1,
					_heading = 88.574f,
					_position = new Vector3(-2060.425f, 4452.528f, 58.249f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.COP,
					_modelname = CornerCut_09.Ped2,
					_heading = 190.201f,
					_position = new Vector3(-2038.521f, 4463.636f, 57.309f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_eastsa_01",
					_heading = 135.727f,
					_position = new Vector3(-2043.423f, 4463.065f, 57.479f),
					_animdir = "amb@world_human_stupor@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_business_01",
					_heading = 254.275f,
					_position = new Vector3(-2066.818f, 4461.703f, 58.524f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_trucker_01",
					_heading = 10.977f,
					_position = new Vector3(-2037.682f, 4459.802f, 57.253f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.MEDIC,
					_modelname = CornerCut_09.Ped3,
					_heading = 213.936f,
					_position = new Vector3(-2043.973f, 4463.666f, 57.488f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.MEDIC,
					_modelname = CornerCut_09.Ped3,
					_heading = 343.107f,
					_position = new Vector3(-2043.842f, 4461.840f, 57.502f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.FIREMAN,
					_modelname = CornerCut_09.Ped4,
					_heading = 2.539f,
					_position = new Vector3(-2061.173f, 4451.427f, 58.298f),
					_animdir = "missfbi_s4mop",
					_animname = "guard_idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 9,
					_type = Globals.HumanType.FIREMAN,
					_modelname = CornerCut_09.Ped4,
					_heading = 68.000f,
					_position = new Vector3(-2036.810f, 4460.365f, 57.271f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male2",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 10,
					_type = Globals.HumanType.COP,
					_modelname = TruckCrash_10.Ped1,
					_heading = 2.450f,
					_position = new Vector3(1899.544f, -1286.181f, 129.992f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 10,
					_type = Globals.HumanType.COP,
					_modelname = TruckCrash_10.Ped2,
					_heading = 197.247f,
					_position = new Vector3(1914.843f, -1303.829f, 132.613f),
					_animdir = "amb@world_human_cop_idles@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 10,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_gaffer_01",
					_heading = 188.900f,
					_position = new Vector3(1899.125f, -1284.800f, 129.768f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 10,
					_type = Globals.HumanType.MEDIC,
					_modelname = TruckCrash_10.Ped3,
					_heading = 37.861f,
					_position = new Vector3(1908.185f, -1240.848f, 122.851f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 10,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_10.Ped4,
					_heading = 332.846f,
					_position = new Vector3(1912.811f, -1253.557f, 125.852f),
					_animdir = "amb@code_human_police_investigate@idle_b",
					_animname = "idle_f",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 10,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_10.Ped4,
					_heading = 220.724f,
					_position = new Vector3(1915.884f, -1243.342f, 124.570f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 10,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_10.Ped4,
					_heading = 47.740f,
					_position = new Vector3(1910.844f, -1264.521f, 127.174f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 11,
					_type = Globals.HumanType.COP,
					_modelname = TruckCrash_11.Ped1,
					_heading = 271.738f,
					_position = new Vector3(-967.705f, 2746.983f, 25.430f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 11,
					_type = Globals.HumanType.COP,
					_modelname = TruckCrash_11.Ped2,
					_heading = 256.132f,
					_position = new Vector3(-955.957f, 2760.349f, 25.441f),
					_animdir = "amb@world_human_cop_idles@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 11,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_gaffer_01",
					_heading = 92.619f,
					_position = new Vector3(-966.272f, 2747.096f, 25.435f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 11,
					_type = Globals.HumanType.MEDIC,
					_modelname = TruckCrash_11.Ped3,
					_heading = 26.750f,
					_position = new Vector3(-985.295f, 2756.408f, 25.223f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 11,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_11.Ped4,
					_heading = 77.311f,
					_position = new Vector3(-977.856f, 2764.493f, 25.223f),
					_animdir = "amb@code_human_police_investigate@idle_b",
					_animname = "idle_f",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 11,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_11.Ped4,
					_heading = 1.578f,
					_position = new Vector3(-989.375f, 2762.535f, 24.430f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 11,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_11.Ped4,
					_heading = 141.563f,
					_position = new Vector3(-980.000f, 2768.768f, 24.193f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 12,
					_type = Globals.HumanType.COP,
					_modelname = TruckCrash_12.Ped1,
					_heading = 86.023f,
					_position = new Vector3(-814.402f, 5265.119f, 87.988f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 12,
					_type = Globals.HumanType.COP,
					_modelname = TruckCrash_12.Ped2,
					_heading = 326.637f,
					_position = new Vector3(-846.794f, 5265.902f, 86.694f),
					_animdir = "amb@world_human_cop_idles@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 12,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_construct_02",
					_heading = 253.527f,
					_position = new Vector3(-815.892f, 5265.535f, 87.934f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 12,
					_type = Globals.HumanType.MEDIC,
					_modelname = TruckCrash_12.Ped3,
					_heading = 72.551f,
					_position = new Vector3(-821.031f, 5263.485f, 87.717f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 12,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_12.Ped4,
					_heading = 241.283f,
					_position = new Vector3(-843.735f, 5275.688f, 77.264f),
					_animdir = "amb@code_human_police_investigate@idle_b",
					_animname = "idle_f",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 12,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_12.Ped4,
					_heading = 190.855f,
					_position = new Vector3(-837.199f, 5277.416f, 78.891f),
					_animdir = "amb@world_human_guard_patrol@male@idle_b",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 12,
					_type = Globals.HumanType.FIREMAN,
					_modelname = TruckCrash_12.Ped4,
					_heading = 188.637f,
					_position = new Vector3(-841.179f, 5278.418f, 76.899f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_13.Ped1,
					_heading = 355.067f,
					_position = new Vector3(1802.023f, -838.791f, 74.501f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_13.Ped2,
					_heading = 130.733f,
					_position = new Vector3(1783.484f, -850.578f, 73.112f),
					_animdir = "missheist_agency2aig_1",
					_animname = "direct_traffic_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_13.Ped3,
					_heading = 329.200f,
					_position = new Vector3(1816.196f, -844.985f, 74.978f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_eastsa_02",
					_heading = 168.912f,
					_position = new Vector3(1812.726f, -830.722f, 75.360f),
					_animdir = "misscarsteal3",
					_animname = "racer_argue_01_a",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_f_y_sweatshop_01",
					_heading = 169.445f,
					_position = new Vector3(1802.269f, -836.781f, 74.501f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_strvend_01",
					_heading = 158.342f,
					_position = new Vector3(1816.877f, -843.788f, 74.987f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_a_male1",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_dockwork_01",
					_heading = 165.076f,
					_position = new Vector3(1814.224f, -826.630f, 75.509f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_dockwork_01",
					_heading = 37.157f,
					_position = new Vector3(1803.564f, -850.751f, 74.052f),
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_13.Ped4,
					_heading = 297.624f,
					_position = new Vector3(1798.295f, -840.991f, 74.207f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_13.Ped4,
					_heading = 299.376f,
					_position = new Vector3(1812.120f, -832.190f, 75.319f),
					_animdir = "missbigscore2aig_3",
					_animname = "wait_for_van_c",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_13.Ped4,
					_heading = 319.331f,
					_position = new Vector3(1826.737f, -819.553f, 76.554f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_13.Ped5,
					_heading = 118.253f,
					_position = new Vector3(1799.496f, -840.309f, 74.302f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male2",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_13.Ped5,
					_heading = 39.784f,
					_position = new Vector3(1813.372f, -832.104f, 75.409f),
					_animdir = "amb@code_human_police_investigate@idle_b",
					_animname = "idle_f",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 13,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_13.Ped5,
					_heading = 73.266f,
					_position = new Vector3(1816.777f, -829.963f, 75.680f),
					_animdir = "missfbi_s4mop",
					_animname = "guard_idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_14.Ped1,
					_heading = 36.047f,
					_position = new Vector3(2519.739f, 5509.815f, 44.680f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_14.Ped2,
					_heading = 210.891f,
					_position = new Vector3(2524.369f, 5493.109f, 44.622f),
					_animdir = "missheist_agency2aig_1",
					_animname = "direct_traffic_b",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_14.Ped3,
					_heading = 42.714f,
					_position = new Vector3(2491.518f, 5540.463f, 44.751f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_eastsa_02",
					_heading = 140.688f,
					_position = new Vector3(2513.784f, 5524.726f, 44.718f),
					_animdir = "misscarsteal3",
					_animname = "racer_argue_01_a",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_f_y_sweatshop_01",
					_heading = 220.101f,
					_position = new Vector3(2518.532f, 5511.224f, 44.678f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_strvend_01",
					_heading = 211.410f,
					_position = new Vector3(2501.609f, 5519.229f, 44.636f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_a_male1",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_dockwork_01",
					_heading = 239.571f,
					_position = new Vector3(2506.589f, 5523.658f, 44.707f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_dockwork_01",
					_heading = 142.712f,
					_position = new Vector3(2526.825f, 5527.298f, 44.663f),
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_14.Ped4,
					_heading = 339.308f,
					_position = new Vector3(2513.207f, 5523.220f, 44.704f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_14.Ped4,
					_heading = 7.828f,
					_position = new Vector3(2517.471f, 5514.229f, 44.687f),
					_animdir = "missbigscore2aig_3",
					_animname = "wait_for_van_c",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_14.Ped4,
					_heading = 204.957f,
					_position = new Vector3(2505.178f, 5540.857f, 44.750f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_14.Ped5,
					_heading = 7.178f,
					_position = new Vector3(2505.342f, 5539.651f, 44.745f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male2",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_14.Ped5,
					_heading = 31.394f,
					_position = new Vector3(2502.487f, 5517.872f, 44.643f),
					_animdir = "amb@code_human_police_investigate@idle_b",
					_animname = "idle_f",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 14,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_14.Ped5,
					_heading = 191.833f,
					_position = new Vector3(2517.201f, 5515.741f, 44.694f),
					_animdir = "missfbi_s4mop",
					_animname = "guard_idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_15.Ped1,
					_heading = 109.052f,
					_position = new Vector3(-481.921f, -507.975f, 25.240f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_15.Ped2,
					_heading = 278.669f,
					_position = new Vector3(-466.122f, -506.249f, 25.297f),
					_animdir = "missheist_agency2aig_1",
					_animname = "direct_traffic_c",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_15.Ped3,
					_heading = 68.883f,
					_position = new Vector3(-497.564f, -503.545f, 25.323f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_ballasout_01",
					_heading = 73.470f,
					_position = new Vector3(-492.038f, -509.855f, 25.178f),
					_animdir = "misscarsteal3",
					_animname = "racer_argue_01_a",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_business_01",
					_heading = 312.475f,
					_position = new Vector3(-483.343f, -508.941f, 25.208f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_prolhost_01",
					_heading = 249.949f,
					_position = new Vector3(-499.148f, -502.606f, 25.323f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_a_male1",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_dockwork_01",
					_heading = 242.674f,
					_position = new Vector3(-497.091f, -511.143f, 25.139f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_dockwork_01",
					_heading = 261.913f,
					_position = new Vector3(-488.322f, -511.814f, 25.123f),
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_15.Ped4,
					_heading = 15.182f,
					_position = new Vector3(-482.000f, -508.991f, 25.206f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_15.Ped4,
					_heading = 232.883f,
					_position = new Vector3(-493.649f, -508.698f, 25.216f),
					_animdir = "missbigscore2aig_3",
					_animname = "wait_for_van_c",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_15.Ped4,
					_heading = 256.470f,
					_position = new Vector3(-502.939f, -508.109f, 25.235f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_15.Ped5,
					_heading = 213.073f,
					_position = new Vector3(-482.541f, -507.815f, 25.245f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male2",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_15.Ped5,
					_heading = 282.008f,
					_position = new Vector3(-493.308f, -509.993f, 25.173f),
					_animdir = "amb@code_human_police_investigate@idle_b",
					_animname = "idle_f",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 15,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_15.Ped5,
					_heading = 236.253f,
					_position = new Vector3(-487.674f, -510.800f, 25.146f),
					_animdir = "missfbi_s4mop",
					_animname = "guard_idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_16.Ped1,
					_heading = 136.961f,
					_position = new Vector3(942.029f, 6521.069f, 18.851f),
					_animdir = "missheist_agency3aig_24",
					_animname = "agent01_conversation",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_16.Ped2,
					_heading = 261.237f,
					_position = new Vector3(986.322f, 6495.624f, 20.987f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.COP,
					_modelname = Freeway_16.Ped3,
					_heading = 121.511f,
					_position = new Vector3(935.589f, 6495.197f, 21.125f),
					_animdir = "amb@world_human_cop_idles@male@idle_b",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beachvesp_02",
					_heading = 351.793f,
					_position = new Vector3(941.026f, 6520.223f, 18.868f),
					_animdir = "misscarsteal3",
					_animname = "racer_argue_01_a",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "u_f_y_comjane",
					_heading = 171.736f,
					_position = new Vector3(947.529f, 6504.476f, 21.073f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "u_m_o_taphillbilly",
					_heading = 298.579f,
					_position = new Vector3(934.069f, 6494.307f, 21.132f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_a_male1",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_dockwork_01",
					_heading = 307.480f,
					_position = new Vector3(941.506f, 6531.092f, 17.847f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_dockwork_01",
					_heading = 37.936f,
					_position = new Vector3(968.497f, 6497.731f, 21.016f),
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_16.Ped4,
					_heading = 321.095f,
					_position = new Vector3(946.707f, 6503.089f, 21.089f),
					_animdir = "amb@world_human_stand_guard@male@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_16.Ped4,
					_heading = 223.176f,
					_position = new Vector3(939.801f, 6521.517f, 18.881f),
					_animdir = "missbigscore2aig_3",
					_animname = "wait_for_van_c",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.MEDIC,
					_modelname = Freeway_16.Ped4,
					_heading = 336.603f,
					_position = new Vector3(931.115f, 6504.478f, 21.135f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_16.Ped5,
					_heading = 106.773f,
					_position = new Vector3(932.536f, 6505.038f, 21.143f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male2",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_16.Ped5,
					_heading = 108.702f,
					_position = new Vector3(940.505f, 6521.731f, 18.898f),
					_animdir = "amb@code_human_police_investigate@idle_b",
					_animname = "idle_f",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 16,
					_type = Globals.HumanType.FIREMAN,
					_modelname = Freeway_16.Ped5,
					_heading = 352.787f,
					_position = new Vector3(943.426f, 6530.157f, 18.029f),
					_animdir = "missfbi_s4mop",
					_animname = "guard_idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.COP,
					_modelname = BeachScene_17.Ped1,
					_heading = 312.822f,
					_position = new Vector3(-1463.149f, -1492.240f, 1.950f),
					_animdir = "rcmnigel1a",
					_animname = "stop",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.COP,
					_modelname = BeachScene_17.Ped2,
					_heading = 297.238f,
					_position = new Vector3(-1465.749f, -1486.366f, 2.119f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.MEDIC,
					_modelname = BeachScene_17.Ped3,
					_heading = 220.117f,
					_position = new Vector3(-1472.865f, -1489.028f, 1.887f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.MEDIC,
					_modelname = BeachScene_17.Ped3,
					_heading = 251.737f,
					_position = new Vector3(-1469.333f, -1496.855f, 1.568f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.LIFEGUARD,
					_modelname = BeachScene_17.Ped4,
					_heading = 135.303f,
					_position = new Vector3(-1467.284f, -1496.907f, 1.615f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_paramedic",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.LIFEGUARD,
					_modelname = BeachScene_17.Ped5,
					_heading = 9.677f,
					_position = new Vector3(-1467.292f, -1498.046f, 1.556f),
					_animdir = "mini@cpr@char_a@cpr_str",
					_animname = "cpr_kol",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_surfer_01",
					_heading = 41.107f,
					_position = new Vector3(-1467.893f, -1497.106f, 1.590f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_victim",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_beach_02",
					_heading = 149.623f,
					_position = new Vector3(-1465.390f, -1483.716f, 2.145f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_beach_01",
					_heading = 147.280f,
					_position = new Vector3(-1463.935f, -1486.130f, 2.131f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_beach_01",
					_heading = 124.484f,
					_position = new Vector3(-1461.344f, -1489.882f, 2.078f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_beach_01",
					_heading = 116.920f,
					_position = new Vector3(-1459.970f, -1492.092f, 2.025f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_o_beach_01",
					_heading = 152.253f,
					_position = new Vector3(-1464.090f, -1484.451f, 2.144f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_beach_01",
					_heading = 151.926f,
					_position = new Vector3(-1462.800f, -1487.491f, 2.125f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_beach_01",
					_heading = 146.163f,
					_position = new Vector3(-1461.323f, -1488.213f, 2.126f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 129.842f,
					_position = new Vector3(-1460.766f, -1491.386f, 2.035f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 119.287f,
					_position = new Vector3(-1460.065f, -1493.355f, 1.972f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.WITNESS,
					_modelname = "a_f_y_tourist_01",
					_heading = 216.191f,
					_position = new Vector3(-1783.165f, -1199.729f, 13.017f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.WITNESS,
					_modelname = "a_f_y_tourist_01",
					_heading = 201.801f,
					_position = new Vector3(-1254.212f, -1904.781f, 5.863f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.WITNESS,
					_modelname = "a_f_y_tourist_01",
					_heading = 193.073f,
					_position = new Vector3(-1675.625f, -1171.587f, 13.017f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.WITNESS,
					_modelname = "a_f_y_tourist_01",
					_heading = 50.958f,
					_position = new Vector3(-1740.568f, -1102.670f, 13.017f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.WITNESS,
					_modelname = "a_f_y_tourist_01",
					_heading = 52.155f,
					_position = new Vector3(-1846.002f, -1173.469f, 13.017f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 21
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 17,
					_type = Globals.HumanType.WITNESS,
					_modelname = "a_f_y_tourist_01",
					_heading = 155.461f,
					_position = new Vector3(-1849.602f, -1250.102f, 8.616f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 22
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.COP,
					_modelname = BeachScene_18.Ped1,
					_heading = 17.710f,
					_position = new Vector3(1274.629f, -2722.163f, 2.148f),
					_animdir = "rcmnigel1a",
					_animname = "stop",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.COP,
					_modelname = BeachScene_18.Ped2,
					_heading = 37.769f,
					_position = new Vector3(1266.767f, -2724.749f, 1.984f),
					_animdir = "amb@code_human_police_crowd_control@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.MEDIC,
					_modelname = BeachScene_18.Ped3,
					_heading = 210.175f,
					_position = new Vector3(1269.823f, -2727.625f, 2.028f),
					_animdir = "missfbi3_party_d",
					_animname = "stand_talk_loop_b_male1",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.MEDIC,
					_modelname = BeachScene_18.Ped3,
					_heading = 351.441f,
					_position = new Vector3(1272.213f, -2731.932f, 2.033f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.LIFEGUARD,
					_modelname = BeachScene_18.Ped4,
					_heading = 221.339f,
					_position = new Vector3(1272.043f, -2730.370f, 2.112f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_paramedic",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.LIFEGUARD,
					_modelname = BeachScene_18.Ped5,
					_heading = 161.654f,
					_position = new Vector3(1273.091f, -2729.893f, 2.078f),
					_animdir = "mini@cpr@char_a@cpr_str",
					_animname = "cpr_kol",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_surfer_01",
					_heading = 113.175f,
					_position = new Vector3(1272.253f, -2730.773f, 2.130f),
					_animdir = "missheistfbi3b_ig8_2",
					_animname = "cpr_loop_victim",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_beach_02",
					_heading = 208.367f,
					_position = new Vector3(1266.940f, -2722.531f, 2.072f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_beach_01",
					_heading = 214.328f,
					_position = new Vector3(1265.886f, -2723.347f, 2.010f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_yoga_01",
					_heading = 230.171f,
					_position = new Vector3(1264.719f, -2724.260f, 2.104f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_yoga_01",
					_heading = 219.611f,
					_position = new Vector3(1265.589f, -2722.501f, 2.131f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_runner_01",
					_heading = 161.147f,
					_position = new Vector3(1275.973f, -2719.987f, 2.214f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_beach_01",
					_heading = 187.381f,
					_position = new Vector3(1274.750f, -2719.916f, 2.220f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_runner_01",
					_heading = 207.004f,
					_position = new Vector3(1273.467f, -2720.441f, 2.188f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 212.635f,
					_position = new Vector3(1272.244f, -2721.139f, 2.151f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 109.700f,
					_position = new Vector3(1281.195f, -2724.900f, 2.108f),
					_animdir = "",
					_animname = "",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_m_dockwork_01",
					_heading = 23.647f,
					_position = new Vector3(1250.628f, -2895.162f, 9.319f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_y_dockwork_01",
					_heading = 198.691f,
					_position = new Vector3(1234.048f, -2909.682f, 21.328f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_m_dockwork_01",
					_heading = 261.453f,
					_position = new Vector3(1237.406f, -2904.665f, 25.330f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_y_dockwork_01",
					_heading = 246.932f,
					_position = new Vector3(1205.794f, -2907.271f, 5.877f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_m_dockwork_01",
					_heading = 120.470f,
					_position = new Vector3(1168.521f, -2905.627f, 5.902f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 21
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_y_dockwork_01",
					_heading = 89.332f,
					_position = new Vector3(1109.213f, -2906.215f, 11.920f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 22
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_m_dockwork_01",
					_heading = 151.001f,
					_position = new Vector3(1076.741f, -2866.708f, 11.260f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 23
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 18,
					_type = Globals.HumanType.WITNESS,
					_modelname = "s_m_y_dockwork_01",
					_heading = 84.083f,
					_position = new Vector3(1023.377f, -2880.157f, 39.157f),
					_animdir = "missheistdockssetup1ig_3@talk",
					_animname = "oh_hey_vin_dockworker",
					_animflag = AnimationFlags.Loop,
					_id = 24
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 19,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_19.Ped1,
					_heading = 69.211f,
					_position = new Vector3(200.255f, -44.686f, 68.622f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 19,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_19.Ped2,
					_heading = 79.750f,
					_position = new Vector3(197.526f, -43.519f, 68.612f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 19,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_19.Ped2,
					_heading = 225.227f,
					_position = new Vector3(197.130f, -42.182f, 68.619f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 19,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_malibu_01",
					_heading = 151.146f,
					_position = new Vector3(197.359f, -42.956f, 68.615f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 19,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_bevhills_01",
					_heading = 117.156f,
					_position = new Vector3(199.412f, -41.386f, 68.616f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 20,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_20.Ped1,
					_heading = 316.511f,
					_position = new Vector3(-1295.551f, -1133.740f, 5.950f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 20,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_20.Ped2,
					_heading = 353.372f,
					_position = new Vector3(-1293.053f, -1132.944f, 6.047f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 20,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_20.Ped2,
					_heading = 167.718f,
					_position = new Vector3(-1293.242f, -1131.550f, 6.123f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 20,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_malibu_01",
					_heading = 38.648f,
					_position = new Vector3(-1293.310f, -1132.346f, 6.080f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 20,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_bevhills_01",
					_heading = 106.374f,
					_position = new Vector3(-1290.537f, -1131.504f, 6.115f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 21,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_21.Ped1,
					_heading = 186.626f,
					_position = new Vector3(-1626.141f, -438.084f, 39.083f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 21,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_21.Ped2,
					_heading = 23.920f,
					_position = new Vector3(-1623.751f, -441.058f, 39.148f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 21,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_21.Ped2,
					_heading = 131.585f,
					_position = new Vector3(-1624.085f, -439.869f, 39.192f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 21,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_malibu_01",
					_heading = 57.561f,
					_position = new Vector3(-1624.287f, -440.484f, 39.150f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 21,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_bevhills_01",
					_heading = 46.871f,
					_position = new Vector3(-1622.699f, -442.870f, 39.035f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 22,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_22.Ped1,
					_heading = 344.854f,
					_position = new Vector3(193.315f, -808.402f, 31.049f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 22,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_22.Ped2,
					_heading = 280.870f,
					_position = new Vector3(194.006f, -805.536f, 31.077f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 22,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_22.Ped2,
					_heading = 106.391f,
					_position = new Vector3(195.349f, -804.413f, 31.138f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 22,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_malibu_01",
					_heading = 338.786f,
					_position = new Vector3(194.553f, -805.031f, 31.108f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 22,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_bevhills_01",
					_heading = 106.190f,
					_position = new Vector3(198.907f, -804.221f, 31.173f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 23,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_23.Ped1,
					_heading = 153.127f,
					_position = new Vector3(1665.017f, 4827.325f, 41.967f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 23,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_23.Ped2,
					_heading = 74.948f,
					_position = new Vector3(1664.896f, 4823.325f, 42.095f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 23,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_23.Ped2,
					_heading = 227.621f,
					_position = new Vector3(1663.303f, 4823.837f, 42.091f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 23,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_hillbilly_02",
					_heading = 333.822f,
					_position = new Vector3(1664.149f, 4823.726f, 42.103f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 23,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_soucent_03",
					_heading = 304.726f,
					_position = new Vector3(1663.073f, 4820.381f, 42.030f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 24,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_24.Ped1,
					_heading = 341.414f,
					_position = new Vector3(857.154f, 4329.255f, 51.632f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 24,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_24.Ped2,
					_heading = 261.425f,
					_position = new Vector3(856.984f, 4332.509f, 51.608f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 24,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_24.Ped2,
					_heading = 141.060f,
					_position = new Vector3(858.547f, 4332.593f, 51.524f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 24,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_hiker_01",
					_heading = 20.510f,
					_position = new Vector3(857.833f, 4332.220f, 51.571f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 24,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hiker_01",
					_heading = 51.664f,
					_position = new Vector3(859.647f, 4331.102f, 51.492f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 25,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_25.Ped1,
					_heading = 282.473f,
					_position = new Vector3(597.592f, 2728.514f, 41.955f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 25,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_25.Ped2,
					_heading = 119.912f,
					_position = new Vector3(601.363f, 2728.033f, 41.939f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 25,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_25.Ped2,
					_heading = 328.414f,
					_position = new Vector3(599.939f, 2727.104f, 41.922f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 25,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_soucent_02",
					_heading = 222.644f,
					_position = new Vector3(600.552f, 2727.641f, 41.932f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 25,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_mexcntry_01",
					_heading = 207.749f,
					_position = new Vector3(598.577f, 2731.507f, 42.014f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 26,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_26.Ped1,
					_heading = 91.468f,
					_position = new Vector3(2501.580f, 4089.218f, 38.555f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 26,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_26.Ped2,
					_heading = 104.623f,
					_position = new Vector3(2498.835f, 4086.781f, 38.240f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 26,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_26.Ped2,
					_heading = 274.998f,
					_position = new Vector3(2496.976f, 4086.108f, 37.997f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 26,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_stlat_02",
					_heading = 157.597f,
					_position = new Vector3(2497.785f, 4086.350f, 38.102f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 26,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_o_indian_01",
					_heading = 227.729f,
					_position = new Vector3(2482.414f, 4099.885f, 38.136f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 27,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_27.Ped1,
					_heading = 299.509f,
					_position = new Vector3(-716.951f, 5780.007f, 17.786f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 27,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_27.Ped2,
					_heading = 240.404f,
					_position = new Vector3(-714.327f, 5782.686f, 17.630f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 27,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_27.Ped2,
					_heading = 56.277f,
					_position = new Vector3(-712.321f, 5782.108f, 17.471f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 27,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_stlat_02",
					_heading = 123.029f,
					_position = new Vector3(-713.338f, 5782.300f, 17.554f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 27,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_m_linecook",
					_heading = 37.169f,
					_position = new Vector3(-712.173f, 5780.002f, 17.490f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 28,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_28.Ped1,
					_heading = 65.716f,
					_position = new Vector3(1691.903f, 6416.239f, 32.543f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 28,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_28.Ped2,
					_heading = 57.557f,
					_position = new Vector3(1690.037f, 6415.783f, 32.452f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 28,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_28.Ped2,
					_heading = 205.343f,
					_position = new Vector3(1688.683f, 6416.980f, 32.403f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 28,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_old_man1a",
					_heading = 94.885f,
					_position = new Vector3(1688.914f, 6416.330f, 32.400f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 28,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_famdnf_01",
					_heading = 161.233f,
					_position = new Vector3(1689.169f, 6418.535f, 32.477f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 29,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_29.Ped1,
					_heading = 332.007f,
					_position = new Vector3(-1524.650f, 4911.681f, 66.501f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 29,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_29.Ped2,
					_heading = 305.674f,
					_position = new Vector3(-1522.202f, 4912.700f, 66.552f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 29,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_29.Ped2,
					_heading = 129.455f,
					_position = new Vector3(-1520.695f, 4914.453f, 66.605f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 29,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hiker_01",
					_heading = 354.345f,
					_position = new Vector3(-1521.479f, 4913.495f, 66.578f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 29,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_hiker_01",
					_heading = 84.624f,
					_position = new Vector3(-1520.197f, 4913.415f, 66.593f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 30,
					_type = Globals.HumanType.COP,
					_modelname = RunOver_30.Ped1,
					_heading = 326.544f,
					_position = new Vector3(-93.242f, 6424.377f, 31.480f),
					_animdir = "amb@code_human_police_investigate@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 30,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_30.Ped2,
					_heading = 222.646f,
					_position = new Vector3(-91.304f, 6431.102f, 31.356f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 30,
					_type = Globals.HumanType.MEDIC,
					_modelname = RunOver_30.Ped2,
					_heading = 81.405f,
					_position = new Vector3(-89.854f, 6430.356f, 31.416f),
					_animdir = "amb@medic@standing@kneel@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 30,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_salton_02",
					_heading = 321.037f,
					_position = new Vector3(-90.865f, 6430.393f, 31.380f),
					_animdir = "missfbi5ig_0",
					_animname = "lyinginpain_loop_steve",
					_animflag = AnimationFlags.Loop,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 30,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_o_tramp_01",
					_heading = 11.816f,
					_position = new Vector3(-89.408f, 6425.795f, 31.490f),
					_animdir = "missmic_4premierejimwaitbef_prem",
					_animname = "wait_idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CALLER,
					_modelname = "u_f_m_miranda",
					_heading = 206.907f,
					_position = new Vector3(-960.665f, 802.342f, 177.430f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.OWNER,
					_modelname = "u_m_y_party_01",
					_heading = 348.353f,
					_position = new Vector3(-1013.762f, 769.201f, 171.379f),
					_animdir = "missheistdockssetup1ig_10@laugh",
					_animname = "laugh_pipe_worker3",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.OWNER_IN,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "intro_90_r",
					_animflag = AnimationFlags.StayInEndFrame,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.OWNER_OUT,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "outro_90_r",
					_animflag = AnimationFlags.None,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_beach_01",
					_heading = 44.218f,
					_position = new Vector3(-1017.721f, 767.009f, 171.379f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_bevhills_04",
					_heading = 230.554f,
					_position = new Vector3(-1018.566f, 767.691f, 171.379f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_genhot_01",
					_heading = 325.328f,
					_position = new Vector3(-1021.614f, 762.994f, 171.209f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_beach_01",
					_heading = 151.961f,
					_position = new Vector3(-1021.043f, 763.940f, 171.209f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beachvesp_01",
					_heading = 139.456f,
					_position = new Vector3(-1017.546f, 761.940f, 171.209f),
					_animdir = "amb@world_human_partying@male@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_ktown_02",
					_heading = 327.063f,
					_position = new Vector3(-1018.493f, 760.897f, 171.209f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_vagos_01",
					_heading = 233.589f,
					_position = new Vector3(-1018.615f, 761.821f, 171.209f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_sunbathe_01",
					_heading = 302.562f,
					_position = new Vector3(-1014.214f, 769.843f, 171.379f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_yoga_01",
					_heading = 139.488f,
					_position = new Vector3(-1013.412f, 770.337f, 171.379f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hipster_01",
					_heading = 248.501f,
					_position = new Vector3(-1015.146f, 761.698f, 171.379f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_breakdance_01",
					_heading = 82.764f,
					_position = new Vector3(-1014.543f, 761.484f, 171.379f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 255.492f,
					_position = new Vector3(-1015.181f, 765.879f, 171.209f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_kerrymcintosh",
					_heading = 20.203f,
					_position = new Vector3(-1017.662f, 760.687f, 171.209f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_f_y_bartender_01",
					_heading = 77.524f,
					_position = new Vector3(-1014.113f, 765.580f, 171.205f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_musclbeac_02",
					_heading = 251.524f,
					_position = new Vector3(-1016.672f, 755.775f, 171.372f),
					_animdir = "amb@world_human_drinking@beer@male@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 31,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_vinewood_02",
					_heading = 138.668f,
					_position = new Vector3(-1015.689f, 755.930f, 171.373f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CALLER,
					_modelname = "player_zero",
					_heading = 35.770f,
					_position = new Vector3(-1929.474f, 404.458f, 96.296f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.OWNER,
					_modelname = "a_m_m_bevhills_02",
					_heading = 97.078f,
					_position = new Vector3(-1930.707f, 351.684f, 93.790f),
					_animdir = "amb@world_human_stand_impatient@male@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.OWNER_IN,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "intro_90_r",
					_animflag = AnimationFlags.StayInEndFrame,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.OWNER_OUT,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "outro_90_r",
					_animflag = AnimationFlags.None,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_tracydisanto",
					_heading = 332.951f,
					_position = new Vector3(-1928.032f, 407.560f, 96.507f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_amandatownley",
					_heading = 121.483f,
					_position = new Vector3(-1927.476f, 408.363f, 96.507f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_genhot_01",
					_heading = 224.758f,
					_position = new Vector3(-1928.137f, 408.774f, 96.507f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_m_beach_01",
					_heading = 289.478f,
					_position = new Vector3(-1922.948f, 404.930f, 96.295f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "player_one",
					_heading = 183.013f,
					_position = new Vector3(-1929.633f, 405.758f, 96.296f),
					_animdir = "amb@world_human_partying@male@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "player_two",
					_heading = 224.720f,
					_position = new Vector3(-1930.741f, 405.586f, 96.296f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_vagos_01",
					_heading = 176.610f,
					_position = new Vector3(-1921.840f, 406.044f, 96.294f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_jimmydisanto",
					_heading = 277.074f,
					_position = new Vector3(-1931.681f, 398.949f, 96.507f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_yoga_01",
					_heading = 355.609f,
					_position = new Vector3(-1921.779f, 404.551f, 96.296f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 302.541f,
					_position = new Vector3(-1926.650f, 405.770f, 96.295f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_stwhi_02",
					_heading = 116.956f,
					_position = new Vector3(-1921.008f, 405.604f, 96.295f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_kerrymcintosh",
					_heading = 93.812f,
					_position = new Vector3(-1931.283f, 399.001f, 96.507f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_f_y_bartender_01",
					_heading = 124.518f,
					_position = new Vector3(-1925.393f, 406.580f, 96.293f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hipster_01",
					_heading = 77.359f,
					_position = new Vector3(-1925.369f, 405.631f, 96.294f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_musclbeac_02",
					_heading = 272.495f,
					_position = new Vector3(-1930.303f, 402.160f, 96.298f),
					_animdir = "amb@world_human_drinking@beer@male@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 32,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_vinewood_02",
					_heading = 84.559f,
					_position = new Vector3(-1929.097f, 402.076f, 96.298f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CALLER,
					_modelname = "a_f_y_business_01",
					_heading = 18.305f,
					_position = new Vector3(45.667f, 557.108f, 180.082f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.OWNER,
					_modelname = "player_one",
					_heading = 240.523f,
					_position = new Vector3(22.709f, 523.712f, 170.228f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.OWNER_IN,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "intro_90_l",
					_animflag = AnimationFlags.StayInEndFrame,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.OWNER_OUT,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "outro_90_l",
					_animflag = AnimationFlags.None,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_tanisha",
					_heading = 45.052f,
					_position = new Vector3(23.207f, 523.001f, 170.228f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_tonya",
					_heading = 133.974f,
					_position = new Vector3(19.481f, 523.285f, 170.228f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_jewelass",
					_heading = 315.423f,
					_position = new Vector3(18.797f, 522.177f, 170.228f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_genhot_01",
					_heading = 127.537f,
					_position = new Vector3(24.051f, 520.757f, 170.228f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_lamardavis",
					_heading = 1.912f,
					_position = new Vector3(22.216f, 522.738f, 170.228f),
					_animdir = "amb@world_human_partying@male@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_stretch",
					_heading = 309.209f,
					_position = new Vector3(23.532f, 520.163f, 170.228f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 265.187f,
					_position = new Vector3(23.483f, 520.753f, 170.228f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_soucent_02",
					_heading = 111.322f,
					_position = new Vector3(21.299f, 519.769f, 170.228f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "csb_anita",
					_heading = 261.347f,
					_position = new Vector3(20.236f, 519.893f, 170.228f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "csb_denise_friend",
					_heading = 240.606f,
					_position = new Vector3(22.550f, 518.116f, 170.228f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "csb_g",
					_heading = 169.163f,
					_position = new Vector3(23.072f, 518.354f, 170.228f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_m_y_strvend_01",
					_heading = 318.828f,
					_position = new Vector3(17.869f, 532.361f, 170.628f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_ballas_01",
					_heading = 138.504f,
					_position = new Vector3(18.447f, 532.846f, 170.628f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_families_01",
					_heading = 150.164f,
					_position = new Vector3(15.696f, 523.886f, 170.228f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "u_m_m_rivalpap",
					_heading = 6.594f,
					_position = new Vector3(15.659f, 522.867f, 170.228f),
					_animdir = "amb@world_human_drinking@beer@male@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 33,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_scdressy_01",
					_heading = 314.433f,
					_position = new Vector3(14.669f, 523.149f, 170.228f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CALLER,
					_modelname = "a_f_m_eastsa_02",
					_heading = 172.24f,
					_position = new Vector3(943.75f, -463.71f, 61.40f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.OWNER,
					_modelname = "ig_terry",
					_heading = 83.11f,
					_position = new Vector3(896.17f, -471.54f, 59.02f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.OWNER_IN,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "intro_90_r",
					_animflag = AnimationFlags.StayInEndFrame,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.OWNER_OUT,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "outro_90_r",
					_animflag = AnimationFlags.None,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 248.43f,
					_position = new Vector3(894.74f, -471.02f, 59.09f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_paige",
					_heading = 276.77f,
					_position = new Vector3(898.69f, -469.97f, 59.02f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 127.67f,
					_position = new Vector3(900.22f, -469.60f, 59.02f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_ashley",
					_heading = 49.50f,
					_position = new Vector3(900.19f, -470.66f, 59.02f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_lost_01",
					_heading = 336.55f,
					_position = new Vector3(891.60f, -474.47f, 59.02f),
					_animdir = "amb@world_human_partying@male@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_lost_02",
					_heading = 204.40f,
					_position = new Vector3(891.50f, -473.32f, 59.02f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_lost_03",
					_heading = 11.18f,
					_position = new Vector3(889.06f, -474.34f, 59.02f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_lost_02",
					_heading = 227.97f,
					_position = new Vector3(888.05f, -473.47f, 59.01f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 186.82f,
					_position = new Vector3(889.15f, -473.16f, 59.01f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 236.36f,
					_position = new Vector3(892.80f, -478.56f, 59.02f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_lost_03",
					_heading = 71.57f,
					_position = new Vector3(894.56f, -478.71f, 59.02f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 1.74f,
					_position = new Vector3(893.42f, -479.35f, 59.07f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 159.90f,
					_position = new Vector3(890.34f, -475.75f, 59.11f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 342.11f,
					_position = new Vector3(889.81f, -477.75f, 59.02f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_lost_01",
					_heading = 72.15f,
					_position = new Vector3(890.88f, -477.01f, 59.02f),
					_animdir = "amb@world_human_drinking@beer@male@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 34,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_lost_01",
					_heading = 249.58f,
					_position = new Vector3(889.32f, -476.80f, 59.02f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CALLER,
					_modelname = "csb_screen_writer",
					_heading = 290.232f,
					_position = new Vector3(-1910.714f, -551.493f, 11.834f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.OWNER,
					_modelname = "csb_anita",
					_heading = 311.631f,
					_position = new Vector3(-1907.520f, -576.176f, 22.892f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.OWNER_IN,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "intro_90_r",
					_animflag = AnimationFlags.StayInEndFrame,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.OWNER_OUT,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "outro_90_r",
					_animflag = AnimationFlags.None,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_bevhills_04",
					_heading = 164.953f,
					_position = new Vector3(-1907.227f, -575.065f, 22.947f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_bevhills_03",
					_heading = 111.073f,
					_position = new Vector3(-1906.405f, -575.679f, 22.893f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_genhot_01",
					_heading = 170.563f,
					_position = new Vector3(-1913.281f, -577.529f, 22.892f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_bevhills_02",
					_heading = 109.572f,
					_position = new Vector3(-1912.398f, -578.217f, 22.892f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_busicas_01",
					_heading = 26.155f,
					_position = new Vector3(-1911.307f, -580.418f, 19.097f),
					_animdir = "amb@world_human_partying@male@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_business_02",
					_heading = 110.824f,
					_position = new Vector3(-1909.350f, -570.377f, 22.970f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_bevhills_01",
					_heading = 199.487f,
					_position = new Vector3(-1911.692f, -579.548f, 19.097f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_gay_01",
					_heading = 55.370f,
					_position = new Vector3(-1908.116f, -581.577f, 22.892f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_f_y_movprem_01",
					_heading = 282.740f,
					_position = new Vector3(-1910.308f, -570.489f, 22.970f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "u_f_y_hotposh_01",
					_heading = 228.278f,
					_position = new Vector3(-1909.074f, -580.910f, 22.892f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_business_01",
					_heading = 9.976f,
					_position = new Vector3(-1911.095f, -576.259f, 22.892f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_business_03",
					_heading = 201.301f,
					_position = new Vector3(-1911.382f, -575.198f, 22.892f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "u_f_y_poppymich",
					_heading = 84.869f,
					_position = new Vector3(-1910.442f, -575.455f, 22.892f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_business_01",
					_heading = 75.738f,
					_position = new Vector3(-1908.076f, -572.487f, 22.970f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "csb_groom",
					_heading = 217.318f,
					_position = new Vector3(-1908.905f, -571.865f, 22.970f),
					_animdir = "amb@world_human_drinking@beer@male@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 35,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_business_04",
					_heading = 283.449f,
					_position = new Vector3(-1909.162f, -572.654f, 22.970f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CALLER,
					_modelname = "ig_bankman",
					_heading = 110.177f,
					_position = new Vector3(-2996.339f, 706.599f, 28.497f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.OWNER,
					_modelname = "csb_oscar",
					_heading = 9.366f,
					_position = new Vector3(-2998.194f, 758.405f, 26.687f),
					_animdir = "amb@world_human_stand_impatient@male@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.OWNER_IN,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "intro_90_r",
					_animflag = AnimationFlags.StayInEndFrame,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.OWNER_OUT,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "outro_90_r",
					_animflag = AnimationFlags.None,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_beach_01",
					_heading = 321.923f,
					_position = new Vector3(-2991.818f, 757.664f, 25.829f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_beach_01",
					_heading = 145.825f,
					_position = new Vector3(-2991.071f, 758.777f, 26.009f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_genhot_01",
					_heading = 97.246f,
					_position = new Vector3(-2997.290f, 758.940f, 26.687f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_scdressy_01",
					_heading = 194.420f,
					_position = new Vector3(-2979.225f, 753.805f, 26.687f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_03",
					_heading = 13.763f,
					_position = new Vector3(-2978.800f, 752.192f, 26.687f),
					_animdir = "amb@world_human_partying@male@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_beach_01",
					_heading = 183.165f,
					_position = new Vector3(-2998.140f, 759.674f, 26.687f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_bevhills_01",
					_heading = 37.735f,
					_position = new Vector3(-2977.912f, 752.087f, 26.687f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_stlat_02",
					_heading = 57.349f,
					_position = new Vector3(-2998.809f, 767.977f, 27.028f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_beach_01",
					_heading = 242.653f,
					_position = new Vector3(-2999.935f, 768.591f, 27.028f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_beach_01",
					_heading = 181.714f,
					_position = new Vector3(-2996.275f, 764.604f, 26.687f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_musclbeac_02",
					_heading = 30.555f,
					_position = new Vector3(-2995.667f, 763.468f, 26.687f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_y_musclbeac_02",
					_heading = 348.357f,
					_position = new Vector3(-2996.476f, 763.670f, 26.687f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_maryann",
					_heading = 29.389f,
					_position = new Vector3(-3001.218f, 762.021f, 27.028f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_f_y_movprem_01",
					_heading = 209.892f,
					_position = new Vector3(-3001.797f, 762.999f, 27.028f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "ig_tylerdix",
					_heading = 267.097f,
					_position = new Vector3(-2989.087f, 768.452f, 26.687f),
					_animdir = "amb@world_human_drinking@beer@male@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 36,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "s_f_y_shop_mid",
					_heading = 87.919f,
					_position = new Vector3(-2987.952f, 768.332f, 26.687f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CALLER,
					_modelname = "a_m_o_genstreet_01",
					_heading = 285.574f,
					_position = new Vector3(-236.757f, 6418.600f, 31.267f),
					_animdir = "amb@world_human_stand_impatient@female@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 1
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.OWNER,
					_modelname = "ig_lifeinvad_01",
					_heading = 108.206f,
					_position = new Vector3(-198.603f, 6377.505f, 31.837f),
					_animdir = "amb@world_human_stand_impatient@male@no_sign@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 2
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.OWNER_IN,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "intro_90_r",
					_animflag = AnimationFlags.StayInEndFrame,
					_id = 3
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.OWNER_OUT,
					_modelname = "NONE",
					_heading = 0f,
					_position = new Vector3(0f,0f,0f),
					_animdir = "reaction@points@",
					_animname = "outro_90_r",
					_animflag = AnimationFlags.None,
					_id = 4
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hipster_01",
					_heading = 202.493f,
					_position = new Vector3(-199.231f, 6378.705f, 31.837f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 5
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hipster_02",
					_heading = 257.262f,
					_position = new Vector3(-200.130f, 6377.689f, 31.837f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 6
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_eastsa_02",
					_heading = 307.764f,
					_position = new Vector3(-199.706f, 6376.670f, 31.837f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 7
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_f_y_vagos_01",
					_heading = 260.184f,
					_position = new Vector3(-196.571f, 6384.506f, 33.085f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 8
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "g_m_y_armgoon_02",
					_heading = 193.225f,
					_position = new Vector3(-195.813f, 6385.329f, 33.085f),
					_animdir = "amb@world_human_partying@male@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 9
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_salton_03",
					_heading = 118.622f,
					_position = new Vector3(-199.146f, 6380.066f, 31.837f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 10
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_vinewood_02",
					_heading = 293.141f,
					_position = new Vector3(-200.582f, 6379.230f, 31.837f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 11
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_salton_01",
					_heading = 148.616f,
					_position = new Vector3(-194.767f, 6377.514f, 31.853f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 12
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_indian_01",
					_heading = 303.409f,
					_position = new Vector3(-196.076f, 6376.754f, 31.844f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_e",
					_animflag = AnimationFlags.Loop,
					_id = 13
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hippie_01",
					_heading = 3.730f,
					_position = new Vector3(-194.956f, 6376.164f, 31.848f),
					_animdir = "amb@world_human_drinking@beer@female@idle_a",
					_animname = "idle_d",
					_animflag = AnimationFlags.Loop,
					_id = 14
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_soucent_03",
					_heading = 44.353f,
					_position = new Vector3(-202.718f, 6378.177f, 31.837f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 15
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_m_m_stlat_02",
					_heading = 224.343f,
					_position = new Vector3(-203.686f, 6379.178f, 31.837f),
					_animdir = "amb@world_human_partying@male@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 16
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_hipster_01",
					_heading = 129.471f,
					_position = new Vector3(-202.146f, 6379.727f, 31.837f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_a",
					_animflag = AnimationFlags.Loop,
					_id = 17
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_soucent_02",
					_heading = 251.977f,
					_position = new Vector3(-193.808f, 6378.434f, 31.860f),
					_animdir = "amb@world_human_partying@female@partying_beer@idle_a",
					_animname = "idle_b",
					_animflag = AnimationFlags.Loop,
					_id = 18
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "csb_fos_rep",
					_heading = 136.665f,
					_position = new Vector3(-192.600f, 6379.120f, 31.865f),
					_animdir = "amb@world_human_drinking@beer@male@idle_a",
					_animname = "idle_c",
					_animflag = AnimationFlags.Loop,
					_id = 19
				});

				HumanList.Add(new Globals.Humans
				{
					_calloutid = 37,
					_type = Globals.HumanType.CIVILIAN,
					_modelname = "a_f_y_soucent_03",
					_heading = 56.839f,
					_position = new Vector3(-192.528f, 6377.919f, 31.864f),
					_animdir = "amb@world_human_partying@female@partying_beer@base",
					_animname = "base",
					_animflag = AnimationFlags.Loop,
					_id = 20
				});

				#endregion Peds

				#region Dialogs
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Partner. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 1,
					_counter = 1,
					_text = "Hey Officer, thanks for responding. Guy flipped his car. He said that another driver drifted around the corner, hit his vehicle, and ended up flipping.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 1,
					_counter = 2,
					_text = "Ouch.Do you have any information on a possible suspect or suspects vehicle ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 1,
					_counter = 3,
					_text = "I can't tell you. I had to get EMS and the tow service here. Try talking to the ~y~Victim~w~ over by my vehicle. He could probably tell you what you need to know.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 1,
					_counter = 4,
					_text = "Okay. Thanks for the information.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 0,
					_text = "Hey bud. I'm from the " + GameHandler._dialog_dept.Remove(1, 7) + ".Are you okay ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 1,
					_text = "Yes officer. Luckily I didn't get hurt! That fucking drifter...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 2,
					_text = "Okay. Can you tell me what happened? Do you know what type of vehicle it was?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ drifted around the corner and was in the middle of the road. As I was coming around, he hit me, made my vehicle flip, and sped off.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 4,
					_text = "Did you see the ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 5,
					_text = "You bet I did! It was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 6,
					_text = "Thanks for you help. It is extremely useful in this investigation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 7,
					_text = "Its a good thing that I remembered the plate! Get this son of a bitch...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 1,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 1,
					_counter = 0,
					_text = "Hey. You requested backup. How can I help?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 1,
					_counter = 1,
					_text = "Hi " + Globals.CharacterName + ", this crash seems to be a Hit and Run. There are tire skids in the middle of the road.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 1,
					_counter = 2,
					_text = "So another vehicle caused the crash?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 1,
					_counter = 3,
					_text = "According to the victim, it seems so. Best is that you ask him yourself. He probably can give you more information.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 1,
					_counter = 4,
					_text = "OK. I will talk to him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I can tell you",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 0,
					_text = "Hi, I'm " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Is everything fine?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 1,
					_text = "Hello officer. Yes I'm fine but pretty pissed.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 2,
					_text = "I can imagine that. Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ drifted around the corner and was in the middle of the road when I was coming around. I took a hit and lost control of my car and crashed.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 4,
					_text = "Did you see the ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 5,
					_text = "Luckily, I did. It was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 6,
					_text = "Perfect. Thanks. With your help we can easily identify this person.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 7,
					_text = "I deserve justice for that. Hope this guy goes to prison",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 2,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 1,
					_counter = 0,
					_text = "Hi. What happened to the taxi driver?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 1,
					_counter = 1,
					_text = "Hey, nice to see you. Well, the guy does not really want to talk to the police. So I don't have much.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 1,
					_counter = 2,
					_text = "Hm. Does he has an active warrant? Tell me what you have",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 1,
					_counter = 3,
					_text = "I already checked that, he is clean. Seems to be a Hit and Run. But try talking to him yourself. It was really hard get something out of him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 1,
					_counter = 4,
					_text = "Okay. Thanks for the information.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Sir, I'm from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Is everything okay",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 1,
					_text = "Hey, yes I'm fine.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 2,
					_text = "Sir, is it possible for you to describe what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ hit me.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 4,
					_text = "Did you see the ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 5,
					_text = "I shouldn't tell you... I hate cops... they suck. But... it was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 6,
					_text = "Thank you. Why do you hate the police",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 7,
					_text = "That is none of your business. Get this asshole and leave me alone.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 3,
					_contactid = 2,
					_counter = 8,
					_text = "Leave me alone.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Officer. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 1,
					_counter = 1,
					_text = "Hello Officer. Thanks for responding. The only thing I know is that we have a hit and run between a motorist and a bicyclist.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 1,
					_counter = 2,
					_text = "Okay. Do you have any information on a possible vehicle or suspect?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 1,
					_counter = 3,
					_text = "No, I was focussing on getting Paramedics here and trying to save the victim. Can you try talking to the ~y~witnesses~w~ and I'll control the scene?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 1,
					_counter = 4,
					_text = "Sure.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 2,
					_counter = 0,
					_text = "Hello sir, are you okay?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 2,
					_counter = 1,
					_text = "Hello Officer. Yes, I'm fine. That poor guy, I hope he's okay!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 2,
					_counter = 2,
					_text = "Did you see how this accident happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 2,
					_counter = 3,
					_text = "No, unfortunately. I was the second person to arrive. The woman over there was the first person on scene.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 2,
					_counter = 4,
					_text = "Okay, thanks for your help.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 2,
					_counter = 5,
					_text = "Glad to help, officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 2,
					_counter = 6,
					_text = "Sorry, but I don't know anything else.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 0,
					_text = "Hello. Are you the one who called 911?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 1,
					_text = "Yes officer. I saw the accident and decided to pull over and call for an ambulance!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 2,
					_text = "Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 3,
					_text = "~w~ went speeding around this turn and hit the cyclist, and didn't even stop! They kept on going!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 4,
					_text = "PLACEHOLDER",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 5,
					_text = "PLACEHOLDER",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your information. Your help is extremely useful in this investigation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 7,
					_text = "No problem! Glad to help the police any day of the week.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 4,
					_contactid = 3,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Partner. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 1,
					_counter = 1,
					_text = "Hi. Thanks for responding. Seems to be a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 1,
					_counter = 2,
					_text = "Okay. Do you have any information on a possible vehicle or suspect?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 1,
					_counter = 3,
					_text = "I can't tell you. Paramedics were already performing CPR when we arrived. Talk to this person here. Maybe he knows more",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 1,
					_counter = 4,
					_text = "Thanks, I will so.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 2,
					_counter = 0,
					_text = "Hello sir, are you okay?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 2,
					_counter = 1,
					_text = "Hello Officer. Yes, I'm fine. Is the biker okay?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 2,
					_counter = 2,
					_text = "I don't have any information about his condition. Did you see how this accident happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 2,
					_counter = 3,
					_text = "Yes, that's the reason why I had to pull into the grass. A car overtook me on the bridge.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 2,
					_counter = 4,
					_text = "Do you have a description on a license plate number of the car?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 2,
					_counter = 5,
					_text = "Sorry, everything went so fast, I can't remember either the car or a plate.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 2,
					_counter = 6,
					_text = "Try talking to the woman. She stopped and called for the EMS, maybe she knows more.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 0,
					_text = "Hello. Are you the one who called 911?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 1,
					_text = "Yes officer. I saw the accident and decided to pull over and call for an ambulance!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 2,
					_text = "Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 3,
					_text = "~w~ overtook the car on the bridge! The biker had to swerve to avoid hitting this idiot and went off.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 4,
					_text = "PLACEHOLDER",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 5,
					_text = "PLACEHOLDER",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your information. Your help is extremely useful in this investigation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 7,
					_text = "No problem! Glad to help the police any day of the week.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 5,
					_contactid = 3,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 1,
					_counter = 0,
					_text = "Hello Ranger, you called for backup. How can I help",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 1,
					_counter = 1,
					_text = "Hi. Thanks for responding up here. The construction workers called 911 when they found this driver on the road.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 1,
					_counter = 2,
					_text = "Okay. Cars aren't supposed to be on this road, so do we know what caused it?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 1,
					_counter = 3,
					_text = "According to them, a car did cause it. Ask for yourself.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 1,
					_counter = 4,
					_text = "Up here? What the hell is a car doing up here? I will talk to the workers, see if they can tell me anything else about it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Guys. My name is " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Please describe what happened.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 2,
					_counter = 1,
					_text = "Hi Officer. Will the biker be okay?. It looks bad for him, doesn't it?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 2,
					_counter = 2,
					_text = "Paramedics try to stabilize him. We need to see. Please focus on the accident. What happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 2,
					_counter = 3,
					_text = "Ah yes sorry. We are performing roadwork here, 'cause the rain washed away parts of this trail. We found him unconscious.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 2,
					_counter = 4,
					_text = "Do you know anything that could cause his crash?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 2,
					_counter = 5,
					_text = "There is one guy who is frequently up here with his car off-roading. But I can't tell you anything about the car.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 2,
					_counter = 6,
					_text = "Try talking to my buddy here. He might know something I don't.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 0,
					_text = "Hello. Your buddy said you might know something about a possible vehicle?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 1,
					_text = "Yes officer. I didn't see the accident, but when I came up here with my truck, a car was going down.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 2,
					_text = "Can you tell me something about the driver? Car?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 3,
					_text = "~w~ came rushing down the hill. It looked like he was fleeing from something. Then we found the victim.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 4,
					_text = "PLACEHOLDER",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 5,
					_text = "PLACEHOLDER",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your information. Your help is extremely useful in this investigation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 7,
					_text = "No problem! Glad that we were up here. Hope the guy makes it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 6,
					_contactid = 3,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 1,
					_counter = 0,
					_text = "Hello Officer, did you request backup?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 1,
					_counter = 1,
					_text = "Yes, I did. We have a hit and run. Until now, the victim was in shock, and I haven't been able to talk to him. Can you attempt to speak to the victim while I assist the paramedics?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 1,
					_counter = 2,
					_text = "Yeah, no problem. Hopefully he can tell us something.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 1,
					_counter = 3,
					_text = "Will do. Good luck, officer!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 1,
					_counter = 4,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Sir, I'm a police officer. Can you tell me anything you remember about the accident? Car, person driving, anything?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 2,
					_counter = 1,
					_text = "Uuhh, I don't feel good... I think that... oh... I can't tell you anything�",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 2,
					_counter = 2,
					_text = "He appears to be suffering from a pretty serious concussion.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 2,
					_counter = 3,
					_text = "Huh, he could be suffering from short term memory loss. Sir, are you sure you can't remember anything? Just the slightest thing can help.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 2,
					_counter = 4,
					_text = "I think.. I think I'm gunna pass out..",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 2,
					_counter = 5,
					_text = "Officer, he just blacked out. The lady over there made the 911 call. Try talking to her!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 2,
					_counter = 6,
					_text = "That is all I have for you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 0,
					_text = "Hello Ma'am. I'm from the " + GameHandler._dialog_dept.Remove(1, 7) + ".Did you see what happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 1,
					_text = "Hi Officer. Yes, I did. A car cut the corner at a high rate of speed and hit the poor man. Is he going to be okay?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 2,
					_text = "He should be. Do you have a description of the vehicle or the driver?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 3,
					_text = ". Dang, that person must be desperate�",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 4,
					_text = "Did you see the license plate of the",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 5,
					_text = "I believe so. I think it was",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your help. Your information is extremely useful in this investigation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 7,
					_contactid = 3,
					_counter = 7,
					_text = "Glad to help!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Partner, did you request backup? How can I help?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 1,
					_counter = 1,
					_text = "Hi bud, thanks for the fast response. We have a hit and run. I haven't been able to talk to the victim. Can you attempt to speak to her while I secure the scene?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 1,
					_counter = 2,
					_text = "Yeah, sure. Hopefully she remembers something.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 1,
					_counter = 3,
					_text = "I don't think so, she seems to be pretty messed up after the crash.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 1,
					_counter = 4,
					_text = "That is all I can tell you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 2,
					_counter = 0,
					_text = "Hi Ma'am, I'm a police officer. Do you remember anything about the accident? A car, person driving, anything?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 2,
					_counter = 1,
					_text = "Ehmm.. sorry officer.. I ... I don't know.. where am I?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 2,
					_counter = 2,
					_text = "She is suffering from a pretty serious concussion caused by an airbag failing to open.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 2,
					_counter = 3,
					_text = "She must have hit her head very hard on the dashboard. Miss, are you sure you can't remember anything?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 2,
					_counter = 4,
					_text = "What time is it? What happend? Where am I ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 2,
					_counter = 5,
					_text = "Officer, please stop questioning. Try talking to the security guard over there. He called 911.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 2,
					_counter = 6,
					_text = "That is all I have for you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 0,
					_text = "Hello Sir. I'm officer " + Globals.CharacterName + " of the " + GameHandler._dialog_dept.Remove(1, 7) +  ".Do you know what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 1,
					_text = "Hi Officer. Yes, I saw the accident. I was driving to the labs when a car came into the other lane. How is the woman doing?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 2,
					_text = "She is facing memory loss. Do you have a description of the vehicle or the driver?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 3,
					_text = ". The car came here often.. always at a high rate of speed.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 4,
					_text = "Do you remember the license plate of the",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 5,
					_text = "Yep. I wrote it down. It was",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your help. Your information is extremely useful in this investigation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 8,
					_contactid = 3,
					_counter = 7,
					_text = "Did you know that I always wanted to be a cop... anyway, glad to help!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 1,
					_counter = 0,
					_text = "Hi, you called in backup. What can I do for you?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 1,
					_counter = 1,
					_text = "Hi buddy. Do me a favor and talk to the victim and witness. I was busy getting the scene save and calling in EMS",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 1,
					_counter = 2,
					_text = "Sure, no problem. The victim looks disoriented. Hope he remembers something",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 1,
					_counter = 3,
					_text = "Yeah, he hit the barrier pretty hard. You'll see.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 1,
					_counter = 4,
					_text = "That is all I can tell you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 2,
					_counter = 0,
					_text = "Hi Sir, I'm a police officer form the " + GameHandler._dialog_dept.Remove(1, 7) + ". Can you remember anything?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 2,
					_counter = 1,
					_text = "What? .. What time is it?.. Who are you?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 2,
					_counter = 2,
					_text = "The crash must be hard. As soon as he is stable we will take him to hospital.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 2,
					_counter = 3,
					_text = "Sir, can you tell me anything...? Can you tell me who was driving, or a color of the car?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 2,
					_counter = 4,
					_text = "Who...? What...?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 2,
					_counter = 5,
					_text = "Believe me. That makes no sense. He definitely has a concussion. Try to get info from the witness there.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 2,
					_counter = 6,
					_text = "That is all I have for you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 0,
					_text = "Hello Sir. I'm officer " + Globals.CharacterName + " of the  " + GameHandler._dialog_dept.Remove(1, 7) +  " . Do you know what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 1,
					_text = "Hello. Yes, that is why I stopped and called 9-1-1?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 2,
					_text = "Can you explain what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 3,
					_text = "The driver was on the wrong side of the road with a high rate of speed.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 4,
					_text = "Do you remember the license plate of the",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 5,
					_text = "I do. It was",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your time and for stopping. Not everybody shows respect these days.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 9,
					_contactid = 3,
					_counter = 7,
					_text = "I appreciate hearing this from a police officer!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Marcus, nice to see ya. What do we have here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 1,
					_text = "Hey " + Globals.CharacterName + ", it appears to be a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 2,
					_text = "Are there any injuries?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 3,
					_text = "Yes. The truck driver ended up rolling his truck and got injured. He's currently getting help in the ambulance, and will most likely spend the night in the hospital.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 4,
					_text = "Damn. Do you know what caused it?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 5,
					_text = "The craftsman here told me that a guy overtook the truck at a high rate of speed, but feel free to ask him for yourself.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 6,
					_text = "Okie Dokie.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 1,
					_counter = 7,
					_text = "That is all i have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 0,
					_text = "Hey Sir. Can you tell me exactly what you saw?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 1,
					_text = "Yes, I can. Some idiot overtook the truck in the turn and I was also coming around. The truck swerved and ended up flipping, while I just hit the fence here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 2,
					_text = "Oh boy. Doesn't appear you have too much damage... Can you tell me anything about the vehicle and driver?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 3,
					_text = "I'm not into cars, but the vehicle appeared to be a ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. What about the license plate? Did you see that?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 5,
					_text = "I believe it was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 6,
					_text = "Okay. Thanks for your help. Give this officer a statement and you will be free to leave.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 7,
					_text = "Okay Officer. Thanks.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 10,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Frank, long time no see. What happend here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 1,
					_text = "Hey " + Globals.CharacterName + ", Seems like a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 2,
					_text = "Is anyone injured?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 3,
					_text = "I'm afraid so. The driver of the truck rolled his vehicle and got injured. Paramedics are taking care about him in the ambulance. He will be sent to the hospital.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 4,
					_text = "It's been a while since I saw an accident like this. Do we know the cause?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 5,
					_text = "The worker here told me that a vehicle went into the truck's lane and made him swerve to avoid the oncoming car, however you could talk to him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 6,
					_text = "Sure, I'll see hat he tells me.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 1,
					_counter = 7,
					_text = "That is all I can tell you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Sir, my partner told me you know what happened.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 1,
					_text = "Yes, Officer. A stupid asshole overtook me and the truck swerved and ended up in the woods.I immedialty called 911.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 2,
					_text = "Thank you for that. Do you remember anything about the vehicle or driver?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 3,
					_text = "Yes actually, I own the same vehicle. It was a ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. Did you see the license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 5,
					_text = "I think it was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 6,
					_text = "Thanks for your help. Give this officer a detailed statement and you will be free to leave.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 7,
					_text = "Okay Officer. Thanks.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 11,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 0,
					_text = "Hi Partner. Wow. That's a deep fall! Let me guess: Drunk Driver.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 1,
					_text = "Hey " + Globals.CharacterName + ", Nope. Actually it is a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 2,
					_text = "Really. On this road? What happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 3,
					_text = "The driver of the Log truck rolled his vehicle and got injured by evading a speeding car. He will be sent to the hospital.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 4,
					_text = "Do we know anything about this car?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 5,
					_text = "His co-driver told me that this vehicle nearly lost control, however you could talk to him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 6,
					_text = "Yep. I will take over here okay?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 1,
					_counter = 7,
					_text = "Sure thanks. Its yours.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 0,
					_text = "Hey. Can you repeat for me that what you told my partner?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 1,
					_text = "Yes, Officer. A stupid asshole came down the hill with an insane speed. My buddy had to go off the road not to hit him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 2,
					_text = "Can you remember that car?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 3,
					_text = "Yeah, I do. It was a ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. Did you see the license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 5,
					_text = "Yes i also remember this. It was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 6,
					_text = "Thanks for your help. Please stay here until the recovery crane has arrived.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 7,
					_text = "Okay Officer. Thanks.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 12,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 1,
					_counter = 0,
					_text = "Hi, what the hell happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 1,
					_counter = 1,
					_text = "Hey Officer " + Globals.CharacterName + ", thanks for the fast response. According to the first infos I have, it seems to be a Hit and Run",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 1,
					_counter = 2,
					_text = "Did you already talk to victims and witnesses?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 1,
					_counter = 3,
					_text = "No sorry, i was helping securing the scene and keep the traffic flow.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 1,
					_counter = 4,
					_text = "Okay, then i will talk to the involved people to gain information about a possible suspect.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 1,
					_counter = 5,
					_text = "Thanks, meanwhile i will take care about the traffic, see ya later.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 0,
					_text = "Hi, my name is " + Globals.CharacterName  + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 1,
					_text = "Oh my god, i hope she will be ok, they just have taken her to the hospital..",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 2,
					_text = "Calm down, everything will be fine. I need you to tell me what happened. Can you do that for me?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 3,
					_text = "I think so, but it all happened so fast... it wasn't my fault.. i needed to pull away...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 4,
					_text = "From what did you pull away. Did a car cut you? Please be more precise.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 5,
					_text = "Yes, it switched to my lane without noticing me. I think it was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 6,
					_text = "Are you sure about this?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 7,
					_text = "No I'm not.. please ask the others.. maybe the can tell you more.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 2,
					_counter = 8,
					_text = "Okay, thanks again. Just keep calm, she will be ok",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 3,
					_counter = 0,
					_text = "Hello, " + GameHandler._dialog_dept.Remove(1, 7) + ". Are you okay? Can i ask you some questions?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 3,
					_counter = 1,
					_text = "Hi, yeah sure, go ahead",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 3,
					_counter = 2,
					_text = "The guy that flipped the car told me that he was cut by a car which switched the lane, is this correct?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 3,
					_counter = 3,
					_text = "Yes. I had to brake hard to stop my car. But i touched the barriers anyway. Now look at my car",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 3,
					_counter = 4,
					_text = "Sorry for that. Can you remember a licence plate or a the car type or maybe the color?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 3,
					_counter = 5,
					_text = "Not really, I was focusing not to crash.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your time, if you need anything then contact " + GameHandler._dialog_dept.Remove(1, 7) + ".",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 0,
					_text = "Hey there, I'm officer " + Globals.CharacterName + ". It seems that your car is fine. Why are you here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 1,
					_text = "Hi, i was the one that called 9-1-1. And i decided to stay cause i have wrote down the car that caused this mess.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 2,
					_text = "Perfect. So you can tell me the licence plate of the",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 3,
					_text = "Yes i can tell you, but it wasn't a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 4,
					_text = "Ok, then what car was it?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 5,
					_text = "It was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 6,
					_text = "Thanks for helping out, it will help to identify this reckless driver. You can leave now",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 13,
					_contactid = 4,
					_counter = 7,
					_text = "Okay. Bye",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Partner. This crash looks serious. Do you know what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 1,
					_counter = 1,
					_text = "Hi " + Globals.CharacterName + ", Yeah, its a miracle that there is not more damage.Looks like a Hit and Run, but I'm not sure",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 1,
					_counter = 2,
					_text = "How do you know. Have you already talked to involved people?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 1,
					_counter = 3,
					_text = "Unfortunately not. I took care about getting EMS and the fire team here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 1,
					_counter = 4,
					_text = "Okay, then I will start questioning to see if we get a cause or maybe a suspect.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 1,
					_counter = 5,
					_text = "Meanwhile I will contact dispatch and give them an update about the status here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 0,
					_text = "Hello, I'm officer " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Are you able to answer some questions?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 1,
					_text = "Oh hi, ehm... yes maybe... they just took my wife to the hospital with the helicopter. They said that she has internal chest injuries.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 2,
					_text = "Damn, sad to hear that. But she is in god hands. Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 3,
					_text = "I was driving on the second lane at suddenly the guy on the first one pulled over.I reacted and flipped the car.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 4,
					_text = "Do you remember a car type or license plate of this vehicle?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 5,
					_text = "I'm really not sure. Maybe it was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 6,
					_text = "Did the person set the indicator, or did he just pull to your side?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 7,
					_text = "No. He just pulled to my lane without any notice",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 2,
					_counter = 8,
					_text = "Thanks for your info. Maybe " + GameHandler._dialog_dept.Remove(1, 7) + " will contact you again.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 3,
					_counter = 0,
					_text = "Hi, " + GameHandler._dialog_dept.Remove(1, 7) + ". Are you the second involved person of this crash?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 3,
					_counter = 1,
					_text = "Hi yes, I was driving behind the car that flipped.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 3,
					_counter = 2,
					_text = "So can you describe the situation that caused this accident?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 3,
					_counter = 3,
					_text = "Sure. A vehicle pulled into the guys car with any notice.. One happened to the other and BAAM.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 3,
					_counter = 4,
					_text = "Do you remember a licence plate or a the car type or maybe the color?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 3,
					_counter = 5,
					_text = "No sorry.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 3,
					_counter = 6,
					_text = "Thanks for your time, if you need anything then contact " + GameHandler._dialog_dept.Remove(1, 7) + ".",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 0,
					_text = "Hello, my name is officer " + Globals.CharacterName + ". Can you tell me what you doing here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 1,
					_text = "Hello officer. I saw exactly what happened from the other side.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 2,
					_text = "Okay. The victims sad that a vehicle pulled on the other lane and caused the crash. It was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 3,
					_text = "Then they must be wrong. It was definitely not a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 4,
					_text = "Interesting. So then please update me.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 5,
					_text = "Yes sure. I memorized it. It was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 6,
					_text = "Thanks for your help. You can leave now",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 14,
					_contactid = 4,
					_counter = 7,
					_text = "Bye",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 1,
					_counter = 0,
					_text = "Wow. Its been a while since a crash happened here. What's going on?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 1,
					_counter = 1,
					_text = "Hey " + Globals.CharacterName + ". You're right. No issue here a long time.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 1,
					_counter = 2,
					_text = "Did you already make contact with the involved people?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 1,
					_counter = 3,
					_text = "Nope. You're the higher ranked cop here. Please take care of it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 1,
					_counter = 4,
					_text = "Always the same excuse. This id getting old. Well okay, I will do it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 1,
					_counter = 5,
					_text = "Thank you very much. I will keep traffic off your back",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 0,
					_text = "Hey, my name is " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Are you okay?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 1,
					_text = "Yes I fine, just some bruising. But my daughter is injured. EMS is now talking her to the hospital",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 2,
					_text = "Sorry to hear that. Is it possible for you to answer some questions regarding the crash?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 3,
					_text = "Well I hope I remember something. Its all a bit blurred from the impact. I will try.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 4,
					_text = "How did this happen? Was any other vehicle involved in this accident?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 5,
					_text = "Yes, another car switched to my lane and I had to brake hard. But it wasn't enough. I think it was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 6,
					_text = "Please take a time and think about your answer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 7,
					_text = "Well sorry. I can't tell if my answer is correct.. please question the others.. maybe they know.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 2,
					_counter = 8,
					_text = "Okay, thanks anyway.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 3,
					_counter = 0,
					_text = "Hello, " + GameHandler._dialog_dept.Remove(1, 7) + ". Can I talk to you for a second?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 3,
					_counter = 1,
					_text = "Hi, sure, go ahead",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 3,
					_counter = 2,
					_text = "The guy that flipped his car told me that the crash was caused by a third car, is this correct?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 3,
					_counter = 3,
					_text = "Yep. As you can see, I tried to stop but failed.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 3,
					_counter = 4,
					_text = "Can you remember a licence plate or a the car type or maybe the color?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 3,
					_counter = 5,
					_text = "No sorry. My eyes where focused on car in front of me... sorry",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 3,
					_counter = 6,
					_text = "Okay, if you need anything then contact " + GameHandler._dialog_dept.Remove(1, 7) + ".",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 0,
					_text = "Hey there, I'm officer " + Globals.CharacterName + ". Are you the 911 caller?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 1,
					_text = "Yes I called the police. I was driving a little bit behind those two when the accident happened",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 2,
					_text = "There seems to be a third car which was causing the accident. Did you see the licence plate of the",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 3,
					_text = "Yes, but the car wasn't a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 4,
					_text = "Then the others must be wrong. Which type was it?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 5,
					_text = "It was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 6,
					_text = "Thanks for your help, appreciate it. You can leave now",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 15,
					_contactid = 4,
					_counter = 7,
					_text = "Okay. Goodbye",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 1,
					_counter = 0,
					_text = "Hi, How can I assist?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 1,
					_counter = 1,
					_text = "Hello " + Globals.CharacterName + ", did dispatch inform you?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 1,
					_counter = 2,
					_text = "No, just send me here. So what happened here",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 1,
					_counter = 3,
					_text = "Its a Hit and Run. But I just shortly talked to the witnesses. Bring yourself up-to-date by talking to the involved ones.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 1,
					_counter = 4,
					_text = "Okay, I will do so.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 1,
					_counter = 5,
					_text = "I will make sure that we don't get a traffic jam here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 0,
					_text = "Hi, I'm office " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 1,
					_text = "Shit... my head hurts.. where is my girlfriend..?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 2,
					_text = "She left in the helicopter. She need to get to the hospital as quickly as possible.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 3,
					_text = "Fuck, were is that fucking bastard..",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 4,
					_text = "What bastard, Please tell me what happened.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 5,
					_text = "A car pushed my off the road. I think it was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 6,
					_text = "I will get out a BOLO for that car model. Give me a second.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 7,
					_text = "No stop... I don't know .Maybe it was a different one.Does anyone of the others know ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 2,
					_counter = 8,
					_text = "I will ask them. For know please stay here. Paramedics will take a look at you",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 3,
					_counter = 0,
					_text = "Hello, " + GameHandler._dialog_dept.Remove(1, 7) + ". Do you have any injuries?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 3,
					_counter = 1,
					_text = "Just some small bruisings. Nothing really mentionable.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 3,
					_counter = 2,
					_text = "The other involved person told me that he was forced of the road by another car. Is that true?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 3,
					_counter = 3,
					_text = "Yes. I was directly behind him, maybe a little bit to near... ah whatever.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 3,
					_counter = 4,
					_text = "For know I don't care about that. Can you remember a licence plate or a the car type or maybe the color?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 3,
					_counter = 5,
					_text = "Sorry. No.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 3,
					_counter = 6,
					_text = "Okay thanks, " + GameHandler._dialog_dept.Remove(1, 7) + " will contact you later.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 0,
					_text = "Hi, my name is " + Globals.CharacterName + " form the " + GameHandler._dialog_dept.Remove(1, 7) + " . Are you okay?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 1,
					_text = "Hello officer, yes I'm okay and luckily I don't have any damage cause I could stop in time.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 2,
					_text = "The other two told me that someone forced them off the road. Car type is a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 3,
					_text = "That's true. I was driving behind them. But the car wasn't a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 4,
					_text = "Well... please tell my then.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 5,
					_text = "It was a",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 6,
					_text = "Thank for you help. You can leave now",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 16,
					_contactid = 4,
					_counter = 7,
					_text = "Okay. Bye",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 1,
					_counter = 0,
					_text = "Hi. How can I help?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 1,
					_counter = 1,
					_text = "Hi Officer. We actually don't know what happened right now.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 1,
					_counter = 2,
					_text = "Okay... Strange. Did anyone see anything?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 1,
					_counter = 3,
					_text = "No. The lifeguards found him about 10 minutes ago, just stranded here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 1,
					_counter = 4,
					_text = "Okay. I'll question some people here and see if they know anything.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I can tell you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 2,
					_counter = 0,
					_text = "Hey, did you see what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 2,
					_counter = 1,
					_text = "Nope. I saw a crowd forming, and I wanted to check out what was going on.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 2,
					_counter = 2,
					_text = "Huh. Okay then...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 2,
					_counter = 3,
					_text = "Sorry.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 3,
					_counter = 0,
					_text = "Hey there. Do you know what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 3,
					_counter = 1,
					_text = "Unfortunately, I have no clue. I was just walking and saw him laying there. I tried asking if he was okay, but he didn't answer, so I called 911.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 3,
					_counter = 2,
					_text = "Okay then. Why don't you and your buddies clear the scene. We'll take it from here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 3,
					_counter = 3,
					_text = "Okay... Damn, hope he makes it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 0,
					_text = "Hello. You are the one that called 911, correct?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 1,
					_text = "Yes officer. Sorry for calling so late, I'm from Europe and not used to the emergency system in America.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 2,
					_text = "It's okay. Can you tell me what you saw?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 3,
					_text = "~w~ speedboat that hit the surfer.They didn't bother stopping. They hit him and kept on going!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 4,
					_text = "Do you know the direction the boat was heading?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 5,
					_text = "I believe the boat was heading to",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 6,
					_text = "Okay. Thank you for your information. Is there anything else you can tell us?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 4,
					_counter = 7,
					_text = "No... unfortunately that's it. Sorry!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 17,
					_contactid = 5,
					_counter = 1,
					_text = "A tourist has reported a crime which is maybe connected to your injured surfer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 1,
					_counter = 0,
					_text = "Hi, everything under control here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 1,
					_counter = 1,
					_text = "Hi Officer. We are busy keeping the crowd away from the scene",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 1,
					_counter = 2,
					_text = "What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 1,
					_counter = 3,
					_text = "The civilians found him 10 minutes ago and called in the lifeguards. I don't have more for you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 1,
					_counter = 4,
					_text = "Okay. Thanks for the info. I'll try to find out if somebody knows anything.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I know!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 2,
					_counter = 0,
					_text = "Hello. My name is " + Globals.CharacterName + ". I'm from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Do you know what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 2,
					_counter = 1,
					_text = "No sorry. I just wanted to know what was going on here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 2,
					_counter = 2,
					_text = "Okay. Please stay away from the scene...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 2,
					_counter = 3,
					_text = "Okay.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 3,
					_counter = 0,
					_text = "Hey there. " + GameHandler._dialog_dept.Remove(1, 7) + ". Can you tell me what happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 3,
					_counter = 1,
					_text = "Yes. We were training here at the beach when I noticed the body in the sand. We tried to talk to him but he didn't answer, so I called 911.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 3,
					_counter = 2,
					_text = "Anything else?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 3,
					_counter = 3,
					_text = "Nope. Sorry.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 0,
					_text = "Hello. Are you the worker that called 911?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 1,
					_text = "Yeah officer. That's me.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 2,
					_text = "Good. Can you describe what you have seen?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 3,
					_text = "~w~ speedboat that hit the surfer. I think they didn't see him but they hit him and kept on going!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 4,
					_text = "Do you have any idea where the boat went?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 5,
					_text = "You're lucky man. Yesterday I saw the exact same boat in the city. It was in",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 6,
					_text = "Thank you. That will make our jobs a lot easier.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 4,
					_counter = 7,
					_text = "Nice to know that I could help you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 18,
					_contactid = 5,
					_counter = 1,
					_text = "A dock worker has reported a hit and run matching your scene location.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Officer. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 1,
					_counter = 1,
					_text = "Hey Partner, thanks for coming out. I just got here, but it appears to be a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 1,
					_counter = 2,
					_text = "Do we have a witness?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 1,
					_counter = 3,
					_text = "Try talking to the lady over there. She might know something.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 1,
					_counter = 4,
					_text = "Will do. Thanks for helping out.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 0,
					_text = "Hey Ma'am. Did you call the ambulance?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 1,
					_text = "Yes I did, officer!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 2,
					_text = "Thank you for that. Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ ran on the curb and hit the man as he attempted to cross the road!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. Did you see the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 5,
					_text = "I did... but I only remember the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 6,
					_text = "Okay. Thanks for your help. Give this officer a statement and you will be free to go on your way.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 7,
					_text = "Thank you officer. Will do.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 19,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Officer. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 1,
					_counter = 1,
					_text = "Hey Partner, thanks for coming out. I just got here, but it appears to be a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 1,
					_counter = 2,
					_text = "Do we have a witness?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 1,
					_counter = 3,
					_text = "Try talking to the lady over there. She might know something.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 1,
					_counter = 4,
					_text = "Will do. Thanks for helping out.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 0,
					_text = "Hey Ma'am. Did you call the ambulance?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 1,
					_text = "Yes I did, officer!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 2,
					_text = "Thank you for that. Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ ran on the curb and hit the man as he attempted to cross the road!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. Did you see the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 5,
					_text = "I did... but I only remember the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 6,
					_text = "Okay. Thanks for your help. Give this officer a statement and you will be free to go on your way.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 7,
					_text = "Thank you officer. Will do.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 20,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Officer. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 1,
					_counter = 1,
					_text = "Hey Partner, thanks for coming out. I just got here, but it appears to be a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 1,
					_counter = 2,
					_text = "Do we have a witness?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 1,
					_counter = 3,
					_text = "Try talking to the lady over there. She might know something.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 1,
					_counter = 4,
					_text = "Will do. Thanks for helping out.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 0,
					_text = "Hey Ma'am. Did you call the ambulance?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 1,
					_text = "Yes I did, officer!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 2,
					_text = "Thank you for that. Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ ran on the curb and hit the man as he attempted to cross the road!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. Did you see the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 5,
					_text = "I did... but I only remember the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 6,
					_text = "Okay. Thanks for your help. Give this officer a statement and you will be free to go on your way.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 7,
					_text = "Thank you officer. Will do.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 21,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Officer. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 1,
					_counter = 1,
					_text = "Hey Partner, thanks for coming out. I just got here, but it appears to be a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 1,
					_counter = 2,
					_text = "Do we have a witness?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 1,
					_counter = 3,
					_text = "Try talking to the lady over there. She might know something.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 1,
					_counter = 4,
					_text = "Will do. Thanks for helping out.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 0,
					_text = "Hey Ma'am. Did you call the ambulance?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 1,
					_text = "Yes I did, officer!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 2,
					_text = "Thank you for that. Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ ran on the curb and hit the man as he attempted to cross the road!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. Did you see the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 5,
					_text = "I did... but I only remember the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 6,
					_text = "Okay. Thanks for your help. Give this officer a statement and you will be free to go on your way.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 7,
					_text = "Thank you officer. Will do.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 22,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 1,
					_counter = 0,
					_text = "Hi Chloe. First deployment today?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 1,
					_counter = 1,
					_text = "Hey " + Globals.CharacterName + ", nice to see you. Yes the first one today.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 1,
					_counter = 2,
					_text = "So what do we have here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 1,
					_counter = 3,
					_text = "Seems to be a Hit and Run. Talk to the Woman over there she will update you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 1,
					_counter = 4,
					_text = "Okay. Ehm.. Let go for a drink when your shift is over.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 1,
					_counter = 5,
					_text = "Sure why not... see ya later.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Ma'am. I'm officer " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ".Can you describe what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 1,
					_text = "Hi, yes this is my boyfriend who got hit!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 2,
					_text = "Oh, I didn't know. So why is he hurt?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ came out of this alleyway and hit him!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 4,
					_text = "Can you tell me the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 5,
					_text = "Only partly. I remember the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 6,
					_text = "I will run that in the Police computer and see what's popping up. I have no more question",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 7,
					_text = "Alright then. Bye",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 23,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry,but t hat's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 1,
					_counter = 0,
					_text = "Hey. How can assist?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 1,
					_counter = 1,
					_text = "Hi buddy, please help me with accident. It a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 1,
					_counter = 2,
					_text = "Okay? How do you know that?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 1,
					_counter = 3,
					_text = "The woman is the guys wife. She told me that. But ask her yourself.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 1,
					_counter = 4,
					_text = "Will do so. Anything else?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 1,
					_counter = 5,
					_text = "Nope. That is all I know!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Miss. My name is " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". What happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 1,
					_text = "Hello officer! Some stupid dude ran him over.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 2,
					_text = "Can you describe the vehicle or do you know the type?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ came around with a high rate of speed. I think he lost control, that is why he hit my husband!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 4,
					_text = "Okay. Do you remember the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 5,
					_text = "I already thought about that, but I just remember the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 6,
					_text = "Thanks. That's more then in the most cases. Maybe we get a hit.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 7,
					_text = "Thank you officer. Please get this bastard.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 24,
					_contactid = 2,
					_counter = 8,
					_text = "I don't know anything more. Sorry.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 1,
					_counter = 0,
					_text = "Hi, you requested backup. How can i help?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 1,
					_counter = 1,
					_text = "Hey Partner, thanks for coming. I just arrived, but it looks that this accident wasn't self-inflicted.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 1,
					_counter = 2,
					_text = "Okay, Do we have a witness who maybe knows something?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 1,
					_counter = 3,
					_text = "Yes. One of the shop owners came out when i got here. Talk to him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 1,
					_counter = 4,
					_text = "At least something. I will question him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 0,
					_text = "Hi Sir. My name is " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Do you want to tell me anything?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 1,
					_text = "Yes, officer " + Globals.CharacterName + ". I called 911!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 2,
					_text = "Thank you. Can you tell me what happened to the woman?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ parked out and hit the woman in reverse and then just left the area.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 4,
					_text = "Did you see the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 5,
					_text = "I was still in my shop so i don't know the complete plate. Only the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 6,
					_text = "Okay. Thanks for your help. My partner will maybe ask you also some questions.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 7,
					_text = "Okay.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 25,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 1,
					_counter = 0,
					_text = "Hello Officer, what can i do for you?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 1,
					_counter = 1,
					_text = "Hi, thanks for the response. It appears to be a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 1,
					_counter = 2,
					_text = "How do you know this?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 1,
					_counter = 3,
					_text = "I shorty talked to the victim. But there is maybe witness. Talk to the Woman in front the Liquor store.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 1,
					_counter = 4,
					_text = "Sure. I will try to find out more about the accident.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Miss. I'm officer " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Do you know anything about the accident?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 1,
					_text = "Yes, officer i do. I'm the owner of this store and i ran out as i saw a car ran over this guy!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 2,
					_text = "Can you tell me how this happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ was driving down Joshua road when it suddenly came on the sidewalk and hit the guy!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 4,
					_text = "Well did you maybe see the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 5,
					_text = "It all went very fast, so I only remember the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 6,
					_text = "That is more then enough. It will definitely help to find out the driver. You can leave now.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 7,
					_text = "Thank you officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 26,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 1,
					_counter = 0,
					_text = "Hey, how i can assist?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 1,
					_counter = 1,
					_text = "Oh hi " + Globals.CharacterName + ". I thought you are on vacation?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 1,
					_counter = 2,
					_text = "Well, someone got sick so i canceled it. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 1,
					_counter = 3,
					_text = "Sad to hear. The Visitor here got hit by car. The cook of this place can tell you more.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 1,
					_counter = 4,
					_text = "Okay. I will ask him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Sir. My name is " + Globals.CharacterName + " from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Can you tell me what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 1,
					_text = "Sure, officer " + Globals.CharacterName + ". I saw the accident and called 9-1-1.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 2,
					_text = "Thanks. So what happened to your visitor?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ just ran him over. The car came out this parking place.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 4,
					_text = "Do you have surveillance cameras to maybe get the license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 5,
					_text = "Yes, but they are not working. But I remember the last 3 digits of the car. It was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 6,
					_text = "Please fix your cameras. I would make my job easier, but at least we have 3 numbers. That's all thanks",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 7,
					_text = "I will do so officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 27,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 1,
					_counter = 0,
					_text = "Hello. Whats going on?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 1,
					_counter = 1,
					_text = "Hi. I just arrived a minute ago, so i can't tell.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 1,
					_counter = 2,
					_text = "Okay. Have you spoken to anybody?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 1,
					_counter = 3,
					_text = "I just wanted to do that. But now you are here. So can you take over?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 1,
					_counter = 4,
					_text = "Sure i will do so. Maybe make some notes about the scene.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 1,
					_counter = 5,
					_text = "I'm writing down some notes about the scene!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 0,
					_text = "Hello Sir. I'm from the " + GameHandler._dialog_dept.Remove(1, 7) + ". Did you see how this man got hurt?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 1,
					_text = "Hello officer! Yes i did. I called 9-1-1 form the phone booth.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 2,
					_text = "Okay. Then please describe how this happened",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ came from the petrol pump. The guy crossed the exit and the car ran over him. It didn't stop. I immediately left the place",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 4,
					_text = "Can you remember the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 5,
					_text = "Damn no. Maybe the last 3 digits. They could be ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 6,
					_text = "Okay. I will try to run this in our system. Maybe we get a hit. Thanks for your cooperation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 7,
					_text = "No problem, anytime.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 28,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 1,
					_counter = 0,
					_text = "Hey Ranger. What can i do for you?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 1,
					_counter = 1,
					_text = "Hello officer, thanks for responding. I was coming back to the station when i found them here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 1,
					_counter = 2,
					_text = "Do you know what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 1,
					_counter = 3,
					_text = "To be honest, i didn't ask. Its your jurisdiction and i was busy getting EMS here and providing first aid.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 1,
					_counter = 4,
					_text = "Fair enough. I will ask the man some questions.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 0,
					_text = "Hey Sir. My name is " + Globals.CharacterName + ". Can you tell what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 1,
					_text = "Hi officer. I'm glad that the ranger came bye and called the EMS.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 2,
					_text = "Okay. Please focus on my questions. What happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ was driving crazy down here. We wanted to go for a hike and then it suddenly appeared and hit my girl!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 4,
					_text = "Did you see the vehicle's license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 5,
					_text = "I tried to. But in only saw the last 3 digits. It was ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 6,
					_text = "Thanks for that. For now thats enough. Maybe " + GameHandler._dialog_dept.Remove(1, 7) + " will contact you later.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 7,
					_text = "Okay. Thank you officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 29,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 1,
					_counter = 0,
					_text = "Hey buddy. What happened here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 1,
					_counter = 1,
					_text = "Hi. Appears to be a Hit and Run. Paramedics told me that.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 1,
					_counter = 2,
					_text = "Do we have a witness?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 1,
					_counter = 3,
					_text = "Yeah, its the gas station owner. He told the paramedics that i was a Hit and Run.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 1,
					_counter = 4,
					_text = "Okay then i will ask him.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 1,
					_counter = 5,
					_text = "That is all I have for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 0,
					_text = "Hey Sir. Are you the one that called the police.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 1,
					_text = "No officer, it was one of my customers. But he already left.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 2,
					_text = "Thats not good. Did you maybe saw what happened?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 3,
					_text = "~w~ left the gas station and hit the man. I didn't saw it, but i was told.!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 4,
					_text = "Hm. Did the customer see a license plate?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 5,
					_text = "No. But I did see the last 3 digits. They are ~y~",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 6,
					_text = "Okay that's good. Thanks for your help. Please give this officer a statement for the record.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 7,
					_text = "Will do.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 30,
					_contactid = 2,
					_counter = 8,
					_text = "Sorry, but that's all I can tell you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 1,
					_counter = 0,
					_text = "Hello Ma'am, are you the one that called in a disturbance?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 1,
					_counter = 1,
					_text = "Hello Officer. Yes I did. Can you hear that loud music?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 1,
					_counter = 2,
					_text = "Yes. How long have they been playing their music that loudly?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 1,
					_counter = 3,
					_text = "It's been going on for at least 4 hours now. Can you please stop it? It is coming from that house.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 1,
					_counter = 4,
					_text = "I'll do my best to have them shut it off. Thanks for letting us know about it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 1,
					_counter = 5,
					_text = "Thank you Officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 0,
					_text = "Hello everybody. Who is the owner of this property?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 1,
					_text = "Hello Officer. This is my house... Is there a problem?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 2,
					_text = "Hi, we have a complaint from one of your neighbours regarding the loud music. What's your name sir?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 3,
					_text = "I'm not telling you that! We're having a party, they should expect to hear us!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 4,
					_text = "Alright sir, well I need you to turn down the volume.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 5,
					_text = "Fine... If you say so. Give me a second...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 6,
					_text = "Better now?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 7,
					_text = "Yes, thank you for your cooperation. Have a fun rest of your time.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 2,
					_counter = 8,
					_text = "Whatever party killer...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 0,
					_text = "Sir, do you think its necessary for me to have to come back again?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 1,
					_text = "Oh hey officer. Sorry, I guess one of my friends turned the volume up. I'll go turn it down.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 2,
					_text = "Well this is my second time here. I don't care about excuses. Turn off the music.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 3,
					_text = "Why? Havn't you had fun as a teen? Quit complaining, we're having fun!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 4,
					_text = "I warned you already. Turn it off now.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 5,
					_text = "No. You can't make me. Im sick of you trying to ruin my party.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 6,
					_text = "There are two ways this will end. First, you turn off the music and continue your party.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 3,
					_counter = 7,
					_text = "Second, if you refuse to cooperate, the party ends and I will take you in for disturbing the peace. Its your choice.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 4,
					_counter = 0,
					_text = "Alright then... I will turn off the music.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 4,
					_counter = 1,
					_text = "Happy now?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 4,
					_counter = 2,
					_text = "Wise decision my friend. Regardless of this action, have a nice day.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 4,
					_counter = 3,
					_text = "Leave my property. The people around here suck...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 5,
					_counter = 0,
					_text = "Fuckin' pig!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 5,
					_counter = 1,
					_text = "Okay bud, put your hands where I can see them. You are going to jail for disturbing the peace.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 31,
					_contactid = 5,
					_counter = 2,
					_text = "Wow, I can't believe this. Clearly someone doesn't know how to have fun!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 1,
					_counter = 0,
					_text = "Excuse me sir, are you the one that called regarding the loud music?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 1,
					_counter = 1,
					_text = "Hi Officer. Yes, I was the one that called the police.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 1,
					_counter = 2,
					_text = "I'm assuming you are talking about the music that I'm hearing in background?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 1,
					_counter = 3,
					_text = "Yes. Those party-goers are always partying, and us neighbors are always suffering! Can you shut it down please?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 1,
					_counter = 4,
					_text = "Certainly. I will take to the owner and ask them to lower the volume.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 1,
					_counter = 5,
					_text = "Thank you so much officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 0,
					_text = "Hi. I'm officer " + Globals.CharacterName + ". Who is responsible for this party?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 1,
					_text = "That's me. Michael De Santa. Is there a problem officer?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 2,
					_text = "Yes Mr. De Santa. Sorry to interrupt but people in your neighborhood are complaining about the loud music.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 3,
					_text = "Oh come on, this is a celebration party for my daughter Tracy. She finally got a job on TV.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 4,
					_text = "Well that's nice to hear Michael, but I need you to turn down the volume.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 5,
					_text = "Alright then, give me second...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 6,
					_text = "Are you satisfied with it now?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 7,
					_text = "Thank you Mr. De Santa. I appreciate your cooperation. Have a nice party.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 2,
					_counter = 8,
					_text = "It won't be as fun...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 0,
					_text = "Can I talk to you for again Mr. De Santa?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 1,
					_text = "What now?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 2,
					_text = "Why is the music so loud again?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 3,
					_text = "Do you really want an answer for that?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 4,
					_text = "Basically I don't care. Turn off the music, or I will take you to jail.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 5,
					_text = "What the fuck? Why are you acting like a pussy?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 6,
					_text = "I asked you kindly to turn off the music, and now you have no choice.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 3,
					_counter = 7,
					_text = "Turn off the music before I take you in.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 4,
					_counter = 0,
					_text = "Okay okay, don't lose yourself.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 4,
					_counter = 1,
					_text = "Happy now?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 4,
					_counter = 2,
					_text = "If I have to come back again, you're going right to the station. Goodbye Mr. De Santa.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 4,
					_counter = 3,
					_text = "Whatever dude. Go back to your group therapy...knuckle head",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 5,
					_counter = 0,
					_text = "The hell I will!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 5,
					_counter = 1,
					_text = "Then I will take you down to the station for disturbing the peace. Let me see your hands.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 32,
					_contactid = 5,
					_counter = 2,
					_text = "This is stupid. I'm gunna call my lawyer you son of a bitch!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 1,
					_counter = 0,
					_text = "Hello. Did you call 911 reporting loud music?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 1,
					_counter = 1,
					_text = "Hello Officer. Yes. They have been playing it for a few hours. Enough is enough!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 1,
					_counter = 2,
					_text = "I agree. Has the volume always been this loud?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 1,
					_counter = 3,
					_text = "There were a few minutes it was quiet, but its been like this for hours.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 1,
					_counter = 4,
					_text = "Okay. I'll make contact with the house owner and ask them to turn down the volume.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 1,
					_counter = 5,
					_text = "Thank you for taking this seriously.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 0,
					_text = "Hello. Can I talk to the house owner for minute?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 1,
					_text = "Yo dog, I'm Franklin Clinton. This is my crib, whats going on?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 2,
					_text = "Hello Mr. Clinton, we got a complaint regarding your loud music.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 3,
					_text = "What? This ain't too loud. People still can talk to each other...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 4,
					_text = "Regardless, please turn down the volume.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 5,
					_text = "Fine, if I have to...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 6,
					_text = "Is this okay for my officer friend?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 7,
					_text = "Yes it is. Thanks for your cooperation.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 2,
					_counter = 8,
					_text = "Thank you officer!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 0,
					_text = "Hey Mr. Clinton, come back over here please.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 1,
					_text = "Hey yo. What'cha doing here again?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 2,
					_text = "I'm back because the music is too loud again.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 3,
					_text = "I think its the same volume as when you left. The dude complaining must have a pack of damaged ears.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 4,
					_text = "Sir, you need to turn off the volume now.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 5,
					_text = "What? No, I'll just turn it down. It doesn't have to be turned off!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 6,
					_text = "Sir, please don't make this harder than it has to be.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 3,
					_counter = 7,
					_text = "Turn off the music, before I take you to jail for disturbing the peace.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 4,
					_counter = 0,
					_text = "Eh, if the cop says to turn it off, I guess I have to turn it off...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 4,
					_counter = 1,
					_text = "Silence has arrived. Are you happy?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 4,
					_counter = 2,
					_text = "I hope you keep it like this. Thank you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 4,
					_counter = 3,
					_text = "Sorry for causing you the hassle, officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 5,
					_counter = 0,
					_text = "You know what, go suck a mighty...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 5,
					_counter = 1,
					_text = "Okay, put your hands where I can see them. You are being placed under arrest for disturbing the peace.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 33,
					_contactid = 5,
					_counter = 2,
					_text = "Jail ain't gunna do nothing, pig!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 1,
					_counter = 0,
					_text = "Hi Ma'am. Did you called 911 because of a disturbing noise?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 1,
					_counter = 1,
					_text = "Hi Officer. Yes I called the cops. The party is too wild. They are throwing beer bottles and doing other bizarre things..",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 1,
					_counter = 2,
					_text = "Did they throw anything out into the streets or at your houses?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 1,
					_counter = 3,
					_text = "Luckily they didn't. Its the house over there with The Lost van.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 1,
					_counter = 4,
					_text = "Seems to be a biker party. Why don't you go back inside while we handle the party.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 1,
					_counter = 5,
					_text = "Thank you.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 0,
					_text = "Hi everyone. Who is the owner here?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 1,
					_text = "That would be me. What can I do for the pig in a uniform?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 2,
					_text = "Your music is too loud. I'm going to have to ask you to turn it down.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 3,
					_text = "Nah, I don't hear any music.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 4,
					_text = "Do you want to cooperate, or should I take you to jail for disturbing the peace?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 5,
					_text = "If thats how you want to be, let me go turn it down.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 6,
					_text = "Don't think that you have won.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 7,
					_text = "Alright bud, thanks for cooperating. Don't make me have to come out again.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 2,
					_counter = 8,
					_text = "Seeya pig in a uniform!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 0,
					_text = "Sir, come over here for a minute.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 1,
					_text = "Whats going on pig in a uniform? Want to join us?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 2,
					_text = "No. You need to turn off the music and stop the party.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 3,
					_text = "Nah! I don't hear any music, and I don't think any of my brothers or sisters do.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 4,
					_text = "It'll take some time to write down all the violations I see here. I think it will be a hefty fine, unless you would like to cooperate.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 5,
					_text = "Whats your fucking problem pig in a uniform?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 6,
					_text = "My problem is that you feel the need to not listen.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 3,
					_counter = 7,
					_text = "Last chance. Turn off the music, or you will go to jail for disturbing the peace.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 4,
					_counter = 0,
					_text = "This time I will listen.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 4,
					_counter = 1,
					_text = "Next time I won't.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 4,
					_counter = 2,
					_text = "Next time I'll put you to jail if you don't cooperate. Have a great day.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 4,
					_counter = 3,
					_text = "Fucking pigs in a uniform. You did not win this battle.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 5,
					_counter = 0,
					_text = "You motherfucking pig in a uniform. I won't do a thing that you're saying!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 5,
					_counter = 1,
					_text = "Show me your hands. You are currently being placed under arrest for disturbing the peace.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 34,
					_contactid = 5,
					_counter = 2,
					_text = "That is why I hate cops.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 1,
					_counter = 0,
					_text = "Hello Ma'am. You have called the police because of a loud party?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 1,
					_counter = 1,
					_text = "Hi Officer. Do you here the music? It is now the third time that this bitch has a party like this.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 1,
					_counter = 2,
					_text = "No need to insult your neighbour. Did you talk to her?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 1,
					_counter = 3,
					_text = "No i won't talk to her. The house is over there. Try the door at the left, otherwise you will find them on the top terrace.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 1,
					_counter = 4,
					_text = "Ok thanks for the info. Please get back into your house. I will take care about this issue.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 1,
					_counter = 5,
					_text = "I hope she goes to jail, bye.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 0,
					_text = "Hello everybody. I need to talk to the owner of this house.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 1,
					_text = "Hello officer, that's me. What can i do for you?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 2,
					_text = "There has been a report of civil disturbance because of loud music.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 3,
					_text = "Are you sure that's my party?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 4,
					_text = "Yes i'm sure. Please do me a favour and lower the volume to adequate noise level.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 5,
					_text = "Well then ok, wait here.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 6,
					_text = "This is the maximum i want to lower it. Is it ok ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 7,
					_text = "Yes Miss, thank you and have a nice day.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 2,
					_counter = 8,
					_text = "Bye.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 0,
					_text = "Miss, step over here please!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 1,
					_text = "Ahm ok? What did i do wrong now ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 2,
					_text = "The noise level is back to ist original. Can you tell me why?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 3,
					_text = "No it is still the same as you left. You must have something with you ears�",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 4,
					_text = "My ears are fine, but it seem like you memory is not. Turn off the music immediatly!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 5,
					_text = "Why are you so unfriendly? I don't like that.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 6,
					_text = "Well i don't like that you are lying to me.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 3,
					_counter = 7,
					_text = "I say this only once. Turn off the music now or i will pull the plug and take you down to the station.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 4,
					_counter = 0,
					_text = "Alright, sorry� i do it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 4,
					_counter = 1,
					_text = "I don't want to have any trouble.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 4,
					_counter = 2,
					_text = "Next time think about this when you lie to the police. Goodbye.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 4,
					_counter = 3,
					_text = "What a jerk�",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 5,
					_counter = 0,
					_text = "You know what. NO. I think you are overreacting. The noise level is fine.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 5,
					_counter = 1,
					_text = "I have enough of this. You can explain this down at the station. Show me your hands.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 35,
					_contactid = 5,
					_counter = 2,
					_text = "� stupid whore downstairs. She is the one who should get arrested",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 1,
					_counter = 0,
					_text = "Hello Sir. You've called 9-1-1 because of too loud music?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 1,
					_counter = 1,
					_text = "Hello Officer, yes, i called the police cause they are playing the music too loud.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 1,
					_counter = 2,
					_text = "Did you talk to the owner to turn the volume down ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 1,
					_counter = 3,
					_text = "No i did not. It is the house over there.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 1,
					_counter = 4,
					_text = "Well next time please try yourself. This time i will talk to the owner.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 1,
					_counter = 5,
					_text = "Ok, thanks.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 0,
					_text = "Hello ? Can i please talk to the owner of this property ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 1,
					_text = "Sure, i'm the new owner of this house. What can i do for you officer?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 2,
					_text = "We have a complaint regarding your party. Could you please lower the volume?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 3,
					_text = "Man, must be that stupid prick next to me. What has he said ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 4,
					_text = "I can't give you any details about the complaint. Please just turn down the volume ok ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 5,
					_text = "Yeah of course, i don't want to make any trouble.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 6,
					_text = "Satisfied with the volume level ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 7,
					_text = "Yes Sir, thanks for you understanding. Have a nice party.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 2,
					_counter = 8,
					_text = "Goodbye officer.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 0,
					_text = "Sir, I need to talk to you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 1,
					_text = "Oh hell no, what's the problem now ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 2,
					_text = "I kindly asked you to lower the volume. It seems like it doesn't had any effect. Now you need to turn it off!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 3,
					_text = "What ? Do you know how much a party like this costs? Music is essential for me. Therefore it stays on!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 4,
					_text = "I'm sorry but you don't have any other possibility. You had your chance.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 5,
					_text = "You know that i earn more money in a day that you make in a year ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 6,
					_text = "I don't care about your financial situation Sir.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 3,
					_counter = 7,
					_text = "Don't hedge arround the problem. Turn off the music  now or i will do it!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 4,
					_counter = 0,
					_text = "Whatever, but this will have consequences for you!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 4,
					_counter = 1,
					_text = "Give me your name and Badgenumber so that i can make a complaint at the department.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 4,
					_counter = 2,
					_text = "You can get this information directly at the department downtown. Have nice day Sir.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 4,
					_counter = 3,
					_text = "You won't get away with it. This will have repercussions.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 5,
					_counter = 0,
					_text = "My answer is simple. NO. I won't turn off the music!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 5,
					_counter = 1,
					_text = "Then i have no other choice as to take you down to the station. Please show me hands.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 36,
					_contactid = 5,
					_counter = 2,
					_text = "I can't believe that shit.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 1,
					_counter = 0,
					_text = "Hi Sir. You called 911. How can i help you ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 1,
					_counter = 1,
					_text = "Yes Hello, i want you to go over the street and turn off the music. It is annoying.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 1,
					_counter = 2,
					_text = "Relax Sir. How long do they play with that volume level.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 1,
					_counter = 3,
					_text = "I don't remember. Just go over there and pull the plug.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 1,
					_counter = 4,
					_text = "Ok Sir, please go back inside. I will make contact with the owner and ask him to lower the volume.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 1,
					_counter = 5,
					_text = "No not lowering, it has to be off! You understand ?...",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 0,
					_text = "Excuse me. Who is the responsible person for this party?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 1,
					_text = "Oh police. Yeah that's me officer. What's the problem?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 2,
					_text = "Your neighbours are complaining about you noise level.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 3,
					_text = "Come on, these old assholes should crawl back into their coffins�",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 4,
					_text = "Please don't insult anybody, just lower the volume please.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 5,
					_text = "I'm really pissed� ok i will lower it.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 6,
					_text = "Is it ok now ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 7,
					_text = "Sure thats fine. Please keep noise level down ok ? Goodbye.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 2,
					_counter = 8,
					_text = "Aha� we will see�",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 0,
					_text = "Sir, step over here!",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 1,
					_text = "Police again ?... Oh man, what now ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 2,
					_text = "My last visit seems to have no effect, so now please turn off the music.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 3,
					_text = "What? Come on, i will lower the volume and keep it there, i promise.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 4,
					_text = "Sir you had your chance. Sorry but this time you have to turn if off.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 5,
					_text = "Whats your fucking problem? I said i promise to keep it low.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 6,
					_text = "Your promise is not enough.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 3,
					_counter = 7,
					_text = "Turn it off now or i will do it for you and you can explain it at the station.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 4,
					_counter = 0,
					_text = "Always the same shit with these old bastards�",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 4,
					_counter = 1,
					_text = "Happy now ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 4,
					_counter = 2,
					_text = "Yes and keep it off understood ?",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 4,
					_counter = 3,
					_text = "Just leave man.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 5,
					_counter = 0,
					_text = "I don't think i wanna do this. I like it that way.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 5,
					_counter = 1,
					_text = "Well then lets have a chat at the station. Show me your hands.",
				});		
				
				DialogList.Add(new Globals.Dialogs
				{
					_calloutid = 37,
					_contactid = 5,
					_counter = 2,
					_text = "This is just bullshit�.",
				});		
				
				#endregion Dialogs

				#region Positions
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 31,
					_type = Globals.PositionType.DOORBELL,
					_position = new Vector3(-214.346f, 6396.502f, 32f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 31,
					_type = Globals.PositionType.BACKYARD,
					_position = new Vector3(-1011.581f, 761.659f, 170.0f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 31,
					_type = Globals.PositionType.PEDTALK,
					_position = new Vector3(-1011.600f, 761.981f, 171.379f),
					_heading = 205f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 31,
					_type = Globals.PositionType.MUSIC,
					_position = new Vector3(-1015.862f, 770.888f, 170.0f),
					_heading = 27.622f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 32,
					_type = Globals.PositionType.DOORBELL,
					_position = new Vector3(-1940.702f, 386.947f, 95f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 32,
					_type = Globals.PositionType.BACKYARD,
					_position = new Vector3(-1921.376f, 400.660f, 95f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 32,
					_type = Globals.PositionType.PEDTALK,
					_position = new Vector3(-1921.751f, 400.443f, 96.296f),
					_heading = 231.397f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 32,
					_type = Globals.PositionType.MUSIC,
					_position = new Vector3(-1928.233f, 397.908f, 96.507f),
					_heading = 186.568f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 33,
					_type = Globals.PositionType.DOORBELL,
					_position = new Vector3(8.713f, 540.592f, 174.8f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 33,
					_type = Globals.PositionType.BACKYARD,
					_position = new Vector3(16.821f, 529.340f, 169.5f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 33,
					_type = Globals.PositionType.PEDTALK,
					_position = new Vector3(17.735f, 528.739f, 170.628f),
					_heading = 52.769f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 33,
					_type = Globals.PositionType.MUSIC,
					_position = new Vector3(23.308f, 532.160f, 170.628f),
					_heading = 308.021f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 34,
					_type = Globals.PositionType.DOORBELL,
					_position = new Vector3(906.64f, -490.16f, 58.30f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 34,
					_type = Globals.PositionType.BACKYARD,
					_position = new Vector3(903.12f, -471.27f, 57.80f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 34,
					_type = Globals.PositionType.PEDTALK,
					_position = new Vector3(901.41f, -471.87f, 59.02f),
					_heading = 291.03f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 34,
					_type = Globals.PositionType.MUSIC,
					_position = new Vector3(895.15f, -474.72f, 57.83f),
					_heading = 217.71f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 35,
					_type = Globals.PositionType.DOORBELL,
					_position = new Vector3(-1897.942f, -572.884f, 10.5f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 35,
					_type = Globals.PositionType.BACKYARD,
					_position = new Vector3(-1912.776f, -572.322f, 21.5f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 35,
					_type = Globals.PositionType.PEDTALK,
					_position = new Vector3(-1911.897f, -572.971f, 22.892f),
					_heading = 50.161f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 35,
					_type = Globals.PositionType.MUSIC,
					_position = new Vector3(-1905.797f, -577.867f, 22.892f),
					_heading = 236.886f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 36,
					_type = Globals.PositionType.DOORBELL,
					_position = new Vector3(-3017.632f, 746.330f, 26.5f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 36,
					_type = Globals.PositionType.BACKYARD,
					_position = new Vector3(-2999.792f, 750.592f, 25.5f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 36,
					_type = Globals.PositionType.PEDTALK,
					_position = new Vector3(-2999.766f, 752.213f, 26.687f),
					_heading = 180.241f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 36,
					_type = Globals.PositionType.MUSIC,
					_position = new Vector3(-3007.383f, 755.513f, 27.589f),
					_heading = 120.369f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 37,
					_type = Globals.PositionType.DOORBELL,
					_position = new Vector3(-214.346f, 6396.502f, 32),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 37,
					_type = Globals.PositionType.BACKYARD,
					_position = new Vector3(-190.673f, 6382.756f, 30.563f),
					_heading = 0f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 37,
					_type = Globals.PositionType.PEDTALK,
					_position = new Vector3(-191.501f, 6381.986f, 31.864f),
					_heading = 315.486f,
				});		
				
				PositionList.Add(new Globals.Positions
				{
					_calloutid = 37,
					_type = Globals.PositionType.MUSIC,
					_position = new Vector3(-202.542f, 6382.753f, 30.563f),
					_heading = 43.332f,
				});		
				
				#endregion Positions

			}
			catch (Exception ex)
            {
                Game.DisplayNotification("~r~LPCallouts~w~ Content Error: ~y~ModelDefintions~w~ could not be generated");
                Game.LogTrivial(ex.ToString());
            }
		}

	}
}