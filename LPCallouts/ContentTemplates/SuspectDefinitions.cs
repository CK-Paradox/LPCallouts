using System;
using System.Collections.Generic;
using System.Drawing;
//LPC
using LPCallouts.Internals;
//LSPDFR
using Rage;


namespace LPCallouts
{
	public class Suspects
	{
		public static List<Globals.SuspectLocation> SuspectLocations = new List<Globals.SuspectLocation>();
        public static List<Globals.SuspectPerson> SuspectPeds = new List<Globals.SuspectPerson>();
        public static List<Globals.SuspectCar> SuspectCars = new List<Globals.SuspectCar>();
        public static List<Globals.SuspectDialog> SuspectDialogs = new List<Globals.SuspectDialog>();
		public static List<Globals.SuspectPositions> SuspectPositions = new List<Globals.SuspectPositions>();

		public static void GenerateContent()
		{
			try
			{
				#region Locations
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-371.318f, 344.831f, 109.948f),
					_ped_heading = 20.069f,
					_veh_position = new Vector3(-372.963f, 348.187f, 108.676f),
					_veh_heading = 93.033f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(-414.738f, 358.037f, 107.174f),
					_police_heading = 276.016f,
				    _backup_position = new Vector3(-1333.969f, 210.553f, 58.286f),
					_backup_heading = 271.629f,
					_backup_veh_model = "POLICE4",
					_backup_ped_model = "s_f_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-350.299f, 514.528f, 120.639f),
					_ped_heading = 141.541f,
					_veh_position = new Vector3(-358.285f, 514.132f, 119.331f),
					_veh_heading = 132.976f,
					_veh_color1 = Color.Green,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-328.066f, 471.285f, 109.213f),
					_police_heading = 48.511f,
				    _backup_position = new Vector3(834.486f, 357.302f, 117.271f),
					_backup_heading = 121.921f,
					_backup_veh_model = "POLICE",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-185.555f, 964.173f, 237.534f),
					_ped_heading = 287.902f,
					_veh_position = new Vector3(-167.587f, 969.192f, 236.614f),
					_veh_heading = 315.644f,
					_veh_color1 = Color.Blue,
					_veh_color2 = Color.Yellow,
					_police_position = new Vector3(-160.591f, 1025.919f, 231.863f),
					_police_heading = 160.248f,
				    _backup_position = new Vector3(568.731f, 1804.229f, 209.388f),
					_backup_heading = 81.661f,
					_backup_veh_model = "POLICE2",
					_backup_ped_model = "s_f_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-1365.972f, 564.851f, 134.973f),
					_ped_heading = 333.800f,
					_veh_position = new Vector3(-1359.004f, 577.134f, 130.977f),
					_veh_heading = 246.286f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Blue,
					_police_position = new Vector3(-1361.306f, 615.420f, 133.841f),
					_police_heading = 180.518f,
				    _backup_position = new Vector3(-1662.834f, 964.894f, 151.636f),
					_backup_heading = 156.488f,
					_backup_veh_model = "POLICE2",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-597.178f, 852.608f, 211.384f),
					_ped_heading = 28.166f,
					_veh_position = new Vector3(-607.483f, 864.654f, 212.567f),
					_veh_heading = 336.557f,
					_veh_color1 = Color.Red,
					_veh_color2 = Color.White,
					_police_position = new Vector3(-532.592f, 845.190f, 195.326f),
					_police_heading = 85.084f,
				    _backup_position = new Vector3(323.728f, 860.678f, 193.908f),
					_backup_heading = 124.938f,
					_backup_veh_model = "POLICE",
					_backup_ped_model = "s_f_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1251.253f, -515.581f, 69.349f),
					_ped_heading = 234.660f,
					_veh_position = new Vector3(1241.170f, -519.351f, 68.568f),
					_veh_heading = 56.094f,
					_veh_color1 = Color.Green,
					_veh_color2 = Color.Yellow,
					_police_position = new Vector3(1269.386f, -495.490f, 68.649f),
					_police_heading = 155.285f,
				    _backup_position = new Vector3(784.387f, -569.989f, 31.048f),
					_backup_heading = 357.360f,
					_backup_veh_model = "POLICE4",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(963.588f, -595.303f, 59.903f),
					_ped_heading = 58.785f,
					_veh_position = new Vector3(961.343f, -608.722f, 58.738f),
					_veh_heading = 31.314f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.White,
					_police_position = new Vector3(956.704f, -624.036f, 57.001f),
					_police_heading = 43.843f,
				    _backup_position = new Vector3(1291.650f, -1513.463f, 42.278f),
					_backup_heading = 18.741f,
					_backup_veh_model = "POLICE3",
					_backup_ped_model = "s_f_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-868.808f, -1104.358f, 6.446f),
					_ped_heading = 272.131f,
					_veh_position = new Vector3(-862.831f, -1094.285f, 1.519f),
					_veh_heading = 298.837f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-896.707f, -1060.410f, 1.811f),
					_police_heading = 211.068f,
				    _backup_position = new Vector3(-94.625f, -623.919f, 35.968f),
					_backup_heading = 159.083f,
					_backup_veh_model = "POLICE",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1245.414f, -1626.040f, 53.282f),
					_ped_heading = 25.261f,
					_veh_position = new Vector3(1237.354f, -1632.322f, 51.609f),
					_veh_heading = 29.632f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(1266.683f, -1585.769f, 52.398f),
					_police_heading = 124.421f,
				    _backup_position = new Vector3(1944.870f, -1083.797f, 95.077f),
					_backup_heading = 343.818f,
					_backup_veh_model = "POLICE2",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-23.991f, -23.640f, 73.246f),
					_ped_heading = 19.733f,
					_veh_position = new Vector3(-38.168f, -32.076f, 68.579f),
					_veh_heading = 31.373f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-55.642f, -59.803f, 60.017f),
					_police_heading = 344.227f,
				    _backup_position = new Vector3(-893.565f, -400.468f, 38.027f),
					_backup_heading = 293.105f,
					_backup_veh_model = "POLICE",
					_backup_ped_model = "s_f_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(98.188f, -255.174f, 47.416f),
					_ped_heading = 20.523f,
					_veh_position = new Vector3(88.707f, -277.061f, 47.096f),
					_veh_heading = 159.349f,
					_veh_color1 = Color.Green,
					_veh_color2 = Color.White,
					_police_position = new Vector3(91.985f, -291.302f, 46.038f),
					_police_heading = 66.215f,
				    _backup_position = new Vector3(5.249f, -968.549f, 29.012f),
					_backup_heading = 250.240f,
					_backup_veh_model = "POLICE",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-240.293f, 381.124f, 112.428f),
					_ped_heading = 87.155f,
					_veh_position = new Vector3(-262.919f, 394.792f, 109.823f),
					_veh_heading = 219.269f,
					_veh_color1 = Color.Red,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-247.127f, 412.901f, 108.634f),
					_police_heading = 107.466f,
				    _backup_position = new Vector3(-1170.465f, 745.542f, 153.281f),
					_backup_heading = 144.715f,
					_backup_veh_model = "POLICE3",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-337.014f, 31.166f, 47.859f),
					_ped_heading = 75.784f,
					_veh_position = new Vector3(-355.108f, 37.789f, 47.761f),
					_veh_heading = 260.437f,
					_veh_color1 = Color.Yellow,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-382.589f, 40.574f, 49.704f),
					_police_heading = 179.398f,
				    _backup_position = new Vector3(376.576f, 195.229f, 102.641f),
					_backup_heading = 160.382f,
					_backup_veh_model = "POLICE2",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-927.363f, -949.452f, 2.745f),
					_ped_heading = 302.843f,
					_veh_position = new Vector3(-920.066f, -953.762f, 1.770f),
					_veh_heading = 119.409f,
					_veh_color1 = Color.Yellow,
					_veh_color2 = Color.White,
					_police_position = new Vector3(-884.182f, -995.304f, 1.997f),
					_police_heading = 30.604f,
				    _backup_position = new Vector3(-954.652f, -462.248f, 37.087f),
					_backup_heading = 207.065f,
					_backup_veh_model = "POLICE4",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-1183.101f, -1064.802f, 2.150f),
					_ped_heading = 99.883f,
					_veh_position = new Vector3(-1189.226f, -1066.147f, 1.757f),
					_veh_heading = 304.746f,
					_veh_color1 = Color.Red,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(-1176.466f, -1091.557f, 1.847f),
					_police_heading = 119.154f,
				    _backup_position = new Vector3(-1063.521f, -1925.449f, 12.681f),
					_backup_heading = 313.518f,
					_backup_veh_model = "POLICE3",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-1742.123f, 364.746f, 88.728f),
					_ped_heading = 126.255f,
					_veh_position = new Vector3(-1749.355f, 366.901f, 89.328f),
					_veh_heading = 296.631f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(-1793.107f, 355.609f, 88.191f),
					_police_heading = 298.284f,
				    _backup_position = new Vector3(-2524.658f, 1053.447f, 183.426f),
					_backup_heading = 253.084f,
					_backup_veh_model = "POLICE2",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-664.282f, 668.728f, 150.439f),
					_ped_heading = 21.047f,
					_veh_position = new Vector3(-666.219f, 671.326f, 150.035f),
					_veh_heading = 251.054f,
					_veh_color1 = Color.Green,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-674.583f, 690.649f, 153.261f),
					_police_heading = 177.695f,
				    _backup_position = new Vector3(-82.645f, 1057.137f, 224.564f),
					_backup_heading = 90.464f,
					_backup_veh_model = "POLICE",
					_backup_ped_model = "s_m_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-1230.736f, -1229.820f, 10.626f),
					_ped_heading = 45.886f,
					_veh_position = new Vector3(-1228.651f, -1231.822f, 6.643f),
					_veh_heading = 19.957f,
					_veh_color1 = Color.Blue,
					_veh_color2 = Color.Yellow,
					_police_position = new Vector3(-1248.725f, -1239.334f, 6.148f),
					_police_heading = 17.869f,
				    _backup_position = new Vector3(-226.522f, -866.854f, 29.715f),
					_backup_heading = 71.177f,
					_backup_veh_model = "POLICE2",
					_backup_ped_model = "s_f_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-604.034f, -782.574f, 25.017f),
					_ped_heading = 23.924f,
					_veh_position = new Vector3(-615.145f, -784.206f, 24.720f),
					_veh_heading = 180.402f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Blue,
					_police_position = new Vector3(-622.709f, -744.364f, 26.737f),
					_police_heading = 181.374f,
				    _backup_position = new Vector3(-15.712f, -1459.961f, 30.176f),
					_backup_heading = 94.684f,
					_backup_veh_model = "POLICE3",
					_backup_ped_model = "s_f_y_cop_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(506.038f, 2610.865f, 43.538f),
					_ped_heading = 46.029f,
					_veh_position = new Vector3(497.747f, 2614.405f, 42.609f),
					_veh_heading = 189.008f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.White,
					_police_position = new Vector3(578.037f, 2634.854f, 41.281f),
					_police_heading = 98.994f,
				    _backup_position = new Vector3(1983.873f, 2985.010f, 45.408f),
					_backup_heading = 101.194f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(365.784f, 2570.713f, 43.568f),
					_ped_heading = 117.713f,
					_veh_position = new Vector3(363.759f, 2567.007f, 43.169f),
					_veh_heading = 242.586f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(285.166f, 2593.573f, 44.053f),
					_police_heading = 222.417f,
				    _backup_position = new Vector3(-102.756f, 1984.025f, 184.524f),
					_backup_heading = 289.501f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(983.777f, 2717.923f, 39.503f),
					_ped_heading = 190.556f,
					_veh_position = new Vector3(970.941f, 2724.826f, 39.132f),
					_veh_heading = 345.501f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(1035.292f, 2677.197f, 39.161f),
					_police_heading = 90.432f,
				    _backup_position = new Vector3(2151.450f, 3260.888f, 45.689f),
					_backup_heading = 66.617f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1252.129f, 2741.905f, 38.447f),
					_ped_heading = 151.530f,
					_veh_position = new Vector3(1245.762f, 2743.315f, 38.094f),
					_veh_heading = 11.147f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(1212.119f, 2673.549f, 37.290f),
					_police_heading = 270.541f,
				    _backup_position = new Vector3(-118.223f, 2836.639f, 50.486f),
					_backup_heading = 246.870f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1405.868f, 3655.384f, 34.093f),
					_ped_heading = 47.059f,
					_veh_position = new Vector3(1405.566f, 3668.235f, 33.672f),
					_veh_heading = 274.537f,
					_veh_color1 = Color.Green,
					_veh_color2 = Color.White,
					_police_position = new Vector3(1337.182f, 3655.511f, 32.844f),
					_police_heading = 290.431f,
				    _backup_position = new Vector3(317.370f, 3438.884f, 36.114f),
					_backup_heading = 304.123f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1924.826f, 3897.377f, 32.645f),
					_ped_heading = 23.614f,
					_veh_position = new Vector3(1930.427f, 3903.034f, 32.281f),
					_veh_heading = 114.893f,
					_veh_color1 = Color.Red,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(1971.771f, 3852.292f, 31.681f),
					_police_heading = 34.252f,
				    _backup_position = new Vector3(1784.519f, 3358.805f, 40.041f),
					_backup_heading = 29.059f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1742.480f, 3804.384f, 35.118f),
					_ped_heading = 224.021f,
					_veh_position = new Vector3(1752.468f, 3805.408f, 33.939f),
					_veh_heading = 299.795f,
					_veh_color1 = Color.Yellow,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(1718.558f, 3762.986f, 33.841f),
					_police_heading = 32.576f,
				    _backup_position = new Vector3(2235.515f, 3716.412f, 37.284f),
					_backup_heading = 114.705f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1499.243f, 3702.761f, 39.059f),
					_ped_heading = 72.396f,
					_veh_position = new Vector3(1506.651f, 3686.636f, 34.192f),
					_veh_heading = 263.186f,
					_veh_color1 = Color.Yellow,
					_veh_color2 = Color.White,
					_police_position = new Vector3(1405.660f, 3681.580f, 33.410f),
					_police_heading = 289.926f,
				    _backup_position = new Vector3(415.253f, 3512.842f, 34.121f),
					_backup_heading = 2.679f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1374.029f, 4380.185f, 44.516f),
					_ped_heading = 178.203f,
					_veh_position = new Vector3(1369.430f, 4383.132f, 44.101f),
					_veh_heading = 11.276f,
					_veh_color1 = Color.Red,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(1432.743f, 4467.259f, 49.428f),
					_police_heading = 164.555f,
				    _backup_position = new Vector3(2389.542f, 4660.637f, 36.141f),
					_backup_heading = 43.072f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1724.990f, 4642.132f, 43.876f),
					_ped_heading = 124.081f,
					_veh_position = new Vector3(1735.852f, 4636.287f, 42.963f),
					_veh_heading = 297.866f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(1690.068f, 4692.890f, 42.419f),
					_police_heading = 179.883f,
				    _backup_position = new Vector3(2393.643f, 5174.267f, 49.678f),
					_backup_heading = 8.148f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(2728.885f, 4280.826f, 48.961f),
					_ped_heading = 82.084f,
					_veh_position = new Vector3(2737.693f, 4273.234f, 48.186f),
					_veh_heading = 284.032f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(2659.912f, 4334.656f, 44.664f),
					_police_heading = 308.883f,
				    _backup_position = new Vector3(1986.639f, 3674.031f, 32.947f),
					_backup_heading = 300.842f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 2,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(2016.380f, 4987.091f, 42.098f),
					_ped_heading = 135.415f,
					_veh_position = new Vector3(2010.520f, 4993.794f, 40.884f),
					_veh_heading = 341.740f,
					_veh_color1 = Color.Green,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(2074.206f, 4995.856f, 40.462f),
					_police_heading = 66.490f,
				    _backup_position = new Vector3(2742.768f, 5024.875f, 38.314f),
					_backup_heading = 8.594f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(1522.557f, 6329.463f, 24.607f),
					_ped_heading = 1.239f,
					_veh_position = new Vector3(1539.947f, 6336.328f, 23.623f),
					_veh_heading = 237.881f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(1476.681f, 6425.723f, 21.382f),
					_police_heading = 218.217f,
				    _backup_position = new Vector3(1983.817f, 6265.395f, 45.182f),
					_backup_heading = 29.880f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-379.724f, 6253.506f, 31.851f),
					_ped_heading = 336.772f,
					_veh_position = new Vector3(-380.853f, 6262.605f, 30.803f),
					_veh_heading = 203.462f,
					_veh_color1 = Color.Green,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-404.264f, 6246.519f, 30.230f),
					_police_heading = 355.568f,
				    _backup_position = new Vector3(-733.629f, 5753.326f, 18.296f),
					_backup_heading = 334.077f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(422.795f, 6479.252f, 28.813f),
					_ped_heading = 60.295f,
					_veh_position = new Vector3(427.246f, 6475.650f, 28.341f),
					_veh_heading = 278.809f,
					_veh_color1 = Color.Blue,
					_veh_color2 = Color.Yellow,
					_police_position = new Vector3(422.411f, 6539.682f, 27.270f),
					_police_heading = 168.188f,
				    _backup_position = new Vector3(-299.096f, 6069.491f, 30.575f),
					_backup_heading = 315.714f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-59.678f, 6450.160f, 31.492f),
					_ped_heading = 58.779f,
					_veh_position = new Vector3(-61.727f, 6443.690f, 30.851f),
					_veh_heading = 227.803f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Blue,
					_police_position = new Vector3(-37.992f, 6509.096f, 30.803f),
					_police_heading = 148.790f,
				    _backup_position = new Vector3(1609.133f, 6428.814f, 25.576f),
					_backup_heading = 70.097f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-302.508f, 6327.479f, 32.887f),
					_ped_heading = 37.731f,
					_veh_position = new Vector3(-294.632f, 6338.443f, 31.647f),
					_veh_heading = 230.171f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.White,
					_police_position = new Vector3(-347.709f, 6311.189f, 29.222f),
					_police_heading = 312.281f,
				    _backup_position = new Vector3(-881.312f, 5424.117f, 34.977f),
					_backup_heading = 286.099f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(35.287f, 6662.094f, 32.190f),
					_ped_heading = 172.783f,
					_veh_position = new Vector3(22.716f, 6664.468f, 30.925f),
					_veh_heading = 345.972f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(73.178f, 6619.002f, 30.812f),
					_police_heading = 44.032f,
				    _backup_position = new Vector3(-645.335f, 5568.782f, 38.209f),
					_backup_heading = 303.302f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-233.113f, 6450.653f, 31.198f),
					_ped_heading = 48.782f,
					_veh_position = new Vector3(-233.065f, 6441.617f, 30.558f),
					_veh_heading = 50.759f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(-190.995f, 6464.768f, 29.993f),
					_police_heading = 144.830f,
				    _backup_position = new Vector3(1401.058f, 6508.332f, 18.879f),
					_backup_heading = 98.639f,
					_backup_veh_model = "SHERIFF",
					_backup_ped_model = "s_m_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 3,
					_callouttype = Globals.CalloutType._Default,
					_ped_position = new Vector3(-480.839f, 6266.175f, 13.635f),
					_ped_heading = 145.745f,
					_veh_position = new Vector3(-485.072f, 6262.172f, 12.206f),
					_veh_heading = 250.853f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(-527.837f, 6210.081f, 7.065f),
					_police_heading = 349.938f,
				    _backup_position = new Vector3(429.475f, 6659.032f, 18.933f),
					_backup_heading = 217.865f,
					_backup_veh_model = "SHERIFF2",
					_backup_ped_model = "s_f_y_sheriff_01",
					_searcharea = new Vector3(0f,0f,0f),
					_areaname = "none",
					_audioarea = "none"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-856.620f, -1469.388f, 1.634f),
					_ped_heading = 317.483f,
					_veh_position = new Vector3(-861.194f, -1468.570f, 0.306f),
					_veh_heading = 109.313f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Red,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-833.224f, -1412.419f, 0.0f),
					_areaname = "Puerto del Sol Marina",
					_audioarea = "AREA_PUERTO_DEL_SOL_01"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-736.532f, -1387.271f, 1.595f),
					_ped_heading = 79.7453f,
					_veh_position = new Vector3(-735.627f, -1382.588f, 0.277f),
					_veh_heading = 320.024f,
					_veh_color1 = Color.Blue,
					_veh_color2 = Color.Yellow,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-833.224f, -1412.419f, 0.0f),
					_areaname = "Puerto del Sol Marina",
					_audioarea = "AREA_PUERTO_DEL_SOL_02"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-718.223f, -1326.099f, 1.596f),
					_ped_heading = 210.671f,
					_veh_position = new Vector3(-723.332f, -1318.624f, 0.284f),
					_veh_heading = 49.792f,
					_veh_color1 = Color.Lime,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-833.224f, -1412.419f, 0.0f),
					_areaname = "Puerto del Sol Marina",
					_audioarea = "AREA_PUERTO_DEL_SOL_03"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-790.977f, -1508.940f, 1.595f),
					_ped_heading = 42.902f,
					_veh_position = new Vector3(-784.065f, -1511.753f, 0.308f),
					_veh_heading = 319.910f,
					_veh_color1 = Color.Red,
					_veh_color2 = Color.Yellow,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-833.224f, -1412.419f, 0.0f),
					_areaname = "Puerto del Sol Marina",
					_audioarea = "AREA_PUERTO_DEL_SOL_04"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-953.205f, -1353.757f, 1.605f),
					_ped_heading = 195.114f,
					_veh_position = new Vector3(-951.675f, -1355.399f, 0.320f),
					_veh_heading = 111.414f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.White,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-833.224f, -1412.419f, 0.0f),
					_areaname = "Puerto del Sol Marina",
					_audioarea = "AREA_PUERTO_DEL_SOL_05"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-1003.789f, -1399.513f, 1.595f),
					_ped_heading = 274.706f,
					_veh_position = new Vector3(-1004.591f, -1409.901f, 0.314f),
					_veh_heading = 199.473f,
					_veh_color1 = Color.Aqua,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-833.224f, -1412.419f, 0.0f),
					_areaname = "Puerto del Sol Marina",
					_audioarea = "AREA_PUERTO_DEL_SOL_06"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-1089.795f, -1086.657f, 2.150f),
					_ped_heading = 175.883f,
					_veh_position = new Vector3(-1084.943f, -1094.751f, -0.145f),
					_veh_heading = 117.145f,
					_veh_color1 = Color.Orange,
					_veh_color2 = Color.Black,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-1022.638f, -1068.662f, -0.236f),
					_areaname = "Vespuccu Canals",
					_audioarea = "AREA_VESPUCCI_CANALS_01"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-1032.259f, -1172.816f, 2.159f),
					_ped_heading = 229.644f,
					_veh_position = new Vector3(-1027.486f, -1185.644f, -0.176f),
					_veh_heading = 302.426f,
					_veh_color1 = Color.Purple,
					_veh_color2 = Color.Yellow,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-1022.638f, -1068.662f, -0.236f),
					_areaname = "Vespuccu Canals",
					_audioarea = "AREA_VESPUCCI_CANALS_02"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-920.930f, -1094.763f, 2.150f),
					_ped_heading = 287.920f,
					_veh_position = new Vector3(-909.939f, -1084.670f, -0.169f),
					_veh_heading = 31.767f,
					_veh_color1 = Color.Blue,
					_veh_color2 = Color.Aqua,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-1022.638f, -1068.662f, -0.236f),
					_areaname = "Vespuccu Canals",
					_audioarea = "AREA_VESPUCCI_CANALS_03"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-989.723f, -974.468f, 4.223f),
					_ped_heading = 290.421f,
					_veh_position = new Vector3(-978.789f, -966.813f, -0.200f),
					_veh_heading = 34.309f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.Orange,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-1022.638f, -1068.662f, -0.236f),
					_areaname = "Vespuccu Canals",
					_audioarea = "AREA_VESPUCCI_CANALS_04"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-1074.430f, -939.539f, 2.362f),
					_ped_heading = 148.279f,
					_veh_position = new Vector3(-1067.520f, -958.105f, -0.099f),
					_veh_heading = 118.749f,
					_veh_color1 = Color.White,
					_veh_color2 = Color.IndianRed,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-1022.638f, -1068.662f, -0.236f),
					_areaname = "Vespuccu Canals",
					_audioarea = "AREA_VESPUCCI_CANALS_05"
				});
				
				SuspectLocations.Add(new Globals.SuspectLocation
				{
					_region = 1,
					_callouttype = Globals.CalloutType._Water,
					_ped_position = new Vector3(-1130.453f, -1031.726f, 2.150f),
					_ped_heading = 50.133f,
					_veh_position = new Vector3(-1144.562f, -1020.402f, 0.016f),
					_veh_heading = 124.372f,
					_veh_color1 = Color.Black,
					_veh_color2 = Color.Lime,
					_police_position = new Vector3(0f,0f,0f),
					_police_heading = 0f,
				    _backup_position = new Vector3(0f,0f,0f),
					_backup_heading = 0f,
					_backup_veh_model = "none",
					_backup_ped_model = "none",
					_searcharea = new Vector3(-1022.638f, -1068.662f, -0.236f),
					_areaname = "Vespuccu Canals",
					_audioarea = "AREA_VESPUCCI_CANALS_06"
				});
				
				#endregion Locations

				#region PedModels
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_m_y_vinewood_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_m_y_vinewood_02",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_m_y_vinewood_03",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_m_y_vinewood_04",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_f_y_vinewood_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_f_y_vinewood_02",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_f_y_vinewood_03",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Rich,
					_modelname = "a_f_y_vinewood_04",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "u_m_y_party_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "u_m_m_partytarget",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "a_m_m_eastsa_02",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "a_m_m_soucent_04",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "a_f_y_eastsa_03",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "a_f_y_soucent_03",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "a_f_m_bevhills_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._Normal,
					_modelname = "a_f_m_ktown_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "a_f_m_eastsa_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "a_m_m_hillbilly_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "a_m_m_mexlabor_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "a_m_y_salton_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "s_f_m_sweatshop_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "s_m_m_autoshop_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "g_f_y_families_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				SuspectPeds.Add(new Globals.SuspectPerson
				{
					_type = Globals.HumanType._County,
					_modelname = "s_m_m_trucker_01",
					_animdir = "missmic2@enemy",
					_animname = "smoking_loop",
					_animflag = AnimationFlags.Loop
				});
				#endregion PedModels

				#region VehicleModels
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "REAPER"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "OSIRIS"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "VACCA"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "ZENTORNO"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "BESTIAGTS"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "T20"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "NINEF"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "BANSHEE"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "FMJ"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "PFISTER811"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "PROTOTIPO"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Rich,
					_modelname = "BULLET"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "GAUNTLET"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "SABREGT"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "DOMINATOR"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "VIGERO"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "PHOENIX"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "BUCCANEER"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "TAMPA"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "NIGHTSHADE"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "STALION"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "BLADE"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "DUKES"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Normal,
					_modelname = "CHINO"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "DLOADER"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "RANCHERXL"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "REBEL2"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "SANDKING2"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "BFINJECTION"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "BIFTA"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "MESA"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "GRANGER"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "EMPEROR2"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "RUINER"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "VOODOO2"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._County,
					_modelname = "PICADOR"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Water,
					_modelname = "TROPIC"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Water,
					_modelname = "JETMAX"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Water,
					_modelname = "SQUALO"
				});
				SuspectCars.Add(new Globals.SuspectCar
				{
					_type = Globals.CarType._Water,
					_modelname = "SUNTRAP"
				});
				#endregion PedModels

				#region Dialogs
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Hello. Do you own the vehicle in your driveway?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 1,
					_text = "~r~Suspect:~w~ Yes, officer, I do.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: Okay. Can you tell me where you were about 15 minutes ago?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 3,
					_text = "~r~Suspect:~w~ Am I being detained, officer?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ I'm only asking you where you were. Can you tell me that, or should I come back with a warrant?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 5,
					_text = "~r~Suspect:~w~ Well, what's happening? Is there a problem with my vehicle?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Yes. It matches the description of a vehicle involved in a Hit and Run.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 7,
					_text = "~r~Suspect:~w~ Well, I was home all day. Your source must have a misunderstanding or something.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Can I take a closer look at your vehicle?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 9,
					_text = "~r~Suspect:~w~ Ugh, you got me. I hit the person and drove off, I didn't know what to do. I'm so sorry, don't arrest me please!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay, well I have to take you down to the station. Put your hands where I can see them, please.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 1,
					_counter = 11,
					_text = "~r~Suspect:~w~ Fuck this! I ain't going' back to jail.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Hey there. Is that your vehicle in the driveway?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 1,
					_text = "r~Suspect:~w~ Yes, it is. Is everything okay?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Can you tell me where you were about 15 minutes ago?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 3,
					_text = "~r~Suspect:~w~ Can you tell me what is going on? Do I need a lawyer?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~Your vehicle matches the description of a vehicle involved in a Hit and Run",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 5,
					_text = "~r~Suspect:~w~ Bullshit! I was home all day!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. We can sort this out at the station. Currently, you are being detained and will have to come down to the station with me.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 7,
					_text = "~r~Suspect:~w~ No! I'm not doing that!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Well unfortunately, at this point, you have no choice.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 9,
					_text = "~r~Suspect:~w~ Stupid cops, stupid justice system. Go screw yourself!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. Go ahead and put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 2,
					_counter = 11,
					_text = "~r~Suspect:~w~ Screw this! Try to catch me pig!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Is that your vehicle in the driveway?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 1,
					_text = "~r~Suspect:~w~ Hello Officer. Yes, it is.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: Any reason for so much vehicle damage?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 3,
					_text = "~r~Suspect:~w~ I got in an accident a few days ago. It's in the process of being fixed, officer.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Oh, okay. Did you happen to get in an accident today?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 5,
					_text = "~r~Suspect:~w~ No, I wasn't involved in an accident today. Why do you ask?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ This vehicle matches the description of a vehicle involved in a hit and run. And by the way you're talking, I can tell you are nervous. Want to come clean?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 7,
					_text = "~r~Suspect:~w~ I am clean. I didn't get in an accident. Please leave now. You aren't welcomed at my home.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ The charge isn't that severe. If you come clean, you might get a lesser sentence. Last chance, do you want to come clean?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 9,
					_text = "~r~Suspect:~w~ Ugh, fine! The person got in my way. I couldn't stop in time. It wasn't my fault, officer, it was theirs...",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. We can sort it out at the station. Right now you are being detained. Put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 3,
					_counter = 11,
					_text = "~r~Suspect:~w~ I'm not going back to jail! Stupid pig!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Hello. Do have a minute? I would like to ask you some questions.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 1,
					_text = "~r~Suspect:~w~ No, sorry. I'm in a hurry!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: I am assuming you know why I am here. Can you tell me why you have so much front end damage on your vehicle?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 3,
					_text = "~r~Suspect:~w~ As I said, I don't have time! Please leave!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ I am not leaving until you answer my question. Why is there so much damage to your vehicle?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 5,
					_text = "~r~Suspect:~w~ Because some bastard hit me, and now you are going to arrest me, when they caused it!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Well due to you admitting to me you were just involved in a hit and run, you will need to come down to the station for further questioning.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 7,
					_text = "~r~Suspect:~w~ No, I am staying right here.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ No, you aren't. Please, don't make me have to use force. Put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 9,
					_text = "~r~Suspect:~w~ This isn't fair!.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Last chance. Put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 4,
					_counter = 11,
					_text = "~r~Suspect:~w~ No, this isn't fair I said!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Do me a favor and keep your hands where I can see them. Is that your vehicle parked over there?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 1,
					_text = "~r~Suspect:~w~ ..Yes officer, it is. Is everything alright?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: Can you tell me where you were approximately 20 minutes ago?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 3,
					_text = "~r~Suspect:~w~ Can you tell me why you're acting like a dick?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. Would you like to tell me where you were, or should I take you down to the station until our investigation is over?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 5,
					_text = "~r~Suspect:~w~ I was cruising around! I was enjoying my day off and just got done pulling in. What the hell is going on?!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Did you happen to hit someone while you were out?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 7,
					_text = "~r~Suspect:~w~ What?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Don't act like nothing has happened. Last chance, did you hit a person?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 9,
					_text = "~r~Suspect:~w~ Maybe. I would like to talk to my lawyer.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ You can, down at the station. Right now, you are under arrest for a Hit and Run. Keep your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Default,
					_dialogid = 5,
					_counter = 11,
					_text = "~r~Suspect:~w~ Fuck you, bitch. Catch me if you can!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Hello. Do you own the boat anchored over there?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 1,
					_text = "~r~Suspect:~w~ Yes, officer, I do.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: Okay. Can you tell me where you were about 15 minutes ago?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 3,
					_text = "~r~Suspect:~w~ Am I being detained, officer?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ I'm only asking you where you were. Can you tell me that, or should I come back with a warrant?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 5,
					_text = "~r~Suspect:~w~ Well, whats happening? Is there a problem with my boat?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Yes. It matches the description of a watercraft involved in a Hit and Run.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 7,
					_text = "~r~Suspect:~w~ Well, I was home all day. Your source must have a misunderstanding or something.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Can I take a closer look at your boat?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 9,
					_text = "~r~Suspect:~w~ Ugh, you got me. I hit the person and sped off, I didn't know what to do. I'm so sorry, don't arrest me please!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay, well I have to take you down to the station. Put your hands where I can see them, please.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 6,
					_counter = 11,
					_text = "~r~Suspect:~w~ Fuck this! I ain't going back to jail.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Hey there. Is that your boat anchored over there?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 1,
					_text = "~r~Suspect:~w~ Yes, it is. Is everything okay?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: Can you tell me where you were about 15 minutes ago?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 3,
					_text = "~r~Suspect:~w~ Can you tell me what is going on? Do I need a lawyer?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~Your boat matches the description of a watercraft involved in a Hit and Run",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 5,
					_text = "~r~Suspect:~w~ Bullshit! I was home all day!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. We can sort this out at the station. Currently, you are being detained, and will have to come down to the station with me.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 7,
					_text = "~r~Suspect:~w~ No! I am not doing that!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Well unfortunately, at this point, you have no choice.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 9,
					_text = "~r~Suspect:~w~ Stupid cops, stupid justice system. Go screw yourself.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. Go ahead and put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 7,
					_counter = 11,
					_text = "~r~Suspect:~w~ Screw this. Try to catch me pig!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Is that your boat anchored over there?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 1,
					_text = "~r~Suspect:~w~ Hello Officer. Yes, it is.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: Any reason for so much damage to your boat?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 3,
					_text = "~r~Suspect:~w~ I got in an accident a few days ago. It's in the process of being fixed, officer.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Oh, okay. Did you happen to get in an accident today?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 5,
					_text = "~r~Suspect:~w~ No, I wasn't involved in an accident today. Why do you ask?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Your boat matches the description of a watercraft involved in a hit and run. And by the way you're talking, I can tell you are nervous. Want to come clean?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 7,
					_text = "~r~Suspect:~w~ I am clean. I didn't get in an accident. Please leave now. I don't want to answer any more questions.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ The charge isn't that severe. If you come clean, you might get a lesser sentence. Last chance, do you want to come clean?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 9,
					_text = "~r~Suspect:~w~ Ugh, fine! The person got in my way. I couldn't stop in time. It wast my fault, officer, it was theirs...",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. We can sort it out at the station. Right now you are being detained. Put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 8,
					_counter = 11,
					_text = "~r~Suspect:~w~ I'm not going back to jail! Stupid pig!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Hello. Do have a minute? I would like to ask you some questions.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 1,
					_text = "~r~Suspect:~w~ No, sorry. I'm in a hurry!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: I am assuming you know why I am here. Can you tell me why you have so much front end damage on your boat?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 3,
					_text = "~r~Suspect:~w~ As I said, I don't have time! Please leave!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ I am not leaving until you answer my question. Why is there so much damage to your boat?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 5,
					_text = "~r~Suspect:~w~ Because some bastard got in front of me, and now you are going to arrest me, when they caused it!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Well due to you admitting to me you were just involved in a hit and run, you will need to come down to the station for further questioning.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 7,
					_text = "~r~Suspect:~w~ No, I am staying right here.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ No, you aren't. Please, don't make me have to use force. Put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 9,
					_text = "~r~Suspect:~w~ This isn't fair!.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Last chance. Put your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 9,
					_counter = 11,
					_text = "~r~Suspect:~w~ No, this isn't fair I said!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 0,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Do me a favor and keep your hands where I can see them. Is that your boat over there?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 1,
					_text = "~r~Suspect:~w~ ..Yes officer, it is. Is everything alright?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 2,
					_text = "~b~" + GameHandler.ini_username + ":~w~: Can you tell me where you were approximately 20 minutes ago?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 3,
					_text = "~r~Suspect:~w~ Can you tell me why you're acting like a dick?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 4,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Okay. Would you like to tell me where you were, or should I take you down to the station until our investigation is over?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 5,
					_text = "~r~Suspect:~w~ I was cruising around! I was enjoying my day off and just got done pulling in. What the hell is going on?!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 6,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Did you happen to hit someone while you were out?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 7,
					_text = "~r~Suspect:~w~ What?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 8,
					_text = "~b~" + GameHandler.ini_username + ":~w~ Don't act like nothing has happened. Last chance, did you hit a person?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 9,
					_text = "~r~Suspect:~w~ Maybe. I would like to talk to my lawyer.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 10,
					_text = "~b~" + GameHandler.ini_username + ":~w~ You can, down at the station. Right now, you are under arrest for a Hit and Run. Keep your hands where I can see them.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._Water,
					_dialogid = 10,
					_counter = 11,
					_text = "~r~Suspect:~w~ Fuck you, bitch. Catch me if you can!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_dialogid = 11,
					_counter = 0,
					_text = "Hey partner, looks like you found the car I was looking for.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_dialogid = 11,
					_counter = 1,
					_text = "Hi, yeah, i was doing my patrol round when i saw it there.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_dialogid = 11,
					_counter = 2,
					_text = "Anything that could lead us to a suspect?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_dialogid = 11,
					_counter = 3,
					_text = "Sorry, no. There was nobody on the way up here and nothing in the car.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_dialogid = 11,
					_counter = 4,
					_text = "Damn. Well you can leave i will take car about the rest.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_dialogid = 11,
					_counter = 5,
					_text = "Ok thanks, see ya.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 0,
					_text = "Hey Partner, seems the BOLO brought success.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 1,
					_text = "Hi, yes, i stopped the car because of its damage to the front wheel, and then saw the APB.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 2,
					_text = "Yeah, well i will take over from here ok ?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 3,
					_text = "Sure, i will back you up from here.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 4,
					_text = "Thanks, then lets go",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 5,
					_text = "Please step out of the vehicle.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 6,
					_text = "No, what did i do wrong? Why did you stop me?",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 7,
					_text = "Your car is seriously damaged. You can't continue. Please step out!",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 8,
					_text = "The Vehicle you drive has been stolen and was involed in a Hit and Run. You are under arrest. Show me you hands.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 9,
					_text = "I would like to talk to my lawyer.",
				});
				SuspectDialogs.Add(new Globals.SuspectDialog
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_dialogid = 12,
					_counter = 10,
					_text = "Seeya bitches�",
				});
				#endregion Dialogs

				#region Positions
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 1,
					_type =  Globals.PositionType.CAR_ABANDON,
					_heading = 339.12f,
					_position = new Vector3(824.21f, 1174.70f, 322.80f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 1,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 21.67f,
					_position = new Vector3(811.89f, 1165.76f, 320.86f),
					_modelname = "PRANGER",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 1,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 314.15f,
					_position = new Vector3(822.13f, 1170.82f, 322.74f),
					_modelname = "s_f_y_ranger_01",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 2,
					_type =  Globals.PositionType.CAR_SUSPECT,
					_heading = 25.86f,
					_position = new Vector3(-19.13f, 1467.14f, 276.01f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 2,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 27.37f,
					_position = new Vector3(-14.95f, 1460.64f, 275.73f),
					_modelname = "POLICE3",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 2,
					_type =  Globals.PositionType.PED_SUSPECT,
					_heading = 25.86f,
					_position = new Vector3(-19.13f, 1467.14f, 276.01f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 2,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 147.87f,
					_position = new Vector3(-13.81f, 1456.97f, 275.97f),
					_modelname = "s_f_y_cop_01",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 2,
					_type =  Globals.PositionType.PED_WAIT,
					_heading = 30.69f,
					_position = new Vector3(-16.12f, 1460.12f, 276.04f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 3,
					_type =  Globals.PositionType.CAR_ABANDON,
					_heading = 356.00f,
					_position = new Vector3(-377.45f, 1598.63f, 332.15f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 3,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 87.42f,
					_position = new Vector3(-378.61f, 1570.95f, 349.76f),
					_modelname = "PRANGER",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 3,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 352.86f,
					_position = new Vector3(-378.61f, 1574.93f, 348.78f),
					_modelname = "s_m_y_ranger_01",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 4,
					_type =  Globals.PositionType.CAR_SUSPECT,
					_heading = 87.38f,
					_position = new Vector3(-484.55f, 135.82f, 63.39f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 4,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 88.13f,
					_position = new Vector3(-475.76f, 135.54f, 63.47f),
					_modelname = "POLICE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 4,
					_type =  Globals.PositionType.PED_SUSPECT,
					_heading = 87.38f,
					_position = new Vector3(-484.55f, 135.82f, 63.39f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 4,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 240.70f,
					_position = new Vector3(-472.76f, 134.30f, 63.95f),
					_modelname = "s_m_y_cop_01",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 4,
					_type =  Globals.PositionType.PED_WAIT,
					_heading = 86.72f,
					_position = new Vector3(-475.92f, 134.23f, 63.90f),
					_modelname = "NONE",
					_region = 1,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 5,
					_type =  Globals.PositionType.CAR_ABANDON,
					_heading = 132.03f,
					_position = new Vector3(705.39f, 2551.40f, 71.87f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 5,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 94.02f,
					_position = new Vector3(723.84f, 2562.07f, 74.16f),
					_modelname = "SHERIFF2",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 5,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 104.43f,
					_position = new Vector3(714.44f, 2555.80f, 73.09f),
					_modelname = "s_m_y_sheriff_01",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 6,
					_type =  Globals.PositionType.CAR_SUSPECT,
					_heading = 271.77f,
					_position = new Vector3(847.89f, 3526.71f, 33.77f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 6,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 260.66f,
					_position = new Vector3(840.05f, 3525.83f, 33.59f),
					_modelname = "SHERIFF",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 6,
					_type =  Globals.PositionType.PED_SUSPECT,
					_heading = 271.77f,
					_position = new Vector3(847.89f, 3526.71f, 33.77f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 6,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 76.16f,
					_position = new Vector3(836.97f, 3527.23f, 34.07f),
					_modelname = "s_f_y_sheriff_01",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 6,
					_type =  Globals.PositionType.PED_WAIT,
					_heading = 266.99f,
					_position = new Vector3(840.36f, 3527.13f, 34.04f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 7,
					_type =  Globals.PositionType.CAR_ABANDON,
					_heading = 317.65f,
					_position = new Vector3(2683.32f, 4880.10f, 32.33f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 7,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 3.82f,
					_position = new Vector3(2684.93f, 4860.31f, 32.43f),
					_modelname = "SHERIFF",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 7,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 2.84f,
					_position = new Vector3(2678.73f, 4872.27f, 32.34f),
					_modelname = "s_m_y_sheriff_01",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 8,
					_type =  Globals.PositionType.CAR_SUSPECT,
					_heading = 10.65f,
					_position = new Vector3(2938.55f, 4014.11f, 51.01f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 8,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 25.48f,
					_position = new Vector3(2939.82f, 4006.98f, 25.48f),
					_modelname = "POLICE4",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 8,
					_type =  Globals.PositionType.PED_SUSPECT,
					_heading = 10.65f,
					_position = new Vector3(2938.55f, 4014.11f, 51.01f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 8,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 350.82f,
					_position = new Vector3(2938.59f, 4006.51f, 51.39f),
					_modelname = "s_m_y_sheriff_01",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 8,
					_type =  Globals.PositionType.PED_WAIT,
					_heading = 170.31f,
					_position = new Vector3(2941.35f, 4003.19f, 51.39f),
					_modelname = "NONE",
					_region = 2,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 9,
					_type =  Globals.PositionType.CAR_ABANDON,
					_heading = 226.68f,
					_position = new Vector3(1553.97f, 6335.77f, 23.59f),
					_modelname = "NONE",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 9,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 61.67f,
					_position = new Vector3(1539.98f, 6346.65f, 23.52f),
					_modelname = "SHERIFF2",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 9,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 233.73f,
					_position = new Vector3(1547.26f, 6340.16f, 23.99f),
					_modelname = "s_f_y_sheriff_01",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 10,
					_type =  Globals.PositionType.CAR_SUSPECT,
					_heading = 56.35f,
					_position = new Vector3(2124.87f, 6093.23f, 50.95f),
					_modelname = "NONE",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 10,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 41.83f,
					_position = new Vector3(2131.15f, 6088.93f, 51.00f),
					_modelname = "SHERIFF2",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 10,
					_type =  Globals.PositionType.PED_SUSPECT,
					_heading = 56.35f,
					_position = new Vector3(2124.87f, 6093.23f, 50.95f),
					_modelname = "NONE",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 10,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 212.96f,
					_position = new Vector3(2133.62f, 6086.68f, 51.44f),
					_modelname = "s_f_y_sheriff_01",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 10,
					_type =  Globals.PositionType.PED_WAIT,
					_heading = 36.70f,
					_position = new Vector3(2129.68f, 6088.43f, 51.38f),
					_modelname = "NONE",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 11,
					_type =  Globals.PositionType.CAR_ABANDON,
					_heading = 276.09f,
					_position = new Vector3(-428.65f, 5440.29f, 73.00f),
					_modelname = "NONE",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 11,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 134.03f,
					_position = new Vector3(-460.66f, 5442.18f, 73.90f),
					_modelname = "PRANGER",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._NoSuspect,
					_id = 11,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 266.27f,
					_position = new Vector3(-453.81f, 5439.04f, 71.33f),
					_modelname = "s_m_y_ranger_01",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 12,
					_type =  Globals.PositionType.CAR_SUSPECT,
					_heading = 148.99f,
					_position = new Vector3(-2311.99f, 4190.37f, 39.25f),
					_modelname = "NONE",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 12,
					_type =  Globals.PositionType.CAR_UNIT,
					_heading = 161.98f,
					_position = new Vector3(-2308.31f, 4195.48f, 39.45f),
					_modelname = "SHERIFF",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 12,
					_type =  Globals.PositionType.PED_SUSPECT,
					_heading = 148.99f,
					_position = new Vector3(-2311.99f, 4190.37f, 39.25f),
					_modelname = "NONE",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 12,
					_type =  Globals.PositionType.PED_UNIT,
					_heading = 302.93f,
					_position = new Vector3(-2306.14f, 4198.79f, 40.19f),
					_modelname = "s_m_y_sheriff_01",
					_region = 3,
				});
				SuspectPositions.Add(new Globals.SuspectPositions
				{
					_callouttype = Globals.CalloutType._TrafficStop,
					_id = 12,
					_type =  Globals.PositionType.PED_WAIT,
					_heading = 136.78f,
					_position = new Vector3(-2307.06f, 4194.98f, 39.96f),
					_modelname = "NONE",
					_region = 3,
				});
				#endregion Positions

			}
			catch (Exception ex)
            {
                Game.DisplayNotification("~r~LPCallouts~w~ Content Error: ~y~SuspectDefintions~w~ could not be generated");
                Game.LogTrivial(ex.ToString());
            }
	}
	}
}
