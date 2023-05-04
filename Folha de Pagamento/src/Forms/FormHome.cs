using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.Forms;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormHome : Form
    {

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
            if(DataUser.Length > 1)
            {
                label1.Text = DataUser[0].ToString();
                label2.Text = DataUser[1].ToString();
                label3.Text = DataUser[2].ToString();
                label4.Text = DataUser[3].ToString();
                label5.Text = DataUser[4].ToString();
                label6.Text = DataUser[5].ToString();
            }
            
        }
        
    }
}