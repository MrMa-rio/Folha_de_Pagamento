using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_ValidadorCPF
    {
        public bool ValidarCPF(string cpf)
        {
            //cpf = Regex.Replace(cpf, "[^0-9]+", ""); // replace anything that is not a digit with ""
            //if (cpf == "") return false;

            //// Elimina CPFs invalidos conhecidos
            //if (cpf.Length != 11 ||
            //    cpf == "00000000000" ||
            //    cpf == "11111111111" ||
            //    cpf == "22222222222" ||
            //    cpf == "33333333333" ||
            //    cpf == "44444444444" ||
            //    cpf == "55555555555" ||
            //    cpf == "66666666666" ||
            //    cpf == "77777777777" ||
            //    cpf == "88888888888" ||
            //    cpf == "99999999999")
            //    return false;

            //// Valida 1o digito
            //int add = 0;
            //for (int i = 0; i < 9; i++)
            //    add += int.Parse(cpf[i].ToString()) * (10 - i);
            //int rev = 11 - add % 11;
            //if (rev == 10 || rev == 11)
            //    rev = 0;
            //if (rev != int.Parse(cpf[9].ToString()))
            //    return false;

            //// Valida 2o digito
            //add = 0;
            //for (int i = 0; i < 10; i++)
            //    add += int.Parse(cpf[i].ToString()) * (11 - i);
            //rev = 11 - add % 11;
            //if (rev == 10 || rev == 11)
            //    rev = 0;
            //if (rev != int.Parse(cpf[10].ToString()))
            //    return false;

            return true;
        }
        public bool setValidacao(MaskedTextBox TxtCpf, PictureBox pictureBox)
        {
            bool Validacao;
            C_ValidadorCPF c_ValidadorCPF = new C_ValidadorCPF();
            Validacao = c_ValidadorCPF.ValidarCPF(TxtCpf.Text);
            if (Validacao)
            {
                pictureBox.BackgroundImage = Properties.Resources.check__1_;
            }
            if (!Validacao)
            {
                pictureBox.BackgroundImage = Properties.Resources.x__1_;
            }
            if (TxtCpf.Text == "   .   .   -")
            {
                pictureBox.Visible = false;
            }
            else
            {
                pictureBox.Visible = true;
            }
            return Validacao;
        }
        
    }
}
