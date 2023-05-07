using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_privateArea
    {
        
        public void setNvlAcesso(string NvlAcesso)
        {
            
            int NivelAcesso = Convert.ToInt32(NvlAcesso);

            if(NivelAcesso == 1)
            {
                showCRUDCargo();
                setNvl2NavBar();
                setNvl1NavBar();
            }
            if(NivelAcesso > 1 && NvlAcesso != null)
            {
                if(NivelAcesso == 2)
                {
                    setNvl2NavBar();
                }
                if(NivelAcesso == 3)
                {
                    setNvl3NavBar();
                }
            }
        }

        public void setDeleteFuncNvl1(Button DeleteFunc, int nvlAcesso)
        {
            if(nvlAcesso == 1)
            {
                DeleteFunc.Visible = true;
            }
            else
            {
                DeleteFunc.Visible = false;
            }
        }

        public void showCRUDCargo()
        {
            FormNavBar formNavbar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
            formNavbar.BtnCargosFun.Visible = true;
            
        }
        public void setNvl1NavBar()
        {
            FormNavBar formNavbar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
            formNavbar.BtnCargosFun.Visible = true;
            formNavbar.BtnPesquisar.Location = new Point(35, 148);
            formNavbar.BtnHolerite.Location = new Point(35, 245);
            formNavbar.BtnHoleriteFunc.Visible = false;
        }
        public void setNvl2NavBar()
        {
            FormNavBar formNavbar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
            formNavbar.BtnGerenciamento.Visible = true;
            formNavbar.PanelSubMenu.Visible = true;
            formNavbar.PanelSubMenuRel.Visible = true;
            formNavbar.PanelSubMenu.Visible = true;
            foreach (Control control in formNavbar.PanelSubMenuRel.Controls)
            {
                if (control is Button)
                {
                    control.Visible = true;
                }
            }
            formNavbar.BtnCargosFun.Visible = false;
            formNavbar.BtnPesquisar.Location = new Point(35, 102);
            formNavbar.BtnHolerite.Location = new Point(35, 245);
            formNavbar.BtnHoleriteFunc.Visible = false;
            formNavbar.BtnHolerite.Visible = true;
        }

        public void setNvl3NavBar()
        {
            FormNavBar formNavbar = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
            formNavbar.BtnGerenciamento.Visible = false;
            formNavbar.PanelSubMenu.Visible = false;

            foreach (Control control in formNavbar.PanelSubMenuRel.Controls)
            {
                if (control is Button)
                {
                    control.Visible = false;
                }
            }
            formNavbar.BtnHoleriteFunc.Visible = true;
            formNavbar.BtnHolerite.Visible = false;
            formNavbar.BtnHoleriteFunc.Location = new Point(35, 11);
        }
    }
}


//Nivel de Acesso 1
/*
    Alterar Valores dos Salarios e Taxas do Calculo de Pagamento
    Ele e ó ele podera criar apagar e alterar cargo
    Deletar Funcionario 
 */
