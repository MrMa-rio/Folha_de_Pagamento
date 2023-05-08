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
    public partial class FormHoleritePDF : Form
    {
        FormHolerite FormHolerite;
        FormHoleriteFunc FormHoleriteFunc;

        public FormHoleritePDF()
        {
            InitializeComponent();
        }
        public FormHoleritePDF(FormHolerite formHolerite) : this()
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.WriterHolerite(this, formHolerite);
        }
        public FormHoleritePDF(FormHoleriteFunc formHoleriteFunc) : this()
        {
            C_PrintPDF c_PrintPDF = new C_PrintPDF();
            c_PrintPDF.WriterHolerite(this, formHoleriteFunc);

        }
    }
}
