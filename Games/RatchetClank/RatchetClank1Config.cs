using Common;
using System.Collections.Generic;

namespace Games.RatchetClank
{
    public class RatchetClank1Config : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank 1 (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Audio Settings
            memoryValues.Add(new MemoryValue("Music Volume", 0x0013328C, "Int16", "Settings", "Max=400, Min=0"));
            memoryValues.Add(new MemoryValue("Sound Effects Volume", 0x00133298, "Int16", "Settings", "Max=333, Min=0"));

            // Controller Input
            memoryValues.Add(new MemoryValue("Controller L3/R3", 0x0013C95C, "Int8", "Input", "Bitfield: bit1=L3, bit2=R3 (0=pressed)"));
            memoryValues.Add(new MemoryValue("Controller Triggers", 0x0013C95D, "Int8", "Input", "Bitfield: bit0=L2, bit1=R2, bit2=L1, bit3=R1 (0=pressed)"));

            // Items & Special
            memoryValues.Add(new MemoryValue("Zoomerator", 0x0013D388, "Int8", "Items", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Raritanium", 0x0013D389, "Int8", "Items", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("CodeBot", 0x0013D38A, "Int8", "Items", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Premium Nanotech", 0x0013D38C, "Int8", "Items", "Orxon Events - Premium Nanotech purchase"));
            memoryValues.Add(new MemoryValue("Ultra Nanotech", 0x0013D38D, "Int8", "Items", "Ultra Nanotech owned"));

            // Event Flags
            memoryValues.Add(new MemoryValue("Novalis Events", 0x0013D397, "Int8", "Events", "Landing with Clank"));
            memoryValues.Add(new MemoryValue("Kerwan Events", 0x0013D3A0, "Int8", "Events", "Explore the city / Ride robo train"));
            memoryValues.Add(new MemoryValue("Veldin Water Switch", 0x0013D407, "Int8", "Events", "0=default, 1=opened valve"));

            // Skill Points (30 total)
            memoryValues.Add(new MemoryValue("SP - Take Aim (Novalis)", 0x0013D408, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Swing It", 0x0013D409, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Transported", 0x0013D40A, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Strike a Pose", 0x0013D40B, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Blimpy", 0x0013D40C, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Qwarktastic", 0x0013D40D, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Any Ten", 0x0013D40E, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Tricky", 0x0013D40F, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Cluck Cluck", 0x0013D410, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Speedy", 0x0013D411, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Girl Trouble", 0x0013D412, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Jumper", 0x0013D413, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Accuracy Counts", 0x0013D414, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Eat Lead", 0x0013D415, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Destroyed", 0x0013D416, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Gunner", 0x0013D417, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Sniper", 0x0013D418, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Hey Over Here", 0x0013D419, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Alien Invasion", 0x0013D41A, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Buried Treasure", 0x0013D41B, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Pest Control", 0x0013D41C, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Whirlybirds", 0x0013D41D, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Sitting Ducks", 0x0013D41E, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Shattered Glass", 0x0013D41F, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Blast Em", 0x0013D420, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Heavy Traffic", 0x0013D421, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Magician", 0x0013D422, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Sneaky", 0x0013D423, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Careful Cruise", 0x0013D424, "Int8", "Skill Points", "1=Unlocked"));
            memoryValues.Add(new MemoryValue("SP - Going Commando", 0x0013D425, "Int8", "Skill Points", "1=Unlocked"));

            // Ammo
            memoryValues.Add(new MemoryValue("Bomb Glove Ammo", 0x0013D450, "Int32", "Ammo", "Bomb Glove ammunition"));
            memoryValues.Add(new MemoryValue("Devastator Ammo", 0x0013D454, "Int32", "Ammo", "Devastator ammunition"));
            memoryValues.Add(new MemoryValue("Visibomb Gun Ammo", 0x0013D45C, "Int32", "Ammo", "Max=20"));
            memoryValues.Add(new MemoryValue("Blaster Ammo", 0x0013D464, "Int32", "Ammo", "Blaster ammunition"));
            memoryValues.Add(new MemoryValue("Pyrocitor Ammo", 0x0013D468, "Int32", "Ammo", "Pyrocitor ammunition"));
            memoryValues.Add(new MemoryValue("Mine Glove Ammo", 0x0013D46C, "Int32", "Ammo", "Mine Glove ammunition"));
            memoryValues.Add(new MemoryValue("Tesla Claw Ammo", 0x0013D474, "Int32", "Ammo", "Tesla Claw ammunition"));
            memoryValues.Add(new MemoryValue("Glove of Doom Ammo", 0x0013D478, "Int32", "Ammo", "Glove of Doom ammunition"));
            memoryValues.Add(new MemoryValue("RYNO Ammo", 0x0013D484, "Int32", "Ammo", "RYNO ammunition"));
            memoryValues.Add(new MemoryValue("Drone Device Ammo", 0x0013D488, "Int32", "Ammo", "Drone Device ammunition"));
            memoryValues.Add(new MemoryValue("Decoy Glove Ammo", 0x0013D48C, "Int32", "Ammo", "Decoy Glove ammunition"));

            // Gadgets
            memoryValues.Add(new MemoryValue("Heli-Pack", 0x0013D4C2, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Thruster-Pack", 0x0013D4C3, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Hydro-Pack", 0x0013D4C4, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Sonic Summoner", 0x0013D4C5, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("O2 Mask", 0x0013D4C6, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Pilot's Helmet", 0x0013D4C7, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Trespasser", 0x0013D4DA, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Metal Detector", 0x0013D4DB, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Magneboots", 0x0013D4DC, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Grindboots", 0x0013D4DD, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Hoverboard", 0x0013D4DE, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Hologuise", 0x0013D4DF, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("PDA", 0x0013D4E0, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Map-O-Matic", 0x0013D4E1, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Bolt Grabber", 0x0013D4E2, "Int8", "Gadgets", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Persuader", 0x0013D4E3, "Int8", "Gadgets", "0=Not owned, 1=Owned"));

            // Weapons
            memoryValues.Add(new MemoryValue("Suck Cannon", 0x0013D4C9, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Bomb Glove", 0x0013D4CA, "Int8", "Weapons", "0=Not owned, 1=Owned (defaults on)"));
            memoryValues.Add(new MemoryValue("Devastator", 0x0013D4CB, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Swingshot", 0x0013D4CC, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Visibomb Gun", 0x0013D4CD, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Taunter", 0x0013D4CE, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Blaster", 0x0013D4CF, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Pyrocitor", 0x0013D4D0, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Mine Glove", 0x0013D4D1, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Walloper", 0x0013D4D2, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Tesla Claw", 0x0013D4D3, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Glove of Doom", 0x0013D4D4, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Morph-O-Ray", 0x0013D4D5, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Hydrodisplacer", 0x0013D4D6, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("RYNO", 0x0013D4D7, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Drone Device", 0x0013D4D8, "Int8", "Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Decoy Glove", 0x0013D4D9, "Int8", "Weapons", "0=Not owned, 1=Owned"));

            // Planet Unlocks
            memoryValues.Add(new MemoryValue("Planet Unlocks Array Start", 0x0013D510, "Int8", "Planet Unlocks", "First-come first-serve infobot order",
@"0x01 = Novalis
0x02 = Aridia
0x03 = Kerwan
0x04 = Eudora
0x05 = Rilgar
0x06 = Blarg Station G34
0x07 = Umbris (Qwark HQ)
0x08 = Batalia
0x09 = Pokitaru
0x0A = Orxon
0x0B = Hoven
0x0C = Oltanis Orbit
0x0D = Oltanis
0x0E = Quartu
0x0F = Kalebo III
0x10 = Veldin Orbit
0x11 = Veldin"));
            memoryValues.Add(new MemoryValue("Kerwan Unlocked", 0x0013D514, "Int8", "Planet Unlocks", "0x03=unlocked"));
            memoryValues.Add(new MemoryValue("Aridia Unlocked", 0x0013D518, "Int8", "Planet Unlocks", "0x02=unlocked"));
            memoryValues.Add(new MemoryValue("Eudora Unlocked", 0x0013D51C, "Int8", "Planet Unlocks", "0x04=unlocked"));
            memoryValues.Add(new MemoryValue("Blarg Station Unlocked", 0x0013D520, "Int8", "Planet Unlocks", "G34 unlocked"));
            memoryValues.Add(new MemoryValue("Rilgar Unlocked", 0x0013D524, "Int8", "Planet Unlocks", "Rilgar unlocked"));
            memoryValues.Add(new MemoryValue("Umbris Unlocked", 0x0013D528, "Int8", "Planet Unlocks", "Qwark HQ unlocked"));
            memoryValues.Add(new MemoryValue("Batalia Unlocked", 0x0013D52C, "Int8", "Planet Unlocks", "Batalia unlocked"));
            memoryValues.Add(new MemoryValue("Orxon Unlocked", 0x0013D530, "Int8", "Planet Unlocks", "Orxon unlocked"));
            memoryValues.Add(new MemoryValue("Gaspar Unlocked", 0x0013D534, "Int8", "Planet Unlocks", "Gaspar unlocked"));
            memoryValues.Add(new MemoryValue("Pokitaru Unlocked", 0x0013D538, "Int8", "Planet Unlocks", "Pokitaru unlocked"));
            memoryValues.Add(new MemoryValue("Hoven Unlocked", 0x0013D53C, "Int8", "Planet Unlocks", "Hoven unlocked"));
            memoryValues.Add(new MemoryValue("Gemlik Moonbase Unlocked", 0x0013D540, "Int8", "Planet Unlocks", "Oltanis Orbit unlocked"));
            memoryValues.Add(new MemoryValue("Oltanis Unlocked", 0x0013D544, "Int8", "Planet Unlocks", "Oltanis unlocked"));
            memoryValues.Add(new MemoryValue("Quartu Unlocked", 0x0013D548, "Int8", "Planet Unlocks", "Quartu unlocked"));
            memoryValues.Add(new MemoryValue("Kalebo III Unlocked", 0x0013D54C, "Int8", "Planet Unlocks", "Kalebo III unlocked"));
            memoryValues.Add(new MemoryValue("Dreks Fleet Unlocked", 0x0013D550, "Int8", "Planet Unlocks", "Veldin Orbit unlocked"));
            memoryValues.Add(new MemoryValue("Final Veldin Unlocked", 0x0013D554, "Int8", "Planet Unlocks", "Final Veldin unlocked"));

            // Infobots
            memoryValues.Add(new MemoryValue("Infobot - Novalis", 0x0013DD41, "Int8", "Infobots", "0=default, 1=getting infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Aridia (buy)", 0x0013DD42, "Int8", "Infobots", "Buy from mechanic flag"));
            memoryValues.Add(new MemoryValue("Infobot - New Ship", 0x0013DD43, "Int8", "Infobots", "Find a new ship flag"));
            memoryValues.Add(new MemoryValue("Infobot - Kerwan", 0x0013DD44, "Int8", "Infobots", "Kerwan infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Blarg Station", 0x0013DD45, "Int8", "Infobots", "Blarg Station infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Eudora", 0x0013DD46, "Int8", "Infobots", "Eudora infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Rilgar", 0x0013DD47, "Int8", "Infobots", "Rilgar infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Umbris", 0x0013DD48, "Int8", "Infobots", "Umbris infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Batalia (soldier)", 0x0013DD49, "Int8", "Infobots", "Batalia soldier infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Orxon", 0x0013DD4A, "Int8", "Infobots", "Batalia Orxon infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Orxon Clank", 0x0013DD4B, "Int8", "Infobots", "Orxon Clank infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Orxon Ratchet", 0x0013DD4C, "Int8", "Infobots", "Orxon Ratchet infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Hoven", 0x0013DD4D, "Int8", "Infobots", "Hoven infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Gemlik", 0x0013DD4E, "Int8", "Infobots", "Gemlik infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Quartu", 0x0013DD4F, "Int8", "Infobots", "Quartu infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Quartu 2", 0x0013DD50, "Int8", "Infobots", "Quartu second infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Dreks Fleet", 0x0013DD51, "Int8", "Infobots", "Quartu Dreks fleet infobot"));
            memoryValues.Add(new MemoryValue("Infobot - Final", 0x0013DD52, "Int8", "Infobots", "Dreks fleet final infobot"));

            // Progression
            memoryValues.Add(new MemoryValue("Overall Progression", 0x0013DD58, "Int8", "Progression", "0x1=first planet, 0x2=after Novalis"));

            // Ammo Usage Statistics
            memoryValues.Add(new MemoryValue("Ammo Used - Bomb Glove", 0x0013DEC8, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Devastator", 0x0013DECC, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Visibomb", 0x0013DED4, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Blaster", 0x0013DEDC, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Pyrocitor", 0x0013DEE0, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Mine Glove", 0x0013DEE4, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Tesla Claw", 0x0013DEEC, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Glove of Doom", 0x0013DEF0, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - RYNO", 0x0013DEFC, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Drone Device", 0x0013DF00, "Int32", "Ammo Stats", "Total ammo used"));
            memoryValues.Add(new MemoryValue("Ammo Used - Decoy Glove", 0x0013DF04, "Int32", "Ammo Stats", "Total ammo used"));

            // Bolts Per Planet
            memoryValues.Add(new MemoryValue("Bolts - Veldin (First)", 0x0013DF38, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Novalis", 0x0013DF3C, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Aridia", 0x0013DF40, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Kerwan", 0x0013DF44, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Eudora", 0x0013DF48, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Rilgar", 0x0013DF4C, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - G34", 0x0013DF50, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Umbris", 0x0013DF54, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Batalia", 0x0013DF58, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Gaspar", 0x0013DF5C, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Orxon", 0x0013DF60, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Pokitaru", 0x0013DF64, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Hoven", 0x0013DF68, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Oltanis Orbit", 0x0013DF6C, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Oltanis", 0x0013DF70, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Quartu", 0x0013DF74, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Kalebo III", 0x0013DF78, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Veldin Orbit", 0x0013DF7C, "Int32", "Bolts Per Planet", "Total bolts gathered"));
            memoryValues.Add(new MemoryValue("Bolts - Veldin (Revisit)", 0x0013DF80, "Int32", "Bolts Per Planet", "Total bolts gathered"));

            // Times Hit Per Planet
            memoryValues.Add(new MemoryValue("Hits - Veldin (First)", 0x0013DF88, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Novalis", 0x0013DF8C, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Aridia", 0x0013DF90, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Kerwan", 0x0013DF94, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Eudora", 0x0013DF98, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Rilgar", 0x0013DF9C, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - G34", 0x0013DFA0, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Umbris", 0x0013DFA4, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Batalia", 0x0013DFA8, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Gaspar", 0x0013DFAC, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Orxon", 0x0013DFB0, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Pokitaru", 0x0013DFB4, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Hoven", 0x0013DFB8, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Oltanis Orbit", 0x0013DFBC, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Oltanis", 0x0013DFC0, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Quartu", 0x0013DFC4, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Kalebo III", 0x0013DFC8, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Veldin Orbit", 0x0013DFCC, "Int32", "Damage Stats", "Times hit by enemy"));
            memoryValues.Add(new MemoryValue("Hits - Veldin (Revisit)", 0x0013DFD0, "Int32", "Damage Stats", "Times hit by enemy"));

            // Deaths Per Planet
            memoryValues.Add(new MemoryValue("Deaths - Novalis", 0x0013DFDC, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Aridia", 0x0013DFE0, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Kerwan", 0x0013DFE4, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Eudora", 0x0013DFE8, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Rilgar", 0x0013DFEC, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - G34", 0x0013DFF0, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Umbris", 0x0013DFF4, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Batalia", 0x0013DFF8, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Gaspar", 0x0013DFFC, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Orxon", 0x0013E000, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Pokitaru", 0x0013E004, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Hoven", 0x0013E008, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Oltanis Orbit", 0x0013E00C, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Oltanis", 0x0013E010, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Quartu", 0x0013E014, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Kalebo III", 0x0013E018, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Veldin Orbit", 0x0013E01C, "Int32", "Death Stats", "Number of deaths"));
            memoryValues.Add(new MemoryValue("Deaths - Veldin (Revisit)", 0x0013E020, "Int32", "Death Stats", "Number of deaths"));

            // Gold Weapons
            memoryValues.Add(new MemoryValue("Gold Suck Cannon", 0x0013E529, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Bomb Glove", 0x0013E52A, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Devastator", 0x0013E52B, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Blaster", 0x0013E52F, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Pyrocitor", 0x0013E530, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Mine Glove", 0x0013E531, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Tesla Claw", 0x0013E533, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Glove of Doom", 0x0013E534, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Morph-O-Ray", 0x0013E535, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));
            memoryValues.Add(new MemoryValue("Gold Decoy Glove", 0x0013E539, "Int8", "Gold Weapons", "0=Not owned, 1=Owned"));

            // Ship Travel
            memoryValues.Add(new MemoryValue("Ship Fast Travel", 0x0013E55C, "Float", "Ship", "-1.0=onboard ship"));

            // Ratchet Position & State
            memoryValues.Add(new MemoryValue("X Coordinate", 0x0013F3D0, "Float", "Position", "Ratchet X position"));
            memoryValues.Add(new MemoryValue("Y Coordinate", 0x0013F3D4, "Float", "Position", "Ratchet Y position"));
            memoryValues.Add(new MemoryValue("Z Coordinate", 0x0013F3D8, "Float", "Position", "Ratchet Z position"));
            memoryValues.Add(new MemoryValue("Rotation", 0x0013F3E8, "Float", "Position", "Rotation (pi to -pi)"));

            // Hoverboard
            memoryValues.Add(new MemoryValue("Hoverboard Started", 0x0013FBD0, "Int32", "Hoverboard", "0xFFFFFFFF=not racing"));
            memoryValues.Add(new MemoryValue("Hoverboard Time", 0x0013FBE4, "Int32", "Hoverboard", "Race time"));
            memoryValues.Add(new MemoryValue("Hoverboard Laps", 0x0013FBEA, "Int8", "Hoverboard", "0=first lap, 3=end of race"));
            memoryValues.Add(new MemoryValue("Hoverboard Score", 0x0013FBF8, "Int32", "Hoverboard", "Race score"));

            // Combat State
            memoryValues.Add(new MemoryValue("Wrench Attack Flag", 0x001403F8, "Int8", "Combat", "0x1=attacking with wrench"));
            memoryValues.Add(new MemoryValue("Weapon Change Counter", 0x001403FB, "Int8", "Combat", "Times weapon changed"));
            memoryValues.Add(new MemoryValue("Weapon Equipped Timer", 0x00140400, "Int32", "Combat", "How long weapon equipped"));
            memoryValues.Add(new MemoryValue("Current Weapon In Hand", 0x00140408, "Int8", "Combat", "Current weapon/gadget held",
@"0x08 = Wrench
0x09 = Suck Cannon
0x0A = Bomb Glove
0x0B = Devastator
0x0C = Swingshot
0x0D = Visibomb Gun
0x0E = Taunter
0x0F = Blaster
0x10 = Pyrocitor
0x11 = Mine Glove
0x12 = Walloper
0x13 = Tesla Claw
0x14 = Glove of Doom
0x15 = Morph-O-Ray
0x17 = RYNO
0x19 = Decoy Glove
0x1B = Metal Detector"));

            // Clank Pack
            memoryValues.Add(new MemoryValue("Clank Pack Equipped", 0x001404F8, "Int8", "Equipment", "Current Clank pack",
@"0x0 = No Clank/Nothing
0x2 = Heli Pack
0x3 = Thruster Pack
0x4 = Hydro Pack"));

            // Giant Clank
            memoryValues.Add(new MemoryValue("Giant Clank HP", 0x00140980, "Int8", "Combat", "Giant Clank health (Veldin)"));

            // Ratchet State
            memoryValues.Add(new MemoryValue("Ratchet State", 0x001413D4, "Int8", "Player State", "Current animation/state",
@"0x04 = Crouching
0x08 = Gliding
0x0A = Helipack Leap
0x0D = Jetpack Hi-jump
0x0F = Helipack Jump
0x10 = Jetpack Leap
0x11 = Walljump
0x1E = First Person
0x20 = Walloper Punch
0x22 = Power Slam
0x23 = Throwing Bomb/Glove/Mine
0x24 = Launching Swingshot
0x25 = Swingshot Contact
0x64 = Inside Ship
0x67 = Teleporting
0x72 = Getting Gold Bolt
0x77 = Death
0x81 = Jetpack Strafe Mode"));

            memoryValues.Add(new MemoryValue("Swingshot End Flag", 0x001413D8, "Int8", "Player State", "0x1=at end of swingshot"));
            memoryValues.Add(new MemoryValue("Movement State", 0x001413DC, "Int8", "Player State", "Current movement",
@"0x0 = Idle
0x1 = Walking
0x3 = Hanging on Ledge
0x4 = Jumping
0x5 = Gliding with Jetpack
0x6 = Attacking with Wrench
0x0B = Power Slam
0x0D = Using Swingshot
0x10 = Sliding (Waterslide)"));

            memoryValues.Add(new MemoryValue("Controlling Clank", 0x001413F4, "Int8", "Player State", "0=Ratchet, 1=Clank"));
            memoryValues.Add(new MemoryValue("Hoverboarding", 0x001413F7, "Int8", "Player State", "0=default, 1=hoverboarding"));
            memoryValues.Add(new MemoryValue("Weapon Fired Flag", 0x001413F8, "Int8", "Player State", "0=default, 1=fired weapon"));
            memoryValues.Add(new MemoryValue("Current Weapon Equipped", 0x00141424, "Int8", "Player State", "Weapon ID"));
            memoryValues.Add(new MemoryValue("Current Footwear", 0x00141428, "Int8", "Player State", "0x1C=Magneboots, 0x1D=Grindboots"));
            memoryValues.Add(new MemoryValue("Current Headgear", 0x0014142C, "Int8", "Player State", "0x5=Sonic Summoner, 0x6=O2 Mask, 0x7=Pilot Helmet"));
            memoryValues.Add(new MemoryValue("Current Clank Pack", 0x00141430, "Int8", "Player State", "0x2=Heli, 0x3=Thruster, 0x4=Hydro"));

            // Load Protection
            memoryValues.Add(new MemoryValue("In-Game Flag", 0x00141584, "Int32", "Game State", "0xFF in gameplay, 0x2 hoverboarding"));

            // Health
            memoryValues.Add(new MemoryValue("Current Health", 0x001415F8, "Int8", "Player", "Current HP"));
            memoryValues.Add(new MemoryValue("Suck Cannon Ammo", 0x001413C8, "Int8", "Ammo", "Current Suck Cannon ammo"));

            // Weapon Usage Counters
            memoryValues.Add(new MemoryValue("Wrench Swings", 0x001416C0, "Int16", "Weapon Stats", "Times wrench swung"));
            memoryValues.Add(new MemoryValue("Suck Cannon Uses", 0x001416C8, "Int16", "Weapon Stats", "Times Suck Cannon used"));
            memoryValues.Add(new MemoryValue("Devastator Uses", 0x001416D8, "Int16", "Weapon Stats", "Times Devastator used"));
            memoryValues.Add(new MemoryValue("Taunter Uses", 0x001416F0, "Int16", "Weapon Stats", "Times Taunter used"));
            memoryValues.Add(new MemoryValue("Blaster Uses", 0x001416F8, "Int16", "Weapon Stats", "Times Blaster used"));
            memoryValues.Add(new MemoryValue("Mine Glove Uses", 0x00141708, "Int16", "Weapon Stats", "Times Mine Glove used"));
            memoryValues.Add(new MemoryValue("Comet Strike Uses", 0x001417A8, "Int16", "Weapon Stats", "Times Comet Strike used"));
            memoryValues.Add(new MemoryValue("Hyper Strike Uses", 0x00141848, "Int16", "Weapon Stats", "Times Hyper Strike used"));

            // Gold Bolts - Novalis (3)
            memoryValues.Add(new MemoryValue("GB - Novalis 1", 0x0014BEC4, "Int8", "Gold Bolts", "First right"));
            memoryValues.Add(new MemoryValue("GB - Novalis 2", 0x0014BEC5, "Int8", "Gold Bolts", "Second"));
            memoryValues.Add(new MemoryValue("GB - Novalis 3", 0x0014BEC6, "Int8", "Gold Bolts", "Cave"));

            // Gold Bolts - Aridia (4)
            memoryValues.Add(new MemoryValue("GB - Aridia 1", 0x0014BEC8, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Aridia 2", 0x0014BEC9, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Aridia 3", 0x0014BECA, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Aridia 4", 0x0014BECB, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Kerwan (3)
            memoryValues.Add(new MemoryValue("GB - Kerwan 1", 0x0014BECC, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Kerwan 2", 0x0014BECD, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Kerwan 3", 0x0014BECE, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Eudora (1)
            memoryValues.Add(new MemoryValue("GB - Eudora 1", 0x0014BED0, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Rilgar (2)
            memoryValues.Add(new MemoryValue("GB - Rilgar 1", 0x0014BED4, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Rilgar 2", 0x0014BED5, "Int8", "Gold Bolts", ""));

            // Gold Bolts - G34 (2)
            memoryValues.Add(new MemoryValue("GB - G34 1", 0x0014BED8, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - G34 2", 0x0014BED9, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Umbris (2)
            memoryValues.Add(new MemoryValue("GB - Umbris 1", 0x0014BEDC, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Umbris 2", 0x0014BEDD, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Batalia (2)
            memoryValues.Add(new MemoryValue("GB - Batalia 1", 0x0014BEE0, "Int8", "Gold Bolts", "River"));
            memoryValues.Add(new MemoryValue("GB - Batalia 2", 0x0014BEE1, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Gaspar (2)
            memoryValues.Add(new MemoryValue("GB - Gaspar 1", 0x0014BEE4, "Int8", "Gold Bolts", "Maw"));
            memoryValues.Add(new MemoryValue("GB - Gaspar 2", 0x0014BEE5, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Orxon (2)
            memoryValues.Add(new MemoryValue("GB - Orxon 1", 0x0014BEE8, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Orxon 2", 0x0014BEE9, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Pokitaru (1)
            memoryValues.Add(new MemoryValue("GB - Pokitaru 1", 0x0014BEEC, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Hoven (2)
            memoryValues.Add(new MemoryValue("GB - Hoven 1", 0x0014BEF0, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Hoven 2", 0x0014BEF1, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Oltanis Orbit (1)
            memoryValues.Add(new MemoryValue("GB - Oltanis Orbit 1", 0x0014BEF4, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Oltanis (4)
            memoryValues.Add(new MemoryValue("GB - Oltanis 1", 0x0014BEF8, "Int8", "Gold Bolts", "Slingshot"));
            memoryValues.Add(new MemoryValue("GB - Oltanis 2", 0x0014BEF9, "Int8", "Gold Bolts", "Slingshot"));
            memoryValues.Add(new MemoryValue("GB - Oltanis 3", 0x0014BEFA, "Int8", "Gold Bolts", "Slingshot"));
            memoryValues.Add(new MemoryValue("GB - Oltanis 4", 0x0014BEFB, "Int8", "Gold Bolts", "Slingshot"));

            // Gold Bolts - Quartu (2)
            memoryValues.Add(new MemoryValue("GB - Quartu 1", 0x0014BEFC, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Quartu 2", 0x0014BEFD, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Kalebo III (2)
            memoryValues.Add(new MemoryValue("GB - Kalebo III 1", 0x0014BF00, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Kalebo III 2", 0x0014BF01, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Veldin Orbit (2)
            memoryValues.Add(new MemoryValue("GB - Veldin Orbit 1", 0x0014BF04, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Veldin Orbit 2", 0x0014BF05, "Int8", "Gold Bolts", ""));

            // Gold Bolts - Final Veldin (3)
            memoryValues.Add(new MemoryValue("GB - Final Veldin 1", 0x0014BF08, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Final Veldin 2", 0x0014BF09, "Int8", "Gold Bolts", ""));
            memoryValues.Add(new MemoryValue("GB - Final Veldin 3", 0x0014BF0A, "Int8", "Gold Bolts", ""));

            // Game State & Debug
            memoryValues.Add(new MemoryValue("Current Planet ID", 0x0015ED84, "Int8", "Game State", "Current planet",
@"0x00 = Tutorial Veldin
0x01 = Novalis
0x02 = Aridia
0x03 = Kerwan
0x04 = Eudora
0x05 = Rilgar
0x06 = Blarg Station G34
0x07 = Umbris
0x08 = Batalia
0x09 = Gaspar
0x0A = Orxon
0x0B = Pokitaru
0x0C = Hoven
0x0D = Oltanis Orbit
0x0E = Oltanis
0x0F = Quartu
0x10 = Kalebo III
0x11 = Veldin Orbit
0x12 = Final Veldin"));

            memoryValues.Add(new MemoryValue("Current Bolts", 0x0015ED98, "Int32", "Player", "Total bolts held"));
            memoryValues.Add(new MemoryValue("Left Handed Ratchet (Unused)", 0x0015EDB5, "Int8", "Debug", "0=right, 1=left hand"));
            memoryValues.Add(new MemoryValue("Challenge Mode/NG+", 0x0015EE20, "Int32", "Game State", "Number of NG+ loops completed"));
            memoryValues.Add(new MemoryValue("Game Timer", 0x0015EE24, "Int32", "Game State", "Overall in-game time"));
            memoryValues.Add(new MemoryValue("Save File Number", 0x0015EE34, "Int8", "Game State", "Current save slot (0-4)"));

            memoryValues.Add(new MemoryValue("Loading State", 0x0015EE48, "Int16", "Game State", "Loading/in-game flag",
@"0x1-0x3 = Loading/Flying ship
0x7 = In-game"));

            memoryValues.Add(new MemoryValue("Hoverboard Best Time", 0x0015EE58, "Int32", "Records", "Rilgar hoverboard best time"));
            memoryValues.Add(new MemoryValue("Hoverboard Best Score", 0x0015EE68, "Int32", "Records", "Rilgar hoverboard best score"));

            // Overall Stats
            memoryValues.Add(new MemoryValue("Total Times Hit", 0x0015EEA8, "Int32", "Overall Stats", "All-time damage taken"));
            memoryValues.Add(new MemoryValue("Total Deaths", 0x0015EEAC, "Int32", "Overall Stats", "All-time deaths"));

            // Debug Mode
            memoryValues.Add(new MemoryValue("Debug Mode", 0x0015F5C4, "Int32", "Debug", "Game state debug",
@"0xFFFFFFFF = Enter Debug Menu
0x0 = Default
0x2 = In Cutscenes
0x3 = In Menu (Start, R3, etc)
0x4 = Hoverboard Race Menu
0x5 = Shop Menu
0x6 = Flying/Ship Animation"));

            // Oxygen
            memoryValues.Add(new MemoryValue("Oxygen Level", 0x0017E384, "Int16", "Player", "0=drowned"));

            // Boss Fights
            memoryValues.Add(new MemoryValue("Alien Queen HP (Display)", 0x0017E7A4, "Int16", "Boss", "Gradual drop (0x1E0 at start)"));
            memoryValues.Add(new MemoryValue("Alien Queen HP (Actual)", 0x0017E7A8, "Int16", "Boss", "Instant update (0x1E0 at start)"));

            // Menu Navigation
            memoryValues.Add(new MemoryValue("Main Menu Screen", 0x001D5BF0, "Int32", "Menus", "Current menu",
@"0x1F = New Game/Load Game
0x2E = Main Menu
0x2F = Options Menu
0x20 = Sound Options
0x30 = Language Options"));

            return memoryValues;
        }
    }
}
