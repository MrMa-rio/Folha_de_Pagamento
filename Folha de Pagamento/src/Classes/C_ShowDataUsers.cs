using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_ShowDataUsers
    {
        C_SearchInDataBase searchInData = new C_SearchInDataBase();
        public void setShowDataUser(TextBox TxtNomeCompleto, MaskedTextBox TxtCpf, ComboBox CbEstadoCivil, ComboBox CbGenero, MaskedTextBox TxtRg, TextBox MatriculaFuncionario) 
        {
            string[] Result;
            Result = searchInData.getDatainTable(MatriculaFuncionario.Text);
            TxtNomeCompleto.Text = Result[1]; // Fazer a atribuição dos valores para cada paramentro com o array Result;
            TxtCpf.Text = Result[2];
            CbEstadoCivil.Text = Result[3];
            CbGenero.Text = Result[4];
            TxtRg.Text = Result[5];
        }
    }
}
