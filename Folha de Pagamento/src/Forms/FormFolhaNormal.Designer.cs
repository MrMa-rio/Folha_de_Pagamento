namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormFolhaNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFolhaNormal));
            LbFolhaNormal = new Panel();
            BtnLimpar = new Button();
            PanelFolhaNormal = new Panel();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            LbRg = new Label();
            CbGenero = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtDataNascimento = new MaskedTextBox();
            TxtCpf = new MaskedTextBox();
            CbEstadoCivil = new ComboBox();
            LbEstadoCivil = new Label();
            LbCpf = new Label();
            LbDataNascimento = new Label();
            TxtNomeCompleto = new TextBox();
            LbNomeCompleto = new Label();
            LbTitulo = new Label();
            label1 = new Label();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            LbFolhaNormal.SuspendLayout();
            PanelFolhaNormal.SuspendLayout();
            SuspendLayout();
            // 
            // LbFolhaNormal
            // 
            LbFolhaNormal.AccessibleRole = AccessibleRole.None;
            LbFolhaNormal.BackColor = Color.LightGray;
            LbFolhaNormal.Controls.Add(BtnLimpar);
            LbFolhaNormal.Controls.Add(PanelFolhaNormal);
            LbFolhaNormal.Controls.Add(LbTitulo);
            LbFolhaNormal.Controls.Add(label1);
            LbFolhaNormal.Controls.Add(BtnConfirmar);
            LbFolhaNormal.Controls.Add(BtnCancelar);
            LbFolhaNormal.Location = new Point(69, 41);
            LbFolhaNormal.Name = "LbFolhaNormal";
            LbFolhaNormal.Size = new Size(1110, 630);
            LbFolhaNormal.TabIndex = 2;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Enabled = false;
            BtnLimpar.FlatAppearance.BorderSize = 0;
            BtnLimpar.FlatStyle = FlatStyle.Flat;
            BtnLimpar.Image = (Image)resources.GetObject("BtnLimpar.Image");
            BtnLimpar.Location = new Point(1004, 582);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(43, 43);
            BtnLimpar.TabIndex = 61;
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // PanelFolhaNormal
            // 
            PanelFolhaNormal.AutoScroll = true;
            PanelFolhaNormal.AutoScrollMargin = new Size(0, 90);
            PanelFolhaNormal.AutoScrollMinSize = new Size(0, 90);
            PanelFolhaNormal.BorderStyle = BorderStyle.FixedSingle;
            PanelFolhaNormal.Controls.Add(textBox3);
            PanelFolhaNormal.Controls.Add(label7);
            PanelFolhaNormal.Controls.Add(textBox1);
            PanelFolhaNormal.Controls.Add(label3);
            PanelFolhaNormal.Controls.Add(maskedTextBox1);
            PanelFolhaNormal.Controls.Add(LbRg);
            PanelFolhaNormal.Controls.Add(CbGenero);
            PanelFolhaNormal.Controls.Add(label6);
            PanelFolhaNormal.Controls.Add(label4);
            PanelFolhaNormal.Controls.Add(label5);
            PanelFolhaNormal.Controls.Add(TxtDataNascimento);
            PanelFolhaNormal.Controls.Add(TxtCpf);
            PanelFolhaNormal.Controls.Add(CbEstadoCivil);
            PanelFolhaNormal.Controls.Add(LbEstadoCivil);
            PanelFolhaNormal.Controls.Add(LbCpf);
            PanelFolhaNormal.Controls.Add(LbDataNascimento);
            PanelFolhaNormal.Controls.Add(TxtNomeCompleto);
            PanelFolhaNormal.Controls.Add(LbNomeCompleto);
            PanelFolhaNormal.Location = new Point(67, 142);
            PanelFolhaNormal.Name = "PanelFolhaNormal";
            PanelFolhaNormal.Size = new Size(980, 434);
            PanelFolhaNormal.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkGray;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(150, 70);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Digite o nome aqui";
            textBox3.Size = new Size(65, 31);
            textBox3.TabIndex = 116;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 70);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 115;
            label7.Text = "ID Cargo";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(150, 350);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "A Definir";
            textBox1.Size = new Size(287, 31);
            textBox1.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 350);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 111;
            label3.Text = "Transporte";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.DarkGray;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(150, 310);
            maskedTextBox1.Mask = "00,000,000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(160, 31);
            maskedTextBox1.TabIndex = 103;
            // 
            // LbRg
            // 
            LbRg.AutoSize = true;
            LbRg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbRg.Location = new Point(15, 310);
            LbRg.Name = "LbRg";
            LbRg.Size = new Size(96, 21);
            LbRg.TabIndex = 104;
            LbRg.Text = "Alimentação";
            // 
            // CbGenero
            // 
            CbGenero.AutoCompleteCustomSource.AddRange(new string[] { "Masculino", "Feminino", "Transgênero", "Cisgênero", "Outro" });
            CbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbGenero.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbGenero.BackColor = Color.DarkGray;
            CbGenero.FlatStyle = FlatStyle.Flat;
            CbGenero.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbGenero.FormattingEnabled = true;
            CbGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Transgênero", "Cisgênero", "Outro" });
            CbGenero.Location = new Point(150, 270);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(160, 31);
            CbGenero.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 270);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 69;
            label6.Text = "Plantão";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(34, 18);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 0, 0);
            label4.Size = new Size(339, 32);
            label4.TabIndex = 9;
            label4.Text = "Informações da Folha Normal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(15, 20);
            label5.Name = "label5";
            label5.Size = new Size(380, 37);
            label5.TabIndex = 8;
            label5.Text = "_________________________________";
            // 
            // TxtDataNascimento
            // 
            TxtDataNascimento.BackColor = Color.DarkGray;
            TxtDataNascimento.BorderStyle = BorderStyle.FixedSingle;
            TxtDataNascimento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDataNascimento.Location = new Point(150, 150);
            TxtDataNascimento.Mask = "00/00/0000";
            TxtDataNascimento.Name = "TxtDataNascimento";
            TxtDataNascimento.PromptChar = 'X';
            TxtDataNascimento.Size = new Size(121, 31);
            TxtDataNascimento.TabIndex = 1;
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = Color.DarkGray;
            TxtCpf.BorderStyle = BorderStyle.FixedSingle;
            TxtCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.Location = new Point(150, 190);
            TxtCpf.Mask = "000,000,000-00";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.PromptChar = 'X';
            TxtCpf.Size = new Size(160, 31);
            TxtCpf.TabIndex = 2;
            // 
            // CbEstadoCivil
            // 
            CbEstadoCivil.AutoCompleteCustomSource.AddRange(new string[] { "Casado", "Solteiro", "Uniao Estavel", "Outro" });
            CbEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbEstadoCivil.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbEstadoCivil.BackColor = Color.DarkGray;
            CbEstadoCivil.FlatStyle = FlatStyle.Flat;
            CbEstadoCivil.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbEstadoCivil.FormattingEnabled = true;
            CbEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Uniao Estável", "Outro" });
            CbEstadoCivil.Location = new Point(150, 230);
            CbEstadoCivil.Name = "CbEstadoCivil";
            CbEstadoCivil.Size = new Size(160, 31);
            CbEstadoCivil.TabIndex = 3;
            // 
            // LbEstadoCivil
            // 
            LbEstadoCivil.AutoSize = true;
            LbEstadoCivil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbEstadoCivil.Location = new Point(15, 230);
            LbEstadoCivil.Name = "LbEstadoCivil";
            LbEstadoCivil.Size = new Size(96, 21);
            LbEstadoCivil.TabIndex = 36;
            LbEstadoCivil.Text = "Bonificações";
            // 
            // LbCpf
            // 
            LbCpf.AutoSize = true;
            LbCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCpf.Location = new Point(15, 190);
            LbCpf.Name = "LbCpf";
            LbCpf.Size = new Size(105, 21);
            LbCpf.TabIndex = 35;
            LbCpf.Text = "Carga horária";
            // 
            // LbDataNascimento
            // 
            LbDataNascimento.AutoSize = true;
            LbDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbDataNascimento.Location = new Point(15, 150);
            LbDataNascimento.Name = "LbDataNascimento";
            LbDataNascimento.Size = new Size(94, 21);
            LbDataNascimento.TabIndex = 34;
            LbDataNascimento.Text = "Salário Base";
            // 
            // TxtNomeCompleto
            // 
            TxtNomeCompleto.BackColor = Color.DarkGray;
            TxtNomeCompleto.BorderStyle = BorderStyle.FixedSingle;
            TxtNomeCompleto.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNomeCompleto.Location = new Point(150, 110);
            TxtNomeCompleto.Name = "TxtNomeCompleto";
            TxtNomeCompleto.PlaceholderText = " Digite o nome aqui";
            TxtNomeCompleto.Size = new Size(287, 31);
            TxtNomeCompleto.TabIndex = 0;
            // 
            // LbNomeCompleto
            // 
            LbNomeCompleto.AutoSize = true;
            LbNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeCompleto.Location = new Point(15, 110);
            LbNomeCompleto.Name = "LbNomeCompleto";
            LbNomeCompleto.Size = new Size(52, 21);
            LbNomeCompleto.TabIndex = 32;
            LbNomeCompleto.Text = "Cargo";
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
            LbTitulo.Size = new Size(262, 41);
            LbTitulo.TabIndex = 50;
            LbTitulo.Text = "Folha Normal       ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(70, 50);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 60;
            label1.Text = "______________________";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Enabled = false;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = (Image)resources.GetObject("BtnConfirmar.Image");
            BtnConfirmar.Location = new Point(906, 582);
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
            BtnCancelar.Location = new Point(955, 582);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(43, 43);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormFolhaNormal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            ClientSize = new Size(1248, 712);
            Controls.Add(LbFolhaNormal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFolhaNormal";
            Text = "FormNormal";
            LbFolhaNormal.ResumeLayout(false);
            LbFolhaNormal.PerformLayout();
            PanelFolhaNormal.ResumeLayout(false);
            PanelFolhaNormal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LbFolhaNormal;
        private Button BtnLimpar;
        private Panel PanelFolhaNormal;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox1;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Label LbRg;
        private ComboBox CbGenero;
        private Label label6;
        private Label label4;
        private Label label5;
        private MaskedTextBox TxtDataNascimento;
        private MaskedTextBox TxtCpf;
        private ComboBox CbEstadoCivil;
        private Label LbEstadoCivil;
        private Label LbCpf;
        private Label LbDataNascimento;
        private TextBox TxtNomeCompleto;
        private Label LbNomeCompleto;
        private Label LbTitulo;
        private Label label1;
        private Button BtnConfirmar;
        private Button BtnCancelar;
    }
}