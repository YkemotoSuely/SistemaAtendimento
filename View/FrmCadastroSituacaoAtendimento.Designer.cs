namespace SistemaAtendimento.View
{
    partial class FrmCadastroSituacaoAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroSituacaoAtendimento));
            txtCodigo = new TextBox();
            grbDadosSituacaoAtendimento = new GroupBox();
            txtNome = new TextBox();
            txtCor = new TextBox();
            pnlSituacao = new Panel();
            lblCodigo = new Label();
            lblNome = new Label();
            lblCor = new Label();
            lblSituacao = new Label();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            dgvListaSituacoesAtendimento = new DataGridView();
            grbListaSituacoesAtendimento = new GroupBox();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            grbDadosSituacaoAtendimento.SuspendLayout();
            pnlSituacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaSituacoesAtendimento).BeginInit();
            grbListaSituacoesAtendimento.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(136, 23);
            txtCodigo.TabIndex = 0;
            // 
            // grbDadosSituacaoAtendimento
            // 
            grbDadosSituacaoAtendimento.Controls.Add(lblSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(lblCor);
            grbDadosSituacaoAtendimento.Controls.Add(lblNome);
            grbDadosSituacaoAtendimento.Controls.Add(lblCodigo);
            grbDadosSituacaoAtendimento.Controls.Add(pnlSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(txtCor);
            grbDadosSituacaoAtendimento.Controls.Add(txtNome);
            grbDadosSituacaoAtendimento.Controls.Add(txtCodigo);
            grbDadosSituacaoAtendimento.Location = new Point(8, 8);
            grbDadosSituacaoAtendimento.Name = "grbDadosSituacaoAtendimento";
            grbDadosSituacaoAtendimento.Size = new Size(776, 168);
            grbDadosSituacaoAtendimento.TabIndex = 1;
            grbDadosSituacaoAtendimento.TabStop = false;
            grbDadosSituacaoAtendimento.Text = "Dados da Situação do Atendimento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(216, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(440, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(16, 120);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(184, 23);
            txtCor.TabIndex = 2;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(264, 112);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(168, 32);
            pnlSituacao.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(216, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(16, 96);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 10;
            lblCor.Text = "Cor";
            lblCor.Click += lblOrdem_Click;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(264, 88);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 11;
            lblSituacao.Text = "Situação";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 2;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(96, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 3;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Continue;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(368, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(280, 208);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(72, 40);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(192, 208);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 40);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(104, 208);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 40);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(16, 208);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(72, 40);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(752, 216);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 32);
            btnPesquisar.TabIndex = 14;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(464, 224);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(280, 23);
            txtPesquisar.TabIndex = 13;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(464, 208);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 12;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dgvListaSituacoesAtendimento
            // 
            dgvListaSituacoesAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaSituacoesAtendimento.Location = new Point(8, 16);
            dgvListaSituacoesAtendimento.Name = "dgvListaSituacoesAtendimento";
            dgvListaSituacoesAtendimento.Size = new Size(768, 150);
            dgvListaSituacoesAtendimento.TabIndex = 0;
            // 
            // grbListaSituacoesAtendimento
            // 
            grbListaSituacoesAtendimento.Controls.Add(dgvListaSituacoesAtendimento);
            grbListaSituacoesAtendimento.Location = new Point(8, 264);
            grbListaSituacoesAtendimento.Name = "grbListaSituacoesAtendimento";
            grbListaSituacoesAtendimento.Size = new Size(784, 176);
            grbListaSituacoesAtendimento.TabIndex = 15;
            grbListaSituacoesAtendimento.TabStop = false;
            grbListaSituacoesAtendimento.Text = "Lista de Situações do Atendimento";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-editar.png");
            imageList1.Images.SetKeyName(2, "icone-excluir.png");
            imageList1.Images.SetKeyName(3, "icone-novo.png");
            imageList1.Images.SetKeyName(4, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // FrmCadastroSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaSituacoesAtendimento);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosSituacaoAtendimento);
            Name = "FrmCadastroSituacaoAtendimento";
            Text = "Cadastro de Situação de Atendimentos";
            grbDadosSituacaoAtendimento.ResumeLayout(false);
            grbDadosSituacaoAtendimento.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaSituacoesAtendimento).EndInit();
            grbListaSituacoesAtendimento.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private GroupBox grbDadosSituacaoAtendimento;
        private TextBox txtCor;
        private TextBox txtNome;
        private Panel pnlSituacao;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblCor;
        private Label lblSituacao;
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private DataGridView dgvListaSituacoesAtendimento;
        private GroupBox grbListaSituacoesAtendimento;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}