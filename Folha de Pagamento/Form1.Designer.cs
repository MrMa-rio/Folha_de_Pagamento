namespace Folha_de_Pagamento
{
    partial class Form1
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
            this.btn_arrow_left = new System.Windows.Forms.Panel();
            this.Barra_Gerenciamento = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_arrow_teste = new System.Windows.Forms.Panel();
            this.Barra_Gerenciamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_arrow_left
            // 
            this.btn_arrow_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_arrow_left.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.arrow_left;
            this.btn_arrow_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_arrow_left.Location = new System.Drawing.Point(19, 21);
            this.btn_arrow_left.Name = "btn_arrow_left";
            this.btn_arrow_left.Size = new System.Drawing.Size(37, 37);
            this.btn_arrow_left.TabIndex = 1;
            this.btn_arrow_left.Enter += new System.EventHandler(this.btn_arrow_left_Enter);
            this.btn_arrow_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            this.btn_arrow_left.MouseEnter += new System.EventHandler(this.btn_arrow_left_MouseEnter);
            this.btn_arrow_left.MouseLeave += new System.EventHandler(this.btn_arrow_left_MouseLeave);
            // 
            // Barra_Gerenciamento
            // 
            this.Barra_Gerenciamento.BackColor = System.Drawing.Color.Silver;
            this.Barra_Gerenciamento.Controls.Add(this.label1);
            this.Barra_Gerenciamento.Controls.Add(this.btn_arrow_left);
            this.Barra_Gerenciamento.Location = new System.Drawing.Point(0, 0);
            this.Barra_Gerenciamento.Name = "Barra_Gerenciamento";
            this.Barra_Gerenciamento.Size = new System.Drawing.Size(345, 751);
            this.Barra_Gerenciamento.TabIndex = 0;
            this.Barra_Gerenciamento.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            // 
            // btn_arrow_teste
            // 
            this.btn_arrow_teste.BackColor = System.Drawing.Color.Transparent;
            this.btn_arrow_teste.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.menu;
            this.btn_arrow_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_arrow_teste.Location = new System.Drawing.Point(29, 29);
            this.btn_arrow_teste.Name = "btn_arrow_teste";
            this.btn_arrow_teste.Padding = new System.Windows.Forms.Padding(5);
            this.btn_arrow_teste.Size = new System.Drawing.Size(37, 37);
            this.btn_arrow_teste.TabIndex = 2;
            this.btn_arrow_teste.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_arrow_teste_MouseClick);
            this.btn_arrow_teste.MouseEnter += new System.EventHandler(this.btn_arrow_teste_MouseEnter);
            this.btn_arrow_teste.MouseLeave += new System.EventHandler(this.btn_arrow_teste_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 751);
            this.Controls.Add(this.Barra_Gerenciamento);
            this.Controls.Add(this.btn_arrow_teste);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 790);
            this.MinimumSize = new System.Drawing.Size(1280, 790);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Barra_Gerenciamento.ResumeLayout(false);
            this.Barra_Gerenciamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel btn_arrow_left;
        private System.Windows.Forms.Panel Barra_Gerenciamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btn_arrow_teste;
    }
}

