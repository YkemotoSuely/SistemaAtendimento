using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroEtapa : Form
    {
        private EtapaController _etapaController;

        public FrmCadastroEtapa()
        {
            InitializeComponent();
            _etapaController = new EtapaController(this);
        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        public void ExibirEtapas(List<Etapas> etapas)
        {
            dgvListaEtapas.DataSource = etapas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etapas etapa = new Etapas
            {
                Nome = txtNome.Text,
                Ordem = txtOrdem.Text,
                Ativo = rdbAtivo.Checked,
            };
            if (!ValidarDados(etapa))
                return;
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {

                _etapaController.Salvar(etapa);
            }
            else
            {
                etapa.Id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Atualizar(etapa);
            }

        }
        public bool ValidarDados(Etapas etapas)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo nome é obrigatório");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrdem.Text))
            {
                ExibirMensagem("O campo ordem é obrigatório");
                txtOrdem.Focus();
                return false;
            }
            return true;
        }
        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtOrdem.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtOrdem.Clear();
            rdbAtivo.Checked = true;
        }
        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvListaEtapas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow LinhaSelecionada = dgvListaEtapas.Rows[e.RowIndex];

                txtCodigo.Text = LinhaSelecionada.Cells["Id"].Value.ToString();

                txtNome.Text = LinhaSelecionada.Cells["Nome"].Value.ToString();

                txtOrdem.Text = LinhaSelecionada.Cells["Ordem"].Value.ToString();

                rdbAtivo.Checked = Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);

                rdbInativo.Checked = !Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);


                // Habilitar os botões de editar e excluir

                btnEditar.Enabled = true;

                btnNovo.Enabled = false;

                btnCancelar.Enabled = true;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Selecione Etapa");
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir esta etapa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Excluir(id);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _etapaController.ListarEtapas(termo);
        }
    }
    }
}

