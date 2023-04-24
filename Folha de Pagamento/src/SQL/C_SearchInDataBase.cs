using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_SearchInDataBase
    {
        private string IP = "bdfolha.mysql.dbaas.com.br";
        private string User = "bdaula";
        private string Password = "Senha@db123";
        private string TargetDB = "bdaula";

        public string[] getDatainTable(string matricula)  //Ex: Table: TbFuncionarios, columnstable: (Nome,CPF...), values: (Mario, 42564537,...)
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string insertSql = $"SELECT * FROM Funcionario where Matricula LIKE {matricula} "; 
            string[] Result = new string[12] ;
            MySqlConnection conexão;
            conexão = new MySqlConnection();
            try
            {
                conexão.ConnectionString = endereco;
                conexão.Open();
                MySqlCommand command = new MySqlCommand(insertSql, conexão);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();

                if(!mySqlDataReader.HasRows)
                {
                    MessageBox.Show("Nenhum Cadastro encontrado.");
                }
                else
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.HasRows)
                        {
                            for(int i = 0; i <= Result.Length-1; i++)
                            {
                                Result[i] = mySqlDataReader.GetString(i);
                            }
                            conexão.Close();
                            return Result;
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
            return Result;
        }
    }
}


/*
 * Refereciando atraves de chaves estrangeiras
 
    SELECT departamento.*, tbfuncionarios.CPF AS departamento_cpf
    FROM tbfuncionarios
    INNER JOIN departamento ON tbfuncionarios.MatriculaFuncionario = departamento.departamento_id
    WHERE departamento.departamento_id = 16;

*/