﻿namespace FOLHA_DE_PAGAMENTO_.src.Forms
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(48, 16);
            label1.Name = "label1";
            label1.Size = new Size(222, 54);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo!";
            // 
            // BtnEntrar
            // 
            BtnEntrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEntrar.Location = new Point(34, 432);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(248, 60);
            BtnEntrar.TabIndex = 3;
            BtnEntrar.Text = "Login";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.MouseClick += BtnEntrar_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(34, 85);
            label4.Name = "label4";
            label4.Size = new Size(257, 28);
            label4.TabIndex = 5;
            label4.Text = "Faça o Login para continuar.";
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(74, 291);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PlaceholderText = "Senha";
            TxtPassword.Size = new Size(214, 29);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.KeyDown += TxtPassword_KeyDown;
            // 
            // TxtUser
            // 
            TxtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUser.Location = new Point(74, 210);
            TxtUser.Name = "TxtUser";
            TxtUser.PlaceholderText = "Matricula : 0010";
            TxtUser.Size = new Size(214, 29);
            TxtUser.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(147, 335);
            label5.Name = "label5";
            label5.Size = new Size(141, 19);
            label5.TabIndex = 8;
            label5.Text = "Esqueceu sua senha ?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 90, 32);
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
            panel1.Location = new Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 723);
            panel1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(48, 682);
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
            label6.Location = new Point(80, 689);
            label6.Name = "label6";
            label6.Size = new Size(185, 19);
            label6.TabIndex = 13;
            label6.Text = "Todos os direitos reservados.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
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
    }
}