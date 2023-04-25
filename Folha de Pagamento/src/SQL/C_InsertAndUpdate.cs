using FOLHA_DE_PAGAMENTO_.src.Forms;
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
        private string TargetDB = "bd";

        public void setDatainTable(string table, string columnsTable, string values, string[] result)  //Ex: Table: TbFuncionarios, columnstable: (Nome,CPF...), values: (Mario, 42564537,...)
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
                MessageBox.Show("Cadastro realizado com Sucesso!!");
                FormShowDadosCadastrais formShowDadosCadastrais = new FormShowDadosCadastrais(result); //arrumar no demostrativo de cadastro
                formShowDadosCadastrais.ShowDialog();
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
        public void setDatainTbFuncionarios(TextBox TxtNomeCompleto,
                                            string TxtDataNascimento,
                                            MaskedTextBox TxtNit,
                                            MaskedTextBox TxtPis,
                                            MaskedTextBox TxtTituloEleitor,
                                            string CbDepartamento,
                                            string IdCargo,
                                            string DataAdmissao,
                                            MaskedTextBox TxtReservista,
                                            bool ValidadorCPF,
                                            ComboBox CbEstadoCivil,
                                            ComboBox CbGenero,
                                            MaskedTextBox TxtCpf,
                                            MaskedTextBox TxtRg,
                                            ComboBox CbCargo)

        {
            string[] result = new string[] {TxtCpf.Text, TxtNomeCompleto.Text, TxtDataNascimento, CbGenero.Text, TxtRg.Text, TxtNit.Text, TxtPis.Text, TxtTituloEleitor.Text, CbEstadoCivil.Text,CbCargo.Text, IdCargo, DataAdmissao };

            if (TxtNomeCompleto.Text.Length < 4 || !ValidadorCPF || CbEstadoCivil.Text == "" || CbGenero.Text == "" || TxtRg.Text.Length < 9 || TxtNit.Text == "" || TxtPis.Text == "" || CbDepartamento == "0" || IdCargo == "0")
            {
                MessageBox.Show("Preencha os campos do Cadastro.");
            }
            else
            {
                DialogResult alertBox = MessageBox.Show("Você está preste á salvar esses DADOS!", "Salvar Dados", MessageBoxButtons.OKCancel);

                if (alertBox == DialogResult.OK)
                {
                    string fillColumns = "CPF, Nome, DATA_Nascimento, Sexo, RG, NIT, PIS, Titulo_Eleitor, Estado_Civel, Reservista, Senha, Data_Admissao, FK_Departamento, FK_Cargo, FK_Empresa";
                    string values = $"'{TxtCpf.Text}','{TxtNomeCompleto.Text}','{TxtDataNascimento}','{CbGenero.Text}','{TxtRg.Text}','{TxtNit.Text}','{TxtPis.Text}','{TxtTituloEleitor.Text}','{CbEstadoCivil.Text}','{TxtReservista.Text}','123456', '{DataAdmissao}',{CbDepartamento}, {IdCargo}, 1 "; //hardcode
                    setDatainTable("funcionario", fillColumns, values, result);   //hardcode

                }
            }
        }
    }
}

/*

    Corrigir os parametros dos metodos do SQL para comportar as novas alterações
    Fazer as devidas alterações no Forms Alterar Cadastro.
    Fazer as alterações em cada instancia dos metodos.

 */

/*
        
    Comecar a pensar em como ira editar os dados vindo no Alterar
    Cadastro.

 */