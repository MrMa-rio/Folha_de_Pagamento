using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_DE_PAGAMENTO_.src.Servidor.GET
{
    internal class C_GetImagens
    {
        public void getImagemUser(PictureBox User)
        {
            string url = $"http://arquivosimagemusuario/nova/imagem.png";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            User.Image = Image.FromStream(stream);

            stream.Close();
            response.Close();
        }

        public void setImagemUser(PictureBox arquivom)
        {
            // Especifica os caminhos dos arquivos de origem e destino
            string caminhoOrigem = @"C:\Users\Mario\Pictures\Impermais_green.png";
            string caminhoDestino = @"C:\Users\Mario\Documents\ServidorLocal\nova\imagem.png";

            // Copia o arquivo de origem para o destino
            File.Copy(caminhoOrigem, caminhoDestino,true);
        }
    }
}
