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
    public partial class FormCargos : Form
    {
        FormNavBar FormAtivo;
        C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormCargos()
        {
            InitializeComponent();
        }
        public FormCargos(FormNavBar navBar) : this()
        {
            FormAtivo = navBar;
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
            bool alert = c_HandleCargoSalario.setCargo(TxtCargo, TxtSalarioBase);
            if (alert)
            {
                MessageBox.Show("Cadastro realizado com Sucesso");
            }
            else
            {
                MessageBox.Show("Cadastro de Cargo Inválida");
            }
        }

        private void BtnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes a sair desta página.\nTem certeza?", "Sair da Página", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void CbCargo_TextChanged(object sender, EventArgs e)
        {
            C_handleCargoSalarioDepartamento c_HandleCargoSalarioDepartamento = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalarioDepartamento.getCargo(CbCargo);
            c_HandleCargoSalarioDepartamento.getSalario(CbCargo, TxtAlterarSalario);
            TxtAlterarCargo.Text = CbCargo.Text;
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes à alterar esse Cargo! Tem certeza?", "Alterar Cargo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                C_handleCargoSalarioDepartamento c_HandleCargoSalarioDepartamento = new C_handleCargoSalarioDepartamento();
                c_HandleCargoSalarioDepartamento.alterCargo(CbCargo, TxtAlterarCargo, TxtAlterarSalario);
            }
        }

        private void BtnErase2_MouseClick(object sender, MouseEventArgs e)
        {
            C_eraseBoxes c_Erase = new C_eraseBoxes();
            c_Erase.eraseTextBox(PnlAlteraCargo);
        }

        private void BtnErase1_MouseClick(object sender, MouseEventArgs e)
        {
            C_eraseBoxes c_Erase = new C_eraseBoxes();
            c_Erase.eraseTextBox(PnlCadastraCargos);
        }

        private void BtnRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            FormNavBar navBar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
            FormCargos formCargos = new FormCargos(navBar);
            C_FormShow c_FormShow = new C_FormShow();
            c_FormShow.refreshFormWithAlert(formCargos, this);
        }

        private void BtnDeletarCargo_MouseClick(object sender, MouseEventArgs e)
        {
            C_handleCargoSalarioDepartamento c_HandleCargoSalarioDepartamento = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalarioDepartamento.deleteCargo(CbCargo);
        }
        private void All_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}