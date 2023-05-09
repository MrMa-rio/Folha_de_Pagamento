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
                MessageBox.Show("Usuário ou Senha Inválidos!");
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
                    MessageBox.Show("Usuário ou Senha Inválidos!");
                }
            }
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Por favor, entre em contato com o Administrador. ");
        }
        private void All_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia o caractere
            }
        }
    }
}

