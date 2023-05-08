using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.Servidor.GET;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormHome : Form
    {
        C_Manipula��oImagens c_Manipula��oImagens = new C_Manipula��oImagens();
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
            if (PnlPerfil.Visible)
            {
                PnlPerfil.Visible = false;
            }
            else
            {
                PnlPerfil.Visible = true;
            }
            if (DataUser.Length > 1)
            {
                label1.Text = DataUser[0].ToString(); //Matricula
                label2.Text = DataUser[1].ToString(); //Nome
                label3.Text = DataUser[2].ToString(); //FK Departamento
                label4.Text = DataUser[3].ToString(); //FK Cargo
                label5.Text = DataUser[4].ToString(); //NvlAcesso
                label6.Text = DataUser[5].ToString(); //Status
            }
            if (!c_Manipula��oImagens.getImagemUser(PboxPerfil, DataUser[0]))
            {
                PboxPerfil.BackgroundImage = Properties.Resources.circle_account1;
            }
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
            if(BtnMenu.Visible == true) 
            {
                navBarShow.setNavBarShow(this, NavBar, NavBar.Pnl2);

            }
        }
    }
}