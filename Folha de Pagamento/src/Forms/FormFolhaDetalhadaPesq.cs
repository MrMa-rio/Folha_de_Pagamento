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

namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    public partial class FormFolhaDetalhadaPesq : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();

        public FormFolhaDetalhadaPesq(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
        }

        private void BtnPesquisarMatricula_MouseClick(object sender, MouseEventArgs e)
        {
            CbYear.Items.Clear();
            CbYear.Text = string.Empty;
            C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
            c_RelatorioFolha.setYear(CbYear, TxtPesquisarMatricula.Text);
            c_RelatorioFolha.setDadosFuncionario(TxtPesquisarMatricula.Text, this);
        }

        private void CbYear_TextChanged(object sender, EventArgs e)
        {
            if (CbYear.Items.Contains(CbYear.Text))
            {
                CbMonth.Items.Clear();
                CbMonth.Text = string.Empty;
                if (CbYear.Text.Trim() != "")
                {
                    C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
                    c_RelatorioFolha.setMonth(this);
                }
            }
            else
            {
                CbMonth.Items.Clear();
                CbMonth.Text = string.Empty;
            }
        }

        private void CbMonth_TextChanged(object sender, EventArgs e)
        {
            if (CbMonth.Text.Trim() != "" && CbYear.Text.Trim() != "")
            {
                C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
                c_RelatorioFolha.getFolhaDetalhada(this);
            }
        }

        private void TxtPesquisarMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbYear.Items.Clear();
                CbYear.Text = string.Empty;
                C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
                c_RelatorioFolha.setYear(CbYear, TxtPesquisarMatricula.Text);
                c_RelatorioFolha.setDadosFuncionario(TxtPesquisarMatricula.Text, this);
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes a sair desta página.\nTem certeza?", "Sair da Página", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnPrint_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaDetalhadaPDF formFolhaDetalhadaPDF = new FormFolhaDetalhadaPDF(this);
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            formFolhaDetalhadaPDF.Show();
            c_PrintPDF.printPdf(formFolhaDetalhadaPDF.PanelFolhaDetalhada);
            formFolhaDetalhadaPDF.Close();
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


