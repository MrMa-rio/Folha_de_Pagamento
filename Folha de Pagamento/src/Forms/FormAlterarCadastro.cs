using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.Servidor.GET;
using FOLHA_DE_PAGAMENTO_.src.SQL;
using Microsoft.VisualBasic.Devices;
using FOLHA_DE_PAGAMENTO_.src.Forms;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormAlterarCadastro : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        private C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
        private C_ShowDataUsers c_ShowDataUsers = new C_ShowDataUsers();
        private C_VerificadorCEP verificadorCEP = new C_VerificadorCEP();
        private C_ManiplaçaoData c_Manipula = new C_ManiplaçaoData();
        private Form formCracha = null;
        private int NvlAcesso;
        string endereco = "";
        C_privateArea c_PrivateArea = new C_privateArea();
        private bool validacao;
        private bool validacaoDate;
        public FormAlterarCadastro()
        {
            InitializeComponent();
        }
        public FormAlterarCadastro(FormNavBar navBar, int nvlAcesso) : this()
        {
            FormAtivo = navBar;
            NvlAcesso = nvlAcesso;

            c_PrivateArea.setDeleteFuncNvl1(BtnDeleteFunc, nvlAcesso);
        }
        public FormAlterarCadastro(FormNavBar navBar, string matriculaFuncionario, int nvlAcesso) : this()
        {
            FormAtivo = navBar;
            TxtMatricula.Text = matriculaFuncionario;
            Keyboard keyboard = new Keyboard();
            keyboard.SendKeys("{ENTER}");
            NvlAcesso = nvlAcesso;
            c_PrivateArea.setDeleteFuncNvl1(BtnDeleteFunc, nvlAcesso);
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            C_ValidadorCPF c_ValidadorCPF = new C_ValidadorCPF();
            validacao = c_ValidadorCPF.setValidacao(TxtCpf, PctCpf);
        }

        private void BtnCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            BoxCalendario.Visible = !BoxCalendario.Visible ? true : false;
        }
        private void BoxCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtCalendario.Text = BoxCalendario.SelectionEnd.ToString();
        }

        private void BtnCalendario2_MouseClick(object sender, MouseEventArgs e)
        {
            BoxCalendario2.Visible = !BoxCalendario2.Visible ? true : false;
            BoxCalendario2.Location = new Point(444, BtnCalendario2.Location.Y);
        }
        private void BoxCalendario2_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtDataAdmissao.Text = BoxCalendario2.SelectionEnd.ToString();
        }
        private void TxtCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCalendario.SelectAll();
        }

        private void TxtCpf_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCpf.SelectAll();
        }
        private void Scroll_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        private void TxtDataEmissao_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDataAdmissao.SelectAll();
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            if (FormAtivo != null)
            {
                navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
            }
        }
        private void BtnPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            c_ShowDataUsers.setShowDataUser(TxtCpf, TxtNomeCompleto,
                TxtCalendario, CbGenero,
                TxtRg, TxtCTrabalho, TxtNit, TxtPis,
                TxtTituloEleitor, CbEstadoCivil,
                TxtReservista, TxtDataAdmissao,
                CbDepartamento, CbCargo, TxtMatricula, BtnEditar, PnlCtrlFunc, BtnCracha
                );
            c_ShowDataUsers.setShowEndereco(TxtRua, TxtNumRua, TxtBairro, TxtComplemento, CbUF, TxtCidade, TxtCep, TxtMatricula);
            c_ShowDataUsers.setShowTelefone(TxtTelefone, TxtMatricula);
            c_ShowDataUsers.setShowEmail(TxtEmail, TxtMatricula);
            C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
            if (!c_ManipulaçãoImagens.getImagemUser(PctUser, TxtMatricula.Text))
            {
                PctUser.BackgroundImage = Properties.Resources.circle_account1;
            }
            if (validacao)
            {
                BtnConfirmar.Enabled = true;
            }
            else
            {
                BtnConfirmar.Enabled = false;
            }
        }
        private void BtnEditar_MouseClick(object sender, MouseEventArgs e)
        {
            C_EnableBoxCadastro c_EnableBoxCadastro = new C_EnableBoxCadastro();
            //c_EnableBoxCadastro.setEnableAltCadastro(this);
            c_EnableBoxCadastro.enable_disable(PnlCtrlFunc);
            BtnDeleteFunc.Enabled = false;
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

        private void TxtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool Validacao = c_ShowDataUsers.setShowDataUser(TxtCpf, TxtNomeCompleto,
                    TxtCalendario, CbGenero,
                    TxtRg, TxtCTrabalho, TxtNit, TxtPis,
                    TxtTituloEleitor, CbEstadoCivil,
                    TxtReservista, TxtDataAdmissao,
                    CbDepartamento, CbCargo, TxtMatricula, BtnEditar, PnlCtrlFunc, BtnCracha
                    );

                c_ShowDataUsers.setShowEndereco(TxtRua, TxtNumRua, TxtBairro, TxtComplemento, CbUF, TxtCidade, TxtCep, TxtMatricula);
                c_ShowDataUsers.setShowTelefone(TxtTelefone, TxtMatricula);
                c_ShowDataUsers.setShowEmail(TxtEmail, TxtMatricula);
                C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
                c_ManipulaçãoImagens.getImagemUser(PctUser, TxtMatricula.Text);
                if (validacao)
                {
                    BtnConfirmar.Enabled = true;
                }
                else
                {
                    BtnConfirmar.Enabled = false;
                }
                if (Validacao)
                {
                    BtnDeleteFunc.Enabled = true;
                }
                else { BtnDeleteFunc.Enabled = false; }
            }
        }

        private void TxtMatricula_Click(object sender, EventArgs e)
        {
            TxtMatricula.SelectAll();
        }

        private void TxtTituloEleitor_MouseClick(object sender, MouseEventArgs e)
        {
            TxtTituloEleitor.SelectAll();
        }

        private void TxtReservista_MouseClick(object sender, MouseEventArgs e)
        {
            TxtReservista.SelectAll();
        }

        private void TxtNit_MouseClick(object sender, MouseEventArgs e)
        {
            TxtNit.SelectAll();
        }

        private void TxtPis_MouseClick(object sender, MouseEventArgs e)
        {
            TxtPis.SelectAll();
        }

        private void TxtCTrabalho_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCTrabalho.SelectAll();
        }

        private void CbCargo_TextChanged(object sender, EventArgs e)
        {
            CbCargo.Controls.Clear();
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalario.getCargo(CbCargo);
            c_HandleCargoSalario.getSalario(CbCargo, TxtSalarioBase);
        }
        private void CbCargo_DropDown(object sender, EventArgs e)
        {
            CbCargo.Controls.Clear();
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalario.getCargo(CbCargo);
        }
        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult messageAlert = MessageBox.Show("Você está prestes a alterar este cadastro. Tem certeza?", "Alterar Cadastro", MessageBoxButtons.YesNo);
            if (messageAlert == DialogResult.Yes)
            {
                C_ManiplaçaoData c_InvertendoData = new C_ManiplaçaoData();

                string DataNascimento = c_InvertendoData.setDateInvert(TxtCalendario.Text, '/');
                string DataAdmissao = c_InvertendoData.setDateInvert(TxtDataAdmissao.Text, '/');

                string departamento = c_HandleCargoSalario.setIdDepartamento(CbDepartamento.Text);
                string cargo = c_HandleCargoSalario.setIdCargo(CbCargo.Text);
                string NvlAcesso = c_HandleCargoSalario.setNvlAcesso(CbDepartamento.Text); /////////////////////////////////////////////////
                string[] data = new string[] { TxtCpf.Text,
                    TxtNomeCompleto.Text, DataNascimento,
                    CbGenero.Text, TxtRg.Text,TxtCTrabalho.Text, TxtNit.Text,
                    TxtPis.Text, TxtTituloEleitor.Text,
                    CbEstadoCivil.Text, TxtReservista.Text,
                    DataAdmissao, departamento, cargo,
                    TxtMatricula.Text,NvlAcesso,validacao.ToString(), validacaoDate.ToString()
                };
                string[] dataTelefone = new string[] { TxtTelefone.Text };
                string[] dataEmail = new string[] { TxtEmail.Text };

                string[] dataCadastroPessoal = new string[] { TxtNomeCompleto.Text,
                    DataNascimento, TxtNit.Text,
                    TxtPis.Text, TxtTituloEleitor.Text,
                    departamento, cargo, DataAdmissao,
                    TxtReservista.Text, validacao.ToString(),
                    CbEstadoCivil.Text, CbGenero.Text, TxtCpf.Text,
                    TxtRg.Text, CbCargo.Text
                };

                string[] dataCadastroAdicional = new string[] { TxtRua.Text, TxtNumRua.Value.ToString(), TxtBairro.Text, TxtComplemento.Text, CbUF.Text, TxtCidade.Text, TxtCep.Text };
                bool alert = c_ShowDataUsers.VerificaDadosFuncionario(dataCadastroPessoal);
                if (endereco != "")
                {
                    C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
                    c_ManipulaçãoImagens.setImagemUser(TxtMatricula.Text, endereco);
                }

                if (alert)
                {
                    C_updateSql c_UpdateSql = new C_updateSql();
                    c_UpdateSql.setUpdateFuncionario(data, dataCadastroAdicional, dataTelefone, dataEmail);
                }
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

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
            endereco = c_ManipulaçãoImagens.setFotoNovoFuncionario(PctUser);
        }
        private void FormAlterarCadastro_Load(object sender, EventArgs e)
        {
            TxtMatricula.Select();
        }

        private void TxtCalendario_TextChanged(object sender, EventArgs e)
        {
            validacaoDate = c_Manipula.setValidacaoData(TxtCalendario, BoxCalendario.TodayDate, PctData);
        }
        private void TxtCep_Leave(object sender, EventArgs e)
        {
            if (TxtCep.Text.Length == 8)
            {
                verificadorCEP.LocalizarCEP(TxtCep.Text, CbUF, TxtCidade, TxtBairro, TxtRua, TxtCep);
            }
        }
        private void BtnDeleteFunc_MouseClick(object sender, MouseEventArgs e)
        {
            FormDesativarFunc formDesativarFunc = new FormDesativarFunc(this);
            formDesativarFunc.ShowDialog();
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
            //validacaoDataAdmissao = c_Manipula.setValidacaoDataAdmissao(TxtDataAdmissao, BoxCalendario2.TodayDate, PctDataAdmissao);
        }

        private void BtnCracha_MouseClick(object sender, MouseEventArgs e)
        {
            if (formCracha == null)
            {
                formCracha = new FormCracha(TxtMatricula.Text);
                formCracha.Show();
            }
            else
            {
                formCracha.Close();
                formCracha = null;
            }
        }
    }
}
