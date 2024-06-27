using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ExemploDapperSqlServer.Infra
{
	public class BaseParameter<T> where T : class
	{
		public object ObterParametros(T obj)
		{
			var propriedades = obj.GetType().GetProperties();
			var parametros = new Dictionary<string, object>();

			foreach (var propriedade in propriedades)
			{
				var propriedadeObj = obj.GetType()!.GetProperty(propriedade.Name)!.GetCustomAttribute<ColumnAttribute>()!.Name;
				var valor = obj.GetType()!.GetProperty(propriedade.Name)!.GetValue(obj);

				if (propriedade != null && valor != null)
				{
					parametros.Add(propriedadeObj!, valor!);
				}
			}

			return parametros;
		}
	}
}
