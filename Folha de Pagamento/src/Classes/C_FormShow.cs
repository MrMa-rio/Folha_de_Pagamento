using FOLHA_DE_PAGAMENTO_.src.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_FormShow
    {
        public Form setFormShow(Form ScreenTarget, Form Nav)
        {
            if(ScreenTarget.Controls.Count > 5)
            {
                ScreenTarget.Controls.RemoveAt(ScreenTarget.Controls.Count - 1);
            }
                
            Nav.TopLevel = false;
            ScreenTarget.Controls.Add(Nav);
            Nav.Dock = DockStyle.Fill;
            Nav.Show();
            return Nav;
        }
        public void setFormCard(FormPesquisar formPesquisar, FormCard formCard)
        {
            formCard.TopLevel = false;
            formPesquisar.PanelPesquisar.Controls.Add(formCard);
            formCard.Dock = DockStyle.Top;
            formCard.Show();
        }
        public void refreshForm(Form newForm, Form closeForm)
        {
            Form formPrincipal = Application.OpenForms.OfType<FormHome>().FirstOrDefault();
            closeForm.Close();
            setFormShow(formPrincipal, newForm);

        }
        public void refreshFormWithAlert(Form newForm, Form closeForm)
        {
            DialogResult dialogResult = MessageBox.Show("           Você está prestes a recarregar está página.\n\tAlguns dados poderão ser perdidos.\n\n\t\tTem certeza?", "Atualizar Pagina", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                refreshForm(newForm, closeForm);
            }
        }
    }
}
