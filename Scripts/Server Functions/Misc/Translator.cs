using System;
using System.IO;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Server.Misc
{
    public class Translator
    {
        private static readonly HttpClient client = new HttpClient();
        internal static ConcurrentDictionary<string, string> m_TranslationCache;
        private static readonly string CachePath = Path.Combine(Core.BaseDirectory, "Data/translation_cache.json");

        static Translator()
        {
            LoadCache();
        }

        public static void LoadCache()
        {
            if (File.Exists(CachePath))
            {
                try
                {
                    string json = File.ReadAllText(CachePath);
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                    m_TranslationCache = new ConcurrentDictionary<string, string>(dictionary);
                    Console.WriteLine("Loaded {0} entries from translation cache.", m_TranslationCache.Count);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error loading translation cache: " + e.Message);
                    m_TranslationCache = new ConcurrentDictionary<string, string>();
                }
            }
            else
            {
                m_TranslationCache = new ConcurrentDictionary<string, string>();
            }
        }

        public static void SaveCache()
        {
            if (m_TranslationCache != null && m_TranslationCache.Count > 0)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(m_TranslationCache, Formatting.Indented);
                    File.WriteAllText(CachePath, json);
                    Console.WriteLine("Saved {0} entries to translation cache.", m_TranslationCache.Count);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error saving translation cache: " + e.Message);
                }
            }
        }

        private static string Translate(string text, string source, string target, out bool fromCache)
        {
            fromCache = false;
            if (string.IsNullOrEmpty(text) || !MyServerSettings.EnableTranslation())
                return text;

            if (m_TranslationCache.TryGetValue(text, out string cachedTranslation))
            {
                fromCache = true;
                return cachedTranslation;
            }

            try
            {
                var apiKey = MyServerSettings.TranslationApiKey();
                var data = new { q = text, source, target, api_key = apiKey };
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync("http://localhost:5000/translate", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseString);
                    string translatedText = result["translatedText"];

                    if (!string.IsNullOrWhiteSpace(text))
                        m_TranslationCache.TryAdd(text, translatedText);

                    return translatedText;
                }
                else
                {
                    Console.WriteLine($"LibreTranslate request FAILED with status {response.StatusCode}: {response.ReasonPhrase}");
                    return text;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"LibreTranslate request EXCEPTION for text \"{text}\": {e.Message}");
                return text;
            }
        }

        public static string TranslateToSpanish(string text)
        {
            bool fromCache;
            return Translate(text, "en", "es", out fromCache);
        }

        public static string TranslateToEnglish(string text)
        {
            bool fromCache;
            return Translate(text, "es", "en", out fromCache);
        }

        public static string TranslateCliloc(int number, string args)
        {
            string text = Cliloc.GetString(number, args);
            if (text != null)
                return TranslateToSpanish(text);
            return null;
        }
    }
}
