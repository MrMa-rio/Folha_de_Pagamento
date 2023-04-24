using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_handleCargoSalarioDepartamento
    {
        public string setSalarioBase(string cargo)
        {

            if (cargo == "Ajudante Geral")  
            {
                return "1578";
            }
            if (cargo == "Impermeabilizador(a)")
            {
                return "2487";
            }
            if (cargo == "Auxiliar Administrativo")
            {
                return "1486";
            }
            if (cargo == "Contadora")
            {
                return "3595";
            }
            else
            {
                return "0";
            }
        }
        public string setIdDepartamento(string departamento)
        {
            if (departamento == "Contabil")
            {
                return "1";
            }
            if (departamento == "Adminstração")
            {
                return"2";

            }
            if (departamento == "Engenharia")
            {
                return"3";
            }
            if (departamento == "Produção")
            {
                return"4";
            }
            else
            {
                return "0";
            }
        }
        public string setIdCargo(string cargo)
        {
            if (cargo == "Ajudante Geral")
            {
                return "14";
            }
            if (cargo == "Impermeabilizador(a)")
            {
                return "13";
            }
            if (cargo == "Auxiliar Administrativo")
            {
                return "12";
            }
            if (cargo == "Contadora")
            {
                return "11";
            }
            else
            {
                return "10";
            }
        }
    }
}


/*
 
 */


