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
