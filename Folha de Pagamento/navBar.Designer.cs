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
            this.Relatorio = new System.Windows.Forms.Button();
            this.Gerenciamento = new System.Windows.Forms.Button();
            this.BtnArrowLeft = new System.Windows.Forms.PictureBox();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Barra_Gerenciamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnArrowLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Gerenciamento
            // 
            this.Barra_Gerenciamento.BackColor = System.Drawing.Color.Silver;
            this.Barra_Gerenciamento.Controls.Add(this.button1);
            this.Barra_Gerenciamento.Controls.Add(this.btnConfiguracao);
            this.Barra_Gerenciamento.Controls.Add(this.Relatorio);
            this.Barra_Gerenciamento.Controls.Add(this.Gerenciamento);
            this.Barra_Gerenciamento.Controls.Add(this.BtnArrowLeft);
            this.Barra_Gerenciamento.Dock = System.Windows.Forms.DockStyle.Left;
            this.Barra_Gerenciamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Barra_Gerenciamento.Location = new System.Drawing.Point(0, 0);
            this.Barra_Gerenciamento.Name = "Barra_Gerenciamento";
            this.Barra_Gerenciamento.Size = new System.Drawing.Size(345, 751);
            this.Barra_Gerenciamento.TabIndex = 1;
            // 
            // Relatorio
            // 
            this.Relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Relatorio.FlatAppearance.BorderSize = 0;
            this.Relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Relatorio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relatorio.Image = global::Folha_de_Pagamento.Properties.Resources.summarize_FILL0_wght400_GRAD0_opsz48;
            this.Relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Relatorio.Location = new System.Drawing.Point(0, 228);
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Relatorio.Size = new System.Drawing.Size(345, 63);
            this.Relatorio.TabIndex = 6;
            this.Relatorio.Text = "Relatório";
            this.Relatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Relatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Relatorio.UseVisualStyleBackColor = true;
            this.Relatorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Relatorio_MouseClick);
            // 
            // Gerenciamento
            // 
            this.Gerenciamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gerenciamento.FlatAppearance.BorderSize = 0;
            this.Gerenciamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gerenciamento.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerenciamento.Image = global::Folha_de_Pagamento.Properties.Resources.manager;
            this.Gerenciamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gerenciamento.Location = new System.Drawing.Point(0, 159);
            this.Gerenciamento.Name = "Gerenciamento";
            this.Gerenciamento.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Gerenciamento.Size = new System.Drawing.Size(345, 63);
            this.Gerenciamento.TabIndex = 3;
            this.Gerenciamento.Text = "Gerenciamento";
            this.Gerenciamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gerenciamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Gerenciamento.UseVisualStyleBackColor = true;
            this.Gerenciamento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gerenciamento_MouseClick);
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
            this.BtnArrowLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_arrow_left_MouseClick);
            this.BtnArrowLeft.MouseEnter += new System.EventHandler(this.btn_arrow_left_MouseEnter);
            this.BtnArrowLeft.MouseLeave += new System.EventHandler(this.btn_arrow_left_MouseLeave);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConfiguracao.Image = global::Folha_de_Pagamento.Properties.Resources.settings;
            this.btnConfiguracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.Location = new System.Drawing.Point(18, 683);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Padding = new System.Windows.Forms.Padding(4);
            this.btnConfiguracao.Size = new System.Drawing.Size(174, 47);
            this.btnConfiguracao.TabIndex = 7;
            this.btnConfiguracao.Text = "Configurações";
            this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Location = new System.Drawing.Point(207, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Trocar/Sair";
            this.button1.UseVisualStyleBackColor = false;
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
        public System.Windows.Forms.Button Gerenciamento;
        public System.Windows.Forms.Button Relatorio;
        public System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button button1;
    }
}