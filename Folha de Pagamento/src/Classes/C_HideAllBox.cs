using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_HideAllBox
    {
        public void hideAll(Panel Paneltarget)
        {
            foreach (Control controle in Paneltarget.Controls)
            {
                if (controle is TextBox) // verifica se o controle é um TextBox
                {
                    ((TextBox)controle).Enabled = false;
                }
                if(controle is ComboBox)
                {
                    ((ComboBox)controle).Enabled = false;
                }
                if (controle is MaskedTextBox)
                {
                    ((MaskedTextBox)controle).Enabled = false;
                }
                if(controle is NumericUpDown)
                {
                    ((NumericUpDown)controle).Enabled = false;
                }
                if (controle is Button)
                {
                    ((Button)controle).Enabled = false;
                }
            }
        }
    }
}
