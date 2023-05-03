using Correios.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaCep;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_VerificadorCEP
    {
        public void LocalizarCEP(string input, ComboBox txtEstado, TextBox txtCidade, TextBox txtBairro, TextBox txtRua, MaskedTextBox txtCep)
        {
            var client = new ViaCepClient().Search(input);

            txtBairro.Text = client.Neighborhood;
            txtCidade.Text = client.City;
            txtEstado.Text = client.StateInitials;
            txtCep.Text = client.ZipCode;
            txtRua.Text = client.Street;
        }
    }
}
