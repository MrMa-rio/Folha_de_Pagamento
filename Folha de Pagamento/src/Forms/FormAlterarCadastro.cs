using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOLHA_DE_PAGAMENTO_.src.Classes;
using FOLHA_DE_PAGAMENTO_.src.SQL;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormAlterarCadastro : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormAlterarCadastro(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
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

        private void BoxCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtCalendario.Text = BoxCalendario.SelectionEnd.ToString();
        }

        private void BtnCalendario2_MouseClick(object sender, MouseEventArgs e)
        {
            BoxCalendario2.Location = new Point(469, 214);
            BoxCalendario2.Visible = !BoxCalendario2.Visible ? true : false;
        }
        private void BoxCalendario2_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtDataEmissao.Text = BoxCalendario2.SelectionEnd.ToString();
        }
        private void TxtCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCalendario.SelectAll();
        }

        private void TxtCpf_MouseClick(object sender, MouseEventArgs e)
        {
            TxtCpf.SelectAll();
        }

        private void TxtDataEmissao_MouseClick(object sender, MouseEventArgs e)
        {
            TxtDataEmissao.SelectAll();
        }
        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void BtnPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            string[] Result = new string[9];
            C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();
            Result = c_SearchInDataBase.getDatainTable(Convert.ToInt32(TxtMatricula.Text), TxtNomePesquisa.Text);
            TxtNomeCompleto.Text = Result[0];
        }
    }
}
