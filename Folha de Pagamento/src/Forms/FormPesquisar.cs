using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.SQL;
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
    public partial class FormPesquisar : Form
    {
        FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        C_ListaDinamica c = new C_ListaDinamica();
        C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
        public FormPesquisar()
        {
            InitializeComponent();
            c.handleListFuncionario("Nome", TxtPesquisarNomes.Text, this);
        }
        public FormPesquisar(FormNavBar navBar) : this()
        {
            FormAtivo = navBar;
        }

        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }
        private void TxtPesquisarCargo_TextChanged(object sender, EventArgs e)
        {
            TxtPesquisarCargo.Controls.Clear();
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalario.getCargo(TxtPesquisarCargo);
            c.handleListFuncionario("FK_Cargo", c_HandleCargoSalario.setIdCargo(TxtPesquisarCargo.Text), this);
        }

        private void TxtPesquisarNomes_TextChanged(object sender, EventArgs e)
        {
            c.handleListFuncionario("Nome", TxtPesquisarNomes.Text, this);
        }

        private void TxtPesquisarCargo_DropDown(object sender, EventArgs e)
        {
            TxtPesquisarCargo.Controls.Clear();
            C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
            c_HandleCargoSalario.getCargo(TxtPesquisarCargo);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes a sair desta página.\nTem certeza?", "Sair da Página", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
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
