using System.Data.SqlClient;
using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace MinimalApiDemo.DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly string connectionString;

        public SqlDataAccess(IConfiguration config)
        {
            connectionString = config.GetConnectionString("Default");
        }

        public async Task<IEnumerable<T>> QueryData<T, U>(
            string storedProcedure,
            U parameters)
        {
            using IDbConnection connection = new SqlConnection(connectionString);

            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task Execute<T>(
            string storedProcedure,
            T parameters)
        {
            using IDbConnection connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
