using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_RelatorioFolha
    {
        public void setFolhaDetalhada(FormFolhaDetalhada formFolhaDetalhada)
        {
            C_SearchInDataBase c_SearchInData = new C_SearchInDataBase();
            C_TransformandoValores c_TransformandoValores = new C_TransformandoValores();

            string taxaINSS = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtTaxaDescINSS.Text);
            string taxaIRRF = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtTaxaDescIRRF.Text);

            List<string[]> Result = c_SearchInData.getListinDB($"SELECT FK_Cargo FROM bd_folha.tb_funcionario WHERE Matricula = {formFolhaDetalhada.TxtPesquisarMatricula.Text};");
            List<string[]> resultIdINSS = c_SearchInData.getListinDB($"Select ID_INSS FROM tb_inss where Taxa_Desconto = {taxaINSS}");
            List<string[]> resultIdIRRF = c_SearchInData.getListinDB($"Select ID_IRF FROM tb_irf where Taxa_Desconto = {taxaIRRF}");

            DateTime dateTime = DateTime.Today;
            string table = "tb_fechamento";
            string columns = "DATA_Emite, FK_Matricula, FK_IDCargo, FK_IRFDesconto, FK_INSSDesconto, Salario_Final, Valor_DescontoINSS, Valor_DescontoFGTS, Valor_DescontoIRF";

            string salarioLiquido = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtSalarioLiquido.Text);
            string descINSS = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtDescINSS.Text);
            string descIRRF = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtDescIRRF.Text);
            string ValorFGTS = c_TransformandoValores.alterandoFormatos(formFolhaDetalhada.TxtValorFGTS.Text);

            string data = $" STR_TO_DATE('{dateTime.ToString()}', '%d/%m/%Y'), '{formFolhaDetalhada.TxtMatricula.Text}'," +
                          $" '{Result[0][0]}', '{resultIdIRRF[0][0]}'," +
                          $" '{resultIdINSS[0][0]}', '{salarioLiquido}'," +
                          $" '{descINSS}', '{ValorFGTS}'," +
                          $" '{descIRRF}' ";

            C_InsertData c_InsertData = new C_InsertData();
            c_InsertData.setData(table, columns, data);
        }
    }
}


/*
 * TODO:
 *      Fazer os pull Origin dos forms do black
 *      Fazer os comboBox ficar responsivo com cada mes do funcionario
 *      Calcular o valor geral das contas de todos funcionarios.
 *      Pra isso devem estar funcionando: Gerador de Folha Detalhada, Leitura da folha mensal, alteração de no maximo 1 mes.
 *      Com isso fazer uma somatoria de todos os funcionario daquele mes.
 *      O gerador de PDF estar funcionado
 *      Com todas essas funcionalidades já funcional, fazer o forms do holerite.
 *      
 *      Login usuarios estão com senha HardCode CPF!!
 *      
 *      E por FIm correção de Bugs
 */