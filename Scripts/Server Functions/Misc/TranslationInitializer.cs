using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Server.Misc
{
    public static class TranslationInitializer
    {
        [CallPriority(10)]
        public static void Configure()
        {
            Server.Translation.TranslateToSpanish = new Func<string, string>(Server.Misc.Translator.ToSpanish);
            Server.Translation.TranslateToEnglish = new Func<string, string>(Server.Misc.Translator.ToEnglish);
            Server.Translation.TranslateCliloc = new Func<int, string, string>(Server.Misc.Translator.TranslateCliloc);

            if (MyServerSettings.EnableTranslation())
            {
                Console.WriteLine("Translation enabled. Starting Cliloc pre-caching...");
                Task.Run(() => PreCacheClilocs());
            }
        }

        private static void PreCacheClilocs()
        {
            try
            {
                int count = 0;
                int total = Cliloc.m_Entries.Count;
                Console.WriteLine("Cliloc pre-caching: Found {0} total entries to process.", total);

                foreach (KeyValuePair<int, string> entry in Cliloc.m_Entries)
                {
                    if (!string.IsNullOrEmpty(entry.Value))
                    {
                        // The translation will be added to the cache by the Translate method
                        Translator.ToSpanish(entry.Value);
                        count++;

                        if (count % 1000 == 0)
                        {
                            Console.WriteLine("Cliloc pre-caching progress: {0}/{1} entries processed...", count, total);
                        }
                    }
                }
                Console.WriteLine("Cliloc pre-caching complete. Processed {0} entries.", count);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred during the Cliloc pre-caching background task:");
                Console.WriteLine(e);
            }
        }
    }
}
