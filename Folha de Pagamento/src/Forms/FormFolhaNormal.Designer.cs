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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFolhaNormal));
            LbFolhaNormal = new Panel();
            button1 = new Button();
            button2 = new Button();
            BtnImprimir = new Button();
            BtnConfirmar = new Button();
            label31 = new Label();
            CbAno = new ComboBox();
            label47 = new Label();
            CbMes = new ComboBox();
            PanelFolhaDetalhada = new Panel();
            panel3 = new Panel();
            panel10 = new Panel();
            label19 = new Label();
            TxtAtivo = new Label();
            panel4 = new Panel();
            TxtCLT = new Label();
            label23 = new Label();
            label24 = new Label();
            panel8 = new Panel();
            label50 = new Label();
            label46 = new Label();
            label45 = new Label();
            TxtSalarioLiquido = new Label();
            TxtTotaisDescontos = new Label();
            TxtVencimentos = new Label();
            label68 = new Label();
            label69 = new Label();
            label70 = new Label();
            panel7 = new Panel();
            label52 = new Label();
            label44 = new Label();
            TxtSalarioLiqMensal = new Label();
            TxtDataEmissao = new Label();
            label41 = new Label();
            TxtMaiorRemuneracao = new Label();
            label48 = new Label();
            label42 = new Label();
            panelFgts = new Panel();
            label5 = new Label();
            label40 = new Label();
            TxtTaxaDescFGTS = new Label();
            label39 = new Label();
            label8 = new Label();
            label43 = new Label();
            TxtTotalFGTS = new Label();
            label51 = new Label();
            TxtSalarioBaseFGTS = new Label();
            TxtValorFGTS = new Label();
            label26 = new Label();
            label29 = new Label();
            label25 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panelIrrf = new Panel();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            label22 = new Label();
            label21 = new Label();
            TxtTaxaDescIRRF = new Label();
            TxtDescIRRF = new Label();
            TxtSalarioBaseIRRF = new Label();
            TxtTotalIRRF = new Label();
            TxtValorIRRF = new Label();
            label28 = new Label();
            label30 = new Label();
            label11 = new Label();
            label15 = new Label();
            label17 = new Label();
            label16 = new Label();
            panelInss = new Panel();
            label20 = new Label();
            label18 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtTaxaDescINSS = new Label();
            TxtDescINSS = new Label();
            TxtSalarioBaseINSS = new Label();
            TxtValorInss = new Label();
            TxtTotalInss = new Label();
            label33 = new Label();
            label32 = new Label();
            label27 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label34 = new Label();
            LbTitulo = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            LbFolhaNormal.SuspendLayout();
            PanelFolhaDetalhada.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panelFgts.SuspendLayout();
            panel2.SuspendLayout();
            panelIrrf.SuspendLayout();
            panelInss.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LbFolhaNormal
            // 
            LbFolhaNormal.AccessibleRole = AccessibleRole.None;
            LbFolhaNormal.BackColor = Color.LightGray;
            LbFolhaNormal.Controls.Add(button1);
            LbFolhaNormal.Controls.Add(button2);
            LbFolhaNormal.Controls.Add(BtnImprimir);
            LbFolhaNormal.Controls.Add(BtnConfirmar);
            LbFolhaNormal.Controls.Add(label31);
            LbFolhaNormal.Controls.Add(CbAno);
            LbFolhaNormal.Controls.Add(label47);
            LbFolhaNormal.Controls.Add(CbMes);
            LbFolhaNormal.Controls.Add(PanelFolhaDetalhada);
            LbFolhaNormal.Controls.Add(LbTitulo);
            LbFolhaNormal.Controls.Add(label1);
            LbFolhaNormal.Location = new Point(80, 90);
            LbFolhaNormal.Name = "LbFolhaNormal";
            LbFolhaNormal.Size = new Size(1110, 630);
            LbFolhaNormal.TabIndex = 2;
            LbFolhaNormal.MouseClick += AllForms_MouseClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.camera;
            button1.Location = new Point(1004, 582);
            button1.Name = "button1";
            button1.Size = new Size(43, 43);
            button1.TabIndex = 131;
            toolTip1.SetToolTip(button1, "Capturar tela em PDF");
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1004, 39);
            button2.Name = "button2";
            button2.Size = new Size(43, 43);
            button2.TabIndex = 130;
            toolTip1.SetToolTip(button2, "Voltar ao início");
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // BtnImprimir
            // 
            BtnImprimir.Cursor = Cursors.Hand;
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatStyle = FlatStyle.Flat;
            BtnImprimir.Image = (Image)resources.GetObject("BtnImprimir.Image");
            BtnImprimir.Location = new Point(955, 582);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(43, 43);
            BtnImprimir.TabIndex = 120;
            toolTip1.SetToolTip(BtnImprimir, "Imprimir folha");
            BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Cursor = Cursors.Hand;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = (Image)resources.GetObject("BtnConfirmar.Image");
            BtnConfirmar.Location = new Point(906, 582);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(43, 43);
            BtnConfirmar.TabIndex = 118;
            toolTip1.SetToolTip(BtnConfirmar, "Gerar folha normal");
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.MouseClick += BtnConfirmar_MouseClick;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(70, 109);
            label31.Name = "label31";
            label31.Size = new Size(127, 20);
            label31.TabIndex = 125;
            label31.Text = "Selecionar o ano:";
            // 
            // CbAno
            // 
            CbAno.BackColor = Color.DarkGray;
            CbAno.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAno.DropDownWidth = 185;
            CbAno.FlatStyle = FlatStyle.Flat;
            CbAno.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbAno.FormattingEnabled = true;
            CbAno.Location = new Point(203, 104);
            CbAno.Name = "CbAno";
            CbAno.Size = new Size(121, 31);
            CbAno.TabIndex = 124;
            toolTip1.SetToolTip(CbAno, "Selecionar o ano");
            CbAno.DropDown += CbAno_DropDown;
            CbAno.TextChanged += CbAno_TextChanged;
            CbAno.KeyPress += All_KeyPress1;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label47.Location = new Point(345, 109);
            label47.Name = "label47";
            label47.Size = new Size(130, 20);
            label47.TabIndex = 123;
            label47.Text = "Selecionar o mês:";
            // 
            // CbMes
            // 
            CbMes.BackColor = Color.DarkGray;
            CbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            CbMes.DropDownWidth = 185;
            CbMes.FlatStyle = FlatStyle.Flat;
            CbMes.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbMes.FormattingEnabled = true;
            CbMes.Location = new Point(486, 104);
            CbMes.Name = "CbMes";
            CbMes.Size = new Size(121, 31);
            CbMes.TabIndex = 121;
            toolTip1.SetToolTip(CbMes, "Selecionar o mês");
            CbMes.TextChanged += CbMes_DropDown;
            CbMes.KeyPress += All_KeyPress1;
            // 
            // PanelFolhaDetalhada
            // 
            PanelFolhaDetalhada.AutoScroll = true;
            PanelFolhaDetalhada.BorderStyle = BorderStyle.FixedSingle;
            PanelFolhaDetalhada.Controls.Add(panel3);
            PanelFolhaDetalhada.Controls.Add(panel8);
            PanelFolhaDetalhada.Controls.Add(panel7);
            PanelFolhaDetalhada.Controls.Add(panelFgts);
            PanelFolhaDetalhada.Controls.Add(panel2);
            PanelFolhaDetalhada.Controls.Add(panelIrrf);
            PanelFolhaDetalhada.Controls.Add(panelInss);
            PanelFolhaDetalhada.Controls.Add(panel1);
            PanelFolhaDetalhada.Location = new Point(67, 142);
            PanelFolhaDetalhada.Name = "PanelFolhaDetalhada";
            PanelFolhaDetalhada.Size = new Size(980, 434);
            PanelFolhaDetalhada.TabIndex = 62;
            PanelFolhaDetalhada.MouseClick += AllForms_MouseClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label24);
            panel3.Location = new Point(2, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(956, 100);
            panel3.TabIndex = 29;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label19);
            panel10.Controls.Add(TxtAtivo);
            panel10.Location = new Point(500, 38);
            panel10.Name = "panel10";
            panel10.Size = new Size(76, 50);
            panel10.TabIndex = 32;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(11, 5);
            label19.Name = "label19";
            label19.Size = new Size(51, 19);
            label19.TabIndex = 19;
            label19.Text = "Ativos";
            // 
            // TxtAtivo
            // 
            TxtAtivo.AutoSize = true;
            TxtAtivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAtivo.Location = new Point(28, 25);
            TxtAtivo.Name = "TxtAtivo";
            TxtAtivo.Size = new Size(0, 19);
            TxtAtivo.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TxtCLT);
            panel4.Controls.Add(label23);
            panel4.Location = new Point(420, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 49);
            panel4.TabIndex = 29;
            // 
            // TxtCLT
            // 
            TxtCLT.AutoSize = true;
            TxtCLT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCLT.Location = new Point(16, 24);
            TxtCLT.Name = "TxtCLT";
            TxtCLT.Size = new Size(0, 19);
            TxtCLT.TabIndex = 27;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(7, 5);
            label23.Name = "label23";
            label23.Size = new Size(32, 19);
            label23.TabIndex = 16;
            label23.Text = "CLT";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(375, 5);
            label24.Name = "label24";
            label24.Size = new Size(236, 25);
            label24.TabIndex = 8;
            label24.Text = "TOTAL DE FUNCIONÁRIOS";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label50);
            panel8.Controls.Add(label46);
            panel8.Controls.Add(label45);
            panel8.Controls.Add(TxtSalarioLiquido);
            panel8.Controls.Add(TxtTotaisDescontos);
            panel8.Controls.Add(TxtVencimentos);
            panel8.Controls.Add(label68);
            panel8.Controls.Add(label69);
            panel8.Controls.Add(label70);
            panel8.Location = new Point(2, 453);
            panel8.Name = "panel8";
            panel8.Size = new Size(956, 50);
            panel8.TabIndex = 79;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label50.Location = new Point(690, 25);
            label50.Name = "label50";
            label50.Size = new Size(25, 19);
            label50.TabIndex = 97;
            label50.Text = "R$";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label46.Location = new Point(310, 25);
            label46.Name = "label46";
            label46.Size = new Size(25, 19);
            label46.TabIndex = 96;
            label46.Text = "R$";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label45.Location = new Point(120, 25);
            label45.Name = "label45";
            label45.Size = new Size(25, 19);
            label45.TabIndex = 95;
            label45.Text = "R$";
            // 
            // TxtSalarioLiquido
            // 
            TxtSalarioLiquido.AutoSize = true;
            TxtSalarioLiquido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioLiquido.ForeColor = Color.FromArgb(0, 70, 0);
            TxtSalarioLiquido.Location = new Point(710, 25);
            TxtSalarioLiquido.MaximumSize = new Size(85, 19);
            TxtSalarioLiquido.Name = "TxtSalarioLiquido";
            TxtSalarioLiquido.Size = new Size(0, 19);
            TxtSalarioLiquido.TabIndex = 78;
            // 
            // TxtTotaisDescontos
            // 
            TxtTotaisDescontos.AutoSize = true;
            TxtTotaisDescontos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotaisDescontos.ForeColor = Color.FromArgb(170, 0, 0);
            TxtTotaisDescontos.Location = new Point(330, 25);
            TxtTotaisDescontos.MaximumSize = new Size(85, 19);
            TxtTotaisDescontos.Name = "TxtTotaisDescontos";
            TxtTotaisDescontos.Size = new Size(0, 19);
            TxtTotaisDescontos.TabIndex = 76;
            // 
            // TxtVencimentos
            // 
            TxtVencimentos.AutoSize = true;
            TxtVencimentos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVencimentos.Location = new Point(140, 25);
            TxtVencimentos.MaximumSize = new Size(85, 19);
            TxtVencimentos.Name = "TxtVencimentos";
            TxtVencimentos.Size = new Size(0, 19);
            TxtVencimentos.TabIndex = 74;
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label68.Location = new Point(690, 5);
            label68.Name = "label68";
            label68.Size = new Size(63, 19);
            label68.TabIndex = 16;
            label68.Text = "Líquido:";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label69.Location = new Point(310, 5);
            label69.Name = "label69";
            label69.Size = new Size(81, 19);
            label69.TabIndex = 15;
            label69.Text = "Descontos:";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label70.Location = new Point(120, 5);
            label70.Name = "label70";
            label70.Size = new Size(97, 19);
            label70.TabIndex = 13;
            label70.Text = "Vencimentos:";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label52);
            panel7.Controls.Add(label44);
            panel7.Controls.Add(TxtSalarioLiqMensal);
            panel7.Controls.Add(TxtDataEmissao);
            panel7.Controls.Add(label41);
            panel7.Controls.Add(TxtMaiorRemuneracao);
            panel7.Controls.Add(label48);
            panel7.Controls.Add(label42);
            panel7.Location = new Point(2, 400);
            panel7.Name = "panel7";
            panel7.Size = new Size(956, 50);
            panel7.TabIndex = 24;
            panel7.MouseClick += AllForms_MouseClick;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label52.Location = new Point(310, 25);
            label52.Name = "label52";
            label52.Size = new Size(25, 19);
            label52.TabIndex = 84;
            label52.Text = "R$";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label44.Location = new Point(120, 25);
            label44.Name = "label44";
            label44.Size = new Size(25, 19);
            label44.TabIndex = 83;
            label44.Text = "R$";
            // 
            // TxtSalarioLiqMensal
            // 
            TxtSalarioLiqMensal.AutoSize = true;
            TxtSalarioLiqMensal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioLiqMensal.Location = new Point(330, 25);
            TxtSalarioLiqMensal.MaximumSize = new Size(85, 19);
            TxtSalarioLiqMensal.Name = "TxtSalarioLiqMensal";
            TxtSalarioLiqMensal.Size = new Size(0, 19);
            TxtSalarioLiqMensal.TabIndex = 76;
            // 
            // TxtDataEmissao
            // 
            TxtDataEmissao.AutoSize = true;
            TxtDataEmissao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDataEmissao.Location = new Point(696, 25);
            TxtDataEmissao.MaximumSize = new Size(85, 19);
            TxtDataEmissao.Name = "TxtDataEmissao";
            TxtDataEmissao.Size = new Size(0, 19);
            TxtDataEmissao.TabIndex = 82;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label41.Location = new Point(310, 5);
            label41.Name = "label41";
            label41.Size = new Size(60, 19);
            label41.TabIndex = 15;
            label41.Text = "Mensal:";
            // 
            // TxtMaiorRemuneracao
            // 
            TxtMaiorRemuneracao.AutoSize = true;
            TxtMaiorRemuneracao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMaiorRemuneracao.Location = new Point(140, 25);
            TxtMaiorRemuneracao.MaximumSize = new Size(85, 19);
            TxtMaiorRemuneracao.Name = "TxtMaiorRemuneracao";
            TxtMaiorRemuneracao.Size = new Size(0, 19);
            TxtMaiorRemuneracao.TabIndex = 75;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label48.Location = new Point(690, 5);
            label48.Name = "label48";
            label48.Size = new Size(123, 19);
            label48.TabIndex = 81;
            label48.Text = "Data de emissão:";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label42.Location = new Point(120, 5);
            label42.Name = "label42";
            label42.Size = new Size(149, 19);
            label42.TabIndex = 14;
            label42.Text = "Maior Remuneração:";
            // 
            // panelFgts
            // 
            panelFgts.BorderStyle = BorderStyle.FixedSingle;
            panelFgts.Controls.Add(label5);
            panelFgts.Controls.Add(label40);
            panelFgts.Controls.Add(TxtTaxaDescFGTS);
            panelFgts.Controls.Add(label39);
            panelFgts.Controls.Add(label8);
            panelFgts.Controls.Add(label43);
            panelFgts.Controls.Add(TxtTotalFGTS);
            panelFgts.Controls.Add(label51);
            panelFgts.Controls.Add(TxtSalarioBaseFGTS);
            panelFgts.Controls.Add(TxtValorFGTS);
            panelFgts.Controls.Add(label26);
            panelFgts.Controls.Add(label29);
            panelFgts.Controls.Add(label25);
            panelFgts.Location = new Point(644, 137);
            panelFgts.Name = "panelFgts";
            panelFgts.Size = new Size(315, 257);
            panelFgts.TabIndex = 19;
            panelFgts.MouseClick += AllForms_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(120, 120);
            label5.Name = "label5";
            label5.Size = new Size(20, 19);
            label5.TabIndex = 31;
            label5.Text = "%";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label40.Location = new Point(120, 150);
            label40.Name = "label40";
            label40.Size = new Size(25, 19);
            label40.TabIndex = 28;
            label40.Text = "R$";
            // 
            // TxtTaxaDescFGTS
            // 
            TxtTaxaDescFGTS.AutoSize = true;
            TxtTaxaDescFGTS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTaxaDescFGTS.Location = new Point(150, 120);
            TxtTaxaDescFGTS.Name = "TxtTaxaDescFGTS";
            TxtTaxaDescFGTS.Size = new Size(0, 19);
            TxtTaxaDescFGTS.TabIndex = 30;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(120, 180);
            label39.Name = "label39";
            label39.Size = new Size(25, 19);
            label39.TabIndex = 27;
            label39.Text = "R$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(4, 120);
            label8.Name = "label8";
            label8.Size = new Size(66, 19);
            label8.TabIndex = 29;
            label8.Text = "FGTS % :";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label43.Location = new Point(120, 210);
            label43.Name = "label43";
            label43.Size = new Size(25, 19);
            label43.TabIndex = 26;
            label43.Text = "R$";
            // 
            // TxtTotalFGTS
            // 
            TxtTotalFGTS.AutoSize = true;
            TxtTotalFGTS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotalFGTS.Location = new Point(150, 210);
            TxtTotalFGTS.Name = "TxtTotalFGTS";
            TxtTotalFGTS.Size = new Size(0, 19);
            TxtTotalFGTS.TabIndex = 23;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label51.Location = new Point(4, 210);
            label51.Name = "label51";
            label51.Size = new Size(50, 19);
            label51.TabIndex = 22;
            label51.Text = "Total :";
            // 
            // TxtSalarioBaseFGTS
            // 
            TxtSalarioBaseFGTS.AutoSize = true;
            TxtSalarioBaseFGTS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioBaseFGTS.Location = new Point(150, 150);
            TxtSalarioBaseFGTS.Name = "TxtSalarioBaseFGTS";
            TxtSalarioBaseFGTS.Size = new Size(0, 19);
            TxtSalarioBaseFGTS.TabIndex = 19;
            // 
            // TxtValorFGTS
            // 
            TxtValorFGTS.AutoSize = true;
            TxtValorFGTS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtValorFGTS.Location = new Point(150, 180);
            TxtValorFGTS.Name = "TxtValorFGTS";
            TxtValorFGTS.Size = new Size(0, 19);
            TxtValorFGTS.TabIndex = 18;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(4, 150);
            label26.Name = "label26";
            label26.Size = new Size(85, 19);
            label26.TabIndex = 12;
            label26.Text = "Base FGTS :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(4, 180);
            label29.Name = "label29";
            label29.Size = new Size(89, 19);
            label29.TabIndex = 10;
            label29.Text = "Valor FGTS :";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(125, 20);
            label25.Name = "label25";
            label25.Size = new Size(55, 25);
            label25.TabIndex = 1;
            label25.Text = "FGTS";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 50);
            panel2.TabIndex = 18;
            panel2.MouseClick += AllForms_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(375, 10);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 7;
            label2.Text = "TOTAIS DA EMPRESA";
            // 
            // panelIrrf
            // 
            panelIrrf.BorderStyle = BorderStyle.FixedSingle;
            panelIrrf.Controls.Add(label38);
            panelIrrf.Controls.Add(label37);
            panelIrrf.Controls.Add(label36);
            panelIrrf.Controls.Add(label22);
            panelIrrf.Controls.Add(label21);
            panelIrrf.Controls.Add(TxtTaxaDescIRRF);
            panelIrrf.Controls.Add(TxtDescIRRF);
            panelIrrf.Controls.Add(TxtSalarioBaseIRRF);
            panelIrrf.Controls.Add(TxtTotalIRRF);
            panelIrrf.Controls.Add(TxtValorIRRF);
            panelIrrf.Controls.Add(label28);
            panelIrrf.Controls.Add(label30);
            panelIrrf.Controls.Add(label11);
            panelIrrf.Controls.Add(label15);
            panelIrrf.Controls.Add(label17);
            panelIrrf.Controls.Add(label16);
            panelIrrf.Location = new Point(323, 137);
            panelIrrf.Name = "panelIrrf";
            panelIrrf.Size = new Size(315, 257);
            panelIrrf.TabIndex = 10;
            panelIrrf.MouseClick += AllForms_MouseClick;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(155, 210);
            label38.Name = "label38";
            label38.Size = new Size(25, 19);
            label38.TabIndex = 28;
            label38.Text = "R$";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label37.Location = new Point(155, 180);
            label37.Name = "label37";
            label37.Size = new Size(25, 19);
            label37.TabIndex = 27;
            label37.Text = "R$";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label36.Location = new Point(155, 150);
            label36.Name = "label36";
            label36.Size = new Size(25, 19);
            label36.TabIndex = 26;
            label36.Text = "R$";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(155, 120);
            label22.Name = "label22";
            label22.Size = new Size(25, 19);
            label22.TabIndex = 25;
            label22.Text = "R$";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(155, 90);
            label21.Name = "label21";
            label21.Size = new Size(20, 19);
            label21.TabIndex = 24;
            label21.Text = "%";
            // 
            // TxtTaxaDescIRRF
            // 
            TxtTaxaDescIRRF.AutoSize = true;
            TxtTaxaDescIRRF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTaxaDescIRRF.Location = new Point(185, 90);
            TxtTaxaDescIRRF.Name = "TxtTaxaDescIRRF";
            TxtTaxaDescIRRF.Size = new Size(0, 19);
            TxtTaxaDescIRRF.TabIndex = 21;
            // 
            // TxtDescIRRF
            // 
            TxtDescIRRF.AutoSize = true;
            TxtDescIRRF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDescIRRF.Location = new Point(185, 120);
            TxtDescIRRF.Name = "TxtDescIRRF";
            TxtDescIRRF.Size = new Size(0, 19);
            TxtDescIRRF.TabIndex = 20;
            // 
            // TxtSalarioBaseIRRF
            // 
            TxtSalarioBaseIRRF.AutoSize = true;
            TxtSalarioBaseIRRF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioBaseIRRF.Location = new Point(185, 150);
            TxtSalarioBaseIRRF.Name = "TxtSalarioBaseIRRF";
            TxtSalarioBaseIRRF.Size = new Size(0, 19);
            TxtSalarioBaseIRRF.TabIndex = 19;
            // 
            // TxtTotalIRRF
            // 
            TxtTotalIRRF.AutoSize = true;
            TxtTotalIRRF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotalIRRF.ForeColor = Color.FromArgb(170, 0, 0);
            TxtTotalIRRF.Location = new Point(185, 210);
            TxtTotalIRRF.Name = "TxtTotalIRRF";
            TxtTotalIRRF.Size = new Size(0, 19);
            TxtTotalIRRF.TabIndex = 18;
            // 
            // TxtValorIRRF
            // 
            TxtValorIRRF.AutoSize = true;
            TxtValorIRRF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtValorIRRF.Location = new Point(185, 180);
            TxtValorIRRF.Name = "TxtValorIRRF";
            TxtValorIRRF.Size = new Size(0, 19);
            TxtValorIRRF.TabIndex = 17;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(4, 210);
            label28.Name = "label28";
            label28.Size = new Size(142, 19);
            label28.TabIndex = 14;
            label28.Text = "Total de descontos :";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(4, 120);
            label30.Name = "label30";
            label30.Size = new Size(46, 19);
            label30.TabIndex = 13;
            label30.Text = "IRRF :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(4, 90);
            label11.Name = "label11";
            label11.Size = new Size(62, 19);
            label11.TabIndex = 12;
            label11.Text = "IRRF % :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(4, 180);
            label15.Name = "label15";
            label15.Size = new Size(85, 19);
            label15.TabIndex = 11;
            label15.Text = "Valor IRRF :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(4, 150);
            label17.Name = "label17";
            label17.Size = new Size(81, 19);
            label17.TabIndex = 10;
            label17.Text = "Base IRRF :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(125, 20);
            label16.Name = "label16";
            label16.Size = new Size(51, 25);
            label16.TabIndex = 1;
            label16.Text = "IRRF";
            // 
            // panelInss
            // 
            panelInss.BorderStyle = BorderStyle.FixedSingle;
            panelInss.Controls.Add(label20);
            panelInss.Controls.Add(label18);
            panelInss.Controls.Add(label7);
            panelInss.Controls.Add(label4);
            panelInss.Controls.Add(label3);
            panelInss.Controls.Add(TxtTaxaDescINSS);
            panelInss.Controls.Add(TxtDescINSS);
            panelInss.Controls.Add(TxtSalarioBaseINSS);
            panelInss.Controls.Add(TxtValorInss);
            panelInss.Controls.Add(TxtTotalInss);
            panelInss.Controls.Add(label33);
            panelInss.Controls.Add(label32);
            panelInss.Controls.Add(label27);
            panelInss.Controls.Add(label12);
            panelInss.Controls.Add(label13);
            panelInss.Controls.Add(label14);
            panelInss.Location = new Point(3, 137);
            panelInss.Name = "panelInss";
            panelInss.Size = new Size(315, 257);
            panelInss.TabIndex = 9;
            panelInss.MouseClick += AllForms_MouseClick;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(155, 210);
            label20.Name = "label20";
            label20.Size = new Size(25, 19);
            label20.TabIndex = 27;
            label20.Text = "R$";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(155, 180);
            label18.Name = "label18";
            label18.Size = new Size(25, 19);
            label18.TabIndex = 26;
            label18.Text = "R$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(155, 150);
            label7.Name = "label7";
            label7.Size = new Size(25, 19);
            label7.TabIndex = 25;
            label7.Text = "R$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(155, 120);
            label4.Name = "label4";
            label4.Size = new Size(25, 19);
            label4.TabIndex = 24;
            label4.Text = "R$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(155, 90);
            label3.Name = "label3";
            label3.Size = new Size(20, 19);
            label3.TabIndex = 23;
            label3.Text = "%";
            // 
            // TxtTaxaDescINSS
            // 
            TxtTaxaDescINSS.AutoSize = true;
            TxtTaxaDescINSS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTaxaDescINSS.Location = new Point(191, 90);
            TxtTaxaDescINSS.Name = "TxtTaxaDescINSS";
            TxtTaxaDescINSS.Size = new Size(0, 19);
            TxtTaxaDescINSS.TabIndex = 22;
            // 
            // TxtDescINSS
            // 
            TxtDescINSS.AutoSize = true;
            TxtDescINSS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDescINSS.Location = new Point(191, 120);
            TxtDescINSS.Name = "TxtDescINSS";
            TxtDescINSS.Size = new Size(0, 19);
            TxtDescINSS.TabIndex = 15;
            // 
            // TxtSalarioBaseINSS
            // 
            TxtSalarioBaseINSS.AutoSize = true;
            TxtSalarioBaseINSS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalarioBaseINSS.Location = new Point(191, 150);
            TxtSalarioBaseINSS.Name = "TxtSalarioBaseINSS";
            TxtSalarioBaseINSS.Size = new Size(0, 19);
            TxtSalarioBaseINSS.TabIndex = 14;
            // 
            // TxtValorInss
            // 
            TxtValorInss.AutoSize = true;
            TxtValorInss.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtValorInss.Location = new Point(191, 180);
            TxtValorInss.Name = "TxtValorInss";
            TxtValorInss.Size = new Size(0, 19);
            TxtValorInss.TabIndex = 13;
            // 
            // TxtTotalInss
            // 
            TxtTotalInss.AutoSize = true;
            TxtTotalInss.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotalInss.ForeColor = Color.FromArgb(170, 0, 0);
            TxtTotalInss.Location = new Point(191, 210);
            TxtTotalInss.Name = "TxtTotalInss";
            TxtTotalInss.Size = new Size(0, 19);
            TxtTotalInss.TabIndex = 12;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(4, 210);
            label33.Name = "label33";
            label33.Size = new Size(142, 19);
            label33.TabIndex = 11;
            label33.Text = "Total de descontos :";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(3, 90);
            label32.Name = "label32";
            label32.Size = new Size(64, 19);
            label32.TabIndex = 10;
            label32.Text = "INSS % :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(4, 120);
            label27.Name = "label27";
            label27.Size = new Size(48, 19);
            label27.TabIndex = 9;
            label27.Text = "INSS :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(4, 180);
            label12.Name = "label12";
            label12.Size = new Size(87, 19);
            label12.TabIndex = 8;
            label12.Text = "Valor INSS :";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(125, 20);
            label13.Name = "label13";
            label13.Size = new Size(52, 25);
            label13.TabIndex = 1;
            label13.Text = "INSS";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(4, 150);
            label14.Name = "label14";
            label14.Size = new Size(91, 19);
            label14.TabIndex = 7;
            label14.Text = "Base INSS I :";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label34);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 72);
            panel1.TabIndex = 6;
            panel1.MouseClick += AllForms_MouseClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 5);
            label10.Name = "label10";
            label10.Size = new Size(331, 25);
            label10.TabIndex = 13;
            label10.Text = "JOSE ANTONIO ALVES CARNEIRO ME";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 35);
            label9.Name = "label9";
            label9.Size = new Size(537, 19);
            label9.TabIndex = 14;
            label9.Text = "RUA JORGE LUIZ REGISTRO, 48, JARDIM SANTA CRUZ, SERRANA-SP, CEP: 14150-000";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label34.Location = new Point(680, 10);
            label34.Name = "label34";
            label34.Size = new Size(235, 25);
            label34.TabIndex = 12;
            label34.Text = "CNPJ : 13.545.586/0001-11";
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
            LbTitulo.Size = new Size(342, 41);
            LbTitulo.TabIndex = 50;
            LbTitulo.Text = "Gerar Folha Normal       ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(70, 50);
            label1.Name = "label1";
            label1.Size = new Size(336, 37);
            label1.TabIndex = 60;
            label1.Text = "_____________________________";
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
            MouseClick += AllForms_MouseClick;
            LbFolhaNormal.ResumeLayout(false);
            LbFolhaNormal.PerformLayout();
            PanelFolhaDetalhada.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panelFgts.ResumeLayout(false);
            panelFgts.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelIrrf.ResumeLayout(false);
            panelIrrf.PerformLayout();
            panelInss.ResumeLayout(false);
            panelInss.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LbFolhaNormal;
        private Label LbTitulo;
        private Label label1;
        private Panel PanelFolhaDetalhada;
        private Label label41;
        private Label label42;
        private Panel panelFgts;
        private Label label26;
        private Label label29;
        private Label label25;
        private Panel panel2;
        private Panel panelIrrf;
        private Label label28;
        private Label label30;
        private Label label11;
        private Label label15;
        private Label label17;
        private Label label16;
        private Panel panelInss;
        private Label label33;
        private Label label32;
        private Label label27;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panel1;
        private Label label2;
        private Label label51;
        private Panel panel7;
        private Panel panel8;
        private Label label68;
        private Label label69;
        private Label label70;
        private Panel panel3;
        private Panel panel4;
        private Label label23;
        private Label LbClt;
        private Label label19;
        private Label label24;
        private Panel panel10;
        private Label label47;
        private ComboBox CbMes;
        private Label label31;
        private ComboBox CbAno;
        internal Label TxtDataEmissao;
        private Label label48;
        private Label label10;
        private Label label9;
        private Label label34;
        private Button BtnImprimir;
        private Button BtnConfirmar;
        private Button button2;
        private ToolTip toolTip1;
        private Label label50;
        private Label label46;
        private Label label45;
        private Label label44;
        private Label label40;
        private Label label39;
        private Label label43;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label18;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label52;
        private Label label5;
        private Label label8;
        private Label label49;
        internal Label TxtSalarioLiqMensal;
        internal Label TxtMaiorRemuneracao;
        internal Label TxtSalarioBaseFGTS;
        internal Label TxtValorFGTS;
        internal Label TxtTaxaDescIRRF;
        internal Label TxtDescIRRF;
        internal Label TxtSalarioBaseIRRF;
        internal Label TxtTotalIRRF;
        internal Label TxtValorIRRF;
        internal Label TxtTaxaDescINSS;
        internal Label TxtDescINSS;
        internal Label TxtSalarioBaseINSS;
        internal Label TxtValorInss;
        internal Label TxtTotalInss;
        internal Label TxtTotalFGTS;
        internal Label TxtSalarioLiquido;
        internal Label TxtTotaisDescontos;
        internal Label TxtVencimentos;
        internal Label TxtAtivo;
        internal Label TxtCLT;
        internal Label TxtTaxaDescFGTS;
        internal Button button1;
    }
}