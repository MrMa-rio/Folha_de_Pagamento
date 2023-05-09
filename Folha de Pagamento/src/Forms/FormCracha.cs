using FOLHA_DE_PAGAMENTO_.src.Servidor.GET;
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
    public partial class FormCracha : Form
    {
        C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
        public FormCracha(string matricula)
        {
            InitializeComponent();
            c_ManipulaçãoImagens.getImagemUser(PctFotoFunc, matricula);
        }
    }
}
