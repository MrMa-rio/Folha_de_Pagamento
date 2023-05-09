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
            label13 = new Label();
            TxtCargo = new Label();
            label6 = new Label();
            TxtDataAdmissao = new MaskedTextBox();
            TxtIdCargo = new Label();
            label12 = new Label();
            label10 = new Label();
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
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Gênero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 118);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 155);
            label4.Name = "label4";
            label4.Size = new Size(35, 21);
            label4.TabIndex = 3;
            label4.Text = "RG:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 318);
            label5.Name = "label5";
            label5.Size = new Size(204, 21);
            label5.TabIndex = 4;
            label5.Text = "Matrícula do funcionário:";
            // 
            // TxtMatricula
            // 
            TxtMatricula.AutoSize = true;
            TxtMatricula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricula.Location = new Point(222, 315);
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(52, 25);
            TxtMatricula.TabIndex = 9;
            TxtMatricula.Text = "0000";
            // 
            // TxtNomeCompleto
            // 
            TxtNomeCompleto.AutoSize = true;
            TxtNomeCompleto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNomeCompleto.Location = new Point(222, 32);
            TxtNomeCompleto.MaximumSize = new Size(220, 22);
            TxtNomeCompleto.Name = "TxtNomeCompleto";
            TxtNomeCompleto.Size = new Size(0, 22);
            TxtNomeCompleto.TabIndex = 5;
            // 
            // PnlInformacoesFunc
            // 
            PnlInformacoesFunc.AutoScroll = true;
            PnlInformacoesFunc.AutoScrollMargin = new Size(0, 25);
            PnlInformacoesFunc.BackColor = Color.LightGray;
            PnlInformacoesFunc.Controls.Add(label13);
            PnlInformacoesFunc.Controls.Add(TxtCargo);
            PnlInformacoesFunc.Controls.Add(label6);
            PnlInformacoesFunc.Controls.Add(TxtDataAdmissao);
            PnlInformacoesFunc.Controls.Add(TxtIdCargo);
            PnlInformacoesFunc.Controls.Add(label12);
            PnlInformacoesFunc.Controls.Add(label10);
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
            PnlInformacoesFunc.Size = new Size(436, 416);
            PnlInformacoesFunc.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(42, 360);
            label13.Name = "label13";
            label13.Size = new Size(347, 30);
            label13.TabIndex = 21;
            label13.Text = "Cadastro efetuado com sucesso!";
            // 
            // TxtCargo
            // 
            TxtCargo.AutoSize = true;
            TxtCargo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCargo.Location = new Point(222, 233);
            TxtCargo.MaximumSize = new Size(220, 22);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.Size = new Size(0, 22);
            TxtCargo.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 238);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 19;
            label6.Text = "Cargo:";
            // 
            // TxtDataAdmissao
            // 
            TxtDataAdmissao.BackColor = Color.LightGray;
            TxtDataAdmissao.BorderStyle = BorderStyle.None;
            TxtDataAdmissao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDataAdmissao.ForeColor = SystemColors.WindowText;
            TxtDataAdmissao.Location = new Point(222, 275);
            TxtDataAdmissao.Mask = "00/00/0000";
            TxtDataAdmissao.Name = "TxtDataAdmissao";
            TxtDataAdmissao.ReadOnly = true;
            TxtDataAdmissao.Size = new Size(101, 25);
            TxtDataAdmissao.TabIndex = 18;
            TxtDataAdmissao.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtIdCargo
            // 
            TxtIdCargo.AutoSize = true;
            TxtIdCargo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIdCargo.Location = new Point(223, 195);
            TxtIdCargo.Name = "TxtIdCargo";
            TxtIdCargo.Size = new Size(0, 25);
            TxtIdCargo.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(17, 198);
            label12.Name = "label12";
            label12.Size = new Size(78, 21);
            label12.TabIndex = 16;
            label12.Text = "ID cargo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(17, 278);
            label10.Name = "label10";
            label10.Size = new Size(126, 21);
            label10.TabIndex = 15;
            label10.Text = "Data admissão:";
            // 
            // TxtGenero
            // 
            TxtGenero.AutoSize = true;
            TxtGenero.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtGenero.Location = new Point(222, 75);
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
            TxtRg.Location = new Point(222, 155);
            TxtRg.Mask = "00,000,000-A";
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
            TxtCpf.Location = new Point(222, 115);
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
            label11.Location = new Point(99, 9);
            label11.Name = "label11";
            label11.Size = new Size(303, 46);
            label11.TabIndex = 11;
            label11.Text = "Dados cadastrados";
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.DarkGray;
            BtnOK.Cursor = Cursors.Hand;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOK.Location = new Point(190, 501);
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
        private Label TxtIdCargo;
        private Label label12;
        private Label label10;
        private MaskedTextBox TxtDataAdmissao;
        private Label TxtCargo;
        private Label label6;
        private Label label13;
    }
}