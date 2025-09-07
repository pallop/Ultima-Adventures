using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Server
{
    public class Translation
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string libreTranslateUrl = "http://localhost:5000/translate";
        private static readonly Dictionary<string, string> cache = new Dictionary<string, string>();

        public static string TranslateToSpanish(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            if (cache.ContainsKey(text))
            {
                return cache[text];
            }

            try
            {
                var data = new { q = text, source = "en", target = "es" };
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync(libreTranslateUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<dynamic>(responseString);
                    string translatedText = result.translatedText;

                    if (!string.IsNullOrEmpty(translatedText))
                    {
                        cache[text] = translatedText;
                        return translatedText;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Translation error: " + ex.Message);
            }

            return text;
        }
    }
}
