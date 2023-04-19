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
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormCadastroFunc(FormNavBar NavBar)
        {
            InitializeComponent();
            FormAtivo = NavBar;
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            C_ValidadorCPF c_ValidadorCPF = new C_ValidadorCPF();
            c_ValidadorCPF.setValidacao(TxtCpf, PctCpf);
        }

        private void BtnCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            BoxCalendario.Visible = !BoxCalendario.Visible ? true : false;
        }

        private void BoxCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            TxtDataNascimento.Text = BoxCalendario.SelectionEnd.ToString();
        }

        private void BtnCalendario2_MouseClick(object sender, MouseEventArgs e)
        {
            BoxCalendario2.Location = new Point(469, 214);
            BoxCalendario2.Visible = !BoxCalendario2.Visible ? true : false;
        }

        private void BoxCalendario2_DateSelected(object sender, DateRangeEventArgs e)
        {
            TxtDataEmissao.Text = BoxCalendario2.SelectionEnd.ToString();
        }

        private void TxtDataNascimento_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDataNascimento.SelectAll();
        }

        private void TxtCpf_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCpf.SelectAll();
        }

        private void TxtRg_MouseClick(object sender, MouseEventArgs e)
        {
            TxtRg.SelectAll();
        }

        private void TxtTelefone_MouseClick(object sender, MouseEventArgs e)
        {
            TxtTelefone.SelectAll();
        }

        private void TxtCep_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCep.SelectAll();
        }

        private void TxtDataEmissao_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDataEmissao.SelectAll();
        }

        private void PnlCadastro_Click(object sender, EventArgs e)
        {
            FormAtivo.Pnl2.Visible = false;
            FormAtivo.Visible = false;
        }

        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }
    }
}
