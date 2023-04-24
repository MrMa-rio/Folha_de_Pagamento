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

            C_ShowDataUsers c_ShowDataUsers = new C_ShowDataUsers();
            bool alert;
            alert = c_ShowDataUsers.setShowDataUser(TxtNomeCompleto, TxtCpf, CbEstadoCivil, CbGenero, TxtRg, TxtMatricula);

            if (!alert)
            {
                MessageBox.Show("Matrícula Inválida!");
            }
        }
        private void BtnEditar_MouseClick(object sender, MouseEventArgs e)
        {
            C_EnableBoxCadastro c_EnableBoxCadastro = new C_EnableBoxCadastro();
            c_EnableBoxCadastro.setEnableAltCadastro(this);
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

        private void TxtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                C_ShowDataUsers c_ShowDataUsers = new C_ShowDataUsers();
                c_ShowDataUsers.setShowDataUser(TxtNomeCompleto, TxtCpf, CbEstadoCivil, CbGenero, TxtRg, TxtMatricula);
            }
        }

        private void TxtMatricula_Click(object sender, EventArgs e)
        {
            TxtMatricula.SelectAll();
        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {
            TxtNomeCompleto.Text = TxtMatricula.Text;
        }
    }
}
