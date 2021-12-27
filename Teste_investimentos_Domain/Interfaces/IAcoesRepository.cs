using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_investimentos_Domain.Models;

namespace Teste_investimentos_Domain.Interfaces
{
    public interface IAcoesRepository
    {
        void CadastrarAcao(NovaAcao acao);
    }
}
