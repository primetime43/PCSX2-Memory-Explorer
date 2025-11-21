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
            "Medal of Honor: Rising Sun (PS2)",
            "Need for Speed: Carbon - Collectors Edition (PS2)",
            "Need for Speed: Hot Pursuit 2 (PS2)",
            "Need for Speed: Most Wanted - Black Edition (PS2)",
            "Need for Speed: Underground (PS2)",
            "Need for Speed: Underground 2 (PS2)",
            "Ratchet & Clank 1 (NTSC)",
            "Ratchet & Clank 3: Up Your Arsenal (NTSC)",
            "Ratchet & Clank: Going Commando (NTSC)",
            "Ratchet & Clank: Size Matters (NTSC)",
            "Ratchet: Deadlocked (NTSC)",
            "Secret Agent Clank (PAL)"
        };
    }
}
