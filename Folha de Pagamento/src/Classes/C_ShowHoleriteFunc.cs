using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using FOLHA_DE_PAGAMENTO_.src.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_ShowHoleriteFunc
    {
        C_SearchInDataBase C_SearchInDataBase = new C_SearchInDataBase();
        C_ManiplaçaoData c_ManiplaçaoData = new C_ManiplaçaoData();
        C_handleCargoSalarioDepartamento c_HandleCargo = new C_handleCargoSalarioDepartamento();
        
        public void getYear(string matricula, ComboBox CbYear)
        {
            string insertSql = $"SELECT DATA_Emite FROM bd_folha.tb_fechamento where FK_Matricula = '{matricula}' ;";
            List<string[]> ListDate = C_SearchInDataBase.getListinDB(insertSql);
            
            foreach (string[] date in ListDate)
            {
                if (CbYear.Items.Count < ListDate.Count)
                {
                    if (!CbYear.Items.Contains(c_ManiplaçaoData.getYear(date[0])))
                    {
                        CbYear.Height = ListDate.Count;
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
        public void getMonth(string matricula, string year, ComboBox CbMonth)
        {
            string insertSql = $"SELECT DATA_Emite FROM bd_folha.tb_fechamento where DATA_Emite LIKE '%{year}%' AND FK_Matricula = '{matricula}'";
            List<string[]> ListDate = C_SearchInDataBase.getListinDB(insertSql);
            foreach (string[] date in ListDate)
            {
                if (CbMonth.Items.Count < ListDate.Count)
                {
                    if (!CbMonth.Items.Contains(c_ManiplaçaoData.getMonth(date[0])))
                    {
                        CbMonth.Height = ListDate.Count;
                        CbMonth.Items.Add(c_ManiplaçaoData.getMonth(date[0]));
                        CbMonth.AutoCompleteCustomSource.Add(c_ManiplaçaoData.getMonth(date[0]));
                    }
                }
                if (CbMonth.GetItemText(c_ManiplaçaoData.getMonth(date[0])) != c_ManiplaçaoData.getMonth(date[0]))
                {
                    CbMonth.Items.Add(c_ManiplaçaoData.getMonth(date[0]));
                    CbMonth.AutoCompleteCustomSource.Add(c_ManiplaçaoData.getMonth(date[0]));
                }
            }
        }
        public void showDataHolerite(string matricula, string year, string month, FormHoleriteFunc formHoleriteFunc)
        {
            string insertSql = $"SELECT * FROM bd_folha.tb_fechamento where DATA_Emite LIKE '%{year}-{month}%' AND FK_Matricula = '{matricula}'";
            List<string[]> ListDate = C_SearchInDataBase.getListinDB(insertSql);
            List<string[]> Funcionario = C_SearchInDataBase.getListinDB($"SELECT * FROM bd_folha.tb_funcionario where Matricula = {matricula}");
            string ID_Holerite = ListDate[0][0];
            string DATA_EMite = ListDate[0][1];
            string Month = c_ManiplaçaoData.getMonth(DATA_EMite);
            string FK_Matricula = ListDate[0][2];
            string FK_IDCargo = ListDate[0][3];
            string FK_IRFDesconto = ListDate[0][4];
            string FK_INSSDesconto = ListDate[0][5];
            string Salario_Final = ListDate[0][6];
            string Valor_DescontoINSS = ListDate[0][7];
            string Valor_DescontoFGTS = ListDate[0][8];
            string Valor_DescontoIRF = ListDate[0][9];
            string Salario_Bruto = ListDate[0][10];

            string nome = Funcionario[0][2];
            string DataAdmissao = Funcionario[0][13];

            formHoleriteFunc.TxtMatricula.Text = FK_Matricula;
            formHoleriteFunc.TxtNome.Text = nome;
            formHoleriteFunc.TxtCargo.Text = c_HandleCargo.getIdCargo( FK_IDCargo );
            formHoleriteFunc.TxtDataAdmissao.Text = DataAdmissao;

            formHoleriteFunc.TxtMatricula_.Text = FK_Matricula;
            formHoleriteFunc.TxtIDINSS.Text = FK_INSSDesconto;
            formHoleriteFunc.TxtIDIRRF.Text = FK_IRFDesconto;
            formHoleriteFunc.TxtIdFGTS.Text = "1"; //ID sempre 1; 
            formHoleriteFunc.TxtNomeCompleto.Text = nome;

            formHoleriteFunc.TaxaINSS.Text = C_SearchInDataBase.getTaxaINSS(FK_INSSDesconto)[0][0];
            formHoleriteFunc.TaxaIRRF.Text = C_SearchInDataBase.getTaxaIRRF(FK_IRFDesconto)[0][0];
            formHoleriteFunc.TaxaFGTS.Text = C_SearchInDataBase.getTaxaFGTS("1")[0][0];
            formHoleriteFunc.TxtSalarioBaseMensal.Text = Salario_Bruto;
            formHoleriteFunc.VencINSS.Text = Valor_DescontoINSS;
            formHoleriteFunc.VencIRRF.Text = Valor_DescontoIRF;
            formHoleriteFunc.ValorFGTS.Text = Valor_DescontoFGTS;

            formHoleriteFunc.TxtVencTotal.Text = (Convert.ToDouble( Salario_Final ) + Convert.ToDouble(Valor_DescontoFGTS)).ToString("N2");
            formHoleriteFunc.DescINSS.Text = Valor_DescontoINSS;
            formHoleriteFunc.DescIRRF.Text = Valor_DescontoIRF;

            formHoleriteFunc.TxtDescTotal.Text = (Convert.ToDouble(Valor_DescontoINSS) + Convert.ToDouble(Valor_DescontoIRF)).ToString("N2");
            formHoleriteFunc.TxtValorLiquido.Text = Convert.ToDouble(Salario_Final).ToString("N2");
            formHoleriteFunc.TxtDataLancamento.Text = DATA_EMite.Substring(0,10);
            formHoleriteFunc.TxtDataEmissao.Text = DateTime.Today.ToString().Substring(0, 10);

            formHoleriteFunc.TxtSalarioBase.Text = Salario_Bruto;
            formHoleriteFunc.TxtBaseinss.Text = Salario_Bruto;
            formHoleriteFunc.TxtBaseFgts.Text = Salario_Bruto;
            formHoleriteFunc.TxtFgtsMes.Text = Valor_DescontoFGTS;
            formHoleriteFunc.TxtBaseirrf.Text = (Convert.ToDouble(Salario_Bruto) - Convert.ToDouble(Valor_DescontoINSS)).ToString("N2");
            formHoleriteFunc.TxtAno.Text = c_ManiplaçaoData.getYear(DATA_EMite);
            formHoleriteFunc.TxtMes.Text = c_ManiplaçaoData.setMonthName(Convert.ToInt32( Month ));
            formHoleriteFunc.TxtIDHolerite.Text = ID_Holerite;

            // Voce ira fazer esses dados receberem as posicoes da lista ListDate e fazer apaecer na tela de Holerite do Funcionario
            // Feito isso, fazer a tela de holerite porem agora onde ela possa escolher qual matricula mostrar.
        }
        public void showDataHolerite(string matricula, string year, string month, FormHolerite formHoleriteFunc)
        {
            string insertSql = $"SELECT * FROM bd_folha.tb_fechamento where DATA_Emite LIKE '%{year}-{month}%' AND FK_Matricula = '{matricula}'";
            List<string[]> ListDate = C_SearchInDataBase.getListinDB(insertSql);
            List<string[]> Funcionario = C_SearchInDataBase.getListinDB($"SELECT * FROM bd_folha.tb_funcionario where Matricula = {matricula}");
            string ID_Holerite = ListDate[0][0];
            string DATA_EMite = ListDate[0][1];
            string Month = c_ManiplaçaoData.getMonth(DATA_EMite);
            string FK_Matricula = ListDate[0][2];
            string FK_IDCargo = ListDate[0][3];
            string FK_IRFDesconto = ListDate[0][4];
            string FK_INSSDesconto = ListDate[0][5];
            string Salario_Final = ListDate[0][6];
            string Valor_DescontoINSS = ListDate[0][7];
            string Valor_DescontoFGTS = ListDate[0][8];
            string Valor_DescontoIRF = ListDate[0][9];
            string Salario_Bruto = ListDate[0][10];

            string nome = Funcionario[0][2];
            string DataAdmissao = Funcionario[0][13];

            formHoleriteFunc.TxtMatricula.Text = FK_Matricula;
            formHoleriteFunc.TxtNome.Text = nome;
            formHoleriteFunc.TxtCargo.Text = c_HandleCargo.getIdCargo(FK_IDCargo);
            formHoleriteFunc.TxtDataAdmissao.Text = DataAdmissao;

            formHoleriteFunc.TxtMatricula_.Text = FK_Matricula;
            formHoleriteFunc.TxtIDINSS.Text = FK_INSSDesconto;
            formHoleriteFunc.TxtIDIRRF.Text = FK_IRFDesconto;
            formHoleriteFunc.TxtIdFGTS.Text = "1"; //ID sempre 1; 
            formHoleriteFunc.TxtNomeCompleto.Text = nome;

            formHoleriteFunc.TaxaINSS.Text = C_SearchInDataBase.getTaxaINSS(FK_INSSDesconto)[0][0];
            formHoleriteFunc.TaxaIRRF.Text = C_SearchInDataBase.getTaxaIRRF(FK_IRFDesconto)[0][0];
            formHoleriteFunc.TaxaFGTS.Text = C_SearchInDataBase.getTaxaFGTS("1")[0][0];
            formHoleriteFunc.TxtSalarioBaseMensal.Text = Salario_Bruto;
            formHoleriteFunc.VencINSS.Text = Valor_DescontoINSS;
            formHoleriteFunc.VencIRRF.Text = Valor_DescontoIRF;
            formHoleriteFunc.ValorFGTS.Text = Valor_DescontoFGTS;

            formHoleriteFunc.TxtVencTotal.Text = (Convert.ToDouble(Salario_Final) + Convert.ToDouble(Valor_DescontoFGTS)).ToString("N2");
            formHoleriteFunc.DescINSS.Text = Valor_DescontoINSS;
            formHoleriteFunc.DescIRRF.Text = Valor_DescontoIRF;

            formHoleriteFunc.TxtDescTotal.Text = (Convert.ToDouble(Valor_DescontoINSS) + Convert.ToDouble(Valor_DescontoIRF)).ToString("N2");
            formHoleriteFunc.TxtValorLiquido.Text = Convert.ToDouble(Salario_Final).ToString("N2");
            formHoleriteFunc.TxtDataLancamento.Text = DATA_EMite.Substring(0, 10);
            formHoleriteFunc.TxtDataEmissao.Text = DateTime.Today.ToString().Substring(0, 10);

            formHoleriteFunc.TxtSalarioBase.Text = Salario_Bruto;
            formHoleriteFunc.TxtBaseinss.Text = Salario_Bruto;
            formHoleriteFunc.TxtBaseFgts.Text = Salario_Bruto;
            formHoleriteFunc.TxtFgtsMes.Text = Valor_DescontoFGTS;
            formHoleriteFunc.TxtBaseirrf.Text = (Convert.ToDouble(Salario_Bruto) - Convert.ToDouble(Valor_DescontoINSS)).ToString("N2");
            formHoleriteFunc.TxtAno.Text = c_ManiplaçaoData.getYear(DATA_EMite);
            formHoleriteFunc.TxtMes.Text = c_ManiplaçaoData.setMonthName(Convert.ToInt32(Month));
            formHoleriteFunc.TxtIDHolerite.Text = ID_Holerite;
        }
    }
}
