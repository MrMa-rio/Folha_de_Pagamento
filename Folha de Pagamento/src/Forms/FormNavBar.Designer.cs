namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormNavBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavBar));
            BtnArrowLeft = new Button();
            panel1 = new Panel();
            PanelSubMenuRel = new Panel();
            BtnHoleriteFunc = new Button();
            BtnFolhaPNormalPesq = new Button();
            FolhaPDetalhadaPesq = new Button();
            BtnCalculoPagamento = new Button();
            FolhaPDetalhada = new Button();
            BtnHolerite = new Button();
            BtnFolhaPNormal = new Button();
            BtnRelatorio = new Button();
            PanelSubMenu = new Panel();
            BtnCadastro = new Button();
            BtnAlterarCadastro = new Button();
            BtnCargosFun = new Button();
            BtnPesquisar = new Button();
            BtnGerenciamento = new Button();
            BtnConfiguracao = new Button();
            BtnLogout = new Button();
            Pnl2 = new Panel();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            PanelSubMenuRel.SuspendLayout();
            PanelSubMenu.SuspendLayout();
            Pnl2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnArrowLeft
            // 
            BtnArrowLeft.BackColor = Color.Transparent;
            BtnArrowLeft.BackgroundImage = Properties.Resources.arrow_left;
            BtnArrowLeft.BackgroundImageLayout = ImageLayout.Stretch;
            BtnArrowLeft.Cursor = Cursors.Hand;
            BtnArrowLeft.FlatAppearance.BorderSize = 0;
            BtnArrowLeft.FlatStyle = FlatStyle.Flat;
            BtnArrowLeft.Location = new Point(27, 28);
            BtnArrowLeft.Name = "BtnArrowLeft";
            BtnArrowLeft.Size = new Size(48, 48);
            BtnArrowLeft.TabIndex = 0;
            BtnArrowLeft.UseVisualStyleBackColor = false;
            BtnArrowLeft.MouseClick += BtnArrowLeft_MouseClick;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 30);
            panel1.AutoScrollMinSize = new Size(0, 30);
            panel1.Controls.Add(PanelSubMenuRel);
            panel1.Controls.Add(BtnRelatorio);
            panel1.Controls.Add(PanelSubMenu);
            panel1.Controls.Add(BtnGerenciamento);
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 573);
            panel1.TabIndex = 1;
            // 
            // PanelSubMenuRel
            // 
            PanelSubMenuRel.Controls.Add(BtnHoleriteFunc);
            PanelSubMenuRel.Controls.Add(BtnFolhaPNormalPesq);
            PanelSubMenuRel.Controls.Add(FolhaPDetalhadaPesq);
            PanelSubMenuRel.Controls.Add(BtnCalculoPagamento);
            PanelSubMenuRel.Controls.Add(FolhaPDetalhada);
            PanelSubMenuRel.Controls.Add(BtnHolerite);
            PanelSubMenuRel.Controls.Add(BtnFolhaPNormal);
            PanelSubMenuRel.Dock = DockStyle.Top;
            PanelSubMenuRel.Location = new Point(0, 320);
            PanelSubMenuRel.Name = "PanelSubMenuRel";
            PanelSubMenuRel.Size = new Size(325, 336);
            PanelSubMenuRel.TabIndex = 6;
            // 
            // BtnHoleriteFunc
            // 
            BtnHoleriteFunc.BackColor = Color.Transparent;
            BtnHoleriteFunc.Cursor = Cursors.Hand;
            BtnHoleriteFunc.FlatAppearance.BorderSize = 0;
            BtnHoleriteFunc.FlatStyle = FlatStyle.Flat;
            BtnHoleriteFunc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHoleriteFunc.Image = (Image)resources.GetObject("BtnHoleriteFunc.Image");
            BtnHoleriteFunc.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHoleriteFunc.Location = new Point(35, 291);
            BtnHoleriteFunc.Name = "BtnHoleriteFunc";
            BtnHoleriteFunc.Size = new Size(221, 40);
            BtnHoleriteFunc.TabIndex = 14;
            BtnHoleriteFunc.Text = "    Holerite";
            BtnHoleriteFunc.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnHoleriteFunc, "Visualizar o holerite");
            BtnHoleriteFunc.UseVisualStyleBackColor = false;
            BtnHoleriteFunc.MouseClick += BtnHoleriteFunc_MouseClick;
            // 
            // BtnFolhaPNormalPesq
            // 
            BtnFolhaPNormalPesq.BackColor = Color.Transparent;
            BtnFolhaPNormalPesq.Cursor = Cursors.Hand;
            BtnFolhaPNormalPesq.FlatAppearance.BorderSize = 0;
            BtnFolhaPNormalPesq.FlatStyle = FlatStyle.Flat;
            BtnFolhaPNormalPesq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFolhaPNormalPesq.Image = (Image)resources.GetObject("BtnFolhaPNormalPesq.Image");
            BtnFolhaPNormalPesq.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFolhaPNormalPesq.Location = new Point(35, 107);
            BtnFolhaPNormalPesq.Name = "BtnFolhaPNormalPesq";
            BtnFolhaPNormalPesq.Size = new Size(244, 40);
            BtnFolhaPNormalPesq.TabIndex = 13;
            BtnFolhaPNormalPesq.Text = "    Pesquisar Folha Normal";
            BtnFolhaPNormalPesq.TextAlign = ContentAlignment.MiddleLeft;
            BtnFolhaPNormalPesq.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnFolhaPNormalPesq, "Pesquisar as folhas de pagamento normais");
            BtnFolhaPNormalPesq.UseVisualStyleBackColor = false;
            BtnFolhaPNormalPesq.MouseClick += BtnFolhaPNormalPesq_MouseClick;
            // 
            // FolhaPDetalhadaPesq
            // 
            FolhaPDetalhadaPesq.BackColor = Color.Transparent;
            FolhaPDetalhadaPesq.Cursor = Cursors.Hand;
            FolhaPDetalhadaPesq.FlatAppearance.BorderSize = 0;
            FolhaPDetalhadaPesq.FlatStyle = FlatStyle.Flat;
            FolhaPDetalhadaPesq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FolhaPDetalhadaPesq.Image = (Image)resources.GetObject("FolhaPDetalhadaPesq.Image");
            FolhaPDetalhadaPesq.ImageAlign = ContentAlignment.MiddleLeft;
            FolhaPDetalhadaPesq.Location = new Point(35, 199);
            FolhaPDetalhadaPesq.Name = "FolhaPDetalhadaPesq";
            FolhaPDetalhadaPesq.Size = new Size(255, 40);
            FolhaPDetalhadaPesq.TabIndex = 12;
            FolhaPDetalhadaPesq.Text = "    Pesquisar Folha Detalhada";
            FolhaPDetalhadaPesq.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(FolhaPDetalhadaPesq, "Pesquisar as folhas de pagamento detalhadas");
            FolhaPDetalhadaPesq.UseVisualStyleBackColor = false;
            FolhaPDetalhadaPesq.MouseClick += FolhaPDetalhadaPesq_MouseClick;
            // 
            // BtnCalculoPagamento
            // 
            BtnCalculoPagamento.BackColor = Color.Transparent;
            BtnCalculoPagamento.Cursor = Cursors.Hand;
            BtnCalculoPagamento.FlatAppearance.BorderSize = 0;
            BtnCalculoPagamento.FlatStyle = FlatStyle.Flat;
            BtnCalculoPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCalculoPagamento.Image = (Image)resources.GetObject("BtnCalculoPagamento.Image");
            BtnCalculoPagamento.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCalculoPagamento.Location = new Point(35, 15);
            BtnCalculoPagamento.Name = "BtnCalculoPagamento";
            BtnCalculoPagamento.Size = new Size(297, 40);
            BtnCalculoPagamento.TabIndex = 7;
            BtnCalculoPagamento.Text = "    Impostos e Dados de Pag.";
            BtnCalculoPagamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnCalculoPagamento, "Cálculos de impostos e dados de pagamentos");
            BtnCalculoPagamento.UseVisualStyleBackColor = false;
            BtnCalculoPagamento.MouseClick += BtnCalculoPagamento_MouseClick;
            // 
            // FolhaPDetalhada
            // 
            FolhaPDetalhada.BackColor = Color.Transparent;
            FolhaPDetalhada.Cursor = Cursors.Hand;
            FolhaPDetalhada.FlatAppearance.BorderSize = 0;
            FolhaPDetalhada.FlatStyle = FlatStyle.Flat;
            FolhaPDetalhada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FolhaPDetalhada.Image = (Image)resources.GetObject("FolhaPDetalhada.Image");
            FolhaPDetalhada.ImageAlign = ContentAlignment.MiddleLeft;
            FolhaPDetalhada.Location = new Point(35, 153);
            FolhaPDetalhada.Name = "FolhaPDetalhada";
            FolhaPDetalhada.Size = new Size(269, 40);
            FolhaPDetalhada.TabIndex = 8;
            FolhaPDetalhada.Text = "    Gerar Folha Pag. Detalhada";
            FolhaPDetalhada.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(FolhaPDetalhada, "Gerar folha de pagamento detalhada");
            FolhaPDetalhada.UseVisualStyleBackColor = false;
            FolhaPDetalhada.MouseClick += BtnFolhaPDetalhada_MouseClick;
            // 
            // BtnHolerite
            // 
            BtnHolerite.BackColor = Color.Transparent;
            BtnHolerite.Cursor = Cursors.Hand;
            BtnHolerite.FlatAppearance.BorderSize = 0;
            BtnHolerite.FlatStyle = FlatStyle.Flat;
            BtnHolerite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHolerite.Image = (Image)resources.GetObject("BtnHolerite.Image");
            BtnHolerite.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHolerite.Location = new Point(35, 245);
            BtnHolerite.Name = "BtnHolerite";
            BtnHolerite.Size = new Size(221, 40);
            BtnHolerite.TabIndex = 9;
            BtnHolerite.Text = "    Holerite";
            BtnHolerite.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnHolerite, "Visualizar o holerite");
            BtnHolerite.UseVisualStyleBackColor = false;
            BtnHolerite.MouseClick += BtnHolerite_MouseClick;
            // 
            // BtnFolhaPNormal
            // 
            BtnFolhaPNormal.BackColor = Color.Transparent;
            BtnFolhaPNormal.Cursor = Cursors.Hand;
            BtnFolhaPNormal.FlatAppearance.BorderSize = 0;
            BtnFolhaPNormal.FlatStyle = FlatStyle.Flat;
            BtnFolhaPNormal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFolhaPNormal.Image = (Image)resources.GetObject("BtnFolhaPNormal.Image");
            BtnFolhaPNormal.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFolhaPNormal.Location = new Point(35, 61);
            BtnFolhaPNormal.Name = "BtnFolhaPNormal";
            BtnFolhaPNormal.Size = new Size(287, 40);
            BtnFolhaPNormal.TabIndex = 11;
            BtnFolhaPNormal.Text = "    Gerar Folha Pag. Normal";
            BtnFolhaPNormal.TextAlign = ContentAlignment.MiddleLeft;
            BtnFolhaPNormal.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnFolhaPNormal, "Gerar folha de pagamento normal");
            BtnFolhaPNormal.UseVisualStyleBackColor = false;
            BtnFolhaPNormal.MouseClick += BtnFolhaPNormal_MouseClick;
            // 
            // BtnRelatorio
            // 
            BtnRelatorio.Cursor = Cursors.Hand;
            BtnRelatorio.Dock = DockStyle.Top;
            BtnRelatorio.FlatAppearance.BorderSize = 0;
            BtnRelatorio.FlatStyle = FlatStyle.Flat;
            BtnRelatorio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRelatorio.Image = Properties.Resources.summary;
            BtnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRelatorio.Location = new Point(0, 257);
            BtnRelatorio.Name = "BtnRelatorio";
            BtnRelatorio.Size = new Size(325, 63);
            BtnRelatorio.TabIndex = 14;
            BtnRelatorio.Text = "  Relatorios";
            BtnRelatorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnRelatorio, "Click para minimizar");
            BtnRelatorio.UseVisualStyleBackColor = true;
            BtnRelatorio.MouseClick += BtnRelatorio_MouseClick;
            // 
            // PanelSubMenu
            // 
            PanelSubMenu.Controls.Add(BtnCadastro);
            PanelSubMenu.Controls.Add(BtnAlterarCadastro);
            PanelSubMenu.Controls.Add(BtnCargosFun);
            PanelSubMenu.Controls.Add(BtnPesquisar);
            PanelSubMenu.Dock = DockStyle.Top;
            PanelSubMenu.Location = new Point(0, 63);
            PanelSubMenu.Name = "PanelSubMenu";
            PanelSubMenu.Size = new Size(325, 194);
            PanelSubMenu.TabIndex = 13;
            // 
            // BtnCadastro
            // 
            BtnCadastro.BackColor = Color.Transparent;
            BtnCadastro.Cursor = Cursors.Hand;
            BtnCadastro.FlatAppearance.BorderSize = 0;
            BtnCadastro.FlatStyle = FlatStyle.Flat;
            BtnCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastro.Image = (Image)resources.GetObject("BtnCadastro.Image");
            BtnCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCadastro.Location = new Point(35, 10);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(244, 40);
            BtnCadastro.TabIndex = 0;
            BtnCadastro.Text = "    Cadastrar Funcionários";
            BtnCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnCadastro, "Cadastrar novos funcionários");
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.MouseClick += BtnCadastro_MouseClick;
            // 
            // BtnAlterarCadastro
            // 
            BtnAlterarCadastro.BackColor = Color.Transparent;
            BtnAlterarCadastro.Cursor = Cursors.Hand;
            BtnAlterarCadastro.FlatAppearance.BorderSize = 0;
            BtnAlterarCadastro.FlatStyle = FlatStyle.Flat;
            BtnAlterarCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAlterarCadastro.Image = (Image)resources.GetObject("BtnAlterarCadastro.Image");
            BtnAlterarCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAlterarCadastro.Location = new Point(35, 56);
            BtnAlterarCadastro.Name = "BtnAlterarCadastro";
            BtnAlterarCadastro.Size = new Size(220, 40);
            BtnAlterarCadastro.TabIndex = 1;
            BtnAlterarCadastro.Text = "    Alterar Funcionários";
            BtnAlterarCadastro.TextAlign = ContentAlignment.MiddleRight;
            BtnAlterarCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnAlterarCadastro, "Alterar funcionários já cadastrados");
            BtnAlterarCadastro.UseVisualStyleBackColor = false;
            BtnAlterarCadastro.MouseClick += BtnAlterarCadastro_MouseClick;
            // 
            // BtnCargosFun
            // 
            BtnCargosFun.BackColor = Color.Transparent;
            BtnCargosFun.Cursor = Cursors.Hand;
            BtnCargosFun.FlatAppearance.BorderSize = 0;
            BtnCargosFun.FlatStyle = FlatStyle.Flat;
            BtnCargosFun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCargosFun.Image = (Image)resources.GetObject("BtnCargosFun.Image");
            BtnCargosFun.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCargosFun.Location = new Point(35, 102);
            BtnCargosFun.Name = "BtnCargosFun";
            BtnCargosFun.Size = new Size(220, 40);
            BtnCargosFun.TabIndex = 3;
            BtnCargosFun.Text = "    Cargos Funcionários";
            BtnCargosFun.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnCargosFun, "Criar ou modificar cargos");
            BtnCargosFun.UseVisualStyleBackColor = false;
            BtnCargosFun.MouseClick += BtnCargosFun_MouseClick;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.Transparent;
            BtnPesquisar.Cursor = Cursors.Hand;
            BtnPesquisar.FlatAppearance.BorderSize = 0;
            BtnPesquisar.FlatStyle = FlatStyle.Flat;
            BtnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Image = (Image)resources.GetObject("BtnPesquisar.Image");
            BtnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPesquisar.Location = new Point(35, 148);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(220, 40);
            BtnPesquisar.TabIndex = 4;
            BtnPesquisar.Text = "    Pesquisar";
            BtnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnPesquisar, "Pesquisar funcionários");
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.MouseClick += BtnPesquisar_MouseClick;
            // 
            // BtnGerenciamento
            // 
            BtnGerenciamento.Cursor = Cursors.Hand;
            BtnGerenciamento.Dock = DockStyle.Top;
            BtnGerenciamento.FlatAppearance.BorderSize = 0;
            BtnGerenciamento.FlatStyle = FlatStyle.Flat;
            BtnGerenciamento.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGerenciamento.Image = Properties.Resources.manager;
            BtnGerenciamento.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGerenciamento.Location = new Point(0, 0);
            BtnGerenciamento.Name = "BtnGerenciamento";
            BtnGerenciamento.Size = new Size(325, 63);
            BtnGerenciamento.TabIndex = 12;
            BtnGerenciamento.Text = "Gerenciamento";
            BtnGerenciamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(BtnGerenciamento, "Click para minimizar");
            BtnGerenciamento.UseVisualStyleBackColor = true;
            BtnGerenciamento.MouseClick += BtnGerenciamento_MouseClick;
            // 
            // BtnConfiguracao
            // 
            BtnConfiguracao.BackColor = Color.LightGray;
            BtnConfiguracao.Cursor = Cursors.Hand;
            BtnConfiguracao.FlatAppearance.BorderSize = 0;
            BtnConfiguracao.FlatStyle = FlatStyle.Flat;
            BtnConfiguracao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConfiguracao.Image = (Image)resources.GetObject("BtnConfiguracao.Image");
            BtnConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfiguracao.Location = new Point(24, 685);
            BtnConfiguracao.Name = "BtnConfiguracao";
            BtnConfiguracao.Size = new Size(159, 48);
            BtnConfiguracao.TabIndex = 2;
            BtnConfiguracao.Text = "Sobre";
            toolTip1.SetToolTip(BtnConfiguracao, "Sobre os criadores e a empresa");
            BtnConfiguracao.UseVisualStyleBackColor = false;
            BtnConfiguracao.MouseClick += BtnConfiguracao_MouseClick;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.LightGray;
            BtnLogout.Cursor = Cursors.Hand;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogout.Image = Properties.Resources.logout;
            BtnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogout.Location = new Point(184, 685);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(141, 48);
            BtnLogout.TabIndex = 3;
            BtnLogout.Text = "Trocar Perfil";
            BtnLogout.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(BtnLogout, "Sair do perfil atual");
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.MouseClick += BtnLogout_MouseClick;
            // 
            // Pnl2
            // 
            Pnl2.Controls.Add(BtnArrowLeft);
            Pnl2.Controls.Add(BtnLogout);
            Pnl2.Controls.Add(BtnConfiguracao);
            Pnl2.Controls.Add(panel1);
            Pnl2.Dock = DockStyle.Fill;
            Pnl2.Location = new Point(0, 0);
            Pnl2.Name = "Pnl2";
            Pnl2.Size = new Size(345, 751);
            Pnl2.TabIndex = 4;
            Pnl2.Visible = false;
            Pnl2.VisibleChanged += Pnl2_VisibleChanged;
            // 
            // FormNavBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(345, 751);
            Controls.Add(Pnl2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNavBar";
            Text = "FormNavBar";
            panel1.ResumeLayout(false);
            PanelSubMenuRel.ResumeLayout(false);
            PanelSubMenu.ResumeLayout(false);
            Pnl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnArrowLeft;
        private Panel panel1;
        private Button BtnConfiguracao;
        private Button BtnLogout;
        public Panel Pnl2;
        internal Button BtnGerenciamento;
        internal Panel PanelSubMenu;
        internal Button BtnRelatorio;
        internal Panel PanelSubMenuRel;
        internal Button BtnAlterarCadastro;
        internal Button BtnCadastro;
        internal Button BtnFolhaPNormal;
        internal Button BtnHolerite;
        internal Button FolhaPDetalhada;
        internal Button BtnCalculoPagamento;
        internal Button BtnPesquisar;
        internal Button BtnCargosFun;
        internal Button BtnFolhaPNormalPesq;
        internal Button FolhaPDetalhadaPesq;
        private ToolTip toolTip1;
        internal Button BtnHoleriteFunc;
    }
}