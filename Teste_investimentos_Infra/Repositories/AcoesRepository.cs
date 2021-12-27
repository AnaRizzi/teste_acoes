using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Teste_investimentos_Domain.Interfaces;
using MySql.Data.MySqlClient;
using Dapper;
using Teste_investimentos_Domain.Models;

namespace Teste_investimentos_Infra.Repositories
{
    public class AcoesRepository : IAcoesRepository
    {
        private IDbConnection _connection;

        public AcoesRepository(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }

        public void CadastrarAcao(NovaAcao acao)
        {
            var query = "INSERT INTO Acoes (Codigo_acao, Razao_social_empresa) VALUES (@codigo, @empresa)";

            _connection.ExecuteAsync(query, new { 
                codigo = acao.IdAcao,
                empresa = acao.RazaoSocialEmpresa
            });
     
        }
    }
}
