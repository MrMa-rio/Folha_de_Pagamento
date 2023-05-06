using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_SomaFolhaNormal
    {
        C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();

        public string sumSalarioLiquido(string year, string month)
        {
            string insertSql = $"SELECT ROUND(SUM(Salario_Final),2) AS total_quantidade FROM tb_fechamento where DATA_Emite LIKE '%{year}-{month}%'";
            return c_SearchInDataBase.getListinDB(insertSql)[0][0];
        }
        public string sumValorDescontoINSS(string year, string month)
        {
            string insertSql = $"SELECT ROUND(SUM(Valor_DescontoINSS),2) AS total_quantidade FROM tb_fechamento where DATA_Emite LIKE '%{year}-{month}%'";
            return c_SearchInDataBase.getListinDB(insertSql)[0][0];
        }
        public string sumValorDescontoFGTS(string year, string month)
        {
            string insertSql = $"SELECT ROUND(SUM(Valor_DescontoFGTS),2) AS total_quantidade FROM tb_fechamento where DATA_Emite LIKE '%{year}-{month}%'";
            return c_SearchInDataBase.getListinDB(insertSql)[0][0];
        }
        public string sumValorDescontoIRF(string year, string month)
        {
            string insertSql = $"SELECT ROUND(SUM(Valor_DescontoIRF),2) AS total_quantidade FROM tb_fechamento where DATA_Emite LIKE '%{year}-{month}%'";
            return c_SearchInDataBase.getListinDB(insertSql)[0][0];
        }
        public string sumSalarioBruto(string year, string month)
        {
            string insertSql = $"SELECT ROUND(SUM(Salario_Bruto),2) AS total_quantidade FROM tb_fechamento where DATA_Emite LIKE '%{year}-{month}%'";
            return c_SearchInDataBase.getListinDB(insertSql)[0][0];
        }

        public double sumTaxaIRRFId(string year, string month, string Id) // passa id que retorna o valor de quantos deve multiplicar.
        {
            string insertSql = $"select FK_IRFDesconto from tb_fechamento where DATA_Emite LIKE '%{year}-{month}%' AND FK_IRFDesconto = {Id}";
            int multiplicador = c_SearchInDataBase.getListinDB(insertSql).Count;
            List<string[]> ListTaxaIRRF = c_SearchInDataBase.getTaxaIRRF(Id);
            double resultado = 0;
            
            resultado = Convert.ToDouble(multiplicador) * Convert.ToDouble(ListTaxaIRRF[0][0]);
            return resultado;// retorna a multiplicação da taxa vezes a quantidade de funcionarios que à TEM.
        }
        public double sumTaxaINSSId(string year, string month, string Id)
        {
            string insertSql = $"select FK_INSSDesconto from tb_fechamento where DATA_Emite LIKE '%{year}-{month}%' AND FK_IRFDesconto = {Id}";
            int multiplicador = c_SearchInDataBase.getListinDB(insertSql).Count;
            List<string[]> ListTaxaINSS = c_SearchInDataBase.getTaxaINSS(Id);
            double resultado = 0;
            resultado = Convert.ToDouble(multiplicador) * Convert.ToDouble(ListTaxaINSS[0][0]);
            return resultado;
        }

        public string sumTotal(string year, string month)
        {
            double sumINSS = 0;
            double sumIRRF = 0;

            for(int i = 1; i <= 4; i++)
            {
                sumINSS += sumTaxaINSSId(year, month, $"{i}");
                sumIRRF += sumTaxaIRRFId(year, month, $"{i}");
            }
            MessageBox.Show($"{sumINSS} {sumIRRF}");
            return "sem mundial";
        }
        //SELECT ROUND(SUM(Valor_DescontoFGTS),2) AS total_quantidade FROM tb_fechamento where DATA_Emite LIKE '%2023-05%';
    }
}
