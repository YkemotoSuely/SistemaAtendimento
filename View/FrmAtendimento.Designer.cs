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
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnCancelar = new Button();
            imlIcones = new ImageList(components);
            btnSalvar = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            comboBox3 = new ComboBox();
            button3 = new Button();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(742, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, -12);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 23;
            label4.Text = "Cód. Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(115, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.RightToLeft = RightToLeft.No;
            btnCancelar.Size = new Size(87, 33);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Finalizar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-editar.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(22, 159);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 33);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 110);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(493, 82);
            textBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 92);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 10;
            label6.Text = "Observações";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 110);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 23);
            comboBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 92);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 8;
            label5.Text = "Situação do Atendimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(520, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 31);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 4;
            label3.Text = "Data Abertura";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(382, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 31);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Cód. Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(742, 290);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Etapas do Atendimento";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = imlIcones;
            button1.Location = new Point(172, 225);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(122, 33);
            button1.TabIndex = 25;
            button1.Text = "Excluir Etapa";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(15, 47);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(285, 23);
            comboBox3.TabIndex = 13;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 3;
            button3.ImageList = imlIcones;
            button3.Location = new Point(22, 225);
            button3.Name = "button3";
            button3.Size = new Size(133, 34);
            button3.TabIndex = 23;
            button3.Text = "Adicionar Etapa";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 29);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 12;
            label8.Text = "Etapa do Atendimento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 103);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(285, 116);
            textBox3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 85);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 12;
            label7.Text = "Observações";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(401, 234);
            dataGridView1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(468, 15);
            label9.Name = "label9";
            label9.Size = new Size(170, 32);
            label9.TabIndex = 24;
            label9.Text = "Atendimento: ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(644, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 25;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 588);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnCancelar;
        private ImageList imlIcones;
        private Button btnSalvar;
        private Button button1;
        private Button button3;
        private Label label4;
        private Label label9;
        private TextBox textBox4;
    }
}