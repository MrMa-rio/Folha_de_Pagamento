using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_ManiplaçaoData
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
        public bool convertDate(string prevDate, DateTime DayDate)
        {
            string valor = prevDate;
            
            string formato = "dd/MM/yyyy";

            DateTime data;
            bool prevDateTime = DateTime.TryParseExact(valor, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
            if (prevDateTime)
            {
                if(data > DayDate || data.Year < DayDate.Year - 80)
                {
                    MessageBox.Show("Essa Data não é válida!");
                    return false;
                }
                else 
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool setValidacaoData(MaskedTextBox DataNascimento, DateTime DayTime, PictureBox pictureBox)
        {
            bool Validacao;
            Validacao = convertDate(DataNascimento.Text, DayTime);
            if (Validacao)
            {
                pictureBox.BackgroundImage = Properties.Resources.check__1_;
            }
            if (!Validacao)
            {
                pictureBox.BackgroundImage = Properties.Resources.x__1_;
            }
            if (DataNascimento.Text == "  /  /")
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
