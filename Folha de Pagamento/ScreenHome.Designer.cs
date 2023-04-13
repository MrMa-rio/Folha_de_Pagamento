namespace Folha_de_Pagamento
{
    public partial class ScreenHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Menu.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.menu;
            this.Btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Menu.Location = new System.Drawing.Point(27, 28);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(48, 48);
            this.Btn_Menu.TabIndex = 4;
            this.Btn_Menu.TabStop = false;
            this.Btn_Menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Menu_MouseClick);
            this.Btn_Menu.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.Btn_Menu.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // ScreenHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 751);
            this.Controls.Add(this.Btn_Menu);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 790);
            this.MinimumSize = new System.Drawing.Size(1280, 790);
            this.Name = "ScreenHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Btn_Menu;
    }
}

