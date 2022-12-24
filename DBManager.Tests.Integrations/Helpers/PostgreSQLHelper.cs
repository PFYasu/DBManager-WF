using DBManager.Core.Models;
using DBManager.Core.Utils;
using DBManager.EngineModule.PostgreSQL;
using Npgsql;

namespace DBManager.Tests.Integrations.Helpers;

public class PostgreSQLHelper : IDisposable
{
    private readonly List<ConnectionStructure> _connectionStructures = new();
    private readonly string _connectionString;
    private readonly string _escapeDatabase;
    public readonly Dictionary<string, string> ConnectionParameters = new();

    public PostgreSQLHelper()
    {
        var connectionString = Environment.GetEnvironmentVariable(ConnectionStringEnvironmentVariable);
        var escapeDatabase = Environment.GetEnvironmentVariable(EscapeDatabaseEnvironmentVariable);

        _connectionString = connectionString;
        _escapeDatabase = escapeDatabase;
        ConnectionParameters = ConnectorHelper.CombineToDictionary(connectionString);
    }

    public const string ConnectionStringEnvironmentVariable = "DBM_POSTGRESQL_CS";
    public const string EscapeDatabaseEnvironmentVariable = "DBM_POSTGRESQL_ED";

    public PostgreSQLPresenter CreatePresenter()
    {
        var connection = new Connection
        {
            Name = NamesGenerator.Generate(),
            EngineType = "PostgreSQL",
            ConnectionParameters = ConnectionParameters,
            TrackedQueries = new List<TrackedQuery>()
        };

        var model = new PostgreSQLModel(connection);
        var presenter = new PostgreSQLPresenter(model, null);

        return presenter;
    }

    public NpgsqlConnection CreateConnection()
    {
        var connection = new NpgsqlConnection(_connectionString);

        var connectionStructure = new ConnectionStructure { Connection = connection };

        _connectionStructures.Add(connectionStructure);

        return connection;
    }

    public async Task<string> CreateDatabase(NpgsqlConnection connection)
    {
        var databaseName = NamesGenerator.Generate();

        var connectionStructure = _connectionStructures
            .Where(x => x.Connection == connection)
            .Single();

        using (var command = connection.CreateCommand())
        {
            await connection.OpenAsync();

            command.CommandText = $"CREATE DATABASE {databaseName};";
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        connectionStructure.DatabaseNames.Add(databaseName);

        return databaseName;
    }

    public void Dispose()
    {
        foreach (var connectionStructure in _connectionStructures)
        {
            var connection = connectionStructure.Connection;

            foreach (var databaseName in connectionStructure.DatabaseNames)
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    connection.ChangeDatabase(_escapeDatabase);

                    command.CommandText =
                        $"SELECT " +
                            $"pg_terminate_backend(pg_stat_activity.pid) " +
                        $"FROM pg_stat_activity " +
                        $"WHERE " +
                            $"pg_stat_activity.datname = '{databaseName}' " +
                            $"AND pid<> pg_backend_pid();";
                    command.ExecuteNonQuery();

                    command.CommandText = $"DROP DATABASE IF EXISTS {databaseName};";
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }

    public class ConnectionStructure
    {
        public NpgsqlConnection Connection { get; set; }
        public List<string> DatabaseNames { get; set; } = new();
    }
}
