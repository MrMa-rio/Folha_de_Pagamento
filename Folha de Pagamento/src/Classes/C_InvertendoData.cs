using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_InvertendoData
    {
        public string setDateInvert(string date)
        {
            string[] dateArray = date.Split('/');
            string dataInvert = dateArray[2] + dateArray[1] + dateArray[0];

            return dataInvert;
        }

        public string setDateReInvert(string date)
        {
            string[] dateArray = date.Split('-');
            string dataInvert = dateArray[2] + dateArray[1] + dateArray[0];

            return dataInvert;
        }
    }
}
