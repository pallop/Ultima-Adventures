using System;
using Server;

namespace Server.Misc
{
    public class TranslationOverhead
    {
        public static void Initialize()
        {
            Mobile.OnOverheadMessageTranslate += new OverheadMessageTranslateHandler(OnTranslate);
            Mobile.OnOverheadMessageRawTranslate += new OverheadMessageRawTranslateHandler(OnRawTranslate);
        }

        private static void OnTranslate(Mobile from, ref int number, ref string args)
        {
            string format = Cliloc.GetString(number);

            if (string.IsNullOrEmpty(format))
                return;

            string translatedFormat = Translator.TranslateToSpanish(format);

            if (string.IsNullOrEmpty(args))
            {
                number = 1042971; // ~1_NOTHING~
                args = translatedFormat;
            }
            else
            {
                try
                {
                    string translated = String.Format(translatedFormat, args.Split('\t'));
                    number = 1042971; // ~1_NOTHING~
                    args = translated;
                }
                catch (FormatException)
                {
                    // Fallback to just showing the translated format string
                    number = 1042971; // ~1_NOTHING~
                    args = translatedFormat;
                }
            }
        }

        private static void OnRawTranslate(Mobile from, ref string text)
        {
            text = Translator.TranslateToSpanish(text);
        }
    }
}
