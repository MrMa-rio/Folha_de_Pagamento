using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_
{
    internal class C_FormClose
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
