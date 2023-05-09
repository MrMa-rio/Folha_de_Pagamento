using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_FolhaNormalPesq
    {
        C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();
        C_ManiplaçaoData c_ManiplaçaoData = new C_ManiplaçaoData();
        public void getYearFolhaNormal(ComboBox CbYear)
        {
            
            string insertSql = $"SELECT DATA_Fechamento FROM bd_folha.tb_fechamentoemp order by DATA_Fechamento ASC";
            List<string[]> Results = c_SearchInDataBase.getListinDB(insertSql);
            foreach (string[] date in Results)
            {
                if (CbYear.Items.Count < Results.Count)
                {
                    if (!CbYear.Items.Contains(c_ManiplaçaoData.getYear(date[0])))
                    {
                        CbYear.Height = Results.Count;
                        CbYear.Items.Add(c_ManiplaçaoData.getYear(date[0]));
                        CbYear.AutoCompleteCustomSource.Add(c_ManiplaçaoData.getYear(date[0]));
                    }

                }
                if (CbYear.GetItemText(c_ManiplaçaoData.getYear(date[0])) != c_ManiplaçaoData.getYear(date[0]))
                {
                    CbYear.Items.Add(c_ManiplaçaoData.getYear(date[0]));
                    CbYear.AutoCompleteCustomSource.Add(c_ManiplaçaoData.getYear(date[0]));
                }
            }
        }
        public void getMonthFolhaNormal(ComboBox CbMonth, string year)
        {
            string insertSql = $"SELECT DATA_Fechamento FROM bd_folha.tb_fechamentoemp where DATA_Fechamento LIKE '%{year}%' order by DATA_Fechamento ASC";
            List<string[]> Results = c_SearchInDataBase.getListinDB(insertSql);

            foreach (string[] date in Results)
            {
                if (CbMonth.Items.Count < Results.Count)
                {
                    if (!CbMonth.Items.Contains( c_ManiplaçaoData.getMonth(date[0]) ) )
                    {
                        CbMonth.Height = Results.Count;
                        CbMonth.Items.Add( c_ManiplaçaoData.getMonth(date[0]) );
                        CbMonth.AutoCompleteCustomSource.Add( c_ManiplaçaoData.getMonth(date[0]) );
                    }

                }
                if (CbMonth.GetItemText(c_ManiplaçaoData.getMonth(date[0])) != c_ManiplaçaoData.getMonth(date[0]))
                {
                    CbMonth.Items.Add(c_ManiplaçaoData.getMonth(date[0]));
                    CbMonth.AutoCompleteCustomSource.Add(c_ManiplaçaoData.getMonth(date[0]));
                }
            }
        }
        public void ShowFolhaNormalPesq(FormFolhaNormalPesq formFolhaNormalPesq)
        {
            string year = formFolhaNormalPesq.CbAno.Text;
            string month = formFolhaNormalPesq.CbMes.Text;
            string insertSql = $"SELECT * FROM bd_folha.tb_fechamentoemp where DATA_Fechamento LIKE '%{year}-{month}%'";
            List<string[]> Results = c_SearchInDataBase.getListinDB(insertSql);

            string ID_FechamentoEmpresa = Results[0][0];
            string DATA_Fechamento = Results[0][1];
            string Total_TaxaIRRF = Results[0][2] ;
            string Total_TaxaINSS = Results[0][3];
            string Total_TaxaFGTS = Results[0][4];
            string SalarioBase_INSS = Results[0][5];
            string SalarioBase_IRRF = Results[0][6];
            string SalarioBase_FGTS = Results[0][7];
            string SalarioBrutoTotal = Results[0][8];
            string Desc_INSS = Results[0][9];
            string Desc_IRRF = Results[0][10];
            string Desc_Total = Results[0][11];
            string CLT = Results[0][12];
            string Funcionarios_Ativos = Results[0][13];
            string SalarioLiquido = Results[0][14];
            string ValorFGTS = Results[0][15];

            formFolhaNormalPesq.TxtTaxaINSS.Text = Convert.ToDouble( Total_TaxaINSS ).ToString("N2");
            formFolhaNormalPesq.TxtINSSDesc.Text = Convert.ToDouble( Desc_INSS ).ToString("N2");
            formFolhaNormalPesq.TxtSalarioINSS.Text = Convert.ToDouble( SalarioBase_INSS ).ToString("N2");
            formFolhaNormalPesq.TxtINSSValor.Text = Convert.ToDouble(Desc_INSS).ToString("N2");
            formFolhaNormalPesq.TxtDescTotalINSS.Text = Convert.ToDouble(Desc_INSS).ToString("N2");

            formFolhaNormalPesq.TxtTaxaDescIRRF.Text = Convert.ToDouble(Total_TaxaIRRF).ToString("N2");
            formFolhaNormalPesq.TxtDescIRRF.Text = Convert.ToDouble(Desc_IRRF).ToString("N2");
            formFolhaNormalPesq.TxtSalarioBaseIRRF.Text = Convert.ToDouble(SalarioBase_IRRF).ToString("N2");
            formFolhaNormalPesq.TxtValorIRRF.Text = Convert.ToDouble(Desc_IRRF).ToString("N2");
            formFolhaNormalPesq.TxtTotalIRRF.Text = Convert.ToDouble(Desc_IRRF).ToString("N2");

            formFolhaNormalPesq.TxtSalarioBaseFGTS.Text = Convert.ToDouble(SalarioBase_FGTS).ToString("N2");
            formFolhaNormalPesq.TxtTaxaFGTS.Text = Convert.ToDouble(Total_TaxaFGTS).ToString("N2");
            formFolhaNormalPesq.TxtValorFGTS.Text = Convert.ToDouble(ValorFGTS).ToString("N2");
            formFolhaNormalPesq.TxtTotalFGTS.Text = Convert.ToDouble(ValorFGTS).ToString("N2");

            formFolhaNormalPesq.TxtMaiorRemuneracao.Text = Convert.ToDouble(SalarioBrutoTotal).ToString("N2");
            formFolhaNormalPesq.TxtTotaisDescontos.Text = Convert.ToDouble(Desc_Total).ToString("N2");
            formFolhaNormalPesq.TxtSalarioLiquido.Text = Convert.ToDouble(SalarioLiquido).ToString("N2");
            formFolhaNormalPesq.TxtDataLancamento.Text = DATA_Fechamento.Substring(0,10);
            formFolhaNormalPesq.TxtVencimentos.Text = Convert.ToDouble(SalarioBrutoTotal).ToString("N2");
            formFolhaNormalPesq.TxtID.Text = ID_FechamentoEmpresa;
            formFolhaNormalPesq.TxtSalarioLiqMensal.Text = Convert.ToDouble(SalarioLiquido).ToString("N2");
            formFolhaNormalPesq.TxtDataEmissao.Text = DateTime.Today.ToString().Substring(0,10);
            formFolhaNormalPesq.LbClt.Text = CLT;
            formFolhaNormalPesq.LbAtivos.Text = Funcionarios_Ativos;


        }
    }
}


//SELECT * FROM bd_folha.tb_fechamentoemp where DATA_Fechamento LIKE '%2023%'