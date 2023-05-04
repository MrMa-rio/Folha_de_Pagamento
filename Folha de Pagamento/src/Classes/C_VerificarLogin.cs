using FOLHA_DE_PAGAMENTO_.src.Forms;
using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_VerificarLogin
    {
        public void statusLogin(string user, string password, FormLogin formLogin)
        {
            C_Verificalogin c_Verificalogin = new C_Verificalogin();
            List<string[]> Results = c_Verificalogin.setLogin(user, password);
            
            if(Results.Count == 1)
            {
                FormHome formPrincipal = Application.OpenForms.OfType<FormHome>().FirstOrDefault();
                formPrincipal.DataUser = Results[0];
                formPrincipal.BtnMenu.Visible = true;
                formLogin.Close();
            }
        }
        public void logout(FormHome formPrincipal, FormNavBar formNavBar)
        {
            FormNavBar formPrincipal_ = Application.OpenForms.OfType<FormNavBar>().FirstOrDefault();
            FormNavBar formNav = new FormNavBar(formPrincipal);
            C_showLogin showLogin = new C_showLogin();
            C_FormShow c_FormShow = new C_FormShow();
            formPrincipal.BtnMenu.Visible =false;
            FormLogin formLogin = new FormLogin(formPrincipal);
            showLogin.ShowLogin(formPrincipal);

            formPrincipal_.Refresh();
        }
    }
}

//Esta ocorrendo um bug onde se existe uma matricula valida, ele esta liberando acesso à navBar
//sabendo que isso nao pode ocorrer.
//Escrever um metodo onde ele comece a impor niveis de acesso a cada parte dos menus.
//melhore as estruturas dos niveis de login entre outros.
