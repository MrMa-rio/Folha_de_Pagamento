using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamento
{
    internal class FormClose
    {
        public void setFormClose(Form FrmAtivo, Form form)
        {
            if (form != null)
            {
                FrmAtivo.Controls.Remove(form);
            }
        }
    }
}
