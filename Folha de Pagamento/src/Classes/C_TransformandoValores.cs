using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_TransformandoValores
    {
        public string alterandoFormatos(string valor)
        {
            valor = Convert.ToDouble(valor).ToString("N2");
            if(valor != "")
            {
                if (valor[valor.Length - 3].ToString() == ".")
                {
                    valor = valor.Remove(valor.Length - 3,1);
                    valor = valor.Insert(valor.Length - 2, ",");
                    MessageBox.Show(valor);
                }
                valor = valor.Replace(".", "");
                valor = valor.Replace(',', '.');
            }
            return valor;
        }
    }
}
