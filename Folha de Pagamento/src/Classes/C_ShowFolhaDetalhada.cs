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
            double descINSS = 0;

          // ++++++++++++++++++++++++++++++++++++++++++++++++++++ Variaçoes salariais e suas taxas (INSS)
            
            if(salario <= SalarioMax1)
            {
                Aliquota = Aliquota1;
            }
            if(salario > SalarioMax1 && salario <= SalarioMax2 ) { Aliquota = Aliquota2; }
            if(salario > SalarioMax2 && salario <= SalarioMax3) { Aliquota = Aliquota3; }
            if( salario > SalarioMax3 ) {  Aliquota = Aliquota4; }
            
            
            if(Aliquota == 7.5)
            {
                descINSS = salario * Aliquota / 100;
                //SalarioLiquido = salario - salario * Aliquota / 100;
            }
            if (Aliquota == 9)
            {
                descINSS = ( salario - SalarioMax1 ) * Aliquota / 100 + (SalarioMax1 * Aliquota1 / 100);
            }
            if(Aliquota == 12) 
            {
                descINSS = (SalarioMax1 * Aliquota1 / 100) + ((SalarioMax2 - SalarioMax1) * Aliquota2 / 100) + ((salario - SalarioMax2) * Aliquota / 100);
            }
            if(Aliquota == 14 && salario < SalarioMax4)
            {
                descINSS = (SalarioMax1 * Aliquota1 / 100) + ((SalarioMax2 - SalarioMax1) * Aliquota2 / 100) + ((SalarioMax3 - SalarioMax2) * Aliquota3 / 100) + ((salario - SalarioMax3) * Aliquota / 100);
            }
            if(Aliquota == 14 && salario > SalarioMax4)
            {
                descINSS = (SalarioMax1 * Aliquota1 / 100) + ((SalarioMax2 - SalarioMax1) * Aliquota2 / 100) + ((SalarioMax3 - SalarioMax2) * Aliquota3 / 100) + ((SalarioMax4 - SalarioMax3) * Aliquota4 / 100);
            }

            formFolhaDetalhada.TxtTaxaDescINSS.Text = Convert.ToDecimal(Aliquota).ToString("N2");
            formFolhaDetalhada.TxtSalarioBaseINSS.Text = TxtSalario;
            formFolhaDetalhada.TxtDescINSS.Text = Convert.ToDecimal(descINSS).ToString("N2");
            formFolhaDetalhada.TxtValorInss.Text = Convert.ToDecimal(descINSS).ToString("N2");
            formFolhaDetalhada.TxtTotalInss.Text = Convert.ToDecimal(descINSS).ToString("N2");
            return descINSS;
        } 
        public double calculoIRRF(string TxtSalario, double DescInss, FormFolhaDetalhada formFolhaDetalhada)
        {

            List<string[]> Results = c_SearchInData.getListSalariosDescIRRF();
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
            double descIRRF = 0;
            salario = salario - DescInss; //Salario - Imposto do INSS

            if(salario <= SalarioMax1) { Aliquota = Aliquota1; }
            if(salario > SalarioMax1 && salario <= SalarioMax2) { Aliquota = Aliquota2; }
            if(salario > SalarioMax2 && salario <= SalarioMax3) { Aliquota = Aliquota3; }
            if(salario > SalarioMax3 && salario <= SalarioMax4) { Aliquota = Aliquota4; }
            if(salario > SalarioMax5) { Aliquota = Aliquota5; }

            

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
            return descIRRF;
        }
        public double calculoFGTS(string Txtsalario, FormFolhaDetalhada formFolhaDetalhada)
        {
            
            double salario = Convert.ToDouble(Txtsalario);
            List<string[]> Results = c_SearchInData.getListValorFGTS();
            double Aliquota = Convert.ToDouble(Results[0][1]);
            double descFGTS = salario * Aliquota / 100;
            formFolhaDetalhada.TxtSalarioBaseFGTS.Text = Txtsalario;
            formFolhaDetalhada.TxtValorFGTS.Text = Convert.ToDecimal(descFGTS).ToString("N2");
            formFolhaDetalhada.TxtTotalFGTS.Text = Convert.ToDecimal(descFGTS).ToString("N2");
            return descFGTS;
        } 
        public void showResultadosGerais(double descINSS, double descIRRF, string Txtsalario, FormFolhaDetalhada formFolhaDetalhada)
        {
            double salario = Convert.ToDouble(Txtsalario);

            double descTotais = descINSS + descIRRF;
            double salarioLiquido = salario - descTotais;

            formFolhaDetalhada.TxtMaiorRemuneracao.Text = Txtsalario;
            formFolhaDetalhada.TxtSalarioLiqMensal.Text = Convert.ToDecimal(salarioLiquido).ToString("N2");
            formFolhaDetalhada.TxtVencimentos.Text = Txtsalario;
            formFolhaDetalhada.TxtTotaisDescontos.Text = Convert.ToDecimal(descTotais).ToString("N2");
            formFolhaDetalhada.TxtSalarioLiquido.Text = Convert.ToDecimal(salarioLiquido).ToString("N2");
        }
    }
}
/*
 Criar um metodo SQL para trazer os dados dos salarios bases e as aliquotas para mostrar na tela
Lembra que nela o usuario irá poder alterar os valores porem apenas o usuario master ira alterar
++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Criar uma classe de calculo INSS e uma de IRRF, primeiro criar um metodo que receba o salario base 
e com ele fazer os devidos descontos do INSS e do IRRF.
++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Para calcular o INSS voce ira precisar entender que

Para salários de até um salário mínimo:
INSS = Salário bruto x 7,5%

Para salários entre um salário mínimo e R$ 2.327,91:
INSS = (Salário bruto - 1.325,00) x 9% + 99,38 (calculo da conta anterior)

Para salários entre R$ 2.327,92 e R$ 4.655,80:
INSS = (Salário bruto - 2.327,91) x 12% + 215,62 (calculo da conta anterior)

Para salários entre R$ 4.655,81 e R$ 6.861,67:
INSS = (Salário bruto - 4.655,80) x 14% + 539,37 (calculo da conta anterior)

Para salários acima de R$ 6.861,67:
INSS = R$ 958,22
++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Lembrando que os salarios variam e sofrem reajustes

 
 */
/*
    Com o valor das taxas em maos, fazer condicionais que façam o calculo
    prgoressivo do salario com base na taxa.
    exemplo: se a taxa for de 7,5 porcento ele deve somente fazer um calculo,
    pois ele recebe ate um salario minimo, se a taxa for de 9% deve fazer duas
    contas e assim por diante
    Obs: no caso de cair no 9% em diante, é preciso fazer a conta progressiva 
    onde é feito o abate dos valores e suas porcentagem.
 */

//SELECT FK_Cargo FROM bd_folha.tb_funcionario WHERE Matricula = 17;