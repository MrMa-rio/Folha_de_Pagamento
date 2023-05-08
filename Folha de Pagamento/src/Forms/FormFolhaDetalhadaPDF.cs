using FOLHA_DE_PAGAMENTO_.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    public partial class FormFolhaDetalhadaPDF : Form
    {
        public FormFolhaDetalhadaPDF()
        {
            InitializeComponent();
        }
        public FormFolhaDetalhadaPDF(FormFolhaDetalhadaPesq folhaDetalhadaPesq) : this()
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.WriterFolhaDetalhada(this, folhaDetalhadaPesq);
        }
        public FormFolhaDetalhadaPDF(FormFolhaDetalhada folhaDetalhada) : this()
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.WriterFolhaDetalhada(this, folhaDetalhada);
        }
    }
}
