using ExemploDapperSqlServer.Domain.Contracts.Repositories;
using ExemploDapperSqlServer.Infra;
using ExemploDapperSqlServer.Infra.Repositories;

namespace ExemploDapperSqlServer.DependencyInjections
{
	public static class RepositoryDependency
	{
		public static void AddClientDIRepositories(this IServiceCollection services)
		{
			services.AddTransient<IClienteRepository, ClienteRepository>();
			services.AddSingleton<DataContext>();
		}
	}
}
