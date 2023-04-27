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
using FOLHA_DE_PAGAMENTO_.src.SQL;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormAlterarCadastro : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
        C_ShowDataUsers c_ShowDataUsers = new C_ShowDataUsers();

        private bool validacao;
        public FormAlterarCadastro(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;


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

        private void TxtDataEmissao_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDataAdmissao.SelectAll();
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void BtnPesquisar_MouseClick(object sender, MouseEventArgs e)
        {


            c_ShowDataUsers.setShowDataUser(TxtCpf, TxtNomeCompleto, TxtCalendario, CbGenero, TxtRg, TxtNit, TxtPis, TxtTituloEleitor, CbEstadoCivil, TxtReservista, TxtDataAdmissao, CbDepartamento, CbCargo, TxtMatricula); //adicionar textbox dos parametros que falta!! e testar as entradas.
            c_ShowDataUsers.setShowEndereco(TxtRua, TxtNumRua, TxtBairro, TxtComplemento, CbUF, TxtCidade, TxtCep, TxtMatricula);
            c_ShowDataUsers.setShowTelefone(TxtTelefone,TxtMatricula);
            c_ShowDataUsers.setShowEmail(TxtEmail, TxtMatricula);
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
            c_EnableBoxCadastro.setEnableAltCadastro(this);
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

                
                c_ShowDataUsers.setShowDataUser(TxtCpf, TxtNomeCompleto, TxtCalendario, CbGenero, TxtRg, TxtNit, TxtPis, TxtTituloEleitor, CbEstadoCivil, TxtReservista, TxtDataAdmissao, CbDepartamento, CbCargo, TxtMatricula); //adicionar textbox dos parametros que falta!! e testar as entradas.
                c_ShowDataUsers.setShowEndereco(TxtRua, TxtNumRua, TxtBairro, TxtComplemento, CbUF, TxtCidade, TxtCep, TxtMatricula);
                c_ShowDataUsers.setShowTelefone(TxtTelefone, TxtMatricula);
                c_ShowDataUsers.setShowEmail(TxtEmail, TxtMatricula);
                if (validacao)
                {
                    BtnConfirmar.Enabled = true;
                }
                else
                {
                    BtnConfirmar.Enabled = false;
                }
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

            TxtSalarioBase.Text = c_HandleCargoSalario.setSalarioBase(CbCargo.Text);
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult messageAlert = MessageBox.Show("Você está preste à alterar este cadastro. Tem certeza?", "Alterar Cadastro", MessageBoxButtons.YesNo);
            if (messageAlert == DialogResult.Yes)
            {
                C_InvertendoData c_InvertendoData = new C_InvertendoData();

                string DataNascimento = c_InvertendoData.setDateInvert(TxtCalendario.Text, '/');
                string DataAdmissao = c_InvertendoData.setDateInvert(TxtDataAdmissao.Text, '/');
                string departamento = c_HandleCargoSalario.setIdDepartamento(CbDepartamento.Text);
                string cargo = c_HandleCargoSalario.setIdCargo(CbCargo.Text);
                string[] data = new string[] { TxtCpf.Text, TxtNomeCompleto.Text, DataNascimento, CbGenero.Text, TxtRg.Text, TxtNit.Text, TxtPis.Text, TxtTituloEleitor.Text, CbEstadoCivil.Text, TxtReservista.Text, DataAdmissao, departamento, cargo, TxtMatricula.Text };
                string[] dataTelefone = new string[] { TxtTelefone.Text };
                string[] dataEmail = new string[] { TxtEmail.Text };
                string[] dataCadastroPessoal = new string[] { TxtNomeCompleto.Text, DataNascimento, TxtNit.Text, TxtPis.Text, TxtTituloEleitor.Text, departamento, cargo, DataAdmissao, TxtReservista.Text, validacao.ToString(), CbEstadoCivil.Text, CbGenero.Text, TxtCpf.Text, TxtRg.Text, CbCargo.Text };
                string[] dataCadastroAdicional = new string[] { TxtRua.Text, TxtNumRua.Value.ToString(), TxtBairro.Text, TxtComplemento.Text, CbUF.Text, TxtCidade.Text, TxtCep.Text };
                bool alert = c_ShowDataUsers.VerificaDadosFuncionario(dataCadastroPessoal);

                if (alert)
                {
                    C_updateSql c_UpdateSql = new C_updateSql();
                    c_UpdateSql.setUpdateFuncionario(data, dataCadastroAdicional,dataTelefone, dataEmail);
                }
            }




        }

        private void BtnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
