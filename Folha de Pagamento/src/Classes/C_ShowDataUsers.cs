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
        public bool setShowDataUser(MaskedTextBox TxtCpf, 
                                    TextBox TxtNomeCompleto, 
                                    MaskedTextBox TxtCalendario, 
                                    ComboBox CbGenero, 
                                    MaskedTextBox TxtRg, 
                                    MaskedTextBox TxtNit, 
                                    MaskedTextBox TxtPis, 
                                    MaskedTextBox TxtTituloEleitor, 
                                    ComboBox CbEstadoCivil, 
                                    MaskedTextBox TxtReservista, 
                                    MaskedTextBox TxtDataAdmissao, 
                                    ComboBox CbDepartamento, 
                                    ComboBox CbCargo, 
                                    MaskedTextBox MatriculaFuncionario) 
        {
            string[] ResultFuncionario;
            
            if(MatriculaFuncionario.Text.Trim().Length > 0)
            {
               
                ResultFuncionario = searchInData.getDatainTable(MatriculaFuncionario.Text);
                TxtCpf.Text = ResultFuncionario[1];
                TxtNomeCompleto.Text = ResultFuncionario[2];
                TxtCalendario.Text = ResultFuncionario[3];
                CbGenero.Text = c_HandleDataGener.handleGener( ResultFuncionario[4] );
                TxtRg.Text = ResultFuncionario[5];
                TxtNit.Text = ResultFuncionario[6];
                TxtPis.Text = ResultFuncionario[7];
                TxtTituloEleitor.Text = ResultFuncionario[8];
                CbEstadoCivil.Text = ResultFuncionario[9];
                TxtReservista.Text = ResultFuncionario[10];
                TxtDataAdmissao.Text = ResultFuncionario[12];
                CbDepartamento.Text = c_HandleCargoSalario.getIdDepartamento( ResultFuncionario[13] );
                CbCargo.Text = c_HandleCargoSalario.getIdCargo( ResultFuncionario[14] );

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setShowEndereco(TextBox TxtRua, NumericUpDown TxtRuaNum, TextBox TxtBairro, TextBox TxtComplemento, ComboBox CbUF, TextBox TxtCidade, MaskedTextBox TxtCep, MaskedTextBox MatriculaFuncionario)
        {
            if (MatriculaFuncionario.Text.Trim().Length > 0)
            {
                string[] ResultEndereco;
                ResultEndereco = searchInData.getData(MatriculaFuncionario.Text, "endereço");
                TxtRua.Text = ResultEndereco[1];
                TxtRuaNum.Value = Convert.ToInt32(ResultEndereco[2]);
                TxtCep.Text = ResultEndereco[3];
                TxtComplemento.Text = ResultEndereco[4];
                CbUF.Text = ResultEndereco[5];
                TxtBairro.Text = ResultEndereco[6];
                TxtCidade.Text = ResultEndereco[7];
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setShowTelefone(MaskedTextBox Telefone, MaskedTextBox MatriculaFuncionario)
        {
            
            if (MatriculaFuncionario.Text.Trim().Length > 0)
            {
                string[] ResultTelefone;
                ResultTelefone = searchInData.getData(MatriculaFuncionario.Text, "telefone");
                Telefone.Text = ResultTelefone[1];

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool setShowEmail(TextBox Email, MaskedTextBox MatriculaFuncionario)
        {


            if (MatriculaFuncionario.Text.Trim().Length > 0)
            {
                string[] ResultEmail;
                ResultEmail = searchInData.getData(MatriculaFuncionario.Text, "email");
                Email.Text = ResultEmail[1];

                return true;
            }
            else
            {
                return false;
            }
        }


        public bool VerificaDadosFuncionario(string[] dataFuncionario)
        {
            if (dataFuncionario[0].Length < 4 || dataFuncionario[9] == "false" || dataFuncionario[10] == "" || dataFuncionario[11] == "" || dataFuncionario[13].Length < 9 || dataFuncionario[2] == "" || dataFuncionario[3] == "" || dataFuncionario[5] == "0" || dataFuncionario[6] == "0" || dataFuncionario[7].Length < 8)
            {
                MessageBox.Show("Preencha os campos do Cadastro Pessoais.");
                return false;
            }
            else{ return true; }
        }
        public bool VerificaDadosAdicionais(string[] dataAdicional)
        {
            if (dataAdicional[0].Length < 2 || dataAdicional[1] == "0" || dataAdicional[2].Length < 2 || dataAdicional[4].Length == 0 || dataAdicional[5].Length == 0 || dataAdicional[6].Length < 8)
            {
                MessageBox.Show("Preencha os campos do Cadastro Adicional.");
                return false;
            }
            else { return true; }
        }
    }
}
