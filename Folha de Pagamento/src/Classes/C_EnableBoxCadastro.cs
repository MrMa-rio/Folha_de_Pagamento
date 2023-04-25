using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_EnableBoxCadastro
    {
        public void setEnableAltCadastro(FormAlterarCadastro formAlterarCadastro )
        {
            formAlterarCadastro.TxtNomeCompleto.Enabled = true;
            formAlterarCadastro.TxtCpf.Enabled = true;
            //formAlterarCadastro.TxtCalendario.Enabled = true;
            formAlterarCadastro.CbGenero.Enabled = true;
            formAlterarCadastro.CbEstadoCivil.Enabled = true;
            formAlterarCadastro.TxtReservista.Enabled = true;
            formAlterarCadastro.TxtRg.Enabled = true;
            formAlterarCadastro.TxtTituloEleitor.Enabled = true;
            //formAlterarCadastro.BtnCalendario.Enabled = true;
            //formAlterarCadastro.PctCpf.Enabled = true;
            formAlterarCadastro.BtnCalendario.Enabled = true;
            formAlterarCadastro.BtnCalendario2.Enabled = true;
            formAlterarCadastro.TxtTelefone.Enabled = true;
            formAlterarCadastro.TxtEmail.Enabled = true;
            formAlterarCadastro.TxtRua.Enabled = true;
            formAlterarCadastro.TxtNumRua.Enabled = true;
            formAlterarCadastro.TxtBairro.Enabled = true;
            formAlterarCadastro.TxtComplemento.Enabled = true;
            formAlterarCadastro.CbUF.Enabled = true;
            formAlterarCadastro.TxtCidade.Enabled = true;
            formAlterarCadastro.TxtCep.Enabled = true;
            formAlterarCadastro.TxtPis.Enabled = true;
            formAlterarCadastro.CbDepartamento.Enabled = true;

            formAlterarCadastro.TxtNumRua.Enabled=true;
            formAlterarCadastro.TxtCalendario.Enabled = true;
            formAlterarCadastro.TxtDataAdmissao.Enabled = true;
            formAlterarCadastro.TxtReservista.Enabled = true;
            formAlterarCadastro.TxtNit.Enabled = true;
            formAlterarCadastro.TxtTituloEleitor.Enabled = true;
            formAlterarCadastro.CbCargo.Enabled = true;
            formAlterarCadastro.TxtDataAdmissao.Enabled = true;
            formAlterarCadastro.TxtCTrabalho.Enabled = true;
            formAlterarCadastro.TxtSalarioBase.Enabled = true;
        }
    }
}
