
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Drawing2D;
using MySqlX.XDevAPI.Relational;
using FOLHA_DE_PAGAMENTO_.src.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.PDF
{
    internal class C_GerarPDF
    {

        public void imprimirPDF(FormHolerite formHolerite)
        {
            var doc = new Document();

            doc.SetMargins(60, 60, 60, 60);
            doc.AddCreationDate();
            PdfWriter.GetInstance(doc, new FileStream($@"C:\Users\Mario\Downloads\{formHolerite.TxtMatricula.Text}_{formHolerite.TxtMes.Text}_{formHolerite.TxtAno.Text}.pdf", FileMode.Create));


            doc.Open();


            Paragraph cabeçalho = new Paragraph();
            cabeçalho.Alignment = Element.ALIGN_CENTER;
            cabeçalho.Add("Folha de Pagamento Detalhada: \n \n");
            doc.Add(cabeçalho);

            //formHolerite.TxtMes.Text
            //formHolerite.TxtAno.Text

            Paragraph coluna0 = new Paragraph("");
            Paragraph coluna1 = new Paragraph(" \t Jose Antonio Alves Carneiro ME \n \n \t CNPJ: \t 13.545.586/0001-11 \n \n");
            Paragraph coluna2 = new Paragraph($" \t {formHolerite.TxtNome.Text} \n \n \t {formHolerite.TxtCargo.Text} \b \b \b \b  Admissao: \t {formHolerite.TxtDataAdmissao.Text.Substring(0, 10)} \n \n");
            Paragraph coluna3 = new Paragraph("Codigo");
            Paragraph coluna4 = new Paragraph("Descriçao");
            Paragraph coluna5 = new Paragraph("Referencia");
            Paragraph coluna6 = new Paragraph("Vencimentos");
            Paragraph coluna7 = new Paragraph("Descontos");
            Paragraph coluna8 = new Paragraph("");
            coluna8.Add(new Phrase("--\n\n"));
            coluna8.Add(new Phrase($"{formHolerite.TxtIDINSS.Text}\n\n"));
            coluna8.Add(new Phrase($"{formHolerite.TxtIDIRRF.Text} \n\n"));
            coluna8.Add(new Phrase($"{formHolerite.TxtIdFGTS.Text} \n\n"));
            coluna8.Add(new Phrase("\n"));
            coluna8.Add(new Phrase("\n"));
            coluna8.Add(new Phrase("\n"));
            coluna8.Add(new Phrase("\n"));
            Paragraph coluna9 = new Paragraph("");
            coluna9.Add(new Phrase("Horas Normais \n\n"));
            coluna9.Add(new Phrase("I.N.S.S.\n\n"));
            coluna9.Add(new Phrase("Imposto de Renda \n\n"));
            coluna9.Add(new Phrase("F.G.T.S. \n\n"));
            coluna9.Add(new Phrase("\n"));
            coluna9.Add(new Phrase("\n"));
            coluna9.Add(new Phrase("\n"));
            coluna9.Add(new Phrase("\n"));
            Paragraph coluna10 = new Paragraph("");
            coluna10.Add(new Phrase("200 \n\n"));
            coluna10.Add(new Phrase($"{formHolerite.TaxaINSS.Text}\n\n"));
            coluna10.Add(new Phrase($"{formHolerite.TaxaIRRF.Text} \n"));
            coluna10.Add(new Phrase($"{formHolerite.TaxaFGTS.Text} \n"));
            coluna10.Add(new Phrase("\n"));
            coluna10.Add(new Phrase("\n"));
            coluna10.Add(new Phrase("\n"));
            coluna10.Add(new Phrase("\n"));
            Paragraph coluna11 = new Paragraph("");
            coluna11.Add(new Phrase($"{formHolerite.TxtSalarioBase.Text} \n\n"));
            coluna11.Add(new Phrase("\n\n"));
            coluna11.Add(new Phrase("\n\n"));
            coluna11.Add(new Phrase("\n"));
            coluna11.Add(new Phrase("\n"));
            coluna11.Add(new Phrase("\n"));
            coluna11.Add(new Phrase("\n"));
            Paragraph coluna12 = new Paragraph("");
            coluna12.Add(new Phrase(" \n\n"));
            coluna12.Add(new Phrase($"{formHolerite.DescINSS.Text}  \n\n\n"));
            coluna12.Add(new Phrase($"{formHolerite.DescIRRF.Text} \n\n"));
            
            coluna12.Add(new Phrase("\n"));
            coluna12.Add(new Phrase("\n"));
            coluna12.Add(new Phrase("\n"));
            coluna12.Add(new Phrase("\n"));
            Paragraph coluna13 = new Paragraph(" \t total de vencimentos \n ");
            coluna13.Add(new Phrase($"{formHolerite.TxtVencTotal.Text}"));
            Paragraph coluna14 = new Paragraph(" \t total de desconto \n");
            coluna14.Add(new Phrase($"{formHolerite.TxtDescTotal.Text}"));
            Paragraph coluna15 = new Paragraph(" \t Valor Liquido->");
            Paragraph coluna16 = new Paragraph($" \t {formHolerite.TxtValorLiquido.Text}");
            Paragraph coluna17 = new Paragraph("Salario Base");
            coluna17.Add(new Phrase($"{formHolerite.TxtSalarioBase.Text}"));
            Paragraph coluna23 = new Paragraph("  Sal Contr INSS");
            coluna23.Add(new Phrase($"{formHolerite.TxtSalarioBase.Text}"));
            Paragraph coluna18 = new Paragraph("  Base Calc FGTS");
            coluna18.Add(new Phrase($" {formHolerite.TxtSalarioBase.Text}"));
            Paragraph coluna19 = new Paragraph("  FGTS do Mes");
            coluna19.Add(new Phrase($" {formHolerite.TxtFgtsMes.Text}"));
            Paragraph coluna20 = new Paragraph("  Base Calc IRRF");
            coluna20.Add(new Phrase($" {formHolerite.TxtBaseirrf.Text}"));
            Paragraph coluna21 = new Paragraph(" Faixa IRRF");
            coluna21.Add(new Phrase($" {formHolerite.TaxaIRRF.Text}"));
            Paragraph coluna22 = new Paragraph(" Declaro ter recebido a importancia liquida descrita nesse recibo \n ");
            coluna22.Add(new Phrase(" __/__/____  \t  \t  \t  _______________________ \n "));
            coluna22.Add(new Phrase(" "));

            PdfPTable Empresa = new PdfPTable(5);
            Empresa.WidthPercentage = 100f;
            Empresa.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            Empresa.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell4 = new PdfPCell(coluna1);
            cell4.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            cell4.Rowspan = 2;
            cell4.Colspan = 5;

            Empresa.AddCell(cell4);

            PdfPTable nomeempregado = new PdfPTable(5);
            nomeempregado.WidthPercentage = 100f;
            nomeempregado.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            nomeempregado.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell5 = new PdfPCell(coluna2);
            cell5.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            cell5.Rowspan = 2;
            cell5.Colspan = 5;
            nomeempregado.AddCell(cell5);


            PdfPTable descriçao = new PdfPTable(5);
            descriçao.WidthPercentage = 100f;
            descriçao.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            descriçao.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;



            PdfPCell cell6 = new PdfPCell(coluna3);
            cell6.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell7 = new PdfPCell(coluna4);
            cell7.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell8 = new PdfPCell(coluna5);
            cell8.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell9 = new PdfPCell(coluna6);
            cell9.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell10 = new PdfPCell(coluna7);
            cell10.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            descriçao.AddCell(cell6);
            descriçao.AddCell(cell7);
            descriçao.AddCell(cell8);
            descriçao.AddCell(cell9);
            descriçao.AddCell(cell10);

            PdfPTable informaçoes = new PdfPTable(5);
            informaçoes.WidthPercentage = 100f;
            informaçoes.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            informaçoes.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell11 = new PdfPCell(coluna8);
            cell11.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell12 = new PdfPCell(coluna9);
            cell12.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell13 = new PdfPCell(coluna10);
            cell13.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell14 = new PdfPCell(coluna11);
            cell14.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell15 = new PdfPCell(coluna12);
            cell15.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            informaçoes.AddCell(cell11);
            informaçoes.AddCell(cell12);
            informaçoes.AddCell(cell13);
            informaçoes.AddCell(cell14);
            informaçoes.AddCell(cell15);

            PdfPTable rodape = new PdfPTable(5);
            rodape.WidthPercentage = 100f;
            rodape.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            rodape.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell16 = new PdfPCell(coluna0);
            cell16.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER;
            cell16.Rowspan = 2;
            cell16.Colspan = 3;
            PdfPCell cell17 = new PdfPCell(coluna13);
            cell17.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            PdfPCell cell18 = new PdfPCell(coluna14);
            cell18.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;

            rodape.AddCell(cell16);
            rodape.AddCell(cell17);
            rodape.AddCell(cell18);


            PdfPTable roda = new PdfPTable(5);
            roda.WidthPercentage = 100f;
            roda.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            roda.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell19 = new PdfPCell(coluna0);
            cell19.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER;
            cell19.Rowspan = 2;
            cell19.Colspan = 3;
            PdfPCell cell20 = new PdfPCell(coluna15);
            cell20.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            PdfPCell cell21 = new PdfPCell(coluna16);
            cell21.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;

            roda.AddCell(cell19);
            roda.AddCell(cell20);
            roda.AddCell(cell21);

            PdfPTable ro = new PdfPTable(6);
            ro.WidthPercentage = 100f;

            ro.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;
            PdfPCell cell22 = new PdfPCell(coluna17);
            cell22.Border = PdfPCell.LEFT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell28 = new PdfPCell(coluna23);
            cell28.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell23 = new PdfPCell(coluna18);
            cell23.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell24 = new PdfPCell(coluna19);
            cell24.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell25 = new PdfPCell(coluna20);
            cell25.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell26 = new PdfPCell(coluna21);
            cell26.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER | PdfPCell.RIGHT_BORDER;

            ro.AddCell(cell22);
            ro.AddCell(cell28);
            ro.AddCell(cell23);
            ro.AddCell(cell24);
            ro.AddCell(cell25);
            ro.AddCell(cell26);

            PdfPTable data = new PdfPTable(1);
            data.WidthPercentage = 100f;
            data.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;


            PdfPCell cell27 = new PdfPCell(coluna22);
            cell27.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            //PdfPCell cell28 = new PdfPCell(coluna0);
            //cell28.Border = PdfPCell.LEFT_BORDER | PdfPCell.BOTTOM_BORDER;

            data.AddCell(cell27);
            //data.AddCell(cell28);



            doc.Add(Empresa);
            doc.Add(nomeempregado);
            doc.Add(descriçao);
            doc.Add(informaçoes);
            doc.Add(rodape);
            doc.Add(roda);
            doc.Add(ro);
            doc.Add(data);

            doc.NewPage();
            doc.Add(Empresa);
            doc.Add(nomeempregado);
            doc.Add(descriçao);
            doc.Add(informaçoes);
            doc.Add(rodape);
            doc.Add(roda);
            doc.Add(ro);
            doc.Add(data);

            doc.Close();
        }

        public void imprimirPDF(FormHoleriteFunc formHolerite)
        {
            var doc = new Document();

            doc.SetMargins(60, 60, 60, 60);
            doc.AddCreationDate();
            PdfWriter.GetInstance(doc, new FileStream($@"C:\Users\Mario\Downloads\{formHolerite.TxtMatricula.Text}_{formHolerite.TxtMes.Text}_{formHolerite.TxtAno.Text}.pdf", FileMode.Create));


            doc.Open();


            Paragraph cabeçalho = new Paragraph();
            cabeçalho.Alignment = Element.ALIGN_CENTER;
            cabeçalho.Add("Folha de Pagamento Detalhada: \n \n");
            doc.Add(cabeçalho);

            //formHolerite.TxtMes.Text
            //formHolerite.TxtAno.Text

            Paragraph coluna0 = new Paragraph("");
            Paragraph coluna1 = new Paragraph(" \t Jose Antonio Alves Carneiro ME \n \n \t CNPJ: \t 13.545.586/0001-11 \n \n");
            Paragraph coluna2 = new Paragraph($" \t {formHolerite.TxtNome.Text} \n \n \t {formHolerite.TxtCargo.Text} \b \b \b \b  Admissao: \t {formHolerite.TxtDataAdmissao.Text.Substring(0, 10)} \n \n");
            Paragraph coluna3 = new Paragraph("Codigo");
            Paragraph coluna4 = new Paragraph("Descriçao");
            Paragraph coluna5 = new Paragraph("Referencia");
            Paragraph coluna6 = new Paragraph("Vencimentos");
            Paragraph coluna7 = new Paragraph("Descontos");
            Paragraph coluna8 = new Paragraph("");
            coluna8.Add(new Phrase("--\n\n"));
            coluna8.Add(new Phrase($"{formHolerite.TxtIDINSS.Text}\n\n"));
            coluna8.Add(new Phrase($"{formHolerite.TxtIDIRRF.Text} \n\n"));
            coluna8.Add(new Phrase($"{formHolerite.TxtIdFGTS.Text} \n\n"));
            coluna8.Add(new Phrase("\n"));
            coluna8.Add(new Phrase("\n"));
            coluna8.Add(new Phrase("\n"));
            coluna8.Add(new Phrase("\n"));
            Paragraph coluna9 = new Paragraph("");
            coluna9.Add(new Phrase("Horas Normais \n\n"));
            coluna9.Add(new Phrase("I.N.S.S.\n\n"));
            coluna9.Add(new Phrase("Imposto de Renda \n\n"));
            coluna9.Add(new Phrase("F.G.T.S. \n\n"));
            coluna9.Add(new Phrase("\n"));
            coluna9.Add(new Phrase("\n"));
            coluna9.Add(new Phrase("\n"));
            coluna9.Add(new Phrase("\n"));
            Paragraph coluna10 = new Paragraph("");
            coluna10.Add(new Phrase("200 \n\n"));
            coluna10.Add(new Phrase($"{formHolerite.TaxaINSS.Text}\n\n"));
            coluna10.Add(new Phrase($"{formHolerite.TaxaIRRF.Text} \n"));
            coluna10.Add(new Phrase($"{formHolerite.TaxaFGTS.Text} \n"));
            coluna10.Add(new Phrase("\n"));
            coluna10.Add(new Phrase("\n"));
            coluna10.Add(new Phrase("\n"));
            coluna10.Add(new Phrase("\n"));
            Paragraph coluna11 = new Paragraph("");
            coluna11.Add(new Phrase($"{formHolerite.TxtSalarioBase.Text} \n\n"));
            coluna11.Add(new Phrase("\n\n"));
            coluna11.Add(new Phrase("\n\n"));
            coluna11.Add(new Phrase("\n"));
            coluna11.Add(new Phrase("\n"));
            coluna11.Add(new Phrase("\n"));
            coluna11.Add(new Phrase("\n"));
            Paragraph coluna12 = new Paragraph("");
            coluna12.Add(new Phrase(" \n\n"));
            coluna12.Add(new Phrase($"{formHolerite.DescINSS.Text}  \n\n\n"));
            coluna12.Add(new Phrase($"{formHolerite.DescIRRF.Text} \n\n"));

            coluna12.Add(new Phrase("\n"));
            coluna12.Add(new Phrase("\n"));
            coluna12.Add(new Phrase("\n"));
            coluna12.Add(new Phrase("\n"));
            Paragraph coluna13 = new Paragraph(" \t total de vencimentos \n ");
            coluna13.Add(new Phrase($"{formHolerite.TxtVencTotal.Text}"));
            Paragraph coluna14 = new Paragraph(" \t total de desconto \n");
            coluna14.Add(new Phrase($"{formHolerite.TxtDescTotal.Text}"));
            Paragraph coluna15 = new Paragraph(" \t Valor Liquido->");
            Paragraph coluna16 = new Paragraph($" \t {formHolerite.TxtValorLiquido.Text}");
            Paragraph coluna17 = new Paragraph("Salario Base");
            coluna17.Add(new Phrase($"{formHolerite.TxtSalarioBase.Text}"));
            Paragraph coluna23 = new Paragraph("  Sal Contr INSS");
            coluna23.Add(new Phrase($"{formHolerite.TxtSalarioBase.Text}"));
            Paragraph coluna18 = new Paragraph("  Base Calc FGTS");
            coluna18.Add(new Phrase($" {formHolerite.TxtSalarioBase.Text}"));
            Paragraph coluna19 = new Paragraph("  FGTS do Mes");
            coluna19.Add(new Phrase($" {formHolerite.TxtFgtsMes.Text}"));
            Paragraph coluna20 = new Paragraph("  Base Calc IRRF");
            coluna20.Add(new Phrase($" {formHolerite.TxtBaseirrf.Text}"));
            Paragraph coluna21 = new Paragraph(" Faixa IRRF");
            coluna21.Add(new Phrase($" {formHolerite.TaxaIRRF.Text}"));
            Paragraph coluna22 = new Paragraph(" Declaro ter recebido a importancia liquida descrita nesse recibo \n ");
            coluna22.Add(new Phrase(" __/__/____  \t  \t  \t  _______________________ \n "));
            coluna22.Add(new Phrase(" "));

            PdfPTable Empresa = new PdfPTable(5);
            Empresa.WidthPercentage = 100f;
            Empresa.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            Empresa.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell4 = new PdfPCell(coluna1);
            cell4.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            cell4.Rowspan = 2;
            cell4.Colspan = 5;

            Empresa.AddCell(cell4);

            PdfPTable nomeempregado = new PdfPTable(5);
            nomeempregado.WidthPercentage = 100f;
            nomeempregado.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            nomeempregado.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell5 = new PdfPCell(coluna2);
            cell5.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            cell5.Rowspan = 2;
            cell5.Colspan = 5;
            nomeempregado.AddCell(cell5);


            PdfPTable descriçao = new PdfPTable(5);
            descriçao.WidthPercentage = 100f;
            descriçao.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            descriçao.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;



            PdfPCell cell6 = new PdfPCell(coluna3);
            cell6.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell7 = new PdfPCell(coluna4);
            cell7.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell8 = new PdfPCell(coluna5);
            cell8.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell9 = new PdfPCell(coluna6);
            cell9.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            PdfPCell cell10 = new PdfPCell(coluna7);
            cell10.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            descriçao.AddCell(cell6);
            descriçao.AddCell(cell7);
            descriçao.AddCell(cell8);
            descriçao.AddCell(cell9);
            descriçao.AddCell(cell10);

            PdfPTable informaçoes = new PdfPTable(5);
            informaçoes.WidthPercentage = 100f;
            informaçoes.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            informaçoes.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell11 = new PdfPCell(coluna8);
            cell11.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell12 = new PdfPCell(coluna9);
            cell12.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell13 = new PdfPCell(coluna10);
            cell13.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell14 = new PdfPCell(coluna11);
            cell14.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell15 = new PdfPCell(coluna12);
            cell15.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            informaçoes.AddCell(cell11);
            informaçoes.AddCell(cell12);
            informaçoes.AddCell(cell13);
            informaçoes.AddCell(cell14);
            informaçoes.AddCell(cell15);

            PdfPTable rodape = new PdfPTable(5);
            rodape.WidthPercentage = 100f;
            rodape.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            rodape.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell16 = new PdfPCell(coluna0);
            cell16.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER;
            cell16.Rowspan = 2;
            cell16.Colspan = 3;
            PdfPCell cell17 = new PdfPCell(coluna13);
            cell17.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            PdfPCell cell18 = new PdfPCell(coluna14);
            cell18.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;

            rodape.AddCell(cell16);
            rodape.AddCell(cell17);
            rodape.AddCell(cell18);


            PdfPTable roda = new PdfPTable(5);
            roda.WidthPercentage = 100f;
            roda.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });
            roda.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;

            PdfPCell cell19 = new PdfPCell(coluna0);
            cell19.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER;
            cell19.Rowspan = 2;
            cell19.Colspan = 3;
            PdfPCell cell20 = new PdfPCell(coluna15);
            cell20.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;
            PdfPCell cell21 = new PdfPCell(coluna16);
            cell21.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.TOP_BORDER | PdfPCell.BOTTOM_BORDER;

            roda.AddCell(cell19);
            roda.AddCell(cell20);
            roda.AddCell(cell21);

            PdfPTable ro = new PdfPTable(6);
            ro.WidthPercentage = 100f;

            ro.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;
            PdfPCell cell22 = new PdfPCell(coluna17);
            cell22.Border = PdfPCell.LEFT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell28 = new PdfPCell(coluna23);
            cell28.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell23 = new PdfPCell(coluna18);
            cell23.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell24 = new PdfPCell(coluna19);
            cell24.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell25 = new PdfPCell(coluna20);
            cell25.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;
            PdfPCell cell26 = new PdfPCell(coluna21);
            cell26.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER | PdfPCell.RIGHT_BORDER;

            ro.AddCell(cell22);
            ro.AddCell(cell28);
            ro.AddCell(cell23);
            ro.AddCell(cell24);
            ro.AddCell(cell25);
            ro.AddCell(cell26);

            PdfPTable data = new PdfPTable(1);
            data.WidthPercentage = 100f;
            data.DefaultCell.BorderWidth = PdfPCell.NO_BORDER;


            PdfPCell cell27 = new PdfPCell(coluna22);
            cell27.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER | PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER;

            //PdfPCell cell28 = new PdfPCell(coluna0);
            //cell28.Border = PdfPCell.LEFT_BORDER | PdfPCell.BOTTOM_BORDER;

            data.AddCell(cell27);
            //data.AddCell(cell28);



            doc.Add(Empresa);
            doc.Add(nomeempregado);
            doc.Add(descriçao);
            doc.Add(informaçoes);
            doc.Add(rodape);
            doc.Add(roda);
            doc.Add(ro);
            doc.Add(data);

            doc.NewPage();
            doc.Add(Empresa);
            doc.Add(nomeempregado);
            doc.Add(descriçao);
            doc.Add(informaçoes);
            doc.Add(rodape);
            doc.Add(roda);
            doc.Add(ro);
            doc.Add(data);

            doc.Close();
        }
        public void printPDF(FormHolerite formHolerite)
        {
            imprimirPDF(formHolerite);
        }

    }
}
