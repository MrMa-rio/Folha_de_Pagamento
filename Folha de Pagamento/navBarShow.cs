using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamento
{
    internal class NavBarShow
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
