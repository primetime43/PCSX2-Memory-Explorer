using System;
using System.Windows.Forms;
using Common;
using Ratchet___Clank.Config;
using Need_for_Speed.Config;

namespace PCSX2_Memory_Explorer
{
    /// <summary>
    /// Factory for creating game-specific memory editor forms.
    /// Game names must match those defined in Common.GameRegistry.SupportedGames
    /// </summary>
    public class FormFactory : IFormFactory
    {
        public Form CreateForm(string formName)
        {
            // NOTE: These case values must match the entries in Common.GameRegistry.SupportedGames
            switch (formName)
            {
                case "Ratchet & Clank 1 (NTSC)":
                    return new GameMemoryEditorForm(new RatchetClank1Config());
                case "Ratchet & Clank: Going Commando (NTSC)":
                    return new GameMemoryEditorForm(new RatchetClank2Config());
                case "Ratchet & Clank 3: Up Your Arsenal (NTSC)":
                    return new GameMemoryEditorForm(new RatchetClank3Config());
                case "Ratchet: Deadlocked (NTSC)":
                    return new GameMemoryEditorForm(new RatchetDeadlockedConfig());
                case "Ratchet & Clank: Size Matters (NTSC)":
                    return new GameMemoryEditorForm(new RatchetSizeMattersConfig());
                case "Secret Agent Clank (PAL)":
                    return new GameMemoryEditorForm(new SecretAgentClankConfig());
                case "Need for Speed: Underground (PS2)":
                    return new GameMemoryEditorForm(new NFSUndergroundConfig());
                case "Need for Speed: Underground 2 (PS2)":
                    return new GameMemoryEditorForm(new NFSUnderground2Config());
                case "Need for Speed: Most Wanted - Black Edition (PS2)":
                    return new GameMemoryEditorForm(new NFSMostWantedConfig());
                default:
                    throw new ArgumentException($"Game '{formName}' not recognized. Available games are defined in Common.GameRegistry.SupportedGames", nameof(formName));
            }
        }
    }
}
