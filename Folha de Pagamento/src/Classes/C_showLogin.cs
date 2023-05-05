using FOLHA_DE_PAGAMENTO_.src.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_showLogin
    {

        public void ShowLogin(FormHome formHome)
        {
            FormLogin login = new FormLogin(formHome);
            if(!formHome.Controls.Contains(login))
            {
                login.TopLevel = false;
                formHome.Controls.Add(login);
                login.TopLevel = false;
                login.Dock = DockStyle.Right;
                login.BringToFront();
                login.Show();
            }
            
        }
    }
}
