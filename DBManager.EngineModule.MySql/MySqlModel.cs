using DBManager.Core.Models;
using DBManager.Core.Models.Engines;
using DBManager.Core.Utils;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.EngineModule.MySql
{
    public class MySqlModel : IEngineModel
    {
        private readonly string _connectionString;

        public MySqlModel(Connection connection)
        {
            var connectionParameters = connection.ConnectionParameters;
            _connectionString = ConnectorHelper.Combine(connectionParameters);

            Name = connection.Name;
            EngineType = connection.EngineType;
            ConnectionParameters = connectionParameters;
            QueryTrackerDriverModel = new QueryTrackerDriverModel(connection.TrackedQueries);
        }

        public string Name { get; }
        public string EngineType { get; }
        public Dictionary<string, string> ConnectionParameters { get; }
        public IQueryTrackerDriverModel QueryTrackerDriverModel { get; }

        public async Task<DataTable> ExecuteQuery(string query, string databaseName = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                if (string.IsNullOrEmpty(databaseName) == false)
                    await connection.ChangeDatabaseAsync(databaseName);

                using (var command = new MySqlCommand(query, connection))
                using (var dataAdapter = new MySqlDataAdapter(command))
                {
                    var dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    await connection.CloseAsync();
                    return dataTable;
                }
            }
        }

        public async Task<int> ExecuteNonQuery(string query, string databaseName = null)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                if (string.IsNullOrEmpty(databaseName) == false)
                    await connection.ChangeDatabaseAsync(databaseName);

                var command = new MySqlCommand(query, connection);
                var affected = await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
                return affected;
            }
        }
    }
}