using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormNavBar : Form
    {
        private FormHome FormAtivo;
        private Form handleForm;

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
            this.Hide();
        }

        private void BtnCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            C_FormShow c_FormShow = new C_FormShow();
            FormCadastroFunc formCadastro = new FormCadastroFunc(FormAtivo);
            handleForm = c_FormShow.setFormShow(FormAtivo, formCadastro, handleForm);
        }

        private void BtnAlterarCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            C_FormShow c_FormShow = new C_FormShow();
            FormAlterarCadastro formAlterarCadastro = new FormAlterarCadastro();
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
    }
}
