using System;
using Server;
using Server.Misc;

namespace Server.Commands
{
    public class ClearTranslationCache
    {
        public static void Initialize()
        {
            CommandSystem.Register("ClearTranslationCacheEntry", AccessLevel.Administrator, new CommandEventHandler(ClearCacheEntry_OnCommand));
        }

        [Usage("ClearTranslationCacheEntry <text>")]
        [Description("Removes a specific entry from the translation cache.")]
        private static void ClearCacheEntry_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;
            if (e.Length == 1)
            {
                string key = e.GetString(0);
                string dummy; // Value is not needed for removal

                if (Translator.m_TranslationCache.TryRemove(key, out dummy))
                {
                    from.SendMessage("Translation cache entry removed for: \"{0}\"", key);
                    from.SendMessage("The translation will be requested from the service on its next appearance.");
                }
                else
                {
                    from.SendMessage("Translation cache entry not found for: \"{0}\"", key);
                }
            }
            else
            {
                from.SendMessage("Usage: [ClearTranslationCacheEntry \"<text to clear>\"]");
            }
        }
    }
}
