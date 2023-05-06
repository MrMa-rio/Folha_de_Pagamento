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
    public partial class FormFolhaDetalhada : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();

        public FormFolhaDetalhada(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void BtnPesquisarMatricula_MouseClick(object sender, MouseEventArgs e)
        {
            C_ShowFolhaDetalhada c_ShowFolhaDetalhada = new C_ShowFolhaDetalhada();
            double DescInss;
            double DescIRRF;
            double DescFGTS;
            c_ShowFolhaDetalhada.getDataFuncionario(TxtPesquisarMatricula.Text, this);
            DescInss = c_ShowFolhaDetalhada.calculoINSS(TxtSalarioBase.Text, this);
            DescIRRF = c_ShowFolhaDetalhada.calculoIRRF(TxtSalarioBase.Text, DescInss, this);
            DescFGTS = c_ShowFolhaDetalhada.calculoFGTS(TxtSalarioBase.Text, this);
            c_ShowFolhaDetalhada.showResultadosGerais(DescInss, DescIRRF, TxtSalarioBase.Text, this);
        }

        private void TxtPesquisarMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                C_ShowFolhaDetalhada c_ShowFolhaDetalhada = new C_ShowFolhaDetalhada();
                double DescInss;
                double DescIRRF;
                double DescFGTS;
                c_ShowFolhaDetalhada.getDataFuncionario(TxtPesquisarMatricula.Text, this);
                DescInss = c_ShowFolhaDetalhada.calculoINSS(TxtSalarioBase.Text, this);
                DescIRRF = c_ShowFolhaDetalhada.calculoIRRF(TxtSalarioBase.Text, DescInss, this);
                DescFGTS = c_ShowFolhaDetalhada.calculoFGTS(TxtSalarioBase.Text, this);
                c_ShowFolhaDetalhada.showResultadosGerais(DescInss, DescIRRF, TxtSalarioBase.Text, this);
            }
        }

        private void TxtPesquisarMatricula_Click(object sender, EventArgs e)
        {
            TxtPesquisarMatricula.SelectAll();
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
            c_RelatorioFolha.setFolhaDetalhada(this);
            MessageBox.Show("Folha de Pagamento Detalhada lançada com Sucesso!!");
        }

        private void panelInss_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
