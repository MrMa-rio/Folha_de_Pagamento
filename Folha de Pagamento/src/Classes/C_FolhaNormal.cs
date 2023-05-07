using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_FolhaNormal
    {
        C_InsertData insertData = new C_InsertData();
        public void setFolhaNormal(FormFolhaNormal formFolhaNormal)
        {
            string columns;
            string values;

            columns =   "DATA_Fechamento," +
                        " Total_TaxaIRRF, Total_TaxaINSS," +
                        " Total_TaxaFGTS, SalarioBase_INSS, SalarioBase_IRRF," +
                        " SalarioBase_FGTS, SalarioBrutoTotal, Desc_INSS, Desc_IRRF," +
                        " Desc_Total, CLT, Funcionarios_Ativos, Salario_Liquido, Valor_FGTS ";
            C_TransformandoValores c_TransformandoValores = new C_TransformandoValores();

            string DATA_Fechamento = formFolhaNormal.TxtDataEmissao.Text;
            string Total_TaxaIRRF = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtTaxaDescIRRF.Text);
            string Total_TaxaINSS = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtTaxaDescINSS.Text);
            string Total_TaxaFGTS = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtTaxaDescFGTS.Text);
            string SalarioBase_INSS = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtSalarioBaseINSS.Text);
            string SalarioBase_IRRF = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtSalarioBaseIRRF.Text);
            string SalarioBase_FGTS = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtSalarioBaseFGTS.Text);
            string SalarioBrutoTotal = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtSalarioBaseINSS.Text);
            string Desc_INSS = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtValorInss.Text);
            string Desc_IRRF = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtValorIRRF.Text);
            string Desc_Total = c_TransformandoValores.alterandoFormatos(formFolhaNormal.TxtTotaisDescontos.Text);
            string CLT = formFolhaNormal.TxtCLT.Text;
            string Funcionarios_Ativos= formFolhaNormal.TxtAtivo.Text;
            string SalarioLiquido = c_TransformandoValores.alterandoFormatos( formFolhaNormal.TxtSalarioLiquido.Text );
            string TotalTaxaFGTS = formFolhaNormal.TxtTaxaDescFGTS.Text;

            values = $"STR_TO_DATE('{DATA_Fechamento}', '%d/%m/%Y')," + 
                $"'{Total_TaxaIRRF}','{Total_TaxaINSS}'," +
                $"'{Total_TaxaFGTS}'," +
                $"'{SalarioBase_INSS}'," +
                $"'{SalarioBase_IRRF}','{SalarioBase_FGTS}'," +
                $"'{SalarioBrutoTotal}','{Desc_INSS}','{Desc_IRRF}'," +
                $"'{Desc_Total}','{CLT}','{Funcionarios_Ativos}'," +
                $"'{SalarioLiquido}', '{TotalTaxaFGTS}'"
            ;
            insertData.setData("tb_fechamentoemp", columns, values);
            
        }
    }
}
