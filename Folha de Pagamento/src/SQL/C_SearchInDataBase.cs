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
        private string IP = "localhost";
        private string User = "root";
        private string Password = "";
        private string TargetDB = "meudt";

        public string[] getDatainTable(int matricula, string nome)  //Ex: Table: TbFuncionarios, columnstable: (Nome,CPF...), values: (Mario, 42564537,...)
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string insertSql = $"SELECT * FROM tbfuncionarios where NomeCompleto LIKE '%{nome}%' "; //
            
            string[] erro = new string[1];
            MySqlConnection conexão;
            conexão = new MySqlConnection();
            try
            {
                conexão.ConnectionString = endereco;
                conexão.Open();
                MySqlCommand command = new MySqlCommand(insertSql, conexão);

                
                MySqlDataReader mySqlDataReader = command.ExecuteReader();

                while(mySqlDataReader.Read())
                {
                    string[] Result = {
                        mySqlDataReader.GetString(0),
                        
                       
                    };

                    MessageBox.Show("Deu Certoo");
                    conexão.Close();
                    return Result;
                }

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n Algo de Errado Na conexão ");
                return erro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return erro;
            }
            finally
            {
                conexão.Close();
            }
            return erro;
        }
    }
}
