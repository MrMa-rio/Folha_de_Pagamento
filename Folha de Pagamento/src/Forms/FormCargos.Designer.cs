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
            LbAlterarCadastro = new Panel();
            BtnLimpar = new Button();
            PnlCtrlFunc = new Panel();
            PctCpf = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label12 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            LbRg = new Label();
            CbGenero = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            BtnCalendario = new Button();
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
            LbAlterarCadastro.SuspendLayout();
            PnlCtrlFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctCpf).BeginInit();
            SuspendLayout();
            // 
            // LbAlterarCadastro
            // 
            LbAlterarCadastro.AccessibleRole = AccessibleRole.None;
            LbAlterarCadastro.BackColor = Color.LightGray;
            LbAlterarCadastro.Controls.Add(BtnLimpar);
            LbAlterarCadastro.Controls.Add(PnlCtrlFunc);
            LbAlterarCadastro.Controls.Add(LbTitulo);
            LbAlterarCadastro.Controls.Add(label1);
            LbAlterarCadastro.Controls.Add(BtnConfirmar);
            LbAlterarCadastro.Controls.Add(BtnCancelar);
            LbAlterarCadastro.Location = new Point(80, 90);
            LbAlterarCadastro.Name = "LbAlterarCadastro";
            LbAlterarCadastro.Size = new Size(1110, 630);
            LbAlterarCadastro.TabIndex = 1;
            LbAlterarCadastro.MouseClick += AllForms_MouseClick;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Enabled = false;
            BtnLimpar.FlatAppearance.BorderSize = 0;
            BtnLimpar.FlatStyle = FlatStyle.Flat;
            BtnLimpar.Image = (Image)resources.GetObject("BtnLimpar.Image");
            BtnLimpar.Location = new Point(706, 582);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(43, 43);
            BtnLimpar.TabIndex = 61;
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // PnlCtrlFunc
            // 
            PnlCtrlFunc.AutoScroll = true;
            PnlCtrlFunc.AutoScrollMargin = new Size(0, 90);
            PnlCtrlFunc.AutoScrollMinSize = new Size(0, 90);
            PnlCtrlFunc.BorderStyle = BorderStyle.FixedSingle;
            PnlCtrlFunc.Controls.Add(PctCpf);
            PnlCtrlFunc.Controls.Add(textBox1);
            PnlCtrlFunc.Controls.Add(label3);
            PnlCtrlFunc.Controls.Add(textBox2);
            PnlCtrlFunc.Controls.Add(label12);
            PnlCtrlFunc.Controls.Add(maskedTextBox1);
            PnlCtrlFunc.Controls.Add(LbRg);
            PnlCtrlFunc.Controls.Add(CbGenero);
            PnlCtrlFunc.Controls.Add(label6);
            PnlCtrlFunc.Controls.Add(label4);
            PnlCtrlFunc.Controls.Add(label5);
            PnlCtrlFunc.Controls.Add(BtnCalendario);
            PnlCtrlFunc.Controls.Add(TxtDataNascimento);
            PnlCtrlFunc.Controls.Add(TxtCpf);
            PnlCtrlFunc.Controls.Add(CbEstadoCivil);
            PnlCtrlFunc.Controls.Add(LbEstadoCivil);
            PnlCtrlFunc.Controls.Add(LbCpf);
            PnlCtrlFunc.Controls.Add(LbDataNascimento);
            PnlCtrlFunc.Controls.Add(TxtNomeCompleto);
            PnlCtrlFunc.Controls.Add(LbNomeCompleto);
            PnlCtrlFunc.Location = new Point(29, 117);
            PnlCtrlFunc.Name = "PnlCtrlFunc";
            PnlCtrlFunc.Size = new Size(1050, 460);
            PnlCtrlFunc.TabIndex = 7;
            PnlCtrlFunc.MouseClick += AllForms_MouseClick;
            // 
            // PctCpf
            // 
            PctCpf.BackgroundImageLayout = ImageLayout.Stretch;
            PctCpf.Location = new Point(337, 184);
            PctCpf.Name = "PctCpf";
            PctCpf.Size = new Size(28, 28);
            PctCpf.TabIndex = 112;
            PctCpf.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(169, 332);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "A Definir";
            textBox1.Size = new Size(287, 31);
            textBox1.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 335);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 111;
            label3.Text = " Titulo de Eleitor:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(169, 369);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "A Definir";
            textBox2.Size = new Size(287, 31);
            textBox2.TabIndex = 109;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 372);
            label12.Name = "label12";
            label12.Size = new Size(88, 21);
            label12.TabIndex = 110;
            label12.Text = " Reservista:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.DarkGray;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(170, 295);
            maskedTextBox1.Mask = "00,000,000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(160, 31);
            maskedTextBox1.TabIndex = 103;
            // 
            // LbRg
            // 
            LbRg.AutoSize = true;
            LbRg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbRg.Location = new Point(14, 298);
            LbRg.Name = "LbRg";
            LbRg.Size = new Size(41, 21);
            LbRg.TabIndex = 104;
            LbRg.Text = "*RG:";
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
            CbGenero.Location = new Point(170, 258);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(160, 31);
            CbGenero.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 262);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 69;
            label6.Text = "*Gênero:";
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
            label4.Size = new Size(249, 32);
            label4.TabIndex = 9;
            label4.Text = "Informações Pessoais";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(14, 20);
            label5.Name = "label5";
            label5.Size = new Size(314, 37);
            label5.TabIndex = 8;
            label5.Text = "___________________________";
            // 
            // BtnCalendario
            // 
            BtnCalendario.BackgroundImage = Properties.Resources.calendario;
            BtnCalendario.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCalendario.FlatAppearance.BorderSize = 0;
            BtnCalendario.FlatStyle = FlatStyle.Flat;
            BtnCalendario.Location = new Point(304, 149);
            BtnCalendario.Name = "BtnCalendario";
            BtnCalendario.Size = new Size(26, 26);
            BtnCalendario.TabIndex = 55;
            BtnCalendario.UseVisualStyleBackColor = true;
            // 
            // TxtDataNascimento
            // 
            TxtDataNascimento.BackColor = Color.DarkGray;
            TxtDataNascimento.BorderStyle = BorderStyle.FixedSingle;
            TxtDataNascimento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDataNascimento.Location = new Point(172, 147);
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
            TxtCpf.Location = new Point(171, 184);
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
            CbEstadoCivil.Location = new Point(170, 221);
            CbEstadoCivil.Name = "CbEstadoCivil";
            CbEstadoCivil.Size = new Size(160, 31);
            CbEstadoCivil.TabIndex = 3;
            // 
            // LbEstadoCivil
            // 
            LbEstadoCivil.AutoSize = true;
            LbEstadoCivil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbEstadoCivil.Location = new Point(14, 225);
            LbEstadoCivil.Name = "LbEstadoCivil";
            LbEstadoCivil.Size = new Size(100, 21);
            LbEstadoCivil.TabIndex = 36;
            LbEstadoCivil.Text = "*Estado Civil:";
            // 
            // LbCpf
            // 
            LbCpf.AutoSize = true;
            LbCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCpf.Location = new Point(14, 187);
            LbCpf.Name = "LbCpf";
            LbCpf.Size = new Size(47, 21);
            LbCpf.TabIndex = 35;
            LbCpf.Text = "*CPF:";
            // 
            // LbDataNascimento
            // 
            LbDataNascimento.AutoSize = true;
            LbDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbDataNascimento.Location = new Point(14, 150);
            LbDataNascimento.Name = "LbDataNascimento";
            LbDataNascimento.Size = new Size(160, 21);
            LbDataNascimento.TabIndex = 34;
            LbDataNascimento.Text = "*Data de Nascimento:";
            // 
            // TxtNomeCompleto
            // 
            TxtNomeCompleto.BackColor = Color.DarkGray;
            TxtNomeCompleto.BorderStyle = BorderStyle.FixedSingle;
            TxtNomeCompleto.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNomeCompleto.Location = new Point(172, 110);
            TxtNomeCompleto.Name = "TxtNomeCompleto";
            TxtNomeCompleto.PlaceholderText = " Digite o nome aqui";
            TxtNomeCompleto.Size = new Size(287, 31);
            TxtNomeCompleto.TabIndex = 0;
            // 
            // LbNomeCompleto
            // 
            LbNomeCompleto.AutoSize = true;
            LbNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeCompleto.Location = new Point(14, 113);
            LbNomeCompleto.Name = "LbNomeCompleto";
            LbNomeCompleto.Size = new Size(135, 21);
            LbNomeCompleto.TabIndex = 32;
            LbNomeCompleto.Text = "*Nome Completo:";
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.FlatStyle = FlatStyle.Flat;
            LbTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Image = (Image)resources.GetObject("LbTitulo.Image");
            LbTitulo.ImageAlign = ContentAlignment.MiddleRight;
            LbTitulo.Location = new Point(86, 33);
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
            label1.Location = new Point(91, 50);
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
            BtnConfirmar.Location = new Point(608, 582);
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
            BtnCancelar.Location = new Point(657, 582);
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
            Controls.Add(LbAlterarCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCargos";
            Text = "FormCargos";
            LbAlterarCadastro.ResumeLayout(false);
            LbAlterarCadastro.PerformLayout();
            PnlCtrlFunc.ResumeLayout(false);
            PnlCtrlFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctCpf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LbAlterarCadastro;
        private Button BtnLimpar;
        private Panel PnlCtrlFunc;
        private PictureBox PctCpf;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label12;
        private MaskedTextBox maskedTextBox1;
        private Label LbRg;
        private ComboBox CbGenero;
        private Label label6;
        private Label label4;
        private Label label5;
        private Button BtnCalendario;
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