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
using static System.Net.Mime.MediaTypeNames;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormNavBar : Form
    {
        public FormHome FormAtivo;
        private Form handleForm;
        private C_FormShow c_FormShow = new C_FormShow();

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
            C_FormNavBarShow c_FormNavBarShow = new C_FormNavBarShow();
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void BtnCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            FormCadastroFunc formCadastro = new FormCadastroFunc(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formCadastro, handleForm);
        }

        private void BtnAlterarCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            
            FormAlterarCadastro formAlterarCadastro = new FormAlterarCadastro(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formAlterarCadastro, handleForm);
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
            handleForm = c_FormShow.setFormShow(FormAtivo, formCargosFun, handleForm);

        }
        private void BtnCalculoPagamento_MouseClick(object sender, MouseEventArgs e)
        {
            FormCalculoPagamento formCalculoPagamento = new FormCalculoPagamento(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formCalculoPagamento, handleForm);

        }
        private void BtnFolhaPNormal_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaNormal formFolhaNormal = new FormFolhaNormal();
            handleForm = c_FormShow.setFormShow(FormAtivo, formFolhaNormal, handleForm);

        }
        private void BtnFolhaPDetalhada_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaDetalhada formFolhaDetalhada = new FormFolhaDetalhada();
            handleForm = c_FormShow.setFormShow(FormAtivo, formFolhaDetalhada, handleForm);

        }
        private void BtnHolerite_MouseClick(object sender, MouseEventArgs e)
        {
            FormHolerite formHolerite = new FormHolerite();
            handleForm = c_FormShow.setFormShow(FormAtivo, formHolerite, handleForm);

        }
    }
}
