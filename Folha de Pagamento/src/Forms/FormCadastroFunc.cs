using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.Servidor.GET;
using FOLHA_DE_PAGAMENTO_.src.SQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormCadastroFunc : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        private C_ManiplaçaoData c_InvertendoData = new C_ManiplaçaoData();
        private C_VerificadorCEP c_verificadorCEP = new C_VerificadorCEP();
        private bool ValidadorCPF;
        private bool ValidacaoDate;
        private bool ValidacaoDataAdmissao;
        private string endereco = "";
        private string matricula;
        public FormCadastroFunc(FormNavBar NavBar)
        {
            InitializeComponent();
            FormAtivo = NavBar;
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            LbCpfResult.Text = TxtCpf.Text;
            C_ValidadorCPF c_ValidadorCPF = new C_ValidadorCPF();
            ValidadorCPF = c_ValidadorCPF.setValidacao(TxtCpf, PctCpf);
        }

        private void BtnCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            BoxCalendario.Visible = !BoxCalendario.Visible ? true : false;
        }

        private void BoxCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            TxtDataNascimento.Text = BoxCalendario.SelectionEnd.ToString();
        }

        private void BtnCalendario2_MouseClick(object sender, MouseEventArgs e)
        {
            BoxCalendario2.Visible = !BoxCalendario2.Visible ? true : false;
            BoxCalendario2.Location = new Point(444, BtnCalendario2.Location.Y);
        }

        private void BoxCalendario2_DateSelected(object sender, DateRangeEventArgs e)
        {
            TxtDataAdmissao.Text = BoxCalendario2.SelectionEnd.ToString();
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }
        private void TxtDataNascimento_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDataNascimento.SelectAll();
        }

        private void TxtCpf_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCpf.SelectAll();
        }

        private void TxtRg_MouseClick(object sender, MouseEventArgs e)
        {
            TxtRg.SelectAll();
        }

        private void TxtTelefone_MouseClick(object sender, MouseEventArgs e)
        {
            TxtTelefone.SelectAll();
        }

        private void TxtCep_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCep.SelectAll();
        }

        private void TxtDataEmissao_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDataAdmissao.SelectAll();
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();

            string departamento = c_HandleCargoSalario.setIdDepartamento(CbDepartamento.Text);
            string cargo = c_HandleCargoSalario.setIdCargo(CbCargo.Text);
            string DataNascimento = c_InvertendoData.setDateInvert(TxtDataNascimento.Text, '/');
            string DataAdmissao = c_InvertendoData.setDateInvert(TxtDataAdmissao.Text, '/');

            string[] dataCadastroPessoal = new string[] { TxtNomeCompleto.Text,
                DataNascimento, TxtNit.Text,
                TxtPis.Text, TxtTituloEleitor.Text,
                departamento, cargo, DataAdmissao,
                TxtReservista.Text, ValidadorCPF.ToString(),
                CbEstadoCivil.Text, CbGenero.Text,
                TxtCpf.Text, TxtRg.Text, CbCargo.Text,TxtCTrabalho.Text,ValidacaoDate.ToString(), ValidacaoDataAdmissao.ToString()
            };

            string[] dataCadastroAdicional = new string[] { TxtRua.Text, TxtNumRua.Value.ToString(),
                TxtBairro.Text, TxtComplemento.Text,
                CbUF.Text, TxtCidade.Text, TxtCep.Text,
                TextEmail.Text, TxtTelefone.Text
            };

            C_InsertData c_InsertData = new C_InsertData();
            matricula = c_InsertData.setDatainDB(dataCadastroPessoal, dataCadastroAdicional);
            if (endereco != "")
            {
                C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
                c_ManipulaçãoImagens.setImagemUser(matricula, endereco);
            }
            if (matricula != "0")
            {
                C_FormShow c_FormShow = new C_FormShow();
                FormNavBar navBar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
                FormCadastroFunc formCadastroFunc = new FormCadastroFunc(navBar);
                c_FormShow.refreshForm(formCadastroFunc, this);
            }
        }
        private void BtnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Você está prestes a fechar a Área de Cadastro! Tem certeza?", "Alerta!", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                Close();
            }
        }

        private void TxtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            LbNomeCompletoResult.Text = TxtNomeCompleto.Text;
        }

        private void TxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            LbDataNascimentoResult.Text = TxtDataNascimento.Text;
            ValidacaoDate = c_InvertendoData.setValidacaoData(TxtDataNascimento, BoxCalendario.TodayDate, Pctdata);
        }

        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {
            LbTelefoneResult.Text = TxtTelefone.Text;
        }

        private void TxtNit_MouseClick(object sender, MouseEventArgs e)
        {
            TxtNit.SelectAll();
        }

        private void TxtCTrabalho_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCTrabalho.SelectAll();
        }
        private void TxtPis_MouseClick(object sender, MouseEventArgs e)
        {
            TxtPis.SelectAll();
        }
        private void TxtTituloEleitor_MouseClick(object sender, MouseEventArgs e)
        {
            TxtTituloEleitor.SelectAll();
        }

        private void TxtReservista_MouseClick(object sender, MouseEventArgs e)
        {
            TxtReservista.SelectAll();
        }

        private void button1_MouseClick(object sender, EventArgs e)
        {
            C_ManipulaçãoImagens c_GetImagens = new C_ManipulaçãoImagens();
            endereco = c_GetImagens.setFotoNovoFuncionario(PctFotoFunc);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            C_ManipulaçãoImagens c_Manipulação = new C_ManipulaçãoImagens();
            {
                c_Manipulação.erasePhoto(PctFotoFunc);
            }
        }

        private void TxtCep_Leave(object sender, EventArgs e)
        {
            if (TxtCep.Text.Length == 8)
            {
                c_verificadorCEP.LocalizarCEP(TxtCep.Text, CbUF, TxtCidade, TxtBairro, TxtRua, TxtCep);
            }
        }
        private void CbCargo_DropDown(object sender, EventArgs e)
        {
            CbCargo.Controls.Clear();
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalario.getCargo(CbCargo);
            LbCargoResult.Text = CbCargo.Text;
        }
        private void CbCargo_Leave(object sender, EventArgs e)
        {
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalario.getSalario(CbCargo, TxtSalarioBase);
        }

        private void BtnLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            C_eraseBoxes c_EraseBoxes = new C_eraseBoxes();
            c_EraseBoxes.eraseTextBox(PnlCtrlFunc);
        }
        private void BtnRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            FormNavBar navBar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
            FormCadastroFunc formCadastroFunc = new FormCadastroFunc(navBar);
            C_FormShow c_FormShow = new C_FormShow();
            c_FormShow.refreshFormWithAlert(formCadastroFunc, this);
        }

        private void All_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void All_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '@')
            {
                e.Handled = true;
            }
        }

        private void TxtDataAdmissao_TextChanged(object sender, EventArgs e)
        {
            ValidacaoDataAdmissao = c_InvertendoData.setValidacaoDataAdmissao(TxtDataAdmissao, BoxCalendario2.TodayDate, PctDataAdmissao);
        }
    }
}
