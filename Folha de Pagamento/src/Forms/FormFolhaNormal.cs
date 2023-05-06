using FOLHA_DE_PAGAMENTO_.src.Classes;
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

        private void BtnImprimir_MouseClick(object sender, MouseEventArgs e)
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.printPdf(PanelFolhaDetalhada);
        }

        private void CbAno_DropDown(object sender, EventArgs e)
        {
            C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();

            c_RelatorioFolha.getYearFolhaNormal(CbAno);
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
            TxtDataEmissao.Text = DateTime.Today.ToString();
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            C_FolhaNormal c_FolhaNormal = new C_FolhaNormal();
            c_FolhaNormal.setFolhaNormal(this);
        }
    }
}
