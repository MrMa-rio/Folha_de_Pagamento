using FOLHA_DE_PAGAMENTO_.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_
{
    public partial class FormCalculoPagamento : Form
    {
        FormNavBar FormAtivo;
        C_CalculosFolha calculosFolha = new C_CalculosFolha();
        public FormCalculoPagamento(FormNavBar navBar)
        {
            InitializeComponent();
            FormAtivo = navBar;
            calculosFolha.setSalariosBaseINSS(this);
            calculosFolha.setSalariosBaseIRRF(this);
        }
    }
}

/*
 * Criar a logica onde o programa ira se
 * comunicar com o banco e puxar tais informações
 * necessarias.
 * Organizar as tela que irao receber as informaçoes
 * Criar a logica dos calculos que independente do
 * valor do salario base, ele rode com precisão.
 * Criar uma logica onde apresente os dados de cada funcionario
 * e aparece o tempo de contribuição salário atual e os descontos
 * emissão do PDF
 
 
 
 */


/*
 Etapas para os descontos 

Antes de descontar o IRRF teremos que calcular o salario bruto do funcionario
Entao calcularemos quantos dias ele trabalhou, se entre esses dias teve feriado(caso sim, ver se ele trabalhou nesse dia, se sim, dobrar o valor desse dia)
calcular as horas extras.
Somando tudo isso, fazer os descontos se o funcionario tem dependentes
 
 
 */

