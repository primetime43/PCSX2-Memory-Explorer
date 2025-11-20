using System.Collections.Generic;

namespace Common
{
    /// <summary>
    /// Centralized registry of all supported games.
    /// Add or remove games here and they will automatically appear in both
    /// the game dropdown and the FormFactory.
    /// </summary>
    public static class GameRegistry
    {
        /// <summary>
        /// Gets the list of all supported game names.
        /// These names are used in both the UI dropdown and the FormFactory.
        /// </summary>
        public static readonly List<string> SupportedGames = new List<string>
        {
            "Ratchet & Clank 1 (NTSC)",
            "Ratchet & Clank: Going Commando (NTSC)",
            "Ratchet & Clank 3: Up Your Arsenal (NTSC)"
        };
    }
}
