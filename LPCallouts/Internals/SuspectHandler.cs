using System;
using System.Collections.Generic;
using System.Linq;
//LSPDFR
using Rage;
using Rage.Native;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Engine.Scripting.Entities;
//LPC
using LPCallouts.Externals;
//External
using ComputerPlus;

namespace LPCallouts.Internals
{
    public class SuspectHandler
    {
        public static int OnScreenTime = 8000;

        public static void Conversation(Ped ped_suspect, Blip blip_suspect, ref LHandle pursuit, Globals.SuspectDialog dialog, bool pursuitcreated, ref int loop, ref bool talking)
        {
            if (Game.LocalPlayer.Character.DistanceTo(ped_suspect.Position) < 5f && Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                int i = loop;
                string Dialog = Suspects.SuspectDialogs.First(t => t._dialogid == dialog._dialogid && t._counter == i)._text;

                switch (loop)
                {
                    case 0:
                        talking = true;
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 1;
                        break;
                    case 1:
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 2;
                        break;
                    case 2:
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 3;
                        break;
                    case 3:
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 4;
                        break;
                    case 4:
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 5;
                        break;
                    case 5:
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 6;
                        break;
                    case 6:
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 7;
                        break;
                    case 7:
                        Game.DisplaySubtitle(Dialog, OnScreenTime);
                        loop = 8;
                        break;
                    case 8:
                        Game.DisplaySubtitle(Dialog, GameHandler._displaytime);
                        loop = 9;
                        break;
                    case 9:
                        talking = false;
                        Array _tmpary = Enum.GetValues(typeof(Globals.PursuitEnd));
                        Globals.PursuitEnd suspectending = (Globals.PursuitEnd)_tmpary.GetValue(Main.LPCRandom.Next(_tmpary.Length));

                        if (pursuitcreated == false)
                        {
                            switch (suspectending)
                            {
                                case Globals.PursuitEnd.PURSUIT:
                                    Game.DisplaySubtitle(Dialog, GameHandler._displaytime);
                                    if (!pursuitcreated && Game.LocalPlayer.Character.DistanceTo(ped_suspect.Position) < 30f)
                                    {
                                        blip_suspect.IsFriendly = false;
                                        pursuit = Functions.CreatePursuit();
                                        Functions.AddPedToPursuit(pursuit, ped_suspect);
                                        Functions.SetPursuitIsActiveForPlayer(pursuit, true);
                                        pursuitcreated = true;
                                        loop = 10;
                                    }
                                    break;
                                case Globals.PursuitEnd.GIVEUP:
                                default:
                                    Game.DisplaySubtitle(Dialog, GameHandler._displaytime);
                                    GameFiber.Wait(3000);
                                    Game.DisplaySubtitle(Dialog, GameHandler._displaytime);
                                    ped_suspect.Tasks.PlayAnimation("anim@move_m@prisoner_cuffed", "idle_intro", 1f, AnimationFlags.StayInEndFrame);
                                    blip_suspect.IsFriendly = false;
                                    GameFiber.Wait(3000);
                                    ped_suspect.Tasks.PlayAnimation("anim@move_m@prisoner_cuffed", "idle", 1f, AnimationFlags.Loop);
                                    Game.DisplaySubtitle("Arrest the Suspect", 4000);
                                    loop = 10;
                                    break;
                            }
                        }
                        break;
                }
            }
        }

        public static void ConversationTrafficStop(ref int Loop, int DialogID, Ped PedUnit, Ped Suspect, Vehicle CarUnit, Vehicle SuspectCar, ref Blip Marker, List<Blip> BlipList, ref bool CreatePursuit, ref LHandle Pursuit)
        {
            if (Rage.Game.IsKeyDown(GameHandler.ini_action))
            {
                int i = Loop;
                bool _active = CreatePursuit;
                LHandle _pursuit = Pursuit;

                string Dialog = Suspects.SuspectDialogs.First(t => t._callouttype == Globals.CalloutType._TrafficStop && t._dialogid == DialogID && t._counter == i)._text;

                switch (Loop)
                {
                    case 5:
                        GameHandler.PlayerChat(1, Dialog);
                        Loop = 6;
                        break;
                    case 6:
                        GameHandler.PlayerChat(9, Dialog);
                        Loop = 7;
                        break;
                    case 7:
                        GameHandler.PlayerChat(1, Dialog);
                        Loop = 8;
                        break;
                    case 8:
                        Array _tmpary = Enum.GetValues(typeof(Globals.PursuitEnd));
                        Globals.PursuitEnd suspectending = (Globals.PursuitEnd)_tmpary.GetValue(Main.LPCRandom.Next(_tmpary.Length));
                        switch (suspectending)
                        {
                            case Globals.PursuitEnd.GIVEUP:
                                GameHandler.PlayerChat(1, Dialog);
                                Loop = 9;
                                break;
                            case Globals.PursuitEnd.PURSUIT:
                                GameHandler.PlayerChat(9, Suspects.SuspectDialogs.First(t => t._callouttype == Globals.CalloutType._TrafficStop && t._dialogid == DialogID && t._counter == 10)._text);
                                GameHandler.RemoveBlip(Marker, BlipList);

                                GameFiber.StartNew(delegate
                                {
                                    SuspectCar.IsEngineOn = true;
                                    PedUnit.Tasks.ClearImmediately();
                                    NativeFunction.CallByName<ulong>("TASK_ENTER_VEHICLE", PedUnit, CarUnit, 1000, -1, 2.0f, 1, 0);
                                    GameFiber.Wait(500);
                                    PedUnit.IsPersistent = false;
                                    CarUnit.IsPersistent = false;
                                    _pursuit = Functions.CreatePursuit();
                                    Suspect.Tasks.CruiseWithVehicle(SuspectCar, 30f, VehicleDrivingFlags.Emergency);
                                    Functions.AddPedToPursuit(_pursuit, Suspect);
                                    Functions.SetPursuitIsActiveForPlayer(_pursuit, true);
                                    Functions.AddCopToPursuit(_pursuit, PedUnit);
                                    GameFiber.Wait(1500);
                                    CarUnit.IsSirenSilent = false;
                                    _active = true;
                                }, FiberHandler._fiber_request);
                                Loop = 10;
                                break;
                        }
                        break;
                    case 9:
                        GameHandler.PlayerChat(1, Dialog);
                        Marker.IsFriendly = false;
                        GameFiber.StartNew(delegate
                        {
                            NativeFunction.CallByName<ulong>("TASK_LEAVE_VEHICLE", Suspect, SuspectCar, 64);
                            GameFiber.Wait(4000);
                            Suspect.Tasks.PlayAnimation("anim@move_m@prisoner_cuffed", "idle_intro", 1f, AnimationFlags.StayInEndFrame);
                            GameFiber.Wait(3000);
                            Suspect.Tasks.PlayAnimation("anim@move_m@prisoner_cuffed", "idle", 1f, AnimationFlags.Loop);
                            NativeFunction.CallByName<ulong>("TASK_ENTER_VEHICLE", PedUnit, CarUnit, 1000, -1, 1.0f, 1, 0);
                            CarUnit.IsSirenOn = false;
                            PedUnit.IsPersistent = false;
                            CarUnit.IsPersistent = false;
                            CarUnit.Dismiss();
                            PedUnit.Dismiss();
                            Game.DisplaySubtitle("Arrest the Suspect", 4000);
                        }, FiberHandler._fiber_request);
                        Loop = 10;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void GetLocation(Guid CalloutID, bool CompterPlus, string CarType, string LicencePlate, Vehicle Car, Ped Person, Ped Witness, Blip Marker, Vector3 Position, string Name)
        {
            string Audio = LicencePlate.Aggregate(string.Empty, (c, i) => c + i + ' ');

            GameFiber.StartNew(delegate
            {
                GameFiber.Wait(2000);
                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ Dispatch, can i get a 10-28");
                GameFiber.Wait(3000);
                GameHandler.DispatchMessage("10-4, go ahead.");
                GameFiber.Wait(3000);
                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ The vehicle is going to be a ~y~" + CarType + "~w~, license plate ~y~" + LicencePlate);
                Functions.PlayScannerAudio("TARGET_VEHICLE_LICENCE_PLATE " + Audio + "REPORT_RESPONSE_COPY_02");
                GameHandler.DispatchMessage("10-12");
                GameFiber.Wait(5000);
                uint _streethash = World.GetStreetHash(Position);
                string _street = World.GetStreetName(_streethash);

                //Computer+
                if (CompterPlus)
                {
                    Persona _witness = Functions.GetPersonaForPed(Witness);
                    CPlusFunctions.AddUpdateToCallout(CalloutID, "Witness Name: " + _witness.FullName);
                    CPlusFunctions.AddUpdateToCallout(CalloutID, "Car model that caused the accident: " + Car.Model.Name);
                    CPlusFunctions.AddUpdateToCallout(CalloutID, "Accident was 10-57, responding to " + _street);
                    CPlusFunctions.AddPedToCallout(CalloutID, Person);
                    CPlusFunctions.AddVehicleToCallout(CalloutID, Car);
                    CPlusFunctions.UpdateCalloutStatus(CalloutID, (int)ECallStatus.Unit_Responding);
                }
                GameHandler.DispatchMessage("I have a vehicle match. The owner is ~y~" + Name + "~w~, and lives at ~y~" + _street);
                GameFiber.Wait(3000);
                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ 10-4. Show me 10-76 Code 2.");
                GameFiber.Wait(3000);
                GameHandler.DispatchMessage("10-4. Showing you 10-76. Respond to ~y~" + _street + "~w~ Code 2.");
                Marker.Alpha = 1.0f;
                Marker.EnableRoute(System.Drawing.Color.Yellow);

                GameFiber.Yield();
            }, "Suspect Location Data");
        }

        public static void GetLocation(Guid CalloutID, bool CompterPlus, string CarType, string LicencePlate, Vehicle Car, Ped Witness)
        {
            string Audio = LicencePlate.Aggregate(string.Empty, (c, i) => c + i + ' ');

            GameFiber.StartNew(delegate
            {
                GameFiber.Wait(2000);
                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ Dispatch, can i get a 10-28");
                GameFiber.Wait(3000);
                GameHandler.DispatchMessage("10-4, go ahead.");
                GameFiber.Wait(3000);
                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ The vehicle is going to be a ~y~" + CarType + "~w~, license plate ~y~" + LicencePlate);
                Functions.PlayScannerAudio("TARGET_VEHICLE_LICENCE_PLATE " + Audio + "REPORT_RESPONSE_COPY_02");
                GameHandler.DispatchMessage("10-12");
                GameFiber.Wait(7000);

                //Computer+
                if (CompterPlus)
                {
                    Persona _witness = Functions.GetPersonaForPed(Witness);
                    CPlusFunctions.AddUpdateToCallout(CalloutID, "Witness Name: " + _witness.FullName);
                    CPlusFunctions.AddUpdateToCallout(CalloutID, "Car model that caused the accident: " + Car.Model.Name);
                    CPlusFunctions.AddUpdateToCallout(CalloutID, "Accident was 10-57");
                    CPlusFunctions.AddVehicleToCallout(CalloutID, Car);
                    CPlusFunctions.UpdateCalloutStatus(CalloutID, (int)ECallStatus.Unit_Responding);
                }
                GameHandler.DispatchMessage("Be Advised! Vehicle returned as: ~r~ STOLEN");
                GameFiber.Wait(2000);
                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ 10-4. Can i get a BOLO on that Vehicle?");
                GameFiber.Wait(3000);
                GameHandler.DispatchMessage("10-4. Informing all Units.");
                GameFiber.Wait(3000);
                Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ I will search the surrounding area.");
                GameFiber.Wait(2000);
                GameHandler.DispatchMessage("10-4.");
                Game.DisplaySubtitle("Search the surrounding area for the suspect vehicle");
                GameFiber.Yield();
            }, "Suspect Location Data");
        }

        public static void GetLocation(Guid CalloutID, bool CompterPlus, string CarType, string LicencePlate, Ped Witness, Blip Marker1, Blip Marker2, Blip Marker3, string Street1, string Street2, string Street3)
        {
            string Audio = LicencePlate.Aggregate(string.Empty, (c, i) => c + i + ' ');

            GameFiber.StartNew(delegate
                {
                    GameFiber.Wait(2000);
                    Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ Dispatch, i need a 10-28 on a partial plate.");
                    GameFiber.Wait(3000);
                    GameHandler.DispatchMessage("10-4, go ahead.");
                    GameFiber.Wait(3000);
                    Game.DisplayNotification("~b~" + GameHandler.ini_username + ":~w~ The vehicle is going to be a ~y~" + CarType + "~w~, license plate contains ~y~" + LicencePlate);
                    GameFiber.Wait(3000);
                    Functions.PlayScannerAudio("TARGET_VEHICLE_LICENCE_PLATE " + Audio + "REPORT_RESPONSE_COPY_02");
                    GameHandler.DispatchMessage("10-12, running...");
                    GameFiber.Wait(6000);

                    //Computer+
                    if (CompterPlus)
                    {
                        Persona _witness = Functions.GetPersonaForPed(Witness);
                        CPlusFunctions.AddUpdateToCallout(CalloutID, "Witness Name: " + _witness.FullName);
                        CPlusFunctions.AddUpdateToCallout(CalloutID, "Car model that caused the accident: " + CarType);
                        CPlusFunctions.AddUpdateToCallout(CalloutID, "Accident was hit and run");
                    }

                    //GET AREAS
                    Marker1.Alpha = 0.8f;
                    Marker2.Alpha = 0.8f;
                    Marker3.Alpha = 0.8f;
                    GameHandler.DispatchMessage("I have 3 possible matches from the system. ~n~ ~g~1. " + Street1 + ",~n~ ~p~2. " + Street2 + ",~n~ ~y~3. " + Street3);
                    Game.DisplaySubtitle("Look at the map and locate the areas. ~n~Press 'NumPad1' to check~g~ " + Street1 + "~w~,~n~Press 'NumPad2' to check~p~ " + Street2 + "~w~,~n~Press 'NumPad3' to check ~y~ " + Street3, 20000);
                }, FiberHandler._fiber_request);
        }

        public static void SpawnVehicle(out Vehicle Car, Globals.SuspectCar CarData, Globals.SuspectLocation Location)
        {
            Car = new Vehicle(CarData._modelname, Location._veh_position, Location._veh_heading);
            Car.IsPersistent = true;
            NativeFunction.CallByName<ulong>("SMASH_VEHICLE_WINDOW", Car, 6);
            NativeFunction.CallByName<ulong>("SET_VEHICLE_DAMAGE", Car, 0.7f, 0.5f, 0.5f, 1000.0f, 100.0f, true);
        }

        public static void SpawnVehicle(out Vehicle Car, out int PositionID, int RegionID, ref Blip Marker, List<Blip> BlipList, Globals.CalloutEnd Ending)
        {
            List<Globals.SuspectCar> tmp_veh = new List<Globals.SuspectCar>();
            switch (RegionID)
            {

                case 1:
                    tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Normal || t._type == Globals.CarType._Rich).ToList();
                    break;
                case 2:
                    tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._County).ToList();
                    break;
                case 3:
                    tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Normal).ToList();
                    break;
            }

            Globals.SuspectCar _suspect_veh = tmp_veh[Main.LPCRandom.Next(tmp_veh.Count)];


            Random rnd = new Random(Environment.TickCount);
            Globals.SuspectPositions _car = new Globals.SuspectPositions();
            List<Globals.SuspectPositions> _tmplist = new List<Globals.SuspectPositions>();
            switch (Ending)
            {
                case Globals.CalloutEnd.ABANDON:
                    _tmplist = Suspects.SuspectPositions.Where(t => t._callouttype == Globals.CalloutType._NoSuspect && t._region == RegionID && t._type == Globals.PositionType.CAR_ABANDON).ToList();
                    _car = _tmplist[rnd.Next(_tmplist.Count)];
                    break;
                case Globals.CalloutEnd.TRAFFICSTOP:
                    _tmplist = Suspects.SuspectPositions.Where(t => t._callouttype == Globals.CalloutType._TrafficStop && t._region == RegionID && t._type == Globals.PositionType.CAR_SUSPECT).ToList();
                    _car = _tmplist[rnd.Next(_tmplist.Count)];
                    break;
            }

            PositionID = _car._id;
            Car = new Vehicle(_suspect_veh._modelname, _car._position, _car._heading);
            Car.IsPersistent = true;
            Car.Wheels[0].BurstTire();
            NativeFunction.CallByName<ulong>("SMASH_VEHICLE_WINDOW", Car, 6);
            NativeFunction.CallByName<ulong>("SET_VEHICLE_DAMAGE", Car, 0.7f, 0.5f, 0.5f, 1000.0f, 100.0f, true);
            NativeFunction.CallByName<ulong>("SET_VEHICLE_DOOR_OPEN", Car, 4, false, true);
            Car.IsStolen = true;
            Marker = Car.AttachBlip();
            Marker.Alpha = 0.0f;
            Marker.Color = System.Drawing.Color.Yellow;
            BlipList.Add(Marker);
        }

        public static void SpawnPed(out Ped Person, Globals.SuspectPerson PersonData, Globals.SuspectLocation Location, ref Blip Marker, ref Persona Data, List<Blip> BlipList, Vehicle Car)
        {
            Person = new Ped(PersonData._modelname, Location._ped_position, Location._ped_heading);
            Person.IsPersistent = true;
            Person.BlockPermanentEvents = true;
            Person.Tasks.PlayAnimation(PersonData._animdir, PersonData._animname, 1f, PersonData._animflag);
            Marker = Person.AttachBlip();
            Marker.Alpha = 0.0f;
            Marker.Color = System.Drawing.Color.Yellow;
            BlipList.Add(Marker);

            Rage.Object _cigarette = new Rage.Object("prop_cs_ciggy_01b", Person.Position);
            int BoneIndex = NativeFunction.Natives.GET_PED_BONE_INDEX<int>(Person, (int)PedBoneId.RightIndexFinger2);
            NativeFunction.CallByName<uint>("ATTACH_ENTITY_TO_ENTITY", _cigarette, Person, BoneIndex, 0f, 0f, 0f, 0f, 0f, 90f, true, false, false, false, 2, 1);

            Data = Functions.GetPersonaForPed(Person);
            Functions.SetPersonaForPed(Person, new Persona(Person, Data.Gender, Data.BirthDay, Data.Citations, Data.Forename, Data.Surname, ELicenseState.Valid, 2, true, false, false));
            Functions.SetVehicleOwnerName(Car, Data.FullName);
        }

        public static void SpawnPed(out Ped Person, int RegionID, int PositionID, ref Persona Data, Vehicle Car)
        {
            List<Globals.SuspectPerson> tmp_ped = new List<Globals.SuspectPerson>();
            switch (RegionID)
            {

                case 1:
                    tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._Normal || t._type == Globals.HumanType._Rich).ToList();
                    break;
                case 2:
                    tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._County).ToList();
                    break;
                case 3:
                    tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._Normal).ToList();
                    break;
            }

            Globals.SuspectPerson _suspect_ped = tmp_ped[Main.LPCRandom.Next(tmp_ped.Count)];

            Random rnd = new Random(Environment.TickCount);
            Globals.SuspectPositions _ped = new Globals.SuspectPositions();

            _ped = Suspects.SuspectPositions.First(t => t._id == PositionID && t._type == Globals.PositionType.PED_SUSPECT);

            Person = new Ped(_suspect_ped._modelname, _ped._position, _ped._heading);
            Person.IsPersistent = true;
            Person.BlockPermanentEvents = true;

            Data = Functions.GetPersonaForPed(Person);
            Functions.SetPersonaForPed(Person, new Persona(Person, Data.Gender, Data.BirthDay, Data.Citations, Data.Forename, Data.Surname, ELicenseState.Suspended, 4, true, false, false));
            Functions.SetVehicleOwnerName(Car, Data.FullName);
        }

        public static void GenerateSuspect(object Instance, ref Globals.SuspectCar Car, ref Globals.SuspectPerson Person, ref Globals.SuspectLocation Location, ref Globals.SuspectDialog Dialog, int Region, Globals.CalloutType Type)
        {
            try
            {
                List<Globals.SuspectLocation> tmp_loc = new List<Globals.SuspectLocation>();
                List<Globals.SuspectCar> tmp_veh = new List<Globals.SuspectCar>();
                List<Globals.SuspectPerson> tmp_ped = new List<Globals.SuspectPerson>();
                List<Globals.SuspectDialog> tmp_dlg = new List<Globals.SuspectDialog>();

                tmp_dlg = Suspects.SuspectDialogs.Where(t => t._callouttype == Type).ToList();
                tmp_loc = Suspects.SuspectLocations.Where(t => t._region == Region && t._callouttype == Type).ToList();

                //GET SUSPECT LOCATION BASED ON SPAWN REGIION
                switch (Region)
                {

                    case 1:
                        if (Type == Globals.CalloutType._Water)
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Water).ToList();
                        else
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Normal || t._type == Globals.CarType._Rich).ToList();

                        tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._Normal || t._type == Globals.HumanType._Rich).ToList();
                        break;
                    case 2:
                        if (Type == Globals.CalloutType._Water)
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Water).ToList();
                        else
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._County).ToList();

                        tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._County).ToList();
                        break;
                    case 3:
                        if (Type == Globals.CalloutType._Water)
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Water).ToList();
                        else
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Normal).ToList();

                        tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._Normal).ToList();
                        break;
                }

                Location = tmp_loc[Main.LPCRandom.Next(tmp_loc.Count)];

                Car = tmp_veh[Main.LPCRandom.Next(tmp_veh.Count)];

                Person = tmp_ped[Main.LPCRandom.Next(tmp_ped.Count)];

                Dialog = tmp_dlg[Main.LPCRandom.Next(tmp_dlg.Count)];

                tmp_loc.Clear();
                tmp_veh.Clear();
                tmp_ped.Clear();
                tmp_dlg.Clear();
            }
            catch
            {
                ErrorHandler.LogMessage(Instance.GetType().Name + " Random Function was aborted", 301);
            }
        }

        public static void GenerateSuspect(object Instance, ref Globals.SuspectCar Car, ref Globals.SuspectPerson Person, ref Globals.SuspectLocation Location, ref Globals.SuspectDialog Dialog, int Region, Globals.CalloutType Type, ref List<Globals.SuspectLocation> AreaList)
        {
            try
            {
                List<Globals.SuspectLocation> tmp_loc = new List<Globals.SuspectLocation>();
                List<Globals.SuspectCar> tmp_veh = new List<Globals.SuspectCar>();
                List<Globals.SuspectPerson> tmp_ped = new List<Globals.SuspectPerson>();
                List<Globals.SuspectDialog> tmp_dlg = new List<Globals.SuspectDialog>();

                tmp_dlg = Suspects.SuspectDialogs.Where(t => t._callouttype == Type).ToList();
                tmp_loc = Suspects.SuspectLocations.Where(t => t._region == Region && t._callouttype == Type).ToList();
                AreaList = tmp_loc.OrderBy(t => Main.LPCRandom.Next()).Take(3).ToList();

                //GET SUSPECT LOCATION BASED ON SPAWN REGIION
                switch (Region)
                {

                    case 1:
                        if (Type == Globals.CalloutType._Water)
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Water).ToList();
                        else
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Normal || t._type == Globals.CarType._Rich).ToList();

                        tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._Normal || t._type == Globals.HumanType._Rich).ToList();
                        break;
                    case 2:
                        if (Type == Globals.CalloutType._Water)
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Water).ToList();
                        else
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._County).ToList();

                        tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._County).ToList();
                        break;
                    case 3:
                        if (Type == Globals.CalloutType._Water)
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Water).ToList();
                        else
                            tmp_veh = Suspects.SuspectCars.Where(t => t._type == Globals.CarType._Normal).ToList();

                        tmp_ped = Suspects.SuspectPeds.Where(t => t._type == Globals.HumanType._Normal).ToList();
                        break;
                }

                Location = AreaList[Main.LPCRandom.Next(AreaList.Count)];

                Car = tmp_veh[Main.LPCRandom.Next(tmp_veh.Count)];

                Person = tmp_ped[Main.LPCRandom.Next(tmp_ped.Count)];

                Dialog = tmp_dlg[Main.LPCRandom.Next(tmp_dlg.Count)];

                tmp_loc.Clear();
                tmp_veh.Clear();
                tmp_ped.Clear();
                tmp_dlg.Clear();
            }
            catch
            {
                ErrorHandler.LogMessage(Instance.GetType().Name + " Random Function was aborted", 301);
            }
        }
    }
}
