using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_ShowFolhaDetalhada
    {
        C_SearchInDataBase c_SearchInData = new C_SearchInDataBase();

        public void getDataFuncionario(string matricula, FormFolhaDetalhada formFolhaDetalhada)
        {
            
            C_handleCargoSalarioDepartamento c_HandleCargo = new C_handleCargoSalarioDepartamento();
            
            string[] dataFuncionario = c_SearchInData.getDatainTable(matricula);
            string Cargo = c_HandleCargo.getIdCargo(dataFuncionario[15]);
            formFolhaDetalhada.TxtMatricula.Text = dataFuncionario[0];
            formFolhaDetalhada.TxtNome.Text = dataFuncionario[2];
            formFolhaDetalhada.TxtCargo.Text = Cargo;
            c_HandleCargo.getSalario(Cargo, formFolhaDetalhada.TxtSalarioBase);
            formFolhaDetalhada.TxtDataAdmissao.Text = dataFuncionario[13];
        }

        public double calculoINSS(string TxtSalario, FormFolhaDetalhada formFolhaDetalhada)
        {
            List<string[]> Results = c_SearchInData.getListSalariosDescINSS();
            double salario = Convert.ToDouble(TxtSalario);
            double descINSS = 0;
            if (Results.Count > 0)
            {
                
                double Aliquota1 = Convert.ToDouble(Results[0][4]);
                double Aliquota2 = Convert.ToDouble(Results[1][4]);
                double Aliquota3 = Convert.ToDouble(Results[2][4]);
                double Aliquota4 = Convert.ToDouble(Results[3][4]);

                double SalarioMin1 = Convert.ToDouble(Results[0][2]);
                double SalarioMin2 = Convert.ToDouble(Results[1][2]);
                double SalarioMin3 = Convert.ToDouble(Results[2][2]);
                double SalarioMin4 = Convert.ToDouble(Results[3][2]);

                double SalarioMax1 = Convert.ToDouble(Results[0][3]);
                double SalarioMax2 = Convert.ToDouble(Results[1][3]);
                double SalarioMax3 = Convert.ToDouble(Results[2][3]);
                double SalarioMax4 = Convert.ToDouble(Results[3][3]);

                double Aliquota = 0;
                double SalarioLiquido;
                



                // ++++++++++++++++++++++++++++++++++++++++++++++++++++ Variaçoes salariais e suas taxas (INSS)

                if (salario <= SalarioMax1)
                {
                    Aliquota = Aliquota1;
                }
                if (salario > SalarioMax1 && salario <= SalarioMax2) { Aliquota = Aliquota2; }
                if (salario > SalarioMax2 && salario <= SalarioMax3) { Aliquota = Aliquota3; }
                if (salario > SalarioMax3) { Aliquota = Aliquota4; }


                if (Aliquota == 7.5)
                {
                    descINSS = salario * Aliquota / 100;
                    //SalarioLiquido = salario - salario * Aliquota / 100;
                }
                if (Aliquota == 9)
                {
                    descINSS = (salario - SalarioMax1) * Aliquota / 100 + (SalarioMax1 * Aliquota1 / 100);
                }
                if (Aliquota == 12)
                {
                    descINSS = (SalarioMax1 * Aliquota1 / 100) + ((SalarioMax2 - SalarioMax1) * Aliquota2 / 100) + ((salario - SalarioMax2) * Aliquota / 100);
                }
                if (Aliquota == 14 && salario < SalarioMax4)
                {
                    descINSS = (SalarioMax1 * Aliquota1 / 100) + ((SalarioMax2 - SalarioMax1) * Aliquota2 / 100) + ((SalarioMax3 - SalarioMax2) * Aliquota3 / 100) + ((salario - SalarioMax3) * Aliquota / 100);
                }
                if (Aliquota == 14 && salario > SalarioMax4)
                {
                    descINSS = (SalarioMax1 * Aliquota1 / 100) + ((SalarioMax2 - SalarioMax1) * Aliquota2 / 100) + ((SalarioMax3 - SalarioMax2) * Aliquota3 / 100) + ((SalarioMax4 - SalarioMax3) * Aliquota4 / 100);
                }

                formFolhaDetalhada.TxtTaxaDescINSS.Text = Convert.ToDecimal(Aliquota).ToString("N2");
                formFolhaDetalhada.TxtSalarioBaseINSS.Text = TxtSalario;
                formFolhaDetalhada.TxtDescINSS.Text = Convert.ToDecimal(descINSS).ToString("N2");
                formFolhaDetalhada.TxtValorInss.Text = Convert.ToDecimal(descINSS).ToString("N2");
                formFolhaDetalhada.TxtTotalInss.Text = Convert.ToDecimal(descINSS).ToString("N2");
            }
            return descINSS;
        } 
        public double calculoIRRF(string TxtSalario, double DescInss, FormFolhaDetalhada formFolhaDetalhada)
        {

            List<string[]> Results = c_SearchInData.getListSalariosDescIRRF();
            double descIRRF = 0;
            if (Results.Count > 0)
            {
                double salario = Convert.ToDouble(TxtSalario);
                double Aliquota1 = Convert.ToDouble(Results[0][4]);
                double Aliquota2 = Convert.ToDouble(Results[1][4]);
                double Aliquota3 = Convert.ToDouble(Results[2][4]);
                double Aliquota4 = Convert.ToDouble(Results[3][4]);
                double Aliquota5 = Convert.ToDouble(Results[4][4]);

                double SalarioMin1 = Convert.ToDouble(Results[0][2]);
                double SalarioMin2 = Convert.ToDouble(Results[1][2]);
                double SalarioMin3 = Convert.ToDouble(Results[2][2]);
                double SalarioMin4 = Convert.ToDouble(Results[3][2]);
                double SalarioMin5 = Convert.ToDouble(Results[4][2]);

                double SalarioMax1 = Convert.ToDouble(Results[0][3]);
                double SalarioMax2 = Convert.ToDouble(Results[1][3]);
                double SalarioMax3 = Convert.ToDouble(Results[2][3]);
                double SalarioMax4 = Convert.ToDouble(Results[3][3]);
                double SalarioMax5 = Convert.ToDouble(Results[4][3]);

                double deducao1 = 0;      //HardCode
                double deducao2 = 142.80;
                double deducao3 = 354.80;
                double deducao4 = 636.13;
                double deducao5 = 869.36;

                // ++++++++++++++++++++++++++++++++++++++++++++++++++++ Variaçoes salariais e suas taxas (IRRF)

                double Aliquota = 0;
                
                salario = salario - DescInss; //Salario - Imposto do INSS

                if (salario <= SalarioMax1) { Aliquota = Aliquota1; }
                if (salario > SalarioMax1 && salario <= SalarioMax2) { Aliquota = Aliquota2; }
                if (salario > SalarioMax2 && salario <= SalarioMax3) { Aliquota = Aliquota3; }
                if (salario > SalarioMax3 && salario <= SalarioMax4) { Aliquota = Aliquota4; }
                if (salario > SalarioMax5) { Aliquota = Aliquota5; }



                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                if (Aliquota == 7.5)
                {
                    descIRRF = (salario * Aliquota / 100) - deducao2;
                }
                if (Aliquota == 15)
                {
                    descIRRF = (salario * Aliquota / 100) - deducao3;
                }
                if (Aliquota == 22.5)
                {
                    descIRRF = (salario * Aliquota / 100) - deducao4;
                }
                if (Aliquota == 27.5)
                {
                    descIRRF = (salario * Aliquota / 100) - deducao5;
                }
                formFolhaDetalhada.TxtTaxaDescIRRF.Text = Convert.ToDecimal(Aliquota).ToString("N2");
                formFolhaDetalhada.TxtDescIRRF.Text = Convert.ToDecimal(descIRRF).ToString("N2");
                formFolhaDetalhada.TxtSalarioBaseIRRF.Text = Convert.ToDecimal(salario).ToString("N2");
                formFolhaDetalhada.TxtValorIRRF.Text = Convert.ToDecimal(descIRRF).ToString("N2");
                formFolhaDetalhada.TxtTotalIRRF.Text = Convert.ToDecimal(descIRRF).ToString("N2");
            }
            return descIRRF;
        }
        public double calculoFGTS(string Txtsalario, FormFolhaDetalhada formFolhaDetalhada)
        {
            
            double salario = Convert.ToDouble(Txtsalario);
            double descFGTS = 0;
            List<string[]> Results = c_SearchInData.getListValorFGTS();

            if (Results.Count > 0)
            {
                double Aliquota = Convert.ToDouble(Results[0][1]);
                descFGTS = salario * Aliquota / 100;
                formFolhaDetalhada.TxtSalarioBaseFGTS.Text = Txtsalario;
                formFolhaDetalhada.TxtValorFGTS.Text = Convert.ToDecimal(descFGTS).ToString("N2");
                formFolhaDetalhada.TxtTotalFGTS.Text = Convert.ToDecimal(descFGTS).ToString("N2");
            }
            return descFGTS;
        } 
        public void showResultadosGerais(double descINSS, double descIRRF, string Txtsalario, FormFolhaDetalhada formFolhaDetalhada)
        {
            if(Txtsalario != "" || Txtsalario.Length > 0)
            {
                double salario = Convert.ToDouble(Txtsalario);

                double descTotais = descINSS + descIRRF;
                double salarioLiquido = salario - descTotais;
                DateTime dateTime = DateTime.Today;
                formFolhaDetalhada.TxtMaiorRemuneracao.Text = Txtsalario;
                formFolhaDetalhada.TxtSalarioLiqMensal.Text = Convert.ToDecimal(salarioLiquido).ToString("N2");
                formFolhaDetalhada.TxtVencimentos.Text = Txtsalario;
                formFolhaDetalhada.TxtTotaisDescontos.Text = Convert.ToDecimal(descTotais).ToString("N2");
                formFolhaDetalhada.TxtSalarioLiquido.Text = Convert.ToDecimal(salarioLiquido).ToString("N2");
                formFolhaDetalhada.TxtDataEmissao.Text = dateTime.ToString();
            }
            
        }
    }
}
