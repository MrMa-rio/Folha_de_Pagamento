using FOLHA_DE_PAGAMENTO_.src.Forms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_PrintPDF
    {
        public void printPdf(Panel LbFolhaNormal)
        {
            Bitmap telaAtual = new Bitmap(LbFolhaNormal.Width, LbFolhaNormal.Height);
            LbFolhaNormal.DrawToBitmap(telaAtual, new Rectangle(Point.Empty, LbFolhaNormal.Size));
            Graphics g = Graphics.FromImage(telaAtual);
            Point point1 = new Point(110);
            Point point2 = new Point(1280);
            g.CopyFromScreen(point1, point2, LbFolhaNormal.Size);
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
            PrinterSettings printerSettings = printDialog.PrinterSettings;
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrinterSettings = printerSettings;
            printDocument.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawImage(telaAtual, e.MarginBounds);
            };
            printDocument.Print();
        }

        public void WriterHolerite(FormHoleritePDF holeritePDF, FormHolerite formHolerite)
        {
            holeritePDF.TxtMes.Text = formHolerite.TxtMes.Text;
            holeritePDF.TxtAno.Text = formHolerite.TxtAno.Text;

            holeritePDF.TxtMatricula.Text = formHolerite.TxtMatricula.Text;
            holeritePDF.TxtNome.Text = formHolerite.TxtNome.Text;
            holeritePDF.TxtCargo.Text = formHolerite.TxtCargo.Text;
            holeritePDF.TxtDataAdmissao.Text = formHolerite.TxtDataAdmissao.Text;

            holeritePDF.TxtIDINSS.Text = formHolerite.TxtIDINSS.Text;
            holeritePDF.TxtIDIRRF.Text = formHolerite.TxtIDIRRF.Text;
            holeritePDF.TxtIdFGTS.Text = formHolerite.TxtIdFGTS.Text;
            holeritePDF.TxtMatricula_.Text = formHolerite.TxtMatricula_.Text;
            holeritePDF.TxtNomeCompleto.Text = formHolerite.TxtNomeCompleto.Text;

            holeritePDF.TaxaINSS.Text = formHolerite.TaxaINSS.Text;
            holeritePDF.TaxaIRRF.Text = formHolerite.TaxaIRRF.Text;
            holeritePDF.TaxaFGTS.Text = formHolerite.TaxaFGTS.Text;

            holeritePDF.TxtSalarioBaseMensal.Text = formHolerite.TxtSalarioBaseMensal.Text;
            holeritePDF.VencINSS.Text = formHolerite.VencINSS.Text;
            holeritePDF.VencIRRF.Text = formHolerite.VencIRRF.Text;
            holeritePDF.ValorFGTS.Text = formHolerite.ValorFGTS.Text;
            holeritePDF.TxtVencTotal.Text = formHolerite.TxtVencTotal.Text;

            holeritePDF.DescINSS.Text = formHolerite.DescINSS.Text;
            holeritePDF.DescIRRF.Text = formHolerite.DescIRRF.Text;
            holeritePDF.TxtDescTotal.Text = formHolerite.TxtDescTotal.Text;

            holeritePDF.TxtDataEmissao.Text = formHolerite.TxtDataEmissao.Text;
            holeritePDF.TxtValorLiquido.Text = formHolerite.TxtValorLiquido.Text;

            holeritePDF.TxtIDHolerite.Text = formHolerite.TxtIDHolerite.Text;
            holeritePDF.TxtSalarioBase.Text = formHolerite.TxtSalarioBase.Text;
            holeritePDF.TxtBaseinss.Text = formHolerite.TxtBaseinss.Text;
            holeritePDF.TxtBaseFgts.Text = formHolerite.TxtBaseFgts.Text;
            holeritePDF.TxtFgtsMes.Text = formHolerite.TxtFgtsMes.Text;
            holeritePDF.TxtBaseirrf.Text = formHolerite.TxtBaseirrf.Text;
            holeritePDF.TxtDataLancamento.Text = formHolerite.TxtDataLancamento.Text;
        }
        public void WriterHolerite(FormHoleritePDF holeritePDF, FormHoleriteFunc formHolerite)
        {
            holeritePDF.TxtMes.Text = formHolerite.TxtMes.Text;
            holeritePDF.TxtAno.Text = formHolerite.TxtAno.Text;

            holeritePDF.TxtMatricula.Text = formHolerite.TxtMatricula.Text;
            holeritePDF.TxtNome.Text = formHolerite.TxtNome.Text;
            holeritePDF.TxtCargo.Text = formHolerite.TxtCargo.Text;
            holeritePDF.TxtDataAdmissao.Text = formHolerite.TxtDataAdmissao.Text;

            holeritePDF.TxtIDINSS.Text = formHolerite.TxtIDINSS.Text;
            holeritePDF.TxtIDIRRF.Text = formHolerite.TxtIDIRRF.Text;
            holeritePDF.TxtIdFGTS.Text = formHolerite.TxtIdFGTS.Text;
            holeritePDF.TxtMatricula_.Text = formHolerite.TxtMatricula_.Text;
            holeritePDF.TxtNomeCompleto.Text = formHolerite.TxtNomeCompleto.Text;

            holeritePDF.TaxaINSS.Text = formHolerite.TaxaINSS.Text;
            holeritePDF.TaxaIRRF.Text = formHolerite.TaxaIRRF.Text;
            holeritePDF.TaxaFGTS.Text = formHolerite.TaxaFGTS.Text;

            holeritePDF.TxtSalarioBaseMensal.Text = formHolerite.TxtSalarioBaseMensal.Text;
            holeritePDF.VencINSS.Text = formHolerite.VencINSS.Text;
            holeritePDF.VencIRRF.Text = formHolerite.VencIRRF.Text;
            holeritePDF.ValorFGTS.Text = formHolerite.ValorFGTS.Text;
            holeritePDF.TxtVencTotal.Text = formHolerite.TxtVencTotal.Text;

            holeritePDF.DescINSS.Text = formHolerite.DescINSS.Text;
            holeritePDF.DescIRRF.Text = formHolerite.DescIRRF.Text;
            holeritePDF.TxtDescTotal.Text = formHolerite.TxtDescTotal.Text;

            holeritePDF.TxtDataEmissao.Text = formHolerite.TxtDataEmissao.Text;
            holeritePDF.TxtIDHolerite.Text = formHolerite.TxtIDHolerite.Text;
            holeritePDF.TxtSalarioBase.Text = formHolerite.TxtSalarioBase.Text;
            holeritePDF.TxtBaseinss.Text = formHolerite.TxtBaseinss.Text;
            holeritePDF.TxtBaseFgts.Text = formHolerite.TxtBaseFgts.Text;
            holeritePDF.TxtFgtsMes.Text = formHolerite.TxtFgtsMes.Text;
            holeritePDF.TxtBaseirrf.Text = formHolerite.TxtBaseirrf.Text;
            holeritePDF.TxtDataLancamento.Text = formHolerite.TxtDataLancamento.Text;
        }

        public void WriterFolhaDetalhada(FormFolhaDetalhadaPDF folhaDetalhadaPDF,FormFolhaDetalhadaPesq formFolhaDetalhada)
        {
            folhaDetalhadaPDF.TxtMatricula.Text = formFolhaDetalhada.TxtMatricula.Text;
            folhaDetalhadaPDF.TxtNome.Text = formFolhaDetalhada.TxtNome.Text;
            folhaDetalhadaPDF.TxtCargo.Text = formFolhaDetalhada.TxtCargo.Text;
            folhaDetalhadaPDF.TxtSalarioBase.Text = formFolhaDetalhada.TxtSalarioBase.Text;
            folhaDetalhadaPDF.TxtDataAdmissao.Text = formFolhaDetalhada.TxtDataAdmissao.Text;

            folhaDetalhadaPDF.TxtTaxaDescINSS.Text = formFolhaDetalhada.TxtTaxaDescINSS.Text;
            folhaDetalhadaPDF.TxtDescINSS.Text = formFolhaDetalhada.TxtDescINSS.Text;
            folhaDetalhadaPDF.TxtSalarioBaseINSS.Text = formFolhaDetalhada.TxtSalarioBaseINSS.Text;
            folhaDetalhadaPDF.TxtValorInss.Text = formFolhaDetalhada.TxtValorInss.Text;
            folhaDetalhadaPDF.TxtTotalInss.Text = formFolhaDetalhada.TxtTotalInss.Text;

            folhaDetalhadaPDF.TxtTaxaDescIRRF.Text = formFolhaDetalhada.TxtTaxaDescIRRF.Text;
            folhaDetalhadaPDF.TxtDescIRRF.Text = formFolhaDetalhada.TxtDescIRRF.Text;
            folhaDetalhadaPDF.TxtSalarioBaseIRRF.Text = formFolhaDetalhada.TxtSalarioBaseIRRF.Text;
            folhaDetalhadaPDF.TxtValorIRRF.Text = formFolhaDetalhada.TxtValorIRRF.Text;
            folhaDetalhadaPDF.TxtTotalIRRF.Text = formFolhaDetalhada.TxtTotalIRRF.Text;

            folhaDetalhadaPDF.TxtSalarioBaseFGTS.Text = formFolhaDetalhada.TxtSalarioBaseFGTS.Text;
            folhaDetalhadaPDF.TxtValorFGTS.Text = formFolhaDetalhada.TxtValorFGTS.Text;
            folhaDetalhadaPDF.TxtTotalFGTS.Text = formFolhaDetalhada.TxtTotalFGTS.Text;

            folhaDetalhadaPDF.TxtMaiorRemuneracao.Text = formFolhaDetalhada.TxtMaiorRemuneracao.Text;
            folhaDetalhadaPDF.TxtSalarioLiqMensal.Text = formFolhaDetalhada.TxtSalarioLiqMensal.Text;
            folhaDetalhadaPDF.TxtDataEmissao.Text = formFolhaDetalhada.TxtDataLancamento.Text;
            folhaDetalhadaPDF.TxtDataLancamento.Text = formFolhaDetalhada.TxtDataEmissao.Text;

            folhaDetalhadaPDF.TxtIdFolha.Text = formFolhaDetalhada.TxtIdFolha.Text;
            folhaDetalhadaPDF.TxtVencimentos.Text = formFolhaDetalhada.TxtVencimentos.Text;
            folhaDetalhadaPDF.TxtSalBaseMensal.Text = formFolhaDetalhada.TxtSalBaseMensal.Text;
            folhaDetalhadaPDF.TxtTotaisDescontos.Text = formFolhaDetalhada.TxtTotaisDescontos.Text;
            folhaDetalhadaPDF.TxtSalarioLiquido.Text = formFolhaDetalhada.TxtSalarioLiquido.Text;
            folhaDetalhadaPDF.TxtSalBaseMensal.Text = formFolhaDetalhada.TxtSalBaseMensal.Text;
        }

        public void WriterFolhaDetalhada(FormFolhaDetalhadaPDF folhaDetalhadaPDF, FormFolhaDetalhada formFolhaDetalhada)
        {
            folhaDetalhadaPDF.TxtMatricula.Text = formFolhaDetalhada.TxtMatricula.Text;
            folhaDetalhadaPDF.TxtNome.Text = formFolhaDetalhada.TxtNome.Text;
            folhaDetalhadaPDF.TxtCargo.Text = formFolhaDetalhada.TxtCargo.Text;
            folhaDetalhadaPDF.TxtSalarioBase.Text = formFolhaDetalhada.TxtSalarioBase.Text;
            folhaDetalhadaPDF.TxtDataAdmissao.Text = formFolhaDetalhada.TxtDataAdmissao.Text;

            folhaDetalhadaPDF.TxtTaxaDescINSS.Text = formFolhaDetalhada.TxtTaxaDescINSS.Text;
            folhaDetalhadaPDF.TxtDescINSS.Text = formFolhaDetalhada.TxtDescINSS.Text;
            folhaDetalhadaPDF.TxtSalarioBaseINSS.Text = formFolhaDetalhada.TxtSalarioBaseINSS.Text;
            folhaDetalhadaPDF.TxtValorInss.Text = formFolhaDetalhada.TxtValorInss.Text;
            folhaDetalhadaPDF.TxtTotalInss.Text = formFolhaDetalhada.TxtTotalInss.Text;

            folhaDetalhadaPDF.TxtTaxaDescIRRF.Text = formFolhaDetalhada.TxtTaxaDescIRRF.Text;
            folhaDetalhadaPDF.TxtDescIRRF.Text = formFolhaDetalhada.TxtDescIRRF.Text;
            folhaDetalhadaPDF.TxtSalarioBaseIRRF.Text = formFolhaDetalhada.TxtSalarioBaseIRRF.Text;
            folhaDetalhadaPDF.TxtValorIRRF.Text = formFolhaDetalhada.TxtValorIRRF.Text;
            folhaDetalhadaPDF.TxtTotalIRRF.Text = formFolhaDetalhada.TxtTotalIRRF.Text;

            folhaDetalhadaPDF.TxtSalarioBaseFGTS.Text = formFolhaDetalhada.TxtSalarioBaseFGTS.Text;
            folhaDetalhadaPDF.TxtValorFGTS.Text = formFolhaDetalhada.TxtValorFGTS.Text;
            folhaDetalhadaPDF.TxtTotalFGTS.Text = formFolhaDetalhada.TxtTotalFGTS.Text;

            folhaDetalhadaPDF.TxtMaiorRemuneracao.Text = formFolhaDetalhada.TxtMaiorRemuneracao.Text;
            folhaDetalhadaPDF.TxtSalarioLiqMensal.Text = formFolhaDetalhada.TxtSalarioLiqMensal.Text;
            //folhaDetalhadaPDF.TxtDataEmissao.Text = formFolhaDetalhada.TxtDataLancamento.Text;
            folhaDetalhadaPDF.TxtDataLancamento.Text = formFolhaDetalhada.TxtDataEmissao.Text;

           // folhaDetalhadaPDF.TxtIdFolha.Text = formFolhaDetalhada.TxtIdFolha.Text;
            folhaDetalhadaPDF.TxtVencimentos.Text = formFolhaDetalhada.TxtVencimentos.Text;
            //folhaDetalhadaPDF.TxtSalBaseMensal.Text = formFolhaDetalhada.TxtSalBaseMensal.Text;
            folhaDetalhadaPDF.TxtTotaisDescontos.Text = formFolhaDetalhada.TxtTotaisDescontos.Text;
            folhaDetalhadaPDF.TxtSalarioLiquido.Text = formFolhaDetalhada.TxtSalarioLiquido.Text;
            //folhaDetalhadaPDF.TxtSalBaseMensal.Text = formFolhaDetalhada.TxtSalBaseMensal.Text;
        }

        public void WriterFolhaNormal(FormFolhaNormalPDF formNormalPDF, FormFolhaNormalPesq formFolhaNormal)
        {

            formNormalPDF.TxtTaxaINSS.Text = formFolhaNormal.TxtTaxaINSS.Text;
            formNormalPDF.TxtINSSDesc.Text = formFolhaNormal.TxtINSSDesc.Text;
            formNormalPDF.TxtSalarioINSS.Text = formFolhaNormal.TxtSalarioINSS.Text;
            formNormalPDF.TxtINSSValor.Text = formFolhaNormal.TxtINSSValor.Text;
            formNormalPDF.TxtDescTotalINSS.Text = formFolhaNormal.TxtDescTotalINSS.Text;

            formNormalPDF.TxtTaxaDescIRRF.Text = formFolhaNormal.TxtTaxaDescIRRF.Text;
            formNormalPDF.TxtDescIRRF.Text = formFolhaNormal.TxtDescIRRF.Text;
            formNormalPDF.TxtSalarioBaseIRRF.Text = formFolhaNormal.TxtSalarioBaseIRRF.Text;
            formNormalPDF.TxtValorIRRF.Text = formFolhaNormal.TxtValorIRRF.Text;
            formNormalPDF.TxtTotalIRRF.Text = formFolhaNormal.TxtTotalIRRF.Text;

            formNormalPDF.TxtTaxaFGTS.Text = formFolhaNormal.TxtTaxaFGTS.Text;
            formNormalPDF.TxtSalarioBaseFGTS.Text = formFolhaNormal.TxtSalarioBaseFGTS.Text;
            formNormalPDF.TxtValorFGTS.Text = formFolhaNormal.TxtValorFGTS.Text;
            formNormalPDF.TxtTotalFGTS.Text = formFolhaNormal.TxtTotalFGTS.Text;

            formNormalPDF.TxtMaiorRemuneracao.Text = formFolhaNormal.TxtMaiorRemuneracao.Text;
            formNormalPDF.TxtSalarioLiqMensal.Text = formFolhaNormal.TxtSalarioLiqMensal.Text;
            formNormalPDF.TxtDataLancamento.Text = formFolhaNormal.TxtDataLancamento.Text;
            formNormalPDF.TxtDataEmissao.Text = formFolhaNormal.TxtDataEmissao.Text;
            
            formNormalPDF.TxtID.Text = formFolhaNormal.TxtID.Text;
            formNormalPDF.TxtVencimentos.Text = formFolhaNormal.TxtVencimentos.Text;
            formNormalPDF.TxtTotaisDescontos.Text = formFolhaNormal.TxtTotaisDescontos.Text;
            formNormalPDF.TxtSalarioLiquido.Text = formFolhaNormal.TxtSalarioLiquido.Text;

            formNormalPDF.LbClt.Text = formFolhaNormal.LbClt.Text;
            formNormalPDF.LbAtivos.Text = formFolhaNormal.LbAtivos.Text;
        }
        public void WriterFolhaNormal(FormFolhaNormalPDF formNormalPDF, FormFolhaNormal formFolhaNormal)
        {
            formNormalPDF.TxtTaxaINSS.Text = formFolhaNormal.TxtTaxaDescINSS.Text;
            formNormalPDF.TxtINSSDesc.Text = formFolhaNormal.TxtDescINSS.Text;
            formNormalPDF.TxtSalarioINSS.Text = formFolhaNormal.TxtSalarioBaseINSS.Text;
            formNormalPDF.TxtINSSValor.Text = formFolhaNormal.TxtValorInss.Text;
            formNormalPDF.TxtDescTotalINSS.Text = formFolhaNormal.TxtTotalInss.Text;

            formNormalPDF.TxtTaxaDescIRRF.Text = formFolhaNormal.TxtTaxaDescIRRF.Text;
            formNormalPDF.TxtDescIRRF.Text = formFolhaNormal.TxtDescIRRF.Text;
            formNormalPDF.TxtSalarioBaseIRRF.Text = formFolhaNormal.TxtSalarioBaseIRRF.Text;
            formNormalPDF.TxtValorIRRF.Text = formFolhaNormal.TxtValorIRRF.Text;
            formNormalPDF.TxtTotalIRRF.Text = formFolhaNormal.TxtTotalIRRF.Text;

            formNormalPDF.TxtTaxaFGTS.Text = formFolhaNormal.TxtTaxaDescFGTS.Text;
            formNormalPDF.TxtSalarioBaseFGTS.Text = formFolhaNormal.TxtSalarioBaseFGTS.Text;
            formNormalPDF.TxtValorFGTS.Text = formFolhaNormal.TxtValorFGTS.Text;
            formNormalPDF.TxtTotalFGTS.Text = formFolhaNormal.TxtTotalFGTS.Text;

            formNormalPDF.TxtMaiorRemuneracao.Text = formFolhaNormal.TxtMaiorRemuneracao.Text;
            formNormalPDF.TxtSalarioLiqMensal.Text = formFolhaNormal.TxtSalarioLiqMensal.Text;
            formNormalPDF.TxtDataLancamento.Text = formFolhaNormal.TxtDataEmissao.Text;
            formNormalPDF.TxtDataEmissao.Text = formFolhaNormal.TxtDataEmissao.Text;

            formNormalPDF.TxtID.Visible = false;
            formNormalPDF.TxtVencimentos.Text = formFolhaNormal.TxtVencimentos.Text;
            formNormalPDF.TxtTotaisDescontos.Text = formFolhaNormal.TxtTotaisDescontos.Text;
            formNormalPDF.TxtSalarioLiquido.Text = formFolhaNormal.TxtSalarioLiquido.Text;

            formNormalPDF.LbClt.Text = formFolhaNormal.TxtCLT.Text;
            formNormalPDF.LbAtivos.Text = formFolhaNormal.TxtAtivo.Text;
        }
    }
}
