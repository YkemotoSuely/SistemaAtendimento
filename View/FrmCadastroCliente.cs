using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento
{
    public partial class FrmCadastroClientes : Form
    {
        private ClienteController _clienteController;

        public FrmCadastroClientes()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this); //o termo "this" refere-se 
        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Cpf_Cnpj = txtCpfCnpj.Text,
                TipoPessoa = rdbFisica.Checked ? "F" : "J",
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
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
        public bool ValidarDados(Clientes clientes)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo nome é obrigatório");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo email é obrigatório");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {
                if (rdbFisica.Checked)
                {
                    ExibirMensagem("O Campo CPF é Obrigatório");

                }
                else
                {
                    ExibirMensagem("O Campo CNPJ é Obrigatório");
                }

                txtCpfCnpj.Focus();
                return false;
            }
            else
            {
                if (rdbFisica.Checked)
                {
                    //verficar se o cpf é valido


                }
                else
                {
                    //verificar se o cnpj é valido
                }
            }

            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                ExibirMensagem("O campo CEP é obrigatório");
                txtCep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O campo endereço é obrigatório");
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O campo número é obrigatório");
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O campo bairro é obrigatório");
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O campo cidade é obrigatório");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O campo estado é obrigatório");
                cbxEstado.Focus();
                return false;
            }
            return true;
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridica.Checked)
            {
                lblCpfCnpj.Text = "CNPJ";

            }


        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFisica.Checked)
            {
                lblCpfCnpj.Text = "CPF";
            }
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            pnlTipoPessoa.Enabled = true;
            txtCpfCnpj.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtBairro.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            rdbFisica.Checked = true;
            rdbJuridica.Checked = true;
            txtCpfCnpj.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            cbxEstado.Text = "";
            rdbAtivo.Checked = true;
            rdbFisica.Checked = true;

        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            pnlTipoPessoa.Enabled = false;
            txtCpfCnpj.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtBairro.ReadOnly = true;
            cbxEstado.Enabled = false;
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

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow LinhaSelecionada = dgvClientes.Rows[e.RowIndex];

                txtCodigo.Text = LinhaSelecionada.Cells["Id"].Value.ToString();

                txtNome.Text = LinhaSelecionada.Cells["Nome"].Value.ToString();

                txtEmail.Text = LinhaSelecionada.Cells["Email"].Value.ToString();

                txtCpfCnpj.Text = LinhaSelecionada.Cells["Cpf_Cnpj"].Value.ToString();

                txtTelefone.Text = LinhaSelecionada.Cells["Telefone"].Value.ToString();

                txtCelular.Text = LinhaSelecionada.Cells["Celular"].Value.ToString();

                txtCep.Text = LinhaSelecionada.Cells["Cep"].Value.ToString();

                txtEndereco.Text = LinhaSelecionada.Cells["Endereco"].Value.ToString();

                txtNumero.Text = LinhaSelecionada.Cells["Numero"].Value.ToString();

                txtComplemento.Text = LinhaSelecionada.Cells["Complemento"].Value.ToString();

                txtBairro.Text = LinhaSelecionada.Cells["Bairro"].Value.ToString();

                txtCidade.Text = LinhaSelecionada.Cells["Cidade"].Value.ToString();

                cbxEstado.Text = LinhaSelecionada.Cells["Estado"].Value.ToString();

                rdbFisica.Checked = LinhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "F";

                rdbJuridica.Checked = LinhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "J";

                rdbAtivo.Checked = Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);

                rdbInativo.Checked = !Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);

                // Habilitar os botões de editar e excluir

                btnEditar.Enabled = true;

                btnNovo.Enabled = false;

                btnCancelar.Enabled = true;

                btnExcluir.Enabled = true;

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
                ExibirMensagem("Selecione Cliente");
                return; 
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir este Cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            { 
                int id = Convert.ToInt32(txtCodigo.Text);
                _clienteController.Excluir(id);
            }
        }
    }


}

