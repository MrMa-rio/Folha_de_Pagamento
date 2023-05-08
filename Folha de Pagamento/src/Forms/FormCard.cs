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

namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    public partial class FormCard : Form
    {
        FormNavBar formNavBar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
        Form formPrincipal = Application.OpenForms.OfType<FormHome>().FirstOrDefault();
        private string[] DadosFuncionario;

        C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
        public FormCard()
        {
            InitializeComponent();
        }
        public FormCard(string[] dadosFuncionario) : this()
        {
            DadosFuncionario = dadosFuncionario;
            TxtNome.Text = dadosFuncionario[2];
            TxtMatricula.Text = dadosFuncionario[0];
            TxtCargo.Text = c_HandleCargoSalario.getIdCargo(dadosFuncionario[15]);
            TxtDepartamento.Text = c_HandleCargoSalario.getIdDepartamento(dadosFuncionario[14]);
        }

        private void PnlBackground_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            PnlBackground.BackColor = Color.DarkGray;
            PanelCard.BackColor = Color.DarkGray;
        }

        private void PnlBackground_MouseEnter(object sender, EventArgs e)
        {
            Thread.Sleep(45);
            PnlBackground.BackColor = Color.LightGray;
            PanelCard.BackColor = Color.Gray;
        }

        private void PnlBackground_MouseClick(object sender, MouseEventArgs e)
        {
            C_FormShow formShow = new C_FormShow();
            FormAlterarCadastro formAlterarCadastro = new FormAlterarCadastro(formNavBar, DadosFuncionario[0], Convert.ToInt32(formNavBar.FormAtivo.DataUser[4]));
            formShow.setFormShow(formPrincipal, formAlterarCadastro);
        }
    }
}
