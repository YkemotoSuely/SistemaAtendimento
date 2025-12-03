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
    public class EtapasAtendimentoController
    {
        private EtapasAtendimentoRepository _etapasAtendimentoRepository;
        private FrmAtendimento _frmAtendimento;

        // criando o cosntrutor

        public EtapasAtendimentoController(FrmAtendimento view) 
        { 
            _frmAtendimento = view;
            _etapasAtendimentoRepository = new EtapasAtendimentoRepository();   
        
        }

        public List<EtapasAtendimentos> Listar(int atendimentoId) 
        {
            return _etapasAtendimentoRepository. Listar(atendimentoId);
        }
        public void Salvar(EtapasAtendimentos etapasAtendimento) 
        {
            try
            {
                _etapasAtendimentoRepository.Inserir(etapasAtendimento);
                _frmAtendimento.ExibirMensagem("Atendimento etapa salvo com Sucesso!!");
            }
            catch (Exception ex) 
            {
                _frmAtendimento.ExibirMensagem($"Erro ao cadastrar o Atendimento etapa");
            }
        }
        public void Excluir(int id) 
        {
            try
            {
                _etapasAtendimentoRepository.Excluir(id);
                _frmAtendimento.ExibirMensagem("Atendimento etapa excluído com Sucesso!!");
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao excluir o Atendimento etapa { ex.Message}");
            }
        }
    }
}
