using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LSPDFR
using Rage;

namespace LPCallouts.Internals
{
    public class ErrorHandler
    {
        public static void LogMessage(string message, int errornumber)
        {
            Game.DisplayHelp("~o~[LPCallouts ERROR:~b~ " + errornumber + "~o~]~w~ Please check RageLog File in GTA5 Directory/logs for details!");
            Game.LogTrivial("[LPCallouts v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "], [ERROR: " + errornumber + "]:" + message);
        }

        public static void WarningMessage(string message, int errornumber)
        {
            Game.LogTrivial("[LPCallouts v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "], [WARNING: " + errornumber + "]:" + message);
        }

    }
}
/*ERROR CODES
 * 
 * OBJECT PLACEMENT:
 * 001 - Static objects could not be placed
 * 002 - Static peds could not be placed
 * 003 - Static vehicles could not be placed
 * 004 - Blips could not be created
 * 005 - Suspect vehicle could not be placed
 * 006 - Suspect ped could not be placed
 * 007 - Relationships not loaded
 * 008 - Objects could not be placed on ground
 * 009 - Assistant Cops not corrently loaded
 * 010 - Cop Models could not be loaded
 * 
 * OBJECT CLEANUP
 * 101 - Incomplete cleanup of Suspect objects
 * 102 - Incomplete cleanup of blips
 * 103 - Incomplete cleanup of static vehicles
 * 104 - Incomplete cleanup of static peds
 * 105 - Incomplete cleanup of static objects
 * 
 * ANIMATIONS
 * 201 - Ped animations could not be loaded
 * 
 * FUNCTIONS
 * 301 - Random Function was aborted
 * 302 - Suspect persona handover aborted
 * 303 - Pursuit was not cleaned up at callout end
 * 304 - Property not added to Ped
 * 305 - Streetnames could not be loaded
 * 306 - Audio could not be loaded
 * 
 * MAIN
 * 991 - Content not loaded
 * 992 - DLL not loaded
 * 993 - Callouts could not be registered!
 * 994 - INI file could not be loaded
 * 995 - INI file value error
 * 996 - GameFiber Crash
 * 997 - Menu Error
 * 998 - IPL Error
 */
