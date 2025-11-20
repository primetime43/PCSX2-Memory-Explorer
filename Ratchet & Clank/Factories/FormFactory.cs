using System;
using System.Windows.Forms;
using Common;
using Ratchet___Clank.Config;

namespace Ratchet___Clank
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
                default:
                    throw new ArgumentException($"Game '{formName}' not recognized. Available games are defined in Common.GameRegistry.SupportedGames", nameof(formName));
            }
        }
    }
}
