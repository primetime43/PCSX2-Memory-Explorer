using Common;
using System.Collections.Generic;

namespace Games.MedalOfHonor
{
    public class MedalOfHonorFrontlineConfig : IGameMemoryConfig
    {
        public string GameName => "Medal of Honor: Frontline (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Player Stats
            memoryValues.Add(new MemoryValue("Current Health", 0x002417D8, "Int32", "Player", "0=Dead, 100=Max"));
            memoryValues.Add(new MemoryValue("Equipped Weapon", 0x002417DC, "Int32", "Player", "Weapon ID"));
            memoryValues.Add(new MemoryValue("Accuracy", 0x00100174, "Float", "Player", "Current accuracy"));

            // Game State
            memoryValues.Add(new MemoryValue("In-Level Flag", 0x0023F8D0, "Int32", "Game State", "0=False, 1=True"));
            memoryValues.Add(new MemoryValue("Screen ID", 0x0023F948, "Int32", "Game State", "Current screen"));
            memoryValues.Add(new MemoryValue("Game Paused", 0x0023FA04, "Int32", "Game State", "0=Not paused"));
            memoryValues.Add(new MemoryValue("Current Menu", 0x0059E624, "Int32", "Game State", "Menu ID when not in game"));

            // Settings
            memoryValues.Add(new MemoryValue("Controller Config", 0x0023FA38, "Int8", "Settings", "1=Sharpshooter, 2=Classic"));
            memoryValues.Add(new MemoryValue("Difficulty", 0x0023FA39, "Int8", "Settings", "1=Easy, 2=Normal, 3=Hard"));

            // Mission Info
            memoryValues.Add(new MemoryValue("Mission ID", 0x0023FA3C, "Int32", "Mission", "Current mission (1-6)"));
            memoryValues.Add(new MemoryValue("Level ID", 0x0023FA40, "Int32", "Mission", "Current level within mission"));
            memoryValues.Add(new MemoryValue("Objectives Completed", 0x0023FA46, "Int8", "Mission", "Number completed"));
            memoryValues.Add(new MemoryValue("Level End Flag", 0x0023FA47, "Int8", "Mission", "0=Not finished, 1=Finished"));
            memoryValues.Add(new MemoryValue("Total Objectives", 0x00253D68, "Int32", "Mission", "Total objectives in mission"));

            // Objectives Status
            memoryValues.Add(new MemoryValue("Objective 1 Status", 0x00253D74, "Int32", "Objectives", "0=Pending, 1=Done"));
            memoryValues.Add(new MemoryValue("Objective 2 Status", 0x00253D80, "Int32", "Objectives", "0=Pending, 1=Done"));
            memoryValues.Add(new MemoryValue("Objective 3 Status", 0x00253D8C, "Int32", "Objectives", "0=Pending, 1=Done"));
            memoryValues.Add(new MemoryValue("Objective 4 Status", 0x00253D98, "Int32", "Objectives", "0=Pending, 1=Done"));
            memoryValues.Add(new MemoryValue("Objective 5 Status", 0x00253DA4, "Int32", "Objectives", "0=Pending, 1=Done"));
            memoryValues.Add(new MemoryValue("Objective 6 Status", 0x00253DB0, "Int32", "Objectives", "0=Pending, 1=Done"));
            memoryValues.Add(new MemoryValue("Objective 7 Status", 0x00253DBC, "Int32", "Objectives", "0=Pending, 1=Done"));
            memoryValues.Add(new MemoryValue("Objective 8 Status", 0x00253DC8, "Int32", "Objectives", "0=Pending, 1=Done"));

            // Medals & Progress
            memoryValues.Add(new MemoryValue("Unlocked Medals 1", 0x0023FA50, "Int8", "Progression", "Medals bitfield (8 medals)"));
            memoryValues.Add(new MemoryValue("Unlocked Medals 2", 0x0023FA51, "Int8", "Progression", "More medals (bit0-1)"));
            memoryValues.Add(new MemoryValue("Missions Unlocked 1", 0x0023FA5C, "Int8", "Progression", "Mission 2-3 levels"));
            memoryValues.Add(new MemoryValue("Missions Unlocked 2", 0x0023FA5D, "Int8", "Progression", "Mission 4-5 levels"));
            memoryValues.Add(new MemoryValue("Missions Unlocked 3", 0x0023FA5E, "Int8", "Progression", "Mission 6 and D-Day levels"));

            // Star Rankings
            memoryValues.Add(new MemoryValue("Stars - Mission 2", 0x0023FA54, "Int8", "Star Rankings", "A Storm in the Port"));
            memoryValues.Add(new MemoryValue("Stars - Mission 3", 0x0023FA55, "Int8", "Star Rankings", "Needle in a Haystack"));
            memoryValues.Add(new MemoryValue("Stars - Mission 4", 0x0023FA56, "Int8", "Star Rankings", "Several Bridges Too Far"));
            memoryValues.Add(new MemoryValue("Stars - Mission 5", 0x0023FA57, "Int8", "Star Rankings", "Rolling Thunder"));
            memoryValues.Add(new MemoryValue("Stars - Mission 6", 0x0023FA58, "Int8", "Star Rankings", "The Horten's Nest"));
            memoryValues.Add(new MemoryValue("Stars - Mission 1", 0x0023FA59, "Int8", "Star Rankings", "D-Day"));

            // Current Mission Statistics
            memoryValues.Add(new MemoryValue("Mission Shots Fired", 0x0023FB58, "Int32", "Mission Stats", "Shots in current mission"));
            memoryValues.Add(new MemoryValue("Mission Hits", 0x0023FB5C, "Int32", "Mission Stats", "Hits in current mission"));
            memoryValues.Add(new MemoryValue("Mission Hits Taken", 0x0023FB60, "Int32", "Mission Stats", "Damage taken"));
            memoryValues.Add(new MemoryValue("Mission Enemies Killed", 0x0023FB68, "Int32", "Mission Stats", "Kills in current mission"));
            memoryValues.Add(new MemoryValue("Mission Timer (Frames)", 0x0023FB88, "Int32", "Mission Stats", "Timer in frames (60fps)"));
            memoryValues.Add(new MemoryValue("Mission Timer (Seconds)", 0x0023FB8C, "Int32", "Mission Stats", "Timer in seconds"));

            // Mission Shot Locations
            memoryValues.Add(new MemoryValue("Mission Head Shots", 0x0023FB6C, "Int32", "Mission Accuracy", "Head hits"));
            memoryValues.Add(new MemoryValue("Mission Left Arm Hits", 0x0023FB70, "Int32", "Mission Accuracy", "Left arm hits"));
            memoryValues.Add(new MemoryValue("Mission Right Arm Hits", 0x0023FB74, "Int32", "Mission Accuracy", "Right arm hits"));
            memoryValues.Add(new MemoryValue("Mission Torso Hits", 0x0023FB78, "Int32", "Mission Accuracy", "Torso hits"));
            memoryValues.Add(new MemoryValue("Mission Left Leg Hits", 0x0023FB7C, "Int32", "Mission Accuracy", "Left leg hits"));
            memoryValues.Add(new MemoryValue("Mission Right Leg Hits", 0x0023FB80, "Int32", "Mission Accuracy", "Right leg hits"));
            memoryValues.Add(new MemoryValue("Mission Groin Hits", 0x0023FB84, "Int32", "Mission Accuracy", "Groin hits"));

            // Global Statistics
            memoryValues.Add(new MemoryValue("Total Shots Fired", 0x0023FA64, "Int32", "Global Stats", "All-time shots"));
            memoryValues.Add(new MemoryValue("Total Hits", 0x0023FA68, "Int32", "Global Stats", "All-time hits"));
            memoryValues.Add(new MemoryValue("Total Hits Taken", 0x0023FA6C, "Int32", "Global Stats", "All-time damage"));
            memoryValues.Add(new MemoryValue("Total Enemies Killed", 0x0023FA74, "Int32", "Global Stats", "All-time kills"));
            memoryValues.Add(new MemoryValue("Total Head Shots", 0x0023FA78, "Int32", "Global Stats", "All-time headshots"));
            memoryValues.Add(new MemoryValue("Total Torso Hits", 0x0023FA84, "Int32", "Global Stats", "All-time torso hits"));

            // Weapon Kills (Current Mission)
            memoryValues.Add(new MemoryValue("Kills - Colt .45", 0x0023FBAC, "Int32", "Weapon Kills", "Colt .45 kills"));
            memoryValues.Add(new MemoryValue("Kills - Walther P38", 0x0023FBB0, "Int32", "Weapon Kills", "Walther P38 kills"));
            memoryValues.Add(new MemoryValue("Kills - Silenced Pistol", 0x0023FBB4, "Int32", "Weapon Kills", "Silenced pistol kills"));
            memoryValues.Add(new MemoryValue("Kills - M1 Garand", 0x0023FBCC, "Int32", "Weapon Kills", "M1 Garand kills"));
            memoryValues.Add(new MemoryValue("Kills - Springfield 03", 0x0023FBD0, "Int32", "Weapon Kills", "Springfield kills"));
            memoryValues.Add(new MemoryValue("Kills - Thompson", 0x0023FBE4, "Int32", "Weapon Kills", "Thompson kills"));
            memoryValues.Add(new MemoryValue("Kills - MP-40", 0x0023FBE8, "Int32", "Weapon Kills", "MP-40 kills"));
            memoryValues.Add(new MemoryValue("Kills - B.A.R.", 0x0023FBF8, "Int32", "Weapon Kills", "B.A.R. kills"));
            memoryValues.Add(new MemoryValue("Kills - MG", 0x0023FC00, "Int32", "Weapon Kills", "Machine gun kills"));
            memoryValues.Add(new MemoryValue("Kills - Mark II Grenade", 0x0023FC18, "Int32", "Weapon Kills", "US grenade kills"));
            memoryValues.Add(new MemoryValue("Kills - Stielgranate", 0x0023FC1C, "Int32", "Weapon Kills", "German grenade kills"));

            // Ammo
            memoryValues.Add(new MemoryValue("Current Weapon Ammo", 0x00254AF0, "Int32", "Ammo", "Ammo in current weapon"));
            memoryValues.Add(new MemoryValue("Reserve Ammo", 0x00254AEC, "Int32", "Ammo", "Remaining ammo for weapon"));

            // Cheats (In-Game Active)
            memoryValues.Add(new MemoryValue("Cheat - Invincible", 0x00240F60, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Infinite Ammo", 0x00240F64, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Snipe-o-Rama", 0x00240F68, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Slow-Mo Jump", 0x00240F6C, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Bullet Shield", 0x00240F74, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Men with Hats", 0x00240F78, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Rubber Grenades", 0x00240F7C, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - MOHton Torpedo", 0x00240F80, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Silver Bullet", 0x00240F84, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Achilles Head", 0x00240F88, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Perfectionist", 0x00240F8C, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Invisible Enemy", 0x00240F90, "Int32", "Cheats Active", "0=Off, 1=On"));

            // Cheat Flags (Menu)
            memoryValues.Add(new MemoryValue("Cheat Flags 1", 0x0023FA4C, "Int8", "Cheat Unlocks", "MOHton, Silver, Bullet Shield, Perfectionist"));
            memoryValues.Add(new MemoryValue("Cheat Flags 2", 0x0023FA4D, "Int8", "Cheat Unlocks", "Invisible, Achilles, Rubber, Hats"));
            memoryValues.Add(new MemoryValue("Cheat Flags 3", 0x0023FA4E, "Int8", "Cheat Unlocks", "Snipe-o-Rama"));

            // Weapon Zoom
            memoryValues.Add(new MemoryValue("Weapon Zoom Scale", 0x0033AE50, "Float", "Weapon", "Current zoom level"));
            memoryValues.Add(new MemoryValue("Weapon Zoom Active", 0x0033AE54, "Int32", "Weapon", "0=No, 1=Yes"));

            return memoryValues;
        }
    }
}
