using System;
using System.Collections;
using Server;
using Server.Mobiles;

namespace Server.Misc
{
    public class TranslationTitles
    {
        public static void Initialize()
        {
            EventSink.WorldLoad += new WorldLoadEventHandler(OnWorldLoad);
        }

        private static void OnWorldLoad()
        {
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
        }
    }
}
