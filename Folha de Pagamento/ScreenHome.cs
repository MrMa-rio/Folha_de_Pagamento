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
        
        FormShow formShow = new FormShow();
        NavBarShow navBarShow = new NavBarShow();
        Form NavBars;
        
        public ScreenHome()
        {
            InitializeComponent();
            navBar NavBar = new navBar(this);
            NavBars = NavBar;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Btn_Menu.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Btn_Menu.BackColor = Color.Transparent;
        }

        private void Btn_Menu_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.setNavBarShow(this, NavBars);
        }
    }
}
