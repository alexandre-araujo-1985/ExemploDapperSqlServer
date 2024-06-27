using Dapper;
using ExemploDapperSqlServer.Domain.Contracts;
using ExemploDapperSqlServer.Domain.Entities;
using ExemploDapperSqlServer.Domain.Contracts.Repositories;

namespace ExemploDapperSqlServer.Infra.Repositories
{
	public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
	{
		public ClienteRepository(DataContext dataContext) : base(dataContext, TabelaConstant.TabelaCliente)
		{
		}
	}
}
