﻿using FOLHA_DE_PAGAMENTO_.src.Classes;
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
    public partial class FormShowDadosCadastrais : Form
    {
        private string[] Result;

        public FormShowDadosCadastrais()
        {
            InitializeComponent();

        }
        public FormShowDadosCadastrais(string[] result) : this()
        {
            Result = result;
        }
        private void FormShowDadosCadastrais_Load(object sender, EventArgs e)
        {

            TxtNomeCompleto.Text = Result[1];
            TxtCpf.Text = Result[0];
            TxtRg.Text = Result[4];
            TxtGenero.Text = Result[3];
            TxtCargo.Text = Result[10];
            TxtDataAdmissao.Text = Result[11];

        }

        private void BtnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
