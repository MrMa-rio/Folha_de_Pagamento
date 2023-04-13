using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamento
{
    internal class FormShow
    {
        public Form setFormShow(Form ScreenTarget, Form Nav, Form NavClose)
        {
            ScreenTarget.Controls.Remove(NavClose);
            Nav.TopLevel = false;
            ScreenTarget.Controls.Add(Nav);
            Nav.Dock = DockStyle.Fill;
            Nav.Show();
            return Nav;
        }
    }
}
