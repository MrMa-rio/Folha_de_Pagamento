using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_HideAllForms
    {
        public void setHideForms(Panel panel)
        {
            if (panel != null && panel.Visible)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }
    }
}
