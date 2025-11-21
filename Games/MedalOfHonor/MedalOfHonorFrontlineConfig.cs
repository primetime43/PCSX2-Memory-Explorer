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
            memoryValues.Add(new MemoryValue("Accuracy", 0x00100174, "Float", "Player", "Current accuracy percentage"));
            memoryValues.Add(new MemoryValue("Current Health", 0x002417D8, "Int32", "Player", "0=Dead, 100=Max"));
            memoryValues.Add(new MemoryValue("Equipped Weapon", 0x002417DC, "Int32", "Player", "Weapon ID",
@"0x00 = Nothing
0x06 = Colt .45
0x07 = Walther P38
0x08 = Silenced Pistol
0x0E = M1 Garand
0x0F = Springfield '03
0x10 = Gewehr 43
0x14 = Thompson
0x15 = MP-40
0x18 = STG-44
0x19 = B.A.R.
0x1D = Shotgun
0x1E = Bazooka
0x20 = Panzerschreck
0x21 = Mark II Grenade
0x22 = Stielgranate
0x25 = I.D. Papers
0xFFFFFFFF = Nothing/Bare Hands"));

            // Pointers
            memoryValues.Add(new MemoryValue("Unit Infos Pointer", 0x0023F4A8, "Int32", "Pointers", "Pointer to unit information data",
@"Unit Infos structure (each unit 0x130 bytes):
+0x00 = Unit State
+0x04 = Health
+0x08-0x14 = Position (X, Y, Z)
+0x18 = Current Weapon
...

Player is typically first unit in array."));

            // Game State
            memoryValues.Add(new MemoryValue("In-Level Flag", 0x0023F8D0, "Int32", "Game State", "0=False, 1=True"));
            memoryValues.Add(new MemoryValue("Screen ID", 0x0023F948, "Int32", "Game State", "Current screen identifier",
@"0x00 = Loading/Transition
0x01 = In-Game
0x02 = Pause Menu
0x03 = Mission Complete
0x04 = Game Over
0x05 = Main Menu"));
            memoryValues.Add(new MemoryValue("Game Paused", 0x0023FA04, "Int32", "Game State", "0=Not paused, 1=Paused"));
            memoryValues.Add(new MemoryValue("Current Menu", 0x0059E624, "Int32", "Game State", "Menu ID when not in game"));

            // Settings
            memoryValues.Add(new MemoryValue("Controller Config", 0x0023FA38, "Int8", "Settings", "Controller layout",
@"0x01 = MOH Sharpshooter
0x02 = Classic MOH"));
            memoryValues.Add(new MemoryValue("Difficulty", 0x0023FA39, "Int8", "Settings", "Game difficulty setting",
@"0x01 = Easy
0x02 = Normal
0x03 = Hard"));

            // Mission Info
            memoryValues.Add(new MemoryValue("Mission ID", 0x0023FA3C, "Int32", "Mission", "Current mission (1-6)",
@"0x01 = D-Day (Your Finest Hour)
0x02 = A Storm in the Port
0x03 = Needle in a Haystack
0x04 = Several Bridges Too Far
0x05 = Rolling Thunder
0x06 = The Horten's Nest"));
            memoryValues.Add(new MemoryValue("Level ID", 0x0023FA40, "Int32", "Mission", "Current level within mission",
@"Mission 1 - D-Day:
  1 = Your Finest Hour
  2 = Into the Breach

Mission 2 - A Storm in the Port:
  1 = Seaside Stowaway
  2 = Special Cargo
  3 = Eye of the Storm
  4 = A Chance Meeting

Mission 3 - Needle in a Haystack:
  1 = Rough Landing
  2 = The Golden Lion
  3 = Operation Repunzel

Mission 4 - Several Bridges Too Far:
  1 = Nijmegen Bridge
  2 = Yard by Yard
  3 = Arnhem Knights

Mission 5 - Rolling Thunder:
  1 = On Track
  2 = Riding Out the Storm
  3 = Derailed!

Mission 6 - The Horten's Nest:
  1 = Clipping Their Wings
  2 = Enemy Mine
  3 = Under the Radar
  4 = Stealing the Show"));
            memoryValues.Add(new MemoryValue("Objectives Completed", 0x0023FA46, "Int8", "Mission", "Number of objectives completed"));
            memoryValues.Add(new MemoryValue("Level End Flag", 0x0023FA47, "Int8", "Mission", "0=Not finished, 1=Finished"));
            memoryValues.Add(new MemoryValue("Total Objectives", 0x00253D68, "Int32", "Mission", "Total objectives in current mission"));

            // Cheat Unlock Flags (Menu)
            memoryValues.Add(new MemoryValue("Cheat Flags 1", 0x0023FA4C, "Int8", "Cheat Unlocks", "First set of unlocked cheats",
@"Bitfield:
bit0 = MOHton Torpedo
bit1 = Silver Bullet
bit2 = Bullet Shield
bit3 = Perfectionist
bit4-7 = Reserved"));
            memoryValues.Add(new MemoryValue("Cheat Flags 2", 0x0023FA4D, "Int8", "Cheat Unlocks", "Second set of unlocked cheats",
@"Bitfield:
bit0 = Invisible Enemies
bit1 = Achilles Head
bit2 = Rubber Grenades
bit3 = Men with Hats
bit4-7 = Reserved"));
            memoryValues.Add(new MemoryValue("Cheat Flags 3", 0x0023FA4E, "Int8", "Cheat Unlocks", "Third set of unlocked cheats",
@"Bitfield:
bit0 = Snipe-o-Rama
bit1 = Slow-Mo Jump
bit2-7 = Reserved"));

            // Medal Unlocks
            memoryValues.Add(new MemoryValue("Unlocked Medals 1", 0x0023FA50, "Int8", "Progression", "Medals bitfield (first 8 medals)",
@"Bitfield:
bit0 = Army Commendation Medal
bit1 = Army Distinguished Service Medal
bit2 = Soldier's Medal
bit3 = Army Good Conduct Medal
bit4 = Distinguished Service Cross
bit5 = Legion of Merit
bit6 = Bronze Star
bit7 = Silver Star"));
            memoryValues.Add(new MemoryValue("Unlocked Medals 2", 0x0023FA51, "Int8", "Progression", "Medals bitfield (last 2 medals)",
@"Bitfield:
bit0 = Congressional Medal of Honor
bit1 = Medal of Honor
bit2-7 = Reserved"));

            // Star Rankings
            memoryValues.Add(new MemoryValue("Stars - Mission 2", 0x0023FA54, "Int8", "Star Rankings", "A Storm in the Port stars (0-4)"));
            memoryValues.Add(new MemoryValue("Stars - Mission 3", 0x0023FA55, "Int8", "Star Rankings", "Needle in a Haystack stars (0-4)"));
            memoryValues.Add(new MemoryValue("Stars - Mission 4", 0x0023FA56, "Int8", "Star Rankings", "Several Bridges Too Far stars (0-4)"));
            memoryValues.Add(new MemoryValue("Stars - Mission 5", 0x0023FA57, "Int8", "Star Rankings", "Rolling Thunder stars (0-4)"));
            memoryValues.Add(new MemoryValue("Stars - Mission 6", 0x0023FA58, "Int8", "Star Rankings", "The Horten's Nest stars (0-4)"));
            memoryValues.Add(new MemoryValue("Stars - Mission 1", 0x0023FA59, "Int8", "Star Rankings", "D-Day stars (0-4)"));

            // Mission Unlocks
            memoryValues.Add(new MemoryValue("Missions Unlocked 1", 0x0023FA5C, "Int8", "Progression", "Storm/Needle levels unlocked",
@"Bitfield:
bit0 = Seaside Stowaway (2-1)
bit1 = Special Cargo (2-2)
bit2 = Eye of the Storm (2-3)
bit3 = A Chance Meeting (2-4)
bit4 = Rough Landing (3-1)
bit5 = The Golden Lion (3-2)
bit6 = Operation Repunzel (3-3)
bit7 = Reserved"));
            memoryValues.Add(new MemoryValue("Missions Unlocked 2", 0x0023FA5D, "Int8", "Progression", "Bridges/Thunder levels unlocked",
@"Bitfield:
bit0 = Nijmegen Bridge (4-1)
bit1 = Yard by Yard (4-2)
bit2 = Arnhem Knights (4-3)
bit3 = On Track (5-1)
bit4 = Riding Out the Storm (5-2)
bit5 = Derailed! (5-3)
bit6-7 = Reserved"));
            memoryValues.Add(new MemoryValue("Missions Unlocked 3", 0x0023FA5E, "Int8", "Progression", "Horten/D-Day levels unlocked",
@"Bitfield:
bit0 = Clipping Their Wings (6-1)
bit1 = Enemy Mine (6-2)
bit2 = Under the Radar (6-3)
bit3 = Stealing the Show (6-4)
bit4 = Your Finest Hour (1-1)
bit5 = Into the Breach (1-2)
bit6-7 = Reserved"));

            // Global Statistics
            memoryValues.Add(new MemoryValue("Total Shots Fired", 0x0023FA64, "Int32", "Global Stats", "All-time shots fired"));
            memoryValues.Add(new MemoryValue("Total Hits", 0x0023FA68, "Int32", "Global Stats", "All-time hits"));
            memoryValues.Add(new MemoryValue("Total Hits Taken", 0x0023FA6C, "Int32", "Global Stats", "All-time damage taken"));
            memoryValues.Add(new MemoryValue("Total Enemies Killed", 0x0023FA74, "Int32", "Global Stats", "All-time kills"));
            memoryValues.Add(new MemoryValue("Total Head Shots", 0x0023FA78, "Int32", "Global Stats", "All-time headshots"));
            memoryValues.Add(new MemoryValue("Total Left Arm Hits", 0x0023FA7C, "Int32", "Global Stats", "All-time left arm hits"));
            memoryValues.Add(new MemoryValue("Total Right Arm Hits", 0x0023FA80, "Int32", "Global Stats", "All-time right arm hits"));
            memoryValues.Add(new MemoryValue("Total Torso Hits", 0x0023FA84, "Int32", "Global Stats", "All-time torso hits"));
            memoryValues.Add(new MemoryValue("Total Left Leg Hits", 0x0023FA88, "Int32", "Global Stats", "All-time left leg hits"));
            memoryValues.Add(new MemoryValue("Total Right Leg Hits", 0x0023FA8C, "Int32", "Global Stats", "All-time right leg hits"));
            memoryValues.Add(new MemoryValue("Total Groin Hits", 0x0023FA90, "Int32", "Global Stats", "All-time groin hits"));

            // Current Mission Statistics
            memoryValues.Add(new MemoryValue("Mission Shots Fired", 0x0023FB58, "Int32", "Mission Stats", "Shots fired in current mission"));
            memoryValues.Add(new MemoryValue("Mission Hits", 0x0023FB5C, "Int32", "Mission Stats", "Hits in current mission"));
            memoryValues.Add(new MemoryValue("Mission Hits Taken", 0x0023FB60, "Int32", "Mission Stats", "Damage taken in current mission"));
            memoryValues.Add(new MemoryValue("Mission Enemies Killed", 0x0023FB68, "Int32", "Mission Stats", "Kills in current mission"));
            memoryValues.Add(new MemoryValue("Mission Timer (Frames)", 0x0023FB88, "Int32", "Mission Stats", "Mission timer in frames (60fps)"));
            memoryValues.Add(new MemoryValue("Mission Timer (Seconds)", 0x0023FB8C, "Int32", "Mission Stats", "Mission timer in seconds"));

            // Mission Shot Locations
            memoryValues.Add(new MemoryValue("Mission Head Shots", 0x0023FB6C, "Int32", "Mission Accuracy", "Head hits this mission"));
            memoryValues.Add(new MemoryValue("Mission Left Arm Hits", 0x0023FB70, "Int32", "Mission Accuracy", "Left arm hits this mission"));
            memoryValues.Add(new MemoryValue("Mission Right Arm Hits", 0x0023FB74, "Int32", "Mission Accuracy", "Right arm hits this mission"));
            memoryValues.Add(new MemoryValue("Mission Torso Hits", 0x0023FB78, "Int32", "Mission Accuracy", "Torso hits this mission"));
            memoryValues.Add(new MemoryValue("Mission Left Leg Hits", 0x0023FB7C, "Int32", "Mission Accuracy", "Left leg hits this mission"));
            memoryValues.Add(new MemoryValue("Mission Right Leg Hits", 0x0023FB80, "Int32", "Mission Accuracy", "Right leg hits this mission"));
            memoryValues.Add(new MemoryValue("Mission Groin Hits", 0x0023FB84, "Int32", "Mission Accuracy", "Groin hits this mission"));

            // Weapon Kills (Current Mission)
            memoryValues.Add(new MemoryValue("Kills - Colt .45", 0x0023FBAC, "Int32", "Weapon Kills", "Colt .45 kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Walther P38", 0x0023FBB0, "Int32", "Weapon Kills", "Walther P38 kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Silenced Pistol", 0x0023FBB4, "Int32", "Weapon Kills", "Silenced pistol kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - M1 Garand", 0x0023FBCC, "Int32", "Weapon Kills", "M1 Garand kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Springfield '03", 0x0023FBD0, "Int32", "Weapon Kills", "Springfield '03 kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Gewehr 43", 0x0023FBD4, "Int32", "Weapon Kills", "Gewehr 43 kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Thompson", 0x0023FBE4, "Int32", "Weapon Kills", "Thompson kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - MP-40", 0x0023FBE8, "Int32", "Weapon Kills", "MP-40 kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - STG-44", 0x0023FBF4, "Int32", "Weapon Kills", "STG-44 kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - B.A.R.", 0x0023FBF8, "Int32", "Weapon Kills", "B.A.R. kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - MG", 0x0023FC00, "Int32", "Weapon Kills", "Machine gun kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Shotgun", 0x0023FC08, "Int32", "Weapon Kills", "Shotgun kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Bazooka", 0x0023FC0C, "Int32", "Weapon Kills", "Bazooka kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Panzerschreck", 0x0023FC14, "Int32", "Weapon Kills", "Panzerschreck kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Mark II Grenade", 0x0023FC18, "Int32", "Weapon Kills", "US grenade kills this mission"));
            memoryValues.Add(new MemoryValue("Kills - Stielgranate", 0x0023FC1C, "Int32", "Weapon Kills", "German grenade kills this mission"));

            // Cheats (In-Game Active)
            memoryValues.Add(new MemoryValue("Cheat - Invincible", 0x00240F60, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Infinite Ammo", 0x00240F64, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Snipe-o-Rama", 0x00240F68, "Int32", "Cheats Active", "0=Off, 1=On (All weapons have scope)"));
            memoryValues.Add(new MemoryValue("Cheat - Slow-Mo Jump", 0x00240F6C, "Int32", "Cheats Active", "0=Off, 1=On (Matrix-style jumps)"));
            memoryValues.Add(new MemoryValue("Cheat - Unknown", 0x00240F70, "Int32", "Cheats Active", "0=Off, 1=On"));
            memoryValues.Add(new MemoryValue("Cheat - Bullet Shield", 0x00240F74, "Int32", "Cheats Active", "0=Off, 1=On (Deflect bullets)"));
            memoryValues.Add(new MemoryValue("Cheat - Men with Hats", 0x00240F78, "Int32", "Cheats Active", "0=Off, 1=On (Enemies wear hats)"));
            memoryValues.Add(new MemoryValue("Cheat - Rubber Grenades", 0x00240F7C, "Int32", "Cheats Active", "0=Off, 1=On (Grenades bounce)"));
            memoryValues.Add(new MemoryValue("Cheat - MOHton Torpedo", 0x00240F80, "Int32", "Cheats Active", "0=Off, 1=On (Big head mode)"));
            memoryValues.Add(new MemoryValue("Cheat - Silver Bullet", 0x00240F84, "Int32", "Cheats Active", "0=Off, 1=On (One-hit kills)"));
            memoryValues.Add(new MemoryValue("Cheat - Achilles Head", 0x00240F88, "Int32", "Cheats Active", "0=Off, 1=On (Headshots only)"));
            memoryValues.Add(new MemoryValue("Cheat - Perfectionist", 0x00240F8C, "Int32", "Cheats Active", "0=Off, 1=On (Die on miss)"));
            memoryValues.Add(new MemoryValue("Cheat - Invisible Enemy", 0x00240F90, "Int32", "Cheats Active", "0=Off, 1=On (Enemies invisible)"));

            // Objectives Status
            memoryValues.Add(new MemoryValue("Objective 1 Status", 0x00253D74, "Int32", "Objectives", "0=Pending, 1=Complete"));
            memoryValues.Add(new MemoryValue("Objective 2 Status", 0x00253D80, "Int32", "Objectives", "0=Pending, 1=Complete"));
            memoryValues.Add(new MemoryValue("Objective 3 Status", 0x00253D8C, "Int32", "Objectives", "0=Pending, 1=Complete"));
            memoryValues.Add(new MemoryValue("Objective 4 Status", 0x00253D98, "Int32", "Objectives", "0=Pending, 1=Complete"));
            memoryValues.Add(new MemoryValue("Objective 5 Status", 0x00253DA4, "Int32", "Objectives", "0=Pending, 1=Complete"));
            memoryValues.Add(new MemoryValue("Objective 6 Status", 0x00253DB0, "Int32", "Objectives", "0=Pending, 1=Complete"));
            memoryValues.Add(new MemoryValue("Objective 7 Status", 0x00253DBC, "Int32", "Objectives", "0=Pending, 1=Complete"));
            memoryValues.Add(new MemoryValue("Objective 8 Status", 0x00253DC8, "Int32", "Objectives", "0=Pending, 1=Complete"));

            // Ammo
            memoryValues.Add(new MemoryValue("Reserve Ammo", 0x00254AEC, "Int32", "Ammo", "Remaining ammo for current weapon"));
            memoryValues.Add(new MemoryValue("Current Weapon Ammo", 0x00254AF0, "Int32", "Ammo", "Ammo in current weapon's magazine"));

            // The Golden Lion (Mission 3-2) Special
            memoryValues.Add(new MemoryValue("Golden Lion - Scene Counter", 0x00277044, "Int32", "Mission Specific", "The Golden Lion scene counter",
@"Tracks progress through The Golden Lion level scenes.
Used for achievement tracking and progress monitoring."));

            // Weapon Zoom
            memoryValues.Add(new MemoryValue("Weapon Zoom Scale", 0x0033AE50, "Float", "Weapon", "Current zoom level (1.0 = normal)"));
            memoryValues.Add(new MemoryValue("Weapon Zoom Active", 0x0033AE54, "Int32", "Weapon", "0=Not zoomed, 1=Zoomed"));

            return memoryValues;
        }
    }
}
