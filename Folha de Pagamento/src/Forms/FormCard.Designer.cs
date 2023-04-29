namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    partial class FormCard
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
            PanelCard = new Panel();
            PnlBackground = new Panel();
            TxtDepartamento = new Label();
            TxtCargo = new Label();
            label16 = new Label();
            TxtNome = new Label();
            label15 = new Label();
            TxtMatricula = new Label();
            label13 = new Label();
            label1 = new Label();
            label14 = new Label();
            PanelCard.SuspendLayout();
            PnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // PanelCard
            // 
            PanelCard.BackColor = Color.DarkGray;
            PanelCard.Controls.Add(PnlBackground);
            PanelCard.Dock = DockStyle.Fill;
            PanelCard.Location = new Point(0, 0);
            PanelCard.Name = "PanelCard";
            PanelCard.Size = new Size(980, 88);
            PanelCard.TabIndex = 15;
            // 
            // PnlBackground
            // 
            PnlBackground.BackColor = Color.DarkGray;
            PnlBackground.Controls.Add(TxtDepartamento);
            PnlBackground.Controls.Add(TxtCargo);
            PnlBackground.Controls.Add(label16);
            PnlBackground.Controls.Add(TxtNome);
            PnlBackground.Controls.Add(label15);
            PnlBackground.Controls.Add(TxtMatricula);
            PnlBackground.Controls.Add(label13);
            PnlBackground.Controls.Add(label1);
            PnlBackground.Controls.Add(label14);
            PnlBackground.Location = new Point(10, 7);
            PnlBackground.Name = "PnlBackground";
            PnlBackground.Size = new Size(958, 75);
            PnlBackground.TabIndex = 17;
            PnlBackground.MouseClick += PnlBackground_MouseClick;
            PnlBackground.MouseEnter += PnlBackground_MouseEnter;
            PnlBackground.MouseLeave += PnlBackground_MouseLeave;
            // 
            // TxtDepartamento
            // 
            TxtDepartamento.AutoSize = true;
            TxtDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDepartamento.Location = new Point(697, 6);
            TxtDepartamento.Name = "TxtDepartamento";
            TxtDepartamento.Size = new Size(114, 21);
            TxtDepartamento.TabIndex = 10;
            TxtDepartamento.Text = "ID Cargo puxar";
            // 
            // TxtCargo
            // 
            TxtCargo.AutoSize = true;
            TxtCargo.BackColor = Color.Transparent;
            TxtCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCargo.Location = new Point(697, 40);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.Size = new Size(95, 21);
            TxtCargo.TabIndex = 16;
            TxtCargo.Text = "Cargo puxar";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(542, 40);
            label16.Name = "label16";
            label16.Size = new Size(59, 21);
            label16.TabIndex = 3;
            label16.Text = "Cargo:";
            // 
            // TxtNome
            // 
            TxtNome.AutoSize = true;
            TxtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNome.Location = new Point(118, 40);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(96, 21);
            TxtNome.TabIndex = 9;
            TxtNome.Text = "Nome puxar";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(542, 6);
            label15.Name = "label15";
            label15.Size = new Size(125, 21);
            label15.TabIndex = 2;
            label15.Text = "Departamento:";
            // 
            // TxtMatricula
            // 
            TxtMatricula.AutoSize = true;
            TxtMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricula.Location = new Point(118, 6);
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(118, 21);
            TxtMatricula.TabIndex = 8;
            TxtMatricula.Text = "Matrícula puxar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(18, 6);
            label13.Name = "label13";
            label13.Size = new Size(87, 21);
            label13.TabIndex = 0;
            label13.Text = "Matrícula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(608, 6);
            label1.Name = "label1";
            label1.Size = new Size(14, 21);
            label1.TabIndex = 14;
            label1.Text = ":";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(18, 40);
            label14.Name = "label14";
            label14.Size = new Size(61, 21);
            label14.TabIndex = 1;
            label14.Text = "Nome:";
            // 
            // FormCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 88);
            Controls.Add(PanelCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCard";
            Text = "FormCard";
            PanelCard.ResumeLayout(false);
            PnlBackground.ResumeLayout(false);
            PnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCard;
        private Label TxtCargo;
        private Label label1;
        private Label TxtDepartamento;
        private Label TxtNome;
        private Label TxtMatricula;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Panel PnlBackground;
    }
}