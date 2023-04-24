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
    public partial class FormCadastroFunc : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        private bool ValidadorCPF;
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
            BoxCalendario2.Location = new Point(469, 214);
            BoxCalendario2.Visible = !BoxCalendario2.Visible ? true : false;
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
            C_InvertendoData c_InvertendoData = new C_InvertendoData();
            string departamento = c_HandleCargoSalario.setIdDepartamento(CbDepartamento.Text);
            string cargo = c_HandleCargoSalario.setIdCargo(CbCargo.Text);
            string DataNascimento = c_InvertendoData.setDateInvert(TxtDataNascimento.Text);
            string DataAdmissao = c_InvertendoData.setDateInvert(TxtDataAdmissao.Text);

            C_InsertAndUpdate c_InsertAndUpdate = new C_InsertAndUpdate();
            c_InsertAndUpdate.setDatainTbFuncionarios(TxtNomeCompleto, DataNascimento, TxtNit, TxtPis, TxtTituloEleitor, departamento, cargo, DataAdmissao, TxtReservista, ValidadorCPF, CbEstadoCivil, CbGenero, TxtCpf, TxtRg);

        }
        private void BtnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Você está preste a fechar a area de Cadatro! Tem certeza?", "Alerta!", MessageBoxButtons.OKCancel);
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
        }

        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {
            LbTelefoneResult.Text = TxtTelefone.Text;
        }

        private void CbCargo_TextChanged(object sender, EventArgs e)
        {
            C_handleCargoSalarioDepartamento c_Cargo = new C_handleCargoSalarioDepartamento();
            LbCargoResult.Text = CbCargo.Text;
            TxtSalarioBase.Text = c_Cargo.setSalarioBase(CbCargo.Text);
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
    }
}
