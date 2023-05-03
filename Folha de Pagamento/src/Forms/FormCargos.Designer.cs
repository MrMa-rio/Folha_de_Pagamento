﻿namespace FOLHA_DE_PAGAMENTO_
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargos));
            LbAdministrarCargos = new Panel();
            BtnRefresh = new Button();
            BtnErase1 = new Button();
            button2 = new Button();
            PnlAlteraCargo = new Panel();
            TxtAlterarSalario = new MaskedTextBox();
            CbCargo = new ComboBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            TxtAlterarCargo = new TextBox();
            label7 = new Label();
            label9 = new Label();
            BtnErase2 = new Button();
            PnlCadastraCargos = new Panel();
            pictureBox1 = new PictureBox();
            TxtSalarioBase = new TextBox();
            label4 = new Label();
            label5 = new Label();
            LbDataNascimento = new Label();
            TxtCargo = new TextBox();
            LbNomeCompleto = new Label();
            LbTitulo = new Label();
            label1 = new Label();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            toolTip1 = new ToolTip(components);
            LbAdministrarCargos.SuspendLayout();
            PnlAlteraCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PnlCadastraCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LbAdministrarCargos
            // 
            LbAdministrarCargos.AccessibleRole = AccessibleRole.None;
            LbAdministrarCargos.BackColor = Color.LightGray;
            LbAdministrarCargos.Controls.Add(BtnRefresh);
            LbAdministrarCargos.Controls.Add(BtnErase1);
            LbAdministrarCargos.Controls.Add(button2);
            LbAdministrarCargos.Controls.Add(PnlAlteraCargo);
            LbAdministrarCargos.Controls.Add(BtnErase2);
            LbAdministrarCargos.Controls.Add(PnlCadastraCargos);
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
            // BtnRefresh
            // 
            BtnRefresh.BackgroundImage = Properties.Resources.refresh1;
            BtnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRefresh.FlatAppearance.BorderSize = 0;
            BtnRefresh.FlatStyle = FlatStyle.Flat;
            BtnRefresh.Location = new Point(974, 54);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(43, 43);
            BtnRefresh.TabIndex = 65;
            toolTip1.SetToolTip(BtnRefresh, "Recarregar Pagina");
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.MouseClick += BtnRefresh_MouseClick;
            // 
            // BtnErase1
            // 
            BtnErase1.FlatAppearance.BorderSize = 0;
            BtnErase1.FlatStyle = FlatStyle.Flat;
            BtnErase1.Image = (Image)resources.GetObject("BtnErase1.Image");
            BtnErase1.Location = new Point(109, 508);
            BtnErase1.Name = "BtnErase1";
            BtnErase1.Size = new Size(43, 43);
            BtnErase1.TabIndex = 64;
            toolTip1.SetToolTip(BtnErase1, "Limpa Campos");
            BtnErase1.UseVisualStyleBackColor = true;
            BtnErase1.MouseClick += BtnErase1_MouseClick;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(60, 508);
            button2.Name = "button2";
            button2.Size = new Size(43, 43);
            button2.TabIndex = 63;
            toolTip1.SetToolTip(button2, "Criar Cargo");
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // PnlAlteraCargo
            // 
            PnlAlteraCargo.AutoScroll = true;
            PnlAlteraCargo.BackColor = Color.LightGray;
            PnlAlteraCargo.BorderStyle = BorderStyle.FixedSingle;
            PnlAlteraCargo.Controls.Add(TxtAlterarSalario);
            PnlAlteraCargo.Controls.Add(CbCargo);
            PnlAlteraCargo.Controls.Add(label8);
            PnlAlteraCargo.Controls.Add(pictureBox2);
            PnlAlteraCargo.Controls.Add(label2);
            PnlAlteraCargo.Controls.Add(label3);
            PnlAlteraCargo.Controls.Add(label6);
            PnlAlteraCargo.Controls.Add(TxtAlterarCargo);
            PnlAlteraCargo.Controls.Add(label7);
            PnlAlteraCargo.Controls.Add(label9);
            PnlAlteraCargo.Location = new Point(616, 142);
            PnlAlteraCargo.Name = "PnlAlteraCargo";
            PnlAlteraCargo.Size = new Size(450, 360);
            PnlAlteraCargo.TabIndex = 62;
            // 
            // TxtAlterarSalario
            // 
            TxtAlterarSalario.BackColor = Color.DarkGray;
            TxtAlterarSalario.BorderStyle = BorderStyle.FixedSingle;
            TxtAlterarSalario.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAlterarSalario.Location = new Point(219, 267);
            TxtAlterarSalario.Name = "TxtAlterarSalario";
            TxtAlterarSalario.Size = new Size(181, 31);
            TxtAlterarSalario.TabIndex = 44;
            // 
            // CbCargo
            // 
            CbCargo.BackColor = Color.DarkGray;
            CbCargo.FlatStyle = FlatStyle.Flat;
            CbCargo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbCargo.FormattingEnabled = true;
            CbCargo.Location = new Point(219, 110);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(212, 31);
            CbCargo.TabIndex = 42;
            CbCargo.DropDown += CbCargo_TextChanged;
            CbCargo.TextChanged += CbCargo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(49, 114);
            label8.Name = "label8";
            label8.Size = new Size(117, 21);
            label8.TabIndex = 41;
            label8.Text = "Escolher Cargo:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.edit;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(201, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(228, 17);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 0, 0);
            label2.Size = new Size(195, 32);
            label2.TabIndex = 38;
            label2.Text = "Modificar Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(194, 20);
            label3.Name = "label3";
            label3.Size = new Size(248, 37);
            label3.TabIndex = 37;
            label3.Text = "_____________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(49, 271);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 40;
            label6.Text = "Salário Base:";
            // 
            // TxtAlterarCargo
            // 
            TxtAlterarCargo.BackColor = Color.DarkGray;
            TxtAlterarCargo.BorderStyle = BorderStyle.FixedSingle;
            TxtAlterarCargo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAlterarCargo.Location = new Point(219, 205);
            TxtAlterarCargo.Name = "TxtAlterarCargo";
            TxtAlterarCargo.PlaceholderText = "Ajudante Geral";
            TxtAlterarCargo.Size = new Size(212, 31);
            TxtAlterarCargo.TabIndex = 35;
            TxtAlterarCargo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(49, 208);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 39;
            label7.Text = "Alterar Nome Cargo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(49, 135);
            label9.Name = "label9";
            label9.Size = new Size(380, 37);
            label9.TabIndex = 43;
            label9.Text = "_________________________________";
            // 
            // BtnErase2
            // 
            BtnErase2.FlatAppearance.BorderSize = 0;
            BtnErase2.FlatStyle = FlatStyle.Flat;
            BtnErase2.Image = (Image)resources.GetObject("BtnErase2.Image");
            BtnErase2.Location = new Point(1024, 508);
            BtnErase2.Name = "BtnErase2";
            BtnErase2.Size = new Size(43, 43);
            BtnErase2.TabIndex = 61;
            toolTip1.SetToolTip(BtnErase2, "Limpa Campos");
            BtnErase2.UseVisualStyleBackColor = true;
            BtnErase2.MouseClick += BtnErase2_MouseClick;
            // 
            // PnlCadastraCargos
            // 
            PnlCadastraCargos.AutoScroll = true;
            PnlCadastraCargos.AutoScrollMargin = new Size(0, 90);
            PnlCadastraCargos.AutoScrollMinSize = new Size(0, 90);
            PnlCadastraCargos.BorderStyle = BorderStyle.FixedSingle;
            PnlCadastraCargos.Controls.Add(pictureBox1);
            PnlCadastraCargos.Controls.Add(TxtSalarioBase);
            PnlCadastraCargos.Controls.Add(label4);
            PnlCadastraCargos.Controls.Add(label5);
            PnlCadastraCargos.Controls.Add(LbDataNascimento);
            PnlCadastraCargos.Controls.Add(TxtCargo);
            PnlCadastraCargos.Controls.Add(LbNomeCompleto);
            PnlCadastraCargos.Location = new Point(60, 142);
            PnlCadastraCargos.Name = "PnlCadastraCargos";
            PnlCadastraCargos.Size = new Size(450, 360);
            PnlCadastraCargos.TabIndex = 7;
            PnlCadastraCargos.MouseClick += AllForms_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.work;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(245, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // TxtSalarioBase
            // 
            TxtSalarioBase.BackColor = Color.DarkGray;
            TxtSalarioBase.BorderStyle = BorderStyle.FixedSingle;
            TxtSalarioBase.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioBase.Location = new Point(150, 218);
            TxtSalarioBase.Name = "TxtSalarioBase";
            TxtSalarioBase.PlaceholderText = "1060,00.";
            TxtSalarioBase.Size = new Size(125, 31);
            TxtSalarioBase.TabIndex = 3;
            TxtSalarioBase.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(7, 17);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 0, 0);
            label4.Size = new Size(227, 32);
            label4.TabIndex = 9;
            label4.Text = "Criação dos Cargos";
            label4.TextAlign = ContentAlignment.MiddleLeft;
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
            TxtCargo.PlaceholderText = "Auxiliar de Compras";
            TxtCargo.Size = new Size(219, 31);
            TxtCargo.TabIndex = 2;
            TxtCargo.TabStop = false;
            // 
            // LbNomeCompleto
            // 
            LbNomeCompleto.AutoSize = true;
            LbNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeCompleto.Location = new Point(15, 158);
            LbNomeCompleto.Name = "LbNomeCompleto";
            LbNomeCompleto.Size = new Size(97, 21);
            LbNomeCompleto.TabIndex = 32;
            LbNomeCompleto.Text = "Novo Cargo:";
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
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = (Image)resources.GetObject("BtnConfirmar.Image");
            BtnConfirmar.Location = new Point(975, 508);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(43, 43);
            BtnConfirmar.TabIndex = 18;
            toolTip1.SetToolTip(BtnConfirmar, "Alterar Cargo");
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.MouseClick += BtnConfirmar_MouseClick;
            // 
            // BtnCancelar
            // 
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.Location = new Point(1023, 54);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(43, 43);
            BtnCancelar.TabIndex = 19;
            toolTip1.SetToolTip(BtnCancelar, "Fechar Pagina");
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.MouseClick += BtnCancelar_MouseClick;
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
            PnlAlteraCargo.ResumeLayout(false);
            PnlAlteraCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PnlCadastraCargos.ResumeLayout(false);
            PnlCadastraCargos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LbAdministrarCargos;
        private Button BtnErase2;
        private Panel PnlCadastraCargos;
        private Label label4;
        private Label label5;
        private Label LbDataNascimento;
        private TextBox TxtCargo;
        private Label LbNomeCompleto;
        private Label LbTitulo;
        private Label label1;
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private Panel PnlAlteraCargo;
        private TextBox TxtSalarioBase;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox TxtAlterarCargo;
        private Label label7;
        private Button BtnErase1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox CbCargo;
        private Label label8;
        private Label label9;
        private ToolTip toolTip1;
        private Button BtnRefresh;
        private MaskedTextBox TxtAlterarSalario;
    }
}