namespace Folha_de_Pagamento
{
    partial class Cadastro
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
            this.panel_Home = new System.Windows.Forms.Panel();
            this.Cadastroo = new System.Windows.Forms.Label();
            this.panel_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Home
            // 
            this.panel_Home.BackgroundImage = global::Folha_de_Pagamento.Properties.Resources.BackgroundImage;
            this.panel_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Home.Controls.Add(this.Cadastroo);
            this.panel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Home.Location = new System.Drawing.Point(0, 0);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(1264, 751);
            this.panel_Home.TabIndex = 5;
            
            // 
            // Cadastroo
            // 
            this.Cadastroo.AutoSize = true;
            this.Cadastroo.BackColor = System.Drawing.Color.Transparent;
            this.Cadastroo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastroo.Location = new System.Drawing.Point(405, 39);
            this.Cadastroo.Name = "Cadastroo";
            this.Cadastroo.Size = new System.Drawing.Size(440, 63);
            this.Cadastroo.TabIndex = 4;
            this.Cadastroo.Text = "Tela de Cadastro";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 751);
            this.Controls.Add(this.panel_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.panel_Home.ResumeLayout(false);
            this.panel_Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_Home;
        public System.Windows.Forms.Label Cadastroo;
    }
}