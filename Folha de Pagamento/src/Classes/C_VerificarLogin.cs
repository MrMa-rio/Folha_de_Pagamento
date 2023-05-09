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
                formPrincipal.BtnPerfil.Visible =true;
                formPrincipal.BtnSetting.Visible = true;
                formLogin.Close();
            }
        }
        public void logout(FormHome formPrincipal)
        {
            formPrincipal.PnlPerfil.Visible = false;
            C_showLogin showLogin = new C_showLogin();
            formPrincipal.BtnMenu.Visible = false;
            showLogin.ShowLogin(formPrincipal);
        }
        public void logoutPerfil(FormHome formPrincipal)
        {
            formPrincipal.PnlPerfil.Visible = false;
            C_showLogin showLogin = new C_showLogin();
            showLogin.ShowLogin(formPrincipal);
            formPrincipal.BtnMenu.Visible = false;
        }
    }
}