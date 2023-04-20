using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_FormNavBarShow
    {
        public void setNavBarShow(Form ScreenTarget, Form Nav)
        {
            Nav.TopLevel = false;
            ScreenTarget.Controls.Add(Nav);
            Nav.Dock = DockStyle.Left;
            Nav.BringToFront();
            Nav.Show();
        }
    }
}
