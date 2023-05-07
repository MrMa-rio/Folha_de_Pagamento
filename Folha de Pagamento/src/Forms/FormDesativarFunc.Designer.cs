namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    partial class FormDesativarFunc
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
            panel1 = new Panel();
            TxtDepartamento = new Label();
            TxtCargo = new Label();
            TxtNome = new Label();
            TxtCPF = new Label();
            TxtDataDemissional = new Label();
            label3 = new Label();
            label1 = new Label();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtDepartamento);
            panel1.Controls.Add(TxtCargo);
            panel1.Controls.Add(TxtNome);
            panel1.Controls.Add(TxtCPF);
            panel1.Controls.Add(TxtDataDemissional);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 455);
            panel1.TabIndex = 0;
            // 
            // TxtDepartamento
            // 
            TxtDepartamento.AutoSize = true;
            TxtDepartamento.Location = new Point(191, 252);
            TxtDepartamento.Name = "TxtDepartamento";
            TxtDepartamento.Size = new Size(83, 15);
            TxtDepartamento.TabIndex = 7;
            TxtDepartamento.Text = "Departamento";
            // 
            // TxtCargo
            // 
            TxtCargo.AutoSize = true;
            TxtCargo.Location = new Point(192, 199);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.Size = new Size(39, 15);
            TxtCargo.TabIndex = 6;
            TxtCargo.Text = "Cargo";
            // 
            // TxtNome
            // 
            TxtNome.AutoSize = true;
            TxtNome.Location = new Point(195, 110);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(40, 15);
            TxtNome.TabIndex = 5;
            TxtNome.Text = "Nome";
            // 
            // TxtCPF
            // 
            TxtCPF.AutoSize = true;
            TxtCPF.Location = new Point(203, 156);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(28, 15);
            TxtCPF.TabIndex = 4;
            TxtCPF.Text = "CPF";
            // 
            // TxtDataDemissional
            // 
            TxtDataDemissional.AutoSize = true;
            TxtDataDemissional.Location = new Point(192, 297);
            TxtDataDemissional.Name = "TxtDataDemissional";
            TxtDataDemissional.Size = new Size(31, 15);
            TxtDataDemissional.TabIndex = 3;
            TxtDataDemissional.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 416);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Tem certeza?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 57);
            label1.Name = "label1";
            label1.Size = new Size(240, 15);
            label1.TabIndex = 0;
            label1.Text = "Você Está preste à desativar este Funcionario";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(62, 497);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 23);
            BtnConfirmar.TabIndex = 1;
            BtnConfirmar.Text = "OK";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.MouseClick += BtnConfirmar_MouseClick;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(308, 499);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.MouseClick += BtnCancelar_MouseClick;
            // 
            // FormDesativarFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 534);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnConfirmar);
            Controls.Add(panel1);
            Name = "FormDesativarFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDesativarFunc";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TxtNome;
        private Label TxtCPF;
        private Label TxtDataDemissional;
        private Label label3;
        private Label label1;
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private Label TxtDepartamento;
        private Label TxtCargo;
    }
}