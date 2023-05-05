using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_SearchInDataBase
    {
        private string IP = "localhost";
        private string User = "root";
        private string Password = "";
        private string TargetDB = "bd_folha";

        //private readonly string IP = "dbfolha.mysql.database.azure.com";
        //private readonly string User = "administrador";
        //private readonly string Password = "Senha@bd123";
        //private readonly string TargetDB = "bd_folha";
        //private readonly string SSL_mode = "require";

        //string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
        //string insertSql = $"SELECT * FROM {Table} where FK_Matricula LIKE {Matricula} ";

        public string[] getDatainTable(string matricula)  //Ex: Table: TbFuncionarios, columnstable: (Nome,CPF...), values: (Mario, 42564537,...)
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB};";
            string searchDataFuncionario = $"SELECT * FROM tb_funcionario where Matricula LIKE {matricula} ";

            MySqlConnection conexão;
            conexão = new MySqlConnection();
            conexão.ConnectionString = endereco;
            conexão.Open();
            MySqlCommand command = new MySqlCommand(searchDataFuncionario, conexão);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            string[] Result = new string[mySqlDataReader.FieldCount];
            try
            {

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
                            for (int i = 0; i < mySqlDataReader.FieldCount - 1; i++)
                            {
                                Result[i] = mySqlDataReader.GetString(i);

                            }
                            conexão.Close();
                            return Result; //Retorna as informaçoes de apenas um funcionario.
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
                MessageBox.Show("Nenhum usuario cadastrado");
            }
            finally
            {
                conexão.Close();
            }
            return Result;
        }


        public string[] getData(string Matricula, string Table)
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string insertSql = $"SELECT * FROM {Table} where FK_Matricula LIKE {Matricula} ";

            MySqlConnection conexão;
            conexão = new MySqlConnection();
            conexão.ConnectionString = endereco;
            conexão.Open();
            MySqlCommand command = new MySqlCommand(insertSql, conexão);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            string[] Result = new string[mySqlDataReader.FieldCount];

            try
            {
                if (!mySqlDataReader.HasRows)
                {

                    return Result;

                }
                else
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.HasRows)
                        {
                            for (int i = 0; i < Result.Length; i++)
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
        public List<string[]> getListFuncionarios(string coluna, string entrada)
        {
            string insertSql = $"select * from tb_funcionario where {coluna} LIKE '%{entrada}%'";
            return getListinDB(insertSql);
        }

        public List<string[]> getListinDB(string insertSql)
        {
            
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            MySqlConnection conexão;
            conexão = new MySqlConnection();
            conexão.ConnectionString = endereco;
            conexão.Open();
            MySqlCommand command = new MySqlCommand(insertSql, conexão);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            List<string[]> Result = new List<string[]>();
            try
            {
                if (!mySqlDataReader.HasRows)
                {
                    return Result;
                }
                else
                {
                    while (mySqlDataReader.Read())
                    {
                        string[] row = new string[mySqlDataReader.FieldCount];
                        if (mySqlDataReader.HasRows)
                        {
                            for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                            {
                                row[i] = mySqlDataReader.GetString(i);
                            }
                        }
                        Result.Add(row);
                    }
                    conexão.Close();
                    return Result;
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
        public List<string[]> getListSalariosDescINSS()
        {
            string insertSql = $"SELECT * FROM tb_inss;";
            return getListinDB(insertSql);
        }
        public List<string[]> getListSalariosDescIRRF()
        {
            string insertSql = $"SELECT * FROM tb_irf";
            return getListinDB(insertSql);
        }
        public List<string[]> getListValorFGTS()
        {
            string insertSql = $"SELECT * FROM tb_fgts";
            return getListinDB(insertSql);
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

//select DATA_Emite from tb_fechamento where FK_Matricula = 19;