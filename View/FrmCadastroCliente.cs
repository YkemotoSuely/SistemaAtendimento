using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento
{
    public partial class FrmCadastroCliente : Form
    {
        private ClienteController _clienteController;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this);
        }




        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);

        }

        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes;
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();
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
                Cep =   txtCep.Text,
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

        public bool ValidarDados(Clientes cliente)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O Campo Nome é Obrigatório");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O Campo E-mail é Obrigatório");
                txtEmail.Focus();
                return false;
            }
                          
             if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
              {
                
                 ExibirMensagem("O Campo CPF/CNPJ é Obrigatório");

                 txtCpfCnpj.Focus();
                 return false;
              }
                     
           
            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                ExibirMensagem("O Campo CEP é Obrigatório");
                txtCep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O Campo Endereço é Obrigatório");
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O Campo Número é Obrigatório");
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O Campo Bairro é Obrigatório");
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O Campo Cidade é Obrigatório");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O Campo Estado é Obrigatório");
                cbxEstado.Focus();
                return false;
            }

            
            return true;
        }

    }
}
