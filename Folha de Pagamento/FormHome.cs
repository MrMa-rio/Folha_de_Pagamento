namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormHome : Form
    {

        C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        private FormNavBar NavBar;

        public FormHome()
        {
            InitializeComponent();
            FormNavBar navBar = new FormNavBar(this);
            NavBar = navBar;

        }

        private void BtnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.setNavBarShow(this, NavBar, NavBar.Pnl2);
        }

        private void FormHome_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(NavBar, NavBar.Pnl2);
        }
    }
}