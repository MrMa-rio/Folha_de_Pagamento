using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.Servidor.GET;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormHome : Form
    {
        C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
        C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormNavBar NavBar;
        internal string[] DataUser = new string[1];
        C_showLogin showLogin = new C_showLogin();
        public FormHome()
        {
            InitializeComponent();
            FormNavBar navBar = new FormNavBar(this);
            FormLogin formLogin = new FormLogin(this);
            showLogin.ShowLogin(this);
            NavBar = navBar;
        }

        private void BtnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.setNavBarShow(this, NavBar, NavBar.Pnl2);
        }

        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(NavBar, NavBar.Pnl2);

        }

        private void BtnPerfil_MouseClick(object sender, MouseEventArgs e)
        {
            C_ShowPerfilUser c_ShowPerfilUser = new C_ShowPerfilUser();
            c_ShowPerfilUser.ShowPerfil(PnlPerfil, DataUser, PboxPerfil, this);
        }

        private void BtnTrocarUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Trocar de Perfil ?", "Trocar Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                C_FormNavBarShow c_FormNavBarShow = new C_FormNavBarShow();
                C_VerificarLogin c_VerificarLogin = new C_VerificarLogin();
                c_FormNavBarShow.AnimationHide(NavBar, NavBar.Pnl2);

                foreach (Control control in this.Controls)
                {
                    control.Hide();
                }
                c_VerificarLogin.logoutPerfil(this);
            }
        }

        private void BtnSetting_MouseClick(object sender, MouseEventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            C_FormShow c_FormShow = new C_FormShow();
            c_FormShow.setFormShow(this, formSobre);
        }

        private void BtnMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (BtnMenu.Visible == true)
            {
                navBarShow.setNavBarShow(this, NavBar, NavBar.Pnl2);

            }
        }
    }
}