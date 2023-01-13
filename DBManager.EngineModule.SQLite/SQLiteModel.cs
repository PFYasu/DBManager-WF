using DBManager.Core.Models;
using DBManager.Core.Models.Engines;
using DBManager.Core.Utils;
using System.Data;
using System.Data.SQLite;

namespace DBManager.EngineModule.SQLite;

public class SQLiteModel : IEngineModel
{
    private readonly string _connectionString;

    public SQLiteModel(Connection connection)
    {
        var connectionParameters = connection.ConnectionParameters;
        _connectionString = ConnectorHelper.CombineToConnectionString(connectionParameters);

        Name = connection.Name;
        EngineType = connection.EngineType;
        ConnectionParameters = connectionParameters;
    }

    public string Name { get; }
    public string EngineType { get; }
    public Dictionary<string, string> ConnectionParameters { get; }

    public async Task<DataTable> ExecuteQuery(string query, string databaseName = null)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            await connection.OpenAsync();

            if (string.IsNullOrEmpty(databaseName) == false)
                await connection.ChangeDatabaseAsync(databaseName);

            using (var command = new SQLiteCommand(query, connection))
            using (var dataAdapter = new SQLiteDataAdapter(command))
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
        using (var connection = new SQLiteConnection(_connectionString))
        {
            await connection.OpenAsync();

            if (string.IsNullOrEmpty(databaseName) == false)
                await connection.ChangeDatabaseAsync(databaseName);

            using (var command = new SQLiteCommand(query, connection))
            {
                var affected = await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
                return affected;
            }
        }
    }
}
