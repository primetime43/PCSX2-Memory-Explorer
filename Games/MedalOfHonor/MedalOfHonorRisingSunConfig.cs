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
            memoryValues.Add(new MemoryValue("Mission Complete Flag", 0x00100070, "Int8", "Game State", "0x10->0x03 = Mission Complete"));
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
            memoryValues.Add(new MemoryValue("Mission Complete State", 0x00381150, "Int32", "Game State", "Mission completion",
@"0xE0 -> 0x120 = Mission 2-8 Complete
0x90 -> 0x120 = Mission 2-8 Complete
0x90 -> 0x1C0 = Mission 9 Complete"));
            memoryValues.Add(new MemoryValue("Level Select Mission", 0x003C6964, "Int8", "Game State", "Level select mission (only works on level select)",
@"0x01 = Day of Infamy
0x02 = Fall of the Philippines
0x03 = Midnight Raid on Guadalcanal
0x04 = Pistol Pete Showdown
0x05 = Singapore Sling
0x07 = In Search of Yamashita's Gold
0x08 = A Bridge on the River Kwai
0x09 = Supercarrier Sabotage
0x0B = Pearl Harbor"));
            memoryValues.Add(new MemoryValue("Match Finished Flag", 0x01748ED4, "Int32", "Game State", "0x3a11a394 = Match finished"));

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
            memoryValues.Add(new MemoryValue("Valor Films Set 1", 0x0010BF58, "Int8", "Film Canisters", "Valor in History films",
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
            memoryValues.Add(new MemoryValue("Skins Unlocked", 0x0010BF66, "Int8", "Skins", "More skins",
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
            memoryValues.Add(new MemoryValue("MP Time Limit", 0x00132024, "Int8", "Multiplayer", "Time limit (0x00=Unlimited, 0x3C=60min)"));
            memoryValues.Add(new MemoryValue("MP Kill Limit", 0x00132025, "Int8", "Multiplayer", "Kill limit (0x00=Unlimited, 0xFF=255)"));
            memoryValues.Add(new MemoryValue("MP Game Settings", 0x00132078, "Int8", "Multiplayer", "Game settings",
@"bit0 = Friendly Fire
bit7 = Game Type (0=Free For All, 1=Team Deathmatch)"));
            memoryValues.Add(new MemoryValue("MP Match Timer", 0x00359D90, "Int32", "Multiplayer", "Match timer (0xBF800000 when over)"));

            // Multiplayer Player 1 Stats
            memoryValues.Add(new MemoryValue("P1 Deaths", 0x00132084, "Int32", "MP Player Stats", "Player 1 death count"));
            memoryValues.Add(new MemoryValue("P1 Kills", 0x00132088, "Int32", "MP Player Stats", "Player 1 kill count"));
            memoryValues.Add(new MemoryValue("P1 Team Frags", 0x0013208C, "Int32", "MP Player Stats", "Player 1 team kills"));

            // Multiplayer Bot 1 Stats
            memoryValues.Add(new MemoryValue("Bot 1 Deaths", 0x0013209C, "Int32", "MP Bot Stats", "Bot 1 death count"));
            memoryValues.Add(new MemoryValue("Bot 1 Kills", 0x001320A0, "Int32", "MP Bot Stats", "Bot 1 kill count"));
            memoryValues.Add(new MemoryValue("Bot 1 Team Frags", 0x001320A4, "Int32", "MP Bot Stats", "Bot 1 team kills"));

            // Multiplayer Bot 2 Stats
            memoryValues.Add(new MemoryValue("Bot 2 Deaths", 0x001320B4, "Int32", "MP Bot Stats", "Bot 2 death count"));
            memoryValues.Add(new MemoryValue("Bot 2 Kills", 0x001320B8, "Int32", "MP Bot Stats", "Bot 2 kill count"));
            memoryValues.Add(new MemoryValue("Bot 2 Team Frags", 0x001320BC, "Int32", "MP Bot Stats", "Bot 2 team kills"));

            // Multiplayer Bot 3 Stats
            memoryValues.Add(new MemoryValue("Bot 3 Deaths", 0x001320CC, "Int32", "MP Bot Stats", "Bot 3 death count"));
            memoryValues.Add(new MemoryValue("Bot 3 Kills", 0x001320D0, "Int32", "MP Bot Stats", "Bot 3 kill count"));
            memoryValues.Add(new MemoryValue("Bot 3 Team Frags", 0x001320D4, "Int32", "MP Bot Stats", "Bot 3 team kills"));

            // Multiplayer Bot 4 Stats
            memoryValues.Add(new MemoryValue("Bot 4 Deaths", 0x001320E4, "Int32", "MP Bot Stats", "Bot 4 death count"));
            memoryValues.Add(new MemoryValue("Bot 4 Kills", 0x001320E8, "Int32", "MP Bot Stats", "Bot 4 kill count"));
            memoryValues.Add(new MemoryValue("Bot 4 Team Frags", 0x001320EC, "Int32", "MP Bot Stats", "Bot 4 team kills"));

            // Multiplayer Bot 5 Stats
            memoryValues.Add(new MemoryValue("Bot 5 Deaths", 0x001320FC, "Int32", "MP Bot Stats", "Bot 5 death count"));
            memoryValues.Add(new MemoryValue("Bot 5 Kills", 0x00132100, "Int32", "MP Bot Stats", "Bot 5 kill count"));
            memoryValues.Add(new MemoryValue("Bot 5 Team Frags", 0x00132104, "Int32", "MP Bot Stats", "Bot 5 team kills"));

            // Multiplayer Bot 6 Stats
            memoryValues.Add(new MemoryValue("Bot 6 Deaths", 0x00132114, "Int32", "MP Bot Stats", "Bot 6 death count"));
            memoryValues.Add(new MemoryValue("Bot 6 Kills", 0x00132118, "Int32", "MP Bot Stats", "Bot 6 kill count"));
            memoryValues.Add(new MemoryValue("Bot 6 Team Frags", 0x0013211C, "Int32", "MP Bot Stats", "Bot 6 team kills"));

            // Multiplayer Bot 7 Stats
            memoryValues.Add(new MemoryValue("Bot 7 Deaths", 0x0013212C, "Int32", "MP Bot Stats", "Bot 7 death count"));
            memoryValues.Add(new MemoryValue("Bot 7 Kills", 0x00132130, "Int32", "MP Bot Stats", "Bot 7 kill count"));
            memoryValues.Add(new MemoryValue("Bot 7 Team Frags", 0x00132134, "Int32", "MP Bot Stats", "Bot 7 team kills"));

            // Multiplayer Team Scores
            memoryValues.Add(new MemoryValue("Allied Team Score", 0x0013213C, "Int32", "MP Teams", "Allied team total score"));
            memoryValues.Add(new MemoryValue("Axis Team Score", 0x00132140, "Int32", "MP Teams", "Axis team total score"));

            // Multiplayer Characters
            memoryValues.Add(new MemoryValue("P1 Character", 0x00132144, "Int32", "MP Characters", "Player 1 character",
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
            memoryValues.Add(new MemoryValue("Bot 1 Character", 0x00132158, "Int32", "MP Characters", "Bot 1 character (see P1 Character for IDs)"));
            memoryValues.Add(new MemoryValue("Bot 2 Character", 0x0013216C, "Int32", "MP Characters", "Bot 2 character (see P1 Character for IDs)"));
            memoryValues.Add(new MemoryValue("Bot 3 Character", 0x00132180, "Int32", "MP Characters", "Bot 3 character (see P1 Character for IDs)"));
            memoryValues.Add(new MemoryValue("Bot 4 Character", 0x00132194, "Int32", "MP Characters", "Bot 4 character (see P1 Character for IDs)"));
            memoryValues.Add(new MemoryValue("Bot 5 Character", 0x001321A8, "Int32", "MP Characters", "Bot 5 character (see P1 Character for IDs)"));
            memoryValues.Add(new MemoryValue("Bot 6 Character", 0x001321BC, "Int32", "MP Characters", "Bot 6 character (see P1 Character for IDs)"));
            memoryValues.Add(new MemoryValue("Bot 7 Character", 0x001321D0, "Int32", "MP Characters", "Bot 7 character (see P1 Character for IDs)"));

            // Objectives
            memoryValues.Add(new MemoryValue("On Screen Event", 0x004BC080, "Int32", "Objectives", "Current on-screen event"));
            memoryValues.Add(new MemoryValue("Objective ID List", 0x004BC23C, "Int32", "Objectives", "Objective ID reference",
@"0x01bc7180 = None

Mission 1: Day of Infamy
0x01bc9369 = Get Topside
0x01bc9385 = Extinguish Fire
0x01bc93a7 = Defend USS California
0x01bc93d1 = (Bonus) Assist Engineer
0x01bc9423 = (Bonus) Save Crewman

Mission 2: Pearl Harbor
0x01bce4e3 = Defend Battleship
0x01bce511 = Escort USS Nevada
0x01bce533 = (Bonus) Shoot 20 Planes Down
0x01bce57d = (Bonus) Shoot 75 Planes Down

Mission 3: Fall of the Philippines
0x01bc9da0 = Find Brother
0x01bc9ecd = Repair Tank
0x01bc9dad = Locate Lost Explosive Truck
0x01bc9de6 = Disable Radio Command Post
0x01bc9e49 = Signal Demolition Soldiers
0x01bc9e01 = Deliver Explosive Truck
0x01bca010 = (Bonus) Found Commander Shima's Photograph
0x01bca033 = (Bonus) Found Golden Buddha

Mission 4: Midnight Raid on Guadalcanal
0x01bca7fc = Reach Landing Area
0x01bca80f = Reach Outpost
0x01bca81d = Destroy Ammo Depot
0x01bca830 = Secure Depot
0x01bca885 = (Bonus) Intelligence Documents Collected (X of 5)
0x01bca99a = (Bonus) Generator Destroyed

Mission 5: Pistol Pete Showdown
0x01bcb24c = Locate Lost Allied Patrol
0x01bcb266 = Find and Destroy Pistol Pete Artillery
0x01bcb28d = Rescue Lost Allied Patrol
0x01bcb2a7 = Escort Harrison to Pistol Pete
0x01bcb2c6 = Rendezvous with Martin Clemens
0x01bcb305 = Escape Across Final Bridge
0x01bcb2e5 = (Bonus) Storm Pack Howitzer Emplacement
0x01bcb3bc = (Bonus) Harrison Saved

Mission 6: Singapore Sling
0x01bcbad1 = Rendezvous with Tanaka
0x01bcbb14 = Ambush Kandler's Car
0x01bcbb7f = Steal Kandler's Uniform
0x01bcbae8 = Reach the Hotel
0x01bcbaf9 = Infiltrate the Axis Summit
0x01bcbb29 = Grab the Slide Reel
0x01bcbb6d = Escape from Hotel
0x01bcbc3a = All Additional Evidence Found. Bonus Objective 2 Complete
0x01bcbb3d = (Bonus) Rescue British POWs
0x01bcbb51 = (Bonus) Procure Additional Evidence

Mission 7: In Search of Yamashita's Gold
0x01bccb1b = Locate Flying Tiger's Crash Site
0x01bccb3c = Find Tanaka
0x01bccb48 = Discover Yamashita's Gold
0x01bccb71 = Exit Temple Before Fourth Gun Explodes
0x01bccb98 = Rescue Pilot
0x01bccbe0 = Find Lotus Flower
0x01bccba5 = (Bonus) Destroy Japanese Radio Equipment
0x01bccd2b = (Bonus) Destroy Officers' Sake Supply

Mission 8: A Bridge on the River Kwai
0x01bcd3ba = Booby trap rails at the viaduct
0x01bcd3da = Rendezvous with Chindits
0x01bcd0ce = Find Bromley
0x01bcd0db = Sabotage Bridge on River Kwai
0x01bcd0f9 = Gain Control of Crane
0x01bcd10f = Open Fuel Tanks (X of 3)
0x01bcd128 = Get Off Bridge
0x01bcd137 = (Bonus) Clear out Cave Bunkers near Hellfire Pass
0x01bcd247 = (Bonus) Eliminate 10 Enemies at Blockade
0x01bcd268 = (Bonus) Disable Barge Dock

Mission 9: Supercarrier Sabotage
0x01bcd7eb = Open Vents
0x01bcd8b8 = Destroy Fuel Monitors
0x01bcdbae = Break Fuel Valves
0x01bcd7d2 = Locate Gold
0x01bcd7de = Sink Carrier
0x01bcd9fb = (Bonus) Send False Radio Transmission
0x01bcdaf2 = (Bonus) Imperial Orders Found"));

            // Objective 1
            memoryValues.Add(new MemoryValue("Objective 1 ID", 0x004BC240, "Int32", "Objectives", "First objective ID"));
            memoryValues.Add(new MemoryValue("Objective 1 Complete", 0x004BC248, "Int32", "Objectives", "First objective status"));
            memoryValues.Add(new MemoryValue("Objective 1 Type", 0x004BC24C, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 1 Viewable", 0x004BC250, "Int32", "Objectives", "First objective viewable"));

            // Objective 2
            memoryValues.Add(new MemoryValue("Objective 2 ID", 0x004BC254, "Int32", "Objectives", "Second objective ID"));
            memoryValues.Add(new MemoryValue("Objective 2 Complete", 0x004BC25C, "Int32", "Objectives", "Second objective status"));
            memoryValues.Add(new MemoryValue("Objective 2 Type", 0x004BC260, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 2 Viewable", 0x004BC264, "Int32", "Objectives", "Second objective viewable"));

            // Objective 3
            memoryValues.Add(new MemoryValue("Objective 3 ID", 0x004BC268, "Int32", "Objectives", "Third objective ID"));
            memoryValues.Add(new MemoryValue("Objective 3 Complete", 0x004BC270, "Int32", "Objectives", "Third objective status"));
            memoryValues.Add(new MemoryValue("Objective 3 Type", 0x004BC274, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 3 Viewable", 0x004BC278, "Int32", "Objectives", "Third objective viewable"));

            // Objective 4
            memoryValues.Add(new MemoryValue("Objective 4 ID", 0x004BC27C, "Int32", "Objectives", "Fourth objective ID"));
            memoryValues.Add(new MemoryValue("Objective 4 Complete", 0x004BC284, "Int32", "Objectives", "Fourth objective status"));
            memoryValues.Add(new MemoryValue("Objective 4 Type", 0x004BC288, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 4 Viewable", 0x004BC28C, "Int32", "Objectives", "Fourth objective viewable"));

            // Objective 5
            memoryValues.Add(new MemoryValue("Objective 5 ID", 0x004BC290, "Int32", "Objectives", "Fifth objective ID"));
            memoryValues.Add(new MemoryValue("Objective 5 Complete", 0x004BC298, "Int32", "Objectives", "Fifth objective status"));
            memoryValues.Add(new MemoryValue("Objective 5 Type", 0x004BC29C, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 5 Viewable", 0x004BC2A0, "Int32", "Objectives", "Fifth objective viewable"));

            // Objective 6
            memoryValues.Add(new MemoryValue("Objective 6 ID", 0x004BC2A4, "Int32", "Objectives", "Sixth objective ID"));
            memoryValues.Add(new MemoryValue("Objective 6 Complete", 0x004BC2AC, "Int32", "Objectives", "Sixth objective status"));
            memoryValues.Add(new MemoryValue("Objective 6 Type", 0x004BC2B0, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 6 Viewable", 0x004BC2B4, "Int32", "Objectives", "Sixth objective viewable"));

            // Objective 7
            memoryValues.Add(new MemoryValue("Objective 7 ID", 0x004BC2B8, "Int32", "Objectives", "Seventh objective ID"));
            memoryValues.Add(new MemoryValue("Objective 7 Complete", 0x004BC2C0, "Int32", "Objectives", "Seventh objective status"));
            memoryValues.Add(new MemoryValue("Objective 7 Type", 0x004BC2C4, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 7 Viewable", 0x004BC2C8, "Int32", "Objectives", "Seventh objective viewable"));

            // Objective 8
            memoryValues.Add(new MemoryValue("Objective 8 ID", 0x004BC2CC, "Int32", "Objectives", "Eighth objective ID"));
            memoryValues.Add(new MemoryValue("Objective 8 Complete", 0x004BC2D4, "Int32", "Objectives", "Eighth objective status"));
            memoryValues.Add(new MemoryValue("Objective 8 Type", 0x004BC2D8, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 8 Viewable", 0x004BC2DC, "Int32", "Objectives", "Eighth objective viewable"));

            // Objective 9
            memoryValues.Add(new MemoryValue("Objective 9 ID", 0x004BC2E0, "Int32", "Objectives", "Ninth objective ID"));
            memoryValues.Add(new MemoryValue("Objective 9 Complete", 0x004BC2E8, "Int32", "Objectives", "Ninth objective status"));
            memoryValues.Add(new MemoryValue("Objective 9 Type", 0x004BC2EC, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 9 Viewable", 0x004BC2F0, "Int32", "Objectives", "Ninth objective viewable"));

            // Objective 10
            memoryValues.Add(new MemoryValue("Objective 10 ID", 0x004BC2F4, "Int32", "Objectives", "Tenth objective ID"));
            memoryValues.Add(new MemoryValue("Objective 10 Complete", 0x004BC2FC, "Int32", "Objectives", "Tenth objective status"));
            memoryValues.Add(new MemoryValue("Objective 10 Type", 0x004BC300, "Int32", "Objectives", "0x00=Regular, 0x01=Bonus"));
            memoryValues.Add(new MemoryValue("Objective 10 Viewable", 0x004BC304, "Int32", "Objectives", "Tenth objective viewable"));

            return memoryValues;
        }
    }
}
