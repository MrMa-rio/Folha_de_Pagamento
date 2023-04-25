using FOLHA_DE_PAGAMENTO_.src.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_InsertData
    {
        private string IP = "localhost";
        private string User = "root";
        private string Password = "";
        private string TargetDB = "bd";

        public string setDatainTableFuncionario(string table, string columnsTable, string values, string CPF)  //Ex: Table: TbFuncionarios, columnstable: (Nome,CPF...), values: (Mario, 42564537,...)
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string insertSql = $"INSERT INTO {table} ({columnsTable}) VALUES ({values})";
            string matriculaSql = $"SELECT Matricula FROM Funcionario WHERE CPF = '{CPF}'";
            string matriculaFuncionario = "0";
            MySqlConnection conexão;
            conexão = new MySqlConnection();
            try
            {
                conexão.ConnectionString = endereco;
                MySqlCommand commandInsert = new MySqlCommand(insertSql, conexão);
                conexão.Open();
                commandInsert.ExecuteReader();
                conexão.Close();
                commandInsert = new MySqlCommand(matriculaSql, conexão);
                conexão.Open();
                MySqlDataReader mySqlDataReader = commandInsert.ExecuteReader();

                if (!mySqlDataReader.HasRows)
                {
                    MessageBox.Show("Nenhum Cadastro encontrado.");
                }
                else
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.HasRows)
                        {
                            matriculaFuncionario = mySqlDataReader.GetString(0);
                            
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n Algo de Errado Na conexão ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexão.Close();
                
            }
            return matriculaFuncionario;
        }

        public void setDataEndereco(string table, string columnsTable, string values)
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string insertSql = $"INSERT INTO {table} ({columnsTable}) VALUES ({values})";

            MySqlConnection conexão = new MySqlConnection();;

            try
            {
                conexão.ConnectionString = endereco;
                MySqlCommand commandInsert = new MySqlCommand(insertSql, conexão);
                conexão.Open();
                commandInsert.ExecuteReader();
                conexão.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n Algo de Errado Na conexão ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexão.Close();

            }
        }

        /*
            dataFuncionario[0] = TxtNomeCompleto
            dataFuncionario[1] = TxtDataNascimento
            dataFuncionario[2] = TxtNit
            dataFuncionario[3] = TxtPis
            dataFuncionario[4] = TxtTituloEleitor
            dataFuncionario[5] = CbDepartamento
            dataFuncionario[6] = IdCargo
            dataFuncionario[7] = DataAdmissao
            dataFuncionario[8] = TxtReservista
            dataFuncionario[9] = ValidadorCPF
            dataFuncionario[10] = CbEstadoCivil
            dataFuncionario[11] = CbGenero
            dataFuncionario[12] = TxtCpf
            dataFuncionario[13] = TxtRg
            dataFuncionario[14] = CbCargo

            dataAdicional[0] = TxtRua
            dataAdicional[1] = TxtNumRua
            dataAdicional[2] = TxtBairro 
            dataAdicional[3] = TxtComplemento
            dataAdicional[4] = CbUF
            dataAdicional[5] = TxtCidade
            dataAdicional[6] = TxtCep
         */

        public void setDatainDB(string[] dataFuncionario, string[] dataAdicional)
        {
            string[] result = new string[] { dataFuncionario[12], dataFuncionario[0], dataFuncionario[1], dataFuncionario[11], dataFuncionario[13], dataFuncionario[2], dataFuncionario[3], dataFuncionario[4], dataFuncionario[10], dataFuncionario[14], dataFuncionario[6], dataFuncionario[7] };

            if (dataFuncionario[0].Length < 4 || dataFuncionario[9] == "false" || dataFuncionario[10] == "" || dataFuncionario[11] == "" || dataFuncionario[13].Length < 9 || dataFuncionario[2] == "" || dataFuncionario[3] == "" || dataFuncionario[5] == "0" || dataFuncionario[6] == "0" || dataFuncionario[7].Length < 8)
            {
                MessageBox.Show("Preencha os campos do Cadastro Pessoais.");
            }

            else if (dataAdicional[0].Length < 2 || dataAdicional[1] == "0" || dataAdicional[2].Length < 2 || dataAdicional[4].Length == 0 || dataAdicional[5].Length == 0 || dataAdicional[6].Length < 8)
            {
                MessageBox.Show("Preencha os campos do Cadastro Adicional.");
            }
            else
            {
                DialogResult alertBox = MessageBox.Show("Você está preste á salvar esses DADOS!", "Salvar Dados", MessageBoxButtons.OKCancel);

                if (alertBox == DialogResult.OK)
                {
                    string fillColumnsFuncionario = "CPF, " +
                                                    "Nome, " +
                                                    "DATA_Nascimento, " +
                                                    "Sexo, RG, NIT, PIS, " +
                                                    "Titulo_Eleitor, " +
                                                    "Estado_Civel, " +
                                                    "Reservista, " +
                                                    "Senha, " +
                                                    "Data_Admissao, " +
                                                    "FK_Departamento, " +
                                                    "FK_Cargo, " +
                                                    "FK_Empresa";

                    string fillColumnsAdicionais = "FK_Matricula," +
                                                    " Rua, Numero, Cep," +
                                                    " Complemento, UF," +
                                                    " Bairro, Cidade";

                    string valuesCadPessoal = $"'{dataFuncionario[12]}','{dataFuncionario[0]}','{dataFuncionario[1]}','{dataFuncionario[11]}','{dataFuncionario[13]}','{dataFuncionario[2]}','{dataFuncionario[3]}','{dataFuncionario[4]}','{dataFuncionario[10]}','{dataFuncionario[8]}','123456', '{dataFuncionario[7]}',{dataFuncionario[5]}, {dataFuncionario[6]}, 1 ";
                    string matriculaFuncionario = setDatainTableFuncionario("funcionario", fillColumnsFuncionario, valuesCadPessoal, dataFuncionario[12]);
                    string valuesCadAdicionais = $"'{matriculaFuncionario}', '{dataAdicional[0]}', '{dataAdicional[1]}', '{dataAdicional[6]}', '{dataAdicional[3]}', '{dataAdicional[4]}', '{dataAdicional[2]}', '{dataAdicional[5]}'";

                    if (matriculaFuncionario != "0")
                    {
                        setDataEndereco("endereço", fillColumnsAdicionais, valuesCadAdicionais);
                        MessageBox.Show("Cadastro realizado com Sucesso!!");
                        FormShowDadosCadastrais formShowDadosCadastrais = new FormShowDadosCadastrais(result, matriculaFuncionario); //arrumar no demostrativo de cadastro
                        formShowDadosCadastrais.ShowDialog();
                    }
                }
            }
        }
    }
} 
/*
    TODO:
    + Criar uma nova conexao com o banco para guardar as informações adicionais do usuario
    + Corrigir bug do box calendario no Form Alterar Cadastro
    + Alterar layout do Form Alterar Cadastro.
            
*/
/*

    Corrigir os parametros dos metodos do SQL para comportar as novas alterações
    Fazer as devidas alterações no Forms Alterar Cadastro.
    Fazer as alterações em cada instancia dos metodos.

 */