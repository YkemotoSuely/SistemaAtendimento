using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;
using static SistemaAtendimento.FrmCadastroCliente;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SistemaAtendimento.Database;
using System.Drawing.Text;

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimento : Form
    {
        private AtendimentoController _atendimentoController;
        private EtapasAtendimentoController _etapasAtendimentoController;

        private int? _atendimentoId;

        public FrmAtendimento(int? atendimentoId = null)
        {
            InitializeComponent();
            _atendimentoController = new AtendimentoController(this); //this injeta esse formulario no controlador

            _etapasAtendimentoController = new EtapasAtendimentoController(this);

            _atendimentoId = atendimentoId;
        }

        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();

        }

        private void CarregarClientes()
        {
            var clientes = _atendimentoController.ListarClientes();
            cbxNomeCliente.DataSource = clientes;
            cbxNomeCliente.DisplayMember = "Nome";
            cbxNomeCliente.SelectedIndex = -1;
            cbxNomeCliente.ValueMember = "Id";

            //filtros no comBobox
            cbxNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;//faz a busca enquanto digita
            cbxNomeCliente.AutoCompleteSource = AutoCompleteSource.ListItems;//faz a busca no que já tem na lista

            txtCodigoCliente.Text = "";// faz o campo do id comecar vazio 
        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarEtapas();
            CarregarSituacaoAtendimento();

            if (_atendimentoId.HasValue)
            {
                var atendimento = _atendimentoController.BuscarAtendimentoPorId(_atendimentoId.Value);

                if (atendimento != null)
                {
                    //Preencher campos
                    PreencherCampos(atendimento);

                    grbEtapasAtendimento.Enabled = true;

                    CarregarEtapasAtendimento();
                }
            }
        }

        private void PreencherCampos(Atendimentos atendimento)
        {
            txtCodigoAtendimento.Text = atendimento.Id.ToString();
            txtCodigoCliente.Text = atendimento.ClienteId.ToString();
            cbxNomeCliente.SelectedValue = atendimento.ClienteId;
            cbxSituacaoAtendimento.SelectedValue = atendimento.SituacaoAtendimentoId;
            dtpAberturaAtendimento.Value = atendimento.DataAbertura ?? DateTime.Now;
            txtObservacaoAtendimento.Text = atendimento.Observacao;

            txtObservacaoAtendimento.Enabled = true;
            txtObservacaoAtendimento.ReadOnly = false;
            cbxSituacaoAtendimento.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnFinalizarAtendimento.Enabled = true;
        }


        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNomeCliente.SelectedValue != null)//se o vaor é diferente de null ,entao tem alguma informação la 
            {
                txtCodigoCliente.Text = cbxNomeCliente.SelectedValue.ToString();
            }
        }

        private void CarregarEtapas()
        {
            var etapas = _atendimentoController.ListarEtapas();
            cbxEtapaAtendimento.DataSource = etapas;
            cbxEtapaAtendimento.DisplayMember = "Nome";
            cbxEtapaAtendimento.SelectedIndex = -1;
            //cbxEtapaAtendimento.ValueMember = "Id";  NAO É NECESSARIO DESSA LINHA

        }
        private void CarregarSituacaoAtendimento()
        {
            var situacaoAtendimento = _atendimentoController.ListarSituacaoAtendimentos();
            cbxSituacaoAtendimento.DataSource = situacaoAtendimento;
            cbxSituacaoAtendimento.DisplayMember = "Nome";
            cbxSituacaoAtendimento.SelectedIndex = -1;
            cbxSituacaoAtendimento.ValueMember = "Id";
        }

        //        private void HabilitarCampos();
        //        {
        //            cbxNomeCliente.Enabled = false;
        //            cbxEtapaAtendimento.Enabled = true;
        //            cbxSituacaoAtendimento.Enabled = true;
        //            txtDescricaoAtendimento.Enabled = true;
        //            dtpDataAtendimento.Enabled = true;
        //            btnSalvarAtendimento.Enabled = true;
        //        }
        //}

        private void HabilitarCampos()
        {
            txtObservacaoAtendimento.ReadOnly = false;
            txtObservacaoAtendimento.Enabled = true;
            cbxNomeCliente.Enabled = true;
            cbxEtapaAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            dtpAberturaAtendimento.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            LimparCampos();
            txtObservacaoAtendimento.ReadOnly = true;
            cbxNomeCliente.Enabled = false;
            cbxEtapaAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            dtpAberturaAtendimento.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            //txtCodigoAtendimento.Enabled = false;
        }

        private void LimparCampos()
        {
            txtObservacaoAtendimento.Clear();
            cbxNomeCliente.SelectedIndex = -1;
            cbxEtapaAtendimento.SelectedIndex = -1;
            cbxSituacaoAtendimento.SelectedIndex = -1;
            dtpAberturaAtendimento.Value = DateTime.Now;
            txtCodigoCliente.Clear();
            txtCodigoAtendimento.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atendimentos atendimento = new Atendimentos
            {
                Id = _atendimentoId ?? null,

                ClienteId = string.IsNullOrWhiteSpace(txtCodigoCliente.Text) ? null : Convert.ToInt32(cbxNomeCliente.SelectedValue),
                // ? if ternário tenta depois convert,
                UsuarioId = 1, // Substitua pelo ID do usuário logado
                SituacaoAtendimentoId = cbxSituacaoAtendimento.SelectedValue == null ? null : Convert.ToInt32(cbxSituacaoAtendimento.SelectedValue),
                Observacao = txtObservacaoAtendimento.Text,
                DataAbertura = dtpAberturaAtendimento.Value,

            };

            if (!Validardados(atendimento))
                return;

            if (_atendimentoId.HasValue && _atendimentoId > 0)
            {
                _atendimentoController.Atualizar(atendimento);
            }
            else
            {
                int? atendimentoId = _atendimentoController.Salvar(atendimento);

                txtCodigoAtendimento.Text = atendimentoId.ToString();

                _atendimentoId = atendimentoId;

                btnExcluir.Enabled = true;

                grbEtapasAtendimento.Enabled = true;

                CarregarEtapasAtendimento();
            }

        }
        private bool Validardados(Atendimentos atendimento)
        {
            //criar regras de validação de campos 
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text))
            {
                cbxNomeCliente.Focus();// coloca o foco no campo
                ExibirMensagem("Selecione um Cliente");
                return false;
            }

            if (cbxSituacaoAtendimento.SelectedValue == null)
            {
                cbxSituacaoAtendimento.Focus();
                ExibirMensagem("Selecione uma Situação do Atendimento");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtObservacaoAtendimento.Text))
            {
                ExibirMensagem("Informe uma Observação do Atendimento");
                txtObservacaoAtendimento.Focus();
                return false;
            }

            return true;

        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_atendimentoId.HasValue && -_atendimentoId < 0)
            {
                var Resultado = MessageBox.Show("Tem certeza que deseja este atendimento", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (Resultado == DialogResult.Yes)
                {
                    _atendimentoController.Excluir(_atendimentoId.Value);
                    DesabilitarCampos();
                }

            }
            else
            {
                ExibirMensagem(" Nenhum atendimento selecionado para exclusão");
            }


        }
        private void CarregarEtapasAtendimento()
        {
            if (!_atendimentoId.HasValue)
            {
                return;
            }
            dgvEtapasAtendimento.DataSource = _etapasAtendimentoController.Listar(_atendimentoId.Value);
        }

        private void btnAdicionarEtapa_Click(object sender, EventArgs e)
        {
            if (!_atendimentoId.HasValue)
            {
                MessageBox.Show("Salve o atendimento antes de adicionar etapas");
                return;
            }
            if (cbxEtapaAtendimento.SelectedValue == null)
            {
                MessageBox.Show("selecione uma Etapa");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEtapaObservacao.Text))
            {
                ExibirMensagem("Digite uma observação do Atendimento");
                txtEtapaObservacao.Focus();
                return;

            }

            var etapaAtendimento = new EtapasAtendimentos
            {
                AtendimentoId = _atendimentoId.Value,
                EtapaId = Convert.ToInt32(cbxEtapaAtendimento.SelectedValue),
                UsuarioId = 1,
                DataCadastro = DateTime.Now,
                Observacao = txtEtapaObservacao.Text,
            };

            _etapasAtendimentoController.Salvar(etapaAtendimento);

            cbxEtapaAtendimento.SelectedIndex = -1;
            txtEtapaObservacao.Clear();

            CarregarEtapasAtendimento();

        }

        private void btnExcluirEtapa_Click(object sender, EventArgs e)
        {
            if (dgvEtapasAtendimento.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Selecione uma etapa para excluir");
                return;

                int id = Convert.ToInt32(dgvEtapasAtendimento.SelectedRows[0].Cells["Id"].Value);

                var confirmar = MessageBox.Show("Deseja excluir esta Etapa?", "Confirmação", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes) 
                {
                    _etapasAtendimentoController.Excluir(id);
                    CarregarEtapasAtendimento();
                
                }
            }
        }
    }
}