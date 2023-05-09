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
        C_HideAllBox c_HideAllBox = new C_HideAllBox();
        public bool setShowDataUser(MaskedTextBox TxtCpf, 
                                    TextBox TxtNomeCompleto, 
                                    MaskedTextBox TxtCalendario, 
                                    ComboBox CbGenero, 
                                    MaskedTextBox TxtRg, 
                                    MaskedTextBox TxtCTrabalho,
                                    MaskedTextBox TxtNit, 
                                    MaskedTextBox TxtPis, 
                                    MaskedTextBox TxtTituloEleitor, 
                                    ComboBox CbEstadoCivil, 
                                    MaskedTextBox TxtReservista, 
                                    MaskedTextBox TxtDataAdmissao, 
                                    ComboBox CbDepartamento, 
                                    ComboBox CbCargo, 
                                    MaskedTextBox MatriculaFuncionario,
                                    Button BtnEditar,
                                    Panel PanelTarget,
                                    Button BtnCracha
                                    ) 
        {
            string[] ResultFuncionario;
            
            if(MatriculaFuncionario.Text.Trim().Length > 0)
            {
                c_HideAllBox.hideAll(PanelTarget);
                ResultFuncionario = searchInData.getDatainTable(MatriculaFuncionario.Text);
                if(ResultFuncionario.Length > 0)
                {

                    TxtCpf.Text = ResultFuncionario[1];
                    TxtNomeCompleto.Text = ResultFuncionario[2];
                    TxtCalendario.Text = ResultFuncionario[3];
                    CbGenero.Text = c_HandleDataGener.handleGener( ResultFuncionario[4] );
                    TxtRg.Text = ResultFuncionario[5];
                    TxtCTrabalho.Text = ResultFuncionario[6];
                    TxtNit.Text = ResultFuncionario[7];
                    TxtPis.Text = ResultFuncionario[8];
                    TxtTituloEleitor.Text = ResultFuncionario[9];
                    CbEstadoCivil.Text = ResultFuncionario[10];
                    TxtReservista.Text = ResultFuncionario[11];
                    TxtDataAdmissao.Text = ResultFuncionario[13];
                    CbDepartamento.Text = c_HandleCargoSalario.getIdDepartamento( ResultFuncionario[14] );
                    CbCargo.Text = c_HandleCargoSalario.getIdCargo( ResultFuncionario[15] );
                    BtnEditar.Enabled = true;
                    BtnCracha.Enabled = true;

                    if(TxtCpf.Text.Length == 11)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool setShowEndereco(TextBox TxtRua, NumericUpDown TxtRuaNum, TextBox TxtBairro, TextBox TxtComplemento, ComboBox CbUF, TextBox TxtCidade, MaskedTextBox TxtCep, MaskedTextBox MatriculaFuncionario)
        {
            if (MatriculaFuncionario.Text.Trim().Length > 0)
            {
                string[] ResultEndereco;
                ResultEndereco = searchInData.getData(MatriculaFuncionario.Text, "tb_endereço");
                TxtRua.Text = ResultEndereco[2];
                TxtRuaNum.Value = Convert.ToInt32(ResultEndereco[3]);
                TxtCep.Text = ResultEndereco[1];
                TxtComplemento.Text = ResultEndereco[7];
                CbUF.Text = ResultEndereco[6];
                TxtBairro.Text = ResultEndereco[4];
                TxtCidade.Text = ResultEndereco[5];
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
                ResultTelefone = searchInData.getData(MatriculaFuncionario.Text, "tb_telefone");
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
                ResultEmail = searchInData.getData(MatriculaFuncionario.Text, "tb_email");
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
