namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            BtnEntrar = new Button();
            label4 = new Label();
            TxtPassword = new TextBox();
            TxtUser = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(250, 48);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo!";
            // 
            // BtnEntrar
            // 
            BtnEntrar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEntrar.Cursor = Cursors.Hand;
            BtnEntrar.FlatAppearance.BorderSize = 0;
            BtnEntrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 122, 44);
            BtnEntrar.FlatStyle = FlatStyle.Flat;
            BtnEntrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEntrar.ForeColor = Color.White;
            BtnEntrar.Location = new Point(34, 497);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(248, 60);
            BtnEntrar.TabIndex = 3;
            BtnEntrar.Text = "Login";
            toolTip1.SetToolTip(BtnEntrar, "Fazer login");
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.MouseClick += BtnEntrar_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(62, 143);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 5;
            label4.Text = "Faça o Login para continuar.";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(46, 90, 32);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.ForeColor = Color.White;
            TxtPassword.Location = new Point(74, 346);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PlaceholderText = "Digite sua senha";
            TxtPassword.Size = new Size(214, 22);
            TxtPassword.TabIndex = 2;
            toolTip1.SetToolTip(TxtPassword, "Digite sua senha");
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.KeyDown += TxtPassword_KeyDown;
            TxtPassword.KeyPress += All_KeyPress;
            // 
            // TxtUser
            // 
            TxtUser.BackColor = Color.FromArgb(46, 90, 32);
            TxtUser.BorderStyle = BorderStyle.None;
            TxtUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUser.ForeColor = Color.White;
            TxtUser.Location = new Point(74, 265);
            TxtUser.Name = "TxtUser";
            TxtUser.PlaceholderText = "Digite sua matrícula";
            TxtUser.Size = new Size(214, 22);
            TxtUser.TabIndex = 1;
            TxtUser.KeyPress += All_KeyPress;
            toolTip1.SetToolTip(TxtUser, "Digite seu usuário");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(147, 390);
            label5.Name = "label5";
            label5.Size = new Size(141, 19);
            label5.TabIndex = 8;
            label5.Text = "Esqueceu sua senha ?";
            toolTip1.SetToolTip(label5, "Esqueceu a senha ?");
            label5.MouseClick += label5_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TxtUser);
            panel1.Controls.Add(TxtPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnEntrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 743);
            panel1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(48, 685);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(80, 688);
            label6.Name = "label6";
            label6.Size = new Size(185, 19);
            label6.TabIndex = 13;
            label6.Text = "Todos os direitos reservados.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 335);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(66, 110, 82);
            label2.Location = new Point(72, 356);
            label2.Name = "label2";
            label2.Size = new Size(222, 15);
            label2.TabIndex = 15;
            label2.Text = "___________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(66, 110, 82);
            label3.Location = new Point(72, 275);
            label3.Name = "label3";
            label3.Size = new Size(222, 15);
            label3.TabIndex = 16;
            label3.Text = "___________________________________________";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 90, 32);
            ClientSize = new Size(343, 790);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.1D;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnEntrar;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox TxtPassword;
        private TextBox TxtUser;
        private PictureBox pictureBox3;
        private Label label6;
        private ToolTip toolTip1;
        private Label label2;
        private Label label3;
    }
}