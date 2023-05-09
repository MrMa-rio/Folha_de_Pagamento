using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.PDF;
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
    public partial class FormHolerite : Form
    {
        string Matricula;
        C_ShowHoleriteFunc c_ShowHoleriteFunc = new C_ShowHoleriteFunc();
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();

        public FormHolerite(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
        }

        private void CbAno_TextChanged(object sender, EventArgs e)
        {
            CbMes.Items.Clear();
            CbMes.Text = string.Empty;
            if (CbAno.Text.Trim() != "" && TxtPesquisarMatricula.Text.Trim() != "")
            {
                c_ShowHoleriteFunc.getMonth(Matricula, CbAno.Text, CbMes);
            }
        }

        private void CbMes_TextChanged(object sender, EventArgs e)
        {

            if (CbAno.Text.Trim() != "" && CbMes.Text.Trim() != "")
            {
                c_ShowHoleriteFunc.showDataHolerite(Matricula, CbAno.Text, CbMes.Text, this);
            }
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void TxtPesquisarMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            CbAno.Text = string.Empty;
            CbAno.Items.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                Matricula = TxtPesquisarMatricula.Text;
                c_ShowHoleriteFunc.getYear(Matricula, CbAno);
            }
        }

        private void BtnPesquisarMatricula_MouseClick(object sender, MouseEventArgs e)
        {
            CbAno.Text = string.Empty;
            CbAno.Items.Clear();
            Matricula = TxtPesquisarMatricula.Text;
            c_ShowHoleriteFunc.getYear(Matricula, CbAno);
        }

        private void BtnHome_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes a sair desta página.\nTem certeza?", "Sair da Página", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnPrint_MouseClick(object sender, MouseEventArgs e)
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            FormHoleritePDF formHoleritePDF = new FormHoleritePDF(this);
            formHoleritePDF.Show();
            c_PrintPDF.printPdf(formHoleritePDF.PanelHolerite);
            formHoleritePDF.Close();
        }

        private void BtnImprimir_MouseClick(object sender, MouseEventArgs e)
        {
            C_GerarPDF c_GerarPDF = new C_GerarPDF();
            c_GerarPDF.printPDF(this);
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
