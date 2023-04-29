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
            if (cargo == "Contador(a)")
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
                return "4";
            }
            if (cargo == "Impermeabilizador(a)")
            {
                return "3";
            }
            if (cargo == "Auxiliar Administrativo")
            {
                return "2";
            }
            if (cargo == "Contador(a)")
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        public string getIdDepartamento(string Id_Departamento)
        {
            if (Id_Departamento == "1")
            {
                return "Contabil";
            }
            if (Id_Departamento == "2")
            {
                return "Adminstração";

            }
            if (Id_Departamento == "3")
            {
                return "Engenharia";
            }
            if (Id_Departamento == "4")
            {
                return "Produção";
            }
            else
            {
                return "0";
            }
        }
        public string getIdCargo(string Id_Cargo)
        {
            if (Id_Cargo == "1")
            {
                return "Contador(a)";
            }
            if (Id_Cargo == "2")
            {
                return "Auxiliar Administrativo";

            }
            if (Id_Cargo == "3")
            {
                return "Impermeabilizador(a)";
            }
            if (Id_Cargo == "4")
            {
                return "Ajudante Geral";
            }
            else
            {
                return "0";
            }
        }

        public string setNvlAcesso(string departamento)
        {
            if(departamento == "Adminstração")
            {
                return "2";
            }
            else
            {
                return "3";
            }

            
        }
    }
}


/*
 
 */


