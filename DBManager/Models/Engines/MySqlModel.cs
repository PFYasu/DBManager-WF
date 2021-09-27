using DBManager.Utils;
using MySqlConnector;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.Models.Engines
{
    public class MySqlModel : IEngineModel
    {
        private readonly string _connectionString;

        public MySqlModel(Connection connection)
        {
            _connectionString = connection.ConnectionString;

            Name = connection.Name;
            Type = connection.Type;
        }

        public string Name { get; }
        public EngineType Type { get; }

        public async Task<DataTable> ExecuteQuery(string query)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            var dataTable = StartExecuteQuery(connection, query);

            await connection.CloseAsync();
            return dataTable;
        }

        public async Task<DataTable> ExecuteQuery(string query, string databaseName)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            await connection.ChangeDatabaseAsync(databaseName);

            var dataTable = StartExecuteQuery(connection, query);

            await connection.CloseAsync();
            return dataTable;
        }

        public async Task<int> ExecuteNonQuery(string query)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            var affected = await StartExecuteNonQuery(connection, query);

            await connection.CloseAsync();
            return affected;
        }

        public async Task<int> ExecuteNonQuery(string query, string databaseName)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            await connection.ChangeDatabaseAsync(databaseName);

            var affected = await StartExecuteNonQuery(connection, query);

            await connection.CloseAsync();
            return affected;
        }

        public async Task ChangeDatabase(string databaseName)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            await connection.CloseAsync();
        }

        private DataTable StartExecuteQuery(MySqlConnection connection, string query)
        {
            using var command = new MySqlCommand(query, connection);
            using var dataAdapter = new MySqlDataAdapter(command);

            var dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        private async Task<int> StartExecuteNonQuery(MySqlConnection connection, string query)
        {
            var command = new MySqlCommand(query, connection);
            var affected = await command.ExecuteNonQueryAsync();

            return affected;
        }
    }
}