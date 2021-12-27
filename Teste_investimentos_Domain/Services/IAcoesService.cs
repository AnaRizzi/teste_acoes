using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_investimentos_Domain.Models;

namespace Teste_investimentos_Domain.Services
{
    public interface IAcoesService
    {
        void CadastroAcoes(NovaAcao request);
        Cotacao CotacaoAcao();
        void CompraAcao(CompraAcao request);
        void VendaAcao(VendaAcao request);
    }
}
