namespace SistemaAtendimento
{
    partial class FrmCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroClientes));
            grbDadosCliente = new GroupBox();
            cbxEstado = new ComboBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            label1 = new Label();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtCep = new TextBox();
            lblCep = new Label();
            txtCpfCnpj = new TextBox();
            lblCpfCnpj = new Label();
            pnlTipoPessoa = new Panel();
            rdbJuridica = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtTelefone = new TextBox();
            blTelefone = new Label();
            txtEmail = new TextBox();
            lablEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnNovo = new Button();
            imlicones = new ImageList(components);
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnPesquisar = new Button();
            grbListaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            grbDadosCliente.SuspendLayout();
            pnlSituacao.SuspendLayout();
            pnlTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(cbxEstado);
            grbDadosCliente.Controls.Add(pnlSituacao);
            grbDadosCliente.Controls.Add(label1);
            grbDadosCliente.Controls.Add(lblEstado);
            grbDadosCliente.Controls.Add(txtCidade);
            grbDadosCliente.Controls.Add(lblCidade);
            grbDadosCliente.Controls.Add(txtComplemento);
            grbDadosCliente.Controls.Add(lblComplemento);
            grbDadosCliente.Controls.Add(txtBairro);
            grbDadosCliente.Controls.Add(lblBairro);
            grbDadosCliente.Controls.Add(txtNumero);
            grbDadosCliente.Controls.Add(lblNumero);
            grbDadosCliente.Controls.Add(txtEndereco);
            grbDadosCliente.Controls.Add(lblEndereco);
            grbDadosCliente.Controls.Add(txtCep);
            grbDadosCliente.Controls.Add(lblCep);
            grbDadosCliente.Controls.Add(txtCpfCnpj);
            grbDadosCliente.Controls.Add(lblCpfCnpj);
            grbDadosCliente.Controls.Add(pnlTipoPessoa);
            grbDadosCliente.Controls.Add(lblTipoPessoa);
            grbDadosCliente.Controls.Add(txtCelular);
            grbDadosCliente.Controls.Add(lblCelular);
            grbDadosCliente.Controls.Add(txtTelefone);
            grbDadosCliente.Controls.Add(blTelefone);
            grbDadosCliente.Controls.Add(txtEmail);
            grbDadosCliente.Controls.Add(lablEmail);
            grbDadosCliente.Controls.Add(txtNome);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigo);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Location = new Point(16, 16);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(832, 280);
            grbDadosCliente.TabIndex = 0;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            // 
            // cbxEstado
            // 
            cbxEstado.Enabled = false;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(760, 184);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(65, 23);
            cbxEstado.TabIndex = 13;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Enabled = false;
            pnlSituacao.Location = new Point(8, 232);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(152, 32);
            pnlSituacao.TabIndex = 14;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(80, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Checked = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 216);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 28;
            label1.Text = "Situação";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(760, 168);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 26;
            lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(520, 184);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(216, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(520, 168);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(296, 184);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.ReadOnly = true;
            txtComplemento.Size = new Size(200, 23);
            txtComplemento.TabIndex = 11;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(296, 168);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 22;
            lblComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(8, 184);
            txtBairro.Name = "txtBairro";
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(264, 23);
            txtBairro.TabIndex = 10;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(8, 168);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 20;
            lblBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(736, 136);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(88, 23);
            txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(736, 120);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Número";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(200, 136);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ReadOnly = true;
            txtEndereco.Size = new Size(512, 23);
            txtEndereco.TabIndex = 8;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(200, 120);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 16;
            lblEndereco.Text = "Endereço";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(8, 136);
            txtCep.Name = "txtCep";
            txtCep.ReadOnly = true;
            txtCep.Size = new Size(168, 23);
            txtCep.TabIndex = 7;
            txtCep.Leave += txtCep_Leave;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(8, 120);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(584, 88);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.ReadOnly = true;
            txtCpfCnpj.Size = new Size(240, 23);
            txtCpfCnpj.TabIndex = 6;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(584, 72);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(28, 15);
            lblCpfCnpj.TabIndex = 12;
            lblCpfCnpj.Text = "CPF";
            // 
            // pnlTipoPessoa
            // 
            pnlTipoPessoa.Controls.Add(rdbJuridica);
            pnlTipoPessoa.Controls.Add(rdbFisica);
            pnlTipoPessoa.Enabled = false;
            pnlTipoPessoa.Location = new Point(400, 88);
            pnlTipoPessoa.Name = "pnlTipoPessoa";
            pnlTipoPessoa.Size = new Size(168, 32);
            pnlTipoPessoa.TabIndex = 5;
            // 
            // rdbJuridica
            // 
            rdbJuridica.AutoSize = true;
            rdbJuridica.Location = new Point(96, 8);
            rdbJuridica.Name = "rdbJuridica";
            rdbJuridica.Size = new Size(65, 19);
            rdbJuridica.TabIndex = 12;
            rdbJuridica.Text = "Jurídica";
            rdbJuridica.UseVisualStyleBackColor = false;
            rdbJuridica.CheckedChanged += rdbJuridica_CheckedChanged;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Checked = true;
            rdbFisica.Location = new Point(8, 8);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 12;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Física";
            rdbFisica.UseVisualStyleBackColor = true;
            rdbFisica.CheckedChanged += rdbFisica_CheckedChanged;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(400, 72);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(69, 15);
            lblTipoPessoa.TabIndex = 10;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(200, 88);
            txtCelular.Name = "txtCelular";
            txtCelular.ReadOnly = true;
            txtCelular.Size = new Size(176, 23);
            txtCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(200, 72);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(8, 88);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new Size(168, 23);
            txtTelefone.TabIndex = 3;
            // 
            // blTelefone
            // 
            blTelefone.AutoSize = true;
            blTelefone.Location = new Point(8, 72);
            blTelefone.Name = "blTelefone";
            blTelefone.Size = new Size(51, 15);
            blTelefone.TabIndex = 6;
            blTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(536, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(288, 23);
            txtEmail.TabIndex = 2;
            // 
            // lablEmail
            // 
            lablEmail.AutoSize = true;
            lablEmail.Location = new Point(536, 24);
            lablEmail.Name = "lablEmail";
            lablEmail.Size = new Size(41, 15);
            lablEmail.TabIndex = 4;
            lablEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 40);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(384, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(128, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(8, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(520, 312);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 40;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(520, 328);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(272, 23);
            txtPesquisar.TabIndex = 20;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlicones;
            btnNovo.Location = new Point(32, 312);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 40);
            btnNovo.TabIndex = 15;
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
            btnEditar.Location = new Point(128, 312);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 16;
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
            btnSalvar.Location = new Point(224, 312);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 40);
            btnSalvar.TabIndex = 17;
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
            btnExcluir.Location = new Point(320, 312);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 40);
            btnExcluir.TabIndex = 18;
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
            btnCancelar.Location = new Point(416, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 40);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageKey = "icone-pesquisar.png";
            btnPesquisar.ImageList = imlicones;
            btnPesquisar.Location = new Point(800, 312);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(40, 40);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += button1_Click;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Location = new Point(16, 376);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(832, 192);
            grbListaClientes.TabIndex = 47;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(8, 24);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(816, 152);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 581);
            Controls.Add(grbListaClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(lblPesquisar);
            Controls.Add(grbDadosCliente);
            Controls.Add(txtPesquisar);
            Name = "FrmCadastroClientes";
            Text = "Cadastro de Clientes";
            Load += FrmCadastroClientes_Load;
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            pnlTipoPessoa.ResumeLayout(false);
            pnlTipoPessoa.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCelular;
        private Label lblCelular;
        private TextBox txtTelefone;
        private Label blTelefone;
        private TextBox txtEmail;
        private Label lablEmail;
        private Panel pnlTipoPessoa;
        private Label lblTipoPessoa;
        private RadioButton rdbJuridica;
        private RadioButton rdbFisica;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtCpfCnpj;
        private Label lblCpfCnpj;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblEstado;
        private Label lblBairro;
        private Label label1;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private ComboBox cbxEstado;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgvClientes;
        private ImageList imlicones;
    }
}