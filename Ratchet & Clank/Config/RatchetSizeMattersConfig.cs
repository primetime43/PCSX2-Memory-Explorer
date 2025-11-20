using Common;
using System.Collections.Generic;

namespace Ratchet___Clank.Config
{
    public class RatchetSizeMattersConfig : IGameMemoryConfig
    {
        public string GameName => "Ratchet & Clank: Size Matters (NTSC)";

        public List<MemoryValue> GetMemoryValues()
        {
            var memoryValues = new List<MemoryValue>();

            // Currency & Progression
            memoryValues.Add(new MemoryValue("Bolts", 0x01F4C768, "Int32", "Currency", "Currency amount"));
            memoryValues.Add(new MemoryValue("Multiplier Bolts", 0x01F4B45E, "Int16", "Currency", "Bolt multiplier value"));
            memoryValues.Add(new MemoryValue("Bolts Multiplier Limiter", 0x01F4C76B, "Int8", "Currency", "Multiplier cap"));
            memoryValues.Add(new MemoryValue("Titanium Bolts", 0x01F4B449, "Int8", "Currency", "Titanium bolt count"));
            memoryValues.Add(new MemoryValue("Experience HP", 0x01F4C774, "Int32", "Progression", "Health experience points"));
            memoryValues.Add(new MemoryValue("Enable/Disable Multiplier and NG+", 0x01F4C778, "Int32", "Progression", "NG+ and multiplier toggle"));
            memoryValues.Add(new MemoryValue("Skill Points", 0x01F4B437, "Int8", "Progression", "Total skill points"));

            // Health per Planet
            memoryValues.Add(new MemoryValue("Pokitaru HP", 0x00F80E2C, "Int32", "Health - Pokitaru", "Current HP on Pokitaru"));
            memoryValues.Add(new MemoryValue("Pokitaru Max HP", 0x00F80E30, "Int32", "Health - Pokitaru", "Maximum HP on Pokitaru"));
            memoryValues.Add(new MemoryValue("Ryllus HP", 0x00F7FB3C, "Int32", "Health - Ryllus", "Current HP on Ryllus"));
            memoryValues.Add(new MemoryValue("Ryllus Max HP", 0x00F7FB40, "Int32", "Health - Ryllus", "Maximum HP on Ryllus"));
            memoryValues.Add(new MemoryValue("Kalidon HP", 0x00F7FCAC, "Int32", "Health - Kalidon", "Current HP on Kalidon"));
            memoryValues.Add(new MemoryValue("Kalidon Max HP", 0x00F7FCB0, "Int32", "Health - Kalidon", "Maximum HP on Kalidon"));
            memoryValues.Add(new MemoryValue("Metalis HP", 0x00F7F63C, "Int32", "Health - Metalis", "Current HP on Metalis"));
            memoryValues.Add(new MemoryValue("Metalis Max HP", 0x00F7F640, "Int32", "Health - Metalis", "Maximum HP on Metalis"));
            memoryValues.Add(new MemoryValue("Space HP", 0x010EC334, "Int32", "Health - Space", "Current HP in space"));
            memoryValues.Add(new MemoryValue("Dreamtime HP", 0x00F76B2C, "Int32", "Health - Dreamtime", "Current HP in Dreamtime"));
            memoryValues.Add(new MemoryValue("Dreamtime Max HP", 0x00F76B30, "Int32", "Health - Dreamtime", "Maximum HP in Dreamtime"));
            memoryValues.Add(new MemoryValue("Medical Outpost Omega HP", 0x00F823AC, "Int32", "Health - Med Outpost", "Current HP at Medical Outpost"));
            memoryValues.Add(new MemoryValue("Medical Outpost Omega Max HP", 0x00F823B0, "Int32", "Health - Med Outpost", "Max HP at Medical Outpost"));
            memoryValues.Add(new MemoryValue("Challax HP", 0x00F80F2C, "Int32", "Health - Challax", "Current HP on Challax"));
            memoryValues.Add(new MemoryValue("Challax Max HP", 0x00F80F30, "Int32", "Health - Challax", "Maximum HP on Challax"));
            memoryValues.Add(new MemoryValue("Dayni Moon HP", 0x00F7A0BC, "Int32", "Health - Dayni Moon", "Current HP on Dayni Moon"));
            memoryValues.Add(new MemoryValue("Dayni Moon Max HP", 0x00F7A0C0, "Int32", "Health - Dayni Moon", "Max HP on Dayni Moon"));
            memoryValues.Add(new MemoryValue("Inside Clank HP", 0x00F82DAC, "Int32", "Health - Inside Clank", "Current HP inside Clank"));
            memoryValues.Add(new MemoryValue("Inside Clank Max HP", 0x00F82DB0, "Int32", "Health - Inside Clank", "Max HP inside Clank"));
            memoryValues.Add(new MemoryValue("Quodrona HP", 0x00F8122C, "Int32", "Health - Quodrona", "Current HP on Quodrona"));
            memoryValues.Add(new MemoryValue("Quodrona Max HP", 0x00F81230, "Int32", "Health - Quodrona", "Maximum HP on Quodrona"));

            // Player Position (Pokitaru example)
            memoryValues.Add(new MemoryValue("Pokitaru X", 0x00F804F0, "Float", "Position", "X coordinate on Pokitaru"));
            memoryValues.Add(new MemoryValue("Pokitaru Y", 0x00F804F4, "Float", "Position", "Y coordinate on Pokitaru"));
            memoryValues.Add(new MemoryValue("Pokitaru Z", 0x00F804F8, "Float", "Position", "Z coordinate on Pokitaru"));

            // Speed per Planet
            memoryValues.Add(new MemoryValue("Pokitaru Speed", 0x00F806FC, "Float", "Speed", "Movement speed on Pokitaru"));
            memoryValues.Add(new MemoryValue("Ryllus Speed", 0x00F7F40C, "Float", "Speed", "Movement speed on Ryllus"));
            memoryValues.Add(new MemoryValue("Kalidon Speed", 0x00F7F57C, "Float", "Speed", "Movement speed on Kalidon"));
            memoryValues.Add(new MemoryValue("Kalidon Race Speed", 0x00F8AAFC, "Float", "Speed", "Race speed on Kalidon"));
            memoryValues.Add(new MemoryValue("Metalis Speed", 0x00F7EF0C, "Float", "Speed", "Movement speed on Metalis"));
            memoryValues.Add(new MemoryValue("Dreamtime Speed", 0x00F763FC, "Float", "Speed", "Movement speed in Dreamtime"));
            memoryValues.Add(new MemoryValue("Outpost Omega Speed", 0x00F81C7C, "Float", "Speed", "Movement speed at Outpost Omega"));
            memoryValues.Add(new MemoryValue("Outpost Omega 2 Speed", 0x00F82B7C, "Float", "Speed", "Alt speed at Outpost Omega"));
            memoryValues.Add(new MemoryValue("Challax Speed", 0x00F807FC, "Float", "Speed", "Movement speed on Challax"));
            memoryValues.Add(new MemoryValue("Dayni Moon Speed", 0x00F7998C, "Float", "Speed", "Movement speed on Dayni Moon"));
            memoryValues.Add(new MemoryValue("Inside Clank Speed", 0x00F8267C, "Float", "Speed", "Movement speed inside Clank"));
            memoryValues.Add(new MemoryValue("Quodrona Speed", 0x00F80AFC, "Float", "Speed", "Movement speed on Quodrona"));

            // Race Boosts
            memoryValues.Add(new MemoryValue("Kalidon Race Boost", 0x00F8E828, "Float", "Racing", "Boost on Kalidon race"));
            memoryValues.Add(new MemoryValue("Outpost Omega Race Boost", 0x00F868A8, "Float", "Racing", "Boost at Outpost Omega race"));

            // Camera Settings
            memoryValues.Add(new MemoryValue("View Mode", 0x00F49E48, "Int32", "Camera", "Camera view mode"));
            memoryValues.Add(new MemoryValue("Camera Left/Right 3rd Person", 0x01F4AB28, "Int32", "Camera", "Horizontal camera (3rd person)"));
            memoryValues.Add(new MemoryValue("Camera Up/Down 3rd Person", 0x01F4AB2C, "Int32", "Camera", "Vertical camera (3rd person)"));
            memoryValues.Add(new MemoryValue("Camera Mode", 0x01F4AB24, "Int32", "Camera", "Camera mode setting"));
            memoryValues.Add(new MemoryValue("Camera Left/Right 1st Person", 0x01F4AB30, "Int32", "Camera", "Horizontal camera (1st person)"));
            memoryValues.Add(new MemoryValue("Camera Up/Down 1st Person", 0x01F4AB34, "Int32", "Camera", "Vertical camera (1st person)"));

            // Armor - Current
            memoryValues.Add(new MemoryValue("Current Body Armor", 0x01F4B354, "Int8", "Armor - Equipped", "Equipped body armor ID"));
            memoryValues.Add(new MemoryValue("Current Helmet Armor", 0x01F4B355, "Int8", "Armor - Equipped", "Equipped helmet ID"));
            memoryValues.Add(new MemoryValue("Current Gloves Armor (Left)", 0x01F4B356, "Int8", "Armor - Equipped", "Equipped left glove ID"));
            memoryValues.Add(new MemoryValue("Current Gloves Armor (Right)", 0x01F4B357, "Int8", "Armor - Equipped", "Equipped right glove ID"));
            memoryValues.Add(new MemoryValue("Current Boots Armor (Left)", 0x01F4B358, "Int8", "Armor - Equipped", "Equipped left boot ID"));
            memoryValues.Add(new MemoryValue("Current Boots Armor (Right)", 0x01F4B359, "Int8", "Armor - Equipped", "Equipped right boot ID"));

            // Armor - Unlocks
            memoryValues.Add(new MemoryValue("Unlock Wildfire Armor", 0x01F4B35A, "Int8", "Armor - Unlocks", "Wildfire armor unlocked"));
            memoryValues.Add(new MemoryValue("Unlock Sludge Mk. 9 Armor", 0x01F4B35B, "Int8", "Armor - Unlocks", "Sludge Mk. 9 armor unlocked"));
            memoryValues.Add(new MemoryValue("Unlock Crystallix Armor", 0x01F4B35C, "Int8", "Armor - Unlocks", "Crystallix armor unlocked"));
            memoryValues.Add(new MemoryValue("Unlock Electroshock Armor", 0x01F4B35D, "Int8", "Armor - Unlocks", "Electroshock armor unlocked"));
            memoryValues.Add(new MemoryValue("Unlock Mega-Bomb Armor", 0x01F4B35E, "Int8", "Armor - Unlocks", "Mega-Bomb armor unlocked"));
            memoryValues.Add(new MemoryValue("Unlock Hyperborean Armor", 0x01F4B35F, "Int8", "Armor - Unlocks", "Hyperborean armor unlocked"));
            memoryValues.Add(new MemoryValue("Unlock Chameleon Armor", 0x01F4B360, "Int8", "Armor - Unlocks", "Chameleon armor unlocked"));

            // Audio/Display Settings
            memoryValues.Add(new MemoryValue("Quick Select Pause", 0x01F4AB38, "Int32", "Settings", "Quick select pause enabled"));
            memoryValues.Add(new MemoryValue("Fly Controls Up/Down", 0x01F4AB08, "Int32", "Settings", "Flight control inversion"));
            memoryValues.Add(new MemoryValue("Vibration", 0x01F4AB44, "Int32", "Settings", "Controller vibration"));
            memoryValues.Add(new MemoryValue("Subtitles", 0x01F4AB0C, "Int32", "Settings", "Subtitles enabled"));
            memoryValues.Add(new MemoryValue("Music Volume", 0x01F4AB18, "Int32", "Settings", "Music volume level"));
            memoryValues.Add(new MemoryValue("Effects Volume", 0x01F4AB1C, "Int32", "Settings", "Sound effects volume"));
            memoryValues.Add(new MemoryValue("Helpdesk Text", 0x01F4AB10, "Int32", "Settings", "Helpdesk text enabled"));
            memoryValues.Add(new MemoryValue("Helpdesk Voice", 0x01F4AB14, "Int32", "Settings", "Helpdesk voice enabled"));
            memoryValues.Add(new MemoryValue("16:9 (Widescreen)", 0x01F4AB20, "Int32", "Settings", "Widescreen mode"));
            memoryValues.Add(new MemoryValue("Progressive Scan", 0x01EF5720, "Int32", "Settings", "Progressive scan enabled"));
            memoryValues.Add(new MemoryValue("Sound", 0x01F4AB50, "Int32", "Settings", "Master sound toggle"));

            // Weapons - Location Set 1 (0x00F3EA**)
            memoryValues.Add(new MemoryValue("Lacerator (Loc 1)", 0x00F3EA5C, "Int32", "Weapons - Set 1", "Lacerator ammo"));
            memoryValues.Add(new MemoryValue("Acid Bomb Glove (Loc 1)", 0x00F3EB0C, "Int32", "Weapons - Set 1", "Acid Bomb Glove ammo"));
            memoryValues.Add(new MemoryValue("Concussion Gun (Loc 1)", 0x00F3EAB4, "Int32", "Weapons - Set 1", "Concussion Gun ammo"));
            memoryValues.Add(new MemoryValue("Agents of Doom (Loc 1)", 0x00F3EB64, "Int32", "Weapons - Set 1", "Agents of Doom ammo"));
            memoryValues.Add(new MemoryValue("Scorcher (Loc 1)", 0x00F3ED1C, "Int32", "Weapons - Set 1", "Scorcher ammo"));
            memoryValues.Add(new MemoryValue("Suck Cannon (Loc 1)", 0x00F3EDCC, "Int32", "Weapons - Set 1", "Suck Cannon ammo"));
            memoryValues.Add(new MemoryValue("Bee Mine Glove (Loc 1)", 0x00F3EBBC, "Int32", "Weapons - Set 1", "Bee Mine Glove ammo"));
            memoryValues.Add(new MemoryValue("Sniper Mine (Loc 1)", 0x00F3ECC4, "Int32", "Weapons - Set 1", "Sniper Mine ammo"));
            memoryValues.Add(new MemoryValue("Shock Rocket (Loc 1)", 0x00F3EC6C, "Int32", "Weapons - Set 1", "Shock Rocket ammo"));
            memoryValues.Add(new MemoryValue("Mootator (Loc 1)", 0x00F3EE24, "Int32", "Weapons - Set 1", "Mootator ammo"));
            memoryValues.Add(new MemoryValue("Static Barrier (Loc 1)", 0x00F3EC14, "Int32", "Weapons - Set 1", "Static Barrier ammo"));
            memoryValues.Add(new MemoryValue("Laser Tracer (Loc 1)", 0x00F3ED74, "Int32", "Weapons - Set 1", "Laser Tracer ammo"));
            memoryValues.Add(new MemoryValue("RYNO (Loc 1)", 0x00F3EED4, "Int32", "Weapons - Set 1", "RYNO ammo"));
            memoryValues.Add(new MemoryValue("Hypershot (Loc 1)", 0x00F3EF2C, "Int32", "Weapons - Set 1", "Hypershot ammo"));
            memoryValues.Add(new MemoryValue("Sprout-O-Matic (Loc 1)", 0x00F3EF84, "Int32", "Weapons - Set 1", "Sprout-O-Matic ammo"));
            memoryValues.Add(new MemoryValue("Polarizer (Loc 1)", 0x00F3EFDC, "Int32", "Weapons - Set 1", "Polarizer ammo"));
            memoryValues.Add(new MemoryValue("PDA (Loc 1)", 0x00F3F034, "Int32", "Weapons - Set 1", "PDA"));
            memoryValues.Add(new MemoryValue("Shrink Ray (Loc 1)", 0x00F3F08C, "Int32", "Weapons - Set 1", "Shrink Ray ammo"));
            memoryValues.Add(new MemoryValue("Bolt Grabber (Loc 1)", 0x00F3F0E4, "Int32", "Weapons - Set 1", "Bolt Grabber"));
            memoryValues.Add(new MemoryValue("Box Breaker (Loc 1)", 0x00F3F1EC, "Int32", "Weapons - Set 1", "Box Breaker"));
            memoryValues.Add(new MemoryValue("Map-O-Matic (Loc 1)", 0x00F3F194, "Int32", "Weapons - Set 1", "Map-O-Matic"));

            // Metalis Arena
            memoryValues.Add(new MemoryValue("Metalis Arena 1 P2 HP", 0x00702854, "Int32", "Arena - Metalis", "Arena 1 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 1 P3 HP", 0x00702F80, "Int32", "Arena - Metalis", "Arena 1 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 1 P4 HP", 0x0070309C, "Int32", "Arena - Metalis", "Arena 1 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 2 P2 HP", 0x007029B4, "Int32", "Arena - Metalis", "Arena 2 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 2 P3 HP", 0x007031B8, "Int32", "Arena - Metalis", "Arena 2 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 2 P4 HP", 0x00703D9C, "Int32", "Arena - Metalis", "Arena 2 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 3 P2 HP", 0x007032D4, "Int32", "Arena - Metalis", "Arena 3 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 3 P3 HP", 0x00703E64, "Int32", "Arena - Metalis", "Arena 3 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 3 P4 HP", 0x00702B14, "Int32", "Arena - Metalis", "Arena 3 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 4 Boss HP", 0x00705BC8, "Int32", "Arena - Metalis", "Arena 4 Boss HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 P2 HP", 0x007033F0, "Int32", "Arena - Metalis", "Arena 5 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 P3 HP", 0x00702C74, "Int32", "Arena - Metalis", "Arena 5 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 P4 HP", 0x00703F2C, "Int32", "Arena - Metalis", "Arena 5 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 Boss HP", 0x00705BF4, "Int32", "Arena - Metalis", "Arena 5 Boss HP"));
            memoryValues.Add(new MemoryValue("Metalis Arena 1 House", 0x001D1F14, "Int32", "Arena - Metalis", "Arena 1 house status"));
            memoryValues.Add(new MemoryValue("Metalis Arena 2 House", 0x001D1F24, "Int32", "Arena - Metalis", "Arena 2 house status"));
            memoryValues.Add(new MemoryValue("Metalis Arena 3 House", 0x001D1F34, "Int32", "Arena - Metalis", "Arena 3 house status"));
            memoryValues.Add(new MemoryValue("Metalis Arena 4 House", 0x001D1F54, "Int32", "Arena - Metalis", "Arena 4 house status"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 House", 0x001D1F44, "Int32", "Arena - Metalis", "Arena 5 house status"));

            // Metalis Arena Scores
            memoryValues.Add(new MemoryValue("Metalis Arena 1 P1 Score", 0x007041EC, "Int32", "Arena Scores - Metalis", "Arena 1 P1 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 1 P2 Score", 0x00704D7C, "Int32", "Arena Scores - Metalis", "Arena 1 P2 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 2 P1 Score", 0x00704064, "Int32", "Arena Scores - Metalis", "Arena 2 P1 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 2 P2 Score", 0x00704C14, "Int32", "Arena Scores - Metalis", "Arena 2 P2 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 3 P1 Score", 0x00704374, "Int32", "Arena Scores - Metalis", "Arena 3 P1 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 3 P2 Score", 0x00704EE4, "Int32", "Arena Scores - Metalis", "Arena 3 P2 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 3 P3 Score", 0x0070504C, "Int32", "Arena Scores - Metalis", "Arena 3 P3 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 4 P1 Score", 0x007044FC, "Int32", "Arena Scores - Metalis", "Arena 4 P1 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 4 P2 Score", 0x007051B4, "Int32", "Arena Scores - Metalis", "Arena 4 P2 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 4 P3 Score", 0x0070531C, "Int32", "Arena Scores - Metalis", "Arena 4 P3 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 4 P4 Score", 0x00705484, "Int32", "Arena Scores - Metalis", "Arena 4 P4 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 P1 Score", 0x00704684, "Int32", "Arena Scores - Metalis", "Arena 5 P1 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 P2 Score", 0x007055EC, "Int32", "Arena Scores - Metalis", "Arena 5 P2 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 P3 Score", 0x00705754, "Int32", "Arena Scores - Metalis", "Arena 5 P3 score"));
            memoryValues.Add(new MemoryValue("Metalis Arena 5 P4 Score", 0x007058BC, "Int32", "Arena Scores - Metalis", "Arena 5 P4 score"));

            // Dayni Moon Arena
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 P2 HP", 0x00A25DEC, "Int32", "Arena - Dayni Moon", "Arena 1 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 P3 HP", 0x00A25D24, "Int32", "Arena - Dayni Moon", "Arena 1 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 P4 HP", 0x00A25AF0, "Int32", "Arena - Dayni Moon", "Arena 1 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 P2 HP", 0x00A26144, "Int32", "Arena - Dayni Moon", "Arena 2 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 P3 HP", 0x00A260C4, "Int32", "Arena - Dayni Moon", "Arena 2 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 P4 HP", 0x00A261C4, "Int32", "Arena - Dayni Moon", "Arena 2 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 P2 HP", 0x00A25EB4, "Int32", "Arena - Dayni Moon", "Arena 3 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 P3 HP", 0x00A26B30, "Int32", "Arena - Dayni Moon", "Arena 3 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 P4 HP", 0x00A25B38, "Int32", "Arena - Dayni Moon", "Arena 3 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 P5 HP", 0x00A26244, "Int32", "Arena - Dayni Moon", "Arena 3 Player 5 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 P2 HP", 0x00A25B80, "Int32", "Arena - Dayni Moon", "Arena 4 Player 2 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 P3 HP", 0x00A25BC8, "Int32", "Arena - Dayni Moon", "Arena 4 Player 3 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 P4 HP", 0x00A262C4, "Int32", "Arena - Dayni Moon", "Arena 4 Player 4 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 P5 HP", 0x00A26344, "Int32", "Arena - Dayni Moon", "Arena 4 Player 5 HP"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 5 Boss HP", 0x00A26CD8, "Int32", "Arena - Dayni Moon", "Arena 5 Boss HP"));

            // Dayni Moon Arena Houses
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 House 1", 0x002F8674, "Int32", "Arena - Dayni Moon", "Arena 1 house 1 status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 House 2", 0x002F8684, "Int32", "Arena - Dayni Moon", "Arena 1 house 2 status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 House 1", 0x002F8694, "Int32", "Arena - Dayni Moon", "Arena 2 house 1 status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 House 2", 0x002F86A4, "Int32", "Arena - Dayni Moon", "Arena 2 house 2 status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 House 3", 0x002F86B4, "Int32", "Arena - Dayni Moon", "Arena 2 house 3 status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 House 1", 0x002F86C4, "Int32", "Arena - Dayni Moon", "Arena 3 house 1 status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 House 2", 0x002F86D4, "Int32", "Arena - Dayni Moon", "Arena 3 house 2 status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 House", 0x002F86E4, "Int32", "Arena - Dayni Moon", "Arena 4 house status"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 5 House", 0x002F86F4, "Int32", "Arena - Dayni Moon", "Arena 5 house status"));

            // Dayni Moon Arena Scores
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 Score P1", 0x00A272F4, "Int32", "Arena Scores - Dayni Moon", "Arena 1 P1 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 Score P2", 0x00A27AA4, "Int32", "Arena Scores - Dayni Moon", "Arena 1 P2 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 1 Score P3", 0x00A27C0C, "Int32", "Arena Scores - Dayni Moon", "Arena 1 P3 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 Score P1", 0x00A2747C, "Int32", "Arena Scores - Dayni Moon", "Arena 2 P1 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 Score P2", 0x00A27D74, "Int32", "Arena Scores - Dayni Moon", "Arena 2 P2 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 2 Score P3", 0x00A27EDC, "Int32", "Arena Scores - Dayni Moon", "Arena 2 P3 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 Score P1", 0x00A27604, "Int32", "Arena Scores - Dayni Moon", "Arena 3 P1 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 Score P2", 0x00A28044, "Int32", "Arena Scores - Dayni Moon", "Arena 3 P2 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 Score P3", 0x00A281AC, "Int32", "Arena Scores - Dayni Moon", "Arena 3 P3 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 3 Score P4", 0x00A28314, "Int32", "Arena Scores - Dayni Moon", "Arena 3 P4 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 Score P1", 0x00A2778C, "Int32", "Arena Scores - Dayni Moon", "Arena 4 P1 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 Score P2", 0x00A2847C, "Int32", "Arena Scores - Dayni Moon", "Arena 4 P2 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 Score P3", 0x00A285E4, "Int32", "Arena Scores - Dayni Moon", "Arena 4 P3 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 4 Score P4", 0x00A2874C, "Int32", "Arena Scores - Dayni Moon", "Arena 4 P4 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 5 Score P1", 0x00A27914, "Int32", "Arena Scores - Dayni Moon", "Arena 5 P1 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 5 Score P2", 0x00A288B4, "Int32", "Arena Scores - Dayni Moon", "Arena 5 P2 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 5 Score P3", 0x00A28A1C, "Int32", "Arena Scores - Dayni Moon", "Arena 5 P3 score"));
            memoryValues.Add(new MemoryValue("Dayni Moon Arena 5 Score P4", 0x00A28B84, "Int32", "Arena Scores - Dayni Moon", "Arena 5 P4 score"));

            // Multiplayer
            memoryValues.Add(new MemoryValue("HP P1", 0x0106FD7C, "Int32", "Multiplayer", "Player 1 health"));
            memoryValues.Add(new MemoryValue("HP P2", 0x0107376C, "Int32", "Multiplayer", "Player 2 health"));
            memoryValues.Add(new MemoryValue("Max HP P1", 0x0106FD80, "Int32", "Multiplayer", "Player 1 max health"));
            memoryValues.Add(new MemoryValue("Max HP P2", 0x01073770, "Int32", "Multiplayer", "Player 2 max health"));
            memoryValues.Add(new MemoryValue("Experience HP P1", 0x01043690, "Int32", "Multiplayer", "Player 1 health XP"));
            memoryValues.Add(new MemoryValue("Experience HP P2", 0x01043694, "Int32", "Multiplayer", "Player 2 health XP"));
            memoryValues.Add(new MemoryValue("P1 Lacerator Level", 0x0102A7D0, "Int32", "Multiplayer", "P1 Lacerator level"));
            memoryValues.Add(new MemoryValue("P2 Lacerator Level", 0x0102A824, "Int32", "Multiplayer", "P2 Lacerator level"));
            memoryValues.Add(new MemoryValue("P1 Lacerator Ammo", 0x0102A7D4, "Int32", "Multiplayer", "P1 Lacerator ammo"));
            memoryValues.Add(new MemoryValue("P2 Lacerator Ammo", 0x0102A828, "Int32", "Multiplayer", "P2 Lacerator ammo"));
            memoryValues.Add(new MemoryValue("P1 Lacerator Experience", 0x0102A7D8, "Int32", "Multiplayer", "P1 Lacerator XP"));
            memoryValues.Add(new MemoryValue("P2 Lacerator Experience", 0x0102A82C, "Int32", "Multiplayer", "P2 Lacerator XP"));
            memoryValues.Add(new MemoryValue("Red Team Flags (Visual)", 0x01048850, "Int32", "Multiplayer", "Red team flags (visual)"));
            memoryValues.Add(new MemoryValue("Red Team Flags", 0x0116B038, "Int32", "Multiplayer", "Red team flags (actual)"));

            // Cheats
            memoryValues.Add(new MemoryValue("Cheats", 0x01F4C440, "Int32", "Cheats", "Cheat flags"));

            return memoryValues;
        }
    }
}
