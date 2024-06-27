using ExemploDapperSqlServer.Application.Services;
using ExemploDapperSqlServer.Domain.Contracts.Services;

namespace ExemploDapperSqlServer.DependencyInjections
{
	public static class ServiceDependency
	{
		public static void AddClientDIServices(this IServiceCollection services)
		{
			services.AddTransient<IClienteService, ClienteService>();
		}
	}
}
