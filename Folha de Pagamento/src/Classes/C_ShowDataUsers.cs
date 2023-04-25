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
        C_handleCargoSalarioDepartamento c_HandleCargoSalario = new C_handleCargoSalarioDepartamento();
        C_handleDataGener c_HandleDataGener = new C_handleDataGener();
        public bool setShowDataUser(MaskedTextBox TxtCpf, TextBox TxtNomeCompleto, MaskedTextBox TxtCalendario, ComboBox CbGenero, MaskedTextBox TxtRg, MaskedTextBox TxtNit, MaskedTextBox TxtPis, MaskedTextBox TxtTituloEleitor, ComboBox CbEstadoCivil, MaskedTextBox TxtReservista, MaskedTextBox TxtDataAdmissao, ComboBox CbDepartamento, ComboBox CbCargo, MaskedTextBox MatriculaFuncionario) 
        {
            string[] Result;
            C_InvertendoData c_InvertendoData = new C_InvertendoData();
            if(MatriculaFuncionario.Text.Trim().Length > 0)
            {
               
                Result = searchInData.getDatainTable(MatriculaFuncionario.Text);
                 // Fazer a atribuição dos valores para cada paramentro com o array Result;
                TxtCpf.Text = Result[1];
                TxtNomeCompleto.Text = Result[2];
                TxtCalendario.Text = Result[3];
                CbGenero.Text = c_HandleDataGener.handleGener( Result[4] );
                TxtRg.Text = Result[5];
                TxtNit.Text = Result[6];
                TxtPis.Text = Result[7];
                TxtTituloEleitor.Text = Result[8];
                CbEstadoCivil.Text = Result[9];
                TxtReservista.Text = Result[10];
                TxtDataAdmissao.Text = Result[12];
                CbDepartamento.Text = c_HandleCargoSalario.getIdDepartamento( Result[13] );
                CbCargo.Text = c_HandleCargoSalario.getIdCargo( Result[14] );
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
