using FOLHA_DE_PAGAMENTO_.src.Servidor.GET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_ShowPerfilUser
    {
        public void ShowPerfil(Panel PnlPerfil, string[] DataUser, PictureBox PboxPerfil, FormHome formHome)
        {
            C_ManipulaçãoImagens c_ManipulaçãoImagens = new C_ManipulaçãoImagens();
            C_handleCargoSalarioDepartamento c_HandleCargoDepartamento = new C_handleCargoSalarioDepartamento();

            string Matricula = DataUser[0].ToString();
            string Nome = DataUser[1].ToString();
            string FK_Departamento = c_HandleCargoDepartamento.getIdDepartamento( DataUser[2].ToString() );
            string FK_Cargo =  c_HandleCargoDepartamento.getIdCargo( DataUser[3].ToString() );
            string NvlAcesso = DataUser[4].ToString();
            string Status = DataUser[5].ToString();
            if (PnlPerfil.Visible)
            {
                PnlPerfil.Visible = false;
            }
            else
            {
                PnlPerfil.Visible = true;
            }
            if (DataUser.Length > 1)
            {
                formHome.label1.Text = Matricula;
                formHome.label2.Text = Nome; 
                formHome.label3.Text = FK_Departamento; 
                formHome.label4.Text = FK_Cargo; 
                formHome.label5.Text = NvlAcesso; 
                formHome.label6.Text = Status;
            }
            if (!c_ManipulaçãoImagens.getImagemUser(PboxPerfil, DataUser[0]))
            {
                PboxPerfil.BackgroundImage = Properties.Resources.circle_account1;
            }
        }
    }
}
