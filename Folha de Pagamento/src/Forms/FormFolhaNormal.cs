using FOLHA_DE_PAGAMENTO_.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormFolhaNormal : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();

        public FormFolhaNormal(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;

        }

        private void AllForms_MouseClick(object sender, MouseEventArgs e)
        {
            navBarShow.AnimationHide(FormAtivo, FormAtivo.Pnl2);
        }

        private void BtnImprimir_MouseClick(object sender, MouseEventArgs e)
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.printPdf(PanelFolhaDetalhada);

            
        }
    }
}
