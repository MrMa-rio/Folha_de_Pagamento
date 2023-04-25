using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_InvertendoData
    {
        public string setDateInvert(string date, char simbolo)
        {
            string[] dateArray = date.Split(simbolo);
            string dataInvert = dateArray[2] + dateArray[1] + dateArray[0];

            return dataInvert;
        }

        public string setDateReInvert(string date)
        {
            //string dataAmericana = "2023-04-24"; // data no formato americano
            DateTime data = DateTime.ParseExact(date, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture); // converter a string para um objeto DateTime
            string dataBrasileira = data.ToString("ddMMyyyy");
            return dataBrasileira;
        }
    }
}
