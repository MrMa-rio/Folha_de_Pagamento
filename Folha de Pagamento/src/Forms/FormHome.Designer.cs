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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            BtnMenu = new Button();
            BtnPerfil = new Button();
            BtnSetting = new Button();
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
            BtnMenu.UseVisualStyleBackColor = false;
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
            BtnPerfil.UseVisualStyleBackColor = true;
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
            BtnSetting.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            BackgroundImage = Properties.Resources.Impermais_green;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1264, 751);
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
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMenu;
        private Button BtnPerfil;
        private Button BtnSetting;
    }
}