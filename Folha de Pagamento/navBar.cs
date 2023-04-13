using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamento
{
    public partial class navBar : Form
    {
        private ScreenHome FrmAtivo;
        Cadastro cadastro = new Cadastro();
        Relatorio relatorio = new Relatorio();
        Form teste;
        public navBar()
        {
            InitializeComponent();
        }
        public navBar(ScreenHome forms) :this()
        {
            FrmAtivo = forms;
        }
        private void btn_arrow_left_MouseEnter(object sender, EventArgs e)
        {
            BtnArrowLeft.BackColor = Color.White;
        }

        private void btn_arrow_left_MouseLeave(object sender, EventArgs e)
        {
            BtnArrowLeft.BackColor = Color.Transparent;
        }

        private void btn_arrow_left_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
        private void gerenciamento_MouseClick(object sender, MouseEventArgs e)
        {
            FormShow formShow = new FormShow();

            teste = formShow.setFormShow(FrmAtivo, cadastro,teste);
        }
        private void Relatorio_MouseClick(object sender, MouseEventArgs e)
        {
            FormShow formShow = new FormShow();

            teste = formShow.setFormShow(FrmAtivo, relatorio, teste);
        }
    }
}
