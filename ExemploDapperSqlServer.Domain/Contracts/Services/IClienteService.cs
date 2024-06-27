using ExemploDapperSqlServer.Domain.Entities;

namespace ExemploDapperSqlServer.Domain.Contracts.Services
{
	public interface IClienteService
	{
		Cliente Pesquisar(int id);
		int Incluir(Cliente cliente);
		void Alterar(Cliente cliente);
		IEnumerable<Cliente> ListarTodos();
		void Excluir(int id);
	}
}
