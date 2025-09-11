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

            if(!ValidarDados(cliente))
                return;

            _clienteController.Salvar(cliente);
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

            if (rdbFisica.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
                {
                    ExibirMensagem("O campo CPF é obrigatório");
                    txtCpfCnpj.Focus();
                    return false;
                }

            }
            else if (rdbJuridica.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
                {
                    ExibirMensagem("O campo CNPJ é obrigatório");
                    txtCpfCnpj.Focus();
                    return false;
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
    }
}
