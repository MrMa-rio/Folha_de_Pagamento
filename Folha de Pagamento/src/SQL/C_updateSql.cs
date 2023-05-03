using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_updateSql
    {
        //UPDATE `bd`.`funcionario` SET `DATA_Nascimento` = '2005-09-15', `NIT` = '66793261052' WHERE (`Matricula` = '22');
       // TxtCpf.Text, TxtNomeCompleto.Text, TxtCalendario.Text, CbGenero.Text, TxtRg.Text, TxtNit.Text, TxtPis.Text, TxtTituloEleitor.Text, CbEstadoCivil.Text, TxtReservista.Text, TxtDataAdmissao.Text, CbDepartamento.Text, CbCargo.Text, TxtMatricula.Text

        private string IP = "localhost";
        private string User = "root";
        private string Password = "";
        private string TargetDB = "bd_folha";

        public bool setUpdateFuncionario( string[] Data , string[] DataAdicional, string[] DataTelefone, string[] DataEmail)
        {
            
            string endereco = $"server={IP};uid={User};pwd={Password};database={TargetDB}";
            string insertSqlFuncionario = $"UPDATE `tb_funcionario` SET `CPF` = '{Data[0]}', `Nome` = '{Data[1]}', `DATA_Nascimento` = '{Data[2]}', `Sexo` = '{Data[3]}', `RG` = '{Data[4]}', `NIT` = '{Data[6]}', `PIS` = '{Data[7]}', `Titulo_Eleitor` = '{Data[8]}', `Estado_Civil` = '{Data[9]}', `Reservista` = '{Data[10]}', `Senha` = '435455', `Data_Admissao` = '{Data[11]}', `FK_Departamento` = '{Data[12]}', `FK_Cargo` = '{Data[13]}' , `FK_NvlAcesso` = '{Data[15]}', `Carteira_Trabalho` = '{Data[5]}' WHERE (`Matricula` = '{Data[14]}')";
            string insertSqlEndereco = $"UPDATE `tb_endereço` SET `Rua` = '{DataAdicional[0]}', `Numero` = '{DataAdicional[1]}', `Cep` = '{DataAdicional[6]}', `Complemento` = '{DataAdicional[3]}', `UF` = '{DataAdicional[4]}', `Bairro` = '{DataAdicional[2]}', `Cidade` = '{DataAdicional[5]}' WHERE (`FK_Matricula` = '{Data[14]}')";
            string insertSqlTelefone = $"UPDATE `tb_telefone` SET `Telefone` = '{DataTelefone[0]}' WHERE (`FK_Matricula` = '{Data[14]}')";
            string insertSqlEmail = $"UPDATE `tb_email` SET `Email` = '{DataEmail[0]}' WHERE (`FK_Matricula` = '{Data[14]}')";
            MySqlConnection conexao = new MySqlConnection();
            if (Data[16] == "True" && Data[17] == "True")
            {
                try
                {
                    conexao.ConnectionString = endereco;
                    MySqlCommand commandInsertinFuncionario = new MySqlCommand(insertSqlFuncionario, conexao);
                    MySqlCommand commandInsertinEndereco = new MySqlCommand(insertSqlEndereco, conexao);
                    MySqlCommand commandInsertinTelefone = new MySqlCommand(insertSqlTelefone, conexao);
                    MySqlCommand commandInsertinEmail = new MySqlCommand(insertSqlEmail, conexao);

                    conexao.Open();
                    commandInsertinFuncionario.ExecuteReader();
                    conexao.Close();

                    conexao.Open();
                    commandInsertinEndereco.ExecuteReader();
                    conexao.Close();

                    conexao.Open();
                    commandInsertinTelefone.ExecuteReader();
                    conexao.Close();

                    conexao.Open();
                    commandInsertinEmail.ExecuteReader();
                    conexao.Close();

                    MessageBox.Show("Cadastro Alterado com Sucesso!!");
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + "\n Algo de Errado Na conexão ");
                    conexao.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexao.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Erro ao Alterar Cadastro!!\nConfirme as informações Cadastrais!");
                return false;
            }
        }
    }
}

/*
    TODO:
        Fazer a validacao do CPF no alterar cadastro para que o botao salvar 
        faca a alteração somete se os dados estiverem completamente corretos
        
        fazer a linkagem das tabelas para que todas as tabelas sejam alteradas dinamicamente

        fazer as conversoes de data,cargo e departamento para que eles nao retornem 0 para o Banco

        N esquecer de linkar o telefone e o email na tabela!!
        Comecar a planejar o esquema de delete.
        Comecar a planejar o dinamismo do Forms Pesquisar
        Comecar a planejar o servidor das fotos
        Comecar a calcular o imposto de renda

        
 */
