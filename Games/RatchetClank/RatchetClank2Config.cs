using Common;
using System.Collections.Generic;

namespace Games.RatchetClank
{
    public class RatchetClank2Config : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank: Going Commando (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // ==================== INPUT ====================
            memoryValues.Add(new MemoryValue("Controller Input", 0x00138320, "Int8", "Input", "Controller button bitflags",
@"Bit 7 = Square
Bit 6 = Cross
Bit 5 = Circle
Bit 4 = Triangle"));
            memoryValues.Add(new MemoryValue("2nd Controller Input", 0x001386A1, "Int8", "Input", "2nd controller input (partial)"));

            // ==================== SAVE DATA ====================
            memoryValues.Add(new MemoryValue("Save Slot ID", 0x001393F8, "Int8", "Save Data", "Current save slot ID"));
            memoryValues.Add(new MemoryValue("Loading New Save Flag", 0x00139520, "Int8", "Save Data", "Loading new save flag",
@"5 = Loading a new save
6 = Saving / overwriting save"));

            // ==================== WEAPON UPGRADES ====================
            memoryValues.Add(new MemoryValue("Bomb Glove Version", 0x00139574, "Int8", "Weapon Upgrades", "Bomb Glove upgrade (0x73 = Mega)"));
            memoryValues.Add(new MemoryValue("Visibomb Version", 0x00139576, "Int8", "Weapon Upgrades", "Visibomb upgrade (Mega)"));
            memoryValues.Add(new MemoryValue("Sheepinator Version", 0x00139578, "Int8", "Weapon Upgrades", "Sheepinator upgrade (0x48 = Upgraded)"));
            memoryValues.Add(new MemoryValue("Decoy Glove Version", 0x00139579, "Int8", "Weapon Upgrades", "Decoy Glove upgrade (Mega)"));
            memoryValues.Add(new MemoryValue("Tesla Claw Version", 0x0013957A, "Int8", "Weapon Upgrades", "Tesla Claw upgrade (Mega)"));
            memoryValues.Add(new MemoryValue("Multi-Star Version", 0x0013957E, "Int8", "Weapon Upgrades", "Multi-Star upgrade",
@"0x41 = Upgraded
0x53 = Mega
0x54 = Ultra"));
            memoryValues.Add(new MemoryValue("Pulse Rifle Version", 0x0013957F, "Int8", "Weapon Upgrades", "Pulse Rifle/Sniper upgrade",
@"0x42 = Upgraded
0x57 = Mega"));
            memoryValues.Add(new MemoryValue("Seeker Gun Version", 0x00139580, "Int8", "Weapon Upgrades", "Seeker Gun upgrade",
@"0x43 = Upgraded
0x55 = Mega
0x56 = Ultra"));
            memoryValues.Add(new MemoryValue("Tetrabomb Version", 0x00139581, "Int8", "Weapon Upgrades", "Tetrabomb upgrade",
@"0x46 = Upgraded
0x67 = Mega
0x68 = Ultra"));
            memoryValues.Add(new MemoryValue("Blitz Gun Version", 0x00139582, "Int8", "Weapon Upgrades", "Blitz Gun upgrade",
@"0x1A = Normal
0x44 = Upgraded
0x5B = Mega"));
            memoryValues.Add(new MemoryValue("Rocket Launcher Version", 0x00139583, "Int8", "Weapon Upgrades", "Rocket Launcher upgrade",
@"0x45 = Upgraded
0x63 = Mega"));
            memoryValues.Add(new MemoryValue("Plasma Storm Version", 0x00139584, "Int8", "Weapon Upgrades", "Plasma Storm upgrade",
@"0x3E = Upgraded
0x65 = Mega"));
            memoryValues.Add(new MemoryValue("Meteor Gun Version", 0x00139585, "Int8", "Weapon Upgrades", "Meteor Gun (Lava Gun) upgrade",
@"0x3F = Upgraded
0x5F = Mega"));
            memoryValues.Add(new MemoryValue("Heavy Lancer Version", 0x00139586, "Int8", "Weapon Upgrades", "Heavy Lancer upgrade",
@"0x3C = Upgraded
0x4F = Mega
0x50 = Ultra"));
            memoryValues.Add(new MemoryValue("Kilonoid Version", 0x00139587, "Int8", "Weapon Upgrades", "Kilonoid (Synthenoid) upgrade",
@"0x3D = Upgraded
0x5D = Mega"));
            memoryValues.Add(new MemoryValue("Spiderbot Version", 0x00139588, "Int8", "Weapon Upgrades", "Spiderbot upgrade",
@"0x4E = Upgraded
0x69 = Mega"));
            memoryValues.Add(new MemoryValue("Bouncer Version", 0x0013958D, "Int8", "Weapon Upgrades", "Bouncer upgrade",
@"0x4C = Upgraded
0x61 = Mega"));
            memoryValues.Add(new MemoryValue("Miniturret Version", 0x00139591, "Int8", "Weapon Upgrades", "Miniturret upgrade",
@"0x40 = Upgraded
0x59 = Mega"));
            memoryValues.Add(new MemoryValue("Mini Nuke Version", 0x00139592, "Int8", "Weapon Upgrades", "Mini Nuke upgrade",
@"0x47 = Upgraded
0x51 = Mega"));
            memoryValues.Add(new MemoryValue("Tesla Barrier Version", 0x00139595, "Int8", "Weapon Upgrades", "Tesla Barrier (Shield Charger) upgrade",
@"0x4D = Upgraded
0x6B = Mega"));
            memoryValues.Add(new MemoryValue("Walloper Version", 0x0013959D, "Int8", "Weapon Upgrades", "Walloper upgrade (0x74 = Mega)"));

            // ==================== MAKTAR ARENA ====================
            memoryValues.Add(new MemoryValue("Maktar Mission Flag 1", 0x001395B9, "Int8", "Maktar Arena", "Maktar mission flag"));
            memoryValues.Add(new MemoryValue("Maktar Mission Flag 2", 0x001395BB, "Int8", "Maktar Arena", "Maktar mission flag"));
            memoryValues.Add(new MemoryValue("Arena - Electrolyzer Wins", 0x001395E9, "Int8", "Maktar Arena", "Battle for Electrolyzer wins"));
            memoryValues.Add(new MemoryValue("Arena - Chainblade Wins", 0x001395EA, "Int8", "Maktar Arena", "Chainblade Challenge wins"));
            memoryValues.Add(new MemoryValue("Arena - Kill 30 in 30 Wins", 0x001395EB, "Int8", "Maktar Arena", "Time Challenge: Kill 30 enemies in 30 seconds wins"));
            memoryValues.Add(new MemoryValue("Arena - Hazard Challenge Wins", 0x001395EC, "Int8", "Maktar Arena", "Hazard Challenge wins"));
            memoryValues.Add(new MemoryValue("Arena - Ultimate Challenge Wins", 0x001395F3, "Int8", "Maktar Arena", "Ultimate Challenge wins"));
            memoryValues.Add(new MemoryValue("Arena - NG+ Avoidance Wins", 0x0013964A, "Int8", "Maktar Arena", "NG+ Timed avoidance: Dodge chainblade for 2 minutes wins"));
            memoryValues.Add(new MemoryValue("Arena - NG+ Wrench Only Wins", 0x0013964B, "Int8", "Maktar Arena", "NG+ Wrench only and don't take a hit wins"));

            // ==================== MEGACORP GAMES ====================
            memoryValues.Add(new MemoryValue("Megacorp Games - Challenge 1", 0x00139600, "Int8", "Megacorp Games", "First challenger challenge"));
            memoryValues.Add(new MemoryValue("Megacorp Games - Challenge 2", 0x00139603, "Int8", "Megacorp Games", "Second challenger challenge"));

            // ==================== PLATINUM BOLTS ====================
            memoryValues.Add(new MemoryValue("Platinum Bolts Spent", 0x00139648, "Int8", "Platinum Bolts", "Platinum bolts spent at mods"));
            // Oozla
            memoryValues.Add(new MemoryValue("PB - Oozla 1", 0x0019B27D, "Int8", "Platinum Bolts", "Oozla Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Oozla 2", 0x0019B27E, "Int8", "Platinum Bolts", "Oozla Platinum Bolt 2"));
            // Maktar
            memoryValues.Add(new MemoryValue("PB - Maktar Casino", 0x0019B281, "Int8", "Platinum Bolts", "Maktar Casino Platinum Bolt"));
            memoryValues.Add(new MemoryValue("PB - Maktar Array", 0x0019B2E1, "Int8", "Platinum Bolts", "Maktar Array Platinum Bolt"));
            // Endako
            memoryValues.Add(new MemoryValue("PB - Endako 1", 0x0019B285, "Int8", "Platinum Bolts", "Endako Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Endako 2", 0x0019B287, "Int8", "Platinum Bolts", "Endako Platinum Bolt 2"));
            // Barlow
            memoryValues.Add(new MemoryValue("PB - Barlow 1", 0x0019B288, "Int8", "Platinum Bolts", "Barlow Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Barlow 2", 0x0019B289, "Int8", "Platinum Bolts", "Barlow Platinum Bolt 2"));
            // Feltzin System
            memoryValues.Add(new MemoryValue("PB - Feltzin System", 0x0019B28C, "Int8", "Platinum Bolts", "Feltzin System Platinum Bolt"));
            // Notak
            memoryValues.Add(new MemoryValue("PB - Notak 1", 0x0019B290, "Int8", "Platinum Bolts", "Notak Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Notak 2", 0x0019B291, "Int8", "Platinum Bolts", "Notak Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Notak 3", 0x0019B292, "Int8", "Platinum Bolts", "Notak Platinum Bolt 3"));
            // Siberius
            memoryValues.Add(new MemoryValue("PB - Siberius 1", 0x0019B294, "Int8", "Platinum Bolts", "Siberius Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Siberius 2", 0x0019B295, "Int8", "Platinum Bolts", "Siberius Platinum Bolt 2"));
            // Tabora
            memoryValues.Add(new MemoryValue("PB - Tabora 1", 0x0019B298, "Int8", "Platinum Bolts", "Tabora Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Tabora 2", 0x0019B299, "Int8", "Platinum Bolts", "Tabora Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Tabora 3", 0x0019B29A, "Int8", "Platinum Bolts", "Tabora Platinum Bolt 3"));
            // Dobbo
            memoryValues.Add(new MemoryValue("PB - Dobbo 1", 0x0019B29C, "Int8", "Platinum Bolts", "Dobbo Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Dobbo 2", 0x0019B29D, "Int8", "Platinum Bolts", "Dobbo Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Dobbo 3", 0x0019B29F, "Int8", "Platinum Bolts", "Dobbo Platinum Bolt 3"));
            // Hrugis Cloud
            memoryValues.Add(new MemoryValue("PB - Hrugis Cloud", 0x0019B2A0, "Int8", "Platinum Bolts", "Hrugis Cloud Platinum Bolt"));
            // Joba
            memoryValues.Add(new MemoryValue("PB - Joba 1", 0x0019B2A4, "Int8", "Platinum Bolts", "Joba Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Joba 2", 0x0019B2A5, "Int8", "Platinum Bolts", "Joba Platinum Bolt 2"));
            // Todano
            memoryValues.Add(new MemoryValue("PB - Todano 1", 0x0019B2A8, "Int8", "Platinum Bolts", "Todano Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Todano 2", 0x0019B2A9, "Int8", "Platinum Bolts", "Todano Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Todano 3", 0x0019B2AA, "Int8", "Platinum Bolts", "Todano Platinum Bolt 3"));
            // Boldan
            memoryValues.Add(new MemoryValue("PB - Boldan 1", 0x0019B2AC, "Int8", "Platinum Bolts", "Boldan Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Boldan 2", 0x0019B2AD, "Int8", "Platinum Bolts", "Boldan Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Boldan 3", 0x0019B2AF, "Int8", "Platinum Bolts", "Boldan Platinum Bolt 3"));
            // Aranos
            memoryValues.Add(new MemoryValue("PB - Aranos", 0x0019B2B0, "Int8", "Platinum Bolts", "Aranos Platinum Bolt"));
            // Gorn
            memoryValues.Add(new MemoryValue("PB - Gorn", 0x0019B2B4, "Int8", "Platinum Bolts", "Gorn Platinum Bolt"));
            // Snivelak
            memoryValues.Add(new MemoryValue("PB - Snivelak", 0x0019B2B8, "Int8", "Platinum Bolts", "Snivelak Platinum Bolt"));
            // Smolg
            memoryValues.Add(new MemoryValue("PB - Smolg 1", 0x0019B2BD, "Int8", "Platinum Bolts", "Smolg Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Smolg 2", 0x0019B2BE, "Int8", "Platinum Bolts", "Smolg Platinum Bolt 2"));
            // Damosel
            memoryValues.Add(new MemoryValue("PB - Damosel 1", 0x0019B2C0, "Int8", "Platinum Bolts", "Damosel Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Damosel 2", 0x0019B2C1, "Int8", "Platinum Bolts", "Damosel Platinum Bolt 2"));
            // Grelbin
            memoryValues.Add(new MemoryValue("PB - Grelbin 1", 0x0019B2C5, "Int8", "Platinum Bolts", "Grelbin Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Grelbin 2", 0x0019B2C6, "Int8", "Platinum Bolts", "Grelbin Platinum Bolt 2"));
            memoryValues.Add(new MemoryValue("PB - Grelbin 3", 0x0019B2C7, "Int8", "Platinum Bolts", "Grelbin Platinum Bolt 3"));
            // Yeedil
            memoryValues.Add(new MemoryValue("PB - Yeedil 1", 0x0019B2C9, "Int8", "Platinum Bolts", "Yeedil Platinum Bolt 1"));
            memoryValues.Add(new MemoryValue("PB - Yeedil 2", 0x0019B2CA, "Int8", "Platinum Bolts", "Yeedil Platinum Bolt 2"));

            // ==================== WEAPON AMMO ====================
            memoryValues.Add(new MemoryValue("Bomb Glove Ammo", 0x001396B8, "Int32", "Weapon Ammo", "Bomb Glove current ammo"));
            memoryValues.Add(new MemoryValue("Visibomb Gun Ammo", 0x001396C0, "Int32", "Weapon Ammo", "Visibomb Gun current ammo"));
            memoryValues.Add(new MemoryValue("Decoy Glove Ammo", 0x001396CC, "Int32", "Weapon Ammo", "Decoy Glove current ammo"));
            memoryValues.Add(new MemoryValue("Tesla Claw Ammo", 0x001396D0, "Int32", "Weapon Ammo", "Tesla Claw current ammo"));
            memoryValues.Add(new MemoryValue("Chopper Ammo", 0x001396E0, "Int32", "Weapon Ammo", "Chopper current ammo"));
            memoryValues.Add(new MemoryValue("Pulse Rifle Ammo", 0x001396E4, "Int32", "Weapon Ammo", "Pulse Rifle current ammo"));
            memoryValues.Add(new MemoryValue("HK22 Gun Ammo", 0x001396E8, "Int32", "Weapon Ammo", "HK22 Gun current ammo"));
            memoryValues.Add(new MemoryValue("Hoverbomb Gun Ammo", 0x001396EC, "Int32", "Weapon Ammo", "Hoverbomb Gun current ammo"));
            memoryValues.Add(new MemoryValue("Blitz Gun Ammo", 0x001396F0, "Int32", "Weapon Ammo", "Blitz Gun current ammo"));
            memoryValues.Add(new MemoryValue("Megarocket Cannon Ammo", 0x001396F4, "Int32", "Weapon Ammo", "Megarocket Cannon current ammo"));
            memoryValues.Add(new MemoryValue("Plasma Storm Ammo", 0x001396F8, "Int32", "Weapon Ammo", "Plasma Storm current ammo"));
            memoryValues.Add(new MemoryValue("Meteor Gun Ammo", 0x001396FC, "Int32", "Weapon Ammo", "Meteor Gun (Lava Gun) current ammo"));
            memoryValues.Add(new MemoryValue("Lancer Ammo", 0x00139700, "Int32", "Weapon Ammo", "Lancer current ammo"));
            memoryValues.Add(new MemoryValue("Synthenoid Ammo", 0x00139704, "Int32", "Weapon Ammo", "Synthenoid current ammo"));
            memoryValues.Add(new MemoryValue("Spiderbot Ammo", 0x00139708, "Int32", "Weapon Ammo", "Spiderbot current ammo"));
            memoryValues.Add(new MemoryValue("Miniturret Ammo", 0x0013972C, "Int32", "Weapon Ammo", "Miniturret Gun current ammo"));
            memoryValues.Add(new MemoryValue("Gravity Bomb Ammo", 0x00139730, "Int32", "Weapon Ammo", "Gravity Bomb current ammo"));
            memoryValues.Add(new MemoryValue("RYNO II Ammo", 0x00139738, "Int32", "Weapon Ammo", "RYNO II current ammo"));
            memoryValues.Add(new MemoryValue("Shield Charger Ammo", 0x0013973C, "Int32", "Weapon Ammo", "Shield Charger current ammo"));

            // ==================== WEAPON XP ====================
            memoryValues.Add(new MemoryValue("HK22 XP", 0x001398C8, "Int32", "Weapon XP", "HK22 Gun experience"));

            // ==================== GAME STATE ====================
            memoryValues.Add(new MemoryValue("Map ID Array", 0x00139948, "Int8", "Game State", "Map ID array (80 bytes) - auto-fills based on planet discovery order"));
            memoryValues.Add(new MemoryValue("Oozla Mission", 0x00139A64, "Int32", "Game State", "Oozla mission progress"));
            memoryValues.Add(new MemoryValue("Map ID", 0x001507E0, "Int8", "Game State", "Current map ID"));
            memoryValues.Add(new MemoryValue("In-Gameplay Flag", 0x00152CDC, "Int32", "Game State", "In-gameplay state",
@"0xFFFFFFFF = In-gameplay
0x00 = In main menus"));
            memoryValues.Add(new MemoryValue("Final Boss Defeats", 0x0018860C, "Int8", "Game State", "How many times final boss is defeated"));

            // ==================== PLAYER STATE ====================
            memoryValues.Add(new MemoryValue("Wrench Thrown Flag", 0x0018B05C, "Int8", "Player State", "Wrench thrown flag"));
            memoryValues.Add(new MemoryValue("Current Equipped Weapon ID", 0x0018B068, "Int8", "Player State", "Current equipped weapon ID"));
            memoryValues.Add(new MemoryValue("Ratchet State", 0x0018C0B4, "Int8", "Player State", "Ratchet's current state"));
            memoryValues.Add(new MemoryValue("Ratchet Jumping Flag", 0x0018C2C0, "Int8", "Player State", "Ratchet jumping flag",
@"0 = On ground
5 = In air"));
            memoryValues.Add(new MemoryValue("Ratchet Health", 0x0018C2EC, "Int8", "Player Stats", "Ratchet's current health"));
            memoryValues.Add(new MemoryValue("Total Wrench Swings", 0x0018C3D8, "Int32", "Player Stats", "Total wrench swings"));
            memoryValues.Add(new MemoryValue("Total Wrench Throws", 0x0018C600, "Int32", "Player Stats", "Total wrench throws"));
            memoryValues.Add(new MemoryValue("Total Deaths", 0x001A73D8, "Int32", "Player Stats", "Total deaths"));
            memoryValues.Add(new MemoryValue("First Person Flag", 0x001A790C, "Int8", "Player State", "First person mode flag"));

            // ==================== MAP/PLANET ID ====================
            memoryValues.Add(new MemoryValue("Planet ID", 0x001A79F8, "Int8", "Game State", "Current planet/map ID",
@"0x00 = Aranos (First Visit)
0x01 = Oozla
0x02 = Maktar
0x03 = Endako
0x04 = Barlow
0x05 = Ship Challenge
0x06 = Notak
0x07 = Siberius
0x08 = Tabora
0x09 = Dobbo
0x0A = Ship Challenge
0x0C = Todano
0x0D = Boldan
0x0E = Aranos
0x0F = Ship Challenge
0x10 = Snivelak
0x11 = Smolg
0x12 = Damosel
0x13 = Grelbin
0x14 = Yeedil
0x19 = Ship Challenge"));

            // ==================== CURRENCY & RESOURCES ====================
            memoryValues.Add(new MemoryValue("Raritanium", 0x001A79FC, "Int32", "Currency", "Raritanium amount"));
            memoryValues.Add(new MemoryValue("Bolts", 0x001A7A00, "Int32", "Currency", "Current bolts"));
            memoryValues.Add(new MemoryValue("Maximum HP", 0x001A7A08, "Int8", "Player Stats", "Maximum health"));
            memoryValues.Add(new MemoryValue("Challenger Mode Flag", 0x001A7A12, "Int8", "Game State", "Challenger mode active"));
            memoryValues.Add(new MemoryValue("HP XP", 0x001A7A14, "Int32", "Player Stats", "Ratchet's HP experience"));
            memoryValues.Add(new MemoryValue("Current Armor", 0x001A7A20, "Int8", "Player Stats", "Current armor equipped",
@"0 = Standard
1 = Tetrafiber (first upgrade)
2 = Duraplate (second upgrade)
3 = Electrosteel (third upgrade)
4 = Carbonox (last upgrade)"));
            memoryValues.Add(new MemoryValue("Moonstones", 0x001A7A24, "Int32", "Currency", "Moonstone count"));
            memoryValues.Add(new MemoryValue("Nanotech Upgrade", 0x001A7A32, "Int8", "Player Stats", "Nanotech upgrade level"));
            memoryValues.Add(new MemoryValue("Bolts Multiplier", 0x001A7A3A, "Int8", "Currency", "Bolts multiplier"));

            // ==================== CHEATS ====================
            memoryValues.Add(new MemoryValue("Cheat: Big Head Actors", 0x001A7A48, "Int8", "Cheats", "Big Head Actors cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Big Head Ratchet", 0x001A7A49, "Int8", "Cheats", "Big Head Ratchet cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Ratchet Snowman", 0x001A7A4A, "Int8", "Cheats", "Ratchet Snowman cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Big Head Clank", 0x001A7A4B, "Int8", "Cheats", "Big Head Clank cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Mirrored Levels", 0x001A7A4C, "Int8", "Cheats", "Mirrored Levels cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Big Head Enemies", 0x001A7A4F, "Int8", "Cheats", "Big Head Enemies cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Clown Ratchet", 0x001A7A51, "Int8", "Cheats", "Clown Ratchet cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Tux Ratchet", 0x001A7A52, "Int8", "Cheats", "Tux Ratchet cheat"));
            memoryValues.Add(new MemoryValue("Cheat: Ratchet Swimsuit", 0x001A7A53, "Int8", "Cheats", "Ratchet Swimsuit cheat"));

            // ==================== SKILL POINTS ====================
            memoryValues.Add(new MemoryValue("SP - That's Impossible", 0x001A7A68, "Int8", "Skill Points", "That's Impossible skill point"));
            memoryValues.Add(new MemoryValue("SP - Wrench Ninja", 0x001A7A69, "Int8", "Skill Points", "Wrench Ninja skill point"));
            memoryValues.Add(new MemoryValue("SP - Speed Demon", 0x001A7A6A, "Int8", "Skill Points", "Speed Demon skill point"));
            memoryValues.Add(new MemoryValue("SP - How Fast Was That", 0x001A7A6B, "Int8", "Skill Points", "How Fast Was That skill point"));
            memoryValues.Add(new MemoryValue("SP - No Shocking Developments", 0x001A7A6C, "Int8", "Skill Points", "No Shocking Developments skill point"));
            memoryValues.Add(new MemoryValue("SP - Heal Your Chi", 0x001A7A6D, "Int8", "Skill Points", "Heal Your Chi skill point"));
            memoryValues.Add(new MemoryValue("SP - Be a Moon Child", 0x001A7A6E, "Int8", "Skill Points", "Be a Moon Child skill point"));
            memoryValues.Add(new MemoryValue("SP - Midtown Insanity", 0x001A7A6F, "Int8", "Skill Points", "Midtown Insanity skill point"));
            memoryValues.Add(new MemoryValue("SP - Dukes Up", 0x001A7A70, "Int8", "Skill Points", "Dukes Up skill point"));
            memoryValues.Add(new MemoryValue("SP - Nothing to See Here", 0x001A7A71, "Int8", "Skill Points", "Nothing to See Here skill point"));
            memoryValues.Add(new MemoryValue("SP - You're My Hero", 0x001A7A72, "Int8", "Skill Points", "You're My Hero skill point"));
            memoryValues.Add(new MemoryValue("SP - Moving Violation", 0x001A7A73, "Int8", "Skill Points", "Moving Violation skill point"));
            memoryValues.Add(new MemoryValue("SP - Old Skool", 0x001A7A74, "Int8", "Skill Points", "Old Skool skill point"));
            memoryValues.Add(new MemoryValue("SP - Prehistoric Rampage", 0x001A7A75, "Int8", "Skill Points", "Prehistoric Rampage skill point"));
            memoryValues.Add(new MemoryValue("SP - Vandalize", 0x001A7A76, "Int8", "Skill Points", "Vandalize skill point"));
            memoryValues.Add(new MemoryValue("SP - Smash and Grab", 0x001A7A77, "Int8", "Skill Points", "Smash and Grab skill point"));
            memoryValues.Add(new MemoryValue("SP - You Can Break a Snow Den", 0x001A7A78, "Int8", "Skill Points", "You Can Break a Snow Den skill point"));
            memoryValues.Add(new MemoryValue("SP - Planet Buster", 0x001A7A79, "Int8", "Skill Points", "Planet Buster skill point"));
            memoryValues.Add(new MemoryValue("SP - Wrench Ninja 2: Massacre", 0x001A7A7A, "Int8", "Skill Points", "Wrench Ninja 2: Massacre skill point"));
            memoryValues.Add(new MemoryValue("SP - 2B or Not 2B Hit", 0x001A7A7B, "Int8", "Skill Points", "2B or Not 2B Hit skill point"));
            memoryValues.Add(new MemoryValue("SP - Bye Bye Birdies", 0x001A7A7C, "Int8", "Skill Points", "Bye Bye Birdies skill point"));
            memoryValues.Add(new MemoryValue("SP - Destroy All Breakables", 0x001A7A7D, "Int8", "Skill Points", "Destroy All Breakables skill point"));
            memoryValues.Add(new MemoryValue("SP - Try to Sleep", 0x001A7A7E, "Int8", "Skill Points", "Try to Sleep skill point"));
            memoryValues.Add(new MemoryValue("SP - Nano to the Max", 0x001A7A7F, "Int8", "Skill Points", "Nano to the Max skill point"));
            memoryValues.Add(new MemoryValue("SP - Robo Rampage", 0x001A7A80, "Int8", "Skill Points", "Robo Rampage skill point"));
            memoryValues.Add(new MemoryValue("SP - Clank Needs Shoes", 0x001A7A81, "Int8", "Skill Points", "Clank Needs a New Pair of Shoes skill point"));
            memoryValues.Add(new MemoryValue("SP - Weapon Envy", 0x001A7A82, "Int8", "Skill Points", "Weapon Envy skill point"));
            memoryValues.Add(new MemoryValue("SP - Safety Deposit", 0x001A7A83, "Int8", "Skill Points", "Safety Deposit skill point"));
            memoryValues.Add(new MemoryValue("SP - Operate Heavy Machinery", 0x001A7A84, "Int8", "Skill Points", "Operate Heavy Machinery skill point"));
            memoryValues.Add(new MemoryValue("SP - Nice Ride", 0x001A7A85, "Int8", "Skill Points", "Nice Ride skill point"));

            // ==================== WEAPON MODS ====================
            memoryValues.Add(new MemoryValue("Chopper Mods", 0x001A7A9E, "Int8", "Weapon Mods", "Chopper modifications"));
            memoryValues.Add(new MemoryValue("Pulse Rifle Mods", 0x001A7A9F, "Int8", "Weapon Mods", "Pulse Rifle modifications"));
            memoryValues.Add(new MemoryValue("Seeker Gun Mods", 0x001A7AA0, "Int8", "Weapon Mods", "Seeker Gun modifications"));
            memoryValues.Add(new MemoryValue("Hoverbomb Mods", 0x001A7AA1, "Int8", "Weapon Mods", "Hoverbomb Gun modifications"));
            memoryValues.Add(new MemoryValue("Blitz Gun Mods", 0x001A7AA2, "Int8", "Weapon Mods", "Blitz Gun modifications",
@"Lower 4 bits = 0xC = Acid mod on
Upper 4 bits = 0x3 = Lock on mode on"));
            memoryValues.Add(new MemoryValue("Rocket Tube Mods", 0x001A7AA3, "Int8", "Weapon Mods", "Rocket Tube modifications"));
            memoryValues.Add(new MemoryValue("Plasma Coil Mods", 0x001A7AA4, "Int8", "Weapon Mods", "Plasma Coil modifications"));
            memoryValues.Add(new MemoryValue("Lava Gun Mods", 0x001A7AA5, "Int8", "Weapon Mods", "Lava Gun modifications"));
            memoryValues.Add(new MemoryValue("Heavy Lancer Mods", 0x001A7AA6, "Int8", "Weapon Mods", "Heavy Lancer modifications",
@"Lower 4 bits = 0x3 = Acid mod
Upper 4 bits = 0x3 = Lock on mode"));
            memoryValues.Add(new MemoryValue("Spiderbot Mods", 0x001A7AA8, "Int8", "Weapon Mods", "Spiderbot modifications"));
            memoryValues.Add(new MemoryValue("Bouncer Mods", 0x001A7AAD, "Int8", "Weapon Mods", "Bouncer modifications"));
            memoryValues.Add(new MemoryValue("Mini Turret Mods", 0x001A7AB1, "Int8", "Weapon Mods", "Mini Turret modifications"));
            memoryValues.Add(new MemoryValue("Mini Nuke Mods", 0x001A7AB2, "Int8", "Weapon Mods", "Mini Nuke modifications"));
            memoryValues.Add(new MemoryValue("RYNO Mods", 0x001A7AB4, "Int8", "Weapon Mods", "RYNO II modifications"));

            // ==================== GADGET FLAGS ====================
            memoryValues.Add(new MemoryValue("Helipack Flag", 0x001A7B02, "Int8", "Gadget Flags", "Helipack gadget obtained"));
            memoryValues.Add(new MemoryValue("Thrusterpack Flag", 0x001A7B03, "Int8", "Gadget Flags", "Thrusterpack obtained"));
            memoryValues.Add(new MemoryValue("Hydro-pack Flag", 0x001A7B04, "Int8", "Gadget Flags", "Hydro-pack gadget obtained"));
            memoryValues.Add(new MemoryValue("Mapper Flag", 0x001A7B05, "Int8", "Gadget Flags", "Mapper item obtained"));
            memoryValues.Add(new MemoryValue("Standard Commando Suit Flag", 0x001A7B06, "Int8", "Gadget Flags", "Standard Commando Suit obtained"));
            memoryValues.Add(new MemoryValue("Armor Magnetizer Flag", 0x001A7B07, "Int8", "Gadget Flags", "Armor Magnetizer obtained"));
            memoryValues.Add(new MemoryValue("Levitator Flag", 0x001A7B08, "Int8", "Gadget Flags", "Levitator item obtained"));
            memoryValues.Add(new MemoryValue("Clank Zapper Flag", 0x001A7B09, "Int8", "Gadget Flags", "Clank Zapper weapon obtained"));

            // ==================== WEAPON FLAGS ====================
            memoryValues.Add(new MemoryValue("Bomb Glove Flag", 0x001A7B0C, "Int8", "Weapon Flags", "Bomb Glove weapon obtained"));
            memoryValues.Add(new MemoryValue("Swingshot Flag", 0x001A7B0D, "Int8", "Weapon Flags", "Swingshot gadget obtained"));
            memoryValues.Add(new MemoryValue("Visibomb Flag", 0x001A7B0E, "Int8", "Weapon Flags", "Visibomb weapon obtained"));
            memoryValues.Add(new MemoryValue("Sheepinator Flag", 0x001A7B10, "Int8", "Weapon Flags", "Sheepinator weapon obtained"));
            memoryValues.Add(new MemoryValue("Decoy Glove Flag", 0x001A7B11, "Int8", "Weapon Flags", "Decoy Glove weapon obtained"));
            memoryValues.Add(new MemoryValue("Tesla Claw Flag", 0x001A7B12, "Int8", "Weapon Flags", "Tesla Claw unlocked"));
            memoryValues.Add(new MemoryValue("Gravity Boots Flag", 0x001A7B13, "Int8", "Weapon Flags", "Gravity Boots gadget obtained"));
            memoryValues.Add(new MemoryValue("Grindboots Flag", 0x001A7B14, "Int8", "Weapon Flags", "Grindboots gadget obtained"));
            memoryValues.Add(new MemoryValue("Glider Flag", 0x001A7B15, "Int8", "Weapon Flags", "Glider item obtained"));
            memoryValues.Add(new MemoryValue("Chopper Flag", 0x001A7B16, "Int8", "Weapon Flags", "Chopper weapon obtained"));
            memoryValues.Add(new MemoryValue("Pulse Rifle Flag", 0x001A7B17, "Int8", "Weapon Flags", "Pulse Rifle weapon obtained"));
            memoryValues.Add(new MemoryValue("Seeker Gun Flag", 0x001A7B18, "Int8", "Weapon Flags", "Seeker Gun weapon obtained"));
            memoryValues.Add(new MemoryValue("Hoverbomb Gun Flag", 0x001A7B19, "Int8", "Weapon Flags", "Hoverbomb Gun weapon obtained"));
            memoryValues.Add(new MemoryValue("Blitz Cannon Flag", 0x001A7B1A, "Int8", "Weapon Flags", "Blitz Cannon weapon obtained"));
            memoryValues.Add(new MemoryValue("Minirocket Tube Flag", 0x001A7B1B, "Int8", "Weapon Flags", "Minirocket Tube weapon obtained"));
            memoryValues.Add(new MemoryValue("Plasma Coil Flag", 0x001A7B1C, "Int8", "Weapon Flags", "Plasma Coil weapon obtained"));
            memoryValues.Add(new MemoryValue("Lava Gun Flag", 0x001A7B1D, "Int8", "Weapon Flags", "Lava Gun weapon obtained"));
            memoryValues.Add(new MemoryValue("Heavy Lancer Flag", 0x001A7B1E, "Int8", "Weapon Flags", "Heavy Lancer weapon obtained"));
            memoryValues.Add(new MemoryValue("Synthenoid Flag", 0x001A7B1F, "Int8", "Weapon Flags", "Synthenoid weapon obtained"));
            memoryValues.Add(new MemoryValue("Spiderbot Glove Flag", 0x001A7B20, "Int8", "Weapon Flags", "Spiderbot Glove weapon obtained"));
            memoryValues.Add(new MemoryValue("Dynamo Flag", 0x001A7B24, "Int8", "Weapon Flags", "Dynamo gadget obtained (Oozla mission)"));
            memoryValues.Add(new MemoryValue("Bouncer Flag", 0x001A7B25, "Int8", "Weapon Flags", "Bouncer weapon obtained"));
            memoryValues.Add(new MemoryValue("Electrolyzer Flag", 0x001A7B26, "Int8", "Weapon Flags", "Electrolyzer item obtained"));
            memoryValues.Add(new MemoryValue("Thermanator Flag", 0x001A7B27, "Int8", "Weapon Flags", "Thermanator gadget obtained"));
            memoryValues.Add(new MemoryValue("Miniturret Glove Flag", 0x001A7B29, "Int8", "Weapon Flags", "Miniturret Glove weapon obtained"));
            memoryValues.Add(new MemoryValue("Mini-Nuke Flag", 0x001A7B2A, "Int8", "Weapon Flags", "Mini-Nuke weapon obtained"));
            memoryValues.Add(new MemoryValue("Zodiac Flag", 0x001A7B2B, "Int8", "Weapon Flags", "Zodiac weapon obtained"));
            memoryValues.Add(new MemoryValue("RYNO II Flag", 0x001A7B2C, "Int8", "Weapon Flags", "RYNO II weapon obtained"));
            memoryValues.Add(new MemoryValue("Shield Charger Flag", 0x001A7B2D, "Int8", "Weapon Flags", "Shield Charger weapon obtained"));
            memoryValues.Add(new MemoryValue("Tractor Beam Flag", 0x001A7B2E, "Int8", "Weapon Flags", "Tractor Beam gadget obtained (Oozla mission)"));
            memoryValues.Add(new MemoryValue("Megacorp Helmet Flag", 0x001A7B2F, "Int8", "Weapon Flags", "Megacorp Helmet item obtained"));
            memoryValues.Add(new MemoryValue("Biker Helmet Flag", 0x001A7B30, "Int8", "Weapon Flags", "Biker Helmet item obtained"));
            memoryValues.Add(new MemoryValue("Box Breaker Flag", 0x001A7B32, "Int8", "Weapon Flags", "Box Breaker item obtained"));
            memoryValues.Add(new MemoryValue("Infiltrator Flag", 0x001A7B33, "Int8", "Weapon Flags", "Infiltrator item obtained"));
            memoryValues.Add(new MemoryValue("Walloper Flag", 0x001A7B35, "Int8", "Weapon Flags", "Walloper weapon obtained"));
            memoryValues.Add(new MemoryValue("Charge Boots Flag", 0x001A7B36, "Int8", "Weapon Flags", "Charge Boots gadget obtained"));
            memoryValues.Add(new MemoryValue("Hypnomatic Flag", 0x001A7B37, "Int8", "Weapon Flags", "Hypnomatic gadget obtained"));

            // ==================== PLANET FLAGS ====================
            memoryValues.Add(new MemoryValue("Planet Flag - Oozla", 0x001A7BD1, "Int8", "Planet Flags", "Oozla planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Maktar Nebula", 0x001A7BD2, "Int8", "Planet Flags", "Maktar Nebula planet flag (Oozla mission)"));
            memoryValues.Add(new MemoryValue("Planet Flag - Endako", 0x001A7BD3, "Int8", "Planet Flags", "Endako planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Barlow", 0x001A7BD4, "Int8", "Planet Flags", "Barlow planet flag (Maktar mission)"));
            memoryValues.Add(new MemoryValue("Planet Flag - Feltzin System", 0x001A7BD5, "Int8", "Planet Flags", "Feltzin System planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Notak", 0x001A7BD6, "Int8", "Planet Flags", "Notak planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Siberius", 0x001A7BD7, "Int8", "Planet Flags", "Siberius planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Tabora", 0x001A7BD8, "Int8", "Planet Flags", "Tabora planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Dobbo", 0x001A7BD9, "Int8", "Planet Flags", "Dobbo planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Hrugis Cloud", 0x001A7BDA, "Int8", "Planet Flags", "Hrugis Cloud planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Joba", 0x001A7BDB, "Int8", "Planet Flags", "Joba planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Todano", 0x001A7BDC, "Int8", "Planet Flags", "Todano planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Boldan", 0x001A7BDD, "Int8", "Planet Flags", "Boldan planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Aranos", 0x001A7BDE, "Int8", "Planet Flags", "Aranos planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Thugs Fleet", 0x001A7BDF, "Int8", "Planet Flags", "Thugs for Less Fleet planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Snivelak", 0x001A7BE0, "Int8", "Planet Flags", "Snivelak planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Smolg", 0x001A7BE1, "Int8", "Planet Flags", "Smolg planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Damosel", 0x001A7BE2, "Int8", "Planet Flags", "Damosel planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Grelbin", 0x001A7BE3, "Int8", "Planet Flags", "Grelbin planet flag"));
            memoryValues.Add(new MemoryValue("Planet Flag - Yeedil", 0x001A7BE4, "Int8", "Planet Flags", "Yeedil planet flag"));

            // ==================== GAMEPLAY FLAGS ====================
            memoryValues.Add(new MemoryValue("Visibomb Active Flag", 0x001A8A44, "Int8", "Gameplay", "Visibomb is active"));
            memoryValues.Add(new MemoryValue("Current Screen (Dynamic)", 0x001A8F00, "Int32", "Gameplay", "Current screen state (Oozla)",
@"0 = In-gameplay
1 = In cutscene
3 = Pause menus
4 = Confirm message
5 = Weapons shop"));

            // ==================== MISC ====================
            memoryValues.Add(new MemoryValue("Museum Electrolyzer Puzzle", 0x001A08C0, "Int8", "Misc", "Museum electrolyzer puzzle flag"));
            memoryValues.Add(new MemoryValue("Message Sound ID", 0x001A6414, "Int16", "Misc", "Message sound ID"));
            memoryValues.Add(new MemoryValue("Tourists Killed", 0x001B09A0, "Int32", "Misc", "Tourist killed count"));
            memoryValues.Add(new MemoryValue("Debug Cheats Input", 0x001B22C8, "Int32", "Misc", "Debug cheats input listening (40 bytes)"));
            memoryValues.Add(new MemoryValue("Cutscene Related", 0x001BF688, "Int32", "Misc", "Cutscene related data"));
            memoryValues.Add(new MemoryValue("Water Interaction", 0x016DE5BC, "Int8", "Misc", "Water interaction enabled (becomes 1 near water)"));

            // ==================== MINI GAMES ====================
            memoryValues.Add(new MemoryValue("Sheep Shooting Position", 0x01999C98, "Float", "Mini Games", "Sheep shooting game player position"));
            memoryValues.Add(new MemoryValue("Sheep Shooting Score", 0x01999CE4, "Int32", "Mini Games", "Sheep shooting game score"));
            memoryValues.Add(new MemoryValue("Sheep Shooting Level", 0x01999CF0, "Int32", "Mini Games", "Sheep shooting game current level"));
            memoryValues.Add(new MemoryValue("Space Wars Projectiles", 0x01BC7C50, "Int32", "Mini Games", "Space-ish Wars projectiles delay/used"));
            memoryValues.Add(new MemoryValue("Space Wars Player Wins", 0x01BC7C58, "Int32", "Mini Games", "Space-ish Wars player wins"));
            memoryValues.Add(new MemoryValue("Space Wars NPC Wins", 0x01BC7C5C, "Int32", "Mini Games", "Space-ish Wars NPC wins"));
            memoryValues.Add(new MemoryValue("Space Wars Start Flag", 0x01BC7C64, "Int32", "Mini Games", "Space-ish Wars start flag (changes every stage)"));

            // ==================== MISSION FLAGS - ARANOS ====================
            memoryValues.Add(new MemoryValue("Aranos First Visit Mission 1", 0x0027EE74, "Int32", "Aranos Missions", "Aranos first visit mission flag"));
            memoryValues.Add(new MemoryValue("Aranos First Visit Mission 2", 0x0027EE9C, "Int32", "Aranos Missions", "Aranos first visit mission flag"));
            memoryValues.Add(new MemoryValue("Aranos Mission 1", 0x0028694C, "Int32", "Aranos Missions", "Aranos mission flag"));
            memoryValues.Add(new MemoryValue("Aranos Mission 2", 0x00286974, "Int32", "Aranos Missions", "Aranos mission flag"));
            memoryValues.Add(new MemoryValue("Aranos Mission 3", 0x0028699C, "Int32", "Aranos Missions", "Aranos mission flag"));
            memoryValues.Add(new MemoryValue("Aranos Mission 4", 0x002869C4, "Int32", "Aranos Missions", "Aranos mission flag"));
            memoryValues.Add(new MemoryValue("Aranos Secret Item", 0x002869EC, "Int32", "Aranos Missions", "Aranos mission secret item (used in Boldan)"));

            // ==================== MISSION FLAGS - OOZLA ====================
            memoryValues.Add(new MemoryValue("Oozla Mission 1", 0x002801F4, "Int32", "Oozla Missions", "Oozla mission flag"));
            memoryValues.Add(new MemoryValue("Oozla Mission 2", 0x0028021C, "Int32", "Oozla Missions", "Oozla mission flag"));
            memoryValues.Add(new MemoryValue("Oozla Mission 3", 0x00280244, "Int32", "Oozla Missions", "Oozla mission flag"));
            memoryValues.Add(new MemoryValue("Oozla Mission 4", 0x0028026C, "Int32", "Oozla Missions", "Oozla mission flag"));
            memoryValues.Add(new MemoryValue("Oozla Missions Completed", 0x00280280, "Int32", "Oozla Missions", "Oozla missions completed flag"));

            // ==================== MISSION FLAGS - SIBERIUS ====================
            memoryValues.Add(new MemoryValue("Siberius Mission", 0x0027FDDC, "Int32", "Siberius Missions", "Siberius mission flag"));

            // ==================== MISSION FLAGS - TODANO ====================
            memoryValues.Add(new MemoryValue("Todano Mission 1", 0x00281514, "Int32", "Todano Missions", "Todano mission flag"));
            memoryValues.Add(new MemoryValue("Todano Secret Collectible", 0x0028153C, "Int32", "Todano Missions", "Todano mission secret collectible"));
            memoryValues.Add(new MemoryValue("Todano Mission 3", 0x00281564, "Int32", "Todano Missions", "Todano mission flag"));
            memoryValues.Add(new MemoryValue("Todano Mission 4", 0x0028158C, "Int32", "Todano Missions", "Todano mission flag"));

            // ==================== MISSION FLAGS - MAKTAR ====================
            memoryValues.Add(new MemoryValue("Maktar Mission 1", 0x00281634, "Int32", "Maktar Missions", "Maktar mission flag"));
            memoryValues.Add(new MemoryValue("Maktar Mission 2", 0x0028165C, "Int32", "Maktar Missions", "Maktar mission flag"));
            memoryValues.Add(new MemoryValue("Maktar Mission 3", 0x00281684, "Int32", "Maktar Missions", "Maktar mission flag"));
            memoryValues.Add(new MemoryValue("Maktar Mission 4", 0x002816AC, "Int32", "Maktar Missions", "Maktar mission flag"));

            // ==================== MISSION FLAGS - SMOLG ====================
            memoryValues.Add(new MemoryValue("Smolg Mission 1", 0x00281A74, "Int32", "Smolg Missions", "Smolg mission flag"));
            memoryValues.Add(new MemoryValue("Smolg Mission 2", 0x00281A9C, "Int32", "Smolg Missions", "Smolg mission flag"));
            memoryValues.Add(new MemoryValue("Smolg Mission 3", 0x00281AC4, "Int32", "Smolg Missions", "Smolg mission flag"));

            // ==================== MISSION FLAGS - SNIVELAK ====================
            memoryValues.Add(new MemoryValue("Snivelak Mission", 0x002821BC, "Int32", "Snivelak Missions", "Snivelak mission flag"));

            // ==================== MISSION FLAGS - DOBBO ====================
            memoryValues.Add(new MemoryValue("Dobbo Mission 1", 0x00282B64, "Int32", "Dobbo Missions", "Dobbo mission flag"));
            memoryValues.Add(new MemoryValue("Dobbo Mission 2", 0x00282BDC, "Int32", "Dobbo Missions", "Dobbo mission flag"));
            memoryValues.Add(new MemoryValue("Dobbo Mission 3", 0x00282C04, "Int32", "Dobbo Missions", "Dobbo mission flag"));
            memoryValues.Add(new MemoryValue("Dobbo Mission 4", 0x00282C2C, "Int32", "Dobbo Missions", "Dobbo mission flag"));

            // ==================== MISSION FLAGS - ENDAKO ====================
            memoryValues.Add(new MemoryValue("Endako Mission 1", 0x00283B94, "Int32", "Endako Missions", "Endako mission flag"));
            memoryValues.Add(new MemoryValue("Endako Mission 2", 0x00283BBC, "Int32", "Endako Missions", "Endako mission flag"));
            memoryValues.Add(new MemoryValue("Endako Mission 3", 0x00283BE4, "Int32", "Endako Missions", "Endako mission flag"));
            memoryValues.Add(new MemoryValue("Endako Mission 4", 0x00283C0C, "Int32", "Endako Missions", "Endako mission flag"));
            memoryValues.Add(new MemoryValue("Endako Mission 5", 0x00283C34, "Int32", "Endako Missions", "Endako mission flag"));

            // ==================== MISSION FLAGS - GRELBIN ====================
            memoryValues.Add(new MemoryValue("Grelbin Mission 1", 0x002842A4, "Int32", "Grelbin Missions", "Grelbin mission flag"));
            memoryValues.Add(new MemoryValue("Grelbin Mission 2", 0x002842CC, "Int32", "Grelbin Missions", "Grelbin mission flag"));
            memoryValues.Add(new MemoryValue("Grelbin Mission 3", 0x002842F4, "Int32", "Grelbin Missions", "Grelbin mission flag"));
            memoryValues.Add(new MemoryValue("Grelbin Mission 4", 0x0028431C, "Int32", "Grelbin Missions", "Grelbin mission flag"));
            memoryValues.Add(new MemoryValue("Grelbin Mission 5", 0x00284344, "Int32", "Grelbin Missions", "Grelbin mission flag"));

            // ==================== MISSION FLAGS - NOTAK ====================
            memoryValues.Add(new MemoryValue("Notak Mission 1", 0x00289B5C, "Int32", "Notak Missions", "Notak mission flag"));
            memoryValues.Add(new MemoryValue("Notak Mission 2", 0x00289B84, "Int32", "Notak Missions", "Notak mission flag"));
            memoryValues.Add(new MemoryValue("Notak Mission 3", 0x00289BAC, "Int32", "Notak Missions", "Notak mission flag"));
            memoryValues.Add(new MemoryValue("Notak Mission 4", 0x00289BD4, "Int32", "Notak Missions", "Notak mission flag"));

            // ==================== MISSION FLAGS - TABORA ====================
            memoryValues.Add(new MemoryValue("Tabora Mission 1", 0x0028A3FC, "Int32", "Tabora Missions", "Tabora mission flag"));
            memoryValues.Add(new MemoryValue("Tabora Mission 2", 0x0028A424, "Int32", "Tabora Missions", "Tabora mission flag"));
            memoryValues.Add(new MemoryValue("Tabora Mission 3", 0x0028A44C, "Int32", "Tabora Missions", "Tabora mission flag"));
            memoryValues.Add(new MemoryValue("Tabora Mission 4", 0x0028A474, "Int32", "Tabora Missions", "Tabora mission flag"));
            memoryValues.Add(new MemoryValue("Tabora Mission 5", 0x0028A4C4, "Int32", "Tabora Missions", "Tabora mission flag"));

            // ==================== MISSION FLAGS - DAMOSEL ====================
            memoryValues.Add(new MemoryValue("Damosel Mission 1", 0x0028A66C, "Int32", "Damosel Missions", "Damosel mission flag"));
            memoryValues.Add(new MemoryValue("Damosel Mission 2", 0x0028A694, "Int32", "Damosel Missions", "Damosel mission flag"));
            memoryValues.Add(new MemoryValue("Damosel Mission 3", 0x0028A6BC, "Int32", "Damosel Missions", "Damosel mission flag"));
            memoryValues.Add(new MemoryValue("Damosel Mission 4", 0x0028A6E4, "Int32", "Damosel Missions", "Damosel mission flag"));
            memoryValues.Add(new MemoryValue("Damosel Mission 5", 0x0028A70C, "Int32", "Damosel Missions", "Damosel mission flag"));

            // ==================== MISSION FLAGS - BOLDAN ====================
            memoryValues.Add(new MemoryValue("Boldan Mission 1", 0x0028B204, "Int32", "Boldan Missions", "Boldan mission flag"));
            memoryValues.Add(new MemoryValue("Boldan Mission 2", 0x0028B22C, "Int32", "Boldan Missions", "Boldan mission flag"));
            memoryValues.Add(new MemoryValue("Boldan Mission 3", 0x0028B254, "Int32", "Boldan Missions", "Boldan mission flag"));
            memoryValues.Add(new MemoryValue("Boldan Mission 4", 0x0028B27C, "Int32", "Boldan Missions", "Boldan mission flag"));

            // ==================== MISSION FLAGS - YEEDIL ====================
            memoryValues.Add(new MemoryValue("Yeedil Mission 1", 0x0028C6C4, "Int32", "Yeedil Missions", "Yeedil mission flag"));
            memoryValues.Add(new MemoryValue("Yeedil Mission 2", 0x0028C6EC, "Int32", "Yeedil Missions", "Yeedil mission flag (does not change after killing boss)"));

            // ==================== MISSION FLAGS - JOBA ====================
            memoryValues.Add(new MemoryValue("Joba Mission 1", 0x00297874, "Int8", "Joba Missions", "Joba mission flag"));
            memoryValues.Add(new MemoryValue("Joba Mission 2", 0x0029789C, "Int8", "Joba Missions", "Joba mission flag"));
            memoryValues.Add(new MemoryValue("Joba Mission 3", 0x002978C4, "Int8", "Joba Missions", "Joba mission flag"));
            memoryValues.Add(new MemoryValue("Joba Mission 4", 0x002978EC, "Int8", "Joba Missions", "Joba mission flag"));

            // ==================== MISSION FLAGS - BARLOW ====================
            memoryValues.Add(new MemoryValue("Barlow Mission 1", 0x0029853C, "Int32", "Barlow Missions", "Barlow mission flag"));
            memoryValues.Add(new MemoryValue("Barlow Mission 2", 0x00298564, "Int32", "Barlow Missions", "Barlow mission flag"));
            memoryValues.Add(new MemoryValue("Barlow Mission 3", 0x0029858C, "Int32", "Barlow Missions", "Barlow mission flag"));
            memoryValues.Add(new MemoryValue("Barlow Mission 4", 0x002985B4, "Int32", "Barlow Missions", "Barlow mission flag"));
            memoryValues.Add(new MemoryValue("Barlow Mission 5", 0x002985DC, "Int32", "Barlow Missions", "Barlow mission flag"));
            memoryValues.Add(new MemoryValue("Barlow Mission 6", 0x00298604, "Int32", "Barlow Missions", "Barlow mission flag"));
            memoryValues.Add(new MemoryValue("Barlow Mission 7", 0x0029862C, "Int32", "Barlow Missions", "Barlow mission flag"));

            // ==================== POINTERS ====================
            memoryValues.Add(new MemoryValue("Endako Pointer Chain", 0x001AA3B8, "Int32", "Pointers", "Pointer chain (Endako only)",
@"+0x68 = Dynamic mini game pointer
++0x00 = Sheep blaster mini game data block"));
            memoryValues.Add(new MemoryValue("Aranos Pointer Chain", 0x001AA438, "Int32", "Pointers", "Pointer chain (Aranos only)",
@"+0x68 = Dynamic mini game pointer
++0x00 = Sheep blaster mini game data block"));
            memoryValues.Add(new MemoryValue("Siberius Boss Pointer", 0x01FB0AC, "Int32", "Pointers", "Pointer chain for Siberius boss",
@"+0x68 = Dynamic pointer of enemy stats
++0x20 = Siberius boss health (float)"));
            memoryValues.Add(new MemoryValue("Final Boss Pointer", 0x01FBE80, "Int32", "Pointers", "Pointer chain for final boss",
@"+0x68 = Dynamic pointer of enemy stats
++0x20 = Final boss health"));
            memoryValues.Add(new MemoryValue("Cutscene Data Pointer", 0x01FEEF50, "Int32", "Pointers", "Pointer of cutscene data",
@"+0xFFFFBA34 = Cutscene ID
+0xFFFFBA30 = In-game cutscene ID"));
            memoryValues.Add(new MemoryValue("Pause Menu Pointer", 0x01FEF9A4, "Int32", "Pointers", "Pause menu pointer",
@"+0xFFFFFD20 = Pause menu flag
+0x6E0 = Debug listening to input for cheats"));

            // ==================== DEBUG ====================
            memoryValues.Add(new MemoryValue("Debug Flag (Sep 9 Proto)", 0x01FE1E4, "Int32", "Debug", "Debug enabled flag for Sep 9, 2003 prototype lv 1"));
            memoryValues.Add(new MemoryValue("Debug Flag (Retail)", 0x01FECE4, "Int32", "Debug", "Debug enabled flag for retail disc lv 1"));

            return memoryValues;
        }
    }
}
