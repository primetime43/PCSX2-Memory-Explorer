using Common;
using System.Collections.Generic;

namespace Need_for_Speed.Config
{
    public class NFSUndergroundConfig : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Underground (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State
            memoryValues.Add(new MemoryValue("In Game Check", 0x0042EDB4, "Int8", "Game State", "00=In Game (racing)"));
            memoryValues.Add(new MemoryValue("Main Menu Check", 0x004E8FF0, "Int8", "Game State", "01=Main Menu"));
            memoryValues.Add(new MemoryValue("Difficulty", 0x0046FBE4, "Int8", "Game State", "00=Easy, 01=Medium, 02=Hard"));
            memoryValues.Add(new MemoryValue("Current Mode", 0x004C5368, "Int32", "Game State", "Bit 0=Underground, Bit 1=Quick Race, Bit 2=Split-Screen"));
            memoryValues.Add(new MemoryValue("Quick Race Mode Select", 0x004C54E4, "Int8", "Game State", "00=Circuit, 01=Sprint, 02=Lap Knockout, 03=Free Run, 05=Drag, 06=Drift"));
            memoryValues.Add(new MemoryValue("Winner Check (ASCII)", 0x0050D0A8, "Int32", "Game State", "6e6e6957=Winner! (drag race)"));

            // Currency & Points
            memoryValues.Add(new MemoryValue("Bank (Money)", 0x004ADA0C, "Int32", "Currency", "Total money"));
            memoryValues.Add(new MemoryValue("Total Style Points", 0x004A6274, "Int32", "Currency", "Accumulated style points"));

            // Quick Race - Circuit Options
            memoryValues.Add(new MemoryValue("QR Circuit - Track Select", 0x004A60D4, "Int16", "Quick Race - Circuit", "03eb=Olympic Square, 03ed=Atlantica, etc."));
            memoryValues.Add(new MemoryValue("QR Circuit - Reverse Status", 0x004A60D8, "Int8", "Quick Race - Circuit", "00=Standard, 01=Reverse"));
            memoryValues.Add(new MemoryValue("QR Circuit - Number of Laps", 0x004A60DC, "Int8", "Quick Race - Circuit", "01-0A (1-10 laps)"));
            memoryValues.Add(new MemoryValue("QR Circuit - Opponent Skill", 0x004A60E0, "Int8", "Quick Race - Circuit", "00=Easy, 01=Medium, 02=Hard"));
            memoryValues.Add(new MemoryValue("QR Circuit - Traffic", 0x004A60E4, "Int8", "Quick Race - Circuit", "00=None, 01=Min, 02=Mod, 03=Max"));
            memoryValues.Add(new MemoryValue("QR Circuit - Catch Up", 0x004A60F4, "Int8", "Quick Race - Circuit", "00=Off, 01=On"));

            // Quick Race - Sprint Options
            memoryValues.Add(new MemoryValue("QR Sprint - Course Select", 0x004A6100, "Int16", "Quick Race - Sprint", "044e=Liberty Gardens, 044f=Broadway, etc."));
            memoryValues.Add(new MemoryValue("QR Sprint - Reverse Status", 0x004A6104, "Int8", "Quick Race - Sprint", "00=Standard, 01=Reverse"));
            memoryValues.Add(new MemoryValue("QR Sprint - Opponent Skill", 0x004A610C, "Int8", "Quick Race - Sprint", "00=Easy, 01=Medium, 02=Hard"));
            memoryValues.Add(new MemoryValue("QR Sprint - Traffic", 0x004A6110, "Int8", "Quick Race - Sprint", "00=None, 01=Min, 02=Mod, 03=Max"));
            memoryValues.Add(new MemoryValue("QR Sprint - Catch Up", 0x004A6120, "Int8", "Quick Race - Sprint", "00=Off, 01=On"));

            // Quick Race - Lap Knockout Options
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Track", 0x004A612C, "Int16", "Quick Race - Lap KO", "Track selection"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Reverse", 0x004A6130, "Int8", "Quick Race - Lap KO", "00=Standard, 01=Reverse"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Skill", 0x004A6138, "Int8", "Quick Race - Lap KO", "00=Easy, 01=Medium, 02=Hard"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Traffic", 0x004A613C, "Int8", "Quick Race - Lap KO", "00=None, 01=Min, 02=Mod, 03=Max"));
            memoryValues.Add(new MemoryValue("QR Lap Knockout - Catch Up", 0x004A614C, "Int8", "Quick Race - Lap KO", "00=Off, 01=On"));

            // Quick Race - Drag Options
            memoryValues.Add(new MemoryValue("QR Drag - Course Select", 0x004A6218, "Int16", "Quick Race - Drag", "04b1=14th & Vine Construction, etc."));
            memoryValues.Add(new MemoryValue("QR Drag - Reverse Status", 0x004A621C, "Int8", "Quick Race - Drag", "00=Standard, 01=Reverse"));
            memoryValues.Add(new MemoryValue("QR Drag - Opponent Skill", 0x004A6224, "Int8", "Quick Race - Drag", "00=Easy, 01=Medium, 02=Hard"));
            memoryValues.Add(new MemoryValue("QR Drag - Traffic", 0x004A6228, "Int8", "Quick Race - Drag", "00=None, 01=Min, 02=Mod, 03=Max"));

            // Quick Race - Drift Options
            memoryValues.Add(new MemoryValue("QR Drift - Course Select", 0x004A6250, "Int16", "Quick Race - Drift", "0515-051c (Drift Tracks 1-8)"));

            // Underground Mode - Performance Upgrades (Current Car)
            memoryValues.Add(new MemoryValue("UG - Weight Reduction", 0x004AC978, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - Suspension", 0x004AC97C, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - Engine/Exhaust", 0x004AC980, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - Turbo", 0x004AC984, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - Nitrous Oxide", 0x004AC988, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - ECU/Fuel System", 0x004AC98C, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - Drivetrain", 0x004AC990, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - Tires", 0x004AC994, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));
            memoryValues.Add(new MemoryValue("UG - Brakes", 0x004AC998, "Int8", "UG Mode - Performance", "00=Stock, 01=Street, 02=Pro, 03=Extreme"));

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
            memoryValues.Add(new MemoryValue("1st Place Check", 0x004C54F0, "Int8", "Race Results - 1st", "00=Player, 64=AI1, 65=AI2, 66=AI3"));
            memoryValues.Add(new MemoryValue("1st Place - Overall Time", 0x004C54F8, "Int32", "Race Results - 1st", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("1st Place - Best Lap", 0x004C54FC, "Int32", "Race Results - 1st", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("1st Place - Top Speed", 0x004C5504, "Float", "Race Results - 1st", "Multiply by 2.237 for correct value"));
            memoryValues.Add(new MemoryValue("1st Place - Avg Speed", 0x004C5508, "Float", "Race Results - 1st", "Multiply by 2.237 for correct value"));
            memoryValues.Add(new MemoryValue("1st Place - Laps Led", 0x004C5594, "Int32", "Race Results - 1st", "Number of laps led"));

            // Race Results - 2nd Place
            memoryValues.Add(new MemoryValue("2nd Place Check", 0x004C564C, "Int8", "Race Results - 2nd", "00=Player, 64=AI1, 65=AI2, 66=AI3"));
            memoryValues.Add(new MemoryValue("2nd Place - Overall Time", 0x004C5654, "Int32", "Race Results - 2nd", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("2nd Place - Best Lap", 0x004C5658, "Int32", "Race Results - 2nd", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("2nd Place - Top Speed", 0x004C5660, "Float", "Race Results - 2nd", "Multiply by 2.237 for correct value"));
            memoryValues.Add(new MemoryValue("2nd Place - Avg Speed", 0x004C5664, "Float", "Race Results - 2nd", "Multiply by 2.237 for correct value"));

            // Race Results - 3rd Place
            memoryValues.Add(new MemoryValue("3rd Place Check", 0x004C57A8, "Int8", "Race Results - 3rd", "00=Player, 64=AI1, 65=AI2, 66=AI3"));
            memoryValues.Add(new MemoryValue("3rd Place - Overall Time", 0x004C57B0, "Int32", "Race Results - 3rd", "Divide by 40 for centiseconds"));
            memoryValues.Add(new MemoryValue("3rd Place - Best Lap", 0x004C57B4, "Int32", "Race Results - 3rd", "Divide by 40 for centiseconds"));

            // Race Results - 4th Place
            memoryValues.Add(new MemoryValue("4th Place Check", 0x004C5904, "Int8", "Race Results - 4th", "00=Player, 64=AI1, 65=AI2, 66=AI3"));
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

            // Sample Underground Mode Events (first 10 of 112)
            memoryValues.Add(new MemoryValue("UG Event 0 - Tutorial", 0x004AC9E4, "Int8", "UG Mode - Events", "01=Access, 02=Won, 03=In, 05=Quit"));
            memoryValues.Add(new MemoryValue("UG Event 1 - Jose's Got Your Back", 0x004AC9E5, "Int8", "UG Mode - Events", "Circuit race"));
            memoryValues.Add(new MemoryValue("UG Event 2 - Last One There", 0x004AC9E6, "Int8", "UG Mode - Events", "Sprint race"));
            memoryValues.Add(new MemoryValue("UG Event 3 - Style And Finesse", 0x004AC9E7, "Int8", "UG Mode - Events", "Drift race"));
            memoryValues.Add(new MemoryValue("UG Event 4 - Perfect Shift", 0x004AC9E8, "Int8", "UG Mode - Events", "Drag race"));
            memoryValues.Add(new MemoryValue("UG Event 5 - Lap Knock Out", 0x004AC9E9, "Int8", "UG Mode - Events", "Lap KO race"));
            memoryValues.Add(new MemoryValue("UG Event 6 - Rookie Tournament", 0x004AC9EA, "Int8", "UG Mode - Events", "Tournament"));
            memoryValues.Add(new MemoryValue("UG Event 111 - Legend of Street", 0x004ACA55, "Int8", "UG Mode - Events", "Final event - Circuit"));

            return memoryValues;
        }
    }
}
