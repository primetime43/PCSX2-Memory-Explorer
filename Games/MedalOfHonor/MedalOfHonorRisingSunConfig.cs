using Common;
using System.Collections.Generic;

namespace Games.MedalOfHonor
{
    public class MedalOfHonorRisingSunConfig : IGameMemoryConfig
    {
        public string GameName => "Medal of Honor: Rising Sun (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game Settings
            memoryValues.Add(new MemoryValue("Difficulty", 0x00100019, "Int8", "Settings", "Game difficulty",
@"0x01 = Easy
0x02 = Normal
0x03 = Hard"));

            // Game State
            memoryValues.Add(new MemoryValue("Mode Indicator", 0x00131668, "Int8", "Game State", "Current game mode",
@"0x01 = Story Mode
0x02 = Multiplayer"));
            memoryValues.Add(new MemoryValue("Current Mission", 0x00131669, "Int8", "Game State", "Current mission/map",
@"Story Mode Missions:
0x01 = Day of Infamy
0x02 = Fall of the Philippines
0x03 = Midnight Raid on Guadalcanal
0x04 = Pistol Pete Showdown
0x05 = Singapore Sling
0x07 = In Search of Yamashita's Gold
0x08 = A Bridge on the River Kwai
0x09 = Supercarrier Sabotage
0x0B = Pearl Harbor
0x10 = Main Menu

Multiplayer Maps:
0x01 = Battleship Raiders
0x02 = Shima Field
0x03 = Marauders at Midnight
0x04 = Solomon Showdown
0x05 = Death in the Orient
0x06 = Calumpit Chaos
0x07 = Idol Assault
0x08 = Boxcar Brawl
0x09 = Hanger Havoc"));
            memoryValues.Add(new MemoryValue("Match Status", 0x0013166A, "Int8", "Game State", "0x00->0x40 = Match Complete"));
            memoryValues.Add(new MemoryValue("Mission Complete Flag", 0x00100070, "Int8", "Game State", "0x10->0x03 = Mission Complete"));

            // Medals (Bitfield)
            memoryValues.Add(new MemoryValue("Medals Set 1", 0x0010BF50, "Int8", "Progression", "Medals bitfield",
@"bit1 = Mission 1: American Defense Service Medal
bit2 = Mission 3: Philippine Defense Medal
bit3 = Mission 4: Guadalcanal Patch
bit4 = Mission 5: American Campaign Medal
bit5 = Mission 6: Marine Corps Expeditionary Medal
bit7 = Mission 7: Asiatic Pacific Campaign Medal"));
            memoryValues.Add(new MemoryValue("Medals Set 2", 0x0010BF51, "Int8", "Progression", "More medals",
@"bit0 = Mission 8: Bronze Star
bit1 = Mission 9: Silver Star
bit2 = All Medals: Navy Cross Medal
bit3 = Mission 2: Navy Distinguished Service Medal"));

            // Film Canisters - Valor In History
            memoryValues.Add(new MemoryValue("Valor Films Set 1", 0x0010BF58, "Int8", "Film Canisters", "Valor films bitfield",
@"bit1 = Pearl Harbor (Mission 1)
bit2 = Fall of the Philippines
bit3 = Midnight Raid on Guadalcanal
bit4 = Pistol Pete Showdown
bit5 = Singapore Sling
bit7 = In Search of Yamashita's Gold"));
            memoryValues.Add(new MemoryValue("Valor Films Set 2", 0x0010BF59, "Int8", "Film Canisters", "More valor films",
@"bit0 = A Bridge on the River Kwai
bit1 = Supercarrier Sabotage"));

            // Film Canisters - Storyboards
            memoryValues.Add(new MemoryValue("Storyboard Films Set 1", 0x0010BF5C, "Int8", "Film Canisters", "Storyboard films",
@"bit1 = Pearl Harbor (Mission 1)
bit2 = Fall of the Philippines
bit3 = Midnight Raid on Guadalcanal
bit4 = Pistol Pete Showdown
bit5 = Singapore Sling
bit7 = In Search of Yamashita's Gold"));
            memoryValues.Add(new MemoryValue("Storyboard Films Set 2", 0x0010BF5D, "Int8", "Film Canisters", "More storyboards",
@"bit0 = A Bridge on the River Kwai
bit1 = Supercarrier Sabotage"));

            // Additional Items
            memoryValues.Add(new MemoryValue("Additional Items 1", 0x0010BF60, "Int8", "Items", "Items bitfield",
@"bit4 = Machete
bit5 = Lotus Flower"));
            memoryValues.Add(new MemoryValue("Additional Items 2", 0x0010BF61, "Int8", "Items", "More items",
@"bit2 = Entrenching Tool"));

            // Bonuses Unlocked
            memoryValues.Add(new MemoryValue("Bonuses Unlocked 1", 0x0010BF64, "Int8", "Bonuses", "Unlocked bonuses",
@"bit0 = All Replay Items
bit1 = Unlimited Ammo (Mission 1)
bit2 = Silver Bullets (Mission 3)
bit3 = Bullet Shield (Mission 4)
bit4 = Rubber Grenades
bit5 = Men With Hats (Mission 5)
bit6 = Always Sniper
bit7 = Achilles Head (Mission 6)"));
            memoryValues.Add(new MemoryValue("Bonuses Unlocked 2", 0x0010BF65, "Int8", "Bonuses", "More bonuses + skins",
@"Bonuses:
bit0 = Invisible Soldiers (Mission 7)
bit1 = Perfectionist Mode (Mission 8)
bit2 = Immortality (Mission 9)
bit3 = SlowMOH

Skins:
bit4 = Mission 1: Navy Engineer
bit5 = Mission 3: 'Gunnie' Lauton
bit6 = Mission 4: Guad Native
bit7 = Mission 5: Lt. Harrison"));

            // Skins Unlocked
            memoryValues.Add(new MemoryValue("Skins Unlocked 2", 0x0010BF66, "Int8", "Skins", "More skins",
@"bit0 = Mission 6: Colonel Kandler
bit2 = Mission 7: Flying Tiger Pilot
bit3 = Mission 8: Chindit
bit4 = Mission 9: Commander Shima"));

            // Bonuses Active
            memoryValues.Add(new MemoryValue("Bonuses Active 1", 0x0010BF68, "Int8", "Bonuses Active", "Active cheats",
@"bit0 = All Replay Items
bit1 = Unlimited Ammo
bit2 = Silver Bullets
bit3 = Bullet Shield
bit4 = Rubber Grenades
bit5 = Men With Hats
bit6 = Always Sniper
bit7 = Achilles Head"));
            memoryValues.Add(new MemoryValue("Bonuses Active 2", 0x0010BF69, "Int8", "Bonuses Active", "More active cheats",
@"bit0 = Invisible Soldiers
bit1 = Perfectionist Mode
bit2 = Immortality
bit3 = SlowMOH"));

            // Combat Statistics
            memoryValues.Add(new MemoryValue("Shots Fired", 0x00131748, "Int16", "Statistics", "Total shots fired"));
            memoryValues.Add(new MemoryValue("Hits", 0x0013174A, "Int16", "Statistics", "Total hits"));
            memoryValues.Add(new MemoryValue("Hits Taken", 0x00131750, "Int16", "Statistics", "Damage taken count"));
            memoryValues.Add(new MemoryValue("Enemies Killed", 0x00131754, "Int16", "Statistics", "Enemies killed / Planes shot down"));
            memoryValues.Add(new MemoryValue("Head Hits", 0x00131756, "Int16", "Statistics", "Headshot count"));
            memoryValues.Add(new MemoryValue("Left Arm Hits", 0x00131758, "Int16", "Statistics", "Left arm hit count"));
            memoryValues.Add(new MemoryValue("Right Arm Hits", 0x0013175A, "Int16", "Statistics", "Right arm hit count"));
            memoryValues.Add(new MemoryValue("Torso Hits", 0x0013175C, "Int16", "Statistics", "Torso hit count"));
            memoryValues.Add(new MemoryValue("Left Leg Hits", 0x0013175E, "Int16", "Statistics", "Left leg hit count"));
            memoryValues.Add(new MemoryValue("Right Leg Hits", 0x00131760, "Int16", "Statistics", "Right leg hit count"));
            memoryValues.Add(new MemoryValue("Groin Hits", 0x00131762, "Int16", "Statistics", "Groin hit count"));

            // Multiplayer Settings
            memoryValues.Add(new MemoryValue("MP Weapon Set", 0x00132021, "Int8", "Multiplayer", "Weapon set",
@"0x01 = US Balanced
0x02 = Made in Japan
0x03 = Sharpshooter
0x04 = Boomsticks
0x05 = MOH Classic
0x06 = Clandestine
0x07 = Automatics
0x08 = One Shot Kills
0x0A = Pistols Only
0x0B = Rifles Only
0x0C = Collateral Damage
0x0D = Imported
0x0E = Duelist
0x0F = Infantryman"));
            memoryValues.Add(new MemoryValue("MP Time Limit", 0x00132024, "Int8", "Multiplayer", "Time limit (0=Unlimited, 0x3C=60min)"));
            memoryValues.Add(new MemoryValue("MP Kill Limit", 0x00132025, "Int8", "Multiplayer", "Kill limit (0=Unlimited, 0xFF=255)"));
            memoryValues.Add(new MemoryValue("MP Game Settings", 0x00132078, "Int8", "Multiplayer", "Game settings",
@"bit0 = Friendly Fire
bit7 = Game Type (0=Free For All, 1=Team Deathmatch)"));

            // Multiplayer Player Stats
            memoryValues.Add(new MemoryValue("P1 Deaths", 0x00132084, "Int32", "MP Player Stats", "Player 1 death count"));
            memoryValues.Add(new MemoryValue("P1 Kills", 0x00132088, "Int32", "MP Player Stats", "Player 1 kill count"));
            memoryValues.Add(new MemoryValue("P1 Team Frags", 0x0013208C, "Int32", "MP Player Stats", "Player 1 team kills"));
            memoryValues.Add(new MemoryValue("P1 Character", 0x00132144, "Int32", "MP Player Stats", "Player 1 character",
@"0xFF = No character selected

Allied:
0x00 = Geoff (2 Stars)
0x01 = Bromley (4 Stars)
0x02 = Joe (2 Stars)
0x03 = Tarver (4 Stars)
0x04 = Donnie (3 Stars)
0x05 = Lawton (4 Stars)
0x06 = Rickshaw (1 Star)
0x07 = Floyd (3 Stars)
0x08 = Loeffler (3 Stars)
0x09 = Raj (2 Stars)
0x0A = Spinelli (2 Stars)
0x0B = Tanaka (1 Star)
0x0C = Harrison (4 Stars)
0x0D = Silas (3 Stars)
0x0E = Zwick (1 Star)

Axis:
0x0F = Dogan (3 Stars)
0x10 = Shogun (4 Stars)
0x11 = Oomomo (4 Stars)
0x12 = Heigen (3 Stars)
0x13 = Takeuchi (3 Stars)
0x14 = Toragami (2 Stars)
0x15 = Kandler (1 Star)
0x16 = Serguei (2 Stars)
0x17 = Kaijo (1 Star)
0x18 = Karimura (4 Stars)
0x19 = Ishiyama (1 Star)
0x1A = Kohda (2 Stars)
0x1B = Ukijima (1 Star)
0x1C = Moriya (2 Stars)
0x1D = Atsuya (3 Stars)"));

            // Multiplayer Team Scores
            memoryValues.Add(new MemoryValue("Allied Team Score", 0x0013213C, "Int32", "MP Teams", "Allied team total score"));
            memoryValues.Add(new MemoryValue("Axis Team Score", 0x00132140, "Int32", "MP Teams", "Axis team total score"));

            // Multiplayer Match Timer
            memoryValues.Add(new MemoryValue("MP Match Timer", 0x00359D90, "Int32", "Multiplayer", "Match timer (0xBF800000 when over)"));

            // Mission Complete Tracking
            memoryValues.Add(new MemoryValue("Mission Complete State", 0x00381150, "Int32", "Game State", "Mission completion",
@"0xE0 -> 0x120 = Mission 2-8 Complete
0x90 -> 0x120 = Mission 2-8 Complete
0x90 -> 0x1C0 = Mission 9 Complete"));
            memoryValues.Add(new MemoryValue("Level Select Mission", 0x003C6964, "Int8", "Game State", "Level select mission",
@"0x01 = Day of Infamy
0x02 = Fall of the Philippines
0x03 = Midnight Raid on Guadalcanal
0x04 = Pistol Pete Showdown
0x05 = Singapore Sling
0x07 = In Search of Yamashita's Gold
0x08 = A Bridge on the River Kwai
0x09 = Supercarrier Sabotage
0x0B = Pearl Harbor"));

            // Objectives
            memoryValues.Add(new MemoryValue("On Screen Event", 0x004BC080, "Int32", "Objectives", "Current on-screen event"));
            memoryValues.Add(new MemoryValue("Objective ID List", 0x004BC23C, "Int32", "Objectives", "Objective ID reference"));
            memoryValues.Add(new MemoryValue("Objective 1 ID", 0x004BC240, "Int32", "Objectives", "First objective ID"));
            memoryValues.Add(new MemoryValue("Objective 1 Complete", 0x004BC248, "Int32", "Objectives", "First objective status"));
            memoryValues.Add(new MemoryValue("Objective 1 Type", 0x004BC24C, "Int32", "Objectives", "0=Regular, 1=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 2 ID", 0x004BC254, "Int32", "Objectives", "Second objective ID"));
            memoryValues.Add(new MemoryValue("Objective 2 Complete", 0x004BC25C, "Int32", "Objectives", "Second objective status"));
            memoryValues.Add(new MemoryValue("Objective 3 ID", 0x004BC268, "Int32", "Objectives", "Third objective ID"));
            memoryValues.Add(new MemoryValue("Objective 3 Complete", 0x004BC270, "Int32", "Objectives", "Third objective status"));

            // Match Finished Flag
            memoryValues.Add(new MemoryValue("Match Finished Flag", 0x01748ED4, "Int32", "Game State", "Match completion flag"));

            return memoryValues;
        }
    }
}
