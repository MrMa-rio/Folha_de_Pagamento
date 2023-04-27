﻿using FOLHA_DE_PAGAMENTO_.src.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_FormShow
    {
        public Form setFormShow(Form ScreenTarget, Form Nav, Form NavClose)
        {
            ScreenTarget.Controls.Remove(NavClose);
            Nav.TopLevel = false;
            ScreenTarget.Controls.Add(Nav);
            Nav.Dock = DockStyle.Fill;
            Nav.Show();
            return Nav;
        }
        public void setFormCard(FormPesquisar formPesquisar, FormCard formCard)
        {
            formCard.TopLevel = false;
            formPesquisar.PanelPesquisar.Controls.Add(formCard);
            formCard.Dock = DockStyle.Top;
            formCard.Show();
        }
    }
}
