using System;
using System.Collections.Generic;
using System.Reflection;
using Server.Items;
using Server.Mobiles;

namespace Server.Commands
{
    public class Pretranslate
    {
        public static void Initialize()
        {
            CommandSystem.Register("Pretranslate", AccessLevel.Administrator, new CommandEventHandler(Pretranslate_OnCommand));
        }

        [Usage("Pretranslate")]
        [Description("Pre-translates all item and creature names.")]
        private static void Pretranslate_OnCommand(CommandEventArgs e)
        {
            e.Mobile.SendMessage("Starting pre-translation...");
            e.Mobile.SendMessage("WARNING: This command will attempt to instantiate every Item and Mobile type in the server. This can be resource-intensive and may cause unexpected side effects. It is recommended to run this on a test server first.");

            // Pre-translate common strings
            Server.Translation.TranslateToSpanish("This creature has suffered");
            Server.Translation.TranslateToSpanish("injury");
            Server.Translation.TranslateToSpanish("injuries");
            Server.Translation.TranslateToSpanish("Durability");
            Server.Translation.TranslateToSpanish("Wear and Tear");

            int itemCount = 0;
            int creatureCount = 0;

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly asm in assemblies)
            {
                Type[] types = asm.GetTypes();
                foreach (Type type in types)
                {
                    if (type.IsSubclassOf(typeof(Item)))
                    {
                        try
                        {
                            Item item = Activator.CreateInstance(type) as Item;
                            if (item != null)
                            {
                                if (item.Name != null)
                                    Server.Translation.TranslateToSpanish(item.Name);
                                item.Delete();
                                itemCount++;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Error pre-translating item type {0}: {1}", type.FullName, ex.Message));
                        }
                    }
                    else if (type.IsSubclassOf(typeof(Mobile)))
                    {
                        try
                        {
                            Mobile mobile = Activator.CreateInstance(type) as Mobile;
                            if (mobile != null)
                            {
                                if (mobile.Name != null)
                                    Server.Translation.TranslateToSpanish(mobile.Name);
                                if (mobile.Title != null)
                                    Server.Translation.TranslateToSpanish(mobile.Title);
                                mobile.Delete();
                                creatureCount++;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Error pre-translating mobile type {0}: {1}", type.FullName, ex.Message));
                        }
                    }
                }
            }

            e.Mobile.SendMessage(String.Format("Pre-translation complete. {0} item names and {1} creature names and titles translated.", itemCount, creatureCount));
        }
    }
}
