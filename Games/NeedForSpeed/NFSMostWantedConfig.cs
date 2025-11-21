using Common;
using System.Collections.Generic;

namespace Games.NeedForSpeed
{
    public class NFSMostWantedConfig : IGameMemoryConfig
    {
        public string GameName => "Need for Speed: Most Wanted - Black Edition (PS2)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Game State & Mode
            memoryValues.Add(new MemoryValue("Single Player Check", 0x0053C6F0, "Int8", "Game State", "0x00=Not Ingame, 0x01=1P Ingame, 0x02=2P Ingame"));
            memoryValues.Add(new MemoryValue("In-game Check", 0x00575D10, "Int8", "Game State", "0x01=In-game"));
            memoryValues.Add(new MemoryValue("Main Menu Check", 0x0056E9B0, "Int8", "Game State", "0x01=In Main Menu, Car Shop, etc."));
            memoryValues.Add(new MemoryValue("Main Menu Selection", 0x0056F574, "Int8", "Game State", "0x01=Career, 0x02=Challenge Series, 0x03=Quick Race, 0x04=My Cars, 0x05=Alias Manager, 0x06=Options"));
            memoryValues.Add(new MemoryValue("Event Mode", 0x005415F0, "Int8", "Game State", "0x00=TollBooth, 0x01=In-game, 0x02=Transition, 0x03=Circuit/Sprint/Speedtrap/Lap Knockout"));
            memoryValues.Add(new MemoryValue("Cutscene Flag", 0x00541290, "Int8", "Game State", "Active during cutscenes"));
            memoryValues.Add(new MemoryValue("Pause Flag", 0x0056DC24, "Int32", "Game State", "Game paused status"));
            memoryValues.Add(new MemoryValue("Restart Flag", 0x0056E3CC, "Int8", "Game State", "0x01=Restart after finishing a race"));
            memoryValues.Add(new MemoryValue("Memory Card Check", 0x005D9A98, "Int8", "Game State", "0x00=Initial, 0x01=Memory Card in use"));

            // Race & Event Info
            memoryValues.Add(new MemoryValue("Boss Race Check", 0x00536924, "Int8", "Race Info", "0x00=Initial, 0x01=In a Race Event (not Tollbooth/Speedtrap)"));
            memoryValues.Add(new MemoryValue("Selected Blacklist Member", 0x0056D888, "Int8", "Race Info", "Currently selected blacklist member"));
            memoryValues.Add(new MemoryValue("Boss Event/Track ID", 0x0056D88C, "Int16", "Race Info", "Boss race track ID"));
            memoryValues.Add(new MemoryValue("Overlay Type", 0x00532610, "Int8", "Race Info", "0x00=First Place, 0x02=Photo Ticket"));

            // Player Performance
            memoryValues.Add(new MemoryValue("Speed (MPH)", 0x005418F0, "Float", "Performance", "Current speed in MPH"));
            memoryValues.Add(new MemoryValue("Player X Coordinate", 0x00579350, "Float", "Performance", "Player X position"));
            memoryValues.Add(new MemoryValue("Player Y Coordinate", 0x00579358, "Float", "Performance", "Player Y position"));
            memoryValues.Add(new MemoryValue("Player Z Coordinate", 0x00579354, "Float", "Performance", "Player Z position"));
            memoryValues.Add(new MemoryValue("Player Rotation", 0x0057934C, "Float", "Performance", "Player rotation angle"));

            // Race Start Position
            memoryValues.Add(new MemoryValue("Race Start X Coordinate", 0x00538010, "Float", "Race Start", "Starting position X"));
            memoryValues.Add(new MemoryValue("Race Start Y Coordinate", 0x00538014, "Float", "Race Start", "Starting position Y"));
            memoryValues.Add(new MemoryValue("Race Start Z Coordinate", 0x00538018, "Float", "Race Start", "Starting position Z"));
            memoryValues.Add(new MemoryValue("Race Start Rotation", 0x00538020, "Int32", "Race Start", "Starting rotation"));

            // Current Pursuit Stats
            memoryValues.Add(new MemoryValue("Current Pursuit - Timer", 0x0056E44C, "Float", "Current Pursuit", "Pursuit timer"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Damaged Vehicles", 0x0056E450, "Int32", "Current Pursuit", "Police vehicles damaged"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Immobilized Vehicles", 0x0056E454, "Int32", "Current Pursuit", "Police vehicles immobilized"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Spike Strips Dodged", 0x0056E458, "Int32", "Current Pursuit", "Spike strips dodged"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Roadblocks Dodged", 0x0056E45C, "Int32", "Current Pursuit", "Roadblocks dodged"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Cost to State", 0x0056E460, "Int32", "Current Pursuit", "Cost to state"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Bounty", 0x0056E464, "Int32", "Current Pursuit", "Bounty (reputation score)"));
            memoryValues.Add(new MemoryValue("Current Pursuit - Bounty (Immobilized)", 0x0056E468, "Int32", "Current Pursuit", "Bounty from immobilized cops"));
            memoryValues.Add(new MemoryValue("Pursuit State", 0x00575CB0, "Int8", "Current Pursuit", "0x00=Initial, 0x01=State 1, 0x02=State 2 (Post-Race)"));

            // Current Car
            memoryValues.Add(new MemoryValue("Current Car ID", 0x005A3B68, "Int8", "Current Car", "Current car ID (see notes for car list)"));

            // Shop Info
            memoryValues.Add(new MemoryValue("In Shop Check", 0x005A40BC, "Int8", "Shop", "0x00=Outside, 0x01=In Shop"));
            memoryValues.Add(new MemoryValue("Shop - Tires", 0x005A402C, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Brakes", 0x005A4030, "Int8", "Shop", "0x04=Max Stock, 0x02=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Suspension", 0x005A4034, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Transmission", 0x005A4038, "Int8", "Shop", "0x04=Max Stock, 0x02=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Engine", 0x005A403C, "Int8", "Shop", "0x04=Max Stock, 0x02=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Turbo", 0x005A4040, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Nitrous", 0x005A4044, "Int8", "Shop", "0x03=Max Stock, 0x01=Max Pink Slip"));
            memoryValues.Add(new MemoryValue("Shop - Junkman Parts", 0x005A4048, "Int8", "Shop", "Junkman parts bitflags, 0x1d=All installed"));

            // Quick Race Menu
            memoryValues.Add(new MemoryValue("Quick Race Sub-Menu", 0x005A3E78, "Int8", "Quick Race", "0x00=Quick Play, 0x01=Single Player, 0x02=Split Screen"));

            // Cheats
            memoryValues.Add(new MemoryValue("Burger King Challenge Cheat", 0x00574228, "Int32", "Cheats", "Burger King Challenge entered"));
            memoryValues.Add(new MemoryValue("Syntec Ford GT Cheat", 0x00574264, "Int8", "Cheats", "0x00=Initial, 0x01=Unlocked"));
            memoryValues.Add(new MemoryValue("Junkman Part Cheat", 0x005742A0, "Int8", "Cheats", "0x00=Initial, 0x01=Unlocked"));

            // Pointers (Base Addresses - use with offsets)
            memoryValues.Add(new MemoryValue("Post-Pursuit Results Pointer", 0x00531D80, "Int32", "Pointers", "Pointer to post-pursuit results screen"));
            memoryValues.Add(new MemoryValue("Overlay Pointer", 0x005325F0, "Int32", "Pointers", "Pointer to overlay data"));
            memoryValues.Add(new MemoryValue("Tollbooth ID Pointer", 0x00537C70, "Int32", "Pointers", "Pointer to tollbooth data (+0x1c=Event ID)"));
            memoryValues.Add(new MemoryValue("Steering/Gas Pointer", 0x0053FBF8, "Int32", "Pointers", "Pointer (+0x1dc=Steering, +0x1f0=Gas/Reverse)"));
            memoryValues.Add(new MemoryValue("GameSession Pointer", 0x0056F0EC, "Int32", "Pointers", "Pointer to PlayerProfile (+0x1c) with extensive car/career data"));
            memoryValues.Add(new MemoryValue("Reward Marker Pointer", 0x0056F81C, "Int32", "Pointers", "Pointer to reward markers (6 sets of ID+Selected)"));
            memoryValues.Add(new MemoryValue("Race Wins/Milestones Pointer", 0x00570E6C, "Int32", "Pointers", "Pointer (+0x24) to blacklist progress data"));
            memoryValues.Add(new MemoryValue("Infraction Bitflags Pointer", 0x00570F54, "Int32", "Pointers", "Pointer (+0x00) to infraction bitflags"));
            memoryValues.Add(new MemoryValue("Pursuit System Pointer", 0x00575CB8, "Int32", "Pointers", "Pointer to pursuit data (timer, busted, cooldown, etc.)"));
            memoryValues.Add(new MemoryValue("Race Start Pointer", 0x00575D18, "Int32", "Pointers", "Pointer to race start (+0x2D8 perfect start, +0x32c countdown, +0x314 police)"));
            memoryValues.Add(new MemoryValue("Track ID Pointer", 0x00575D30, "Int32", "Pointers", "Pointer (+0x50, +0x1c) to ASCII track ID"));
            memoryValues.Add(new MemoryValue("Tire State Pointer", 0x00575D40, "Int32", "Pointers", "Pointer to tire states (+0x1bfc through +0x1c08)"));
            memoryValues.Add(new MemoryValue("Race Timer Pointer", 0x00575D44, "Int32", "Pointers", "Pointer to position (+0x30), timer (+0x144), speedtrap (+0x154)"));
            memoryValues.Add(new MemoryValue("Performance Upgrade Pointer", 0x00575DFC, "Int32", "Pointers", "Pointer (+0x154, +0x118) to performance upgrade data"));
            memoryValues.Add(new MemoryValue("Heat Level Pointer", 0x005771FC, "Int32", "Pointers", "Pointer (+0x30) to current heat level"));
            memoryValues.Add(new MemoryValue("Current Car Pointer", 0x005A0488, "Int32", "Pointers", "Pointer (+0x40, +0x00) to current car ID"));

            return memoryValues;
        }
    }
}
