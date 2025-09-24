using SistemaAtendimento.Controller;

using SistemaAtendimento.Model;

namespace SistemaAtendimento.View

{

    public partial class FrmCadastroSituacaoAtendimento : Form

    {

        private SituacaoAtendimentoController _situacaoAtendimentoController;

        public FrmCadastroSituacaoAtendimento()

        {

            InitializeComponent();

            _situacaoAtendimentoController = new SituacaoAtendimentoController(this);

        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)

        {

            _situacaoAtendimentoController.ListarSituacaoAtendimentos();

        }

        public void ExibirMensagem(string mensagem)

        {

            MessageBox.Show(mensagem);

        }

        public void ExibirSituacaoAtendimentos(List<SituacaoAtendimentos> situacaoAtendimentos)

        {

            dgvListaSituacaoAtendimento.DataSource = situacaoAtendimentos;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SituacaoAtendimentos situacaoAtendimentos = new SituacaoAtendimentos
            {
                Nome = txtNome.Text,
                Cor = txtCor.Text,
                Ativo = rdbAtivo.Checked,
            };
            if (!ValidarDados(cliente))
                return;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _clienteController.Salvar(cliente);
            }
            else
            {
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                _clienteController.Atualizar(cliente);
            }
        }
        public bool ValidarDados(SituacaoAtendimentos situacaoAtendimentos)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo nome é obrigatório");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCor.Text))
            {
                ExibirMensagem("O campo cor é obrigatório");
                txtEmail.Focus();
                return false;
            }
            //terminar na próxima aula
        }

    }

