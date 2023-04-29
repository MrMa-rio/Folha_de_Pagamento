namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargos));
            LbAdministrarCargos = new Panel();
            PanelPerfilCargos = new Panel();
            LbSalarioBase = new Label();
            label3 = new Label();
            label10 = new Label();
            Lbid = new Label();
            label8 = new Label();
            LbCargo = new Label();
            PctFotoCargos = new PictureBox();
            BtnLimpar = new Button();
            PanelAdminCargos = new Panel();
            TxtSalarioBase = new TextBox();
            Txtid = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            LbDataNascimento = new Label();
            TxtCargo = new TextBox();
            LbNomeCompleto = new Label();
            LbTitulo = new Label();
            label1 = new Label();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            LbAdministrarCargos.SuspendLayout();
            PanelPerfilCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctFotoCargos).BeginInit();
            PanelAdminCargos.SuspendLayout();
            SuspendLayout();
            // 
            // LbAdministrarCargos
            // 
            LbAdministrarCargos.AccessibleRole = AccessibleRole.None;
            LbAdministrarCargos.BackColor = Color.LightGray;
            LbAdministrarCargos.Controls.Add(PanelPerfilCargos);
            LbAdministrarCargos.Controls.Add(BtnLimpar);
            LbAdministrarCargos.Controls.Add(PanelAdminCargos);
            LbAdministrarCargos.Controls.Add(LbTitulo);
            LbAdministrarCargos.Controls.Add(label1);
            LbAdministrarCargos.Controls.Add(BtnConfirmar);
            LbAdministrarCargos.Controls.Add(BtnCancelar);
            LbAdministrarCargos.Location = new Point(80, 90);
            LbAdministrarCargos.Name = "LbAdministrarCargos";
            LbAdministrarCargos.Size = new Size(1110, 630);
            LbAdministrarCargos.TabIndex = 1;
            LbAdministrarCargos.MouseClick += AllForms_MouseClick;
            // 
            // PanelPerfilCargos
            // 
            PanelPerfilCargos.AutoScroll = true;
            PanelPerfilCargos.BackColor = Color.LightGray;
            PanelPerfilCargos.BorderStyle = BorderStyle.FixedSingle;
            PanelPerfilCargos.Controls.Add(LbSalarioBase);
            PanelPerfilCargos.Controls.Add(label3);
            PanelPerfilCargos.Controls.Add(label10);
            PanelPerfilCargos.Controls.Add(Lbid);
            PanelPerfilCargos.Controls.Add(label8);
            PanelPerfilCargos.Controls.Add(LbCargo);
            PanelPerfilCargos.Controls.Add(PctFotoCargos);
            PanelPerfilCargos.Location = new Point(810, 50);
            PanelPerfilCargos.Name = "PanelPerfilCargos";
            PanelPerfilCargos.Size = new Size(275, 456);
            PanelPerfilCargos.TabIndex = 62;
            // 
            // LbSalarioBase
            // 
            LbSalarioBase.AutoSize = true;
            LbSalarioBase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSalarioBase.Location = new Point(120, 390);
            LbSalarioBase.Name = "LbSalarioBase";
            LbSalarioBase.Size = new Size(58, 21);
            LbSalarioBase.TabIndex = 120;
            LbSalarioBase.Text = "Salário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 390);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 119;
            label3.Text = "Salário Base :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 340);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 117;
            label10.Text = "Cargo : ";
            // 
            // Lbid
            // 
            Lbid.AutoSize = true;
            Lbid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbid.Location = new Point(120, 290);
            Lbid.Name = "Lbid";
            Lbid.Size = new Size(25, 21);
            Lbid.TabIndex = 117;
            Lbid.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 290);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 117;
            label8.Text = "ID Cargo : ";
            // 
            // LbCargo
            // 
            LbCargo.AutoSize = true;
            LbCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCargo.Location = new Point(120, 340);
            LbCargo.Name = "LbCargo";
            LbCargo.Size = new Size(52, 21);
            LbCargo.TabIndex = 114;
            LbCargo.Text = "Cargo";
            // 
            // PctFotoCargos
            // 
            PctFotoCargos.ErrorImage = null;
            PctFotoCargos.Image = (Image)resources.GetObject("PctFotoCargos.Image");
            PctFotoCargos.Location = new Point(15, 15);
            PctFotoCargos.Name = "PctFotoCargos";
            PctFotoCargos.Size = new Size(245, 245);
            PctFotoCargos.SizeMode = PictureBoxSizeMode.StretchImage;
            PctFotoCargos.TabIndex = 0;
            PctFotoCargos.TabStop = false;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Enabled = false;
            BtnLimpar.FlatAppearance.BorderSize = 0;
            BtnLimpar.FlatStyle = FlatStyle.Flat;
            BtnLimpar.Image = (Image)resources.GetObject("BtnLimpar.Image");
            BtnLimpar.Location = new Point(742, 512);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(43, 43);
            BtnLimpar.TabIndex = 61;
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // PanelAdminCargos
            // 
            PanelAdminCargos.AutoScroll = true;
            PanelAdminCargos.AutoScrollMargin = new Size(0, 90);
            PanelAdminCargos.AutoScrollMinSize = new Size(0, 90);
            PanelAdminCargos.BorderStyle = BorderStyle.FixedSingle;
            PanelAdminCargos.Controls.Add(TxtSalarioBase);
            PanelAdminCargos.Controls.Add(Txtid);
            PanelAdminCargos.Controls.Add(label7);
            PanelAdminCargos.Controls.Add(label4);
            PanelAdminCargos.Controls.Add(label5);
            PanelAdminCargos.Controls.Add(LbDataNascimento);
            PanelAdminCargos.Controls.Add(TxtCargo);
            PanelAdminCargos.Controls.Add(LbNomeCompleto);
            PanelAdminCargos.Location = new Point(67, 142);
            PanelAdminCargos.Name = "PanelAdminCargos";
            PanelAdminCargos.Size = new Size(718, 364);
            PanelAdminCargos.TabIndex = 7;
            PanelAdminCargos.MouseClick += AllForms_MouseClick;
            // 
            // TxtSalarioBase
            // 
            TxtSalarioBase.BackColor = Color.DarkGray;
            TxtSalarioBase.BorderStyle = BorderStyle.FixedSingle;
            TxtSalarioBase.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioBase.Location = new Point(150, 218);
            TxtSalarioBase.Name = "TxtSalarioBase";
            TxtSalarioBase.PlaceholderText = "Digite o salário.";
            TxtSalarioBase.Size = new Size(125, 31);
            TxtSalarioBase.TabIndex = 3;
            // 
            // Txtid
            // 
            Txtid.BackColor = Color.DarkGray;
            Txtid.BorderStyle = BorderStyle.FixedSingle;
            Txtid.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txtid.Location = new Point(150, 98);
            Txtid.Name = "Txtid";
            Txtid.PlaceholderText = "ID";
            Txtid.ReadOnly = true;
            Txtid.Size = new Size(65, 31);
            Txtid.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 98);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 115;
            label7.Text = "ID Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(30, 17);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 0, 0);
            label4.Size = new Size(227, 32);
            label4.TabIndex = 9;
            label4.Text = "Criação dos Cargos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(15, 20);
            label5.Name = "label5";
            label5.Size = new Size(270, 37);
            label5.TabIndex = 8;
            label5.Text = "_______________________";
            // 
            // LbDataNascimento
            // 
            LbDataNascimento.AutoSize = true;
            LbDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbDataNascimento.Location = new Point(15, 218);
            LbDataNascimento.Name = "LbDataNascimento";
            LbDataNascimento.Size = new Size(97, 21);
            LbDataNascimento.TabIndex = 34;
            LbDataNascimento.Text = "Salário Base:";
            // 
            // TxtCargo
            // 
            TxtCargo.BackColor = Color.DarkGray;
            TxtCargo.BorderStyle = BorderStyle.FixedSingle;
            TxtCargo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCargo.Location = new Point(150, 158);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.PlaceholderText = "Digite o Cargo aqui.";
            TxtCargo.Size = new Size(287, 31);
            TxtCargo.TabIndex = 2;
            // 
            // LbNomeCompleto
            // 
            LbNomeCompleto.AutoSize = true;
            LbNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeCompleto.Location = new Point(15, 158);
            LbNomeCompleto.Name = "LbNomeCompleto";
            LbNomeCompleto.Size = new Size(55, 21);
            LbNomeCompleto.TabIndex = 32;
            LbNomeCompleto.Text = "Cargo:";
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.FlatStyle = FlatStyle.Flat;
            LbTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Image = (Image)resources.GetObject("LbTitulo.Image");
            LbTitulo.ImageAlign = ContentAlignment.MiddleRight;
            LbTitulo.Location = new Point(60, 33);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Padding = new Padding(10, 0, 0, 0);
            LbTitulo.Size = new Size(377, 41);
            LbTitulo.TabIndex = 50;
            LbTitulo.Text = "  Administrar Cargos          ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(70, 50);
            label1.Name = "label1";
            label1.Size = new Size(402, 37);
            label1.TabIndex = 60;
            label1.Text = "___________________________________";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Enabled = false;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = (Image)resources.GetObject("BtnConfirmar.Image");
            BtnConfirmar.Location = new Point(644, 512);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(43, 43);
            BtnConfirmar.TabIndex = 18;
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.Location = new Point(693, 512);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(43, 43);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            ClientSize = new Size(1264, 751);
            Controls.Add(LbAdministrarCargos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCargos";
            Text = "FormCargos";
            MouseClick += AllForms_MouseClick;
            LbAdministrarCargos.ResumeLayout(false);
            LbAdministrarCargos.PerformLayout();
            PanelPerfilCargos.ResumeLayout(false);
            PanelPerfilCargos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctFotoCargos).EndInit();
            PanelAdminCargos.ResumeLayout(false);
            PanelAdminCargos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LbAdministrarCargos;
        private Button BtnLimpar;
        private Panel PanelAdminCargos;
        private Label label4;
        private Label label5;
        private Label LbDataNascimento;
        private TextBox TxtCargo;
        private Label LbNomeCompleto;
        private Label LbTitulo;
        private Label label1;
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private TextBox Txtid;
        private Label label7;
        private Label LbCargo;
        private Panel PanelPerfilCargos;
        private PictureBox PctFotoCargos;
        private Label label8;
        private Label label10;
        private Label Lbid;
        private TextBox TxtSalarioBase;
        private Label LbSalarioBase;
        private Label label3;
    }
}