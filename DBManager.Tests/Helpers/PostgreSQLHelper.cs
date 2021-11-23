using DBManager.Core.Models;
using DBManager.EngineModule.PostgreSQL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBManager.Tests.Helpers
{
    public class PostgreSQLHelper : IDisposable
    {
        private readonly List<ConnectionStructure> _connectionStructures;
        private readonly string _escapeDatabaseName;

        public PostgreSQLHelper(string escapeDatabaseName)
        {
            _connectionStructures = new List<ConnectionStructure>();
            _escapeDatabaseName = escapeDatabaseName;
        }

        public PostgreSQLPresenter CreatePresenter(Dictionary<string, string> connectionParameters)
        {
            var connection = new Connection
            {
                Name = NamesGenerator.Generate(),
                EngineType = "PostgreSQL",
                ConnectionParameters = connectionParameters,
                TrackedQueries = new List<TrackedQuery>()
            };

            var model = new PostgreSQLModel(connection);
            var presenter = new PostgreSQLPresenter(model, null);

            return presenter;
        }

        public NpgsqlConnection CreateConnection(string connectionString)
        {
            var connection = new NpgsqlConnection(connectionString);

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
                        connection.ChangeDatabase(_escapeDatabaseName);

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
            public List<string> DatabaseNames { get; set; }

            public ConnectionStructure()
            {
                DatabaseNames = new List<string>();
            }
        }
    }
}
