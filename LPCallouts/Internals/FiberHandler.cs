using System;
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

namespace LPCallouts.Internals
{
    public class FiberHandler
    {
        //GAMEFIBER NAMES:
        public static string _fiber_content = "Content Placement";
        public static string _fiber_cleanup = "Entity Cleanup";
        public static string _fiber_request = "Dispatch request";
        public static string _fiber_anim = "Back to Animation";
        public static string _fiber_radio = "Player Radio Animation";
        public static string _fiber_move = "Ped Move to Vehicle";
        public static string _fiber_backup = "AI Backup";
        public static string _fiber_bell = "Doorbell interaction";

        public static void EMSLeaveArea(Vehicle Car, Ped Person)
        {
            if (Car.IsHelicopter)
            {
                GameFiber.StartNew(delegate
                {
                    Person.Tasks.ClearImmediately();
                    Person.Tasks.EnterVehicle(Car, -1);
                    GameFiber.Wait(12000);
                    if (Person.IsInVehicle(Car, false) == true)
                    {
                        Car.IsEngineOn = true;
                        GameFiber.Wait(6000);
                        Car.IsPositionFrozen = false;
                        Car.Dismiss();
                        Person.Dismiss();
                    }
                }, _fiber_move);
            }
            else
            {
                GameFiber.StartNew(delegate
                {
                    Person.Tasks.ClearImmediately();
                    Person.Tasks.EnterVehicle(Car, -1);
                    GameFiber.Wait(12000);
                    if (Person.IsInVehicle(Car, false) == true)
                    {
                        Car.IsPositionFrozen = true;
                        Person.Tasks.CruiseWithVehicle(20f, VehicleDrivingFlags.Emergency);
                        Car.IsSirenOn = true;
                        Car.IsSirenSilent = false;
                        GameFiber.Wait(2000);
                        Car.IsPositionFrozen = false;
                        Car.Dismiss();
                        Person.Dismiss();
                    }
                }, _fiber_move);
            }
        }

        public static void CivCarLeaveArea(Vehicle Car, Ped Person)
        {
            GameFiber.StartNew(delegate
            {
                Person.Tasks.ClearImmediately();
                Person.Tasks.EnterVehicle(Car, -1);
                GameFiber.Wait(8000);
                Car.IsPositionFrozen = true;
                Car.IndicatorLightsStatus = VehicleIndicatorLightsStatus.Off;
                Person.Tasks.CruiseWithVehicle(Car, 20f, VehicleDrivingFlags.Normal);
                GameFiber.Wait(2000);
                Car.IsPositionFrozen = false;
                GameFiber.Wait(2000);
                Car.Dismiss();
                Person.Dismiss();
            }, _fiber_move);
        }

        public static void PedLeaveArea(Ped Person)
        {
            GameFiber.StartNew(delegate
            {
                GameFiber.Wait(2000);
                Person.Dismiss();
                Person.IsPersistent = false;
            }, _fiber_anim);
        }

        public static void BackToAnimation(Ped Person, float Heading, AnimationDictionary AnimDir, string AnimName, AnimationFlags AnimFlag)
        {
            GameFiber.StartNew(delegate
            {
                Person.Tasks.ClearImmediately();
                Person.Tasks.AchieveHeading(Heading);
                GameFiber.Wait(2000);
                Person.Tasks.PlayAnimation(AnimDir, AnimName, 1f, AnimFlag);
            }, _fiber_anim);
        }

        public static void PlayerSearchingAbandon(ref Blip _blip)
        {
            Blip Marker = _blip;
            GameFiber.StartNew(delegate
            {
                GameFiber.Wait(2000);
                Functions.PlayScannerAudio("DISP_ATTENTION_UNIT_02 DIV_" + GameHandler.ini_division_p + " " + GameHandler.ini_unittype_p + " BEAT_" + GameHandler.ini_beat_p);
                GameFiber.Wait(6000);
                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ 10-4, go ahead.");
                GameFiber.Wait(2000);
                GameHandler.DispatchMessage("Stolen Vehicle was found by another unit.");
                GameFiber.Wait(5000);
                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ 10-4. Can you give me the location?");
                GameFiber.Wait(5000);
                GameHandler.DispatchMessage("10-4. Showing you 10-76. Respond Code 2.");
                Marker.Alpha = 1.0f;
                Marker.EnableRoute(System.Drawing.Color.Orange);
            }, FiberHandler._fiber_request);
        }

        public static void PlayerToTrafficstop(ref Blip _blip, List<Blip> BlipList, Vector3 Position)
        {
            Blip Marker = _blip;

            GameFiber.StartNew(delegate
            {
                GameFiber.Wait(2000);
                Functions.PlayScannerAudio("DISP_ATTENTION_UNIT_02 DIV_" + GameHandler.ini_division_p + " " + GameHandler.ini_unittype_p + " BEAT_" + GameHandler.ini_beat_p);
                GameFiber.Wait(4000);
                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ 10-4, go ahead.");
                GameFiber.Wait(2000);
                GameHandler.DispatchMessage("We have 10-38 with a vehicle matching your description.");
                GameFiber.Wait(5000);
                Game.DisplayNotification("~b~" + Globals.CharacterName + ":~w~ 10-4. Can you give me the location?");
                GameFiber.Wait(5000);
                GameHandler.DispatchMessage("10-4. Showing you 10-76. Respond Code 3.");
                Marker = new Blip(Position);
                Marker.Color = Color.Blue;
                Marker.Alpha = 1.0f;
                Marker.EnableRoute(Color.Blue);
                BlipList.Add(Marker);
            }, FiberHandler._fiber_request);
        }

        public static void PlayerAtTrafficstop(Ped Person, Vehicle Car, ref bool Talking, int PositionID)
        {
            bool Enable = Talking;
            GameFiber.StartNew(delegate
            {
                Game.DisplaySubtitle("Talk to the officer by pressing ~o~'" + GameHandler.ini_action.ToString() + "", 5000);
                NativeFunction.CallByName<ulong>("TASK_LEAVE_VEHICLE", Person, Car, 256);
                GameFiber.Wait(2000);
                Globals.SuspectPositions _gotopos = Suspects.SuspectPositions.First(t => t._id == PositionID && t._type == Globals.PositionType.PED_UNIT);
                Person.Tasks.GoStraightToPosition(_gotopos._position, 1.0f, _gotopos._heading, 2f, 3800);
                GameFiber.Wait(4000);
                Enable = true;
            }, FiberHandler._fiber_request);
        }
    }
}
