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
    public partial class FormHoleriteFunc : Form
    {
        string Matricula;
        C_ShowHoleriteFunc c_ShowHoleriteFunc = new C_ShowHoleriteFunc();
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormHoleriteFunc(string matricula, FormNavBar formNavBar)
        {
            InitializeComponent();
            FormAtivo = formNavBar;
            Matricula = matricula;

            c_ShowHoleriteFunc.getYear(Matricula, CbAno);
        }

        private void CbAno_TextChanged(object sender, EventArgs e)
        {
            CbMes.Text = string.Empty;
            if (CbAno.Text.Trim() != "")
            {
                c_ShowHoleriteFunc.getMonth(Matricula, CbAno.Text, CbMes);
            }
        }

        private void CbMes_TextChanged(object sender, EventArgs e)
        {

            if (CbAno.Text.Trim() != "" && CbMes.Text.Trim() != "")
            {
                c_ShowHoleriteFunc.showDataHolerite(Matricula, CbAno.Text, CbMes.Text, this);
            }
        }
    }
}
