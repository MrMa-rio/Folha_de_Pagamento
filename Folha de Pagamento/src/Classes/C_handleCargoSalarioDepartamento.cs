using FOLHA_DE_PAGAMENTO_.src.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Classes
{
    internal class C_handleCargoSalarioDepartamento
    {
        C_CargoDepartamento c_Cargo = new C_CargoDepartamento();

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
            List<string[]> cargos = c_Cargo.getCargosDB();

            foreach (string[] carg in cargos)
            {
                if(cargo == carg[1])
                {
                    return carg[0];
                }
            }
            return "0";
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
            List<string[]> cargos = c_Cargo.getCargosDB();
            foreach (string[] cargo in cargos)
            {
                if(Id_Cargo == cargo[0])
                {
                    return cargo[1];
                }
            }
            return "";
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
        public void getCargo(ComboBox CbCargo)
        {
            List<string[]> cargos = c_Cargo.getCargosDB();
            foreach (string[] cargo in cargos)
            {
                if(CbCargo.Items.Count < cargos.Count)
                {
                    CbCargo.Height = cargos.Count;
                    CbCargo.Items.Add(cargo[1]);
                    CbCargo.AutoCompleteCustomSource.Add(cargo[1]);
                }
                if (CbCargo.GetItemText(cargo[1]) != cargo[1])
                {
                    CbCargo.Items.Add(cargo[1]);
                    CbCargo.AutoCompleteCustomSource.Add(cargo[1]);
                }
            }
        }
        public void getSalario(ComboBox CbCargo ,MaskedTextBox TxtSalario)
        {
            List<string[]> cargos = c_Cargo.getCargosDB();
            foreach (string[] cargo in cargos)
            {
                if (CbCargo.Text == cargo[1])
                {
                    TxtSalario.Text = Convert.ToDecimal(cargo[2]).ToString("N2");
                    break;
                }
                else
                {
                    TxtSalario.Text = "";
                }
            }
        }
        public void getSalario(string Cargo, Label Salario)
        {
            List<string[]> cargos = c_Cargo.getCargosDB();
            foreach (string[] cargo in cargos)
            {
                if (Cargo == cargo[1])
                {

                    Salario.Text = Convert.ToDecimal(cargo[2]).ToString("N2");
                    break;
                }
                else
                {
                    Salario.Text = "";
                }
            }
        }
        public bool setCargo(TextBox TxtCargo, TextBox TxtSalario)
        {
            if(TxtCargo.Text.Trim() != "" && TxtSalario.Text.Trim() != "")
            {
                List<string[]> cargos = c_Cargo.getCargosDB();
                foreach (string[] cargo in cargos)
                {
                    if (cargo[1] ==  TxtCargo.Text.Trim())
                    {
                        return false;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Você está prestes a cadastar um Novo Cargo.Tem Certeza?", "Criar Cargo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    c_Cargo.setNovoCargoDB(TxtCargo.Text, TxtSalario.Text);
                    return true;
                }
            }
            return false;
        }
        public bool alterCargo(ComboBox CbCargo, TextBox Cargo, MaskedTextBox Salario)
        {
            if(CbCargo.Text.Trim() != "" && Cargo.Text.Trim() != "" && Salario.Text.Trim() != "")
            {
                List<string[]> cargos = c_Cargo.getCargosDB();
                foreach (string[] cargo in cargos)
                {
                    if (cargo[1] == Cargo.Text.Trim() && Cargo.Text.Trim() != CbCargo.Text)
                    {
                        MessageBox.Show("Nome de Cargo já Existente.");
                        return false;
                    }
                }
                string idCargo = setIdCargo(CbCargo.Text);
                c_Cargo.modificaCargoDB(Cargo.Text, Salario.Text,idCargo);
                return true;
            }
            else
            {
                MessageBox.Show("Campos de Alterção vazio.");
                return false;
            }
        }

        public bool deleteCargo(ComboBox CbCargo) 
        {
            C_SearchInDataBase c_SearchInDataBase = new C_SearchInDataBase();
            C_InsertData c_InsertData = new C_InsertData();
            List<string[]> cargos = c_Cargo.getCargosDB();
            foreach (string[] cargo in cargos)
            {
                if (CbCargo.Text == cargo[1])
                {
                    string Id = setIdCargo(CbCargo.Text);
                    string insertSql = $"SELECT FK_Cargo FROM bd_folha.tb_funcionario where FK_Cargo = {Id}";
                    int FuncionariosNoCargo = c_SearchInDataBase.getListinDB(insertSql).Count;

                    if (FuncionariosNoCargo == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Você está preste à deletar este cargo! Continuar? ", "Deletar Cargo", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            string deleteComando = $"DELETE FROM `bd_folha`.`tb_cargo` WHERE (`ID_Cargo` = '{Id}')";
                            c_InsertData.deleteData(deleteComando);
                            MessageBox.Show("Cargo desativado com sucesso!");
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Para excluir um cargo, certifique-se de que não haja nenhum colaborador vinculado a ele. Por favor, verifique.");
                        return false;
                    }
                    break;
                }
                
            }
            MessageBox.Show("O cargo não existe ou está Incorreto");
            return false;
        }
    }
}