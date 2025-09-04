namespace SistemaAtendimento.View
{
    partial class FrmCadastroEtapa
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
            grbDadosEtapa = new GroupBox();
            lblCodigo = new Label();
            textBox1 = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblOrdem = new Label();
            textBox3 = new TextBox();
            lblSituacao = new Label();
            pnlSituacao = new Panel();
            btnNovo = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            button6 = new Button();
            grbListaEtapas = new GroupBox();
            dataGridView1 = new DataGridView();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            grbDadosEtapa.SuspendLayout();
            pnlSituacao.SuspendLayout();
            grbListaEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbDadosEtapa
            // 
            grbDadosEtapa.Controls.Add(pnlSituacao);
            grbDadosEtapa.Controls.Add(lblSituacao);
            grbDadosEtapa.Controls.Add(textBox3);
            grbDadosEtapa.Controls.Add(lblOrdem);
            grbDadosEtapa.Controls.Add(txtNome);
            grbDadosEtapa.Controls.Add(lblNome);
            grbDadosEtapa.Controls.Add(textBox1);
            grbDadosEtapa.Controls.Add(lblCodigo);
            grbDadosEtapa.Location = new Point(8, 16);
            grbDadosEtapa.Name = "grbDadosEtapa";
            grbDadosEtapa.Size = new Size(776, 168);
            grbDadosEtapa.TabIndex = 0;
            grbDadosEtapa.TabStop = false;
            grbDadosEtapa.Text = "Dados da Etapa";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(184, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(184, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(576, 23);
            txtNome.TabIndex = 3;
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(16, 80);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 4;
            lblOrdem.Text = "Ordem";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 5;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(296, 80);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 6;
            lblSituacao.Text = "Situação";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(296, 96);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(152, 32);
            pnlSituacao.TabIndex = 7;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(16, 200);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(64, 32);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "button1";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(104, 200);
            button2.Name = "button2";
            button2.Size = new Size(64, 32);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(192, 200);
            button3.Name = "button3";
            button3.Size = new Size(64, 32);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(280, 200);
            button4.Name = "button4";
            button4.Size = new Size(64, 32);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(368, 200);
            button5.Name = "button5";
            button5.Size = new Size(64, 32);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 192);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(456, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(280, 23);
            textBox4.TabIndex = 7;
            // 
            // button6
            // 
            button6.Location = new Point(744, 200);
            button6.Name = "button6";
            button6.Size = new Size(32, 32);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // grbListaEtapas
            // 
            grbListaEtapas.Controls.Add(dataGridView1);
            grbListaEtapas.Location = new Point(8, 256);
            grbListaEtapas.Name = "grbListaEtapas";
            grbListaEtapas.Size = new Size(784, 184);
            grbListaEtapas.TabIndex = 9;
            grbListaEtapas.TabStop = false;
            grbListaEtapas.Text = "Lista de Etapas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(768, 150);
            dataGridView1.TabIndex = 0;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 1;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(88, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 2;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaEtapas);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosEtapa);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapas";
            grbDadosEtapa.ResumeLayout(false);
            grbDadosEtapa.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            grbListaEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosEtapa;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox textBox1;
        private Label lblCodigo;
        private Panel pnlSituacao;
        private Label lblSituacao;
        private TextBox textBox3;
        private Label lblOrdem;
        private Button btnNovo;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private TextBox textBox4;
        private Button button6;
        private GroupBox grbListaEtapas;
        private DataGridView dataGridView1;
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
    }
}