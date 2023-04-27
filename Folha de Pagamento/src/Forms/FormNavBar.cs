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
        C_FormNavBarShow c_FormNavBarShow = new C_FormNavBarShow();

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
            handleForm = c_FormShow.setFormShow(FormAtivo, formCadastro, handleForm);
            c_FormNavBarShow.AnimationHide(this, Pnl2);
        }

        private void BtnAlterarCadastro_MouseClick(object sender, MouseEventArgs e)
        {

            FormAlterarCadastro formAlterarCadastro = new FormAlterarCadastro(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formAlterarCadastro, handleForm);
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
            handleForm = c_FormShow.setFormShow(FormAtivo, formCargosFun, handleForm);
            c_FormNavBarShow.AnimationHide(this, Pnl2);


        }
        private void BtnPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            FormPesquisar formPesquisar = new FormPesquisar(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formPesquisar, handleForm);
            c_FormNavBarShow.AnimationHide(this, Pnl2);

        }

        private void BtnCalculoPagamento_MouseClick(object sender, MouseEventArgs e)
        {
            FormCalculoPagamento formCalculoPagamento = new FormCalculoPagamento(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formCalculoPagamento, handleForm);
            c_FormNavBarShow.AnimationHide(this, Pnl2);


        }
        private void BtnFolhaPNormal_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaNormal formFolhaNormal = new FormFolhaNormal(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formFolhaNormal, handleForm);
            c_FormNavBarShow.AnimationHide(this, Pnl2);


        }
        private void BtnFolhaPDetalhada_MouseClick(object sender, MouseEventArgs e)
        {
            FormFolhaDetalhada formFolhaDetalhada = new FormFolhaDetalhada(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formFolhaDetalhada, handleForm);
            c_FormNavBarShow.AnimationHide(this, Pnl2);


        }
        private void BtnHolerite_MouseClick(object sender, MouseEventArgs e)
        {
            FormHolerite formHolerite = new FormHolerite(this);
            handleForm = c_FormShow.setFormShow(FormAtivo, formHolerite, handleForm);
            c_FormNavBarShow.AnimationHide(this, Pnl2);


        }
    }
}
