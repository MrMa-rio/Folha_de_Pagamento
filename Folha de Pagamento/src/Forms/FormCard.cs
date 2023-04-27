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
        private string[] DadosFuncionario;
        C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
        public FormCard(string[] dadosFuncionario)
        {
            InitializeComponent();
            DadosFuncionario = dadosFuncionario;
            TxtNome.Text = dadosFuncionario[2];
            TxtMatricula.Text = dadosFuncionario[0];
            TxtCargo.Text = c_HandleCargoSalario.getIdCargo(dadosFuncionario[14]);
            TxtDepartamento.Text = c_HandleCargoSalario.getIdDepartamento( dadosFuncionario[13]);

        }

        private void PanelCard_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.White;
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
    }
}
