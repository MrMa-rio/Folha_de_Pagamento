namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisar));
            LbPesquisar = new Panel();
            button1 = new Button();
            TxtPesquisarCargo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            TxtPesquisarNomes = new TextBox();
            BtnPesquisarNomes = new Button();
            PanelPesquisar = new Panel();
            LbTitulo = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            LbPesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // LbPesquisar
            // 
            LbPesquisar.AccessibleRole = AccessibleRole.None;
            LbPesquisar.BackColor = Color.LightGray;
            LbPesquisar.Controls.Add(button1);
            LbPesquisar.Controls.Add(TxtPesquisarCargo);
            LbPesquisar.Controls.Add(label3);
            LbPesquisar.Controls.Add(label2);
            LbPesquisar.Controls.Add(TxtPesquisarNomes);
            LbPesquisar.Controls.Add(BtnPesquisarNomes);
            LbPesquisar.Controls.Add(PanelPesquisar);
            LbPesquisar.Controls.Add(LbTitulo);
            LbPesquisar.Controls.Add(label1);
            LbPesquisar.Location = new Point(81, 90);
            LbPesquisar.Name = "LbPesquisar";
            LbPesquisar.Size = new Size(1110, 630);
            LbPesquisar.TabIndex = 1;
            LbPesquisar.MouseClick += AllForms_MouseClick;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1004, 39);
            button1.Name = "button1";
            button1.Size = new Size(43, 43);
            button1.TabIndex = 69;
            toolTip1.SetToolTip(button1, "Voltar ao início");
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // TxtPesquisarCargo
            // 
            TxtPesquisarCargo.BackColor = Color.DarkGray;
            TxtPesquisarCargo.FlatStyle = FlatStyle.Flat;
            TxtPesquisarCargo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPesquisarCargo.FormattingEnabled = true;
            TxtPesquisarCargo.Location = new Point(803, 100);
            TxtPesquisarCargo.Name = "TxtPesquisarCargo";
            TxtPesquisarCargo.Size = new Size(207, 31);
            TxtPesquisarCargo.TabIndex = 68;
            toolTip1.SetToolTip(TxtPesquisarCargo, "Selecione um cargo");
            TxtPesquisarCargo.DropDown += TxtPesquisarCargo_DropDown;
            TxtPesquisarCargo.TextChanged += TxtPesquisarCargo_TextChanged;
            TxtPesquisarCargo.KeyPress += All_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(637, 106);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 66;
            label3.Text = "Pesquisar por Cargos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 106);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 65;
            label2.Text = "Pesquisar por Nomes:";
            // 
            // TxtPesquisarNomes
            // 
            TxtPesquisarNomes.BackColor = Color.DarkGray;
            TxtPesquisarNomes.BorderStyle = BorderStyle.FixedSingle;
            TxtPesquisarNomes.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPesquisarNomes.Location = new Point(234, 101);
            TxtPesquisarNomes.Name = "TxtPesquisarNomes";
            TxtPesquisarNomes.PlaceholderText = "Digite um nome";
            TxtPesquisarNomes.Size = new Size(290, 31);
            TxtPesquisarNomes.TabIndex = 63;
            toolTip1.SetToolTip(TxtPesquisarNomes, "Digite um nome");
            TxtPesquisarNomes.TextChanged += TxtPesquisarNomes_TextChanged;
            TxtPesquisarNomes.KeyPress += All_KeyPress;
            // 
            // BtnPesquisarNomes
            // 
            BtnPesquisarNomes.BackColor = Color.LightGray;
            BtnPesquisarNomes.BackgroundImage = (Image)resources.GetObject("BtnPesquisarNomes.BackgroundImage");
            BtnPesquisarNomes.BackgroundImageLayout = ImageLayout.Stretch;
            BtnPesquisarNomes.Cursor = Cursors.Hand;
            BtnPesquisarNomes.Enabled = false;
            BtnPesquisarNomes.FlatAppearance.BorderSize = 0;
            BtnPesquisarNomes.FlatStyle = FlatStyle.Flat;
            BtnPesquisarNomes.Location = new Point(525, 101);
            BtnPesquisarNomes.Name = "BtnPesquisarNomes";
            BtnPesquisarNomes.Size = new Size(31, 31);
            BtnPesquisarNomes.TabIndex = 61;
            toolTip1.SetToolTip(BtnPesquisarNomes, "Pesquisar");
            BtnPesquisarNomes.UseVisualStyleBackColor = false;
            // 
            // PanelPesquisar
            // 
            PanelPesquisar.AutoScroll = true;
            PanelPesquisar.AutoScrollMargin = new Size(0, 90);
            PanelPesquisar.AutoScrollMinSize = new Size(0, 90);
            PanelPesquisar.BackColor = Color.LightGray;
            PanelPesquisar.BorderStyle = BorderStyle.FixedSingle;
            PanelPesquisar.Location = new Point(67, 142);
            PanelPesquisar.Name = "PanelPesquisar";
            PanelPesquisar.Size = new Size(980, 434);
            PanelPesquisar.TabIndex = 7;
            PanelPesquisar.MouseClick += AllForms_MouseClick;
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.FlatStyle = FlatStyle.Flat;
            LbTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Image = (Image)resources.GetObject("LbTitulo.Image");
            LbTitulo.ImageAlign = ContentAlignment.MiddleRight;
            LbTitulo.Location = new Point(70, 33);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Padding = new Padding(10, 0, 0, 0);
            LbTitulo.Size = new Size(209, 41);
            LbTitulo.TabIndex = 50;
            LbTitulo.Text = "Pesquisar       ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(60, 50);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 60;
            label1.Text = "___________________";
            // 
            // FormPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            ClientSize = new Size(1264, 751);
            Controls.Add(LbPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPesquisar";
            Text = "FormPesquisar";
            MouseClick += AllForms_MouseClick;
            LbPesquisar.ResumeLayout(false);
            LbPesquisar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LbPesquisar;
        private Label LbTitulo;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox TxtPesquisarNomes;
        private Button BtnPesquisarNomes;
        internal Panel PanelPesquisar;
        private ComboBox TxtPesquisarCargo;
        private ToolTip toolTip1;
        private Button button1;
    }
}