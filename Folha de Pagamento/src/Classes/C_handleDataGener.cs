using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_handleDataGener
    {
        public string handleGener(string Sexo)
        {
            if(Sexo == "M" || Sexo == "m")
            {
                return "Masculino";
            }
            if(Sexo == "F" || Sexo == "f")
            {
                return "Feminino";
            }
            if (Sexo == "T" || Sexo == "t")
            {
                return "Transgênero";
            }
            else
            {
                return "Outro";
            }
        }
    }
}
