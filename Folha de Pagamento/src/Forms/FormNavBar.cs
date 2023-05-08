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
using FOLHA_DE_PAGAMENTO_.src.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormNavBar : Form
    {
        public FormHome FormAtivo;
        private Form handleForm;
        private C_FormShow c_FormShow = new C_FormShow();
        C_FormNavBarShow c_FormNavBarShow = new C_FormNavBarShow();
        C_privateArea c_privateArea = new C_privateArea();
        public FormNavBar()
        {
            InitializeComponent();
        }
        public FormNavBar(FormHome formHome) : this()
        {
            FormAtivo = formHome;
        }

        private void BtnArrowLeft_MouseClick(object sender, MouseEventArgs e)
        {
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void BtnCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            FormCadastroFunc formCadastro = new FormCadastroFunc(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formCadastro);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void BtnAlterarCadastro_MouseClick(object sender, MouseEventArgs e)
        {

            FormAlterarCadastro formAlterarCadastro = new FormAlterarCadastro(this, Convert.ToInt32(FormAtivo.DataUser[4]));
            handleForm = c_FormShow.setFormShow(FormAtivo, formAlterarCadastro);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void BtnGerenciamento_MouseClick(object sender, MouseEventArgs e)
        {
            C_HideAllForms c_HideAllForms = new C_HideAllForms();
            c_HideAllForms.setHideForms(PanelSubMenu);
        }

        private void BtnRelatorio_MouseClick(object sender, MouseEventArgs e)
        {
            C_HideAllForms c_HideAllForms = new C_HideAllForms();
            c_HideAllForms.setHideForms(PanelSubMenuRel);
        }

        private void BtnCargosFun_MouseClick(object sender, MouseEventArgs e)
        {
            FormCargos formCargosFun = new FormCargos(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formCargosFun);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }
        private void BtnPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            FormPesquisar formPesquisar = new FormPesquisar(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formPesquisar);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void BtnCalculoPagamento_MouseClick(object sender, MouseEventArgs e)
        {
            FormCalculoPagamento formCalculoPagamento = new FormCalculoPagamento(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formCalculoPagamento);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }
        private void BtnFolhaPNormal_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaNormal formFolhaNormal = new FormFolhaNormal(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formFolhaNormal);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }
        private void BtnFolhaPDetalhada_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaDetalhada formFolhaDetalhada = new FormFolhaDetalhada(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formFolhaDetalhada);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }
        private void BtnHolerite_MouseClick(object sender, MouseEventArgs e)
        {
            FormHolerite formHolerite = new FormHolerite(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formHolerite);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }
        private void BtnHoleriteFunc_MouseClick(object sender, MouseEventArgs e)
        {
            FormHoleriteFunc formHolerite = new FormHoleriteFunc(FormAtivo.DataUser[0], this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formHolerite);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void Pnl2_VisibleChanged(object sender, EventArgs e)
        {
            c_privateArea.setNvlAcesso(FormAtivo.DataUser[4]);
        }

        private void BtnLogout_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Trocar de Perfil ?", "Trocar Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                C_VerificarLogin c_VerificarLogin = new C_VerificarLogin();
                c_FormNavBarShow.AnimationHide(this, Pnl2);

                foreach (Control control in FormAtivo.Controls)
                {
                    control.Hide();
                }
                c_VerificarLogin.logout(FormAtivo);
            }
        }

        private void BtnFolhaPNormalPesq_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaNormalPesq formNormalPesq = new FormFolhaNormalPesq(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formNormalPesq);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void FolhaPDetalhadaPesq_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaDetalhadaPesq formDetalhadaPesq = new FormFolhaDetalhadaPesq(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formDetalhadaPesq);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void BtnConfiguracao_MouseClick(object sender, MouseEventArgs e)
        {
            FormSobre formSobre = new FormSobre(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formSobre);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }
    }
}
