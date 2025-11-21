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
            memoryValues.Add(new MemoryValue("Difficulty", 0x00100019, "Int8", "Settings", "0x01=Easy, 0x02=Normal, 0x03=Hard"));

            // Game State
            memoryValues.Add(new MemoryValue("Mode Indicator", 0x00131668, "Int8", "Game State", "0x01=Story, 0x02=Multiplayer"));
            memoryValues.Add(new MemoryValue("Current Mission", 0x00131669, "Int8", "Game State", "Mission ID (0x01-0x09)"));
            memoryValues.Add(new MemoryValue("Match Status", 0x0013166A, "Int8", "Game State", "0x00->0x40 = Match Complete"));
            memoryValues.Add(new MemoryValue("Mission Complete Flag", 0x00100070, "Int8", "Game State", "0x10->0x03 = Mission Complete"));

            // Medals (Bitfield)
            memoryValues.Add(new MemoryValue("Medals Set 1", 0x0010BF50, "Int8", "Progression", "Missions 1,3-7 medals (bitfield)"));
            memoryValues.Add(new MemoryValue("Medals Set 2", 0x0010BF51, "Int8", "Progression", "Missions 2,8,9 + Navy Cross medals"));

            // Film Canisters - Valor In History
            memoryValues.Add(new MemoryValue("Valor Films Set 1", 0x0010BF58, "Int8", "Film Canisters", "Missions 1-6 valor films (bitfield)"));
            memoryValues.Add(new MemoryValue("Valor Films Set 2", 0x0010BF59, "Int8", "Film Canisters", "Missions 7-8 valor films"));

            // Film Canisters - Storyboards
            memoryValues.Add(new MemoryValue("Storyboard Films Set 1", 0x0010BF5C, "Int8", "Film Canisters", "Missions 1-6 storyboards (bitfield)"));
            memoryValues.Add(new MemoryValue("Storyboard Films Set 2", 0x0010BF5D, "Int8", "Film Canisters", "Missions 7-8 storyboards"));

            // Additional Items
            memoryValues.Add(new MemoryValue("Additional Items 1", 0x0010BF60, "Int8", "Items", "Machete, Lotus Flower (bitfield)"));
            memoryValues.Add(new MemoryValue("Additional Items 2", 0x0010BF61, "Int8", "Items", "Entrenching Tool (bit2)"));

            // Bonuses Unlocked
            memoryValues.Add(new MemoryValue("Bonuses Unlocked 1", 0x0010BF64, "Int8", "Bonuses", "Replay Items, Unlimited Ammo, Silver Bullets, etc."));
            memoryValues.Add(new MemoryValue("Bonuses Unlocked 2", 0x0010BF65, "Int8", "Bonuses", "Invisible Soldiers, Perfectionist, Immortality, SlowMOH"));

            // Skins Unlocked
            memoryValues.Add(new MemoryValue("Skins Unlocked 1", 0x0010BF65, "Int8", "Skins", "Missions 1-5 skins (bits 4-7)"));
            memoryValues.Add(new MemoryValue("Skins Unlocked 2", 0x0010BF66, "Int8", "Skins", "Missions 6-9 skins"));

            // Bonuses Active
            memoryValues.Add(new MemoryValue("Bonuses Active 1", 0x0010BF68, "Int8", "Bonuses Active", "Active cheats set 1 (bitfield)"));
            memoryValues.Add(new MemoryValue("Bonuses Active 2", 0x0010BF69, "Int8", "Bonuses Active", "Active cheats set 2 (bitfield)"));

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
            memoryValues.Add(new MemoryValue("MP Weapon Set", 0x00132021, "Int8", "Multiplayer", "Weapon set ID (0x01-0x0F)"));
            memoryValues.Add(new MemoryValue("MP Time Limit", 0x00132024, "Int8", "Multiplayer", "Time limit in minutes (0=Unlimited)"));
            memoryValues.Add(new MemoryValue("MP Kill Limit", 0x00132025, "Int8", "Multiplayer", "Kill limit (0=Unlimited, max 255)"));
            memoryValues.Add(new MemoryValue("MP Game Settings", 0x00132078, "Int8", "Multiplayer", "Friendly fire (bit0), Game type (bit7)"));

            // Multiplayer Player Stats
            memoryValues.Add(new MemoryValue("P1 Deaths", 0x00132084, "Int32", "MP Player Stats", "Player 1 death count"));
            memoryValues.Add(new MemoryValue("P1 Kills", 0x00132088, "Int32", "MP Player Stats", "Player 1 kill count"));
            memoryValues.Add(new MemoryValue("P1 Team Frags", 0x0013208C, "Int32", "MP Player Stats", "Player 1 team kills"));
            memoryValues.Add(new MemoryValue("P1 Character", 0x00132144, "Int32", "MP Player Stats", "Player 1 character ID"));

            // Multiplayer Team Scores
            memoryValues.Add(new MemoryValue("Allied Team Score", 0x0013213C, "Int32", "MP Teams", "Allied team total score"));
            memoryValues.Add(new MemoryValue("Axis Team Score", 0x00132140, "Int32", "MP Teams", "Axis team total score"));

            // Multiplayer Match Timer
            memoryValues.Add(new MemoryValue("MP Match Timer", 0x00359D90, "Int32", "Multiplayer", "Match timer (0xBF800000 when over)"));

            // Mission Complete Tracking
            memoryValues.Add(new MemoryValue("Mission Complete State", 0x00381150, "Int32", "Game State", "Mission completion flag"));
            memoryValues.Add(new MemoryValue("Level Select Mission", 0x003C6964, "Int8", "Game State", "Mission on level select screen"));

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
