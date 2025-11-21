using Common;
using System.Collections.Generic;

namespace Games.NeedForSpeed
{
    public class NFSUndergroundConfig : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Underground (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State
            memoryValues.Add(new MemoryValue("In Game Check", 0x0042EDB4, "Int8", "Game State", "00=In Game (racing)",
@"0x00 = In Game (currently racing)
Used to detect when player is actively in a race"));
            memoryValues.Add(new MemoryValue("Main Menu Check", 0x004E8FF0, "Int8", "Game State", "01=Main Menu",
@"0x01 = Main Menu
Used to detect when player is at the main menu"));
            memoryValues.Add(new MemoryValue("Difficulty", 0x0046FBE4, "Int8", "Game State", "00=Easy, 01=Medium, 02=Hard",
@"0x00 = Easy
0x01 = Medium
0x02 = Hard"));
            memoryValues.Add(new MemoryValue("Current Mode", 0x004C5368, "Int32", "Game State", "Bit 0=Underground, Bit 1=Quick Race, Bit 2=Split-Screen",
@"Bit flags for current game mode:
Bit 0 = Underground Mode
Bit 1 = Quick Race
Bit 2 = Split-Screen"));
            memoryValues.Add(new MemoryValue("Quick Race Mode Select", 0x004C54E4, "Int8", "Game State", "00=Circuit, 01=Sprint, 02=Lap Knockout, 03=Free Run, 05=Drag, 06=Drift",
@"0x00 = Circuit
0x01 = Sprint
0x02 = Lap Knockout
0x03 = Free Run
0x05 = Drag
0x06 = Drift"));
            memoryValues.Add(new MemoryValue("Winner Check (ASCII)", 0x0050D0A8, "Int32", "Game State", "6e6e6957=Winner! (drag race)",
@"ASCII text check for 'Winner!' display
0x6e6e6957 = 'Winn' (start of 'Winner!')
Used to detect drag race wins"));

            // Currency & Points
            memoryValues.Add(new MemoryValue("Bank (Money)", 0x004ADA0C, "Int32", "Currency", "Total money"));
            memoryValues.Add(new MemoryValue("Total Style Points", 0x004A6274, "Int32", "Currency", "Accumulated style points"));

            // Quick Race - Circuit Options
            memoryValues.Add(new MemoryValue("QR Circuit - Track Select", 0x004A60D4, "Int16", "Quick Race - Circuit", "03eb=Olympic Square, 03ed=Atlantica, etc.",
@"Circuit Tracks:
0x03eb = Olympic Square
0x03ed = Atlantica
0x03f0 = Bedard Bridge
0x03f3 = 9th and Frey
0x03f5 = Terminal
0x03f7 = Spillway
0x03f9 = Outer Ring
0x03fc = Inner City
0x03fe = Stadium
0x0400 = Market Street
0x0402 = National Rail
0x0404 = 1st Ave Truck Stop
0x0406 = Port Royal"));
            memoryValues.Add(new MemoryValue("QR Circuit - Reverse Status", 0x004A60D8, "Int8", "Quick Race - Circuit", "00=Standard, 01=Reverse",
@"0x00 = Standard direction
0x01 = Reverse direction"));
            memoryValues.Add(new MemoryValue("QR Circuit - Number of Laps", 0x004A60DC, "Int8", "Quick Race - Circuit", "01-0A (1-10 laps)",
@"0x01 = 1 Lap
0x02 = 2 Laps
...
0x0A = 10 Laps"));
            memoryValues.Add(new MemoryValue("QR Circuit - Opponent Skill", 0x004A60E0, "Int8", "Quick Race - Circuit", "00=Easy, 01=Medium, 02=Hard",
@"0x00 = Easy
0x01 = Medium
0x02 = Hard"));
            memoryValues.Add(new MemoryValue("QR Circuit - Traffic", 0x004A60E4, "Int8", "Quick Race - Circuit", "00=None, 01=Min, 02=Mod, 03=Max",
@"0x00 = None
0x01 = Minimum
0x02 = Moderate
0x03 = Maximum"));
            memoryValues.Add(new MemoryValue("QR Circuit - Catch Up", 0x004A60F4, "Int8", "Quick Race - Circuit", "00=Off, 01=On",
@"0x00 = Off
0x01 = On"));

            // Quick Race - Sprint Options
            memoryValues.Add(new MemoryValue("QR Sprint - Course Select", 0x004A6100, "Int16", "Quick Race - Sprint", "044e=Liberty Gardens, 044f=Broadway, etc.",
@"Sprint Courses:
0x044e = Liberty Gardens
0x044f = Broadway
0x0450 = 7th & Sparling
0x0451 = Locust Ridge
0x0452 = Lock Up
0x0453 = Coventry
0x0454 = Main Street
0x0455 = Lyons
0x0456 = Broadway (Alt)
0x0457 = Commercial
0x0458 = Parkade
0x0459 = Central
0x045a = Lockwood
0x045b = Switchback"));
            memoryValues.Add(new MemoryValue("QR Sprint - Reverse Status", 0x004A6104, "Int8", "Quick Race - Sprint", "00=Standard, 01=Reverse",
@"0x00 = Standard direction
0x01 = Reverse direction"));
            memoryValues.Add(new MemoryValue("QR Sprint - Opponent Skill", 0x004A610C, "Int8", "Quick Race - Sprint", "00=Easy, 01=Medium, 02=Hard",
@"0x00 = Easy
0x01 = Medium
0x02 = Hard"));
            memoryValues.Add(new MemoryValue("QR Sprint - Traffic", 0x004A6110, "Int8", "Quick Race - Sprint", "00=None, 01=Min, 02=Mod, 03=Max",
@"0x00 = None
0x01 = Minimum
0x02 = Moderate
0x03 = Maximum"));
            memoryValues.Add(new MemoryValue("QR Sprint - Catch Up", 0x004A6120, "Int8", "Quick Race - Sprint", "00=Off, 01=On",
@"0x00 = Off
0x01 = On"));

            // Quick Race - Lap Knockout Options
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Track", 0x004A612C, "Int16", "Quick Race - Lap KO", "Track selection"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Reverse", 0x004A6130, "Int8", "Quick Race - Lap KO", "00=Standard, 01=Reverse"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Skill", 0x004A6138, "Int8", "Quick Race - Lap KO", "00=Easy, 01=Medium, 02=Hard"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Traffic", 0x004A613C, "Int8", "Quick Race - Lap KO", "00=None, 01=Min, 02=Mod, 03=Max"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Catch Up", 0x004A614C, "Int8", "Quick Race - Lap KO", "00=Off, 01=On"));

            // Quick Race - Drag Options
            memoryValues.Add(new MemoryValue("QR Drag - Course Select", 0x004A6218, "Int16", "Quick Race - Drag", "04b1=14th & Vine Construction, etc.",
@"Drag Courses:
0x04b1 = 14th & Vine Construction
0x04b2 = 14th & Vine
0x04b3 = 7th & Sparling
0x04b4 = Market/Main
0x04b5 = Waterfront
0x04b6 = Dockside Cranes
0x04b7 = River Road
0x04b8 = Airport
0x04b9 = Spillway Interchange
0x04ba = Stadium Tunnel
0x04bb = 101 Highway North
0x04bc = 101 Highway South
0x04bd = Broadway Bridge
0x04be = International Way"));
            memoryValues.Add(new MemoryValue("QR Drag - Reverse Status", 0x004A621C, "Int8", "Quick Race - Drag", "00=Standard, 01=Reverse",
@"0x00 = Standard direction
0x01 = Reverse direction"));
            memoryValues.Add(new MemoryValue("QR Drag - Opponent Skill", 0x004A6224, "Int8", "Quick Race - Drag", "00=Easy, 01=Medium, 02=Hard",
@"0x00 = Easy
0x01 = Medium
0x02 = Hard"));
            memoryValues.Add(new MemoryValue("QR Drag - Traffic", 0x004A6228, "Int8", "Quick Race - Drag", "00=None, 01=Min, 02=Mod, 03=Max",
@"0x00 = None
0x01 = Minimum
0x02 = Moderate
0x03 = Maximum"));

            // Quick Race - Drift Options
            memoryValues.Add(new MemoryValue("QR Drift - Course Select", 0x004A6250, "Int16", "Quick Race - Drift", "0515-051c (Drift Tracks 1-8)",
@"Drift Tracks:
0x0515 = Drift Track 1
0x0516 = Drift Track 2
0x0517 = Drift Track 3
0x0518 = Drift Track 4
0x0519 = Drift Track 5
0x051a = Drift Track 6
0x051b = Drift Track 7
0x051c = Drift Track 8"));

            // Underground Mode - Performance Upgrades (Current Car)
            memoryValues.Add(new MemoryValue("UG - Weight Reduction", 0x004AC978, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - Suspension", 0x004AC97C, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - Engine/Exhaust", 0x004AC980, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - Turbo", 0x004AC984, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - Nitrous Oxide", 0x004AC988, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - ECU/Fuel System", 0x004AC98C, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - Drivetrain", 0x004AC990, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - Tires", 0x004AC994, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));
            memoryValues.Add(new MemoryValue("UG - Brakes", 0x004AC998, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme",
@"Performance upgrade levels:
0x00 = Stock
0x01 = Street (Level 1)
0x02 = Pro (Level 2)
0x03 = Extreme (Level 3)"));

            // Current Car - Quick Race Performance Upgrades
            memoryValues.Add(new MemoryValue("QR Current Car - Weight Reduction", 0x004C7BC8, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - Suspension", 0x004C7BCC, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - Engine/Exhaust", 0x004C7BD0, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - Turbo", 0x004C7BD4, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - Nitrous", 0x004C7BD8, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - ECU/Fuel", 0x004C7BDC, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - Drivetrain", 0x004C7BE0, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - Tires", 0x004C7BE4, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("QR Current Car - Brakes", 0x004C7BE8, "Int8", "QR Current Car", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Race Results - 1st Place
            memoryValues.Add(new MemoryValue("1st Place Check", 0x004C54F0, "Int8", "Race Results - 1st", "00=Player, 64=AI1, 65=AI2, 66=AI3",
@"Position identifier:
0x00 = Player
0x64 = AI Opponent 1
0x65 = AI Opponent 2
0x66 = AI Opponent 3"));
            memoryValues.Add(new MemoryValue("1st Place - Overall Time", 0x004C54F8, "Int32", "Race Results - 1st", "Divide by 40 for centiseconds",
@"Raw value / 40 = centiseconds
Example: 240000 / 40 = 6000 centiseconds = 1:00.00"));
            memoryValues.Add(new MemoryValue("1st Place - Best Lap", 0x004C54FC, "Int32", "Race Results - 1st", "Divide by 40 for centiseconds",
@"Raw value / 40 = centiseconds
Example: 240000 / 40 = 6000 centiseconds = 1:00.00"));
            memoryValues.Add(new MemoryValue("1st Place - Top Speed", 0x004C5504, "Float", "Race Results - 1st", "Multiply by 2.237 for correct value",
@"Raw value * 2.237 = mph
Speed conversion factor"));
            memoryValues.Add(new MemoryValue("1st Place - Avg Speed", 0x004C5508, "Float", "Race Results - 1st", "Multiply by 2.237 for correct value",
@"Raw value * 2.237 = mph
Speed conversion factor"));
            memoryValues.Add(new MemoryValue("1st Place - Laps Led", 0x004C5594, "Int32", "Race Results - 1st", "Number of laps led"));

            // Race Results - 2nd Place
            memoryValues.Add(new MemoryValue("2nd Place Check", 0x004C564C, "Int8", "Race Results - 2nd", "00=Player, 64=AI1, 65=AI2, 66=AI3",
@"Position identifier:
0x00 = Player
0x64 = AI Opponent 1
0x65 = AI Opponent 2
0x66 = AI Opponent 3"));
            memoryValues.Add(new MemoryValue("2nd Place - Overall Time", 0x004C5654, "Int32", "Race Results - 2nd", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("2nd Place - Best Lap", 0x004C5658, "Int32", "Race Results - 2nd", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("2nd Place - Top Speed", 0x004C5660, "Float", "Race Results - 2nd", "Multiply by 2.237 for correct value"));
            memoryValues.Add(new MemoryValue("2nd Place - Avg Speed", 0x004C5664, "Float", "Race Results - 2nd", "Multiply by 2.237 for correct value"));

            // Race Results - 3rd Place
            memoryValues.Add(new MemoryValue("3rd Place Check", 0x004C57A8, "Int8", "Race Results - 3rd", "00=Player, 64=AI1, 65=AI2, 66=AI3",
@"Position identifier:
0x00 = Player
0x64 = AI Opponent 1
0x65 = AI Opponent 2
0x66 = AI Opponent 3"));
            memoryValues.Add(new MemoryValue("3rd Place - Overall Time", 0x004C57B0, "Int32", "Race Results - 3rd", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("3rd Place - Best Lap", 0x004C57B4, "Int32", "Race Results - 3rd", "Divide by 40 for centiseconds"));

            // Race Results - 4th Place
            memoryValues.Add(new MemoryValue("4th Place Check", 0x004C5904, "Int8", "Race Results - 4th", "00=Player, 64=AI1, 65=AI2, 66=AI3",
@"Position identifier:
0x00 = Player
0x64 = AI Opponent 1
0x65 = AI Opponent 2
0x66 = AI Opponent 3"));
            memoryValues.Add(new MemoryValue("4th Place - Overall Time", 0x004C590C, "Int32", "Race Results - 4th", "Divide by 40 for centiseconds"));

            // Drift Mode
            memoryValues.Add(new MemoryValue("Drift - Score Lap 1", 0x004C55E4, "Int32", "Drift Mode", "Score after lap 1"));
            memoryValues.Add(new MemoryValue("Drift - Score Lap 2", 0x004C55E8, "Int32", "Drift Mode", "Score after lap 2"));
            memoryValues.Add(new MemoryValue("Drift - Score Lap 3", 0x004C55EC, "Int32", "Drift Mode", "Score after lap 3"));
            memoryValues.Add(new MemoryValue("Drift - Best Drift Score", 0x004C5634, "Int32", "Drift Mode", "Best single drift score"));
            memoryValues.Add(new MemoryValue("Drift - Longest Drift", 0x004C5638, "Float", "Drift Mode", "Longest drift distance"));

            // Drag Race
            memoryValues.Add(new MemoryValue("Drag - Perfect Shifts (1st)", 0x004C563C, "Int8", "Drag Race", "Perfect shifts - 1st place car"));
            memoryValues.Add(new MemoryValue("Drag - Total Shifts (1st)", 0x004C5640, "Int8", "Drag Race", "Total shifts - 1st place car"));
            memoryValues.Add(new MemoryValue("Drag - Perfect Shifts (2nd)", 0x004C5798, "Int8", "Drag Race", "Perfect shifts - 2nd place car"));
            memoryValues.Add(new MemoryValue("Drag - Total Shifts (2nd)", 0x004C579C, "Int8", "Drag Race", "Total shifts - 2nd place car"));

            // Statistics - Global
            memoryValues.Add(new MemoryValue("Stats - Global Starts", 0x004B595C, "Int32", "Statistics - Global", "Total races started"));
            memoryValues.Add(new MemoryValue("Stats - Global Wins", 0x004B5960, "Int32", "Statistics - Global", "Total wins"));
            memoryValues.Add(new MemoryValue("Stats - Global Losses", 0x004B5964, "Int32", "Statistics - Global", "Total losses"));

            // Statistics - Sprint
            memoryValues.Add(new MemoryValue("Stats - Sprint Starts", 0x004B5968, "Int32", "Statistics - Sprint", "Sprint races started"));
            memoryValues.Add(new MemoryValue("Stats - Sprint Wins", 0x004B596C, "Int32", "Statistics - Sprint", "Sprint wins"));
            memoryValues.Add(new MemoryValue("Stats - Sprint Style Pts", 0x004B5970, "Int32", "Statistics - Sprint", "Sprint style points"));

            // Statistics - Drag
            memoryValues.Add(new MemoryValue("Stats - Drag Starts", 0x004B5974, "Int32", "Statistics - Drag", "Drag races started"));
            memoryValues.Add(new MemoryValue("Stats - Drag Wins", 0x004B5978, "Int32", "Statistics - Drag", "Drag wins"));
            memoryValues.Add(new MemoryValue("Stats - Drag Style Pts", 0x004B597C, "Int32", "Statistics - Drag", "Drag style points"));
            memoryValues.Add(new MemoryValue("Stats - Drag Times Totaled", 0x004B59A4, "Int32", "Statistics - Drag", "Times car totaled in drag"));

            // Statistics - Drift
            memoryValues.Add(new MemoryValue("Stats - Drift Starts", 0x004B5980, "Int32", "Statistics - Drift", "Drift races started"));
            memoryValues.Add(new MemoryValue("Stats - Drift Wins", 0x004B5984, "Int32", "Statistics - Drift", "Drift wins"));
            memoryValues.Add(new MemoryValue("Stats - Drift Style Pts", 0x004B5988, "Int32", "Statistics - Drift", "Drift style points"));

            // Statistics - Circuit
            memoryValues.Add(new MemoryValue("Stats - Circuit Starts", 0x004B598C, "Int32", "Statistics - Circuit", "Circuit races started"));
            memoryValues.Add(new MemoryValue("Stats - Circuit Wins", 0x004B5990, "Int32", "Statistics - Circuit", "Circuit wins"));
            memoryValues.Add(new MemoryValue("Stats - Circuit Style Pts", 0x004B5994, "Int32", "Statistics - Circuit", "Circuit style points"));

            // Magazines (Unlockables)
            memoryValues.Add(new MemoryValue("Magazine 1 - Circuit 10th", 0x004ADA40, "Int8", "Magazines", "Ranked 10th in Circuit"));
            memoryValues.Add(new MemoryValue("Magazine 2 - Sprint 9th", 0x004ADE94, "Int8", "Magazines", "Ranked 9th in Sprint"));
            memoryValues.Add(new MemoryValue("Magazine 3 - Drift 10th", 0x004AE2E8, "Int8", "Magazines", "Ranked 10th in Drift"));
            memoryValues.Add(new MemoryValue("Magazine 4 - Drag 7th", 0x004AE73C, "Int8", "Magazines", "Ranked 7th in Drag"));
            memoryValues.Add(new MemoryValue("Magazine 10 - Win All Tournaments", 0x004B0134, "Int8", "Magazines", "Win all tournaments"));
            memoryValues.Add(new MemoryValue("Magazine 11 - Overall Title", 0x004B0588, "Int8", "Magazines", "Win overall title"));
            memoryValues.Add(new MemoryValue("Magazine 12 - All Level 1 Perf", 0x004B09DC, "Int8", "Magazines", "All Level 1 performance upgrades"));
            memoryValues.Add(new MemoryValue("Magazine 13 - All Level 2 Perf", 0x004B0E30, "Int8", "Magazines", "All Level 2 performance upgrades"));
            memoryValues.Add(new MemoryValue("Magazine 14 - All Level 3 Perf", 0x004B1284, "Int8", "Magazines", "All Level 3 performance upgrades"));
            memoryValues.Add(new MemoryValue("Magazine 15 - 1 Star Reputation", 0x004B16D8, "Int8", "Magazines", "Built 1 star reputation car"));

            // Underground Mode Events (112 events at 0x004AC9E4 - 0x004ACA55)
            memoryValues.Add(new MemoryValue("UG Event 0 - Tutorial", 0x004AC9E4, "Int8", "UG Mode - Events", "01=Access, 02=Won, 03=In, 05=Quit",
@"Event Status Values:
0x01 = Accessible (can enter)
0x02 = Won (completed)
0x03 = Currently in event
0x05 = Quit (exited event)

This is the tutorial event that teaches basic controls."));
            memoryValues.Add(new MemoryValue("UG Event 1 - Jose's Got Your Back", 0x004AC9E5, "Int8", "UG Mode - Events", "Circuit race",
@"Event Status Values:
0x01 = Accessible
0x02 = Won
0x03 = Currently in event
0x05 = Quit

Circuit race event"));
            memoryValues.Add(new MemoryValue("UG Event 2 - Last One There", 0x004AC9E6, "Int8", "UG Mode - Events", "Sprint race",
@"Event Status Values:
0x01 = Accessible
0x02 = Won
0x03 = Currently in event
0x05 = Quit

Sprint race event"));
            memoryValues.Add(new MemoryValue("UG Event 3 - Style And Finesse", 0x004AC9E7, "Int8", "UG Mode - Events", "Drift race",
@"Event Status Values:
0x01 = Accessible
0x02 = Won
0x03 = Currently in event
0x05 = Quit

Drift race event"));
            memoryValues.Add(new MemoryValue("UG Event 4 - Perfect Shift", 0x004AC9E8, "Int8", "UG Mode - Events", "Drag race",
@"Event Status Values:
0x01 = Accessible
0x02 = Won
0x03 = Currently in event
0x05 = Quit

Drag race event"));
            memoryValues.Add(new MemoryValue("UG Event 5 - Lap Knock Out", 0x004AC9E9, "Int8", "UG Mode - Events", "Lap KO race",
@"Event Status Values:
0x01 = Accessible
0x02 = Won
0x03 = Currently in event
0x05 = Quit

Lap Knockout race event"));
            memoryValues.Add(new MemoryValue("UG Event 6 - Rookie Tournament", 0x004AC9EA, "Int8", "UG Mode - Events", "Tournament",
@"Event Status Values:
0x01 = Accessible
0x02 = Won
0x03 = Currently in event
0x05 = Quit

Tournament event with multiple races"));
            memoryValues.Add(new MemoryValue("UG Event 7 - Drag Tournament 1", 0x004AC9EB, "Int8", "UG Mode - Events", "Drag Tournament"));
            memoryValues.Add(new MemoryValue("UG Event 8 - Drifting the Night", 0x004AC9EC, "Int8", "UG Mode - Events", "Drift event"));
            memoryValues.Add(new MemoryValue("UG Event 9 - Sprinting 101", 0x004AC9ED, "Int8", "UG Mode - Events", "Sprint event"));
            memoryValues.Add(new MemoryValue("UG Event 10 - Olympic Square", 0x004AC9EE, "Int8", "UG Mode - Events", "Circuit race"));
            memoryValues.Add(new MemoryValue("UG Event 11 - Terminal", 0x004AC9EF, "Int8", "UG Mode - Events", "Lap KO race"));
            memoryValues.Add(new MemoryValue("UG Event 12 - Bedard Bridge", 0x004AC9F0, "Int8", "UG Mode - Events", "Circuit race"));
            memoryValues.Add(new MemoryValue("UG Event 13 - Amateur Tournament", 0x004AC9F1, "Int8", "UG Mode - Events", "Tournament"));
            memoryValues.Add(new MemoryValue("UG Event 14 - Drag Tournament 2", 0x004AC9F2, "Int8", "UG Mode - Events", "Drag Tournament"));
            memoryValues.Add(new MemoryValue("UG Event 15 - Drift Competition", 0x004AC9F3, "Int8", "UG Mode - Events", "Drift event"));
            memoryValues.Add(new MemoryValue("UG Event 111 - Legend of Street", 0x004ACA55, "Int8", "UG Mode - Events", "Final event - Circuit",
@"Event Status Values:
0x01 = Accessible
0x02 = Won
0x03 = Currently in event
0x05 = Quit

FINAL EVENT - Legend of the Street
Win this to complete Underground Mode!"));

            // ===== QUICK RACE - VEHICLE PERFORMANCE UPGRADES =====
            // VW Golf GTI
            memoryValues.Add(new MemoryValue("VW Golf GTI - Weight Reduction", 0x004A86E0, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - Suspension", 0x004A86E4, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - Engine/Exhaust", 0x004A86E8, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - Turbo", 0x004A86EC, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - Nitrous", 0x004A86F0, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - ECU/Fuel", 0x004A86F4, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - Drivetrain", 0x004A86F8, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - Tires", 0x004A86FC, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("VW Golf GTI - Brakes", 0x004A8700, "Int8", "QR - VW Golf GTI", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Ford Focus
            memoryValues.Add(new MemoryValue("Ford Focus - Weight Reduction", 0x004A8A28, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - Suspension", 0x004A8A2C, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - Engine/Exhaust", 0x004A8A30, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - Turbo", 0x004A8A34, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - Nitrous", 0x004A8A38, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - ECU/Fuel", 0x004A8A3C, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - Drivetrain", 0x004A8A40, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - Tires", 0x004A8A44, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Ford Focus - Brakes", 0x004A8A48, "Int8", "QR - Ford Focus", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Mazda Miata MX-5
            memoryValues.Add(new MemoryValue("Mazda Miata - Weight Reduction", 0x004A8D70, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - Suspension", 0x004A8D74, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - Engine/Exhaust", 0x004A8D78, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - Turbo", 0x004A8D7C, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - Nitrous", 0x004A8D80, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - ECU/Fuel", 0x004A8D84, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - Drivetrain", 0x004A8D88, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - Tires", 0x004A8D8C, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda Miata - Brakes", 0x004A8D90, "Int8", "QR - Mazda Miata", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Dodge Neon
            memoryValues.Add(new MemoryValue("Dodge Neon - Weight Reduction", 0x004A90B8, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - Suspension", 0x004A90BC, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - Engine/Exhaust", 0x004A90C0, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - Turbo", 0x004A90C4, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - Nitrous", 0x004A90C8, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - ECU/Fuel", 0x004A90CC, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - Drivetrain", 0x004A90D0, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - Tires", 0x004A90D4, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Dodge Neon - Brakes", 0x004A90D8, "Int8", "QR - Dodge Neon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Honda Civic
            memoryValues.Add(new MemoryValue("Honda Civic - Weight Reduction", 0x004A9400, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - Suspension", 0x004A9404, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - Engine/Exhaust", 0x004A9408, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - Turbo", 0x004A940C, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - Nitrous", 0x004A9410, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - ECU/Fuel", 0x004A9414, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - Drivetrain", 0x004A9418, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - Tires", 0x004A941C, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda Civic - Brakes", 0x004A9420, "Int8", "QR - Honda Civic", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Peugeot 206
            memoryValues.Add(new MemoryValue("Peugeot 206 - Weight Reduction", 0x004A9748, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - Suspension", 0x004A974C, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - Engine/Exhaust", 0x004A9750, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - Turbo", 0x004A9754, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - Nitrous", 0x004A9758, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - ECU/Fuel", 0x004A975C, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - Drivetrain", 0x004A9760, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - Tires", 0x004A9764, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Peugeot 206 - Brakes", 0x004A9768, "Int8", "QR - Peugeot 206", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Nissan Sentra SE-R
            memoryValues.Add(new MemoryValue("Nissan Sentra - Weight Reduction", 0x004A9A90, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - Suspension", 0x004A9A94, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - Engine/Exhaust", 0x004A9A98, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - Turbo", 0x004A9A9C, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - Nitrous", 0x004A9AA0, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - ECU/Fuel", 0x004A9AA4, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - Drivetrain", 0x004A9AA8, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - Tires", 0x004A9AAC, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Sentra - Brakes", 0x004A9AB0, "Int8", "QR - Nissan Sentra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Toyota Celica
            memoryValues.Add(new MemoryValue("Toyota Celica - Weight Reduction", 0x004A9DD8, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - Suspension", 0x004A9DDC, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - Engine/Exhaust", 0x004A9DE0, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - Turbo", 0x004A9DE4, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - Nitrous", 0x004A9DE8, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - ECU/Fuel", 0x004A9DEC, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - Drivetrain", 0x004A9DF0, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - Tires", 0x004A9DF4, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Celica - Brakes", 0x004A9DF8, "Int8", "QR - Toyota Celica", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Acura Integra Type R
            memoryValues.Add(new MemoryValue("Acura Integra - Weight Reduction", 0x004AA120, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - Suspension", 0x004AA124, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - Engine/Exhaust", 0x004AA128, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - Turbo", 0x004AA12C, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - Nitrous", 0x004AA130, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - ECU/Fuel", 0x004AA134, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - Drivetrain", 0x004AA138, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - Tires", 0x004AA13C, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura Integra - Brakes", 0x004AA140, "Int8", "QR - Acura Integra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Subaru Impreza 2.5 RS
            memoryValues.Add(new MemoryValue("Subaru Impreza - Weight Reduction", 0x004AA468, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - Suspension", 0x004AA46C, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - Engine/Exhaust", 0x004AA470, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - Turbo", 0x004AA474, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - Nitrous", 0x004AA478, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - ECU/Fuel", 0x004AA47C, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - Drivetrain", 0x004AA480, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - Tires", 0x004AA484, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Subaru Impreza - Brakes", 0x004AA488, "Int8", "QR - Subaru Impreza", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Mitsubishi Eclipse
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Weight Reduction", 0x004AA7B0, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Suspension", 0x004AA7B4, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Engine/Exhaust", 0x004AA7B8, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Turbo", 0x004AA7BC, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Nitrous", 0x004AA7C0, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - ECU/Fuel", 0x004AA7C4, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Drivetrain", 0x004AA7C8, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Tires", 0x004AA7CC, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Eclipse - Brakes", 0x004AA7D0, "Int8", "QR - Mitsubishi Eclipse", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Acura RSX Type-S
            memoryValues.Add(new MemoryValue("Acura RSX - Weight Reduction", 0x004AAAF8, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - Suspension", 0x004AAAFC, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - Engine/Exhaust", 0x004AAB00, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - Turbo", 0x004AAB04, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - Nitrous", 0x004AAB08, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - ECU/Fuel", 0x004AAB0C, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - Drivetrain", 0x004AAB10, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - Tires", 0x004AAB14, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Acura RSX - Brakes", 0x004AAB18, "Int8", "QR - Acura RSX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Hyundai Tiburon GT
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Weight Reduction", 0x004AAE40, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Suspension", 0x004AAE44, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Engine/Exhaust", 0x004AAE48, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Turbo", 0x004AAE4C, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Nitrous", 0x004AAE50, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - ECU/Fuel", 0x004AAE54, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Drivetrain", 0x004AAE58, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Tires", 0x004AAE5C, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Hyundai Tiburon - Brakes", 0x004AAE60, "Int8", "QR - Hyundai Tiburon", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Nissan 240SX
            memoryValues.Add(new MemoryValue("Nissan 240SX - Weight Reduction", 0x004AB188, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - Suspension", 0x004AB18C, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - Engine/Exhaust", 0x004AB190, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - Turbo", 0x004AB194, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - Nitrous", 0x004AB198, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - ECU/Fuel", 0x004AB19C, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - Drivetrain", 0x004AB1A0, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - Tires", 0x004AB1A4, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 240SX - Brakes", 0x004AB1A8, "Int8", "QR - Nissan 240SX", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Mazda RX-7
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Weight Reduction", 0x004AB4D0, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Suspension", 0x004AB4D4, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Engine/Exhaust", 0x004AB4D8, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Turbo", 0x004AB4DC, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Nitrous", 0x004AB4E0, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - ECU/Fuel", 0x004AB4E4, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Drivetrain", 0x004AB4E8, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Tires", 0x004AB4EC, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mazda RX-7 - Brakes", 0x004AB4F0, "Int8", "QR - Mazda RX-7", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Honda S2000
            memoryValues.Add(new MemoryValue("Honda S2000 - Weight Reduction", 0x004AB818, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - Suspension", 0x004AB81C, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - Engine/Exhaust", 0x004AB820, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - Turbo", 0x004AB824, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - Nitrous", 0x004AB828, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - ECU/Fuel", 0x004AB82C, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - Drivetrain", 0x004AB830, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - Tires", 0x004AB834, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Honda S2000 - Brakes", 0x004AB838, "Int8", "QR - Honda S2000", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Toyota Supra
            memoryValues.Add(new MemoryValue("Toyota Supra - Weight Reduction", 0x004ABB60, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - Suspension", 0x004ABB64, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - Engine/Exhaust", 0x004ABB68, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - Turbo", 0x004ABB6C, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - Nitrous", 0x004ABB70, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - ECU/Fuel", 0x004ABB74, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - Drivetrain", 0x004ABB78, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - Tires", 0x004ABB7C, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Toyota Supra - Brakes", 0x004ABB80, "Int8", "QR - Toyota Supra", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Nissan 350Z
            memoryValues.Add(new MemoryValue("Nissan 350Z - Weight Reduction", 0x004ABEA8, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - Suspension", 0x004ABEAC, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - Engine/Exhaust", 0x004ABEB0, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - Turbo", 0x004ABEB4, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - Nitrous", 0x004ABEB8, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - ECU/Fuel", 0x004ABEBC, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - Drivetrain", 0x004ABEC0, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - Tires", 0x004ABEC4, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan 350Z - Brakes", 0x004ABEC8, "Int8", "QR - Nissan 350Z", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Nissan Skyline
            memoryValues.Add(new MemoryValue("Nissan Skyline - Weight Reduction", 0x004AC1F0, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - Suspension", 0x004AC1F4, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - Engine/Exhaust", 0x004AC1F8, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - Turbo", 0x004AC1FC, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - Nitrous", 0x004AC200, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - ECU/Fuel", 0x004AC204, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - Drivetrain", 0x004AC208, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - Tires", 0x004AC20C, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Nissan Skyline - Brakes", 0x004AC210, "Int8", "QR - Nissan Skyline", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            // Mitsubishi Lancer Evolution VII
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Weight Reduction", 0x004AC538, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Suspension", 0x004AC53C, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Engine/Exhaust", 0x004AC540, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Turbo", 0x004AC544, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Nitrous", 0x004AC548, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - ECU/Fuel", 0x004AC54C, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Drivetrain", 0x004AC550, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Tires", 0x004AC554, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("Mitsubishi Evo VII - Brakes", 0x004AC558, "Int8", "QR - Mitsubishi Evo VII", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

            return memoryValues;
        }
    }
}
