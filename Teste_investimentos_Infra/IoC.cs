using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_investimentos_Domain.Interfaces;
using Teste_investimentos_Domain.Services;
using Teste_investimentos_Infra.Repositories;

namespace Teste_investimentos_Infra
{
    public static class IoC
    {
		public static IServiceCollection ConfigureContainer(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IAcoesService, AcoesService>();

			var connectionString = configuration.GetConnectionString("MySql");

			services.AddScoped<IAcoesRepository>(_ => new AcoesRepository(connectionString));

			return services;
		}
	}
}
