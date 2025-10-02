using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapaController
    {
        private FrmCadastroEtapa _frmCadastroEtapa;
        private EtapaRepository _etapaRepository;

        public EtapaController(FrmCadastroEtapa view)
        {
            _frmCadastroEtapa = view;
            _etapaRepository = new EtapaRepository();

        }
        public void ListarEtapas()
        {
            try
            {
                var listaEtapas = _etapaRepository.Listar();
                _frmCadastroEtapa.ExibirEtapas(listaEtapas);
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($" erro ao carregar as etapas: {ex.Message}");
            }
        }
        public void Salvar(Etapas etapa)
        {

            try
            {
                _etapaRepository.Inserir(etapa);
                _frmCadastroEtapa.ExibirMensagem("Cliente cadastrado com sucesso");

                //atualizar DataGrid
                ListarEtapas();

                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao cadastrar a etapa: {ex.Message}");
            }
        }
        public void Atualizar(Etapas etapa)
        {

            try
            {
                _etapaRepository.Atualizar(etapa);
                _frmCadastroEtapa.ExibirMensagem("Cliente atualizado com sucesso");

                //atualizar DataGrid
                ListarEtapas();

                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao atualizar a etapa: {ex.Message}");
            }
        }
        public void Excluir(int id)
        {
            try
            {
                _etapaRepository.Excluir(id);
                _frmCadastroEtapa.ExibirMensagem("Etapa excluída com sucesso");
                ListarEtapas();

                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao excluir a etapa: {ex.Message}");
            }
        }
    }
}



