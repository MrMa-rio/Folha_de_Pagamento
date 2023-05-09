using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.PDF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormFolhaNormal : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();

        public FormFolhaNormal(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
        }

        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void CbAno_DropDown(object sender, EventArgs e)
        {
            C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
            C_FolhaNormalPesq c_FolhaNormalPesq = new C_FolhaNormalPesq();
            c_FolhaNormalPesq.getYearFolhaNormal(CbAno);
        }

        private void CbAno_TextChanged(object sender, EventArgs e)
        {
            CbMes.Items.Clear();
            if (CbAno.Text.Trim() != "")
            {
                C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
                c_RelatorioFolha.setMonth(CbAno.Text, CbMes);
                TxtDataEmissao.Text = DateTime.Today.ToString();
            }
        }

        private void CbMes_DropDown(object sender, EventArgs e)
        {
            C_SomaFolhaNormal c_SomaFolhaNormal = new C_SomaFolhaNormal();
            c_SomaFolhaNormal.sumTotal(CbAno.Text, CbMes.Text, this);
            TxtDataEmissao.Text = DateTime.Today.ToString().Substring(0, 10);
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            C_FolhaNormal c_FolhaNormal = new C_FolhaNormal();
            C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
            if (c_RelatorioFolha.dadosDuplicadoFNormal(TxtDataEmissao.Text))
            {
                c_FolhaNormal.setFolhaNormal(this);
                MessageBox.Show("Folha de Pagamento Detalhada lançada com Sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao lançar Folha. Dados Duplicados!");
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

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaNormalPDF formPDF = new FormFolhaNormalPDF(this);
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            formPDF.Show();
            c_PrintPDF.printPdf(formPDF.PanelFolhaDetalhada);
            formPDF.Close();
        }
        private void All_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
