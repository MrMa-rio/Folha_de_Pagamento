﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOLHA_DE_PAGAMENTO_.src.Classes;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormFolhaNormal : Form
    {
        private FormNavBar FormAtivo;
        private C_FormNavBarShow navBarShow = new C_FormNavBarShow();
        public FormFolhaNormal( FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
        }
    }
}