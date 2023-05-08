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
        private void CbAno_DropDown(object sender, EventArgs e)
        {
            C_FolhaNormalPesq c_FolhaNormal = new C_FolhaNormalPesq();
            c_FolhaNormal.getYearFolhaNormal(CbAno);
        }

        private void CbAno_TextChanged(object sender, EventArgs e)
        {
            C_FolhaNormalPesq c_FolhaNormalPesq = new C_FolhaNormalPesq();
            c_FolhaNormalPesq.getMonthFolhaNormal(CbMes, CbAno.Text);

        }

        private void CbMes_TextChanged(object sender, EventArgs e)
        {
            C_FolhaNormalPesq c_FolhaNormalPesq = new C_FolhaNormalPesq();
            c_FolhaNormalPesq.ShowFolhaNormalPesq(this);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você está prestes a sair desta página.\nTem certeza?", "Sair da Página", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}