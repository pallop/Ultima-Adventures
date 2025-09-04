using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Server;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;

namespace Server.Commands
{
    public class TranslationCommands
    {
        public static void Initialize()
        {
            CommandSystem.Register("ClearTranslationCacheEntry", AccessLevel.Administrator, new CommandEventHandler(ClearTranslationCacheEntry_OnCommand));
            CommandSystem.Register("FixTranslationCache", AccessLevel.Administrator, new CommandEventHandler(FixTranslationCache_OnCommand));
        }

        [Usage("ClearTranslationCacheEntry \"<text>\"")]
        [Description("Clears a specific entry from the translation cache.")]
        private static void ClearTranslationCacheEntry_OnCommand(CommandEventArgs e)
        {
            if (e.Length >= 1)
            {
                string textToClear = e.GetString(0);
                string removedValue;

                if (Server.Misc.Translator.m_TranslationCache.TryRemove(textToClear, out removedValue))
                {
                    e.Mobile.SendMessage("Entry for \"{0}\" removed from cache.", textToClear);
                }
                else
                {
                    e.Mobile.SendMessage("Entry for \"{0}\" not found in cache.", textToClear);
                }
            }
            else
            {
                e.Mobile.SendMessage("Usage: ClearTranslationCacheEntry \"<text>\"");
            }
        }

        [Usage("FixTranslationCache")]
        [Description("Scans the translation cache for entries that appear to be untranslated and attempts to re-translate them.")]
        private static void FixTranslationCache_OnCommand(CommandEventArgs e)
        {
            e.Mobile.SendMessage("Starting translation cache fix process...");

            int fixedCount = 0;
            int scannedCount = 0;
            List<string> keysToFix = new List<string>();

            // Regex to detect if a string contains common Spanish words or typical character patterns.
            // This is a heuristic and might not be perfect.
            Regex spanishHeuristic = new Regex(@"\b(el|la|los|las|un|una|de|a|en|y|o|que|es|del|al)\b|ñ|¡|¿", RegexOptions.IgnoreCase);

            foreach (var kvp in Server.Misc.Translator.m_TranslationCache)
            {
                scannedCount++;
                // Heuristic: If the source (key) looks like Spanish and the translation (value) does NOT, it's likely a failed translation.
                if (spanishHeuristic.IsMatch(kvp.Key) && !spanishHeuristic.IsMatch(kvp.Value))
                {
                    // Another check: if the source and destination are identical, it's a failed translation.
                    if (kvp.Key.Equals(kvp.Value, StringComparison.OrdinalIgnoreCase))
                    {
                        keysToFix.Add(kvp.Key);
                    }
                }
            }

            if (keysToFix.Count == 0)
            {
                e.Mobile.SendMessage("Scanned {0} entries. No obvious translation errors found.", scannedCount);
                return;
            }

            e.Mobile.SendMessage("Found {0} potential translation errors. Attempting to fix...", keysToFix.Count);

            foreach (string key in keysToFix)
            {
                // Remove the incorrect entry
                string oldValue;
                Server.Misc.Translator.m_TranslationCache.TryRemove(key, out oldValue);

                // Re-translate it. The Translate method will automatically add the new result to the cache.
                bool fromCache; // We don't care about the result here, just that it runs.
                string newValue = Server.Misc.Translator.Translate(key, out fromCache);

                if (!key.Equals(newValue, StringComparison.OrdinalIgnoreCase))
                {
                    fixedCount++;
                    e.Mobile.SendMessage("Fixed: \"{0}\" -> \"{1}\"", key, newValue);
                }
            }

            e.Mobile.SendMessage("Translation cache fix process complete. Scanned {0} entries and fixed {1}.", scannedCount, fixedCount);
        }
    }
}
