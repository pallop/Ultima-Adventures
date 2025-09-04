using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Server.Misc
{
    public static class TranslationInitializer
    {
        private static readonly string m_CachePath = Path.Combine(Core.BaseDirectory, "Data", "translation_cache.json");

        [CallPriority(10)]
        public static void Configure()
        {
            Server.Translation.TranslateToSpanish = new Func<string, string>(Server.Misc.Translator.ToSpanish);
            Server.Translation.TranslateToEnglish = new Func<string, string>(Server.Misc.Translator.ToEnglish);
            Server.Translation.TranslateCliloc = new Func<int, string, string>(Server.Misc.Translator.TranslateCliloc);

            if (MyServerSettings.EnableTranslation())
            {
                LoadCache();
                EventSink.Shutdown += new ShutdownEventHandler(OnShutdown);

                Console.WriteLine("Translation enabled. Starting Cliloc pre-caching...");
                Task.Run(() => PreCacheClilocs());
            }
        }

        private static void LoadCache()
        {
            if (File.Exists(m_CachePath))
            {
                try
                {
                    Console.WriteLine("Loading translation cache from disk...");
                    string json = File.ReadAllText(m_CachePath);
                    var loadedCache = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                    if (loadedCache != null)
                    {
                        foreach (var kvp in loadedCache)
                        {
                            Translator.m_TranslationCache.TryAdd(kvp.Key, kvp.Value);
                        }
                    }
                    Console.WriteLine("Loaded {0} translations from cache file.", Translator.m_TranslationCache.Count);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to load translation cache: " + e.Message);
                }
            }
        }

        private static void OnShutdown(ShutdownEventArgs e)
        {
            try
            {
                Console.WriteLine("Saving translation cache to disk...");
                string json = JsonConvert.SerializeObject(Translator.m_TranslationCache, Formatting.Indented);
                File.WriteAllText(m_CachePath, json);
                Console.WriteLine("Saved {0} translations.", Translator.m_TranslationCache.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to save translation cache: " + ex.Message);
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
                        // The translation will be added to the cache by the Translate method if not already present
                        Translator.ToSpanish(entry.Value);
                        count++;

                        if (count > 0 && count % 1000 == 0)
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
