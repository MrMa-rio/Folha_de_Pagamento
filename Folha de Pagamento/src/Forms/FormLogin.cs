using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    public partial class FormLogin : Form
    {
        FormHome FormHome;
        public FormLogin(FormHome formHome)
        {
            InitializeComponent();
            FormHome = formHome;
        }
        private void BtnEntrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtUser.Text.Trim().Length != 0 && TxtPassword.Text.Trim().Length != 0)
            {

                C_VerificarLogin c_VerificarLogin = new C_VerificarLogin();
                c_VerificarLogin.statusLogin(TxtUser.Text, TxtPassword.Text, this);
            }
            else
            {
                MessageBox.Show("Usuario/Senha Invalidos!");
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtUser.Text.Trim().Length != 0 && TxtPassword.Text.Trim().Length != 0)
                {
                    C_VerificarLogin c_VerificarLogin = new C_VerificarLogin();
                    c_VerificarLogin.statusLogin(TxtUser.Text, TxtPassword.Text, this);
                }
                else
                {
                    MessageBox.Show("Usuario/Senha Invalidos!");
                }
            }
        }
    }
}

