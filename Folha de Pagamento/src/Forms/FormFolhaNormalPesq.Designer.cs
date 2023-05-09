namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    partial class FormFolhaNormalPesq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFolhaNormalPesq));
            LbFolhaNormal = new Panel();
            button2 = new Button();
            BtnPrint = new Button();
            BtnImprimir = new Button();
            label31 = new Label();
            CbAno = new ComboBox();
            label47 = new Label();
            CbMes = new ComboBox();
            PanelFolhaDetalhada = new Panel();
            panel3 = new Panel();
            panel10 = new Panel();
            label19 = new Label();
            LbAtivos = new Label();
            panel4 = new Panel();
            label23 = new Label();
            LbClt = new Label();
            label24 = new Label();
            panel8 = new Panel();
            label53 = new Label();
            label52 = new Label();
            label22 = new Label();
            TxtVencimentos = new TextBox();
            TxtSalarioLiquido = new TextBox();
            TxtTotaisDescontos = new TextBox();
            TxtID = new Label();
            label35 = new Label();
            label68 = new Label();
            label69 = new Label();
            label70 = new Label();
            panel7 = new Panel();
            TxtDataEmissao = new TextBox();
            TxtDataLancamento = new Label();
            label5 = new Label();
            label21 = new Label();
            label20 = new Label();
            TxtSalarioLiqMensal = new TextBox();
            TxtMaiorRemuneracao = new TextBox();
            label41 = new Label();
            label48 = new Label();
            label42 = new Label();
            panelFgts = new Panel();
            TxtTaxaFGTS = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label57 = new Label();
            label56 = new Label();
            label36 = new Label();
            label51 = new Label();
            TxtTotalFGTS = new TextBox();
            label26 = new Label();
            TxtValorFGTS = new TextBox();
            label29 = new Label();
            TxtSalarioBaseFGTS = new TextBox();
            label25 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panelIrrf = new Panel();
            label8 = new Label();
            label55 = new Label();
            label50 = new Label();
            label46 = new Label();
            label45 = new Label();
            TxtTotalIRRF = new TextBox();
            TxtValorIRRF = new TextBox();
            label28 = new Label();
            TxtSalarioBaseIRRF = new TextBox();
            label30 = new Label();
            TxtDescIRRF = new TextBox();
            label11 = new Label();
            TxtTaxaDescIRRF = new TextBox();
            label15 = new Label();
            label17 = new Label();
            label16 = new Label();
            panelInss = new Panel();
            label43 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            label18 = new Label();
            TxtDescTotalINSS = new TextBox();
            TxtINSSValor = new TextBox();
            TxtTotalInss = new TextBox();
            TxtSalarioINSS = new TextBox();
            TxtValorInss = new TextBox();
            TxtINSSDesc = new TextBox();
            TxtSalarioBaseINSS = new TextBox();
            TxtTaxaINSS = new TextBox();
            TxtDescINSS = new TextBox();
            TxtTaxaDescINSS = new TextBox();
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
            LbFolhaNormal.Controls.Add(button2);
            LbFolhaNormal.Controls.Add(BtnPrint);
            LbFolhaNormal.Controls.Add(BtnImprimir);
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
            LbFolhaNormal.TabIndex = 3;
            LbFolhaNormal.MouseClick += AllForms_MouseClick;
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
            // BtnPrint
            // 
            BtnPrint.Cursor = Cursors.Hand;
            BtnPrint.FlatAppearance.BorderSize = 0;
            BtnPrint.FlatStyle = FlatStyle.Flat;
            BtnPrint.Image = (Image)resources.GetObject("BtnPrint.Image");
            BtnPrint.Location = new Point(1006, 578);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(43, 43);
            BtnPrint.TabIndex = 129;
            toolTip1.SetToolTip(BtnPrint, "Capturar tela em PDF");
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.MouseClick += BtnPrint_MouseClick;
            // 
            // BtnImprimir
            // 
            BtnImprimir.Cursor = Cursors.Hand;
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatStyle = FlatStyle.Flat;
            BtnImprimir.Image = (Image)resources.GetObject("BtnImprimir.Image");
            BtnImprimir.Location = new Point(957, 578);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(43, 43);
            BtnImprimir.TabIndex = 128;
            toolTip1.SetToolTip(BtnImprimir, "Imprimir PDF");
            BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(363, 110);
            label31.Name = "label31";
            label31.Size = new Size(130, 20);
            label31.TabIndex = 125;
            label31.Text = "Selecionar o mês:";
            // 
            // CbAno
            // 
            CbAno.BackColor = Color.DarkGray;
            CbAno.DropDownWidth = 185;
            CbAno.FlatStyle = FlatStyle.Flat;
            CbAno.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbAno.FormattingEnabled = true;
            CbAno.Location = new Point(200, 105);
            CbAno.Name = "CbAno";
            CbAno.Size = new Size(121, 31);
            CbAno.TabIndex = 124;
            CbAno.DropDown += CbAno_DropDown;
            CbAno.TextChanged += CbAno_TextChanged;
            CbAno.KeyPress += All_KeyPress;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label47.Location = new Point(67, 110);
            label47.Name = "label47";
            label47.Size = new Size(127, 20);
            label47.TabIndex = 123;
            label47.Text = "Selecionar o ano:";
            // 
            // CbMes
            // 
            CbMes.BackColor = Color.DarkGray;
            CbMes.DropDownWidth = 185;
            CbMes.FlatStyle = FlatStyle.Flat;
            CbMes.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CbMes.FormattingEnabled = true;
            CbMes.Location = new Point(499, 105);
            CbMes.Name = "CbMes";
            CbMes.Size = new Size(121, 31);
            CbMes.TabIndex = 121;
            CbMes.TextChanged += CbMes_TextChanged;
            CbMes.KeyPress += All_KeyPress;
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
            panel3.MouseClick += AllForms_MouseClick;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label19);
            panel10.Controls.Add(LbAtivos);
            panel10.Location = new Point(500, 38);
            panel10.Name = "panel10";
            panel10.Size = new Size(76, 50);
            panel10.TabIndex = 32;
            panel10.MouseClick += AllForms_MouseClick;
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
            // LbAtivos
            // 
            LbAtivos.AutoSize = true;
            LbAtivos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbAtivos.Location = new Point(23, 24);
            LbAtivos.Name = "LbAtivos";
            LbAtivos.Size = new Size(0, 19);
            LbAtivos.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label23);
            panel4.Controls.Add(LbClt);
            panel4.Location = new Point(420, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 49);
            panel4.TabIndex = 29;
            panel4.MouseClick += AllForms_MouseClick;
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
            // LbClt
            // 
            LbClt.AutoSize = true;
            LbClt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbClt.Location = new Point(14, 25);
            LbClt.Name = "LbClt";
            LbClt.Size = new Size(0, 19);
            LbClt.TabIndex = 23;
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
            panel8.Controls.Add(label53);
            panel8.Controls.Add(label52);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(TxtVencimentos);
            panel8.Controls.Add(TxtSalarioLiquido);
            panel8.Controls.Add(TxtTotaisDescontos);
            panel8.Controls.Add(TxtID);
            panel8.Controls.Add(label35);
            panel8.Controls.Add(label68);
            panel8.Controls.Add(label69);
            panel8.Controls.Add(label70);
            panel8.Location = new Point(2, 453);
            panel8.Name = "panel8";
            panel8.Size = new Size(956, 50);
            panel8.TabIndex = 79;
            panel8.MouseClick += AllForms_MouseClick;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(690, 25);
            label53.Name = "label53";
            label53.Size = new Size(20, 15);
            label53.TabIndex = 102;
            label53.Text = "R$";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(310, 25);
            label52.Name = "label52";
            label52.Size = new Size(20, 15);
            label52.TabIndex = 102;
            label52.Text = "R$";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(120, 27);
            label22.Name = "label22";
            label22.Size = new Size(20, 15);
            label22.TabIndex = 102;
            label22.Text = "R$";
            // 
            // TxtVencimentos
            // 
            TxtVencimentos.BackColor = Color.LightGray;
            TxtVencimentos.BorderStyle = BorderStyle.None;
            TxtVencimentos.Location = new Point(145, 27);
            TxtVencimentos.Name = "TxtVencimentos";
            TxtVencimentos.ReadOnly = true;
            TxtVencimentos.Size = new Size(100, 16);
            TxtVencimentos.TabIndex = 95;
            // 
            // TxtSalarioLiquido
            // 
            TxtSalarioLiquido.BackColor = Color.LightGray;
            TxtSalarioLiquido.BorderStyle = BorderStyle.None;
            TxtSalarioLiquido.Location = new Point(715, 25);
            TxtSalarioLiquido.Name = "TxtSalarioLiquido";
            TxtSalarioLiquido.ReadOnly = true;
            TxtSalarioLiquido.Size = new Size(100, 16);
            TxtSalarioLiquido.TabIndex = 98;
            // 
            // TxtTotaisDescontos
            // 
            TxtTotaisDescontos.BackColor = Color.LightGray;
            TxtTotaisDescontos.BorderStyle = BorderStyle.None;
            TxtTotaisDescontos.Location = new Point(335, 25);
            TxtTotaisDescontos.Name = "TxtTotaisDescontos";
            TxtTotaisDescontos.ReadOnly = true;
            TxtTotaisDescontos.Size = new Size(100, 16);
            TxtTotaisDescontos.TabIndex = 97;
            // 
            // TxtID
            // 
            TxtID.AutoSize = true;
            TxtID.Location = new Point(8, 25);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(0, 15);
            TxtID.TabIndex = 94;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label35.Location = new Point(8, 5);
            label35.Name = "label35";
            label35.Size = new Size(20, 15);
            label35.TabIndex = 93;
            label35.Text = "ID";
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
            panel7.Controls.Add(TxtDataEmissao);
            panel7.Controls.Add(TxtDataLancamento);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(TxtSalarioLiqMensal);
            panel7.Controls.Add(TxtMaiorRemuneracao);
            panel7.Controls.Add(label41);
            panel7.Controls.Add(label48);
            panel7.Controls.Add(label42);
            panel7.Location = new Point(2, 400);
            panel7.Name = "panel7";
            panel7.Size = new Size(956, 50);
            panel7.TabIndex = 24;
            panel7.MouseClick += AllForms_MouseClick;
            // 
            // TxtDataEmissao
            // 
            TxtDataEmissao.BackColor = Color.LightGray;
            TxtDataEmissao.BorderStyle = BorderStyle.None;
            TxtDataEmissao.Location = new Point(696, 24);
            TxtDataEmissao.Name = "TxtDataEmissao";
            TxtDataEmissao.ReadOnly = true;
            TxtDataEmissao.Size = new Size(100, 16);
            TxtDataEmissao.TabIndex = 104;
            // 
            // TxtDataLancamento
            // 
            TxtDataLancamento.AutoSize = true;
            TxtDataLancamento.Location = new Point(466, 24);
            TxtDataLancamento.Name = "TxtDataLancamento";
            TxtDataLancamento.Size = new Size(0, 15);
            TxtDataLancamento.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(460, 5);
            label5.Name = "label5";
            label5.Size = new Size(147, 19);
            label5.TabIndex = 102;
            label5.Text = "Data de lançamento:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(310, 25);
            label21.Name = "label21";
            label21.Size = new Size(20, 15);
            label21.TabIndex = 101;
            label21.Text = "R$";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(120, 25);
            label20.Name = "label20";
            label20.Size = new Size(20, 15);
            label20.TabIndex = 100;
            label20.Text = "R$";
            // 
            // TxtSalarioLiqMensal
            // 
            TxtSalarioLiqMensal.BackColor = Color.LightGray;
            TxtSalarioLiqMensal.BorderStyle = BorderStyle.None;
            TxtSalarioLiqMensal.Location = new Point(335, 24);
            TxtSalarioLiqMensal.Name = "TxtSalarioLiqMensal";
            TxtSalarioLiqMensal.ReadOnly = true;
            TxtSalarioLiqMensal.Size = new Size(100, 16);
            TxtSalarioLiqMensal.TabIndex = 99;
            // 
            // TxtMaiorRemuneracao
            // 
            TxtMaiorRemuneracao.BackColor = Color.LightGray;
            TxtMaiorRemuneracao.BorderStyle = BorderStyle.None;
            TxtMaiorRemuneracao.Location = new Point(145, 26);
            TxtMaiorRemuneracao.Name = "TxtMaiorRemuneracao";
            TxtMaiorRemuneracao.ReadOnly = true;
            TxtMaiorRemuneracao.Size = new Size(100, 16);
            TxtMaiorRemuneracao.TabIndex = 97;
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
            panelFgts.Controls.Add(TxtTaxaFGTS);
            panelFgts.Controls.Add(label3);
            panelFgts.Controls.Add(label4);
            panelFgts.Controls.Add(label6);
            panelFgts.Controls.Add(label7);
            panelFgts.Controls.Add(label57);
            panelFgts.Controls.Add(label56);
            panelFgts.Controls.Add(label36);
            panelFgts.Controls.Add(label51);
            panelFgts.Controls.Add(TxtTotalFGTS);
            panelFgts.Controls.Add(label26);
            panelFgts.Controls.Add(TxtValorFGTS);
            panelFgts.Controls.Add(label29);
            panelFgts.Controls.Add(TxtSalarioBaseFGTS);
            panelFgts.Controls.Add(label25);
            panelFgts.Location = new Point(644, 137);
            panelFgts.Name = "panelFgts";
            panelFgts.Size = new Size(315, 257);
            panelFgts.TabIndex = 19;
            panelFgts.MouseClick += AllForms_MouseClick;
            // 
            // TxtTaxaFGTS
            // 
            TxtTaxaFGTS.BackColor = Color.LightGray;
            TxtTaxaFGTS.BorderStyle = BorderStyle.None;
            TxtTaxaFGTS.Location = new Point(137, 121);
            TxtTaxaFGTS.Name = "TxtTaxaFGTS";
            TxtTaxaFGTS.ReadOnly = true;
            TxtTaxaFGTS.Size = new Size(100, 16);
            TxtTaxaFGTS.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 123);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 30;
            label3.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 61);
            label4.Name = "label4";
            label4.Size = new Size(21, 19);
            label4.TabIndex = 28;
            label4.Text = "--";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(4, 119);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 27;
            label6.Text = "FGTS %";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 61);
            label7.Name = "label7";
            label7.Size = new Size(21, 19);
            label7.TabIndex = 26;
            label7.Text = "--";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(100, 212);
            label57.Name = "label57";
            label57.Size = new Size(20, 15);
            label57.TabIndex = 25;
            label57.Text = "R$";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(100, 180);
            label56.Name = "label56";
            label56.Size = new Size(20, 15);
            label56.TabIndex = 24;
            label56.Text = "R$";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(100, 150);
            label36.Name = "label36";
            label36.Size = new Size(20, 15);
            label36.TabIndex = 23;
            label36.Text = "R$";
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
            // TxtTotalFGTS
            // 
            TxtTotalFGTS.BackColor = Color.LightGray;
            TxtTotalFGTS.BorderStyle = BorderStyle.None;
            TxtTotalFGTS.Location = new Point(137, 210);
            TxtTotalFGTS.Name = "TxtTotalFGTS";
            TxtTotalFGTS.ReadOnly = true;
            TxtTotalFGTS.Size = new Size(100, 16);
            TxtTotalFGTS.TabIndex = 22;
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
            // TxtValorFGTS
            // 
            TxtValorFGTS.BackColor = Color.LightGray;
            TxtValorFGTS.BorderStyle = BorderStyle.None;
            TxtValorFGTS.Location = new Point(137, 180);
            TxtValorFGTS.Name = "TxtValorFGTS";
            TxtValorFGTS.ReadOnly = true;
            TxtValorFGTS.Size = new Size(100, 16);
            TxtValorFGTS.TabIndex = 21;
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
            // TxtSalarioBaseFGTS
            // 
            TxtSalarioBaseFGTS.BackColor = Color.LightGray;
            TxtSalarioBaseFGTS.BorderStyle = BorderStyle.None;
            TxtSalarioBaseFGTS.Location = new Point(137, 150);
            TxtSalarioBaseFGTS.Name = "TxtSalarioBaseFGTS";
            TxtSalarioBaseFGTS.ReadOnly = true;
            TxtSalarioBaseFGTS.Size = new Size(100, 16);
            TxtSalarioBaseFGTS.TabIndex = 20;
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
            panelIrrf.Controls.Add(label8);
            panelIrrf.Controls.Add(label55);
            panelIrrf.Controls.Add(label50);
            panelIrrf.Controls.Add(label46);
            panelIrrf.Controls.Add(label45);
            panelIrrf.Controls.Add(TxtTotalIRRF);
            panelIrrf.Controls.Add(TxtValorIRRF);
            panelIrrf.Controls.Add(label28);
            panelIrrf.Controls.Add(TxtSalarioBaseIRRF);
            panelIrrf.Controls.Add(label30);
            panelIrrf.Controls.Add(TxtDescIRRF);
            panelIrrf.Controls.Add(label11);
            panelIrrf.Controls.Add(TxtTaxaDescIRRF);
            panelIrrf.Controls.Add(label15);
            panelIrrf.Controls.Add(label17);
            panelIrrf.Controls.Add(label16);
            panelIrrf.Location = new Point(323, 137);
            panelIrrf.Name = "panelIrrf";
            panelIrrf.Size = new Size(315, 257);
            panelIrrf.TabIndex = 10;
            panelIrrf.MouseClick += AllForms_MouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(148, 92);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 29;
            label8.Text = "%";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(145, 213);
            label55.Name = "label55";
            label55.Size = new Size(20, 15);
            label55.TabIndex = 28;
            label55.Text = "R$";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(146, 183);
            label50.Name = "label50";
            label50.Size = new Size(20, 15);
            label50.TabIndex = 27;
            label50.Text = "R$";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(146, 153);
            label46.Name = "label46";
            label46.Size = new Size(20, 15);
            label46.TabIndex = 26;
            label46.Text = "R$";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(146, 123);
            label45.Name = "label45";
            label45.Size = new Size(20, 15);
            label45.TabIndex = 25;
            label45.Text = "R$";
            // 
            // TxtTotalIRRF
            // 
            TxtTotalIRRF.BackColor = Color.LightGray;
            TxtTotalIRRF.BorderStyle = BorderStyle.None;
            TxtTotalIRRF.Location = new Point(175, 213);
            TxtTotalIRRF.Name = "TxtTotalIRRF";
            TxtTotalIRRF.ReadOnly = true;
            TxtTotalIRRF.Size = new Size(100, 16);
            TxtTotalIRRF.TabIndex = 23;
            // 
            // TxtValorIRRF
            // 
            TxtValorIRRF.BackColor = Color.LightGray;
            TxtValorIRRF.BorderStyle = BorderStyle.None;
            TxtValorIRRF.Location = new Point(175, 183);
            TxtValorIRRF.Name = "TxtValorIRRF";
            TxtValorIRRF.ReadOnly = true;
            TxtValorIRRF.Size = new Size(100, 16);
            TxtValorIRRF.TabIndex = 19;
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
            // TxtSalarioBaseIRRF
            // 
            TxtSalarioBaseIRRF.BackColor = Color.LightGray;
            TxtSalarioBaseIRRF.BorderStyle = BorderStyle.None;
            TxtSalarioBaseIRRF.Location = new Point(175, 153);
            TxtSalarioBaseIRRF.Name = "TxtSalarioBaseIRRF";
            TxtSalarioBaseIRRF.ReadOnly = true;
            TxtSalarioBaseIRRF.Size = new Size(100, 16);
            TxtSalarioBaseIRRF.TabIndex = 18;
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
            // TxtDescIRRF
            // 
            TxtDescIRRF.BackColor = Color.LightGray;
            TxtDescIRRF.BorderStyle = BorderStyle.None;
            TxtDescIRRF.Location = new Point(175, 123);
            TxtDescIRRF.Name = "TxtDescIRRF";
            TxtDescIRRF.ReadOnly = true;
            TxtDescIRRF.Size = new Size(100, 16);
            TxtDescIRRF.TabIndex = 17;
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
            // TxtTaxaDescIRRF
            // 
            TxtTaxaDescIRRF.BackColor = Color.LightGray;
            TxtTaxaDescIRRF.BorderStyle = BorderStyle.None;
            TxtTaxaDescIRRF.Location = new Point(175, 93);
            TxtTaxaDescIRRF.Name = "TxtTaxaDescIRRF";
            TxtTaxaDescIRRF.ReadOnly = true;
            TxtTaxaDescIRRF.Size = new Size(100, 16);
            TxtTaxaDescIRRF.TabIndex = 16;
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
            panelInss.Controls.Add(label43);
            panelInss.Controls.Add(label40);
            panelInss.Controls.Add(label39);
            panelInss.Controls.Add(label38);
            panelInss.Controls.Add(label18);
            panelInss.Controls.Add(TxtDescTotalINSS);
            panelInss.Controls.Add(TxtINSSValor);
            panelInss.Controls.Add(TxtTotalInss);
            panelInss.Controls.Add(TxtSalarioINSS);
            panelInss.Controls.Add(TxtValorInss);
            panelInss.Controls.Add(TxtINSSDesc);
            panelInss.Controls.Add(TxtSalarioBaseINSS);
            panelInss.Controls.Add(TxtTaxaINSS);
            panelInss.Controls.Add(TxtDescINSS);
            panelInss.Controls.Add(TxtTaxaDescINSS);
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
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(145, 213);
            label43.Name = "label43";
            label43.Size = new Size(20, 15);
            label43.TabIndex = 29;
            label43.Text = "R$";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(146, 183);
            label40.Name = "label40";
            label40.Size = new Size(20, 15);
            label40.TabIndex = 28;
            label40.Text = "R$";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(146, 153);
            label39.Name = "label39";
            label39.Size = new Size(20, 15);
            label39.TabIndex = 27;
            label39.Text = "R$";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(146, 123);
            label38.Name = "label38";
            label38.Size = new Size(20, 15);
            label38.TabIndex = 26;
            label38.Text = "R$";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(148, 93);
            label18.Name = "label18";
            label18.Size = new Size(17, 15);
            label18.TabIndex = 25;
            label18.Text = "%";
            // 
            // TxtDescTotalINSS
            // 
            TxtDescTotalINSS.BackColor = Color.LightGray;
            TxtDescTotalINSS.BorderStyle = BorderStyle.None;
            TxtDescTotalINSS.Location = new Point(175, 213);
            TxtDescTotalINSS.Name = "TxtDescTotalINSS";
            TxtDescTotalINSS.ReadOnly = true;
            TxtDescTotalINSS.Size = new Size(100, 16);
            TxtDescTotalINSS.TabIndex = 24;
            // 
            // TxtINSSValor
            // 
            TxtINSSValor.BackColor = Color.LightGray;
            TxtINSSValor.BorderStyle = BorderStyle.None;
            TxtINSSValor.Location = new Point(175, 183);
            TxtINSSValor.Name = "TxtINSSValor";
            TxtINSSValor.ReadOnly = true;
            TxtINSSValor.Size = new Size(100, 16);
            TxtINSSValor.TabIndex = 15;
            // 
            // TxtTotalInss
            // 
            TxtTotalInss.BackColor = Color.LightGray;
            TxtTotalInss.BorderStyle = BorderStyle.None;
            TxtTotalInss.Location = new Point(175, 213);
            TxtTotalInss.Name = "TxtTotalInss";
            TxtTotalInss.ReadOnly = true;
            TxtTotalInss.Size = new Size(100, 16);
            TxtTotalInss.TabIndex = 24;
            // 
            // TxtSalarioINSS
            // 
            TxtSalarioINSS.BackColor = Color.LightGray;
            TxtSalarioINSS.BorderStyle = BorderStyle.None;
            TxtSalarioINSS.Location = new Point(175, 153);
            TxtSalarioINSS.Name = "TxtSalarioINSS";
            TxtSalarioINSS.ReadOnly = true;
            TxtSalarioINSS.Size = new Size(100, 16);
            TxtSalarioINSS.TabIndex = 14;
            // 
            // TxtValorInss
            // 
            TxtValorInss.BackColor = Color.LightGray;
            TxtValorInss.BorderStyle = BorderStyle.None;
            TxtValorInss.Location = new Point(175, 183);
            TxtValorInss.Name = "TxtValorInss";
            TxtValorInss.ReadOnly = true;
            TxtValorInss.Size = new Size(100, 16);
            TxtValorInss.TabIndex = 15;
            // 
            // TxtINSSDesc
            // 
            TxtINSSDesc.BackColor = Color.LightGray;
            TxtINSSDesc.BorderStyle = BorderStyle.None;
            TxtINSSDesc.Location = new Point(175, 122);
            TxtINSSDesc.Name = "TxtINSSDesc";
            TxtINSSDesc.ReadOnly = true;
            TxtINSSDesc.Size = new Size(100, 16);
            TxtINSSDesc.TabIndex = 13;
            // 
            // TxtSalarioBaseINSS
            // 
            TxtSalarioBaseINSS.BackColor = Color.LightGray;
            TxtSalarioBaseINSS.BorderStyle = BorderStyle.None;
            TxtSalarioBaseINSS.Location = new Point(175, 152);
            TxtSalarioBaseINSS.Name = "TxtSalarioBaseINSS";
            TxtSalarioBaseINSS.ReadOnly = true;
            TxtSalarioBaseINSS.Size = new Size(100, 16);
            TxtSalarioBaseINSS.TabIndex = 14;
            // 
            // TxtTaxaINSS
            // 
            TxtTaxaINSS.BackColor = Color.LightGray;
            TxtTaxaINSS.BorderStyle = BorderStyle.None;
            TxtTaxaINSS.Location = new Point(175, 93);
            TxtTaxaINSS.Name = "TxtTaxaINSS";
            TxtTaxaINSS.ReadOnly = true;
            TxtTaxaINSS.Size = new Size(100, 16);
            TxtTaxaINSS.TabIndex = 12;
            // 
            // TxtDescINSS
            // 
            TxtDescINSS.BackColor = Color.LightGray;
            TxtDescINSS.BorderStyle = BorderStyle.None;
            TxtDescINSS.Location = new Point(175, 123);
            TxtDescINSS.Name = "TxtDescINSS";
            TxtDescINSS.ReadOnly = true;
            TxtDescINSS.Size = new Size(100, 16);
            TxtDescINSS.TabIndex = 13;
            // 
            // TxtTaxaDescINSS
            // 
            TxtTaxaDescINSS.BackColor = Color.LightGray;
            TxtTaxaDescINSS.BorderStyle = BorderStyle.None;
            TxtTaxaDescINSS.Location = new Point(175, 93);
            TxtTaxaDescINSS.Name = "TxtTaxaDescINSS";
            TxtTaxaDescINSS.ReadOnly = true;
            TxtTaxaDescINSS.Size = new Size(100, 16);
            TxtTaxaDescINSS.TabIndex = 12;
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
            LbTitulo.Size = new Size(395, 41);
            LbTitulo.TabIndex = 50;
            LbTitulo.Text = "Pesquisar Folha Normal       ";
            LbTitulo.MouseClick += AllForms_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(70, 50);
            label1.Name = "label1";
            label1.Size = new Size(391, 37);
            label1.TabIndex = 60;
            label1.Text = "__________________________________";
            // 
            // FormFolhaNormalPesq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            ClientSize = new Size(1248, 712);
            Controls.Add(LbFolhaNormal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFolhaNormalPesq";
            Text = "FormFolhaNormalPesq";
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
        private Button BtnPrint;
        private Button BtnImprimir;
        private Label label31;
        private Label label47;
        private Panel PanelFolhaDetalhada;
        private Panel panel8;
        private Label label35;
        private Label label68;
        private Label label69;
        private Label label70;
        private Panel panel7;
        private Label label48;
        private Label label41;
        private Label label42;
        private Panel panelFgts;
        private Label label51;
        private Label label26;
        private Label label29;
        private Label label25;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel10;
        private Label label19;
        private Panel panel4;
        private Label label23;
        private Label label24;
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
        private Label label10;
        private Label label9;
        private Label label34;
        private Label LbTitulo;
        private Label label1;
        private Button button2;
        private ToolTip toolTip1;
        private TextBox TxtTotalInss;
        private TextBox TxtValorInss;
        private TextBox TxtSalarioBaseINSS;
        private TextBox TxtDescINSS;
        private TextBox TxtTaxaDescINSS;
        private Label label36;
        private Label label57;
        private Label label56;
        private Label label55;
        private Label label50;
        private Label label46;
        private Label label45;
        private Label label43;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label53;
        private Label label52;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label18;
        internal TextBox TxtDescTotalINSS;
        internal TextBox TxtINSSValor;
        internal TextBox TxtSalarioINSS;
        internal TextBox TxtINSSDesc;
        internal TextBox TxtTaxaINSS;
        internal ComboBox CbAno;
        internal ComboBox CbMes;
        internal TextBox TxtTotalFGTS;
        internal TextBox TxtValorFGTS;
        internal TextBox TxtSalarioBaseFGTS;
        internal TextBox TxtTotalIRRF;
        internal TextBox TxtValorIRRF;
        internal TextBox TxtSalarioBaseIRRF;
        internal TextBox TxtDescIRRF;
        internal TextBox TxtTaxaDescIRRF;
        internal TextBox TxtMaiorRemuneracao;
        internal TextBox TxtTotaisDescontos;
        internal TextBox TxtSalarioLiquido;
        internal Label TxtDataLancamento;
        internal TextBox TxtVencimentos;
        internal Label TxtID;
        internal TextBox TxtSalarioLiqMensal;
        internal TextBox TxtDataEmissao;
        internal Label LbAtivos;
        internal Label LbClt;
        private Label label3;
        private Label label8;
        internal TextBox TxtTaxaFGTS;
    }
}