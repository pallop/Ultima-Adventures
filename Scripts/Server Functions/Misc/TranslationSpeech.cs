using System;
using Server;
using Server.Mobiles;

namespace Server.Misc
{
    public class TranslationSpeech
    {
        public static void Initialize()
        {
            Mobile.OnSpeechLog += new SpeechLogHandler(OnSpeechLog);
        }

        private static void OnSpeechLog(Mobile from, string speech)
        {
            if (from is PlayerMobile)
            {
                string translated = Translator.TranslateToEnglish(speech);
                Console.WriteLine($"[Translation] {from.Name}: {translated}");
            }
        }
    }
}
