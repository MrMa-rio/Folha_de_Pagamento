using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FOLHA_DE_PAGAMENTO_.src.SQL
{
    internal class C_Verificalogin
    {
        private string IP = "localhost";
        private string User = "root";
        private string Password = "";
        private string TargetDB = "bd_folha";

        //private readonly string IP = "dbfolha.mysql.database.azure.com";
        //private readonly string User = "Sistema";
        //private readonly string Password = "Senha@db123";
        //private readonly string TargetDB = "bd_folha";
        public List<string[]> setLogin(string user, string password)
        {
            List<string[]> Results = new List<string[]>();
            if (user.Trim().Length > 0)
            {
                string getSql = $"SELECT Matricula, Nome, FK_Departamento, FK_Cargo, FK_NvlAcesso, Status FROM tb_funcionario WHERE Matricula = '{user}' AND senha = '{password}' AND Status = 'Ativo'";
                
                C_SearchInDataBase c_SearchInData = new C_SearchInDataBase();
                Results = c_SearchInData.getListinDB(getSql);
                if(Results.Count == 1 )
                {
                    MessageBox.Show("Login efetuado com Sucesso!");
                    return Results;
                }
                else
                {
                    MessageBox.Show("Nenhum Login encontrado ou Senha Inválida!");
                    return Results;
                }
            }
            else
            {
                return Results;
            }
        }
    }
}

//SELECT * FROM bd_folha.tb_funcionario where Status = "Ativo" AND Nome LIKE '%ma%';  //confirmar pessoa ativa