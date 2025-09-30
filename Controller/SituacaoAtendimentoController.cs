using System;

using System.Collections.Generic;

using SistemaAtendimento.Model;

using SistemaAtendimento.Repositories;

using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller

{

    public class SituacaoAtendimentoController

    {

        private FrmCadastroSituacaoAtendimento _frmCadastroSituacaoAtendimento;

        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;

        public SituacaoAtendimentoController(FrmCadastroSituacaoAtendimento view)

        {

            _frmCadastroSituacaoAtendimento = view;

            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();

        }

        public void ListarSituacaoAtendimentos()

        {

            try

            {

                var listaSituacaoAtendimentos = _situacaoAtendimentoRepository.Listar();

                _frmCadastroSituacaoAtendimento.ExibirSituacaoAtendimentos(listaSituacaoAtendimentos);

            }

            catch (Exception ex)

            {

                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao carregar as situações de atendimento: {ex.Message}");

            }

        }

        public void Salvar(SituacaoAtendimentos situacaoAtendimento)

        {

            try

            {

                _situacaoAtendimentoRepository.Inserir(situacaoAtendimento);

                _frmCadastroSituacaoAtendimento.ExibirMensagem($" Situacao de Atendimento cadastrado com Sucesso:");

                //atualizar dataGrid 

                ListarSituacaoAtendimentos();

                _frmCadastroSituacaoAtendimento.DesabilitarCampos();

            }

            catch (Exception ex)

            {

                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Cadastrar a Situacao de Atendimento: {ex.Message}");

            }

        }
        public void Atualizar(SituacaoAtendimentos situacaoAtendimento)
        {

            try
            {
                _situacaoAtendimentoRepository.Atualizar(situacaoAtendimento);

                _frmCadastroSituacaoAtendimento.ExibirMensagem($" Situacao de Atendimento atualizado com Sucesso:");

                //atualizar dataGrid 

                ListarSituacaoAtendimentos();

                _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao atualizar a Situacao de Atendimento: {ex.Message}");
            }
        }
        public void Excluir(int id)
        {
            try
            {
                _situacaoAtendimentoRepository.Excluir(id);
                _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação de Atendimento excluído com sucesso");
                ListarSituacaoAtendimentos();

                _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao excluir a Situação de Atendimento: {ex.Message}");
            }
        }

    }

}

