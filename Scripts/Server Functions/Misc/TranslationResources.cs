using System;
using Server;

namespace Server.Misc
{
    public class TranslationResources
    {
        public static void Initialize()
        {
            EventSink.ResourceNameTranslate += new ResourceNameTranslateEventHandler(TranslateResourceName);
        }

        private static string TranslateResourceName(string name)
        {
            return Translator.Translate(name, "es");
        }
    }
}
