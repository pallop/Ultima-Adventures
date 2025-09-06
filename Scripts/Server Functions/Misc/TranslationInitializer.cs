using System;
using Server;
using Server.Mobiles;
using Server.Network;
using System.Collections.Generic;

namespace Server.Misc
{
    public class TranslationInitializer
    {
        public static void Initialize()
        {
            EventSink.Shutdown += new ShutdownEventHandler(OnShutdown);
            EventSink.WorldLoad += new WorldLoadEventHandler(OnWorldLoad);

            EventSink.TranslateCliloc += new TranslateClilocEventHandler(Translator.TranslateCliloc);
            EventSink.TranslateToEnglish += new TranslateToEnglishEventHandler(Translator.TranslateToEnglish);
            EventSink.TranslateToSpanish += new TranslateToSpanishEventHandler(Translator.TranslateToSpanish);
			EventSink.ResourceNameTranslate += new ResourceNameTranslateEventHandler(Translator.Translate);

			Mobile.OnSendLocalizedMessage += new SendLocalizedMessageHandler(OnSendLocalizedMessage);

			InitializeSquireDialogs();
        }

        private static void OnShutdown(ShutdownEventArgs e)
        {
            Translator.SaveCache();
        }

		private static void OnWorldLoad()
        {
            Console.WriteLine("Translating NPC Titles...");
            foreach (Mobile m in World.Mobiles.Values)
            {
                if (m is BaseCreature)
                {
                    BaseCreature bc = (BaseCreature)m;
                    if (!string.IsNullOrEmpty(bc.Title))
                    {
                        bc.Title = Translator.TranslateToSpanish(bc.Title);
                    }
                }
            }
            Console.WriteLine("NPC Titles translated.");
        }

        private static bool OnSendLocalizedMessage(Mobile to, int number, string args)
        {
            if (to == null || to.NetState == null)
                return false;

            string text = Cliloc.Get(number, args);
            if (string.IsNullOrEmpty(text))
                return false;

            text = Translator.TranslateToSpanish(text);
            to.Send(new UnicodeMessage(Serial.MinusOne, -1, MessageType.Regular, 0x3B2, 3, "System", "System", text));
            return true;
        }

		public static void InitializeSquireDialogs()
        {
            Console.WriteLine("Translating Squire Dialogs...");
            foreach (KeyValuePair<SquireDialogTree, List<string>> entry in SquireDialogData.Dialogs)
            {
                List<string> translatedLines = new List<string>();
                foreach (string line in entry.Value)
                {
                    translatedLines.Add(Translator.TranslateToSpanish(line));
                }
                SquireDialog.TranslatedDialogs[entry.Key] = translatedLines;
            }
            Console.WriteLine("Squire Dialogs translated.");
        }
    }
}
