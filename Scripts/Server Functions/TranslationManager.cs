using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Server
{
    public class TranslationManager
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string libreTranslateUrl = "http://localhost:5000/translate";
        private static readonly Dictionary<string, string> cache = new Dictionary<string, string>();
        private static readonly Queue<string> translationQueue = new Queue<string>();
        private static readonly object queueLock = new object();
        private static bool isRunning = false;

        public static void Initialize()
        {
            if (!isRunning)
            {
                isRunning = true;
                new Thread(new ThreadStart(ProcessQueue)).Start();
            }
        }

        public static string Translate(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            if (cache.TryGetValue(text, out string translatedText))
                return translatedText;

            lock (queueLock)
            {
                if (!translationQueue.Contains(text))
                    translationQueue.Enqueue(text);
            }

            return text;
        }

        private static void ProcessQueue()
        {
            while (isRunning)
            {
                string textToTranslate = null;
                lock (queueLock)
                {
                    if (translationQueue.Count > 0)
                        textToTranslate = translationQueue.Dequeue();
                }

                if (textToTranslate != null)
                {
                    try
                    {
                        var data = new { q = textToTranslate, source = "en", target = "es" };
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
                                cache[textToTranslate] = translatedText;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Translation error: " + ex.Message);
                    }
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
    }
}
