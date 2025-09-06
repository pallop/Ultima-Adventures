using System;
using Server;

namespace Server.Misc
{
    public class TranslationOPL
    {
        public static void Initialize()
        {
            ObjectPropertyList.OnTranslate += new OPLTranslateHandler(OnTranslate);
            ObjectPropertyList.OnRawTranslate += new OPLRawTranslateHandler(OnRawTranslate);
        }

        private static string OnTranslate(int number, string args)
        {
            string format = Cliloc.GetString(number);

            if (string.IsNullOrEmpty(format))
                return null;

            string translatedFormat = Translator.TranslateToSpanish(format);

            if (string.IsNullOrEmpty(args))
                return translatedFormat;

            try
            {
                return String.Format(translatedFormat, args.Split('\t'));
            }
            catch (FormatException)
            {
                // This can happen if the translation changes the format specifiers.
                // In this case, we'll just return the translated format string.
                return translatedFormat;
            }
        }

        private static string OnRawTranslate(string text)
        {
            return Translator.TranslateToSpanish(text);
        }
    }
}
