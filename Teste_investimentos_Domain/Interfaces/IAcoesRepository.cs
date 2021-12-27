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
        void CompraAcao(CompraAcaoCompleta acao);
        bool VerificarSeAcaoExiste(int idAcao);
        void VendaAcao(VendaAcaoCompleta acao);
    }
}
