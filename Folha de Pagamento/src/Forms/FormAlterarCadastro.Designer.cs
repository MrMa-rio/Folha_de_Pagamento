namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormAlterarCadastro
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
            Button BtnEditar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarCadastro));
            panel1 = new Panel();
            BtnLimpar = new Button();
            BtnConfirmar = new Button();
            PnlCtrlFunc = new Panel();
            TxtTelefone = new MaskedTextBox();
            TxtCep = new MaskedTextBox();
            LbCep = new Label();
            TxtTituloEleitor = new TextBox();
            LbTituloEleitor = new Label();
            TxtReservista = new TextBox();
            LbReservista = new Label();
            TxtRg = new MaskedTextBox();
            LbRg = new Label();
            PctCpf = new PictureBox();
            BoxCalendario2 = new MonthCalendar();
            BtnCalendario2 = new Button();
            TxtDataEmissao = new MaskedTextBox();
            TxtSalarioBase = new TextBox();
            label26 = new Label();
            label27 = new Label();
            TxtCTrabalho = new TextBox();
            label28 = new Label();
            TxtNit = new TextBox();
            label29 = new Label();
            label24 = new Label();
            label25 = new Label();
            CbUF = new ComboBox();
            TxtCidade = new TextBox();
            label19 = new Label();
            label23 = new Label();
            TxtEmail = new TextBox();
            label20 = new Label();
            label22 = new Label();
            TxtComplemento = new TextBox();
            label21 = new Label();
            TxtBairro = new TextBox();
            label11 = new Label();
            TxtNumRua = new TextBox();
            label10 = new Label();
            TxtRua = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            CbGenero = new ComboBox();
            LbGenero = new Label();
            label4 = new Label();
            label5 = new Label();
            BoxCalendario = new MonthCalendar();
            BtnCalendario = new Button();
            TxtCalendario = new MaskedTextBox();
            TxtCpf = new MaskedTextBox();
            CbCargo = new ComboBox();
            LbCargo = new Label();
            CbEstadoCivil = new ComboBox();
            LbEstadoCivil = new Label();
            LbCpf = new Label();
            LbDataNascimento = new Label();
            TxtNomeCompleto = new TextBox();
            LbNomeCompleto = new Label();
            BtnCancelar = new Button();
            btnPesquisar = new Button();
            LbMatricula = new Label();
            TxtMatricula = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LbTitulo = new Label();
            label1 = new Label();
            BtnEditar = new Button();
            panel1.SuspendLayout();
            PnlCtrlFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctCpf).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.edit;
            BtnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Location = new Point(116, 270);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(49, 49);
            BtnEditar.TabIndex = 1;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.MouseClick += BtnEditar_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(BtnLimpar);
            panel1.Controls.Add(BtnConfirmar);
            panel1.Controls.Add(PnlCtrlFunc);
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(LbMatricula);
            panel1.Controls.Add(TxtMatricula);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(LbTitulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(80, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 630);
            panel1.TabIndex = 0;
            panel1.MouseClick += AllForms_MouseClick;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Enabled = false;
            BtnLimpar.FlatAppearance.BorderSize = 0;
            BtnLimpar.FlatStyle = FlatStyle.Flat;
            BtnLimpar.Image = (Image)resources.GetObject("BtnLimpar.Image");
            BtnLimpar.Location = new Point(742, 578);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(43, 43);
            BtnLimpar.TabIndex = 116;
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Enabled = false;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = (Image)resources.GetObject("BtnConfirmar.Image");
            BtnConfirmar.Location = new Point(644, 578);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(43, 43);
            BtnConfirmar.TabIndex = 114;
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // PnlCtrlFunc
            // 
            PnlCtrlFunc.AutoScroll = true;
            PnlCtrlFunc.AutoScrollMargin = new Size(0, 90);
            PnlCtrlFunc.AutoScrollMinSize = new Size(0, 90);
            PnlCtrlFunc.BorderStyle = BorderStyle.FixedSingle;
            PnlCtrlFunc.Controls.Add(TxtTelefone);
            PnlCtrlFunc.Controls.Add(TxtCep);
            PnlCtrlFunc.Controls.Add(LbCep);
            PnlCtrlFunc.Controls.Add(TxtTituloEleitor);
            PnlCtrlFunc.Controls.Add(LbTituloEleitor);
            PnlCtrlFunc.Controls.Add(TxtReservista);
            PnlCtrlFunc.Controls.Add(LbReservista);
            PnlCtrlFunc.Controls.Add(TxtRg);
            PnlCtrlFunc.Controls.Add(LbRg);
            PnlCtrlFunc.Controls.Add(PctCpf);
            PnlCtrlFunc.Controls.Add(BoxCalendario2);
            PnlCtrlFunc.Controls.Add(BtnCalendario2);
            PnlCtrlFunc.Controls.Add(TxtDataEmissao);
            PnlCtrlFunc.Controls.Add(TxtSalarioBase);
            PnlCtrlFunc.Controls.Add(label26);
            PnlCtrlFunc.Controls.Add(label27);
            PnlCtrlFunc.Controls.Add(TxtCTrabalho);
            PnlCtrlFunc.Controls.Add(label28);
            PnlCtrlFunc.Controls.Add(TxtNit);
            PnlCtrlFunc.Controls.Add(label29);
            PnlCtrlFunc.Controls.Add(label24);
            PnlCtrlFunc.Controls.Add(label25);
            PnlCtrlFunc.Controls.Add(CbUF);
            PnlCtrlFunc.Controls.Add(TxtCidade);
            PnlCtrlFunc.Controls.Add(label19);
            PnlCtrlFunc.Controls.Add(label23);
            PnlCtrlFunc.Controls.Add(TxtEmail);
            PnlCtrlFunc.Controls.Add(label20);
            PnlCtrlFunc.Controls.Add(label22);
            PnlCtrlFunc.Controls.Add(TxtComplemento);
            PnlCtrlFunc.Controls.Add(label21);
            PnlCtrlFunc.Controls.Add(TxtBairro);
            PnlCtrlFunc.Controls.Add(label11);
            PnlCtrlFunc.Controls.Add(TxtNumRua);
            PnlCtrlFunc.Controls.Add(label10);
            PnlCtrlFunc.Controls.Add(TxtRua);
            PnlCtrlFunc.Controls.Add(label9);
            PnlCtrlFunc.Controls.Add(label7);
            PnlCtrlFunc.Controls.Add(label8);
            PnlCtrlFunc.Controls.Add(CbGenero);
            PnlCtrlFunc.Controls.Add(LbGenero);
            PnlCtrlFunc.Controls.Add(label4);
            PnlCtrlFunc.Controls.Add(label5);
            PnlCtrlFunc.Controls.Add(BoxCalendario);
            PnlCtrlFunc.Controls.Add(BtnCalendario);
            PnlCtrlFunc.Controls.Add(TxtCalendario);
            PnlCtrlFunc.Controls.Add(TxtCpf);
            PnlCtrlFunc.Controls.Add(CbCargo);
            PnlCtrlFunc.Controls.Add(LbCargo);
            PnlCtrlFunc.Controls.Add(CbEstadoCivil);
            PnlCtrlFunc.Controls.Add(LbEstadoCivil);
            PnlCtrlFunc.Controls.Add(LbCpf);
            PnlCtrlFunc.Controls.Add(LbDataNascimento);
            PnlCtrlFunc.Controls.Add(TxtNomeCompleto);
            PnlCtrlFunc.Controls.Add(LbNomeCompleto);
            PnlCtrlFunc.Location = new Point(67, 142);
            PnlCtrlFunc.Name = "PnlCtrlFunc";
            PnlCtrlFunc.Size = new Size(718, 434);
            PnlCtrlFunc.TabIndex = 12;
            PnlCtrlFunc.MouseClick += AllForms_MouseClick;
            // 
            // TxtTelefone
            // 
            TxtTelefone.BackColor = Color.DarkGray;
            TxtTelefone.BorderStyle = BorderStyle.FixedSingle;
            TxtTelefone.Enabled = false;
            TxtTelefone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTelefone.Location = new Point(172, 535);
            TxtTelefone.Mask = "(00) 0 0000-0000";
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(287, 31);
            TxtTelefone.TabIndex = 122;
            TxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TxtTelefone.MouseClick += TxtTelefone_MouseClick;
            // 
            // TxtCep
            // 
            TxtCep.BackColor = Color.DarkGray;
            TxtCep.BorderStyle = BorderStyle.FixedSingle;
            TxtCep.Enabled = false;
            TxtCep.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCep.ForeColor = SystemColors.WindowText;
            TxtCep.Location = new Point(172, 831);
            TxtCep.Mask = "00,000-000";
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(100, 31);
            TxtCep.TabIndex = 121;
            TxtCep.MouseClick += TxtCep_MouseClick;
            // 
            // LbCep
            // 
            LbCep.AutoSize = true;
            LbCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCep.Location = new Point(16, 835);
            LbCep.Name = "LbCep";
            LbCep.Size = new Size(47, 21);
            LbCep.TabIndex = 120;
            LbCep.Text = "*CEP:";
            // 
            // TxtTituloEleitor
            // 
            TxtTituloEleitor.BackColor = Color.DarkGray;
            TxtTituloEleitor.BorderStyle = BorderStyle.FixedSingle;
            TxtTituloEleitor.Enabled = false;
            TxtTituloEleitor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTituloEleitor.Location = new Point(171, 327);
            TxtTituloEleitor.Name = "TxtTituloEleitor";
            TxtTituloEleitor.PlaceholderText = "A Definir";
            TxtTituloEleitor.Size = new Size(287, 31);
            TxtTituloEleitor.TabIndex = 116;
            // 
            // LbTituloEleitor
            // 
            LbTituloEleitor.AutoSize = true;
            LbTituloEleitor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbTituloEleitor.Location = new Point(17, 330);
            LbTituloEleitor.Name = "LbTituloEleitor";
            LbTituloEleitor.Size = new Size(125, 21);
            LbTituloEleitor.TabIndex = 119;
            LbTituloEleitor.Text = " Titulo de Eleitor:";
            // 
            // TxtReservista
            // 
            TxtReservista.BackColor = Color.DarkGray;
            TxtReservista.BorderStyle = BorderStyle.FixedSingle;
            TxtReservista.Enabled = false;
            TxtReservista.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtReservista.Location = new Point(171, 364);
            TxtReservista.Name = "TxtReservista";
            TxtReservista.PlaceholderText = "A Definir";
            TxtReservista.Size = new Size(287, 31);
            TxtReservista.TabIndex = 117;
            // 
            // LbReservista
            // 
            LbReservista.AutoSize = true;
            LbReservista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbReservista.Location = new Point(17, 367);
            LbReservista.Name = "LbReservista";
            LbReservista.Size = new Size(88, 21);
            LbReservista.TabIndex = 118;
            LbReservista.Text = " Reservista:";
            // 
            // TxtRg
            // 
            TxtRg.BackColor = Color.DarkGray;
            TxtRg.BorderStyle = BorderStyle.FixedSingle;
            TxtRg.Enabled = false;
            TxtRg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRg.Location = new Point(172, 290);
            TxtRg.Mask = "00,000,000-0";
            TxtRg.Name = "TxtRg";
            TxtRg.Size = new Size(160, 31);
            TxtRg.TabIndex = 114;
            TxtRg.MouseClick += TxtRg_MouseClick;
            // 
            // LbRg
            // 
            LbRg.AutoSize = true;
            LbRg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbRg.Location = new Point(17, 293);
            LbRg.Name = "LbRg";
            LbRg.Size = new Size(41, 21);
            LbRg.TabIndex = 115;
            LbRg.Text = "*RG:";
            // 
            // PctCpf
            // 
            PctCpf.BackgroundImageLayout = ImageLayout.Stretch;
            PctCpf.Enabled = false;
            PctCpf.Location = new Point(338, 181);
            PctCpf.Name = "PctCpf";
            PctCpf.Size = new Size(28, 28);
            PctCpf.TabIndex = 113;
            PctCpf.TabStop = false;
            // 
            // BoxCalendario2
            // 
            BoxCalendario2.Location = new Point(471, 1055);
            BoxCalendario2.Name = "BoxCalendario2";
            BoxCalendario2.ShowToday = false;
            BoxCalendario2.ShowTodayCircle = false;
            BoxCalendario2.TabIndex = 102;
            BoxCalendario2.Visible = false;
            BoxCalendario2.DateChanged += BoxCalendario2_DateChanged;
            // 
            // BtnCalendario2
            // 
            BtnCalendario2.BackgroundImage = Properties.Resources.calendario;
            BtnCalendario2.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCalendario2.Enabled = false;
            BtnCalendario2.FlatAppearance.BorderSize = 0;
            BtnCalendario2.FlatStyle = FlatStyle.Flat;
            BtnCalendario2.Location = new Point(299, 1132);
            BtnCalendario2.Name = "BtnCalendario2";
            BtnCalendario2.Size = new Size(26, 26);
            BtnCalendario2.TabIndex = 101;
            BtnCalendario2.UseVisualStyleBackColor = true;
            BtnCalendario2.MouseClick += BtnCalendario2_MouseClick;
            // 
            // TxtDataEmissao
            // 
            TxtDataEmissao.BackColor = Color.DarkGray;
            TxtDataEmissao.BorderStyle = BorderStyle.FixedSingle;
            TxtDataEmissao.Enabled = false;
            TxtDataEmissao.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDataEmissao.Location = new Point(172, 1129);
            TxtDataEmissao.Mask = "00/00/0000";
            TxtDataEmissao.Name = "TxtDataEmissao";
            TxtDataEmissao.PromptChar = 'X';
            TxtDataEmissao.Size = new Size(121, 31);
            TxtDataEmissao.TabIndex = 20;
            TxtDataEmissao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TxtDataEmissao.MouseClick += TxtDataEmissao_MouseClick;
            // 
            // TxtSalarioBase
            // 
            TxtSalarioBase.BackColor = Color.DarkGray;
            TxtSalarioBase.BorderStyle = BorderStyle.FixedSingle;
            TxtSalarioBase.Enabled = false;
            TxtSalarioBase.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioBase.Location = new Point(172, 1167);
            TxtSalarioBase.Name = "TxtSalarioBase";
            TxtSalarioBase.PlaceholderText = " R$1.304,98";
            TxtSalarioBase.ReadOnly = true;
            TxtSalarioBase.Size = new Size(220, 31);
            TxtSalarioBase.TabIndex = 21;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(15, 1170);
            label26.Name = "label26";
            label26.Size = new Size(104, 21);
            label26.TabIndex = 99;
            label26.Text = "*Salário Base:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(15, 1133);
            label27.Name = "label27";
            label27.Size = new Size(134, 21);
            label27.TabIndex = 97;
            label27.Text = "*Data de Emissão:";
            // 
            // TxtCTrabalho
            // 
            TxtCTrabalho.BackColor = Color.DarkGray;
            TxtCTrabalho.BorderStyle = BorderStyle.FixedSingle;
            TxtCTrabalho.Enabled = false;
            TxtCTrabalho.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCTrabalho.Location = new Point(172, 1055);
            TxtCTrabalho.Name = "TxtCTrabalho";
            TxtCTrabalho.PlaceholderText = "A Definir";
            TxtCTrabalho.Size = new Size(287, 31);
            TxtCTrabalho.TabIndex = 18;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(15, 1058);
            label28.Name = "label28";
            label28.Size = new Size(118, 21);
            label28.TabIndex = 95;
            label28.Text = "*C. de Trabalho:";
            // 
            // TxtNit
            // 
            TxtNit.BackColor = Color.DarkGray;
            TxtNit.BorderStyle = BorderStyle.FixedSingle;
            TxtNit.Enabled = false;
            TxtNit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNit.Location = new Point(172, 1018);
            TxtNit.Name = "TxtNit";
            TxtNit.PlaceholderText = "A Definir";
            TxtNit.Size = new Size(220, 31);
            TxtNit.TabIndex = 17;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(15, 1021);
            label29.Name = "label29";
            label29.Size = new Size(44, 21);
            label29.TabIndex = 93;
            label29.Text = "*NIT:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.FlatStyle = FlatStyle.Flat;
            label24.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ImageAlign = ContentAlignment.MiddleRight;
            label24.Location = new Point(35, 925);
            label24.Name = "label24";
            label24.Padding = new Padding(10, 0, 0, 0);
            label24.Size = new Size(293, 32);
            label24.TabIndex = 91;
            label24.Text = "Informações Profissionais";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.FlatStyle = FlatStyle.Flat;
            label25.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label25.Location = new Point(15, 927);
            label25.Name = "label25";
            label25.Size = new Size(347, 37);
            label25.TabIndex = 90;
            label25.Text = "______________________________";
            // 
            // CbUF
            // 
            CbUF.AutoCompleteCustomSource.AddRange(new string[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE ", "TO" });
            CbUF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbUF.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbUF.BackColor = Color.DarkGray;
            CbUF.Enabled = false;
            CbUF.FlatStyle = FlatStyle.Flat;
            CbUF.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbUF.FormattingEnabled = true;
            CbUF.ItemHeight = 23;
            CbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE ", "TO" });
            CbUF.Location = new Point(171, 756);
            CbUF.MaxDropDownItems = 6;
            CbUF.Name = "CbUF";
            CbUF.Size = new Size(160, 31);
            CbUF.TabIndex = 15;
            // 
            // TxtCidade
            // 
            TxtCidade.BackColor = Color.DarkGray;
            TxtCidade.BorderStyle = BorderStyle.FixedSingle;
            TxtCidade.Enabled = false;
            TxtCidade.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCidade.Location = new Point(171, 794);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.PlaceholderText = "A Definir";
            TxtCidade.Size = new Size(287, 31);
            TxtCidade.TabIndex = 16;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(15, 797);
            label19.Name = "label19";
            label19.Size = new Size(68, 21);
            label19.TabIndex = 88;
            label19.Text = "*Cidade:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(15, 760);
            label23.Name = "label23";
            label23.Size = new Size(39, 21);
            label23.TabIndex = 86;
            label23.Text = "*UF:";
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = Color.DarkGray;
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Enabled = false;
            TxtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(172, 572);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "A Definir";
            TxtEmail.Size = new Size(287, 31);
            TxtEmail.TabIndex = 10;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(15, 575);
            label20.Name = "label20";
            label20.Size = new Size(55, 21);
            label20.TabIndex = 84;
            label20.Text = " Email:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(15, 538);
            label22.Name = "label22";
            label22.Size = new Size(77, 21);
            label22.TabIndex = 82;
            label22.Text = "*Telefone:";
            // 
            // TxtComplemento
            // 
            TxtComplemento.BackColor = Color.DarkGray;
            TxtComplemento.BorderStyle = BorderStyle.FixedSingle;
            TxtComplemento.Enabled = false;
            TxtComplemento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtComplemento.Location = new Point(171, 719);
            TxtComplemento.Name = "TxtComplemento";
            TxtComplemento.PlaceholderText = "A Definir";
            TxtComplemento.Size = new Size(287, 31);
            TxtComplemento.TabIndex = 14;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(15, 722);
            label21.Name = "label21";
            label21.Size = new Size(116, 21);
            label21.TabIndex = 80;
            label21.Text = " Complemento:";
            // 
            // TxtBairro
            // 
            TxtBairro.BackColor = Color.DarkGray;
            TxtBairro.BorderStyle = BorderStyle.FixedSingle;
            TxtBairro.Enabled = false;
            TxtBairro.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBairro.Location = new Point(171, 682);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.PlaceholderText = "A Definir";
            TxtBairro.Size = new Size(287, 31);
            TxtBairro.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 685);
            label11.Name = "label11";
            label11.Size = new Size(62, 21);
            label11.TabIndex = 78;
            label11.Text = "*Bairro:";
            // 
            // TxtNumRua
            // 
            TxtNumRua.BackColor = Color.DarkGray;
            TxtNumRua.BorderStyle = BorderStyle.FixedSingle;
            TxtNumRua.Enabled = false;
            TxtNumRua.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNumRua.Location = new Point(171, 645);
            TxtNumRua.Name = "TxtNumRua";
            TxtNumRua.PlaceholderText = "A Definir";
            TxtNumRua.Size = new Size(287, 31);
            TxtNumRua.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 648);
            label10.Name = "label10";
            label10.Size = new Size(78, 21);
            label10.TabIndex = 76;
            label10.Text = "*Numero:";
            // 
            // TxtRua
            // 
            TxtRua.BackColor = Color.DarkGray;
            TxtRua.BorderStyle = BorderStyle.FixedSingle;
            TxtRua.Enabled = false;
            TxtRua.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRua.Location = new Point(171, 608);
            TxtRua.Name = "TxtRua";
            TxtRua.PlaceholderText = "A Definir";
            TxtRua.Size = new Size(287, 31);
            TxtRua.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 611);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 74;
            label9.Text = "*Rua:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(35, 443);
            label7.Name = "label7";
            label7.Padding = new Padding(10, 0, 0, 0);
            label7.Size = new Size(364, 32);
            label7.TabIndex = 72;
            label7.Text = "Informações Pessoais Adicionais";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(15, 445);
            label8.Name = "label8";
            label8.Size = new Size(402, 37);
            label8.TabIndex = 71;
            label8.Text = "___________________________________";
            // 
            // CbGenero
            // 
            CbGenero.AutoCompleteCustomSource.AddRange(new string[] { "Masculino", "Feminino", "Transgênero", "Cisgênero", "Outro" });
            CbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbGenero.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbGenero.BackColor = Color.DarkGray;
            CbGenero.Enabled = false;
            CbGenero.FlatStyle = FlatStyle.Flat;
            CbGenero.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbGenero.FormattingEnabled = true;
            CbGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Transgênero", "Cisgênero", "Outro" });
            CbGenero.Location = new Point(172, 253);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(160, 31);
            CbGenero.TabIndex = 8;
            // 
            // LbGenero
            // 
            LbGenero.AutoSize = true;
            LbGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbGenero.Location = new Point(15, 257);
            LbGenero.Name = "LbGenero";
            LbGenero.Size = new Size(71, 21);
            LbGenero.TabIndex = 69;
            LbGenero.Text = "*Gênero:";
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
            label4.TabIndex = 90;
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
            label5.TabIndex = 80;
            label5.Text = "___________________________";
            // 
            // BoxCalendario
            // 
            BoxCalendario.Location = new Point(464, 110);
            BoxCalendario.Name = "BoxCalendario";
            BoxCalendario.ShowToday = false;
            BoxCalendario.ShowTodayCircle = false;
            BoxCalendario.TabIndex = 56;
            BoxCalendario.Visible = false;
            BoxCalendario.DateChanged += BoxCalendario_DateChanged;
            // 
            // BtnCalendario
            // 
            BtnCalendario.BackgroundImage = Properties.Resources.calendario;
            BtnCalendario.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCalendario.Enabled = false;
            BtnCalendario.FlatAppearance.BorderSize = 0;
            BtnCalendario.FlatStyle = FlatStyle.Flat;
            BtnCalendario.Location = new Point(304, 149);
            BtnCalendario.Name = "BtnCalendario";
            BtnCalendario.Size = new Size(26, 26);
            BtnCalendario.TabIndex = 55;
            BtnCalendario.UseVisualStyleBackColor = true;
            BtnCalendario.MouseClick += BtnCalendario_MouseClick;
            // 
            // TxtCalendario
            // 
            TxtCalendario.BackColor = Color.DarkGray;
            TxtCalendario.BorderStyle = BorderStyle.FixedSingle;
            TxtCalendario.Enabled = false;
            TxtCalendario.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCalendario.Location = new Point(172, 146);
            TxtCalendario.Mask = "00/00/0000";
            TxtCalendario.Name = "TxtCalendario";
            TxtCalendario.PromptChar = 'X';
            TxtCalendario.Size = new Size(121, 31);
            TxtCalendario.TabIndex = 5;
            TxtCalendario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TxtCalendario.MouseClick += TxtCalendario_MouseClick;
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = Color.DarkGray;
            TxtCpf.BorderStyle = BorderStyle.FixedSingle;
            TxtCpf.Enabled = false;
            TxtCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.Location = new Point(172, 181);
            TxtCpf.Mask = "000,000,000-00";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.PromptChar = 'X';
            TxtCpf.Size = new Size(160, 31);
            TxtCpf.TabIndex = 6;
            TxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TxtCpf.MouseClick += TxtCpf_MouseClick;
            TxtCpf.TextChanged += TxtCpf_TextChanged;
            // 
            // CbCargo
            // 
            CbCargo.AutoCompleteCustomSource.AddRange(new string[] { "Analista de Sistema", "Suporte TI", "Desenvolvedor de Software" });
            CbCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbCargo.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbCargo.BackColor = Color.DarkGray;
            CbCargo.Enabled = false;
            CbCargo.FlatStyle = FlatStyle.Flat;
            CbCargo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbCargo.FormattingEnabled = true;
            CbCargo.Items.AddRange(new object[] { "Analista de Sistema", "Suporte TI", "Desenvolvedor de Software" });
            CbCargo.Location = new Point(172, 1092);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(220, 31);
            CbCargo.TabIndex = 19;
            // 
            // LbCargo
            // 
            LbCargo.AutoSize = true;
            LbCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCargo.Location = new Point(15, 1096);
            LbCargo.Name = "LbCargo";
            LbCargo.Size = new Size(62, 21);
            LbCargo.TabIndex = 38;
            LbCargo.Text = "*Cargo:";
            // 
            // CbEstadoCivil
            // 
            CbEstadoCivil.AutoCompleteCustomSource.AddRange(new string[] { "Casado", "Solteiro", "Uniao Estavel", "Outro" });
            CbEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbEstadoCivil.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbEstadoCivil.BackColor = Color.DarkGray;
            CbEstadoCivil.Enabled = false;
            CbEstadoCivil.FlatStyle = FlatStyle.Flat;
            CbEstadoCivil.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbEstadoCivil.FormattingEnabled = true;
            CbEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Uniao Estável", "Outro" });
            CbEstadoCivil.Location = new Point(172, 217);
            CbEstadoCivil.Name = "CbEstadoCivil";
            CbEstadoCivil.Size = new Size(160, 31);
            CbEstadoCivil.TabIndex = 7;
            // 
            // LbEstadoCivil
            // 
            LbEstadoCivil.AutoSize = true;
            LbEstadoCivil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbEstadoCivil.Location = new Point(15, 221);
            LbEstadoCivil.Name = "LbEstadoCivil";
            LbEstadoCivil.Size = new Size(100, 21);
            LbEstadoCivil.TabIndex = 36;
            LbEstadoCivil.Text = "*Estado Civil:";
            // 
            // LbCpf
            // 
            LbCpf.AutoSize = true;
            LbCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCpf.Location = new Point(15, 187);
            LbCpf.Name = "LbCpf";
            LbCpf.Size = new Size(47, 21);
            LbCpf.TabIndex = 35;
            LbCpf.Text = "*CPF:";
            // 
            // LbDataNascimento
            // 
            LbDataNascimento.AutoSize = true;
            LbDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbDataNascimento.Location = new Point(15, 150);
            LbDataNascimento.Name = "LbDataNascimento";
            LbDataNascimento.Size = new Size(160, 21);
            LbDataNascimento.TabIndex = 34;
            LbDataNascimento.Text = "*Data de Nascimento:";
            // 
            // TxtNomeCompleto
            // 
            TxtNomeCompleto.BackColor = Color.DarkGray;
            TxtNomeCompleto.BorderStyle = BorderStyle.FixedSingle;
            TxtNomeCompleto.Enabled = false;
            TxtNomeCompleto.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNomeCompleto.Location = new Point(172, 110);
            TxtNomeCompleto.Name = "TxtNomeCompleto";
            TxtNomeCompleto.PlaceholderText = " Digite o nome aqui";
            TxtNomeCompleto.Size = new Size(287, 31);
            TxtNomeCompleto.TabIndex = 4;
            // 
            // LbNomeCompleto
            // 
            LbNomeCompleto.AutoSize = true;
            LbNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeCompleto.Location = new Point(15, 113);
            LbNomeCompleto.Name = "LbNomeCompleto";
            LbNomeCompleto.Size = new Size(135, 21);
            LbNomeCompleto.TabIndex = 32;
            LbNomeCompleto.Text = "*Nome Completo:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.Location = new Point(693, 578);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(43, 43);
            BtnCancelar.TabIndex = 115;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.LightGray;
            btnPesquisar.BackgroundImage = Properties.Resources.Search;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Stretch;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(312, 103);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 32);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.MouseClick += BtnPesquisar_MouseClick;
            // 
            // LbMatricula
            // 
            LbMatricula.AutoSize = true;
            LbMatricula.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LbMatricula.Location = new Point(67, 103);
            LbMatricula.Name = "LbMatricula";
            LbMatricula.Size = new Size(101, 25);
            LbMatricula.TabIndex = 8;
            LbMatricula.Text = "Matrícula:";
            // 
            // TxtMatricula
            // 
            TxtMatricula.BackColor = Color.DarkGray;
            TxtMatricula.BorderStyle = BorderStyle.FixedSingle;
            TxtMatricula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricula.Location = new Point(169, 103);
            TxtMatricula.MaxLength = 6;
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.PlaceholderText = " XX-XXXX";
            TxtMatricula.Size = new Size(134, 32);
            TxtMatricula.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(BtnEditar);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(810, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 526);
            panel3.TabIndex = 6;
            panel3.MouseClick += AllForms_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 322);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 122;
            label2.Text = "EDITAR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.circle_account1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 245);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.FlatStyle = FlatStyle.Flat;
            LbTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Image = (Image)resources.GetObject("LbTitulo.Image");
            LbTitulo.ImageAlign = ContentAlignment.MiddleRight;
            LbTitulo.Location = new Point(70, 28);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Padding = new Padding(10, 0, 0, 0);
            LbTitulo.Size = new Size(452, 41);
            LbTitulo.TabIndex = 50;
            LbTitulo.Text = "Alterar Cadastro Funcionário      ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(60, 42);
            label1.Name = "label1";
            label1.Size = new Size(457, 37);
            label1.TabIndex = 60;
            label1.Text = "________________________________________";
            // 
            // FormAlterarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 751);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAlterarCadastro";
            Text = "FormAlterarCadastro";
            MouseClick += AllForms_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PnlCtrlFunc.ResumeLayout(false);
            PnlCtrlFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctCpf).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LbTitulo;
        private Label label1;
        private Panel panel3;
        private TextBox TxtMatricula;
        private Label LbMatricula;
        private Button btnPesquisar;
        private PictureBox pictureBox1;
        private Panel PnlCtrlFunc;
        private MonthCalendar BoxCalendario2;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label24;
        private Label label25;
        private Label label19;
        private Label label23;
        private Label label20;
        private Label label22;
        private Label label21;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label LbGenero;
        private Label label4;
        private Label label5;
        private MonthCalendar BoxCalendario;
        private Label LbCargo;
        private Label LbEstadoCivil;
        private Label LbCpf;
        private Label LbDataNascimento;
        private Label LbNomeCompleto;
        private Button BtnLimpar;
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private Label LbTituloEleitor;
        private Label LbReservista;
        private Label LbRg;
        private Label LbCep;
        private Label label2;
        internal ComboBox CbGenero;
        internal MaskedTextBox TxtCalendario;
        internal MaskedTextBox TxtCpf;
        internal ComboBox CbEstadoCivil;
        internal TextBox TxtNomeCompleto;
        internal TextBox TxtTituloEleitor;
        internal TextBox TxtReservista;
        internal MaskedTextBox TxtRg;
        internal Button BtnCalendario;
        internal PictureBox PctCpf;
        internal ComboBox CbUF;
        internal TextBox TxtCidade;
        internal TextBox TxtEmail;
        internal TextBox TxtComplemento;
        internal TextBox TxtBairro;
        internal TextBox TxtNumRua;
        internal TextBox TxtRua;
        internal MaskedTextBox TxtCep;
        internal MaskedTextBox TxtTelefone;
        internal Button BtnCalendario2;
        internal MaskedTextBox TxtDataEmissao;
        internal TextBox TxtSalarioBase;
        internal TextBox TxtCTrabalho;
        internal TextBox TxtNit;
        internal ComboBox CbCargo;
    }
}