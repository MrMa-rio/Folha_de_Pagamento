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
            components = new System.ComponentModel.Container();
            Button BtnEditarFoto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarCadastro));
            BtnDeletarFunc = new Button();
            panel1 = new Panel();
            BtnEditar = new Button();
            BtnDeleteFunc = new Button();
            TxtMatricula = new MaskedTextBox();
            BtnConfirmar = new Button();
            PnlCtrlFunc = new Panel();
            PctDataAdmissao = new PictureBox();
            TxtSalarioBase = new MaskedTextBox();
            PctData = new PictureBox();
            TxtNumRua = new NumericUpDown();
            TxtTituloEleitor = new MaskedTextBox();
            LbTituloEleitor = new Label();
            TxtReservista = new MaskedTextBox();
            LbReservista = new Label();
            TxtNit = new MaskedTextBox();
            LbNit = new Label();
            TxtCTrabalho = new MaskedTextBox();
            LbCarteiraTrabalho = new Label();
            CbDepartamento = new ComboBox();
            label6 = new Label();
            TxtPis = new MaskedTextBox();
            label3 = new Label();
            TxtTelefone = new MaskedTextBox();
            TxtCep = new MaskedTextBox();
            LbCep = new Label();
            TxtRg = new MaskedTextBox();
            LbRg = new Label();
            PctCpf = new PictureBox();
            BoxCalendario2 = new MonthCalendar();
            BtnCalendario2 = new Button();
            TxtDataAdmissao = new MaskedTextBox();
            label26 = new Label();
            label27 = new Label();
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
            panel3 = new Panel();
            BtnCracha = new Button();
            label12 = new Label();
            PctUser = new PictureBox();
            LbTitulo = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            process1 = new System.Diagnostics.Process();
            BtnEditarFoto = new Button();
            panel1.SuspendLayout();
            PnlCtrlFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctDataAdmissao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PctData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumRua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PctCpf).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctUser).BeginInit();
            SuspendLayout();
            // 
            // BtnEditarFoto
            // 
            BtnEditarFoto.BackgroundImage = Properties.Resources.editPhoto;
            BtnEditarFoto.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEditarFoto.Cursor = Cursors.Hand;
            BtnEditarFoto.FlatAppearance.BorderSize = 0;
            BtnEditarFoto.FlatStyle = FlatStyle.Flat;
            BtnEditarFoto.Location = new Point(218, 221);
            BtnEditarFoto.Name = "BtnEditarFoto";
            BtnEditarFoto.Size = new Size(43, 43);
            BtnEditarFoto.TabIndex = 31;
            toolTip1.SetToolTip(BtnEditarFoto, "Trocar imagem perfil");
            BtnEditarFoto.UseVisualStyleBackColor = true;
            BtnEditarFoto.MouseClick += button1_MouseClick;
            // 
            // BtnDeletarFunc
            // 
            BtnDeletarFunc.Location = new Point(0, 0);
            BtnDeletarFunc.Name = "BtnDeletarFunc";
            BtnDeletarFunc.Size = new Size(75, 23);
            BtnDeletarFunc.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(BtnDeleteFunc);
            panel1.Controls.Add(TxtMatricula);
            panel1.Controls.Add(BtnConfirmar);
            panel1.Controls.Add(PnlCtrlFunc);
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(LbMatricula);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(LbTitulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(80, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 630);
            panel1.TabIndex = 0;
            panel1.MouseClick += AllForms_MouseClick;
            // 
            // BtnEditar
            // 
            BtnEditar.BackgroundImage = Properties.Resources.edit;
            BtnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEditar.Enabled = false;
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Location = new Point(742, 578);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(43, 43);
            BtnEditar.TabIndex = 61;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.MouseClick += BtnEditar_MouseClick;
            // 
            // BtnDeleteFunc
            // 
            BtnDeleteFunc.Cursor = Cursors.Hand;
            BtnDeleteFunc.Enabled = false;
            BtnDeleteFunc.FlatAppearance.BorderSize = 0;
            BtnDeleteFunc.FlatStyle = FlatStyle.Flat;
            BtnDeleteFunc.Image = Properties.Resources.user_minus;
            BtnDeleteFunc.Location = new Point(67, 582);
            BtnDeleteFunc.Name = "BtnDeleteFunc";
            BtnDeleteFunc.Size = new Size(43, 43);
            BtnDeleteFunc.TabIndex = 33;
            toolTip1.SetToolTip(BtnDeleteFunc, "Deletar funcionário");
            BtnDeleteFunc.UseVisualStyleBackColor = true;
            BtnDeleteFunc.MouseClick += BtnDeleteFunc_MouseClick;
            // 
            // TxtMatricula
            // 
            TxtMatricula.BackColor = Color.DarkGray;
            TxtMatricula.BorderStyle = BorderStyle.FixedSingle;
            TxtMatricula.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricula.Location = new Point(169, 103);
            TxtMatricula.Mask = "00000";
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.PromptChar = ' ';
            TxtMatricula.RightToLeft = RightToLeft.No;
            TxtMatricula.Size = new Size(88, 31);
            TxtMatricula.TabIndex = 1;
            TxtMatricula.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TxtMatricula.Click += TxtMatricula_Click;
            TxtMatricula.KeyDown += TxtMatricula_KeyDown;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Cursor = Cursors.Hand;
            BtnConfirmar.Enabled = false;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = (Image)resources.GetObject("BtnConfirmar.Image");
            BtnConfirmar.Location = new Point(690, 578);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(43, 43);
            BtnConfirmar.TabIndex = 28;
            toolTip1.SetToolTip(BtnConfirmar, "Confirmar");
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.MouseClick += BtnConfirmar_MouseClick;
            // 
            // PnlCtrlFunc
            // 
            PnlCtrlFunc.AutoScroll = true;
            PnlCtrlFunc.AutoScrollMargin = new Size(0, 10);
            PnlCtrlFunc.AutoScrollMinSize = new Size(0, 90);
            PnlCtrlFunc.BorderStyle = BorderStyle.FixedSingle;
            PnlCtrlFunc.Controls.Add(PctDataAdmissao);
            PnlCtrlFunc.Controls.Add(TxtSalarioBase);
            PnlCtrlFunc.Controls.Add(PctData);
            PnlCtrlFunc.Controls.Add(TxtNumRua);
            PnlCtrlFunc.Controls.Add(TxtTituloEleitor);
            PnlCtrlFunc.Controls.Add(LbTituloEleitor);
            PnlCtrlFunc.Controls.Add(TxtReservista);
            PnlCtrlFunc.Controls.Add(LbReservista);
            PnlCtrlFunc.Controls.Add(TxtNit);
            PnlCtrlFunc.Controls.Add(LbNit);
            PnlCtrlFunc.Controls.Add(TxtCTrabalho);
            PnlCtrlFunc.Controls.Add(LbCarteiraTrabalho);
            PnlCtrlFunc.Controls.Add(CbDepartamento);
            PnlCtrlFunc.Controls.Add(label6);
            PnlCtrlFunc.Controls.Add(TxtPis);
            PnlCtrlFunc.Controls.Add(label3);
            PnlCtrlFunc.Controls.Add(TxtTelefone);
            PnlCtrlFunc.Controls.Add(TxtCep);
            PnlCtrlFunc.Controls.Add(LbCep);
            PnlCtrlFunc.Controls.Add(TxtRg);
            PnlCtrlFunc.Controls.Add(LbRg);
            PnlCtrlFunc.Controls.Add(PctCpf);
            PnlCtrlFunc.Controls.Add(BoxCalendario2);
            PnlCtrlFunc.Controls.Add(BtnCalendario2);
            PnlCtrlFunc.Controls.Add(TxtDataAdmissao);
            PnlCtrlFunc.Controls.Add(label26);
            PnlCtrlFunc.Controls.Add(label27);
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
            // PctDataAdmissao
            // 
            PctDataAdmissao.Location = new Point(294, 679);
            PctDataAdmissao.Name = "PctDataAdmissao";
            PctDataAdmissao.Size = new Size(26, 26);
            PctDataAdmissao.TabIndex = 301;
            PctDataAdmissao.TabStop = false;
            // 
            // TxtSalarioBase
            // 
            TxtSalarioBase.BackColor = Color.DarkGray;
            TxtSalarioBase.BorderStyle = BorderStyle.FixedSingle;
            TxtSalarioBase.Enabled = false;
            TxtSalarioBase.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioBase.Location = new Point(509, 625);
            TxtSalarioBase.Name = "TxtSalarioBase";
            TxtSalarioBase.ReadOnly = true;
            TxtSalarioBase.Size = new Size(156, 31);
            TxtSalarioBase.TabIndex = 300;
            TxtSalarioBase.TabStop = false;
            toolTip1.SetToolTip(TxtSalarioBase, "Este é o salário base");
            TxtSalarioBase.KeyPress += All_KeyPress;
            // 
            // PctData
            // 
            PctData.BackgroundImageLayout = ImageLayout.Stretch;
            PctData.Enabled = false;
            PctData.Location = new Point(300, 148);
            PctData.Name = "PctData";
            PctData.Size = new Size(28, 28);
            PctData.TabIndex = 137;
            PctData.TabStop = false;
            // 
            // TxtNumRua
            // 
            TxtNumRua.BackColor = Color.DarkGray;
            TxtNumRua.BorderStyle = BorderStyle.FixedSingle;
            TxtNumRua.Enabled = false;
            TxtNumRua.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNumRua.ForeColor = SystemColors.WindowText;
            TxtNumRua.Location = new Point(167, 1080);
            TxtNumRua.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            TxtNumRua.Name = "TxtNumRua";
            TxtNumRua.Size = new Size(160, 31);
            TxtNumRua.TabIndex = 25;
            toolTip1.SetToolTip(TxtNumRua, "Informe o número");
            TxtNumRua.KeyPress += All_KeyPress;
            // 
            // TxtTituloEleitor
            // 
            TxtTituloEleitor.BackColor = Color.DarkGray;
            TxtTituloEleitor.BorderStyle = BorderStyle.FixedSingle;
            TxtTituloEleitor.Enabled = false;
            TxtTituloEleitor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTituloEleitor.Location = new Point(167, 327);
            TxtTituloEleitor.Mask = "000000000000";
            TxtTituloEleitor.Name = "TxtTituloEleitor";
            TxtTituloEleitor.PromptChar = ' ';
            TxtTituloEleitor.Size = new Size(162, 31);
            TxtTituloEleitor.TabIndex = 10;
            TxtTituloEleitor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtTituloEleitor, "Digite o título");
            TxtTituloEleitor.MouseClick += TxtTituloEleitor_MouseClick;
            TxtTituloEleitor.KeyPress += All_KeyPress;
            // 
            // LbTituloEleitor
            // 
            LbTituloEleitor.AutoSize = true;
            LbTituloEleitor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbTituloEleitor.Location = new Point(10, 330);
            LbTituloEleitor.Name = "LbTituloEleitor";
            LbTituloEleitor.Size = new Size(125, 21);
            LbTituloEleitor.TabIndex = 135;
            LbTituloEleitor.Text = " Titulo de Eleitor:";
            // 
            // TxtReservista
            // 
            TxtReservista.BackColor = Color.DarkGray;
            TxtReservista.BorderStyle = BorderStyle.FixedSingle;
            TxtReservista.Enabled = false;
            TxtReservista.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtReservista.Location = new Point(167, 364);
            TxtReservista.Mask = "00000000000";
            TxtReservista.Name = "TxtReservista";
            TxtReservista.PromptChar = ' ';
            TxtReservista.Size = new Size(162, 31);
            TxtReservista.TabIndex = 11;
            TxtReservista.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtReservista, "Digite o reservista");
            TxtReservista.MouseClick += TxtReservista_MouseClick;
            TxtReservista.KeyPress += All_KeyPress;
            // 
            // LbReservista
            // 
            LbReservista.AutoSize = true;
            LbReservista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbReservista.Location = new Point(10, 367);
            LbReservista.Name = "LbReservista";
            LbReservista.Size = new Size(88, 21);
            LbReservista.TabIndex = 133;
            LbReservista.Text = " Reservista:";
            // 
            // TxtNit
            // 
            TxtNit.BackColor = Color.DarkGray;
            TxtNit.BorderStyle = BorderStyle.FixedSingle;
            TxtNit.Enabled = false;
            TxtNit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNit.Location = new Point(509, 588);
            TxtNit.Mask = "00000000000";
            TxtNit.Name = "TxtNit";
            TxtNit.PromptChar = ' ';
            TxtNit.Size = new Size(156, 31);
            TxtNit.TabIndex = 15;
            TxtNit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtNit, "Digite o NIS");
            TxtNit.MouseClick += TxtNit_MouseClick;
            TxtNit.KeyPress += All_KeyPress;
            // 
            // LbNit
            // 
            LbNit.AutoSize = true;
            LbNit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNit.Location = new Point(372, 591);
            LbNit.Name = "LbNit";
            LbNit.Size = new Size(44, 21);
            LbNit.TabIndex = 131;
            LbNit.Text = "*NIT:";
            // 
            // TxtCTrabalho
            // 
            TxtCTrabalho.BackColor = Color.DarkGray;
            TxtCTrabalho.BorderStyle = BorderStyle.FixedSingle;
            TxtCTrabalho.Enabled = false;
            TxtCTrabalho.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCTrabalho.Location = new Point(167, 629);
            TxtCTrabalho.Mask = "0000000 | 000-0";
            TxtCTrabalho.Name = "TxtCTrabalho";
            TxtCTrabalho.Size = new Size(156, 31);
            TxtCTrabalho.TabIndex = 16;
            TxtCTrabalho.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtCTrabalho, "Digite a carteira de trabalho");
            TxtCTrabalho.MouseClick += TxtCTrabalho_MouseClick;
            TxtCTrabalho.KeyPress += All_KeyPress;
            // 
            // LbCarteiraTrabalho
            // 
            LbCarteiraTrabalho.AutoSize = true;
            LbCarteiraTrabalho.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCarteiraTrabalho.Location = new Point(10, 632);
            LbCarteiraTrabalho.Name = "LbCarteiraTrabalho";
            LbCarteiraTrabalho.Size = new Size(118, 21);
            LbCarteiraTrabalho.TabIndex = 129;
            LbCarteiraTrabalho.Text = "*C. de Trabalho:";
            // 
            // CbDepartamento
            // 
            CbDepartamento.AutoCompleteCustomSource.AddRange(new string[] { "Contabil", "Adminstração", "Engenharia", "Produção" });
            CbDepartamento.AutoCompleteMode = AutoCompleteMode.Suggest;
            CbDepartamento.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbDepartamento.BackColor = Color.DarkGray;
            CbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            CbDepartamento.Enabled = false;
            CbDepartamento.FlatStyle = FlatStyle.Flat;
            CbDepartamento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbDepartamento.ForeColor = SystemColors.WindowText;
            CbDepartamento.FormattingEnabled = true;
            CbDepartamento.Items.AddRange(new object[] { "Contabil", "Adminstração", "Engenharia", "Produção" });
            CbDepartamento.Location = new Point(509, 551);
            CbDepartamento.Name = "CbDepartamento";
            CbDepartamento.Size = new Size(185, 31);
            CbDepartamento.TabIndex = 13;
            toolTip1.SetToolTip(CbDepartamento, "Escolha o departamento");
            CbDepartamento.KeyPress += All_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(372, 555);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 127;
            label6.Text = "*Departamento:";
            // 
            // TxtPis
            // 
            TxtPis.BackColor = Color.DarkGray;
            TxtPis.BorderStyle = BorderStyle.FixedSingle;
            TxtPis.Enabled = false;
            TxtPis.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPis.Location = new Point(167, 592);
            TxtPis.Mask = "000,00000,00-0";
            TxtPis.Name = "TxtPis";
            TxtPis.Size = new Size(156, 31);
            TxtPis.TabIndex = 14;
            TxtPis.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtPis, "Digite o PIS");
            TxtPis.MouseClick += TxtPis_MouseClick;
            TxtPis.KeyPress += All_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 595);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 126;
            label3.Text = "*PIS/PASEP:";
            // 
            // TxtTelefone
            // 
            TxtTelefone.BackColor = Color.DarkGray;
            TxtTelefone.BorderStyle = BorderStyle.FixedSingle;
            TxtTelefone.Enabled = false;
            TxtTelefone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTelefone.Location = new Point(167, 859);
            TxtTelefone.Mask = "(00) 0 0000-0000";
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(287, 31);
            TxtTelefone.TabIndex = 19;
            TxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtTelefone, "Digite o telefone");
            TxtTelefone.MouseClick += TxtTelefone_MouseClick;
            TxtTelefone.KeyPress += All_KeyPress;
            // 
            // TxtCep
            // 
            TxtCep.BackColor = Color.DarkGray;
            TxtCep.BorderStyle = BorderStyle.FixedSingle;
            TxtCep.Enabled = false;
            TxtCep.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCep.ForeColor = SystemColors.WindowText;
            TxtCep.Location = new Point(167, 970);
            TxtCep.Mask = "00,000-000";
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(100, 31);
            TxtCep.TabIndex = 22;
            TxtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtCep, "Digite o CEP");
            TxtCep.MouseClick += TxtCep_MouseClick;
            TxtCep.KeyPress += All_KeyPress;
            TxtCep.Leave += TxtCep_Leave;
            // 
            // LbCep
            // 
            LbCep.AutoSize = true;
            LbCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCep.Location = new Point(10, 973);
            LbCep.Name = "LbCep";
            LbCep.Size = new Size(47, 21);
            LbCep.TabIndex = 120;
            LbCep.Text = "*CEP:";
            // 
            // TxtRg
            // 
            TxtRg.BackColor = Color.DarkGray;
            TxtRg.BorderStyle = BorderStyle.FixedSingle;
            TxtRg.Enabled = false;
            TxtRg.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRg.Location = new Point(167, 290);
            TxtRg.Mask = "00,000,000-0";
            TxtRg.Name = "TxtRg";
            TxtRg.Size = new Size(160, 31);
            TxtRg.TabIndex = 9;
            TxtRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtRg, "Digite o RG");
            TxtRg.MouseClick += TxtRg_MouseClick;
            TxtRg.KeyPress += All_KeyPress;
            // 
            // LbRg
            // 
            LbRg.AutoSize = true;
            LbRg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbRg.Location = new Point(10, 293);
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
            BoxCalendario2.Location = new Point(463, 677);
            BoxCalendario2.Name = "BoxCalendario2";
            BoxCalendario2.ShowToday = false;
            BoxCalendario2.ShowTodayCircle = false;
            BoxCalendario2.TabIndex = 102;
            BoxCalendario2.TabStop = false;
            BoxCalendario2.Visible = false;
            BoxCalendario2.DateChanged += BoxCalendario2_DateChanged;
            // 
            // BtnCalendario2
            // 
            BtnCalendario2.BackgroundImage = Properties.Resources.calendario;
            BtnCalendario2.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCalendario2.Cursor = Cursors.Hand;
            BtnCalendario2.Enabled = false;
            BtnCalendario2.FlatAppearance.BorderSize = 0;
            BtnCalendario2.FlatStyle = FlatStyle.Flat;
            BtnCalendario2.Location = new Point(326, 679);
            BtnCalendario2.Name = "BtnCalendario2";
            BtnCalendario2.Size = new Size(26, 26);
            BtnCalendario2.TabIndex = 101;
            BtnCalendario2.TabStop = false;
            toolTip1.SetToolTip(BtnCalendario2, "Abrir calendário");
            BtnCalendario2.UseVisualStyleBackColor = true;
            BtnCalendario2.MouseClick += BtnCalendario2_MouseClick;
            // 
            // TxtDataAdmissao
            // 
            TxtDataAdmissao.BackColor = Color.DarkGray;
            TxtDataAdmissao.BorderStyle = BorderStyle.FixedSingle;
            TxtDataAdmissao.Enabled = false;
            TxtDataAdmissao.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDataAdmissao.Location = new Point(167, 677);
            TxtDataAdmissao.Mask = "00/00/0000";
            TxtDataAdmissao.Name = "TxtDataAdmissao";
            TxtDataAdmissao.Size = new Size(121, 31);
            TxtDataAdmissao.TabIndex = 18;
            toolTip1.SetToolTip(TxtDataAdmissao, "Digite a data");
            TxtDataAdmissao.MouseClick += TxtDataEmissao_MouseClick;
            TxtDataAdmissao.KeyPress += All_KeyPress;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(372, 628);
            label26.Name = "label26";
            label26.Size = new Size(104, 21);
            label26.TabIndex = 99;
            label26.Text = "*Salário Base:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(10, 680);
            label27.Name = "label27";
            label27.Size = new Size(145, 21);
            label27.TabIndex = 97;
            label27.Text = "*Data de Admissão:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.FlatStyle = FlatStyle.Flat;
            label24.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ImageAlign = ContentAlignment.MiddleRight;
            label24.Location = new Point(30, 459);
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
            label25.Location = new Point(10, 461);
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
            CbUF.DropDownStyle = ComboBoxStyle.DropDownList;
            CbUF.Enabled = false;
            CbUF.FlatStyle = FlatStyle.Flat;
            CbUF.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbUF.FormattingEnabled = true;
            CbUF.ItemHeight = 23;
            CbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE ", "TO" });
            CbUF.Location = new Point(167, 1006);
            CbUF.MaxDropDownItems = 6;
            CbUF.Name = "CbUF";
            CbUF.Size = new Size(160, 31);
            CbUF.TabIndex = 23;
            CbUF.KeyPress += All_KeyPress;
            // 
            // TxtCidade
            // 
            TxtCidade.BackColor = Color.DarkGray;
            TxtCidade.BorderStyle = BorderStyle.FixedSingle;
            TxtCidade.Enabled = false;
            TxtCidade.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCidade.Location = new Point(167, 1043);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.PlaceholderText = "Digite a cidade";
            TxtCidade.Size = new Size(287, 31);
            TxtCidade.TabIndex = 24;
            toolTip1.SetToolTip(TxtCidade, "Digite a cidade");
            TxtCidade.KeyPress += All_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(10, 1046);
            label19.Name = "label19";
            label19.Size = new Size(68, 21);
            label19.TabIndex = 88;
            label19.Text = "*Cidade:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(10, 1010);
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
            TxtEmail.Location = new Point(167, 896);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "digiteaqui@seuemail.com";
            TxtEmail.Size = new Size(287, 31);
            TxtEmail.TabIndex = 20;
            TxtEmail.KeyPress += All_KeyPress1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(10, 899);
            label20.Name = "label20";
            label20.Size = new Size(55, 21);
            label20.TabIndex = 84;
            label20.Text = " Email:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(10, 862);
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
            TxtComplemento.Location = new Point(167, 1154);
            TxtComplemento.Name = "TxtComplemento";
            TxtComplemento.PlaceholderText = "Apto.200";
            TxtComplemento.Size = new Size(287, 31);
            TxtComplemento.TabIndex = 27;
            TxtComplemento.KeyPress += All_KeyPress;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(9, 1155);
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
            TxtBairro.Location = new Point(167, 1117);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.PlaceholderText = "Digite o bairro";
            TxtBairro.Size = new Size(287, 31);
            TxtBairro.TabIndex = 26;
            toolTip1.SetToolTip(TxtBairro, "Digite o bairro");
            TxtBairro.KeyPress += All_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(9, 1118);
            label11.Name = "label11";
            label11.Size = new Size(62, 21);
            label11.TabIndex = 78;
            label11.Text = "*Bairro:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(9, 1081);
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
            TxtRua.Location = new Point(167, 932);
            TxtRua.Name = "TxtRua";
            TxtRua.PlaceholderText = "Digite a rua";
            TxtRua.Size = new Size(287, 31);
            TxtRua.TabIndex = 21;
            TxtRua.KeyPress += All_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 935);
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
            label7.Location = new Point(30, 767);
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
            label8.Location = new Point(10, 769);
            label8.Name = "label8";
            label8.Size = new Size(402, 37);
            label8.TabIndex = 71;
            label8.Text = "___________________________________";
            // 
            // CbGenero
            // 
            CbGenero.AutoCompleteCustomSource.AddRange(new string[] { "Masculino", "Feminino", "Outro" });
            CbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbGenero.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbGenero.BackColor = Color.DarkGray;
            CbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            CbGenero.Enabled = false;
            CbGenero.FlatStyle = FlatStyle.Flat;
            CbGenero.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbGenero.FormattingEnabled = true;
            CbGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            CbGenero.Location = new Point(167, 253);
            CbGenero.Name = "CbGenero";
            CbGenero.Size = new Size(160, 31);
            CbGenero.TabIndex = 8;
            toolTip1.SetToolTip(CbGenero, "Selecionar o gênero");
            CbGenero.KeyPress += All_KeyPress;
            // 
            // LbGenero
            // 
            LbGenero.AutoSize = true;
            LbGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbGenero.Location = new Point(10, 257);
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
            BoxCalendario.TabStop = false;
            BoxCalendario.Visible = false;
            BoxCalendario.DateChanged += BoxCalendario_DateChanged;
            // 
            // BtnCalendario
            // 
            BtnCalendario.BackgroundImage = Properties.Resources.calendario;
            BtnCalendario.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCalendario.Cursor = Cursors.Hand;
            BtnCalendario.Enabled = false;
            BtnCalendario.FlatAppearance.BorderSize = 0;
            BtnCalendario.FlatStyle = FlatStyle.Flat;
            BtnCalendario.Location = new Point(338, 150);
            BtnCalendario.Name = "BtnCalendario";
            BtnCalendario.Size = new Size(26, 26);
            BtnCalendario.TabIndex = 55;
            BtnCalendario.TabStop = false;
            toolTip1.SetToolTip(BtnCalendario, "Abrir calendário");
            BtnCalendario.UseVisualStyleBackColor = true;
            BtnCalendario.MouseClick += BtnCalendario_MouseClick;
            // 
            // TxtCalendario
            // 
            TxtCalendario.BackColor = Color.DarkGray;
            TxtCalendario.BorderStyle = BorderStyle.FixedSingle;
            TxtCalendario.Enabled = false;
            TxtCalendario.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCalendario.Location = new Point(167, 146);
            TxtCalendario.Mask = "00/00/0000";
            TxtCalendario.Name = "TxtCalendario";
            TxtCalendario.Size = new Size(121, 31);
            TxtCalendario.TabIndex = 5;
            TxtCalendario.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            toolTip1.SetToolTip(TxtCalendario, "Digite a data");
            TxtCalendario.MouseClick += TxtCalendario_MouseClick;
            TxtCalendario.TextChanged += TxtCalendario_TextChanged;
            TxtCalendario.KeyPress += All_KeyPress;
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = Color.DarkGray;
            TxtCpf.BorderStyle = BorderStyle.FixedSingle;
            TxtCpf.Enabled = false;
            TxtCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.Location = new Point(167, 181);
            TxtCpf.Mask = "000,000,000-00";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(160, 31);
            TxtCpf.TabIndex = 6;
            TxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(TxtCpf, "Digite o CPF");
            TxtCpf.MouseClick += TxtCpf_MouseClick;
            TxtCpf.TextChanged += TxtCpf_TextChanged;
            TxtCpf.KeyPress += All_KeyPress;
            // 
            // CbCargo
            // 
            CbCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbCargo.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbCargo.BackColor = Color.DarkGray;
            CbCargo.Enabled = false;
            CbCargo.FlatStyle = FlatStyle.Flat;
            CbCargo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbCargo.FormattingEnabled = true;
            CbCargo.Location = new Point(167, 555);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(190, 31);
            CbCargo.TabIndex = 12;
            toolTip1.SetToolTip(CbCargo, "Escolha o cargo");
            CbCargo.DropDown += CbCargo_DropDown;
            CbCargo.TextChanged += CbCargo_TextChanged;
            CbCargo.KeyPress += All_KeyPress;
            // 
            // LbCargo
            // 
            LbCargo.AutoSize = true;
            LbCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCargo.Location = new Point(10, 559);
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
            CbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            CbEstadoCivil.Enabled = false;
            CbEstadoCivil.FlatStyle = FlatStyle.Flat;
            CbEstadoCivil.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbEstadoCivil.FormattingEnabled = true;
            CbEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Uniao Estável", "Outro" });
            CbEstadoCivil.Location = new Point(167, 217);
            CbEstadoCivil.Name = "CbEstadoCivil";
            CbEstadoCivil.Size = new Size(160, 31);
            CbEstadoCivil.TabIndex = 7;
            toolTip1.SetToolTip(CbEstadoCivil, "Selecionar o estado civil");
            CbEstadoCivil.KeyPress += All_KeyPress;
            // 
            // LbEstadoCivil
            // 
            LbEstadoCivil.AutoSize = true;
            LbEstadoCivil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbEstadoCivil.Location = new Point(10, 221);
            LbEstadoCivil.Name = "LbEstadoCivil";
            LbEstadoCivil.Size = new Size(100, 21);
            LbEstadoCivil.TabIndex = 36;
            LbEstadoCivil.Text = "*Estado Civil:";
            // 
            // LbCpf
            // 
            LbCpf.AutoSize = true;
            LbCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbCpf.Location = new Point(10, 187);
            LbCpf.Name = "LbCpf";
            LbCpf.Size = new Size(47, 21);
            LbCpf.TabIndex = 35;
            LbCpf.Text = "*CPF:";
            // 
            // LbDataNascimento
            // 
            LbDataNascimento.AutoSize = true;
            LbDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbDataNascimento.Location = new Point(10, 150);
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
            TxtNomeCompleto.Location = new Point(167, 110);
            TxtNomeCompleto.Name = "TxtNomeCompleto";
            TxtNomeCompleto.PlaceholderText = "Digite o nome aqui";
            TxtNomeCompleto.Size = new Size(287, 31);
            TxtNomeCompleto.TabIndex = 4;
            toolTip1.SetToolTip(TxtNomeCompleto, "Digitar o nome");
            TxtNomeCompleto.KeyPress += All_KeyPress;
            // 
            // LbNomeCompleto
            // 
            LbNomeCompleto.AutoSize = true;
            LbNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbNomeCompleto.Location = new Point(10, 113);
            LbNomeCompleto.Name = "LbNomeCompleto";
            LbNomeCompleto.Size = new Size(135, 21);
            LbNomeCompleto.TabIndex = 32;
            LbNomeCompleto.Text = "*Nome Completo:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.Location = new Point(742, 93);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(43, 43);
            BtnCancelar.TabIndex = 29;
            toolTip1.SetToolTip(BtnCancelar, "Sair da Página");
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.MouseClick += BtnCancelar_MouseClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.LightGray;
            btnPesquisar.BackgroundImage = Properties.Resources.Search;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Stretch;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(265, 103);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 32);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Tag = "Pesquisar";
            toolTip1.SetToolTip(btnPesquisar, "Pesquisar por matrícula");
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
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(BtnCracha);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(BtnEditarFoto);
            panel3.Controls.Add(PctUser);
            panel3.Location = new Point(810, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 526);
            panel3.TabIndex = 6;
            panel3.MouseClick += AllForms_MouseClick;
            // 
            // BtnCracha
            // 
            BtnCracha.Cursor = Cursors.Hand;
            BtnCracha.Enabled = false;
            BtnCracha.FlatAppearance.BorderSize = 0;
            BtnCracha.FlatStyle = FlatStyle.Flat;
            BtnCracha.Image = Properties.Resources.contact;
            BtnCracha.Location = new Point(116, 385);
            BtnCracha.Name = "BtnCracha";
            BtnCracha.Size = new Size(43, 43);
            BtnCracha.TabIndex = 62;
            toolTip1.SetToolTip(BtnCracha, "Sair da Página");
            BtnCracha.UseVisualStyleBackColor = true;
            BtnCracha.MouseClick += BtnCracha_MouseClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(93, 351);
            label12.Name = "label12";
            label12.Size = new Size(89, 25);
            label12.TabIndex = 125;
            label12.Text = "CRACHÁ";
            // 
            // PctUser
            // 
            PctUser.BackgroundImage = Properties.Resources.circle_account1;
            PctUser.BackgroundImageLayout = ImageLayout.Stretch;
            PctUser.Location = new Point(15, 19);
            PctUser.Name = "PctUser";
            PctUser.Size = new Size(246, 245);
            PctUser.TabIndex = 0;
            PctUser.TabStop = false;
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
            label1.Size = new Size(468, 37);
            label1.TabIndex = 60;
            label1.Text = "_________________________________________";
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
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
            Load += FormAlterarCadastro_Load;
            MouseClick += AllForms_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PnlCtrlFunc.ResumeLayout(false);
            PnlCtrlFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctDataAdmissao).EndInit();
            ((System.ComponentModel.ISupportInitialize)PctData).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumRua).EndInit();
            ((System.ComponentModel.ISupportInitialize)PctCpf).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LbTitulo;
        private Label label1;
        private Panel panel3;
        private Label LbMatricula;
        private Button btnPesquisar;
        private PictureBox PctUser;
        private Panel PnlCtrlFunc;
        private MonthCalendar BoxCalendario2;
        private Label label26;
        private Label label27;
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
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private Label LbRg;
        private Label LbCep;
        internal ComboBox CbGenero;
        internal MaskedTextBox TxtCalendario;
        internal MaskedTextBox TxtCpf;
        internal ComboBox CbEstadoCivil;
        internal TextBox TxtNomeCompleto;
        internal MaskedTextBox TxtRg;
        internal Button BtnCalendario;
        internal PictureBox PctCpf;
        internal ComboBox CbUF;
        internal TextBox TxtCidade;
        internal TextBox TxtEmail;
        internal TextBox TxtComplemento;
        internal TextBox TxtBairro;
        internal TextBox TxtRua;
        internal MaskedTextBox TxtCep;
        internal MaskedTextBox TxtTelefone;
        internal Button BtnCalendario2;
        internal MaskedTextBox TxtDataAdmissao;
        internal ComboBox CbCargo;
        private MaskedTextBox TxtMatricula;
        private Label label6;
        private Label label3;
        private Label LbCarteiraTrabalho;
        private Label LbNit;
        private Label LbReservista;
        private Label LbTituloEleitor;
        internal MaskedTextBox TxtNit;
        internal MaskedTextBox TxtReservista;
        internal MaskedTextBox TxtTituloEleitor;
        internal ComboBox CbDepartamento;
        internal MaskedTextBox TxtPis;
        internal MaskedTextBox TxtCTrabalho;
        internal NumericUpDown TxtNumRua;
        internal PictureBox PctData;
        private ToolTip toolTip1;
        private MaskedTextBox TxtSalarioBase;
        private Button BtnDeleteFunc;
        private Button BtnDeletarFunc;
        private Label label12;
        private Button BtnEditar;
        private PictureBox PctDataAdmissao;
        private Button BtnCracha;
        private System.Diagnostics.Process process1;
    }
}