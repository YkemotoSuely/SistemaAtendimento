namespace SistemaAtendimento.View
{
    partial class FrmAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtendimento));
            grbDadosCliente = new GroupBox();
            blSituacaoAtendimento = new Label();
            lablDataAbertura = new Label();
            lblNome = new Label();
            txtCodigoCliente = new TextBox();
            lblCodCliente = new Label();
            cbxNomeCliente = new ComboBox();
            cbxSituacaoAtendimento = new ComboBox();
            btnNovo = new Button();
            btnFinalizarAtendimento = new Button();
            dtpAberturaAtendimento = new DateTimePicker();
            label2 = new Label();
            txtCodigoAtendimento = new TextBox();
            txtObservacaoAtendimento = new TextBox();
            lblObservacoes = new Label();
            grbEtapasAtendimento = new GroupBox();
            lblAtendimento = new Label();
            txtEtapaObservacao = new TextBox();
            btnExcluirEtapa = new Button();
            btnAdicionarEtapa = new Button();
            cbxEtapaAtendimento = new ComboBox();
            lblEtapaAtendimento = new Label();
            label6 = new Label();
            dgvEtapasAtendimento = new DataGridView();
            imageList1 = new ImageList(components);
            btnPesquisarAtenidmento = new Button();
            btnEditar = new Button();
            button2 = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            grbDadosCliente.SuspendLayout();
            grbEtapasAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(btnCancelar);
            grbDadosCliente.Controls.Add(btnExcluir);
            grbDadosCliente.Controls.Add(button2);
            grbDadosCliente.Controls.Add(btnEditar);
            grbDadosCliente.Controls.Add(lblObservacoes);
            grbDadosCliente.Controls.Add(txtObservacaoAtendimento);
            grbDadosCliente.Controls.Add(dtpAberturaAtendimento);
            grbDadosCliente.Controls.Add(btnFinalizarAtendimento);
            grbDadosCliente.Controls.Add(btnNovo);
            grbDadosCliente.Controls.Add(cbxSituacaoAtendimento);
            grbDadosCliente.Controls.Add(cbxNomeCliente);
            grbDadosCliente.Controls.Add(blSituacaoAtendimento);
            grbDadosCliente.Controls.Add(lablDataAbertura);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigoCliente);
            grbDadosCliente.Controls.Add(lblCodCliente);
            grbDadosCliente.Location = new Point(8, 40);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(880, 232);
            grbDadosCliente.TabIndex = 1;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            grbDadosCliente.Enter += grbDadosCliente_Enter;
            // 
            // blSituacaoAtendimento
            // 
            blSituacaoAtendimento.AutoSize = true;
            blSituacaoAtendimento.Location = new Point(8, 80);
            blSituacaoAtendimento.Name = "blSituacaoAtendimento";
            blSituacaoAtendimento.Size = new Size(142, 15);
            blSituacaoAtendimento.TabIndex = 6;
            blSituacaoAtendimento.Text = "Situação do Atendimento";
            // 
            // lablDataAbertura
            // 
            lablDataAbertura.AutoSize = true;
            lablDataAbertura.Location = new Point(560, 24);
            lablDataAbertura.Name = "lablDataAbertura";
            lablDataAbertura.Size = new Size(80, 15);
            lablDataAbertura.TabIndex = 4;
            lablDataAbertura.Text = "Data Abertura";
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
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(8, 40);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Size = new Size(100, 23);
            txtCodigoCliente.TabIndex = 0;
            // 
            // lblCodCliente
            // 
            lblCodCliente.AutoSize = true;
            lblCodCliente.Location = new Point(8, 24);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(69, 15);
            lblCodCliente.TabIndex = 0;
            lblCodCliente.Text = "Cód.Cliente";
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.FormattingEnabled = true;
            cbxNomeCliente.Location = new Point(128, 40);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(416, 23);
            cbxNomeCliente.TabIndex = 29;
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(8, 96);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(240, 23);
            cbxSituacaoAtendimento.TabIndex = 31;
            // 
            // btnNovo
            // 
            btnNovo.Enabled = false;
            btnNovo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageKey = "icone-novo.png";
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(8, 192);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(104, 40);
            btnNovo.TabIndex = 32;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarAtendimento
            // 
            btnFinalizarAtendimento.Enabled = false;
            btnFinalizarAtendimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarAtendimento.ImageIndex = 6;
            btnFinalizarAtendimento.ImageList = imageList1;
            btnFinalizarAtendimento.Location = new Point(688, 192);
            btnFinalizarAtendimento.Name = "btnFinalizarAtendimento";
            btnFinalizarAtendimento.Size = new Size(176, 40);
            btnFinalizarAtendimento.TabIndex = 33;
            btnFinalizarAtendimento.Text = "Finalizar Atendimento";
            btnFinalizarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarAtendimento.UseVisualStyleBackColor = true;
            // 
            // dtpAberturaAtendimento
            // 
            dtpAberturaAtendimento.Location = new Point(560, 40);
            dtpAberturaAtendimento.Name = "dtpAberturaAtendimento";
            dtpAberturaAtendimento.Size = new Size(304, 23);
            dtpAberturaAtendimento.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(576, 8);
            label2.Name = "label2";
            label2.Size = new Size(149, 30);
            label2.TabIndex = 2;
            label2.Text = "Atendimento:";
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Location = new Point(728, 16);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.ReadOnly = true;
            txtCodigoAtendimento.Size = new Size(160, 23);
            txtCodigoAtendimento.TabIndex = 35;
            // 
            // txtObservacaoAtendimento
            // 
            txtObservacaoAtendimento.Location = new Point(280, 88);
            txtObservacaoAtendimento.Multiline = true;
            txtObservacaoAtendimento.Name = "txtObservacaoAtendimento";
            txtObservacaoAtendimento.Size = new Size(584, 96);
            txtObservacaoAtendimento.TabIndex = 35;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(280, 72);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(74, 15);
            lblObservacoes.TabIndex = 36;
            lblObservacoes.Text = "Observações";
            // 
            // grbEtapasAtendimento
            // 
            grbEtapasAtendimento.Controls.Add(dgvEtapasAtendimento);
            grbEtapasAtendimento.Controls.Add(lblAtendimento);
            grbEtapasAtendimento.Controls.Add(txtEtapaObservacao);
            grbEtapasAtendimento.Controls.Add(btnExcluirEtapa);
            grbEtapasAtendimento.Controls.Add(btnAdicionarEtapa);
            grbEtapasAtendimento.Controls.Add(cbxEtapaAtendimento);
            grbEtapasAtendimento.Controls.Add(lblEtapaAtendimento);
            grbEtapasAtendimento.Controls.Add(label6);
            grbEtapasAtendimento.Location = new Point(8, 280);
            grbEtapasAtendimento.Name = "grbEtapasAtendimento";
            grbEtapasAtendimento.Size = new Size(880, 296);
            grbEtapasAtendimento.TabIndex = 36;
            grbEtapasAtendimento.TabStop = false;
            grbEtapasAtendimento.Text = "Etapas do Atendimento";
            // 
            // lblAtendimento
            // 
            lblAtendimento.AutoSize = true;
            lblAtendimento.Location = new Point(8, 72);
            lblAtendimento.Name = "lblAtendimento";
            lblAtendimento.Size = new Size(74, 15);
            lblAtendimento.TabIndex = 36;
            lblAtendimento.Text = "Observações";
            // 
            // txtEtapaObservacao
            // 
            txtEtapaObservacao.Location = new Point(8, 88);
            txtEtapaObservacao.Multiline = true;
            txtEtapaObservacao.Name = "txtEtapaObservacao";
            txtEtapaObservacao.Size = new Size(280, 152);
            txtEtapaObservacao.TabIndex = 35;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.Enabled = false;
            btnExcluirEtapa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageIndex = 0;
            btnExcluirEtapa.ImageList = imageList1;
            btnExcluirEtapa.Location = new Point(160, 248);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(128, 40);
            btnExcluirEtapa.TabIndex = 33;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.Enabled = false;
            btnAdicionarEtapa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageIndex = 1;
            btnAdicionarEtapa.ImageList = imageList1;
            btnAdicionarEtapa.Location = new Point(8, 248);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(136, 40);
            btnAdicionarEtapa.TabIndex = 32;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(8, 40);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(280, 23);
            cbxEtapaAtendimento.TabIndex = 31;
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Location = new Point(8, 24);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(126, 15);
            lblEtapaAtendimento.TabIndex = 6;
            lblEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 24);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 0;
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(312, 56);
            dgvEtapasAtendimento.MultiSelect = false;
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.ReadOnly = true;
            dgvEtapasAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEtapasAtendimento.Size = new Size(552, 224);
            dgvEtapasAtendimento.TabIndex = 37;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-novo.png");
            imageList1.Images.SetKeyName(2, "icone-salvar.png");
            imageList1.Images.SetKeyName(3, "icone-editar.png");
            imageList1.Images.SetKeyName(4, "icone-excluir.png");
            imageList1.Images.SetKeyName(5, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(6, "Finalizar.png");
            // 
            // btnPesquisarAtenidmento
            // 
            btnPesquisarAtenidmento.Enabled = false;
            btnPesquisarAtenidmento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisarAtenidmento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtenidmento.ImageIndex = 5;
            btnPesquisarAtenidmento.ImageList = imageList1;
            btnPesquisarAtenidmento.Location = new Point(16, 0);
            btnPesquisarAtenidmento.Name = "btnPesquisarAtenidmento";
            btnPesquisarAtenidmento.Size = new Size(184, 35);
            btnPesquisarAtenidmento.TabIndex = 37;
            btnPesquisarAtenidmento.Text = "Pesquisar Atendimento";
            btnPesquisarAtenidmento.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarAtenidmento.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageKey = "icone-editar.png";
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(128, 192);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 40);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageKey = "icone-salvar.png";
            button2.ImageList = imageList1;
            button2.Location = new Point(248, 192);
            button2.Name = "button2";
            button2.Size = new Size(104, 40);
            button2.TabIndex = 38;
            button2.Text = "Salvar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageKey = "icone-excluir.png";
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(368, 192);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 40);
            btnExcluir.TabIndex = 39;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageKey = "icone-cancelar.png";
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(488, 192);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 40);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 596);
            Controls.Add(btnPesquisarAtenidmento);
            Controls.Add(grbEtapasAtendimento);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(label2);
            Controls.Add(grbDadosCliente);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            grbEtapasAtendimento.ResumeLayout(false);
            grbEtapasAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCliente;
        private Label blSituacaoAtendimento;
        private Label lablDataAbertura;
        private Label lblNome;
        private TextBox txtCodigoCliente;
        private Label lblCodCliente;
        private ComboBox cbxNomeCliente;
        private ComboBox cbxSituacaoAtendimento;
        private Button btnNovo;
        private DateTimePicker dtpAberturaAtendimento;
        private Button btnFinalizarAtendimento;
        private TextBox txtObservacaoAtendimento;
        private Label label2;
        private TextBox txtCodigoAtendimento;
        private Label lblObservacoes;
        private GroupBox grbEtapasAtendimento;
        private Label lblAtendimento;
        private TextBox txtEtapaObservacao;
        private Button btnExcluirEtapa;
        private Button btnAdicionarEtapa;
        private ComboBox cbxEtapaAtendimento;
        private Label lblEtapaAtendimento;
        private Label label6;
        private DataGridView dgvEtapasAtendimento;
        private ImageList imageList1;
        private Button btnPesquisarAtenidmento;
        private Button btnExcluir;
        private Button button2;
        private Button btnEditar;
        private Button btnCancelar;
    }
}