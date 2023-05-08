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
            if (TxtPesquisarMatricula.Text.Trim() != "")
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

        private void TxtPesquisarMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtPesquisarMatricula.Text.Trim() != "")
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
        }

        private void TxtPesquisarMatricula_Click(object sender, EventArgs e)
        {
            TxtPesquisarMatricula.SelectAll();
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {

            C_RelatorioFolha c_RelatorioFolha = new C_RelatorioFolha();
            if (c_RelatorioFolha.dadosDuplicadoDetalhado(TxtMatricula.Text, TxtDataEmissao.Text))
            {
                c_RelatorioFolha.setFolhaDetalhada(this);
                MessageBox.Show("Folha de Pagamento Detalhada lançada com Sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao lançar Folha. Dados Duplicados!");
            }

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes a sair desta página.\nTem certeza?", "Sair da Página", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}