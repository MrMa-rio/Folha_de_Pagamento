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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavBar));
            BtnArrowLeft = new Button();
            panel1 = new Panel();
            PanelSubMenuRel = new Panel();
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
            button4 = new Button();
            BtnGerenciamento = new Button();
            BtnConfiguracao = new Button();
            BtnLogout = new Button();
            Pnl2 = new Panel();
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
            PanelSubMenuRel.Controls.Add(BtnCalculoPagamento);
            PanelSubMenuRel.Controls.Add(FolhaPDetalhada);
            PanelSubMenuRel.Controls.Add(BtnHolerite);
            PanelSubMenuRel.Controls.Add(BtnFolhaPNormal);
            PanelSubMenuRel.Dock = DockStyle.Top;
            PanelSubMenuRel.Location = new Point(0, 390);
            PanelSubMenuRel.Name = "PanelSubMenuRel";
            PanelSubMenuRel.Size = new Size(325, 247);
            PanelSubMenuRel.TabIndex = 6;
            // 
            // BtnCalculoPagamento
            // 
            BtnCalculoPagamento.BackColor = Color.Transparent;
            BtnCalculoPagamento.FlatAppearance.BorderSize = 0;
            BtnCalculoPagamento.FlatStyle = FlatStyle.Flat;
            BtnCalculoPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCalculoPagamento.Image = (Image)resources.GetObject("BtnCalculoPagamento.Image");
            BtnCalculoPagamento.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCalculoPagamento.Location = new Point(35, 21);
            BtnCalculoPagamento.Name = "BtnCalculoPagamento";
            BtnCalculoPagamento.Size = new Size(244, 40);
            BtnCalculoPagamento.TabIndex = 7;
            BtnCalculoPagamento.Text = "    Calculo Pagamento";
            BtnCalculoPagamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCalculoPagamento.UseVisualStyleBackColor = false;
            BtnCalculoPagamento.MouseClick += BtnCalculoPagamento_MouseClick;
            // 
            // FolhaPDetalhada
            // 
            FolhaPDetalhada.BackColor = Color.Transparent;
            FolhaPDetalhada.FlatAppearance.BorderSize = 0;
            FolhaPDetalhada.FlatStyle = FlatStyle.Flat;
            FolhaPDetalhada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FolhaPDetalhada.Image = (Image)resources.GetObject("FolhaPDetalhada.Image");
            FolhaPDetalhada.ImageAlign = ContentAlignment.MiddleLeft;
            FolhaPDetalhada.Location = new Point(35, 113);
            FolhaPDetalhada.Name = "FolhaPDetalhada";
            FolhaPDetalhada.Size = new Size(255, 40);
            FolhaPDetalhada.TabIndex = 8;
            FolhaPDetalhada.Text = "    Folha Pagamento Detalhada";
            FolhaPDetalhada.TextImageRelation = TextImageRelation.ImageBeforeText;
            FolhaPDetalhada.UseVisualStyleBackColor = false;
            FolhaPDetalhada.MouseClick += BtnFolhaPDetalhada_MouseClick;
            // 
            // BtnHolerite
            // 
            BtnHolerite.BackColor = Color.Transparent;
            BtnHolerite.FlatAppearance.BorderSize = 0;
            BtnHolerite.FlatStyle = FlatStyle.Flat;
            BtnHolerite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHolerite.Image = (Image)resources.GetObject("BtnHolerite.Image");
            BtnHolerite.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHolerite.Location = new Point(35, 159);
            BtnHolerite.Name = "BtnHolerite";
            BtnHolerite.Size = new Size(221, 40);
            BtnHolerite.TabIndex = 9;
            BtnHolerite.Text = "    Holerite";
            BtnHolerite.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnHolerite.UseVisualStyleBackColor = false;
            BtnHolerite.MouseClick += BtnHolerite_MouseClick;
            // 
            // BtnFolhaPNormal
            // 
            BtnFolhaPNormal.BackColor = Color.Transparent;
            BtnFolhaPNormal.FlatAppearance.BorderSize = 0;
            BtnFolhaPNormal.FlatStyle = FlatStyle.Flat;
            BtnFolhaPNormal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFolhaPNormal.Image = (Image)resources.GetObject("BtnFolhaPNormal.Image");
            BtnFolhaPNormal.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFolhaPNormal.Location = new Point(35, 67);
            BtnFolhaPNormal.Name = "BtnFolhaPNormal";
            BtnFolhaPNormal.Size = new Size(244, 40);
            BtnFolhaPNormal.TabIndex = 11;
            BtnFolhaPNormal.Text = "    Folha Pagamento Normal";
            BtnFolhaPNormal.TextAlign = ContentAlignment.MiddleLeft;
            BtnFolhaPNormal.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFolhaPNormal.UseVisualStyleBackColor = false;
            BtnFolhaPNormal.MouseClick += BtnFolhaPNormal_MouseClick;
            // 
            // BtnRelatorio
            // 
            BtnRelatorio.Dock = DockStyle.Top;
            BtnRelatorio.FlatAppearance.BorderSize = 0;
            BtnRelatorio.FlatStyle = FlatStyle.Flat;
            BtnRelatorio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRelatorio.Image = Properties.Resources.summary;
            BtnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRelatorio.Location = new Point(0, 327);
            BtnRelatorio.Name = "BtnRelatorio";
            BtnRelatorio.Size = new Size(325, 63);
            BtnRelatorio.TabIndex = 14;
            BtnRelatorio.Text = "  Relatorios";
            BtnRelatorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRelatorio.UseVisualStyleBackColor = true;
            BtnRelatorio.MouseClick += BtnRelatorio_MouseClick;
            // 
            // PanelSubMenu
            // 
            PanelSubMenu.Controls.Add(BtnCadastro);
            PanelSubMenu.Controls.Add(BtnAlterarCadastro);
            PanelSubMenu.Controls.Add(BtnCargosFun);
            PanelSubMenu.Controls.Add(BtnPesquisar);
            PanelSubMenu.Controls.Add(button4);
            PanelSubMenu.Dock = DockStyle.Top;
            PanelSubMenu.Location = new Point(0, 63);
            PanelSubMenu.Name = "PanelSubMenu";
            PanelSubMenu.Size = new Size(325, 264);
            PanelSubMenu.TabIndex = 13;
            // 
            // BtnCadastro
            // 
            BtnCadastro.BackColor = Color.Transparent;
            BtnCadastro.FlatAppearance.BorderSize = 0;
            BtnCadastro.FlatStyle = FlatStyle.Flat;
            BtnCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastro.Image = (Image)resources.GetObject("BtnCadastro.Image");
            BtnCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCadastro.Location = new Point(35, 6);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(220, 40);
            BtnCadastro.TabIndex = 0;
            BtnCadastro.Text = "    Cadastrar Funcionários";
            BtnCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.MouseClick += BtnCadastro_MouseClick;
            // 
            // BtnAlterarCadastro
            // 
            BtnAlterarCadastro.BackColor = Color.Transparent;
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
            BtnAlterarCadastro.UseVisualStyleBackColor = false;
            BtnAlterarCadastro.MouseClick += BtnAlterarCadastro_MouseClick;
            // 
            // BtnCargosFun
            // 
            BtnCargosFun.BackColor = Color.Transparent;
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
            BtnCargosFun.UseVisualStyleBackColor = false;
            BtnCargosFun.MouseClick += BtnCargosFun_MouseClick;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.Transparent;
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
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.MouseClick += BtnPesquisar_MouseClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Enabled = false;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.cube;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(35, 194);
            button4.Name = "button4";
            button4.Size = new Size(220, 40);
            button4.TabIndex = 5;
            button4.Text = "    A Definir";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // BtnGerenciamento
            // 
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
            BtnGerenciamento.UseVisualStyleBackColor = true;
            BtnGerenciamento.MouseClick += BtnGerenciamento_MouseClick;
            // 
            // BtnConfiguracao
            // 
            BtnConfiguracao.BackColor = Color.LightGray;
            BtnConfiguracao.Enabled = false;
            BtnConfiguracao.FlatAppearance.BorderSize = 0;
            BtnConfiguracao.FlatStyle = FlatStyle.Flat;
            BtnConfiguracao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConfiguracao.Image = Properties.Resources.settings;
            BtnConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfiguracao.Location = new Point(11, 687);
            BtnConfiguracao.Name = "BtnConfiguracao";
            BtnConfiguracao.Size = new Size(174, 48);
            BtnConfiguracao.TabIndex = 2;
            BtnConfiguracao.Text = "Configurações";
            BtnConfiguracao.TextAlign = ContentAlignment.MiddleRight;
            BtnConfiguracao.UseVisualStyleBackColor = false;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.LightGray;
            BtnLogout.Enabled = false;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogout.Image = Properties.Resources.logout;
            BtnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogout.Location = new Point(191, 687);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(141, 48);
            BtnLogout.TabIndex = 3;
            BtnLogout.Text = "Trocar Perfil";
            BtnLogout.TextAlign = ContentAlignment.MiddleRight;
            BtnLogout.UseVisualStyleBackColor = false;
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
        private Button BtnAlterarCadastro;
        private Button BtnCadastro;
        private Button BtnConfiguracao;
        private Button BtnLogout;
        private Button BtnFolhaPNormal;
        private Button BtnHolerite;
        private Button FolhaPDetalhada;
        private Button BtnCalculoPagamento;
        private Button button4;
        private Button BtnPesquisar;
        private Button BtnCargosFun;
        private Button BtnGerenciamento;
        private Panel PanelSubMenu;
        private Button BtnRelatorio;
        private Panel PanelSubMenuRel;
        public Panel Pnl2;
    }
}