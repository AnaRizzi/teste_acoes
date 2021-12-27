using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_investimentos_Domain.Interfaces;
using Teste_investimentos_Domain.Models;

namespace Teste_investimentos_Domain.Services
{
    public class AcoesService : IAcoesService
    {
        public readonly IAcoesRepository _repository;

        public AcoesService(IAcoesRepository repository)
        {
            _repository = repository;
        }

        public void CadastroAcoes(NovaAcao acao)
        {
            _repository.CadastrarAcao(acao);
        }

        public void CompraAcao(CompraAcao request)
        {
            throw new NotImplementedException();
        }

        public Cotacao CotacaoAcao()
        {
            return new Cotacao();
        }

        public void VendaAcao(VendaAcao request)
        {
            throw new NotImplementedException();
        }
    }
}
