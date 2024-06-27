using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace ExemploDapperSqlServer.Infra
{
	public class DataContext
	{
		public IDbConnection AbrirConexao()
		{
			var connectionString = @"Data Source =.\sqlexpress; Initial Catalog = ExemploDapper; Integrated Security = True; ;TrustServerCertificate=True";

			IDbConnection sqlConnection = new SqlConnection(connectionString);

			DefaultTypeMap.MatchNamesWithUnderscores = true;

			sqlConnection.Open();

			return sqlConnection;
		}
	}
}
