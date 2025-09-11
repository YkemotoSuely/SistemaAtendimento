using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        private FrmCadastroClientes _frmCadastroCliente;
        private ClienteRepository _clienteRepository;

        public ClienteController(FrmCadastroClientes view) 
        {
            _frmCadastroCliente = view;
            _clienteRepository = new ClienteRepository();
            
        }

        public void ListarClientes() // a função try cath, testa o algoritmo dentro do escopo "try" e ,caso, dê erro retorna a mensagem declarada dentro do escopo "cath"
        {
            try
            {
                var listaClientes = _clienteRepository.Listar();

                _frmCadastroCliente.ExibirClientes(listaClientes);
            } 
            catch (Exception ex)
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            }
           
        }
        public void Salvar(Clientes cliente) 
        {
           
            try
            {
                _clienteRepository.Inserir(cliente);
                _frmCadastroCliente.ExibirMensagem("Cliente cadastrado com sucesso");
               
                //atualizar DataGrid
                ListarClientes();
            }
            catch (Exception ex) 
            {
                _frmCadastroCliente.ExibirMensagem($"Erro ao cadastrar o cliente: {ex.Message}");
            }
        }
    }
}
