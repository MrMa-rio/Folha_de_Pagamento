using FOLHA_DE_PAGAMENTO_.src.Classes;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormHome : Form
    {

        C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public Form NavBar;

        public FormHome()
        {
            InitializeComponent();
            FormNavBar navBar = new FormNavBar(this);
            NavBar = navBar;
        }

        private void BtnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.setNavBarShow(this, NavBar);
        }
    }
}