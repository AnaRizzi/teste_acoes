using System;

namespace Teste_investimentos_Domain.Exceptions
{
    public class AcaoNaoEncontradaException : Exception
    {
        public AcaoNaoEncontradaException() : base("Código de ação inválido!") { }
    }
}
