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
    public partial class FormShowDadosCadastrais : Form
    {
        private string[] Result;
        private string matricula;

        public FormShowDadosCadastrais()
        {
            InitializeComponent();

        }
        public FormShowDadosCadastrais(string[] result, string matriculaFuncionario) : this()
        {
            Result = result;
            matricula = matriculaFuncionario;
        }
        private void FormShowDadosCadastrais_Load(object sender, EventArgs e)
        {
            C_ManiplaçaoData c_InvertendoData = new C_ManiplaçaoData();
            TxtMatricula.Text = matricula;
            TxtNomeCompleto.Text = Result[1];
            TxtCpf.Text = Result[0];
            TxtRg.Text = Result[4];
            TxtGenero.Text = Result[3];
            TxtCargo.Text = Result[9];
            TxtIdCargo.Text = Result[10];
            TxtDataAdmissao.Text = c_InvertendoData.setDateReInvert(Result[11]);

        }

        private void BtnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
