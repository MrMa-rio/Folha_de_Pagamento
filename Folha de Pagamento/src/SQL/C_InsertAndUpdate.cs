using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_InsertAndUpdate
    {
        private string IP = "localhost";
        private string User = "root";
        private string Password = "";
        private string TargetDB = "meudt";

        public void setDatainTable(string table, string columnsTable, string values)  //Ex: Table: TbFuncionarios, columnstable: (Nome,CPF...), values: (Mario, 42564537,...)
        {
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string insertSql = $"INSERT INTO {table} ({columnsTable}) VALUES ({values})";
            MySqlConnection conexão;
            conexão = new MySqlConnection();
            try
            {

                conexão.ConnectionString = endereco;

                MySqlCommand command = new MySqlCommand(insertSql, conexão);

                conexão.Open();
                command.ExecuteReader();
                
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
        public void setDatainTbFuncionarios(TextBox TxtNomeCompleto, bool ValidadorCPF, ComboBox CbEstadoCivil, ComboBox CbGenero, MaskedTextBox TxtCpf, MaskedTextBox TxtRg)
        {
            if (TxtNomeCompleto.Text.Length < 4 || !ValidadorCPF || CbEstadoCivil.Text == "" || CbGenero.Text == "" || TxtRg.Text.Length < 4)
            {
                MessageBox.Show("Preencha os campos do Cadastro.");
            }
            else
            {
                DialogResult alertBox = MessageBox.Show("Você está preste á salvar esses DADOS!", "Salvar Dados", MessageBoxButtons.OKCancel);

                if (alertBox == DialogResult.OK)
                {
                    string fillColumns = "NomeCompleto,CPF,EstadoCivil, Genero, RG";
                    string values = $"'{TxtNomeCompleto.Text}','{TxtCpf.Text}','{CbEstadoCivil.Text}','{CbGenero.Text}','{TxtRg.Text}'";
                    setDatainTable("tbfuncionarios", fillColumns, values);
                }
            }
        }
    }
}
