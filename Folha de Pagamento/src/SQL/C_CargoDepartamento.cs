using FOLHA_DE_PAGAMENTO_.src.Classes;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_CargoDepartamento
    {
        private readonly string IP = "localhost";
        private readonly string User = "root";
        private readonly string Password = "";
        private readonly string TargetDB = "bd_folha";

        //private readonly string IP = "dbfolha.mysql.database.azure.com";
        //private readonly string User = "Sistema";
        //private readonly string Password = "Senha@db123";
        //private readonly string TargetDB = "bd_folha";

        public List<string[]> getCargosDB()
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string searchCargo = $"SELECT * FROM tb_cargo";

            MySqlConnection conexão;
            conexão = new MySqlConnection();
            conexão.ConnectionString = endereco;
            conexão.Open();

            MySqlCommand command = new MySqlCommand(searchCargo, conexão);
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
                MessageBox.Show("Nenhum Cargo cadastrado");
            }
            finally
            {
                conexão.Close();
            }
            return Result;
        }

        public bool setNovoCargoDB(string cargo, string salario)
        {
            C_TransformandoValores c_TransformandoValores = new C_TransformandoValores();

            salario = c_TransformandoValores.alterandoFormatos(salario);
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";

            string insertCargo = $" INSERT INTO `tb_cargo` (`Nome_Cargo`, `Salario`) VALUES ('{cargo}', '{salario}')";

            MySqlConnection conexão;
            conexão = new MySqlConnection();
            try
            {
                conexão.ConnectionString = endereco;
                MySqlCommand commandInsert = new MySqlCommand(insertCargo, conexão);
                conexão.Open();
                commandInsert.ExecuteReader();
                conexão.Close();
                return true;
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
            return false;
        }
        public bool modificaCargoDB(string TxtCargo,string txtSalario, string idCargo )
        {
            C_TransformandoValores c_TransformandoValores = new C_TransformandoValores();

            txtSalario = c_TransformandoValores.alterandoFormatos(txtSalario);
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string updateSql =  $"UPDATE `tb_cargo` SET `Nome_Cargo` = '{TxtCargo}', `Salario` = '{txtSalario}' WHERE(`ID_Cargo` = '{idCargo}')";

            MySqlConnection conexao = new MySqlConnection();

            try
            {
                conexao.ConnectionString = endereco;
                MySqlCommand command = new MySqlCommand(updateSql, conexao);

                conexao.Open();
                command.ExecuteReader();
                conexao.Close();

                MessageBox.Show("Cargo Alterado com Sucesso!!");
                return true;
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show(ex.Message );
            }
            conexao.Close();
            return false;
        }
    }
}
