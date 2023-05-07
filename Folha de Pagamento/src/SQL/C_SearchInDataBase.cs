using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_SearchInDataBase
    {
        private string IP = "localhost";
        private string User = "root";
        private string Password = "";
        private string TargetDB = "bd_folha";

        //private readonly string IP = "dbfolha.mysql.database.azure.com";
        //private readonly string User = "Sistema";
        //private readonly string Password = "Senha@db123";
        //private readonly string TargetDB = "bd_folha";

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

        public List<string[]> getDataFuncionario(string matricula)
        {
            string insertSql = $"select * from tb_funcionario where Matricula = {matricula}";
            return getListinDB(insertSql);
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

        public List<string[]> getListDate(string matricula)
        {
            string insertSql = $"Select DATA_Emite from tb_fechamento where FK_Matricula = {matricula}";
            return getListinDB(insertSql);
        }
        public List<string[]> getListMonth(string matricula, string year)
        {
            string insertSql = $"Select DATA_Emite from tb_fechamento where DATA_Emite LIKE '%{year}%' AND FK_Matricula = {matricula}";
            return getListinDB(insertSql);
        }

        public List<string[]> getListDate()
        {
            string insertSql = $"Select DATA_Emite from tb_fechamento";
            return getListinDB(insertSql); //retorna a coluna data
        }

        public List<string[]> getListMonth(string year)
        {
            string insertSql = $"Select DATA_Emite from tb_fechamento where DATA_Emite LIKE '%{year}%' ";
            return getListinDB(insertSql); //retorna coluna data atraves do parametro ano
        }
        public List<string[]> getRowMajor(string year, string month, string matricula)
        {
            string insertSql = $"Select * from tb_fechamento  where DATA_Emite LIKE '%{year}-{month}%' AND FK_Matricula = {matricula} ORDER BY ID_Holerite DESC LIMIT 1";
            return getListinDB(insertSql);
        }
        public List<string[]> getListFechamento(string matricula, string year, string month)
        {
            string insertSql = $"Select * from tb_fechamento where DATA_Emite LIKE '%{year}-{month}%' AND  FK_Matricula = {matricula}";
            return getListinDB(insertSql); // dados folha do ano tal e mes tal...
        }

        public List<string[]> getTaxaINSS(string idINSS)
        {
            string insertSql = $"Select Taxa_Desconto from tb_inss where ID_INSS = {idINSS}";
            return getListinDB(insertSql); // retorna a taxa atraves do ID
        }
        public List<string[]> getTaxaIRRF(string idIRRF)
        {
            string insertSql = $"Select Taxa_Desconto from tb_irf where ID_IRF = {idIRRF}";
            return getListinDB(insertSql); // retorna a taxa atraves do ID
        }
        public List<string[]> getTaxaFGTS(string idFGTS)
        {
            string insertSql = $"Select Valor_FGTS from tb_fgts where ID_FGTS = {idFGTS}";
            return getListinDB(insertSql); // retorna a taxa atraves do ID
        }
    }
}
//Select DATA_Emite from tb_fechamento where DATA_Emite LIKE '%2023%' AND FK_Matricula = 19; // Retorna dados com base na matricula e no ano
//Select DATA_Emite from tb_fechamento where FK_Matricula = 19; // Retorna dados com base na matricula
//Select * from tb_fechamento where DATA_Emite LIKE '%2023-05%' AND  FK_Matricula = 19; Retorna dados com base no mes, ano e matricula


/*
 * Refereciando atraves de chaves estrangeiras
 
    SELECT departamento.*, tbfuncionarios.CPF AS departamento_cpf
    FROM tbfuncionarios
    INNER JOIN departamento ON tbfuncionarios.MatriculaFuncionario = departamento.departamento_id
    WHERE departamento.departamento_id = 16;

*/

//select DATA_Emite from tb_fechamento where FK_Matricula = 19;