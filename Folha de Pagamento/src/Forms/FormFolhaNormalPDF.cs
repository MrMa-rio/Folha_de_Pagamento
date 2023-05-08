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
    public partial class FormFolhaNormalPDF : Form
    {
        public FormFolhaNormalPDF()
        {
            InitializeComponent();
        }
        public FormFolhaNormalPDF(FormFolhaNormalPesq formFolhaNormalPesq) : this()
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.WriterFolhaNormal(this, formFolhaNormalPesq);
        }
        public FormFolhaNormalPDF(FormFolhaNormal formFolhaNormal) : this()
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.WriterFolhaNormal(this, formFolhaNormal);
        }
    }
}
