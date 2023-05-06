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
    public partial class FormFolhaNormalPesq : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormFolhaNormalPesq(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C_SomaFolhaNormal c_SomaFolhaNormal = new C_SomaFolhaNormal();
            // MessageBox.Show(c_SomaFolhaNormal.sumTaxaIRRFId("2023", "05", "2").ToString()); // retorna quantiadde da multiplicação ex: se retorno for 4 e o id 2, id2 = 7, 7x5 = 35
            c_SomaFolhaNormal.sumTotal("2023", "05");
        }
    }
}
