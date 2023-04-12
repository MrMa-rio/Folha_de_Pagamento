namespace Folha_de_Pagamento
{
    partial class navBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Barra_Gerenciamento = new System.Windows.Forms.Panel();
            this.BtnArrowLeft = new System.Windows.Forms.PictureBox();
            this.Barra_Gerenciamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnArrowLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Gerenciamento
            // 
            this.Barra_Gerenciamento.BackColor = System.Drawing.Color.Silver;
            this.Barra_Gerenciamento.Controls.Add(this.BtnArrowLeft);
            this.Barra_Gerenciamento.Dock = System.Windows.Forms.DockStyle.Left;
            this.Barra_Gerenciamento.Location = new System.Drawing.Point(0, 0);
            this.Barra_Gerenciamento.Name = "Barra_Gerenciamento";
            this.Barra_Gerenciamento.Size = new System.Drawing.Size(345, 751);
            this.Barra_Gerenciamento.TabIndex = 1;
            // 
            // BtnArrowLeft
            // 
            this.BtnArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.BtnArrowLeft.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.arrow_left;
            this.BtnArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnArrowLeft.Location = new System.Drawing.Point(21, 31);
            this.BtnArrowLeft.MaximumSize = new System.Drawing.Size(41, 41);
            this.BtnArrowLeft.MinimumSize = new System.Drawing.Size(39, 39);
            this.BtnArrowLeft.Name = "BtnArrowLeft";
            this.BtnArrowLeft.Padding = new System.Windows.Forms.Padding(2);
            this.BtnArrowLeft.Size = new System.Drawing.Size(39, 39);
            this.BtnArrowLeft.TabIndex = 2;
            this.BtnArrowLeft.TabStop = false;
            this.BtnArrowLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.BtnArrowLeft.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.BtnArrowLeft.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // navBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 751);
            this.Controls.Add(this.Barra_Gerenciamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "navBar";
            this.Text = "navBar";
            this.Barra_Gerenciamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnArrowLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Gerenciamento;
        private System.Windows.Forms.PictureBox BtnArrowLeft;
    }
}