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
    public partial class FormCalculoPagamento : Form
    {
        FormNavBar FormAtivo;
        public FormCalculoPagamento(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
        }
    }
}
