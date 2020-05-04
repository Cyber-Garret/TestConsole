using Dapper;

using SqlToJson.Models;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SqlToJson
{
	interface IDataRepo
	{
		List<Exotic> GetExotics();
		List<Catalyst> GetCatalysts();
	}

	class DataRepo : IDataRepo
	{
		private readonly string connectionString;
		public DataRepo(string conn)
		{
			connectionString = conn;
		}

		public List<Catalyst> GetCatalysts()
		{
			using var db = new SqlConnection(connectionString);
			return db.Query<Catalyst>("SELECT * FROM Catalysts").ToList();
		}

		public List<Exotic> GetExotics()
		{
			using var db = new SqlConnection(connectionString);
			return db.Query<Exotic>("SELECT * FROM Exotics").ToList();
		}
	}
}
