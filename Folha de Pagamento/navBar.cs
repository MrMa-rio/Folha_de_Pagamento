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
    public partial class navBar : Form
    {
       

        public navBar()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            BtnArrowLeft.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            BtnArrowLeft.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

    }
}
