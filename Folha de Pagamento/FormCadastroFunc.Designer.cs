namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormCadastroFunc
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
            PanelPerfilFunc = new Panel();
            BtnEditar = new Button();
            PctFotoFunc = new PictureBox();
            PanelCtrlCad = new Panel();
            BtnCalendario = new Button();
            BoxCalendario = new MonthCalendar();
            TxtCalendario = new MaskedTextBox();
            TxtCpf = new MaskedTextBox();
            LbValidacao = new Label();
            comboBox1 = new ComboBox();
            BtnConfirmar = new Button();
            textBox3 = new TextBox();
            BtnCancelar = new Button();
            textBox7 = new TextBox();
            label2 = new Label();
            label9 = new Label();
            CbEstadoCivil = new ComboBox();
            textBox6 = new TextBox();
            TxtNomeFunc = new TextBox();
            label8 = new Label();
            label7 = new Label();
            LbEstadoCivil = new Label();
            LbCpf = new Label();
            LbDataNasc = new Label();
            LbNomeFunc = new Label();
            LbTitulo = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            PanelPerfilFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctFotoFunc).BeginInit();
            PanelCtrlCad.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(PanelPerfilFunc);
            panel1.Controls.Add(PanelCtrlCad);
            panel1.Controls.Add(LbTitulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(80, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 630);
            panel1.TabIndex = 0;
            // 
            // PanelPerfilFunc
            // 
            PanelPerfilFunc.BackColor = Color.DarkGray;
            PanelPerfilFunc.Controls.Add(BtnEditar);
            PanelPerfilFunc.Controls.Add(PctFotoFunc);
            PanelPerfilFunc.Location = new Point(810, 50);
            PanelPerfilFunc.Name = "PanelPerfilFunc";
            PanelPerfilFunc.Size = new Size(275, 550);
            PanelPerfilFunc.TabIndex = 4;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.edit;
            BtnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Location = new Point(111, 270);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(49, 46);
            BtnEditar.TabIndex = 1;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // PctFotoFunc
            // 
            PctFotoFunc.ErrorImage = null;
            PctFotoFunc.Image = Properties.Resources.circle_account1;
            PctFotoFunc.Location = new Point(15, 19);
            PctFotoFunc.Name = "PctFotoFunc";
            PctFotoFunc.Size = new Size(245, 245);
            PctFotoFunc.SizeMode = PictureBoxSizeMode.StretchImage;
            PctFotoFunc.TabIndex = 0;
            PctFotoFunc.TabStop = false;
            // 
            // PanelCtrlCad
            // 
            PanelCtrlCad.AutoScroll = true;
            PanelCtrlCad.BackgroundImageLayout = ImageLayout.Stretch;
            PanelCtrlCad.Controls.Add(BtnCalendario);
            PanelCtrlCad.Controls.Add(BoxCalendario);
            PanelCtrlCad.Controls.Add(TxtCalendario);
            PanelCtrlCad.Controls.Add(TxtCpf);
            PanelCtrlCad.Controls.Add(LbValidacao);
            PanelCtrlCad.Controls.Add(comboBox1);
            PanelCtrlCad.Controls.Add(BtnConfirmar);
            PanelCtrlCad.Controls.Add(textBox3);
            PanelCtrlCad.Controls.Add(BtnCancelar);
            PanelCtrlCad.Controls.Add(textBox7);
            PanelCtrlCad.Controls.Add(label2);
            PanelCtrlCad.Controls.Add(label9);
            PanelCtrlCad.Controls.Add(CbEstadoCivil);
            PanelCtrlCad.Controls.Add(textBox6);
            PanelCtrlCad.Controls.Add(TxtNomeFunc);
            PanelCtrlCad.Controls.Add(label8);
            PanelCtrlCad.Controls.Add(label7);
            PanelCtrlCad.Controls.Add(LbEstadoCivil);
            PanelCtrlCad.Controls.Add(LbCpf);
            PanelCtrlCad.Controls.Add(LbDataNasc);
            PanelCtrlCad.Controls.Add(LbNomeFunc);
            PanelCtrlCad.Location = new Point(65, 131);
            PanelCtrlCad.Name = "PanelCtrlCad";
            PanelCtrlCad.Size = new Size(740, 469);
            PanelCtrlCad.TabIndex = 3;
            // 
            // BtnCalendario
            // 
            BtnCalendario.BackgroundImage = Properties.Resources.calendario;
            BtnCalendario.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCalendario.FlatAppearance.BorderSize = 0;
            BtnCalendario.FlatStyle = FlatStyle.Flat;
            BtnCalendario.Location = new Point(326, 92);
            BtnCalendario.Name = "BtnCalendario";
            BtnCalendario.Size = new Size(26, 26);
            BtnCalendario.TabIndex = 22;
            BtnCalendario.UseVisualStyleBackColor = true;
            BtnCalendario.MouseClick += BtnCalendario_MouseClick;
            // 
            // BoxCalendario
            // 
            BoxCalendario.Location = new Point(426, 85);
            BoxCalendario.Name = "BoxCalendario";
            BoxCalendario.ShowToday = false;
            BoxCalendario.ShowTodayCircle = false;
            BoxCalendario.TabIndex = 21;
            BoxCalendario.Visible = false;
            BoxCalendario.DateSelected += BoxCalendario_DateSelected;
            // 
            // TxtCalendario
            // 
            TxtCalendario.BackColor = Color.DarkGray;
            TxtCalendario.BorderStyle = BorderStyle.FixedSingle;
            TxtCalendario.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCalendario.Location = new Point(193, 89);
            TxtCalendario.Mask = "00/00/0000";
            TxtCalendario.Name = "TxtCalendario";
            TxtCalendario.PromptChar = 'X';
            TxtCalendario.Size = new Size(121, 31);
            TxtCalendario.TabIndex = 20;
            TxtCalendario.Text = "01012000";
            TxtCalendario.TextAlign = HorizontalAlignment.Center;
            TxtCalendario.ValidatingType = typeof(DateTime);
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = Color.DarkGray;
            TxtCpf.BeepOnError = true;
            TxtCpf.BorderStyle = BorderStyle.FixedSingle;
            TxtCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.Location = new Point(193, 136);
            TxtCpf.Mask = "000,000,000-00";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.PromptChar = 'X';
            TxtCpf.Size = new Size(160, 31);
            TxtCpf.TabIndex = 19;
            TxtCpf.TextChanged += TxtCpf_TextChanged;
            // 
            // LbValidacao
            // 
            LbValidacao.AutoSize = true;
            LbValidacao.BackColor = Color.Transparent;
            LbValidacao.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LbValidacao.Location = new Point(352, 137);
            LbValidacao.Name = "LbValidacao";
            LbValidacao.Size = new Size(0, 18);
            LbValidacao.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Analista de Sistema", "Suporte TI", "Desenvolvedor de Software" });
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.BackColor = Color.DarkGray;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Analista de Sistema", "Suporte TI", "Desenvolvedor de Software" });
            comboBox1.Location = new Point(194, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 31);
            comboBox1.TabIndex = 17;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = Properties.Resources.check;
            BtnConfirmar.Location = new Point(602, 496);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(43, 43);
            BtnConfirmar.TabIndex = 6;
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkGray;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(194, 362);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "A DEFINIR";
            textBox3.Size = new Size(287, 31);
            textBox3.TabIndex = 16;
            // 
            // BtnCancelar
            // 
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Image = Properties.Resources.close;
            BtnCancelar.Location = new Point(664, 496);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(43, 43);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.DarkGray;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(194, 316);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "A DEFINIR";
            textBox7.Size = new Size(287, 31);
            textBox7.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 359);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 14;
            label2.Text = "A Definir:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(38, 311);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 13;
            label9.Text = "A Definir:";
            // 
            // CbEstadoCivil
            // 
            CbEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbEstadoCivil.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbEstadoCivil.BackColor = Color.DarkGray;
            CbEstadoCivil.FlatStyle = FlatStyle.Flat;
            CbEstadoCivil.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbEstadoCivil.FormattingEnabled = true;
            CbEstadoCivil.Items.AddRange(new object[] { "Casado", "União Estável", "Solteiro", "Outro" });
            CbEstadoCivil.Location = new Point(193, 177);
            CbEstadoCivil.Name = "CbEstadoCivil";
            CbEstadoCivil.Size = new Size(160, 31);
            CbEstadoCivil.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DarkGray;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(194, 270);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "A DEFINIR";
            textBox6.Size = new Size(287, 31);
            textBox6.TabIndex = 11;
            // 
            // TxtNomeFunc
            // 
            TxtNomeFunc.BackColor = Color.DarkGray;
            TxtNomeFunc.BorderStyle = BorderStyle.FixedSingle;
            TxtNomeFunc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNomeFunc.Location = new Point(194, 41);
            TxtNomeFunc.Name = "TxtNomeFunc";
            TxtNomeFunc.PlaceholderText = "Digite Nome do Novo Funcionario";
            TxtNomeFunc.Size = new Size(287, 31);
            TxtNomeFunc.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(38, 274);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 5;
            label8.Text = "A Definir:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 226);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 4;
            label7.Text = "Cargo:";
            // 
            // LbEstadoCivil
            // 
            LbEstadoCivil.AutoSize = true;
            LbEstadoCivil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbEstadoCivil.Location = new Point(38, 181);
            LbEstadoCivil.Name = "LbEstadoCivil";
            LbEstadoCivil.Size = new Size(93, 21);
            LbEstadoCivil.TabIndex = 3;
            LbEstadoCivil.Text = "Estado Civil:";
            // 
            // LbCpf
            // 
            LbCpf.AutoSize = true;
            LbCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCpf.Location = new Point(38, 134);
            LbCpf.Name = "LbCpf";
            LbCpf.Size = new Size(40, 21);
            LbCpf.TabIndex = 2;
            LbCpf.Text = "CPF:";
            // 
            // LbDataNasc
            // 
            LbDataNasc.AutoSize = true;
            LbDataNasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbDataNasc.Location = new Point(38, 87);
            LbDataNasc.Name = "LbDataNasc";
            LbDataNasc.Size = new Size(150, 21);
            LbDataNasc.TabIndex = 1;
            LbDataNasc.Text = "Data de nascimento:";
            // 
            // LbNomeFunc
            // 
            LbNomeFunc.AutoSize = true;
            LbNomeFunc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeFunc.Location = new Point(38, 43);
            LbNomeFunc.Name = "LbNomeFunc";
            LbNomeFunc.Size = new Size(128, 21);
            LbNomeFunc.TabIndex = 0;
            LbNomeFunc.Text = "Nome Completo:";
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.FlatStyle = FlatStyle.Flat;
            LbTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Image = Properties.Resources.circle_account;
            LbTitulo.ImageAlign = ContentAlignment.MiddleRight;
            LbTitulo.Location = new Point(86, 33);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Padding = new Padding(10, 0, 0, 0);
            LbTitulo.Size = new Size(368, 41);
            LbTitulo.TabIndex = 2;
            LbTitulo.Text = "Dados do Funcionário      ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(65, 50);
            label1.Name = "label1";
            label1.Size = new Size(402, 37);
            label1.TabIndex = 1;
            label1.Text = "___________________________________";
            // 
            // FormCadastroFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 129, 241);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 751);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormCadastroFunc";
            Text = "FormCadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelPerfilFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PctFotoFunc).EndInit();
            PanelCtrlCad.ResumeLayout(false);
            PanelCtrlCad.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label LbTitulo;
        private Panel PanelPerfilFunc;
        private Panel PanelCtrlCad;
        private Label label8;
        private Label label7;
        private Label LbEstadoCivil;
        private Label LbCpf;
        private Label LbDataNasc;
        private Label LbNomeFunc;
        private TextBox TxtNomeFunc;
        private TextBox textBox6;
        private ComboBox CbEstadoCivil;
        private TextBox textBox3;
        private TextBox textBox7;
        private Label label2;
        private Label label9;
        private PictureBox PctFotoFunc;
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private Button BtnEditar;
        private ComboBox comboBox1;
        private Label LbValidacao;
        private MaskedTextBox TxtCpf;
        private MonthCalendar BoxCalendario;
        private MaskedTextBox TxtCalendario;
        private Button BtnCalendario;
    }
}