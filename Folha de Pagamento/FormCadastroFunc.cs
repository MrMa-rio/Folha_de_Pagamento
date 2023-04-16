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
    public partial class FormCadastroFunc : Form
    {
        private Form FormAtivo; //Nao utilizado
        public FormCadastroFunc(Form C_FormAtivo)
        {
            InitializeComponent();
            FormAtivo = C_FormAtivo;
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            C_ValidadorCPF c_ValidadorCPF = new C_ValidadorCPF();
            c_ValidadorCPF.setValidacao(TxtCpf, LbValidacao);
        }
    }
}
