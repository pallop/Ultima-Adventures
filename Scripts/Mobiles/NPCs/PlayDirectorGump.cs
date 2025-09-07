using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;

namespace Server.Mobiles
{
    public class PlayDirectorGump : Gump
    {
        private PlayDirectorNewChar m_Director;

        public PlayDirectorGump(PlayDirectorNewChar director) : base(50, 50)
        {
            m_Director = director;

            Closable = false;
            Dragable = false;
            Resizable = false;

            AddPage(0);
            AddBackground(0, 0, 400, 300, 9270);
            AddAlphaRegion(10, 10, 380, 280);

            AddHtml(10, 20, 380, 20, "<CENTER>Decisiones</CENTER>", false, false);

            // Question 1
            AddHtml(20, 60, 360, 40, "¿Te comprometes a mantener este mundo limpio y a respetar a los demás aventureros?", true, false);
            AddRadio(20, 100, 9727, 9730, true, 1);
            AddHtml(50, 102, 100, 20, "Sí", false, false);
            AddRadio(150, 100, 9727, 9730, false, 2);
            AddHtml(180, 102, 100, 20, "No", false, false);

            // Question 2
            AddHtml(20, 130, 360, 40, "¿Deseas convertirte en un avatar del equilibrio?", true, false);
            AddRadio(20, 170, 9727, 9730, true, 3);
            AddHtml(50, 172, 100, 20, "Sí", false, false);
            AddRadio(150, 170, 9727, 9730, false, 4);
            AddHtml(180, 172, 100, 20, "No", false, false);

            // Question 3
            AddHtml(20, 200, 360, 40, "¿Deseas ser un Alma Atada (SoulBound)?", true, false);
            AddRadio(20, 240, 9727, 9730, true, 5);
            AddHtml(50, 242, 100, 20, "Sí", false, false);
            AddRadio(150, 240, 9727, 9730, false, 6);
            AddHtml(180, 242, 100, 20, "No", false, false);

            AddButton(300, 260, 247, 248, 1, GumpButtonType.Reply, 0); // Okay button
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            if (info.ButtonID == 1)
            {
                Mobile from = sender.Mobile;
                bool choice1 = info.IsSwitched(1);
                bool choice2 = info.IsSwitched(3);
                bool choice3 = info.IsSwitched(5);

                if (m_Director != null)
                {
                    m_Director.HandleGumpResponse(from, choice1, choice2, choice3);
                }
            }
        }
    }
}
