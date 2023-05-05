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
    }
}
