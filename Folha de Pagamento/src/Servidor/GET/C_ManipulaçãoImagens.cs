using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_DE_PAGAMENTO_.src.Servidor.GET
{
    internal class C_ManipulaçãoImagens
    {
        public bool getImagemUser(PictureBox User,string matriculaFuncionario)
        {
            try
            {
                string url = $"http://arquivosimagemusuario/{matriculaFuncionario}/imagemUser/imagemUser.png";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                User.BackgroundImage = Image.FromStream(stream);
                stream.Close();
                response.Close();
                return true;
            }
            catch
            {
                User.BackgroundImage = Properties.Resources.circle_account1;
                return false;
            }
        }

        public void setImagemUser(string matriculaFuncionario, string endereco)
        {

            string caminhoOrigem = endereco;
            string arquivo = "imagemUser.png";
            string caminhoDestino = @$"C:\Users\Mario\Documents\ServidorLocal\{matriculaFuncionario}\imagemUser\";

            if (!Directory.Exists(caminhoDestino))
            {
                Directory.CreateDirectory(caminhoDestino);
            }

            // Copia o arquivo de origem para o destino
            File.Copy(caminhoOrigem, caminhoDestino + arquivo, true);

        }

        public string setFotoNovoFuncionario(PictureBox User)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\"; // Define o diretório inicial
            openFileDialog.Filter = "Arquivos de Imagens (*.jpeg)|*.jpeg|Arquivos de Imagens (*.png)|*.png|Todos os arquivos (*.*)|*.*"; // Define as extensões permitidas
            openFileDialog.FilterIndex = 0;
            string endereco = "";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                endereco = openFileDialog.FileName;
                if (File.Exists(endereco))
                {
                    User.BackgroundImage = Image.FromFile(endereco);
                }
                else
                {
                    MessageBox.Show("A imagem não foi encontrada.");
                }
               
            }

            return endereco;
        }

        public void erasePhoto(PictureBox User)
        {
          DialogResult Alert =  MessageBox.Show("Você está preste à apagar Foto do Usuario! Tem certeza?", "Apagar Foto", MessageBoxButtons.YesNo);
            if (Alert == DialogResult.Yes)
            {
                User.BackgroundImage = Properties.Resources.circle_account1;
            }
        }
    }
}

//openFileDialog.FileName - Local do arquivo selecionado do usuario

/*
    TODO: Primeiramente voce deve criar um metodo que altere a foto estatica do FormCadastro para
          Foto do funcionario, depois disso guardar o endereço do diretorio em uma variavel.

          Depois disso criar um metodo que ira receber a matricula do funcionario e a url da foto do cadastrante
          Esse metodo sera responsavel por subir a foto desse usuario no servidor para futuros acessos;
 
 
 */