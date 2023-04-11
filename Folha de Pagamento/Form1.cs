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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Barra_Gerenciamento.Visible)
            {
                Barra_Gerenciamento.Visible = true;
                btn_arrow_teste.Visible = true;
            }
            else
            {
                Barra_Gerenciamento.Visible = false;
            }
             
        }
        private void btn_arrow_left_Enter(object sender, EventArgs e)
        {
            btn_arrow_left.BackColor = SystemColors.Control;
        }

        private void btn_arrow_left_MouseEnter(object sender, EventArgs e)
        {
            btn_arrow_left.BackColor = Color.White;
        }

        private void btn_arrow_left_MouseLeave(object sender, EventArgs e)
        {
            btn_arrow_left.BackColor = Color.Transparent;

        }

        private void btn_arrow_teste_MouseEnter(object sender, EventArgs e)
        {
            btn_arrow_teste.BackColor = Color.White;
        }

        private void btn_arrow_teste_MouseLeave(object sender, EventArgs e)
        {
            btn_arrow_teste.BackColor = Color.Transparent;
        }

        private void btn_arrow_teste_MouseClick(object sender, MouseEventArgs e)
        {
            Barra_Gerenciamento.Visible = true;
        }
    }
}
