namespace SistemaAtendimento.View
{
    partial class FrmConsultaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            grbFiltro = new GroupBox();
            cbxFiltro = new ComboBox();
            txtFiltro = new TextBox();
            btnPesquisar = new Button();
            imageList1 = new ImageList(components);
            dgvConsultaAtendimento = new DataGridView();
            grbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            SuspendLayout();
            // 
            // grbFiltro
            // 
            grbFiltro.Controls.Add(dgvConsultaAtendimento);
            grbFiltro.Controls.Add(btnPesquisar);
            grbFiltro.Controls.Add(txtFiltro);
            grbFiltro.Controls.Add(cbxFiltro);
            grbFiltro.Location = new Point(8, 16);
            grbFiltro.Name = "grbFiltro";
            grbFiltro.Size = new Size(776, 416);
            grbFiltro.TabIndex = 0;
            grbFiltro.TabStop = false;
            grbFiltro.Text = "Filtrar por :";
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Location = new Point(8, 24);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(184, 23);
            cbxFiltro.TabIndex = 0;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(216, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(408, 23);
            txtFiltro.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(648, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(120, 32);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-pesquisar.png");
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(16, 88);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.Size = new Size(744, 320);
            dgvConsultaAtendimento.TabIndex = 3;
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbFiltro);
            Name = "FrmConsultaAtendimento";
            Text = "Consulta Atendimento";
            grbFiltro.ResumeLayout(false);
            grbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbFiltro;
        private Button btnPesquisar;
        private TextBox txtFiltro;
        private ComboBox cbxFiltro;
        private DataGridView dgvConsultaAtendimento;
        private ImageList imageList1;
    }
}