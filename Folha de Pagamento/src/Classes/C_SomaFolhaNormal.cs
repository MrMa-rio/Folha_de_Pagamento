using FOLHA_DE_PAGAMENTO_.src.Forms;
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

        public int AtivosAndClt(string year, string month)
        {
            string insertSql = $"SELECT * FROM bd_folha.tb_fechamento where DATA_Emite LIKE '%{year}-{month}%'";
            return c_SearchInDataBase.getListinDB(insertSql).Count;
        }
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
        public string sumValorTaxaFGTS(string year, string month)
        {
            string insertSql = $"SELECT * FROM bd_folha.tb_fechamento where DATA_Emite LIKE '%{year}-{month}%'";
            string Taxa_FGTS = c_SearchInDataBase.getListinDB("Select Valor_FGTS from tb_fgts")[0][0];
            double result = Convert.ToDouble( c_SearchInDataBase.getListinDB(insertSql).Count ) * Convert.ToDouble( Taxa_FGTS);
            return result.ToString("N2");
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
        public void sumTotal(string year, string month, FormFolhaNormal formFolhaNormal)
        {
            double sumINSS = 0;
            double sumIRRF = 0;

            for (int i = 1; i <= 4; i++)
            {
                sumINSS += sumTaxaINSSId(year, month, $"{i}");
                sumIRRF += sumTaxaIRRFId(year, month, $"{i}");
            }

            formFolhaNormal.TxtTaxaDescINSS.Text =  sumINSS.ToString("N2");
            formFolhaNormal.TxtTaxaDescIRRF.Text = sumIRRF.ToString("N2");
            formFolhaNormal.TxtTaxaDescFGTS.Text = sumValorTaxaFGTS(year, month);
            
            formFolhaNormal.TxtDescINSS.Text = Convert.ToDouble( sumValorDescontoINSS(year, month).ToString()).ToString("N2");
            formFolhaNormal.TxtDescIRRF.Text = Convert.ToDouble(sumValorDescontoIRF(year, month)).ToString("N2") ;
            

            formFolhaNormal.TxtSalarioBaseINSS.Text = Convert.ToDouble(sumSalarioBruto(year, month)).ToString("N2");
            formFolhaNormal.TxtSalarioBaseIRRF.Text = Convert.ToDouble(sumSalarioLiquido(year, month)).ToString("N2");

            formFolhaNormal.TxtValorInss.Text = Convert.ToDouble(sumValorDescontoINSS(year,month)).ToString("N2");
            formFolhaNormal.TxtValorIRRF.Text = Convert.ToDouble(sumValorDescontoIRF(year, month)).ToString("N2");

            formFolhaNormal.TxtTotalInss.Text = Convert.ToDouble(sumValorDescontoINSS(year, month)).ToString("N2");
            formFolhaNormal.TxtTotalIRRF.Text = Convert.ToDouble(sumValorDescontoIRF(year, month)).ToString("N2");

            formFolhaNormal.TxtSalarioBaseFGTS.Text = Convert.ToDouble(sumSalarioBruto(year,month)).ToString("N2");
            formFolhaNormal.TxtValorFGTS.Text = Convert.ToDouble(sumValorDescontoFGTS(year, month)).ToString("N2");
            formFolhaNormal.TxtTotalFGTS.Text = Convert.ToDouble(sumValorDescontoFGTS(year, month)).ToString("N2");

            formFolhaNormal.TxtMaiorRemuneracao.Text = Convert.ToDouble(sumSalarioBruto(year, month)).ToString("N2");
            formFolhaNormal.TxtSalarioLiqMensal.Text = Convert.ToDouble(sumSalarioLiquido(year, month)).ToString("N2");

            formFolhaNormal.TxtSalarioLiquido.Text = Convert.ToDouble(sumSalarioLiquido(year, month)).ToString("N2");
            formFolhaNormal.TxtVencimentos.Text = Convert.ToDouble(sumSalarioBruto(year, month)).ToString("N2");

            formFolhaNormal.TxtTotaisDescontos.Text = (Convert.ToDouble(sumValorDescontoFGTS(year,month)) + Convert.ToDouble(sumValorDescontoIRF(year, month) )).ToString("N2");
            formFolhaNormal.TxtAtivo.Text = AtivosAndClt(year, month).ToString();
            formFolhaNormal.TxtCLT.Text = AtivosAndClt(year, month).ToString();
            
        }
        public void sumTotal(string year, string month, FormFolhaNormalPesq formFolhaNormal)
        {
            double sumINSS = 0;
            double sumIRRF = 0;

            for (int i = 1; i <= 4; i++)
            {
                sumINSS += sumTaxaINSSId(year, month, $"{i}");
                sumIRRF += sumTaxaIRRFId(year, month, $"{i}");
            }

        }

        //SELECT ROUND(SUM(Valor_DescontoFGTS),2) AS total_quantidade FROM tb_fechamento where DATA_Emite LIKE '%2023-05%';
    }
}
