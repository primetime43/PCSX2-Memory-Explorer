using System;
using System.Windows.Forms;
using Common;
using Games.RatchetClank;
using Games.NeedForSpeed;
using Games.MedalOfHonor;

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
                case "Need for Speed: Hot Pursuit 2 (PS2)":
                    return new GameMemoryEditorForm(new NFSHotPursuit2Config());
                case "Need for Speed: Carbon - Collectors Edition (PS2)":
                    return new GameMemoryEditorForm(new NFSCarbonConfig());
                case "Medal of Honor: Rising Sun (PS2)":
                    return new GameMemoryEditorForm(new MedalOfHonorRisingSunConfig());
                default:
                    throw new ArgumentException($"Game '{formName}' not recognized. Available games are defined in Common.GameRegistry.SupportedGames", nameof(formName));
            }
        }
    }
}
