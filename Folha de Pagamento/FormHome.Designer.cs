﻿namespace FOLHA_DE_PAGAMENTO_
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
            BtnMenu = new Button();
            SuspendLayout();
            // 
            // BtnMenu
            // 
            BtnMenu.BackColor = Color.Transparent;
            BtnMenu.BackgroundImage = Properties.Resources.menu;
            BtnMenu.FlatAppearance.BorderSize = 0;
            BtnMenu.FlatStyle = FlatStyle.Flat;
            BtnMenu.Location = new Point(27, 28);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(48, 48);
            BtnMenu.TabIndex = 0;
            BtnMenu.UseVisualStyleBackColor = false;
            BtnMenu.MouseClick += BtnMenu_MouseClick;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 129, 241);
            BackgroundImage = Properties.Resources.BackgroundImage1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 751);
            Controls.Add(BtnMenu);
            DoubleBuffered = true;
            MaximizeBox = false;
            MaximumSize = new Size(1280, 790);
            MinimumSize = new Size(1280, 790);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha de Pagamento";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMenu;
    }
}