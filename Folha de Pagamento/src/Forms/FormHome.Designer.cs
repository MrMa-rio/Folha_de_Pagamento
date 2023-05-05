namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            BtnMenu = new Button();
            BtnPerfil = new Button();
            BtnSetting = new Button();
            toolTip1 = new ToolTip(components);
            PnlPerfil = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PnlPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // BtnMenu
            // 
            BtnMenu.BackColor = Color.FromArgb(46, 76, 32);
            BtnMenu.BackgroundImage = Properties.Resources.menu2;
            BtnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BtnMenu.FlatAppearance.BorderSize = 0;
            BtnMenu.FlatStyle = FlatStyle.Flat;
            BtnMenu.Location = new Point(27, 28);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(48, 48);
            BtnMenu.TabIndex = 0;
            toolTip1.SetToolTip(BtnMenu, "Menu");
            BtnMenu.UseVisualStyleBackColor = false;
            BtnMenu.Visible = false;
            BtnMenu.MouseClick += BtnMenu_MouseClick;
            // 
            // BtnPerfil
            // 
            BtnPerfil.BackgroundImage = Properties.Resources.user;
            BtnPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            BtnPerfil.FlatAppearance.BorderSize = 0;
            BtnPerfil.FlatStyle = FlatStyle.Flat;
            BtnPerfil.Location = new Point(1180, 28);
            BtnPerfil.Name = "BtnPerfil";
            BtnPerfil.Size = new Size(48, 48);
            BtnPerfil.TabIndex = 1;
            toolTip1.SetToolTip(BtnPerfil, "Perfil");
            BtnPerfil.UseVisualStyleBackColor = true;
            BtnPerfil.MouseClick += BtnPerfil_MouseClick;
            // 
            // BtnSetting
            // 
            BtnSetting.BackgroundImage = (Image)resources.GetObject("BtnSetting.BackgroundImage");
            BtnSetting.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSetting.FlatAppearance.BorderSize = 0;
            BtnSetting.FlatStyle = FlatStyle.Flat;
            BtnSetting.Location = new Point(1107, 28);
            BtnSetting.Name = "BtnSetting";
            BtnSetting.Size = new Size(48, 48);
            BtnSetting.TabIndex = 2;
            toolTip1.SetToolTip(BtnSetting, "Configuração");
            BtnSetting.UseVisualStyleBackColor = true;
            // 
            // PnlPerfil
            // 
            PnlPerfil.BackColor = Color.White;
            PnlPerfil.Controls.Add(label6);
            PnlPerfil.Controls.Add(label5);
            PnlPerfil.Controls.Add(label4);
            PnlPerfil.Controls.Add(label3);
            PnlPerfil.Controls.Add(label2);
            PnlPerfil.Controls.Add(label1);
            PnlPerfil.Location = new Point(971, 82);
            PnlPerfil.Name = "PnlPerfil";
            PnlPerfil.Size = new Size(281, 410);
            PnlPerfil.TabIndex = 3;
            PnlPerfil.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 148);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 198);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 238);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 282);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 330);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 102);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            BackgroundImage = Properties.Resources.Impermais_green;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1264, 751);
            Controls.Add(PnlPerfil);
            Controls.Add(BtnSetting);
            Controls.Add(BtnPerfil);
            Controls.Add(BtnMenu);
            DoubleBuffered = true;
            MaximizeBox = false;
            MaximumSize = new Size(1280, 790);
            MinimumSize = new Size(1280, 790);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha de Pagamento";
            MouseClick += AllForms_MouseClick;
            PnlPerfil.ResumeLayout(false);
            PnlPerfil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        internal Button BtnMenu;
        private Panel PnlPerfil;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        internal Button BtnPerfil;
        internal Button BtnSetting;
    }
}