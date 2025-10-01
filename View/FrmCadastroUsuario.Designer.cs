namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            grbDadosUsuario = new GroupBox();
            cbxPerfil = new ComboBox();
            lblPerfil = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlicones = new ImageList(components);
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnPesquisar = new Button();
            grbListaUsuarios = new GroupBox();
            dgvUsuarios = new DataGridView();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            grbDadosUsuario.SuspendLayout();
            grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(lblPerfil);
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(txtEmail);
            grbDadosUsuario.Controls.Add(lblEmail);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDadosUsuario.Location = new Point(16, 16);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Size = new Size(768, 168);
            grbDadosUsuario.TabIndex = 0;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // cbxPerfil
            // 
            cbxPerfil.Enabled = false;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "Administrador", "Usuário" });
            cbxPerfil.Location = new Point(544, 120);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(208, 25);
            cbxPerfil.TabIndex = 4;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(544, 96);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(38, 17);
            lblPerfil.TabIndex = 8;
            lblPerfil.Text = "Perfil";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(352, 120);
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = true;
            txtSenha.Size = new Size(160, 25);
            txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(352, 96);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 17);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(312, 25);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 17);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(152, 56);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(600, 25);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(152, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 17);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(112, 25);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 32);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(51, 17);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlicones;
            btnNovo.Location = new Point(24, 200);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 40);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imlicones
            // 
            imlicones.ColorDepth = ColorDepth.Depth32Bit;
            imlicones.ImageStream = (ImageListStreamer)resources.GetObject("imlicones.ImageStream");
            imlicones.TransparentColor = Color.Transparent;
            imlicones.Images.SetKeyName(0, "icone-cancelar.png");
            imlicones.Images.SetKeyName(1, "icone-editar.png");
            imlicones.Images.SetKeyName(2, "icone-excluir.png");
            imlicones.Images.SetKeyName(3, "icone-novo.png");
            imlicones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlicones.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlicones;
            btnEditar.Location = new Point(120, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlicones;
            btnSalvar.Location = new Point(216, 200);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 40);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlicones;
            btnExcluir.Location = new Point(312, 200);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 40);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlicones;
            btnCancelar.Location = new Point(408, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlicones;
            btnPesquisar.Location = new Point(744, 208);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(40, 31);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grbListaUsuarios
            // 
            grbListaUsuarios.Controls.Add(dgvUsuarios);
            grbListaUsuarios.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbListaUsuarios.Location = new Point(16, 256);
            grbListaUsuarios.Name = "grbListaUsuarios";
            grbListaUsuarios.Size = new Size(768, 192);
            grbListaUsuarios.TabIndex = 8;
            grbListaUsuarios.TabStop = false;
            grbListaUsuarios.Text = "Lista de Usuários";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(16, 24);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(736, 152);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(520, 216);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(208, 23);
            txtPesquisar.TabIndex = 9;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(520, 200);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 10;
            lblPesquisar.Text = "Pesquisar";
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(grbListaUsuarios);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosUsuario);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuários";
            Load += FrmCadastroUsuario_Load;
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosUsuario;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtSenha;
        private ComboBox cbxPerfil;
        private Label lblPerfil;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnPesquisar;
        private GroupBox grbListaUsuarios;
        private DataGridView dgvUsuarios;
        private TextBox txtPesquisar;
        private ImageList imlicones;
        private Label lblPesquisar;
    }
}