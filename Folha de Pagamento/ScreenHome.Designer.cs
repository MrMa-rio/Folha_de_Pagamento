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
            this.pnlInicial = new System.Windows.Forms.Panel();
            this.Btn_Menu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInicial
            // 
            this.pnlInicial.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.BackgroundImage;
            this.pnlInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInicial.Controls.Add(this.label1);
            this.pnlInicial.Controls.Add(this.Btn_Menu);
            this.pnlInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicial.Location = new System.Drawing.Point(0, 0);
            this.pnlInicial.Name = "pnlInicial";
            this.pnlInicial.Size = new System.Drawing.Size(1264, 751);
            this.pnlInicial.TabIndex = 4;
            this.pnlInicial.Click += new System.EventHandler(this.pnlInicial_Click);
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Menu.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.menu;
            this.Btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Menu.Location = new System.Drawing.Point(28, 32);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(48, 48);
            this.Btn_Menu.TabIndex = 3;
            this.Btn_Menu.TabStop = false;
            this.Btn_Menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.Btn_Menu.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.Btn_Menu.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ScreenHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 751);
            this.Controls.Add(this.pnlInicial);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 790);
            this.MinimumSize = new System.Drawing.Size(1280, 790);
            this.Name = "ScreenHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlInicial.ResumeLayout(false);
            this.pnlInicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlInicial;
        private System.Windows.Forms.PictureBox Btn_Menu;
        public System.Windows.Forms.Label label1;
    }
}

