using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_eraseBoxes
    {
        public void eraseTextBox(Panel PanelAdminCargos)
        {
            DialogResult dialogResult = MessageBox.Show("Você está preste à LIMPAR todos os campos! ", "Limpar Campos", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                foreach (Control controle in PanelAdminCargos.Controls)
                {
                    if (controle is TextBox) // verifica se o controle é um TextBox
                    {
                        ((TextBox)controle).Text = "";
                    }
                }
                eraseCombobox(PanelAdminCargos);
                erasemaskedTextBox(PanelAdminCargos);
            }
        }
        public void erasemaskedTextBox(Panel PanelAdminCargos)
        {
            foreach (Control controle in PanelAdminCargos.Controls)
            {
                if (controle is MaskedTextBox) // verifica se o controle é um TextBox
                {
                    ((MaskedTextBox)controle).Text = ""; 
                }
            }
        }
        public void eraseCombobox(Panel PanelAdminCargos)
        {
            foreach (Control controle in PanelAdminCargos.Controls)
            {
                if (controle is ComboBox) // verifica se o controle é um TextBox
                {
                    ((ComboBox)controle).Text = "";
                }
            }
        }
    }
}
