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
        public FormCargos(FormNavBar navBar) :this()
        {
            FormAtivo = navBar;
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }
    }
}
