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
            BtnTrocarUsuario = new Button();
            PnlPerfil = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            PboxPerfil = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PboxPerfil).BeginInit();
            SuspendLayout();
            // 
            // BtnMenu
            // 
            BtnMenu.BackColor = Color.FromArgb(46, 76, 32);
            BtnMenu.BackgroundImage = Properties.Resources.menu2;
            BtnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BtnMenu.Cursor = Cursors.Hand;
            BtnMenu.FlatAppearance.BorderSize = 0;
            BtnMenu.FlatStyle = FlatStyle.Flat;
            BtnMenu.Location = new Point(27, 28);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(48, 48);
            BtnMenu.TabIndex = 0;
            toolTip1.SetToolTip(BtnMenu, "Menu");
            BtnMenu.UseVisualStyleBackColor = false;
            BtnMenu.Visible = false;
            BtnMenu.VisibleChanged += BtnMenu_VisibleChanged;
            BtnMenu.MouseClick += BtnMenu_MouseClick;
            // 
            // BtnPerfil
            // 
            BtnPerfil.BackgroundImage = Properties.Resources.user;
            BtnPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            BtnPerfil.Cursor = Cursors.Hand;
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
            BtnSetting.Cursor = Cursors.Hand;
            BtnSetting.FlatAppearance.BorderSize = 0;
            BtnSetting.FlatStyle = FlatStyle.Flat;
            BtnSetting.Location = new Point(1107, 28);
            BtnSetting.Name = "BtnSetting";
            BtnSetting.Size = new Size(48, 48);
            BtnSetting.TabIndex = 2;
            toolTip1.SetToolTip(BtnSetting, "Sobre os criadores e a empresa");
            BtnSetting.UseVisualStyleBackColor = true;
            BtnSetting.MouseClick += BtnSetting_MouseClick;
            // 
            // BtnTrocarUsuario
            // 
            BtnTrocarUsuario.BackColor = Color.Transparent;
            BtnTrocarUsuario.Cursor = Cursors.Hand;
            BtnTrocarUsuario.FlatAppearance.BorderSize = 0;
            BtnTrocarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            BtnTrocarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            BtnTrocarUsuario.FlatStyle = FlatStyle.Flat;
            BtnTrocarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTrocarUsuario.Image = (Image)resources.GetObject("BtnTrocarUsuario.Image");
            BtnTrocarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTrocarUsuario.Location = new Point(57, 315);
            BtnTrocarUsuario.Name = "BtnTrocarUsuario";
            BtnTrocarUsuario.Size = new Size(180, 48);
            BtnTrocarUsuario.TabIndex = 13;
            BtnTrocarUsuario.Text = "           Trocar de perfil";
            toolTip1.SetToolTip(BtnTrocarUsuario, "Trocar de perfil");
            BtnTrocarUsuario.UseVisualStyleBackColor = false;
            BtnTrocarUsuario.MouseClick += BtnTrocarUsuario_MouseClick;
            // 
            // PnlPerfil
            // 
            PnlPerfil.BackColor = Color.White;
            PnlPerfil.BackgroundImage = (Image)resources.GetObject("PnlPerfil.BackgroundImage");
            PnlPerfil.Controls.Add(BtnTrocarUsuario);
            PnlPerfil.Controls.Add(label12);
            PnlPerfil.Controls.Add(label11);
            PnlPerfil.Controls.Add(label10);
            PnlPerfil.Controls.Add(label9);
            PnlPerfil.Controls.Add(label8);
            PnlPerfil.Controls.Add(label7);
            PnlPerfil.Controls.Add(PboxPerfil);
            PnlPerfil.Controls.Add(label6);
            PnlPerfil.Controls.Add(label5);
            PnlPerfil.Controls.Add(label4);
            PnlPerfil.Controls.Add(label3);
            PnlPerfil.Controls.Add(label2);
            PnlPerfil.Controls.Add(label1);
            PnlPerfil.Location = new Point(971, 90);
            PnlPerfil.Name = "PnlPerfil";
            PnlPerfil.Size = new Size(281, 371);
            PnlPerfil.TabIndex = 3;
            PnlPerfil.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(25, 288);
            label12.Name = "label12";
            label12.Size = new Size(62, 19);
            label12.TabIndex = 12;
            label12.Text = "Nome : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(25, 263);
            label11.Name = "label11";
            label11.Size = new Size(118, 19);
            label11.TabIndex = 11;
            label11.Text = "Departamento : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(25, 238);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 10;
            label10.Text = "Cargo : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(25, 213);
            label9.Name = "label9";
            label9.Size = new Size(125, 19);
            label9.TabIndex = 9;
            label9.Text = "Nível de acesso : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 188);
            label8.Name = "label8";
            label8.Size = new Size(61, 19);
            label8.TabIndex = 8;
            label8.Text = "Status : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(25, 163);
            label7.Name = "label7";
            label7.Size = new Size(84, 19);
            label7.TabIndex = 7;
            label7.Text = "Matrícula : ";
            // 
            // PboxPerfil
            // 
            PboxPerfil.BackColor = Color.Transparent;
            PboxPerfil.BackgroundImage = (Image)resources.GetObject("PboxPerfil.BackgroundImage");
            PboxPerfil.BackgroundImageLayout = ImageLayout.Zoom;
            PboxPerfil.Location = new Point(81, 18);
            PboxPerfil.Name = "PboxPerfil";
            PboxPerfil.Size = new Size(120, 120);
            PboxPerfil.TabIndex = 6;
            PboxPerfil.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(91, 188);
            label6.MaximumSize = new Size(250, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(157, 214);
            label5.MaximumSize = new Size(250, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 4;
            label5.Text = "Nível Acesso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 238);
            label4.MaximumSize = new Size(250, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 3;
            label4.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(148, 263);
            label3.MaximumSize = new Size(250, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 2;
            label3.Text = "Departamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 288);
            label2.MaximumSize = new Size(250, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 163);
            label1.MaximumSize = new Size(250, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "Matrícula";
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
            ((System.ComponentModel.ISupportInitialize)PboxPerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        internal Button BtnMenu;
        internal Button BtnPerfil;
        internal Button BtnSetting;
        private PictureBox PboxPerfil;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button BtnTrocarUsuario;
        internal Panel PnlPerfil;
        internal Label label6;
        internal Label label5;
        internal Label label4;
        internal Label label3;
        internal Label label2;
        internal Label label1;
    }
}