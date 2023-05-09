using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_RelatorioFolha
    {
        C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();
        C_handleCargoSalarioDepartamento c_HandleCargo = new C_handleCargoSalarioDepartamento();
        C_ManiplaçaoData c_ManiplaçaoData = new C_ManiplaçaoData();
        public void setFolhaDetalhada(FormFolhaDetalhada formFolhaDetalhada)
        {
            C_SearchInDataBase c_SearchInData = new C_SearchInDataBase();
            C_TransformandoValores c_TransformandoValores = new C_TransformandoValores();

            string taxaINSS = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtTaxaDescINSS.Text);
            string taxaIRRF = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtTaxaDescIRRF.Text);

            List<string[]> Result = c_SearchInData.getListinDB($"SELECT FK_Cargo FROM bd_folha.tb_funcionario WHERE Matricula = {formFolhaDetalhada.TxtPesquisarMatricula.Text};");
            List<string[]> resultIdINSS = c_SearchInData.getListinDB($"Select ID_INSS FROM tb_inss where Taxa_Desconto = {taxaINSS}");
            List<string[]> resultIdIRRF = c_SearchInData.getListinDB($"Select ID_IRF FROM tb_irf where Taxa_Desconto = {taxaIRRF}");

            DateTime dateTime = DateTime.Today;
            string table = "tb_fechamento";
            string columns = "DATA_Emite, FK_Matricula, FK_IDCargo, FK_IRFDesconto, FK_INSSDesconto, Salario_Final, Valor_DescontoINSS, Valor_DescontoFGTS, Valor_DescontoIRF, Salario_Bruto";

            string salarioLiquido = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtSalarioLiquido.Text);
            string descINSS = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtDescINSS.Text);
            string descIRRF = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtDescIRRF.Text);
            string ValorFGTS = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtValorFGTS.Text);
            string SalarioBruto = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtSalarioBase.Text);
            string data = $" STR_TO_DATE('{dateTime.ToString()}', '%d/%m/%Y'), '{formFolhaDetalhada.TxtMatricula.Text}'," +
                          $" '{Result[0][0]}', '{resultIdIRRF[0][0]}'," +
                          $" '{resultIdINSS[0][0]}', '{salarioLiquido}'," +
                          $" '{descINSS}', '{ValorFGTS}'," +
                          $" '{descIRRF}', '{SalarioBruto}' ";

            C_InsertData c_InsertData = new C_InsertData();
            c_InsertData.setData(table, columns, data);
        }

        public void getFolhaDetalhada(FormFolhaDetalhadaPesq formFolhaDetalhada)
        {

            string matricula = formFolhaDetalhada.TxtPesquisarMatricula.Text;
            string year = formFolhaDetalhada.CbYear.Text;
            string month = formFolhaDetalhada.CbMonth.Text;

            List<string[]> ListDate = c_SearchInDataBase.getListFechamento(matricula, year, month);
            setDadosFuncionario(matricula, formFolhaDetalhada);
            setDadosFolhaDetalhada(formFolhaDetalhada, ListDate);
        }

        public void setDadosFuncionario(string matricula, FormFolhaDetalhadaPesq formFolhaDetalhada)
        {
            List<string[]> data = c_SearchInDataBase.getDataFuncionario(matricula);
            if(data.Count > 0)
            {
                formFolhaDetalhada.TxtMatricula.Text = data[0][0];
                formFolhaDetalhada.TxtNome.Text = data[0][2];
                formFolhaDetalhada.TxtDataAdmissao.Text = data[0][13];
            }
            
        }

        public void setDadosFolhaDetalhada(FormFolhaDetalhadaPesq formFolhaDetalhada, List<string[]> ListDate)
        {
            string TaxaINSS,valorFGTS, TaxaIRRF, descINSS, descIRRF;
            double salario = Convert.ToDouble(ListDate[0][10]);
            double descINSS_ = Convert.ToDouble(ListDate[0][7]);
            double descIRRF_ = Convert.ToDouble(ListDate[0][9]);
            formFolhaDetalhada.TxtCargo.Text = c_HandleCargo.getIdCargo(ListDate[0][3]);

            TaxaINSS = c_SearchInDataBase.getTaxaINSS(ListDate[0][5])[0][0];
            TaxaIRRF = c_SearchInDataBase.getTaxaIRRF(ListDate[0][4])[0][0];

            descINSS = ListDate[0][7];
            descIRRF = ListDate[0][9];

            formFolhaDetalhada.TxtTaxaDescINSS.Text = TaxaINSS;
            formFolhaDetalhada.TxtTaxaDescIRRF.Text = TaxaIRRF;
            formFolhaDetalhada.TxtValorFGTS.Text = ListDate[0][8];

            formFolhaDetalhada.TxtSalarioBase.Text = ListDate[0][10];
            formFolhaDetalhada.TxtSalarioBaseINSS.Text = ListDate[0][10];
            formFolhaDetalhada.TxtSalarioBaseFGTS.Text = ListDate[0][10];
            formFolhaDetalhada.TxtSalarioBaseIRRF.Text = (salario - descINSS_).ToString("N2");

            formFolhaDetalhada.TxtDescINSS.Text = descINSS;
            formFolhaDetalhada.TxtDescIRRF.Text = descIRRF;

            formFolhaDetalhada.TxtValorInss.Text = descINSS;
            formFolhaDetalhada.TxtValorIRRF.Text = descIRRF;

            formFolhaDetalhada.TxtTotalInss.Text = descINSS;
            formFolhaDetalhada.TxtTotalIRRF.Text = descIRRF;
            formFolhaDetalhada.TxtTotalFGTS.Text = ListDate[0][8];

            formFolhaDetalhada.TxtMaiorRemuneracao.Text = Convert.ToDouble( ListDate[0][10]).ToString("N2");
            formFolhaDetalhada.TxtVencimentos.Text = Convert.ToDouble(ListDate[0][10]).ToString("N2");
            formFolhaDetalhada.TxtSalarioLiqMensal.Text = Convert.ToDouble(ListDate[0][6]).ToString("N2");
            formFolhaDetalhada.TxtSalarioLiquido.Text = (salario - descINSS_ - descIRRF_ ).ToString("N2");
            formFolhaDetalhada.TxtTotaisDescontos.Text = (descINSS_ + descIRRF_).ToString("N2");

            formFolhaDetalhada.TxtIdFolha.Text = ListDate[0][0];
            formFolhaDetalhada.TxtDataLancamento.Text = ListDate[0][1].Substring(0, 10);
            formFolhaDetalhada.TxtDataEmissao.Text = DateTime.Today.ToString().Substring(0,10);
            formFolhaDetalhada.TxtSalBaseMensal.Text = formFolhaDetalhada.TxtVencimentos.Text;


        }

        public void setYear(ComboBox CbYear, string matricula)
        {
            C_ManiplaçaoData c_ManiplaçaoData = new C_ManiplaçaoData();
            C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();
            List<string[]> ListDate = c_SearchInDataBase.getListDate(matricula);

            foreach (string[] date in ListDate)
            {
                if (CbYear.Items.Count < ListDate.Count)
                {
                    if (!CbYear.Items.Contains(c_ManiplaçaoData.getYear(date[0]) ))
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

        public void setMonth(FormFolhaDetalhadaPesq formFolhaDetalhada)
        {
            string matricula = formFolhaDetalhada.TxtPesquisarMatricula.Text;
            string year = formFolhaDetalhada.CbYear.Text;
            ComboBox CbMonth = formFolhaDetalhada.CbMonth;

            C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();
            

            List<string[]> ListDate = c_SearchInDataBase.getListMonth(matricula, year);

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

        public void getYearFolhaNormal(ComboBox CbYear)
        {
            C_ManiplaçaoData c_ManiplaçaoData = new C_ManiplaçaoData();
            C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();
            List<string[]> ListDate = c_SearchInDataBase.getListDate();

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

        public void setMonth(string year, ComboBox CbMonth)
        {
            List<string[]> ListDate = c_SearchInDataBase.getListMonth(year);

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

        public bool dadosDuplicadoDetalhado(string matricula, string dataEmissao)
        {
            

            string month = c_ManiplaçaoData.getMonth(dataEmissao);
            string year = c_ManiplaçaoData.getYear(dataEmissao);
            //'
            string insertSql = $"SELECT * FROM bd_folha.tb_fechamento where DATA_Emite LIKE '%{year}-{month}%' AND FK_Matricula = {matricula}";
            if(c_SearchInDataBase.getListinDB(insertSql).Count > 0)
            {
                return false;
            }

            return true;
        }
        public bool dadosDuplicadoFNormal(string dataEmissao)
        {


            string month = c_ManiplaçaoData.getMonth(dataEmissao);
            string year = c_ManiplaçaoData.getYear(dataEmissao);
            string insertSql = $"SELECT * FROM bd_folha.tb_fechamentoemp where DATA_Fechamento LIKE '%{year}-{month}%' ";
            if (c_SearchInDataBase.getListinDB(insertSql).Count > 0)
            {
                return false;
            }

            return true;
        }

    }

}




/*
 * TODO:
 *      Fazer os pull Origin dos forms do black
 *      Fazer os comboBox ficar responsivo com cada mes do funcionario
 *      Calcular o valor geral das contas de todos funcionarios.
 *      Pra isso devem estar funcionando: Gerador de Folha Detalhada, Leitura da folha mensal, alteração de no maximo 1 mes.
 *      Com isso fazer uma somatoria de todos os funcionario daquele mes.
 *      O gerador de PDF estar funcionado
 *      Com todas essas funcionalidades já funcional, fazer o forms do holerite.
 *      
 *      Login usuarios estão com senha HardCode CPF!!
 *      
 *      E por FIm correção de Bugs
 */