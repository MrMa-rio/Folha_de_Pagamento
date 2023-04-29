using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_ListaDinamica
    {
        C_SearchInDataBase inDataBase = new C_SearchInDataBase();
        C_FormShow C_FormShow = new C_FormShow();
        public void handleListFuncionario(string coluna, string entrada, FormPesquisar formPesquisar)
        {
            
            List<string[]> strings = new List<string[]>();
            strings = inDataBase.getListFuncionarios(coluna, entrada);
            formPesquisar.PanelPesquisar.Controls.Clear();
           
            foreach (string[] s in strings)
            {
                FormCard formCard = new FormCard(s);
                C_FormShow.setFormCard(formPesquisar, formCard);
            }
        }
    }
}
