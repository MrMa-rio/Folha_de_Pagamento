using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    public partial class FormDesativarFunc : Form
    {
        FormAlterarCadastro form;
        public FormDesativarFunc(FormAlterarCadastro formAlterarCadastro)
        {
            InitializeComponent();
            form = formAlterarCadastro;
            TxtNome.Text = formAlterarCadastro.TxtNomeCompleto.Text;
            TxtCPF.Text = formAlterarCadastro.TxtCpf.Text;
            TxtCargo.Text = formAlterarCadastro.CbCargo.Text;
            TxtDepartamento.Text = formAlterarCadastro.CbDepartamento.Text;
            TxtDataDemissional.Text = DateTime.Today.ToString().Substring(0, 10);
        }

        private void BtnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            C_updateSql c_UpdateSql = new C_updateSql();
            c_UpdateSql.desativaFuncionario(TxtCPF.Text);

            this.Close();
            MessageBox.Show("Funcionario Desativado Com Sucesso!");
        }
    }
}

//Finalizar O CRUD do funcionario para que ele nao apareça nas outras telas, 
//Fazer uma validação antes de cada consulta para nao retornar dados.

//Para que o usuario nao delete outros func, por engano, liberar o delete somente quando 
// a função editar estivere desabilitada!!


//Finalizar o crud do Cargo!!


//Mesclar cargo departamento, para que ambos fiquem coerentes;