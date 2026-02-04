namespace SistemaAtendimento.View
{
    partial class FrmLogin
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
            lblEmail = new Label();
            lblSenha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntra = new Button();
            lblBemVindo = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(88, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(88, 184);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(51, 20);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(152, 184);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(264, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnEntra
            // 
            btnEntra.BackColor = SystemColors.InactiveCaption;
            btnEntra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntra.Location = new Point(336, 272);
            btnEntra.Name = "btnEntra";
            btnEntra.Size = new Size(200, 32);
            btnEntra.TabIndex = 4;
            btnEntra.Text = "Entrar";
            btnEntra.UseVisualStyleBackColor = false;
            btnEntra.Click += btnEntra_Click;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBemVindo.Location = new Point(176, 24);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(214, 53);
            lblBemVindo.TabIndex = 5;
            lblBemVindo.Text = "Bem Vindo";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 335);
            Controls.Add(lblBemVindo);
            Controls.Add(btnEntra);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEntra;
        private Label lblBemVindo;
    }
}