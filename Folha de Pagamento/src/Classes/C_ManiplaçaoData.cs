﻿using System;
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
        public string getYear(string date)
        {
            string[] dateArray = date.Split('/');

            
            
            string dataYear = dateArray[2];
            string dataMouth = dateArray[1];
            string dataDay = dateArray[0];
            return dataYear.Substring(0, 4);
        }
        public string getMonth(string date)
        {
            string[] dateArray = date.Split('/');

            string dataMonth = dateArray[1];
            return dataMonth.Substring(0, 2);
        }
        //Select DATA_Emite from tb_fechamento where DATA_Emite LIKE '%2023%' AND FK_Matricula = 19; // Retorna dados com base na matricula e no ano
        //Select DATA_Emite from tb_fechamento where FK_Matricula = 19; // Retorna dados com base na matricula
        //Select * from tb_fechamento where DATA_Emite LIKE '%2023-05%' AND  FK_Matricula = 19; Retorna dados com base no mes, ano e matricula

        

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
        public string setMonthName(int month)
        {
            string monthName = "";
            if (month == 01) { monthName = "Janeiro"; }
            if (month == 02) { monthName = "Fevereiro"; }
            if (month == 03) { monthName = "Março"; }
            if (month == 04) { monthName = "Abril"; }
            if (month == 05) { monthName = "Maio"; }
            if (month == 06) { monthName = "Junho"; }
            if (month == 07) { monthName = "Julho"; }
            if (month == 08) { monthName = "Agosto"; }
            if (month == 09) { monthName = "Setembro"; }
            if (month == 10) { monthName = "Outubro"; }
            if (month == 11) { monthName = "Novembro"; }
            if (month == 12) { monthName = "Dezemvro"; }
            return monthName;
        }
    }
}
