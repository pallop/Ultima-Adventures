using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Server;
using Server.Misc;
using Server.Custom;

namespace Server.Commands
{
    public class FixTranslationCacheCommand
    {
        public static void Initialize()
        {
            CommandSystem.Register("FixTranslationCache", AccessLevel.Administrator, new CommandEventHandler(FixCache_OnCommand));
        }

        [Usage("FixTranslationCache")]
        [Description("Scans the translation cache for entries where the translation is the same as the original text, and attempts to re-translate them.")]
        private static void FixCache_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;
            from.SendMessage("Starting translation cache fix process in the background. See server console for progress.");

            Task.Run(() => FixCache());
        }

        private static bool IsSpanish(string text)
        {
            // Simple heuristic to detect Spanish by checking for common Spanish characters.
            return text.IndexOfAny(new char[] { 'ñ', 'á', 'é', 'í', 'ó', 'ú', '¿', '¡' }) != -1;
        }

        private static void FixCache()
        {
            Console.WriteLine("Starting translation cache fix...");
            try
            {
                var keysToFix = new List<string>();
                Regex englishChars = new Regex(@"[a-zA-Z]");

                foreach (var kvp in Translator.m_TranslationCache)
                {
                    // Heuristic 1: Failed translation returned the original text.
                    if (kvp.Key == kvp.Value)
                    {
                        if (!keysToFix.Contains(kvp.Key))
                            keysToFix.Add(kvp.Key);
                        continue;
                    }

                    // Heuristic 2: Spanish to English translation still contains Spanish-specific characters.
                    if (IsSpanish(kvp.Key))
                    {
                        if (IsSpanish(kvp.Value))
                        {
                            if (!keysToFix.Contains(kvp.Key))
                                keysToFix.Add(kvp.Key);
                        }
                    }
                    // Heuristic 3: English to Spanish translation still contains English characters (and is not a proper noun/special case).
                    else
                    {
                        if (englishChars.IsMatch(kvp.Value))
                        {
                            // This is a weak heuristic, as Spanish uses the Latin alphabet.
                            // A more advanced check could be implemented here if needed.
                            // For now, we'll consider any match suspicious enough to re-translate.
                            if (!keysToFix.Contains(kvp.Key))
                                keysToFix.Add(kvp.Key);
                        }
                    }
                }

                if (keysToFix.Count == 0)
                {
                    Console.WriteLine("Translation cache fix: No entries found that need fixing.");
                    return;
                }

                Console.WriteLine("Translation cache fix: Found {0} entries to re-translate.", keysToFix.Count);
                int fixedCount = 0;
                int failedCount = 0;

                foreach (string key in keysToFix)
                {
                    string dummy;
                    Translator.m_TranslationCache.TryRemove(key, out dummy);

                    string newTranslation;
                    // We don't know the original direction, so we have to guess.
                    // This is a limitation of this approach. We'll assume if it contains Spanish chars, it's Spanish.
                    if (IsSpanish(key))
                    {
                        newTranslation = Translator.ToEnglish(key);
                    }
                    else
                    {
                        newTranslation = Translator.ToSpanish(key);
                    }

                    if (newTranslation != key)
                    {
                        fixedCount++;
                        if (MyServerSettings.TranslationVerbose())
                            Console.WriteLine("  Fixed: \"{0}\" -> \"{1}\"", key, newTranslation);
                    }
                    else
                    {
                        failedCount++;
                        if (MyServerSettings.TranslationVerbose())
                             Console.WriteLine("  Failed to fix: \"{0}\"", key);
                    }
                }

                Console.WriteLine("Translation cache fix complete. Successfully fixed {0} entries. Failed to fix {1} entries.", fixedCount, failedCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred during the translation cache fix process:");
                Console.WriteLine(e);
            }
        }
    }
}
