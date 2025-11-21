using Common;
using System.Collections.Generic;

namespace Games.RatchetClank
{
    public class RatchetDeadlockedConfig : IGameMemoryConfig
    {
        public string GameName => "Ratchet: Deadlocked (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Currency & Points
            memoryValues.Add(new MemoryValue("Bolts", 0x001e2ea0, "Int32", "Currency", "Current bolt count"));
            memoryValues.Add(new MemoryValue("Dread Points", 0x001e2ea4, "Int32", "Currency", "DreadZone points"));

            // Equipped Items
            memoryValues.Add(new MemoryValue("Equipped Skin", 0x001e2eb0, "Int8", "Equipped", "Currently equipped skin ID",
@"0x00 = Default
0x01 = Exterminator v1
0x02 = Exterminator v2
0x03 = Avenger
0x04 = Stalker
0x05 = Alpha
0x06 = Liberator
0x07 = Marauder
0x08 = Crusader
0x09 = Vindicator
0x0a = Elite
0x0b = Quantum
0x0c = Infernox
0x0d = Holoshield Specialist
0x0e = Landstalker
0x0f = Hovership
0x10 = Tremor
0x11 = Jak
0x12 = Dan Johnson
0x13 = Vernon
0x14 = Starshield
0x15 = Clank
0x16 = Renegade
0x17 = Hotshot
0x18 = Ninja Ratchet
0x19 = Mr. Sunshine
0x1a = Snow Dan
0x1b = King Claude
0x1c = W3RM
0x1d = Muscles"));
            memoryValues.Add(new MemoryValue("Equipped Weapon", 0x001e2eb4, "Int8", "Equipped", "Currently equipped weapon",
@"0x00 = Wrench
0x01 = Dual Vipers
0x02 = Magma Cannon
0x03 = Arbiter
0x04 = Fusion Rifle
0x05 = Mini Turret Launcher
0x06 = B6 Obliterator
0x07 = Holoshield Launcher
0x08 = Hunter Mine Launcher
0x09 = Scorpion Flail"));

            // Skins Unlocked (Bitflags)
            memoryValues.Add(new MemoryValue("Skins Unlocked (Bitfield)", 0x001e2eb8, "Int32", "Skins Unlocked", "Bitfield for unlocked skins",
@"bit0 = Default
bit1 = Exterminator v1
bit2 = Exterminator v2
bit3 = Avenger
bit4 = Stalker
bit5 = Alpha
bit6 = Liberator
bit7 = Marauder
bit8 = Crusader
bit9 = Vindicator
bit10 = Elite
bit11 = Quantum
bit12 = Infernox
bit13 = Holoshield Specialist
bit14 = Landstalker
bit15 = Hovership
bit16 = Tremor
bit17 = Jak
bit18 = Dan Johnson
bit19 = Vernon
bit20 = Starshield
bit21 = Clank
bit22 = Renegade
bit23 = Hotshot
bit24 = Ninja Ratchet
bit25 = Mr. Sunshine
bit26 = Snow Dan
bit27 = King Claude
bit28 = W3RM
bit29 = Muscles"));

            // Medals
            memoryValues.Add(new MemoryValue("Blue Medals", 0x001e2ebc, "Int8", "Medals", "Number of blue medals earned"));
            memoryValues.Add(new MemoryValue("Green Medals", 0x001e2ebd, "Int8", "Medals", "Number of green medals earned"));
            memoryValues.Add(new MemoryValue("Gold Medals", 0x001e2ebe, "Int8", "Medals", "Number of gold medals earned"));
            memoryValues.Add(new MemoryValue("Black Medals", 0x001e2ebf, "Int8", "Medals", "Number of black medals earned"));

            // Challenge Mode
            memoryValues.Add(new MemoryValue("Challenge Mode Flag", 0x001e2ec0, "Int8", "Game Progress", "Challenge mode active (0x00=Normal, 0x01=Challenge Mode)"));

            // Bot Equipment
            memoryValues.Add(new MemoryValue("Bot Weapon (Merc)", 0x001e2ec4, "Int8", "Bot Equipment", "Merc's equipped weapon",
@"0x00 = Dual Raptors
0x01 = Dual Vipers
0x02 = Magma Cannon
0x03 = B6 Obliterator
0x04 = Holoshield Launcher"));
            memoryValues.Add(new MemoryValue("Bot Weapon (Green)", 0x001e2ec5, "Int8", "Bot Equipment", "Green's equipped weapon",
@"0x00 = Dual Raptors
0x01 = Dual Vipers
0x02 = Magma Cannon
0x03 = B6 Obliterator
0x04 = Holoshield Launcher"));
            memoryValues.Add(new MemoryValue("Bot Upgrade (Merc)", 0x001e2ec6, "Int8", "Bot Equipment", "Merc's upgrade level (0x00-0x09)"));
            memoryValues.Add(new MemoryValue("Bot Upgrade (Green)", 0x001e2ec7, "Int8", "Bot Equipment", "Green's upgrade level (0x00-0x09)"));
            memoryValues.Add(new MemoryValue("Bot Paintjob (Merc)", 0x001e2ec8, "Int8", "Bot Equipment", "Merc's paintjob",
@"0x00 = Default
0x01 = Flames
0x02 = Yellow Jacket
0x03 = Zebra
0x04 = Crimson
0x05 = Chrome
0x06 = Arctic
0x07 = Bruiser
0x08 = Mr. Sunshine
0x09 = Sluggo
0x0a = Ace Hardlight
0x0b = Reactor
0x0c = Shellshock
0x0d = Vox"));
            memoryValues.Add(new MemoryValue("Bot Paintjob (Green)", 0x001e2ec9, "Int8", "Bot Equipment", "Green's paintjob"));
            memoryValues.Add(new MemoryValue("Bot Head (Merc)", 0x001e2eca, "Int8", "Bot Equipment", "Merc's head style",
@"0x00 = Default
0x01 = Cyclops
0x02 = Brainiac
0x03 = Bug Eye
0x04 = Spike
0x05 = Happy
0x06 = Robo
0x07 = Lizard
0x08 = Megadroid
0x09 = Teeny
0x0a = Winkles
0x0b = Cutter"));
            memoryValues.Add(new MemoryValue("Bot Head (Green)", 0x001e2ecb, "Int8", "Bot Equipment", "Green's head style"));

            // Skills - DreadZone Station
            memoryValues.Add(new MemoryValue("Skills - DreadZone Station", 0x001e2ecc, "Int16", "Skills - DreadZone Station", "Skill points earned on DreadZone Station",
@"bit0 = Skill 1 (Avoid the turrets in the Intrastation Transit without taking damage)
bit1 = Skill 2 (Defeat all DZ Strikers at Grist for the Mill in under 2 minutes 30 seconds)
bit2 = Skill 3 (Don't take damage from the grinders in the Intrastation Transit)
bit3 = Skill 4 (Complete Terminal Clinic Sparring Challenge in under 2 minutes 30 seconds)
bit4 = Skill 5 (Score 500 in the Landstalker qualifying event)
bit5 = Skill 6 (Score 500 in the Air Hovership qualifying event)
bit6 = Skill 7 (Air Hovership time bonus. Complete the Hovership qualifying event in under 1 minute 30 seconds)
bit7 = Skill 8 (Land Stalker time bonus. Complete the Landstalker qualifying event in under 1 minute 30 seconds)
bit8 = Skill 9 (Use the Holoshield Launcher to complete Grist for the Mill without taking damage)
bit9 = Skill 10 (Score 500 in the On the Prowl qualifying event)
bit10 = Skill 11 (On The Prowl time bonus. Complete On the Prowl in under 1 minute 30 seconds)"));

            // Skills - Catacrom Four
            memoryValues.Add(new MemoryValue("Skills - Catacrom Four", 0x001e2ece, "Int16", "Skills - Catacrom Four", "Skill points earned on Catacrom Four",
@"bit0 = Skill 1 (Complete Rise Up without taking damage)
bit1 = Skill 2 (Use only the wrench and the Holoshield Launcher to complete Rise Up)
bit2 = Skill 3 (Have at least 4 holoshields deployed at the same time during Rise Up)
bit3 = Skill 4 (Complete Labyrinth of Death without taking damage)
bit4 = Skill 5 (Complete Labyrinth of Death in under 3 minutes)
bit5 = Skill 6 (Complete Zombie Attack without taking damage)
bit6 = Skill 7 (Complete Zombie Attack using only the wrench)
bit7 = Skill 8 (Complete All Aboard without taking damage)
bit8 = Skill 9 (Complete All Aboard in under 10 seconds with no damage)
bit9 = Skill 10 (Complete The Tower of Power without taking damage)
bit10 = Skill 11 (Complete The Tower of Power in under 2 minutes)
bit11 = Skill 12 (All kills by Holoshield Launcher in Energy Collector)
bit12 = Skill 13 (Complete Energy Collector without taking damage)"));

            // Skills - Sarathos
            memoryValues.Add(new MemoryValue("Skills - Sarathos", 0x001e2ed0, "Int16", "Skills - Sarathos", "Skill points earned on Sarathos",
@"bit0 = Skill 1 (Complete Scorpio without taking damage)
bit1 = Skill 2 (Complete Scorpio using only the wrench)
bit2 = Skill 3 (Use the Dual Vipers to complete Scorpio)
bit3 = Skill 4 (Use the wrench to complete Mining Facility in under 2 minutes)
bit4 = Skill 5 (Complete Mining Facility without taking damage)
bit5 = Skill 6 (Complete King of the Leviathans without taking damage)
bit6 = Skill 7 (Complete King of the Leviathans in under 2 minutes 30 seconds)
bit7 = Skill 8 (Complete Alien Soil without taking damage)
bit8 = Skill 9 (Complete Alien Soil in under 1 minute 30 seconds)
bit9 = Skill 10 (Complete Node Overload without taking damage)
bit10 = Skill 11 (Complete Node Overload in under 2 minutes 30 seconds)
bit11 = Skill 12 (Complete Sarathos Survival without taking damage)
bit12 = Skill 13 (Complete Sarathos Survival using only the wrench)
bit13 = Skill 14 (Complete Where the Dead Sleep without taking damage)
bit14 = Skill 15 (Complete Where the Dead Sleep with all kills by Holoshield Launcher)"));

            // Skills - Kronos
            memoryValues.Add(new MemoryValue("Skills - Kronos", 0x001e2ed2, "Int16", "Skills - Kronos", "Skill points earned on Kronos",
@"bit0 = Skill 1 (Complete Infiltrate the Cathedral without taking damage)
bit1 = Skill 2 (Complete Infiltrate the Cathedral using only the wrench)
bit2 = Skill 3 (Complete Infiltrate the Cathedral in under 1 minute 30 seconds)
bit3 = Skill 4 (Complete Lost and Found without taking damage)
bit4 = Skill 5 (Complete Lost and Found using only the Scorpion Flail)
bit5 = Skill 6 (Complete Lost and Found in under 3 minutes)
bit6 = Skill 7 (Complete Path of Death without taking damage)
bit7 = Skill 8 (Complete Path of Death using only the wrench)
bit8 = Skill 9 (Complete Dark Cathedral without taking damage)
bit9 = Skill 10 (Complete Dark Cathedral using only the Dual Vipers)
bit10 = Skill 11 (Complete Temple of Shaar without taking damage)
bit11 = Skill 12 (Complete Temple of Shaar using only the Scorpion Flail)
bit12 = Skill 13 (Complete Chains of Villainy without taking damage)
bit13 = Skill 14 (Complete Chains of Villainy in under 2 minutes)"));

            // Skills - Shaar
            memoryValues.Add(new MemoryValue("Skills - Shaar", 0x001e2ed4, "Int16", "Skills - Shaar", "Skill points earned on Shaar",
@"bit0 = Skill 1 (Complete Alien Battle without taking damage)
bit1 = Skill 2 (Complete Alien Battle using only the wrench)
bit2 = Skill 3 (Complete Alien Battle in under 2 minutes)
bit3 = Skill 4 (Complete Tremor Smash without taking damage)
bit4 = Skill 5 (Complete Tremor Smash in under 30 seconds)
bit5 = Skill 6 (Complete Moon Landing without taking damage)
bit6 = Skill 7 (Complete Moon Landing in under 2 minutes 30 seconds)
bit7 = Skill 8 (Complete Air Drop without taking damage)
bit8 = Skill 9 (Complete Air Drop in under 3 minutes)
bit9 = Skill 10 (Complete End Zone without taking damage)
bit10 = Skill 11 (Complete End Zone in under 2 minutes)
bit11 = Skill 12 (Complete Grinding without taking damage)
bit12 = Skill 13 (Complete Grinding in under 3 minutes)"));

            // Skills - Orxon
            memoryValues.Add(new MemoryValue("Skills - Orxon", 0x001e2ed6, "Int16", "Skills - Orxon", "Skill points earned on Orxon",
@"bit0 = Skill 1 (Complete Prison Break without taking damage)
bit1 = Skill 2 (Complete Prison Break using only the wrench)
bit2 = Skill 3 (Complete Prison Break in under 2 minutes)
bit3 = Skill 4 (Complete Refinery Ambush without taking damage)
bit4 = Skill 5 (Complete Refinery Ambush using only the Magma Cannon)
bit5 = Skill 6 (Complete Refinery Ambush in under 2 minutes 30 seconds)
bit6 = Skill 7 (Complete Defend without taking damage)
bit7 = Skill 8 (Defend all turrets with at least 50% health)
bit8 = Skill 9 (Complete The Bomb without taking damage)
bit9 = Skill 10 (Complete The Bomb in under 1 minute 30 seconds)
bit10 = Skill 11 (Complete Gas Attack without taking damage)
bit11 = Skill 12 (Complete Gas Attack in under 3 minutes)
bit12 = Skill 13 (Complete Landstalker Chase without taking damage)
bit13 = Skill 14 (Score at least 10000 points in Landstalker Chase)"));

            // Skills - Valix Belt
            memoryValues.Add(new MemoryValue("Skills - Valix Belt", 0x001e2ed8, "Int16", "Skills - Valix Belt", "Skill points earned on Valix Belt",
@"bit0 = Skill 1 (Complete One Giant Step without taking damage)
bit1 = Skill 2 (Complete One Giant Step using only the wrench)
bit2 = Skill 3 (Complete One Giant Step in under 2 minutes)
bit3 = Skill 4 (Complete Escape without taking damage)
bit4 = Skill 5 (Complete Escape in under 30 seconds)
bit5 = Skill 6 (Complete The Long Walk without taking damage)
bit6 = Skill 7 (Complete The Long Walk in under 2 minutes)
bit7 = Skill 8 (Complete Space Ace without taking damage)
bit8 = Skill 9 (Complete Space Ace with all kills by Holoshield Launcher)
bit9 = Skill 10 (Complete Mining without taking damage)
bit10 = Skill 11 (Complete Mining in under 2 minutes)
bit11 = Skill 12 (Complete Advanced Qualifier without taking damage)
bit12 = Skill 13 (Complete Advanced Qualifier with all kills by Dual Vipers)
bit13 = Skill 14 (Complete Asteroid Attack without taking damage)
bit14 = Skill 15 (Score at least 4000 in Asteroid Attack)"));

            // Skills - Torval
            memoryValues.Add(new MemoryValue("Skills - Torval", 0x001e2eda, "Int16", "Skills - Torval", "Skill points earned on Torval",
@"bit0 = Skill 1 (Complete Cold Storage without taking damage)
bit1 = Skill 2 (Complete Cold Storage using only the wrench)
bit2 = Skill 3 (Complete Cold Storage in under 2 minutes 30 seconds)
bit3 = Skill 4 (Complete Grinding without taking damage)
bit4 = Skill 5 (Complete Grinding in under 2 minutes)
bit5 = Skill 6 (Complete Construction Site without taking damage)
bit6 = Skill 7 (Complete Construction Site in under 2 minutes)
bit7 = Skill 8 (Complete Ice Cube without taking damage)
bit8 = Skill 9 (Complete Ice Cube in under 25 seconds)
bit9 = Skill 10 (Complete Field Trip without taking damage)
bit10 = Skill 11 (Complete Field Trip in under 2 minutes)
bit11 = Skill 12 (Complete Factory Smash without taking damage)
bit12 = Skill 13 (Complete Factory Smash in under 2 minutes 30 seconds)"));

            // Skills - Stygia
            memoryValues.Add(new MemoryValue("Skills - Stygia", 0x001e2edc, "Int16", "Skills - Stygia", "Skill points earned on Stygia",
@"bit0 = Skill 1 (Complete Industrial Mine without taking damage)
bit1 = Skill 2 (Complete Industrial Mine using only the wrench)
bit2 = Skill 3 (Complete Industrial Mine in under 2 minutes)
bit3 = Skill 4 (Complete Breath of Fire without taking damage)
bit4 = Skill 5 (Complete Breath of Fire in under 3 minutes)
bit5 = Skill 6 (Complete Tunnel Drop without taking damage)
bit6 = Skill 7 (Complete Tunnel Drop in under 30 seconds)
bit7 = Skill 8 (Complete Lava Climbing without taking damage)
bit8 = Skill 9 (Complete Lava Climbing in under 2 minutes)
bit9 = Skill 10 (Complete The Crucible without taking damage)
bit10 = Skill 11 (Complete The Crucible in under 3 minutes)
bit11 = Skill 12 (Complete Fighting Fire with Fire without taking damage)
bit12 = Skill 13 (Complete Fighting Fire with Fire in under 3 minutes)"));

            // Skills - Maraxus
            memoryValues.Add(new MemoryValue("Skills - Maraxus", 0x001e2ede, "Int16", "Skills - Maraxus", "Skill points earned on Maraxus",
@"bit0 = Skill 1 (Complete Sarathos Safari without taking damage)
bit1 = Skill 2 (Complete Sarathos Safari in under 2 minutes)
bit2 = Skill 3 (Complete Frozen Tundra without taking damage)
bit3 = Skill 4 (Complete Frozen Tundra in under 2 minutes)
bit4 = Skill 5 (Complete Jail Break without taking damage)
bit5 = Skill 6 (Complete Jail Break in under 2 minutes 30 seconds)
bit6 = Skill 7 (Complete Prison Cell without taking damage)
bit7 = Skill 8 (Complete Prison Cell in under 25 seconds)
bit8 = Skill 9 (Complete Reactor without taking damage)
bit9 = Skill 10 (Complete Reactor in under 2 minutes 30 seconds)
bit10 = Skill 11 (Complete Last Stand without taking damage)
bit11 = Skill 12 (Complete Last Stand in under 2 minutes 30 seconds)"));

            // Skills - Ghost Station
            memoryValues.Add(new MemoryValue("Skills - Ghost Station", 0x001e2ee0, "Int16", "Skills - Ghost Station", "Skill points earned on Ghost Station",
@"bit0 = Skill 1 (Complete The Hero Smash without taking damage)
bit1 = Skill 2 (Complete The Hero Smash in under 30 seconds)
bit2 = Skill 3 (Complete Prison Planet without taking damage)
bit3 = Skill 4 (Complete Prison Planet in under 2 minutes)
bit4 = Skill 5 (Complete Haunted without taking damage)
bit5 = Skill 6 (Complete Haunted in under 2 minutes)
bit6 = Skill 7 (Complete Escape the Station without taking damage)
bit7 = Skill 8 (Complete Escape the Station in under 2 minutes)
bit8 = Skill 9 (Complete The Final Showdown without taking damage)
bit9 = Skill 10 (Complete The Final Showdown in under 5 minutes)"));

            // Enemy Defeat Statistics
            memoryValues.Add(new MemoryValue("Enemies Defeated - Swarmers", 0x001e2ee4, "Int16", "Enemy Stats", "Swarmers defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 2", 0x001e2ee6, "Int16", "Enemy Stats", "Unknown enemy type 2 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Tremors", 0x001e2ee8, "Int16", "Enemy Stats", "Tremors defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 4", 0x001e2eea, "Int16", "Enemy Stats", "Unknown enemy type 4 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Executioners", 0x001e2eec, "Int16", "Enemy Stats", "Executioners defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 6", 0x001e2eee, "Int16", "Enemy Stats", "Unknown enemy type 6 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - DZ Strikers", 0x001e2ef0, "Int16", "Enemy Stats", "DZ Strikers defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 8", 0x001e2ef2, "Int16", "Enemy Stats", "Unknown enemy type 8 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Zombies", 0x001e2ef4, "Int16", "Enemy Stats", "Zombies defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 10", 0x001e2ef6, "Int16", "Enemy Stats", "Unknown enemy type 10 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Laser Bots", 0x001e2ef8, "Int16", "Enemy Stats", "Laser Bots defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 12", 0x001e2efa, "Int16", "Enemy Stats", "Unknown enemy type 12 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Leviathans", 0x001e2efc, "Int16", "Enemy Stats", "Leviathans defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 14", 0x001e2efe, "Int16", "Enemy Stats", "Unknown enemy type 14 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Dropships", 0x001e2f00, "Int16", "Enemy Stats", "Dropships destroyed"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 16", 0x001e2f02, "Int16", "Enemy Stats", "Unknown enemy type 16 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Ghost Zombies", 0x001e2f04, "Int16", "Enemy Stats", "Ghost Zombies defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 18", 0x001e2f06, "Int16", "Enemy Stats", "Unknown enemy type 18 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Blade Balls", 0x001e2f08, "Int16", "Enemy Stats", "Blade Balls defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 20", 0x001e2f0a, "Int16", "Enemy Stats", "Unknown enemy type 20 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Ghost Executioners", 0x001e2f0c, "Int16", "Enemy Stats", "Ghost Executioners defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 22", 0x001e2f0e, "Int16", "Enemy Stats", "Unknown enemy type 22 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Endzone Bomber", 0x001e2f10, "Int16", "Enemy Stats", "Endzone Bombers defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 24", 0x001e2f12, "Int16", "Enemy Stats", "Unknown enemy type 24 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - DZ Ghost", 0x001e2f14, "Int16", "Enemy Stats", "DZ Ghosts defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 26", 0x001e2f16, "Int16", "Enemy Stats", "Unknown enemy type 26 defeated"));
            memoryValues.Add(new MemoryValue("Enemies Defeated - Unknown 27", 0x001e2f18, "Int16", "Enemy Stats", "Unknown enemy type 27 defeated"));

            // Alpha Mods Available
            memoryValues.Add(new MemoryValue("Alpha Mod Available - Speed", 0x001e2f1c, "Int8", "Alpha Mods Available", "Speed mods in inventory"));
            memoryValues.Add(new MemoryValue("Alpha Mod Available - Ammo", 0x001e2f1d, "Int8", "Alpha Mods Available", "Ammo mods in inventory"));
            memoryValues.Add(new MemoryValue("Alpha Mod Available - Aiming", 0x001e2f1e, "Int8", "Alpha Mods Available", "Aiming mods in inventory"));
            memoryValues.Add(new MemoryValue("Alpha Mod Available - Impact", 0x001e2f1f, "Int8", "Alpha Mods Available", "Impact mods in inventory"));
            memoryValues.Add(new MemoryValue("Alpha Mod Available - Area", 0x001e2f20, "Int8", "Alpha Mods Available", "Area mods in inventory"));
            memoryValues.Add(new MemoryValue("Alpha Mod Available - XP", 0x001e2f21, "Int8", "Alpha Mods Available", "XP mods in inventory"));
            memoryValues.Add(new MemoryValue("Alpha Mod Available - Jackpot", 0x001e2f22, "Int8", "Alpha Mods Available", "Jackpot mods in inventory"));
            memoryValues.Add(new MemoryValue("Alpha Mod Available - NanoLeech", 0x001e2f23, "Int8", "Alpha Mods Available", "NanoLeech mods in inventory"));

            // Wrench
            memoryValues.Add(new MemoryValue("Wrench Upgrade Level", 0x001e2f24, "Int8", "Wrench", "Wrench upgrade level",
@"0x00 = OmniWrench
0x01 = OmniWrench 8001
0x02 = OmniWrench 9001
0x03 = OmniWrench 10K
0x04 = OmniWrench 12000
0x05 = Mega OmniWrench 12000"));

            // Dual Vipers
            memoryValues.Add(new MemoryValue("Dual Vipers - Level", 0x001e2f28, "Int8", "Weapons - Dual Vipers", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Ammo", 0x001e2f2c, "Int32", "Weapons - Dual Vipers", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Experience", 0x001e2f30, "Int32", "Weapons - Dual Vipers", "Experience points"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Omega Mod", 0x001e2f34, "Int8", "Weapons - Dual Vipers", "Equipped omega mod",
@"0x00 = No Mod
0x01-0x10 = Various omega mods"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 1", 0x001e2f36, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 1",
@"0x00 = Empty
0x01 = Speed
0x02 = Ammo
0x03 = Aiming
0x04 = Impact
0x05 = Area
0x06 = XP
0x07 = Jackpot
0x08 = NanoLeech"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 2", 0x001e2f37, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 3", 0x001e2f38, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 4", 0x001e2f39, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 5", 0x001e2f3a, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 6", 0x001e2f3b, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 7", 0x001e2f3c, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 8", 0x001e2f3d, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 9", 0x001e2f3e, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Dual Vipers - Alpha Mod Slot 10", 0x001e2f3f, "Int8", "Weapons - Dual Vipers", "Alpha mod in slot 10"));

            // Magma Cannon
            memoryValues.Add(new MemoryValue("Magma Cannon - Level", 0x001e2f40, "Int8", "Weapons - Magma Cannon", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Ammo", 0x001e2f44, "Int32", "Weapons - Magma Cannon", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Experience", 0x001e2f48, "Int32", "Weapons - Magma Cannon", "Experience points"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Omega Mod", 0x001e2f4c, "Int8", "Weapons - Magma Cannon", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 1", 0x001e2f4e, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 2", 0x001e2f4f, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 3", 0x001e2f50, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 4", 0x001e2f51, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 5", 0x001e2f52, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 6", 0x001e2f53, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 7", 0x001e2f54, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 8", 0x001e2f55, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 9", 0x001e2f56, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Magma Cannon - Alpha Mod Slot 10", 0x001e2f57, "Int8", "Weapons - Magma Cannon", "Alpha mod in slot 10"));

            // Arbiter
            memoryValues.Add(new MemoryValue("Arbiter - Level", 0x001e2f58, "Int8", "Weapons - Arbiter", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Arbiter - Ammo", 0x001e2f5c, "Int32", "Weapons - Arbiter", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Arbiter - Experience", 0x001e2f60, "Int32", "Weapons - Arbiter", "Experience points"));
            memoryValues.Add(new MemoryValue("Arbiter - Omega Mod", 0x001e2f64, "Int8", "Weapons - Arbiter", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 1", 0x001e2f66, "Int8", "Weapons - Arbiter", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 2", 0x001e2f67, "Int8", "Weapons - Arbiter", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 3", 0x001e2f68, "Int8", "Weapons - Arbiter", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 4", 0x001e2f69, "Int8", "Weapons - Arbiter", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 5", 0x001e2f6a, "Int8", "Weapons - Arbiter", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 6", 0x001e2f6b, "Int8", "Weapons - Arbiter", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 7", 0x001e2f6c, "Int8", "Weapons - Arbiter", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 8", 0x001e2f6d, "Int8", "Weapons - Arbiter", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 9", 0x001e2f6e, "Int8", "Weapons - Arbiter", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Arbiter - Alpha Mod Slot 10", 0x001e2f6f, "Int8", "Weapons - Arbiter", "Alpha mod in slot 10"));

            // Fusion Rifle
            memoryValues.Add(new MemoryValue("Fusion Rifle - Level", 0x001e2f70, "Int8", "Weapons - Fusion Rifle", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Ammo", 0x001e2f74, "Int32", "Weapons - Fusion Rifle", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Experience", 0x001e2f78, "Int32", "Weapons - Fusion Rifle", "Experience points"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Omega Mod", 0x001e2f7c, "Int8", "Weapons - Fusion Rifle", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 1", 0x001e2f7e, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 2", 0x001e2f7f, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 3", 0x001e2f80, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 4", 0x001e2f81, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 5", 0x001e2f82, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 6", 0x001e2f83, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 7", 0x001e2f84, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 8", 0x001e2f85, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 9", 0x001e2f86, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Fusion Rifle - Alpha Mod Slot 10", 0x001e2f87, "Int8", "Weapons - Fusion Rifle", "Alpha mod in slot 10"));

            // Mini Turret Launcher
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Level", 0x001e2f88, "Int8", "Weapons - Mini Turret", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Ammo", 0x001e2f8c, "Int32", "Weapons - Mini Turret", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Experience", 0x001e2f90, "Int32", "Weapons - Mini Turret", "Experience points"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Omega Mod", 0x001e2f94, "Int8", "Weapons - Mini Turret", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 1", 0x001e2f96, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 2", 0x001e2f97, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 3", 0x001e2f98, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 4", 0x001e2f99, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 5", 0x001e2f9a, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 6", 0x001e2f9b, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 7", 0x001e2f9c, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 8", 0x001e2f9d, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 9", 0x001e2f9e, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Mini Turret Launcher - Alpha Mod Slot 10", 0x001e2f9f, "Int8", "Weapons - Mini Turret", "Alpha mod in slot 10"));

            // B6 Obliterator
            memoryValues.Add(new MemoryValue("B6 Obliterator - Level", 0x001e2fa0, "Int8", "Weapons - B6 Obliterator", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Ammo", 0x001e2fa4, "Int32", "Weapons - B6 Obliterator", "Current ammo count"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Experience", 0x001e2fa8, "Int32", "Weapons - B6 Obliterator", "Experience points"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Omega Mod", 0x001e2fac, "Int8", "Weapons - B6 Obliterator", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 1", 0x001e2fae, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 2", 0x001e2faf, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 3", 0x001e2fb0, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 4", 0x001e2fb1, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 5", 0x001e2fb2, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 6", 0x001e2fb3, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 7", 0x001e2fb4, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 8", 0x001e2fb5, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 9", 0x001e2fb6, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("B6 Obliterator - Alpha Mod Slot 10", 0x001e2fb7, "Int8", "Weapons - B6 Obliterator", "Alpha mod in slot 10"));

            // Holoshield Launcher
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Level", 0x001e2fb8, "Int8", "Weapons - Holoshield", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Ammo", 0x001e2fbc, "Int32", "Weapons - Holoshield", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Experience", 0x001e2fc0, "Int32", "Weapons - Holoshield", "Experience points"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Omega Mod", 0x001e2fc4, "Int8", "Weapons - Holoshield", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 1", 0x001e2fc6, "Int8", "Weapons - Holoshield", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 2", 0x001e2fc7, "Int8", "Weapons - Holoshield", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 3", 0x001e2fc8, "Int8", "Weapons - Holoshield", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 4", 0x001e2fc9, "Int8", "Weapons - Holoshield", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 5", 0x001e2fca, "Int8", "Weapons - Holoshield", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 6", 0x001e2fcb, "Int8", "Weapons - Holoshield", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 7", 0x001e2fcc, "Int8", "Weapons - Holoshield", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 8", 0x001e2fcd, "Int8", "Weapons - Holoshield", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 9", 0x001e2fce, "Int8", "Weapons - Holoshield", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Holoshield Launcher - Alpha Mod Slot 10", 0x001e2fcf, "Int8", "Weapons - Holoshield", "Alpha mod in slot 10"));

            // Hunter Mine Launcher
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Level", 0x001e2fd0, "Int8", "Weapons - Hunter Mine", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Ammo", 0x001e2fd4, "Int32", "Weapons - Hunter Mine", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Experience", 0x001e2fd8, "Int32", "Weapons - Hunter Mine", "Experience points"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Omega Mod", 0x001e2fdc, "Int8", "Weapons - Hunter Mine", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 1", 0x001e2fde, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 2", 0x001e2fdf, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 3", 0x001e2fe0, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 4", 0x001e2fe1, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 5", 0x001e2fe2, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 6", 0x001e2fe3, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 7", 0x001e2fe4, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 8", 0x001e2fe5, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 9", 0x001e2fe6, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Hunter Mine Launcher - Alpha Mod Slot 10", 0x001e2fe7, "Int8", "Weapons - Hunter Mine", "Alpha mod in slot 10"));

            // Scorpion Flail
            memoryValues.Add(new MemoryValue("Scorpion Flail - Level", 0x001e2fe8, "Int8", "Weapons - Scorpion Flail", "Weapon level (0x00-0x09, 0x0a=V10 Mega)"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Ammo", 0x001e2fec, "Int32", "Weapons - Scorpion Flail", "Current ammo count"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Experience", 0x001e2ff0, "Int32", "Weapons - Scorpion Flail", "Experience points"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Omega Mod", 0x001e2ff4, "Int8", "Weapons - Scorpion Flail", "Equipped omega mod"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 1", 0x001e2ff6, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 1"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 2", 0x001e2ff7, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 2"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 3", 0x001e2ff8, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 3"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 4", 0x001e2ff9, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 4"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 5", 0x001e2ffa, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 5"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 6", 0x001e2ffb, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 6"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 7", 0x001e2ffc, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 7"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 8", 0x001e2ffd, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 8"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 9", 0x001e2ffe, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 9"));
            memoryValues.Add(new MemoryValue("Scorpion Flail - Alpha Mod Slot 10", 0x001e2fff, "Int8", "Weapons - Scorpion Flail", "Alpha mod in slot 10"));

            // Challenge Completion - DreadZone Station
            memoryValues.Add(new MemoryValue("Challenge - Grist for the Mill - Times Completed", 0x001e3000, "Int8", "Challenges - DreadZone", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Grist for the Mill - Stars", 0x001e3001, "Int8", "Challenges - DreadZone", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Sparring - Times Completed", 0x001e3002, "Int8", "Challenges - DreadZone", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Sparring - Stars", 0x001e3003, "Int8", "Challenges - DreadZone", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Landstalker Qualifying - Times Completed", 0x001e3004, "Int8", "Challenges - DreadZone", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Landstalker Qualifying - Stars", 0x001e3005, "Int8", "Challenges - DreadZone", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Hovership Qualifying - Times Completed", 0x001e3006, "Int8", "Challenges - DreadZone", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Hovership Qualifying - Stars", 0x001e3007, "Int8", "Challenges - DreadZone", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - On the Prowl - Times Completed", 0x001e3008, "Int8", "Challenges - DreadZone", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - On the Prowl - Stars", 0x001e3009, "Int8", "Challenges - DreadZone", "Stars awarded (0-5)"));

            // Challenge Completion - Catacrom Four
            memoryValues.Add(new MemoryValue("Challenge - Rise Up - Times Completed", 0x001e300a, "Int8", "Challenges - Catacrom", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Rise Up - Stars", 0x001e300b, "Int8", "Challenges - Catacrom", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Labyrinth of Death - Times Completed", 0x001e300c, "Int8", "Challenges - Catacrom", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Labyrinth of Death - Stars", 0x001e300d, "Int8", "Challenges - Catacrom", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Zombie Attack - Times Completed", 0x001e300e, "Int8", "Challenges - Catacrom", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Zombie Attack - Stars", 0x001e300f, "Int8", "Challenges - Catacrom", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - All Aboard - Times Completed", 0x001e3010, "Int8", "Challenges - Catacrom", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - All Aboard - Stars", 0x001e3011, "Int8", "Challenges - Catacrom", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Tower of Power - Times Completed", 0x001e3012, "Int8", "Challenges - Catacrom", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Tower of Power - Stars", 0x001e3013, "Int8", "Challenges - Catacrom", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Energy Collector - Times Completed", 0x001e3014, "Int8", "Challenges - Catacrom", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Energy Collector - Stars", 0x001e3015, "Int8", "Challenges - Catacrom", "Stars awarded (0-5)"));

            // Challenge Completion - Sarathos
            memoryValues.Add(new MemoryValue("Challenge - Scorpio - Times Completed", 0x001e3016, "Int8", "Challenges - Sarathos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Scorpio - Stars", 0x001e3017, "Int8", "Challenges - Sarathos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Mining Facility - Times Completed", 0x001e3018, "Int8", "Challenges - Sarathos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Mining Facility - Stars", 0x001e3019, "Int8", "Challenges - Sarathos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - King of Leviathans - Times Completed", 0x001e301a, "Int8", "Challenges - Sarathos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - King of Leviathans - Stars", 0x001e301b, "Int8", "Challenges - Sarathos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Alien Soil - Times Completed", 0x001e301c, "Int8", "Challenges - Sarathos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Alien Soil - Stars", 0x001e301d, "Int8", "Challenges - Sarathos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Node Overload - Times Completed", 0x001e301e, "Int8", "Challenges - Sarathos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Node Overload - Stars", 0x001e301f, "Int8", "Challenges - Sarathos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Sarathos Survival - Times Completed", 0x001e3020, "Int8", "Challenges - Sarathos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Sarathos Survival - Stars", 0x001e3021, "Int8", "Challenges - Sarathos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Where the Dead Sleep - Times Completed", 0x001e3022, "Int8", "Challenges - Sarathos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Where the Dead Sleep - Stars", 0x001e3023, "Int8", "Challenges - Sarathos", "Stars awarded (0-5)"));

            // Challenge Completion - Kronos
            memoryValues.Add(new MemoryValue("Challenge - Infiltrate Cathedral - Times Completed", 0x001e3024, "Int8", "Challenges - Kronos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Infiltrate Cathedral - Stars", 0x001e3025, "Int8", "Challenges - Kronos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Lost and Found - Times Completed", 0x001e3026, "Int8", "Challenges - Kronos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Lost and Found - Stars", 0x001e3027, "Int8", "Challenges - Kronos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Path of Death - Times Completed", 0x001e3028, "Int8", "Challenges - Kronos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Path of Death - Stars", 0x001e3029, "Int8", "Challenges - Kronos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Dark Cathedral - Times Completed", 0x001e302a, "Int8", "Challenges - Kronos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Dark Cathedral - Stars", 0x001e302b, "Int8", "Challenges - Kronos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Temple of Shaar - Times Completed", 0x001e302c, "Int8", "Challenges - Kronos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Temple of Shaar - Stars", 0x001e302d, "Int8", "Challenges - Kronos", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Chains of Villainy - Times Completed", 0x001e302e, "Int8", "Challenges - Kronos", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Chains of Villainy - Stars", 0x001e302f, "Int8", "Challenges - Kronos", "Stars awarded (0-5)"));

            // Challenge Completion - Shaar
            memoryValues.Add(new MemoryValue("Challenge - Alien Battle - Times Completed", 0x001e3030, "Int8", "Challenges - Shaar", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Alien Battle - Stars", 0x001e3031, "Int8", "Challenges - Shaar", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Tremor Smash - Times Completed", 0x001e3032, "Int8", "Challenges - Shaar", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Tremor Smash - Stars", 0x001e3033, "Int8", "Challenges - Shaar", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Moon Landing - Times Completed", 0x001e3034, "Int8", "Challenges - Shaar", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Moon Landing - Stars", 0x001e3035, "Int8", "Challenges - Shaar", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Air Drop - Times Completed", 0x001e3036, "Int8", "Challenges - Shaar", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Air Drop - Stars", 0x001e3037, "Int8", "Challenges - Shaar", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - End Zone - Times Completed", 0x001e3038, "Int8", "Challenges - Shaar", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - End Zone - Stars", 0x001e3039, "Int8", "Challenges - Shaar", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Grinding (Shaar) - Times Completed", 0x001e303a, "Int8", "Challenges - Shaar", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Grinding (Shaar) - Stars", 0x001e303b, "Int8", "Challenges - Shaar", "Stars awarded (0-5)"));

            // Challenge Completion - Orxon
            memoryValues.Add(new MemoryValue("Challenge - Prison Break - Times Completed", 0x001e303c, "Int8", "Challenges - Orxon", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Prison Break - Stars", 0x001e303d, "Int8", "Challenges - Orxon", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Refinery Ambush - Times Completed", 0x001e303e, "Int8", "Challenges - Orxon", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Refinery Ambush - Stars", 0x001e303f, "Int8", "Challenges - Orxon", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Defend - Times Completed", 0x001e3040, "Int8", "Challenges - Orxon", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Defend - Stars", 0x001e3041, "Int8", "Challenges - Orxon", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - The Bomb - Times Completed", 0x001e3042, "Int8", "Challenges - Orxon", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - The Bomb - Stars", 0x001e3043, "Int8", "Challenges - Orxon", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Gas Attack - Times Completed", 0x001e3044, "Int8", "Challenges - Orxon", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Gas Attack - Stars", 0x001e3045, "Int8", "Challenges - Orxon", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Landstalker Chase - Times Completed", 0x001e3046, "Int8", "Challenges - Orxon", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Landstalker Chase - Stars", 0x001e3047, "Int8", "Challenges - Orxon", "Stars awarded (0-5)"));

            // Challenge Completion - Valix Belt
            memoryValues.Add(new MemoryValue("Challenge - One Giant Step - Times Completed", 0x001e3048, "Int8", "Challenges - Valix", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - One Giant Step - Stars", 0x001e3049, "Int8", "Challenges - Valix", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Escape - Times Completed", 0x001e304a, "Int8", "Challenges - Valix", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Escape - Stars", 0x001e304b, "Int8", "Challenges - Valix", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - The Long Walk - Times Completed", 0x001e304c, "Int8", "Challenges - Valix", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - The Long Walk - Stars", 0x001e304d, "Int8", "Challenges - Valix", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Space Ace - Times Completed", 0x001e304e, "Int8", "Challenges - Valix", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Space Ace - Stars", 0x001e304f, "Int8", "Challenges - Valix", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Mining (Valix) - Times Completed", 0x001e3050, "Int8", "Challenges - Valix", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Mining (Valix) - Stars", 0x001e3051, "Int8", "Challenges - Valix", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Advanced Qualifier - Times Completed", 0x001e3052, "Int8", "Challenges - Valix", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Advanced Qualifier - Stars", 0x001e3053, "Int8", "Challenges - Valix", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Asteroid Attack - Times Completed", 0x001e3054, "Int8", "Challenges - Valix", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Asteroid Attack - Stars", 0x001e3055, "Int8", "Challenges - Valix", "Stars awarded (0-5)"));

            // Challenge Completion - Torval
            memoryValues.Add(new MemoryValue("Challenge - Cold Storage - Times Completed", 0x001e3056, "Int8", "Challenges - Torval", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Cold Storage - Stars", 0x001e3057, "Int8", "Challenges - Torval", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Grinding (Torval) - Times Completed", 0x001e3058, "Int8", "Challenges - Torval", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Grinding (Torval) - Stars", 0x001e3059, "Int8", "Challenges - Torval", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Construction Site - Times Completed", 0x001e305a, "Int8", "Challenges - Torval", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Construction Site - Stars", 0x001e305b, "Int8", "Challenges - Torval", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Ice Cube - Times Completed", 0x001e305c, "Int8", "Challenges - Torval", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Ice Cube - Stars", 0x001e305d, "Int8", "Challenges - Torval", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Field Trip - Times Completed", 0x001e305e, "Int8", "Challenges - Torval", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Field Trip - Stars", 0x001e305f, "Int8", "Challenges - Torval", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Factory Smash - Times Completed", 0x001e3060, "Int8", "Challenges - Torval", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Factory Smash - Stars", 0x001e3061, "Int8", "Challenges - Torval", "Stars awarded (0-5)"));

            // Challenge Completion - Stygia
            memoryValues.Add(new MemoryValue("Challenge - Industrial Mine - Times Completed", 0x001e3062, "Int8", "Challenges - Stygia", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Industrial Mine - Stars", 0x001e3063, "Int8", "Challenges - Stygia", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Breath of Fire - Times Completed", 0x001e3064, "Int8", "Challenges - Stygia", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Breath of Fire - Stars", 0x001e3065, "Int8", "Challenges - Stygia", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Tunnel Drop - Times Completed", 0x001e3066, "Int8", "Challenges - Stygia", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Tunnel Drop - Stars", 0x001e3067, "Int8", "Challenges - Stygia", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Lava Climbing - Times Completed", 0x001e3068, "Int8", "Challenges - Stygia", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Lava Climbing - Stars", 0x001e3069, "Int8", "Challenges - Stygia", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - The Crucible - Times Completed", 0x001e306a, "Int8", "Challenges - Stygia", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - The Crucible - Stars", 0x001e306b, "Int8", "Challenges - Stygia", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Fighting Fire - Times Completed", 0x001e306c, "Int8", "Challenges - Stygia", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Fighting Fire - Stars", 0x001e306d, "Int8", "Challenges - Stygia", "Stars awarded (0-5)"));

            // Challenge Completion - Maraxus
            memoryValues.Add(new MemoryValue("Challenge - Sarathos Safari - Times Completed", 0x001e306e, "Int8", "Challenges - Maraxus", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Sarathos Safari - Stars", 0x001e306f, "Int8", "Challenges - Maraxus", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Frozen Tundra - Times Completed", 0x001e3070, "Int8", "Challenges - Maraxus", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Frozen Tundra - Stars", 0x001e3071, "Int8", "Challenges - Maraxus", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Jail Break - Times Completed", 0x001e3072, "Int8", "Challenges - Maraxus", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Jail Break - Stars", 0x001e3073, "Int8", "Challenges - Maraxus", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Prison Cell - Times Completed", 0x001e3074, "Int8", "Challenges - Maraxus", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Prison Cell - Stars", 0x001e3075, "Int8", "Challenges - Maraxus", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Reactor - Times Completed", 0x001e3076, "Int8", "Challenges - Maraxus", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Reactor - Stars", 0x001e3077, "Int8", "Challenges - Maraxus", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Last Stand - Times Completed", 0x001e3078, "Int8", "Challenges - Maraxus", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Last Stand - Stars", 0x001e3079, "Int8", "Challenges - Maraxus", "Stars awarded (0-5)"));

            // Challenge Completion - Ghost Station
            memoryValues.Add(new MemoryValue("Challenge - Hero Smash - Times Completed", 0x001e307a, "Int8", "Challenges - Ghost Station", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Hero Smash - Stars", 0x001e307b, "Int8", "Challenges - Ghost Station", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Prison Planet - Times Completed", 0x001e307c, "Int8", "Challenges - Ghost Station", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Prison Planet - Stars", 0x001e307d, "Int8", "Challenges - Ghost Station", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Haunted - Times Completed", 0x001e307e, "Int8", "Challenges - Ghost Station", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Haunted - Stars", 0x001e307f, "Int8", "Challenges - Ghost Station", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Escape Station - Times Completed", 0x001e3080, "Int8", "Challenges - Ghost Station", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Escape Station - Stars", 0x001e3081, "Int8", "Challenges - Ghost Station", "Stars awarded (0-5)"));
            memoryValues.Add(new MemoryValue("Challenge - Final Showdown - Times Completed", 0x001e3082, "Int8", "Challenges - Ghost Station", "Times completed"));
            memoryValues.Add(new MemoryValue("Challenge - Final Showdown - Stars", 0x001e3083, "Int8", "Challenges - Ghost Station", "Stars awarded (0-5)"));

            // Current Challenge ID
            memoryValues.Add(new MemoryValue("Current Challenge ID", 0x001e3084, "Int8", "Game State", "Currently active challenge",
@"0x00 = None
0x01 = Grist for the Mill (DreadZone Station)
0x02 = Sparring (DreadZone Station)
0x03 = Landstalker Qualifying (DreadZone Station)
0x04 = Hovership Qualifying (DreadZone Station)
0x05 = On the Prowl (DreadZone Station)
0x06 = Rise Up (Catacrom Four)
0x07 = Labyrinth of Death (Catacrom Four)
0x08 = Zombie Attack (Catacrom Four)
0x09 = All Aboard (Catacrom Four)
0x0a = Tower of Power (Catacrom Four)
0x0b = Energy Collector (Catacrom Four)
0x0c = Scorpio (Sarathos)
0x0d = Mining Facility (Sarathos)
0x0e = King of Leviathans (Sarathos)
0x0f = Alien Soil (Sarathos)
0x10 = Node Overload (Sarathos)
0x11 = Sarathos Survival (Sarathos)
0x12 = Where the Dead Sleep (Sarathos)
0x13 = Infiltrate Cathedral (Kronos)
0x14 = Lost and Found (Kronos)
0x15 = Path of Death (Kronos)
0x16 = Dark Cathedral (Kronos)
0x17 = Temple of Shaar (Kronos)
0x18 = Chains of Villainy (Kronos)
0x19 = Alien Battle (Shaar)
0x1a = Tremor Smash (Shaar)
0x1b = Moon Landing (Shaar)
0x1c = Air Drop (Shaar)
0x1d = End Zone (Shaar)
0x1e = Grinding (Shaar)
0x1f = Prison Break (Orxon)
0x20 = Refinery Ambush (Orxon)
0x21 = Defend (Orxon)
0x22 = The Bomb (Orxon)
0x23 = Gas Attack (Orxon)
0x24 = Landstalker Chase (Orxon)
0x25 = One Giant Step (Valix Belt)
0x26 = Escape (Valix Belt)
0x27 = The Long Walk (Valix Belt)
0x28 = Space Ace (Valix Belt)
0x29 = Mining (Valix Belt)
0x2a = Advanced Qualifier (Valix Belt)
0x2b = Asteroid Attack (Valix Belt)
0x2c = Cold Storage (Torval)
0x2d = Grinding (Torval)
0x2e = Construction Site (Torval)
0x2f = Ice Cube (Torval)
0x30 = Field Trip (Torval)
0x31 = Factory Smash (Torval)
0x32 = Industrial Mine (Stygia)
0x33 = Breath of Fire (Stygia)
0x34 = Tunnel Drop (Stygia)
0x35 = Lava Climbing (Stygia)
0x36 = The Crucible (Stygia)
0x37 = Fighting Fire with Fire (Stygia)
0x38 = Sarathos Safari (Maraxus)
0x39 = Frozen Tundra (Maraxus)
0x3a = Jail Break (Maraxus)
0x3b = Prison Cell (Maraxus)
0x3c = Reactor (Maraxus)
0x3d = Last Stand (Maraxus)
0x3e = Hero Smash (Ghost Station)
0x3f = Prison Planet (Ghost Station)
0x40 = Haunted (Ghost Station)
0x41 = Escape the Station (Ghost Station)
0x42 = The Final Showdown (Ghost Station)"));

            // Cheat Status
            memoryValues.Add(new MemoryValue("Cheat Status", 0x001e3088, "Int16", "Cheats", "Currently active cheats (bitfield)",
@"bit0 = Ninja Ratchet (must have DL skin)
bit1 = Mr. Sunshine (must have Elite skin)
bit2 = Snow Dan (must have Dan Johnson skin)
bit3 = King Claude (must have Clank skin)
bit4 = W3RM (must have Renegade skin)
bit5 = Muscles (must have Hotshot skin)

Cheats only work after activating via vendor."));
            memoryValues.Add(new MemoryValue("Permanent Cheat Flags", 0x001e308a, "Int16", "Cheats", "Permanently unlocked cheats (bitfield)",
@"bit0 = Ninja Ratchet
bit1 = Mr. Sunshine
bit2 = Snow Dan
bit3 = King Claude
bit4 = W3RM
bit5 = Muscles

Once unlocked, these remain available permanently."));

            // Exterminator Trading Cards
            memoryValues.Add(new MemoryValue("Trading Cards Collected", 0x001e308c, "Int32", "Trading Cards", "Bitfield of collected trading cards",
@"bit0 = Card 1 (Shellshock)
bit1 = Card 2 (Reactor)
bit2 = Card 3 (Eviscerator)
bit3 = Card 4 (Ace Hardlight)
bit4 = Card 5 (Vox)
bit5 = Card 6 (Gleeman Vox)
bit6 = Card 7 (Juanita)
bit7 = Card 8 (Dallas)
bit8 = Card 9 (Green)
bit9 = Card 10 (Merc)
bit10 = Card 11 (Clank)
bit11 = Card 12 (Ratchet)
bit12 = Card 13 (Al)
bit13 = Card 14 (Team Darkstar)
bit14 = Card 15 (Vernon)"));

            // Weapon Shots Fired Statistics
            memoryValues.Add(new MemoryValue("Shots Fired - Dual Vipers", 0x001e3090, "Int32", "Weapon Stats", "Total shots fired with Dual Vipers"));
            memoryValues.Add(new MemoryValue("Shots Fired - Magma Cannon", 0x001e3094, "Int32", "Weapon Stats", "Total shots fired with Magma Cannon"));
            memoryValues.Add(new MemoryValue("Shots Fired - Arbiter", 0x001e3098, "Int32", "Weapon Stats", "Total shots fired with Arbiter"));
            memoryValues.Add(new MemoryValue("Shots Fired - Fusion Rifle", 0x001e309c, "Int32", "Weapon Stats", "Total shots fired with Fusion Rifle"));
            memoryValues.Add(new MemoryValue("Shots Fired - Mini Turret", 0x001e30a0, "Int32", "Weapon Stats", "Total shots fired with Mini Turret Launcher"));
            memoryValues.Add(new MemoryValue("Shots Fired - B6 Obliterator", 0x001e30a4, "Int32", "Weapon Stats", "Total shots fired with B6 Obliterator"));
            memoryValues.Add(new MemoryValue("Shots Fired - Holoshield", 0x001e30a8, "Int32", "Weapon Stats", "Total shots fired with Holoshield Launcher"));
            memoryValues.Add(new MemoryValue("Shots Fired - Hunter Mine", 0x001e30ac, "Int32", "Weapon Stats", "Total shots fired with Hunter Mine Launcher"));
            memoryValues.Add(new MemoryValue("Shots Fired - Scorpion Flail", 0x001e30b0, "Int32", "Weapon Stats", "Total shots fired with Scorpion Flail"));

            // Game Statistics
            memoryValues.Add(new MemoryValue("Challenge Timer", 0x001e30b4, "Int32", "Game Stats", "Current challenge timer (frames)"));
            memoryValues.Add(new MemoryValue("Battledome Wins", 0x001e30b8, "Int16", "Game Stats", "Total battledome wins"));
            memoryValues.Add(new MemoryValue("Battledome Losses", 0x001e30ba, "Int16", "Game Stats", "Total battledome losses"));

            return memoryValues;
        }
    }
}
