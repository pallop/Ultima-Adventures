using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Server.Misc
{
    public class Cliloc
    {
        private static Dictionary<int, string> m_Table;

        static Cliloc()
        {
            string path = Core.FindDataFile("Cliloc.enu");

            if (path != null)
            {
                m_Table = new Dictionary<int, string>();
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        br.ReadInt32(); //header
                        br.ReadInt16(); //version

                        while (br.BaseStream.Length != br.BaseStream.Position)
                        {
                            int number = br.ReadInt32();
                            br.ReadByte(); // flag
                            int length = br.ReadInt16();

                            if (length > 0)
                            {
                                byte[] buffer = new byte[length];
                                br.Read(buffer, 0, length);
                                m_Table[number] = Encoding.UTF8.GetString(buffer);
                            }
                        }
                    }
                }
            }
        }

        public static string GetString(int number)
        {
            if (m_Table != null && m_Table.ContainsKey(number))
                return m_Table[number];

            return null;
        }

        public static string GetString(int number, string args)
        {
            string s = GetString(number);

            if (s == null)
                return null;

            if (args == null || args.Length == 0)
                return s;

            return String.Format(s, args.Split('\t'));
        }
    }
}
