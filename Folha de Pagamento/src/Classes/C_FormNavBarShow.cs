using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_FormNavBarShow
    {
        public void setNavBarShow(Form ScreenTarget, FormNavBar Nav, Panel panel)
        {
            Nav.TopLevel = false;
            ScreenTarget.Controls.Add(Nav);
            //Nav.Dock = DockStyle.Left;

            AnimationShow(Nav, panel);
        }
        public void AnimationShow(Form Nav, Panel panelTarget)
        {
            for (int l = 2; l < 345; l++)
            {
                Nav.BringToFront();
                Nav.Width = l;
                Nav.Show();
            }
            panelTarget.Visible = true;
        }
        public void AnimationHide(Form Nav, Panel panelTarget)
        {
            panelTarget.Visible = false;
            Nav.Hide();
        }
    }
}
