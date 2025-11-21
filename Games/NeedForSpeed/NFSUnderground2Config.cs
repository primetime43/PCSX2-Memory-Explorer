using Common;
using System.Collections.Generic;

namespace Games.NeedForSpeed
{
    public class NFSUnderground2Config : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Underground 2 (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State & Progression
            memoryValues.Add(new MemoryValue("Completion %", 0x004ED560, "Float", "Game State", "Overall completion percentage"));
            memoryValues.Add(new MemoryValue("Current Stage", 0x004FA42C, "Int32", "Game State", "Current stage number"));
            memoryValues.Add(new MemoryValue("Number of Events Completed", 0x004FA430, "Int32", "Game State", "Total events completed (includes cutscenes, shops discovered, etc.)"));
            memoryValues.Add(new MemoryValue("Career Difficulty", 0x004FB7E4, "Int8", "Game State", "0=Easy, 1=Medium, 2=Hard"));
            memoryValues.Add(new MemoryValue("Main Menu Selection", 0x0051C408, "Int8", "Game State", "01=Career, 02=Quick Race"));

            // Currency & Messages
            memoryValues.Add(new MemoryValue("Bank", 0x004F9A64, "Int32", "Currency", "Total money"));
            memoryValues.Add(new MemoryValue("SMS Messages Total", 0x004F9A50, "Int32", "Messages", "Total number of SMS messages"));
            memoryValues.Add(new MemoryValue("SMS Messages Unread", 0x004F9A54, "Int32", "Messages", "Number of unread SMS messages"));

            // Current Activity
            memoryValues.Add(new MemoryValue("Current Car ID", 0x004EF700, "Int32", "Current Activity", "ID of currently active car"));
            memoryValues.Add(new MemoryValue("Current Neon Underglow", 0x004EFEF8, "Int8", "Current Activity", "Currently applied neon underglow"));
            memoryValues.Add(new MemoryValue("Current Event ID", 0x004FB048, "Int32", "Current Activity", "ID of current event"));
            memoryValues.Add(new MemoryValue("Current Photography Event Bool", 0x004F6B38, "Int32", "Current Activity", "0x00=not completed, 0x01=completed"));
            memoryValues.Add(new MemoryValue("Current Photography Event", 0x004F6B3C, "Int32", "Current Activity", "Current photography event ID"));
            memoryValues.Add(new MemoryValue("Race Car is On Top Of", 0x004FB050, "Int32", "Current Activity", "Race ID that car is positioned on"));
            memoryValues.Add(new MemoryValue("Current Shop ID", 0x004FB058, "Int32", "Current Activity", "ID of shop you are on top of"));
            memoryValues.Add(new MemoryValue("Active Race ID", 0x004FB064, "Int32", "Current Activity", "Race ID of active race"));
            memoryValues.Add(new MemoryValue("Current Speed", 0x01CACDA0, "Int32", "Current Activity", "Current speed"));

            // Garage & Cars
            memoryValues.Add(new MemoryValue("Garage Slot Active", 0x004FB080, "Int8", "Garage", "0xa0=Tutorial, 0xa1=Slot 1, 0xa2=Slot 2, 0xa3=Slot 3, 0xa4=Slot 4, 0xa5=Slot 5"));
            memoryValues.Add(new MemoryValue("Car ID - Garage Slot 1", 0x005012A0, "Int32", "Garage", "Car ID in garage slot 1"));
            memoryValues.Add(new MemoryValue("Car ID - Garage Slot 2", 0x00501A9C, "Int32", "Garage", "Car ID in garage slot 2"));
            memoryValues.Add(new MemoryValue("Car ID - Garage Slot 3", 0x00502298, "Int32", "Garage", "Car ID in garage slot 3"));
            memoryValues.Add(new MemoryValue("Car ID - Garage Slot 4", 0x00502A94, "Int32", "Garage", "Car ID in garage slot 4"));
            memoryValues.Add(new MemoryValue("Car ID - Garage Slot 5", 0x00503290, "Int32", "Garage", "Car ID in garage slot 5"));

            // Tutorial
            memoryValues.Add(new MemoryValue("Tutorial - 1st Race ID", 0x004F9C0C, "Int32", "Tutorial", "1st completed race ID (0xca207583=Hidden Circuit, 0xca207584=Circuit, 0x1bcb7ab0=Sprint)"));
            memoryValues.Add(new MemoryValue("Tutorial - 2nd Race ID", 0x004F9C10, "Int32", "Tutorial", "2nd completed race ID"));
            memoryValues.Add(new MemoryValue("Tutorial - 3rd Race ID", 0x004F9C14, "Int32", "Tutorial", "3rd completed race ID"));
            memoryValues.Add(new MemoryValue("Tutorial Outruns Won", 0x004F9CE8, "Int32", "Tutorial", "Number of outruns won in tutorial"));
            memoryValues.Add(new MemoryValue("Tutorial Completed", 0x004F9D08, "Int32", "Tutorial", "Bool - Tutorial completed/Stage 1 unlocked"));

            // Stage 1
            memoryValues.Add(new MemoryValue("Stage 1 - First Race Completed", 0x004F9D10, "Int32", "Stage 1", "Race ID of first race completed"));

            // Stage 2
            memoryValues.Add(new MemoryValue("Stage 2 - Completed Races Array", 0x004F9E14, "Int32", "Stage 2", "Race IDs completed [140 bytes array]"));
            memoryValues.Add(new MemoryValue("Stage 2 - Sponsor Events Array", 0x004F9EA0, "Int32", "Stage 2", "Race IDs for sponsor events [12 bytes]"));
            memoryValues.Add(new MemoryValue("Stage 2 - URL Events Array", 0x004F9EB0, "Int32", "Stage 2", "Race IDs for URL events [12 bytes]"));
            memoryValues.Add(new MemoryValue("Stage 2 Outruns Won", 0x004F9EF0, "Int32", "Stage 2", "Number of outruns won"));

            // Stage 3
            memoryValues.Add(new MemoryValue("Stage 3 - Completed Races Array", 0x004F9F18, "Int32", "Stage 3", "Race IDs completed [140 bytes array]"));
            memoryValues.Add(new MemoryValue("Stage 3 - Sponsor Events Array", 0x004F9FA4, "Int32", "Stage 3", "Race ID array start for sponsor events"));
            memoryValues.Add(new MemoryValue("Stage 3 - 3rd Sponsor Event", 0x004F9FAC, "Int32", "Stage 3", "3rd sponsor event race ID"));
            memoryValues.Add(new MemoryValue("Stage 3 - URL Events Array", 0x004F9FB4, "Int32", "Stage 3", "Race ID array start for URL events"));
            memoryValues.Add(new MemoryValue("Stage 3 Outruns Won", 0x004F9FF4, "Int32", "Stage 3", "Number of outruns won"));

            // Stage 4
            memoryValues.Add(new MemoryValue("Stage 4 - Completed Races Array", 0x004FA01C, "Int32", "Stage 4", "Race IDs completed [140 bytes, holds 35 entries]"));
            memoryValues.Add(new MemoryValue("Stage 4 - Sponsor Events Array", 0x004FA0A8, "Int32", "Stage 4", "Race ID array start for sponsor events [12 bytes]"));
            memoryValues.Add(new MemoryValue("Stage 4 - URL Events Array", 0x004FA0B8, "Int32", "Stage 4", "Race IDs for URL events [28 bytes]"));
            memoryValues.Add(new MemoryValue("Stage 4 - Magazine Covers Event", 0x004FA0E0, "Int32", "Stage 4", "Event ID for magazine covers"));
            memoryValues.Add(new MemoryValue("Stage 4 Outruns Won", 0x004FA0F8, "Int32", "Stage 4", "Number of outruns won"));
            memoryValues.Add(new MemoryValue("Stage 4 Races Won", 0x004FA100, "Int32", "Stage 4", "Races won while in Stage 4 career overworld"));

            // Stage 5
            memoryValues.Add(new MemoryValue("Stage 5 - Completed Races Array", 0x004FA120, "Int32", "Stage 5", "Race IDs completed [140 bytes, holds 35 entries]"));
            memoryValues.Add(new MemoryValue("Stage 5 - 35th World Event", 0x004FA1A8, "Int32", "Stage 5", "35th world event race ID"));
            memoryValues.Add(new MemoryValue("Stage 5 - Sponsor Events Array", 0x004FA1AC, "Int32", "Stage 5", "Race ID array start for sponsor events"));
            memoryValues.Add(new MemoryValue("Stage 5 - 3rd Sponsor Event", 0x004FA1B4, "Int32", "Stage 5", "3rd sponsor event race ID"));
            memoryValues.Add(new MemoryValue("Stage 5 - URL Events Array", 0x004FA1BC, "Int32", "Stage 5", "Race ID array start for URL events"));
            memoryValues.Add(new MemoryValue("Stage 5 - 9th URL Race", 0x004FA1DC, "Int32", "Stage 5", "9th URL race ID"));
            memoryValues.Add(new MemoryValue("Stage 5 Outruns Won", 0x004FA1FC, "Int32", "Stage 5", "Number of outruns won"));

            // Career Statistics
            memoryValues.Add(new MemoryValue("Races Entered", 0x004FB060, "Int32", "Career Stats", "Total races entered"));
            memoryValues.Add(new MemoryValue("Races Entered (Duplicate)", 0x005060B0, "Int32", "Career Stats", "Total races entered (duplicate address)"));
            memoryValues.Add(new MemoryValue("Races Won", 0x005060B4, "Int32", "Career Stats", "Total races won"));
            memoryValues.Add(new MemoryValue("Circuits Won", 0x005060E4, "Int32", "Career Stats", "Career circuits won (counts repeats)"));
            memoryValues.Add(new MemoryValue("SUV Races Remaining", 0x004F9C03, "Int8", "Career Stats", "Number of SUV races remaining"));
            memoryValues.Add(new MemoryValue("Highest Drift Score", 0x00511280, "Int32", "Career Stats", "Highest single drift score in most recent drift"));

            // Available Races
            memoryValues.Add(new MemoryValue("Available Races Array Start", 0x004F9AFC, "Int32", "Available Races", "Beginning of array of available races in current stage"));
            memoryValues.Add(new MemoryValue("Available Races Array", 0x004F9B00, "Int32", "Available Races", "Available races in current stage [160 bytes]"));

            // Event System
            memoryValues.Add(new MemoryValue("Event Array", 0x004FA434, "Int32", "Events", "Event array [2376 bytes] - +0x00=ID, +0x04-0x05=Info, +0x06=Info (16-bit, 0x0005=locations entered)"));
            memoryValues.Add(new MemoryValue("Event List End", 0x004FAD7C, "Int32", "Events", "End of event list"));

            // Profile
            memoryValues.Add(new MemoryValue("Profile Name - First Char", 0x004FB4A8, "Int8", "Profile", "First ASCII character of profile name"));
            memoryValues.Add(new MemoryValue("Profile Name - Last Char", 0x004FB4AE, "Int8", "Profile", "Last ASCII character of profile name"));

            // Shops Discovered
            memoryValues.Add(new MemoryValue("City Core Shops Discovered", 0x00575F68, "Int8", "Shops", "Number of shops discovered in City Core"));
            memoryValues.Add(new MemoryValue("Beacon Hill Shops Discovered", 0x00575F6C, "Int8", "Shops", "Number of shops discovered in Beacon Hill"));
            memoryValues.Add(new MemoryValue("Jackson Heights Shops Discovered", 0x00575F70, "Int8", "Shops", "Number of shops discovered in Jackson Heights"));
            memoryValues.Add(new MemoryValue("Coal Harbor East Shops Discovered", 0x00575F74, "Int8", "Shops", "Number of shops discovered in Coal Harbor East"));
            memoryValues.Add(new MemoryValue("Coal Harbor West Shops Discovered", 0x00575F78, "Int8", "Shops", "Number of shops discovered in Coal Harbor West"));

            // Unknown/Misc Arrays
            memoryValues.Add(new MemoryValue("Unknown Array Start", 0x004FB234, "Int32", "Misc", "Start of unknown array"));

            return memoryValues;
        }
    }
}
