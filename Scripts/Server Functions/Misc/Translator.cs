using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Server.Misc
{
    public class Translator
    {
        private static readonly HttpClient client = new HttpClient();
        internal static readonly ConcurrentDictionary<string, string> m_TranslationCache = new ConcurrentDictionary<string, string>();
        private static readonly Regex m_HtmlRegex = new Regex(@">(?<text>[^<]*)<", RegexOptions.Compiled);

        private static string Translate(string text, string source, string target)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // If the text contains HTML, parse it. Otherwise, translate the whole thing.
            if (text.Contains("<") && text.Contains(">"))
            {
                // Use a MatchEvaluator to replace only the text content between tags.
                return m_HtmlRegex.Replace(text, (match) =>
                {
                    string originalText = match.Groups["text"].Value;
                    // We must still translate the text content, which uses the main Translate method.
                    // This creates a recursive call, but the inner call will not contain HTML tags,
                    // so it will use the direct translation path.
                    string translatedText = Translate(originalText, source, target);
                    return ">" + translatedText + "<";
                });
            }

            // --- Direct Translation Logic (for non-HTML or for text segments from HTML) ---

            string cachedTranslation;
            if (m_TranslationCache.TryGetValue(text, out cachedTranslation))
            {
                if (MyServerSettings.TranslationVerbose())
                    Console.WriteLine("Translation Cache HIT: \"{0}\" -> \"{1}\"", text, cachedTranslation);
                return cachedTranslation;
            }

            if (MyServerSettings.TranslationVerbose())
                Console.WriteLine("Translation Cache MISS: \"{0}\". Requesting from service...", text);

            try
            {
                var apiKey = MyServerSettings.TranslationApiKey();

                object data;
                if (!string.IsNullOrEmpty(apiKey))
                {
                    data = new { q = text, source = source, target = target, api_key = apiKey };
                }
                else
                {
                    data = new { q = text, source = source, target = target };
                }

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync("http://localhost:5000/translate", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseString);
                    string translatedText = result["translatedText"];

                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        m_TranslationCache.TryAdd(text, translatedText);
                    }
                    return translatedText;
                }
                else
                {
                    if (MyServerSettings.TranslationVerbose())
                        Console.WriteLine("LibreTranslate request FAILED with status {0}: {1}", response.StatusCode, response.ReasonPhrase);
                    return text; // Return original text on error
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("LibreTranslate request EXCEPTION for text \"{0}\": {1}", text, e.Message);
                return text;
            }
        }

        public static string ToSpanish(string text)
        {
			if (!MyServerSettings.EnableTranslation())
				return text;
            return Translate(text, "en", "es");
        }

        public static string ToEnglish(string text)
        {
			if (!MyServerSettings.EnableTranslation())
				return text;
            return Translate(text, "es", "en");
        }

		public static string TranslateCliloc(int number, string args)
		{
			if (!MyServerSettings.EnableTranslation())
				return null;

			string text = Cliloc.GetString(number, args);

			if (text != null)
				return Translate(text, "en", "es");

			return null;
		}
    }
}
