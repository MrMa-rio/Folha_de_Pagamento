namespace FOLHA_DE_PAGAMENTO_
{
    partial class FormHolerite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHolerite));
            LbAlterarCadastro = new Panel();
            BtnLimpar = new Button();
            PnlCtrlFunc = new Panel();
            LbTitulo = new Label();
            label1 = new Label();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            LbAlterarCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // LbAlterarCadastro
            // 
            LbAlterarCadastro.AccessibleRole = AccessibleRole.None;
            LbAlterarCadastro.BackColor = Color.LightGray;
            LbAlterarCadastro.Controls.Add(BtnLimpar);
            LbAlterarCadastro.Controls.Add(PnlCtrlFunc);
            LbAlterarCadastro.Controls.Add(LbTitulo);
            LbAlterarCadastro.Controls.Add(label1);
            LbAlterarCadastro.Controls.Add(BtnConfirmar);
            LbAlterarCadastro.Controls.Add(BtnCancelar);
            LbAlterarCadastro.Location = new Point(69, 41);
            LbAlterarCadastro.Name = "LbAlterarCadastro";
            LbAlterarCadastro.Size = new Size(1110, 630);
            LbAlterarCadastro.TabIndex = 2;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Enabled = false;
            BtnLimpar.FlatAppearance.BorderSize = 0;
            BtnLimpar.FlatStyle = FlatStyle.Flat;
            BtnLimpar.Image = (Image)resources.GetObject("BtnLimpar.Image");
            BtnLimpar.Location = new Point(742, 578);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(43, 43);
            BtnLimpar.TabIndex = 61;
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // PnlCtrlFunc
            // 
            PnlCtrlFunc.AutoScroll = true;
            PnlCtrlFunc.AutoScrollMargin = new Size(0, 90);
            PnlCtrlFunc.AutoScrollMinSize = new Size(0, 90);
            PnlCtrlFunc.BorderStyle = BorderStyle.FixedSingle;
            PnlCtrlFunc.Location = new Point(67, 142);
            PnlCtrlFunc.Name = "PnlCtrlFunc";
            PnlCtrlFunc.Size = new Size(986, 434);
            PnlCtrlFunc.TabIndex = 7;
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.FlatStyle = FlatStyle.Flat;
            LbTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Image = (Image)resources.GetObject("LbTitulo.Image");
            LbTitulo.ImageAlign = ContentAlignment.MiddleRight;
            LbTitulo.Location = new Point(60, 33);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Padding = new Padding(10, 0, 0, 0);
            LbTitulo.Size = new Size(189, 41);
            LbTitulo.TabIndex = 50;
            LbTitulo.Text = "Holerite       ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(70, 50);
            label1.Name = "label1";
            label1.Size = new Size(402, 37);
            label1.TabIndex = 60;
            label1.Text = "___________________________________";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Enabled = false;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Image = (Image)resources.GetObject("BtnConfirmar.Image");
            BtnConfirmar.Location = new Point(644, 578);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(43, 43);
            BtnConfirmar.TabIndex = 18;
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.Location = new Point(693, 578);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(43, 43);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormHolerite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 76, 32);
            ClientSize = new Size(1248, 712);
            Controls.Add(LbAlterarCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHolerite";
            Text = "FormHolerite";
            LbAlterarCadastro.ResumeLayout(false);
            LbAlterarCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LbAlterarCadastro;
        private Button BtnLimpar;
        private Panel PnlCtrlFunc;
        private Label LbTitulo;
        private Label label1;
        private Button BtnConfirmar;
        private Button BtnCancelar;
    }
}