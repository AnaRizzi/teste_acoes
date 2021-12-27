using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_investimentos_Domain.Exceptions;
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
            var acaoExiste = _repository.VerificarSeAcaoExiste(request.IdAcao);

            if (!acaoExiste)
            {
                throw new AcaoNaoEncontradaException();
            }

            var acao = new CompraAcaoCompleta(request);

            _repository.CompraAcao(acao);
        }

        public Cotacao CotacaoAcao()
        {
            return new Cotacao();
        }

        public void VendaAcao(VendaAcao request)
        {
            var acaoExiste = _repository.VerificarSeAcaoExiste(request.IdAcao);

            if (!acaoExiste)
            {
                throw new AcaoNaoEncontradaException();
            }

            var acao = new VendaAcaoCompleta(request);

            _repository.VendaAcao(acao);
        }
    }
}
