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
        }
        public void enable_disable(Panel panel)
        {
            
            foreach (Control controle in panel.Controls)
            {
                if (controle is MaskedTextBox) // verifica se o controle é um TextBox
                {
                    if ( controle.Enabled == false )
                    {
                        ((MaskedTextBox)controle).Enabled = true;
                    }
                    else
                    {
                        ((MaskedTextBox)controle).Enabled = false;
                    }
                }

                if (controle is TextBox) // verifica se o controle é um TextBox
                {
                    if (controle.Enabled == false)
                    {
                        ((TextBox)controle).Enabled = true;
                    }
                    else
                    {
                        ((TextBox)controle).Enabled = false;
                    }
                }

                if (controle is Button) // verifica se o controle é um TextBox
                {
                    if (controle.Enabled == false)
                    {
                        ((Button)controle).Enabled = true;
                    }
                    else
                    {
                        ((Button)controle).Enabled = false;
                    }
                }

                if (controle is ComboBox) // verifica se o controle é um TextBox
                {
                    if (controle.Enabled == false)
                    {
                        ((ComboBox)controle).Enabled = true;
                    }
                    else
                    {
                        ((ComboBox)controle).Enabled = false;
                    }
                }
                if (controle is NumericUpDown) // verifica se o controle é um TextBox
                {
                    if (controle.Enabled == false)
                    {
                        ((NumericUpDown)controle).Enabled = true;
                    }
                    else
                    {
                        ((NumericUpDown)controle).Enabled = false;
                    }
                }

            }
        }
    }
}
