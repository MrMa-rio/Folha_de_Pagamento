using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    
    internal class C_CalculosFolha
    {
        C_SearchInDataBase searchInData = new C_SearchInDataBase();

        public void setSalariosBaseINSS(FormCalculoPagamento formCalculoPagamento)
        {
            List<string[]> Results = searchInData.getListSalariosDescINSS();

            formCalculoPagamento.TxtFxSalarioID1Min.Text = "R$" + Convert.ToDecimal(Results[0][2]).ToString("N2");
            formCalculoPagamento.TxtFxSalarioID1Max.Text = "R$" + Convert.ToDecimal(Results[0][3]).ToString("N2");
            formCalculoPagamento.TxtAliquota1.Text = Convert.ToDecimal(Results[0][4]).ToString() + "%";

            formCalculoPagamento.TxtFxSalarioID2Min.Text = "R$" + Convert.ToDecimal(Results[1][2]).ToString("N2");
            formCalculoPagamento.TxtFxSalarioID2Max.Text = "R$" + Convert.ToDecimal(Results[1][3]).ToString("N2");
            formCalculoPagamento.TxtAliquota2.Text = Convert.ToDecimal(Results[1][4]).ToString() + "%";

            formCalculoPagamento.TxtFxSalarioID3Min.Text = "R$" + Convert.ToDecimal(Results[2][2]).ToString("N2");
            formCalculoPagamento.TxtFxSalarioID3Max.Text = "R$" + Convert.ToDecimal(Results[2][3]).ToString("N2");
            formCalculoPagamento.TxtAliquota3.Text = Convert.ToDecimal(Results[2][4]).ToString() + "%";

            formCalculoPagamento.TxtFxSalarioID4Min.Text = "R$" + Convert.ToDecimal(Results[3][2]).ToString("N2");
            formCalculoPagamento.TxtFxSalarioID4Max.Text = "R$" + Convert.ToDecimal(Results[3][3]).ToString("N2");
            formCalculoPagamento.TxtAliquota4.Text = Convert.ToDecimal(Results[3][4]).ToString() + "%";


        }

        public void setSalariosBaseIRRF(FormCalculoPagamento formCalculoPagamento)
        {
            List<string[]> Results = searchInData.getListSalariosDescIRRF();

            formCalculoPagamento.TxtSalarioIrId1Min.Text = "R$" + Convert.ToDecimal(Results[0][2]).ToString("N2");
            formCalculoPagamento.TxtSalarioIrId1Max.Text = "R$" + Convert.ToDecimal(Results[0][3]).ToString("N2");
            formCalculoPagamento.TxtAliquotaIr1.Text = Convert.ToDecimal(Results[0][4]).ToString() + "%";

            formCalculoPagamento.TxtSalarioIrId2Min.Text = "R$" + Convert.ToDecimal(Results[1][2]).ToString("N2");
            formCalculoPagamento.TxtSalarioIrId2Max.Text = "R$" + Convert.ToDecimal(Results[1][3]).ToString("N2");
            formCalculoPagamento.TxtAliquotaIr2.Text = Convert.ToDecimal(Results[1][4]).ToString() + "%";

            formCalculoPagamento.TxtSalarioIrId3Min.Text = "R$" + Convert.ToDecimal(Results[2][2]).ToString("N2");
            formCalculoPagamento.TxtSalarioIrId3Max.Text = "R$" + Convert.ToDecimal(Results[2][3]).ToString("N2");
            formCalculoPagamento.TxtAliquotaIr3.Text = Convert.ToDecimal(Results[2][4]).ToString() + "%";

            formCalculoPagamento.TxtSalarioIrId4Min.Text = "R$" + Convert.ToDecimal(Results[3][2]).ToString("N2");
            formCalculoPagamento.TxtSalarioIrId4Max.Text = "R$" + Convert.ToDecimal(Results[3][3]).ToString("N2");
            formCalculoPagamento.TxtAliquotaIr4.Text = Convert.ToDecimal(Results[3][4]).ToString() + "%";

            formCalculoPagamento.TxtSalarioIrId5Min.Text = "R$" + Convert.ToDecimal(Results[4][2]).ToString("N2");
            formCalculoPagamento.TxtSalarioIrId5Max.Text = "R$" + Convert.ToDecimal(Results[4][3]).ToString("N2");
            formCalculoPagamento.TxtAliquotaIr5.Text = Convert.ToDecimal(Results[4][4]).ToString() + "%";
        }

    }
}
