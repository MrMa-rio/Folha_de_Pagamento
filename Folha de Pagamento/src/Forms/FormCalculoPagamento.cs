using FOLHA_DE_PAGAMENTO_.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormCalculoPagamento : Form
    {
        FormNavBar FormAtivo;
        C_CalculosFolha calculosFolha = new C_CalculosFolha();
        C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormCalculoPagamento(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
            calculosFolha.setSalariosBaseINSS(this);
            calculosFolha.setSalariosBaseIRRF(this);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes a sair desta página.\nTem certeza?", "Sair da Página", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            C_eraseBoxes c_EraseBoxes = new C_eraseBoxes();
            c_EraseBoxes.eraseTextBox(panel5);
            c_EraseBoxes.eraseTextBox(panel4);

        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);

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