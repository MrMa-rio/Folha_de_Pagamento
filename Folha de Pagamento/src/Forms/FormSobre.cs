using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_;
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
    public partial class FormSobre : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormSobre()
        {
            InitializeComponent();
        }
        public FormSobre(FormNavBar navBar) : this()
        {
            InitializeComponent();
            FormAtivo = navBar;
        }

        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void BtnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
