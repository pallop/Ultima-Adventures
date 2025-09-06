using System;
using Server;
using Server.Network;

namespace Server.Misc
{
    public class TranslationMessages
    {
        public static void Initialize()
        {
            Mobile.OnSendLocalizedMessage = new SendLocalizedMessageHandler(OnSendLocalizedMessage);
        }

        private static bool OnSendLocalizedMessage(Mobile to, int number, string args)
        {
            string text = Cliloc.Get(number, args);
            text = Translator.Translate(text, "es");
            to.Send(new UnicodeMessage(to.Serial, to.Body, MessageType.Regular, to.SpeechHue, 3, "ENU", to.Name, text));
            return true;
        }
    }
}
