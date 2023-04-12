using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamento
{
    
    public partial class ScreenHome : Form
    {
        navBar NavBar = new navBar();
        NavBarShow navBarShow = new NavBarShow();
        private Form formAtivo;

        public Form FormAtivo
        {
            get { return formAtivo; }
            set { formAtivo = value; }
        }


        public ScreenHome()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.setNavBarShow(pnlInicial, NavBar);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Btn_Menu.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Btn_Menu.BackColor = Color.Transparent;
        }

        private void pnlInicial_Click(object sender, EventArgs e)
        {
            NavBar.Hide();
        }
    }
}
