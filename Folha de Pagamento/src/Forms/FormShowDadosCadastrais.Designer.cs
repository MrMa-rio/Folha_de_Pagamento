namespace FOLHA_DE_PAGAMENTO_.src.Forms
{
    partial class FormShowDadosCadastrais
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtMatricula = new Label();
            TxtNomeCompleto = new Label();
            PnlInformacoesFunc = new Panel();
            TxtGenero = new Label();
            TxtRg = new MaskedTextBox();
            TxtCpf = new MaskedTextBox();
            label11 = new Label();
            BtnOK = new Button();
            PnlInformacoesFunc.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 48);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 128);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 208);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 288);
            label4.Name = "label4";
            label4.Size = new Size(35, 21);
            label4.TabIndex = 3;
            label4.Text = "RG:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 368);
            label5.Name = "label5";
            label5.Size = new Size(206, 21);
            label5.TabIndex = 4;
            label5.Text = "Matricula do Funcionario:";
            // 
            // TxtMatricula
            // 
            TxtMatricula.AutoSize = true;
            TxtMatricula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricula.Location = new Point(242, 368);
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(52, 25);
            TxtMatricula.TabIndex = 9;
            TxtMatricula.Text = "0000";
            // 
            // TxtNomeCompleto
            // 
            TxtNomeCompleto.AutoSize = true;
            TxtNomeCompleto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNomeCompleto.Location = new Point(242, 48);
            TxtNomeCompleto.MaximumSize = new Size(220, 22);
            TxtNomeCompleto.Name = "TxtNomeCompleto";
            TxtNomeCompleto.Size = new Size(0, 22);
            TxtNomeCompleto.TabIndex = 5;
            // 
            // PnlInformacoesFunc
            // 
            PnlInformacoesFunc.AutoScroll = true;
            PnlInformacoesFunc.BackColor = Color.LightGray;
            PnlInformacoesFunc.Controls.Add(TxtGenero);
            PnlInformacoesFunc.Controls.Add(TxtRg);
            PnlInformacoesFunc.Controls.Add(TxtCpf);
            PnlInformacoesFunc.Controls.Add(label1);
            PnlInformacoesFunc.Controls.Add(TxtMatricula);
            PnlInformacoesFunc.Controls.Add(label2);
            PnlInformacoesFunc.Controls.Add(label3);
            PnlInformacoesFunc.Controls.Add(label4);
            PnlInformacoesFunc.Controls.Add(label5);
            PnlInformacoesFunc.Controls.Add(TxtNomeCompleto);
            PnlInformacoesFunc.Location = new Point(28, 68);
            PnlInformacoesFunc.Name = "PnlInformacoesFunc";
            PnlInformacoesFunc.Size = new Size(436, 427);
            PnlInformacoesFunc.TabIndex = 10;
            // 
            // TxtGenero
            // 
            TxtGenero.AutoSize = true;
            TxtGenero.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtGenero.Location = new Point(242, 124);
            TxtGenero.Name = "TxtGenero";
            TxtGenero.Size = new Size(0, 25);
            TxtGenero.TabIndex = 13;
            // 
            // TxtRg
            // 
            TxtRg.BackColor = Color.LightGray;
            TxtRg.BorderStyle = BorderStyle.None;
            TxtRg.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRg.ForeColor = SystemColors.WindowText;
            TxtRg.Location = new Point(242, 285);
            TxtRg.Mask = "00,000,000-0";
            TxtRg.Name = "TxtRg";
            TxtRg.ReadOnly = true;
            TxtRg.Size = new Size(118, 25);
            TxtRg.TabIndex = 12;
            TxtRg.Text = "000000000";
            TxtRg.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = Color.LightGray;
            TxtCpf.BorderStyle = BorderStyle.None;
            TxtCpf.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.ForeColor = SystemColors.WindowText;
            TxtCpf.Location = new Point(242, 205);
            TxtCpf.Mask = "000,000,000-00";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.ReadOnly = true;
            TxtCpf.Size = new Size(135, 25);
            TxtCpf.TabIndex = 11;
            TxtCpf.Text = "00000000000";
            TxtCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(97, 9);
            label11.Name = "label11";
            label11.Size = new Size(308, 46);
            label11.TabIndex = 11;
            label11.Text = "Dados Cadastrados";
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.DarkGray;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Location = new Point(189, 501);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(107, 31);
            BtnOK.TabIndex = 12;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.MouseClick += BtnOK_MouseClick;
            // 
            // FormShowDadosCadastrais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(496, 544);
            Controls.Add(BtnOK);
            Controls.Add(label11);
            Controls.Add(PnlInformacoesFunc);
            Name = "FormShowDadosCadastrais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informaçoes Enviadas";
            Load += FormShowDadosCadastrais_Load;
            PnlInformacoesFunc.ResumeLayout(false);
            PnlInformacoesFunc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label TxtMatricula;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label TxtNomeCompleto;
        private Panel PnlInformacoesFunc;
        private Label label11;
        private MaskedTextBox TxtRg;
        private MaskedTextBox TxtCpf;
        private Label TxtGenero;
        private Button BtnOK;
    }
}