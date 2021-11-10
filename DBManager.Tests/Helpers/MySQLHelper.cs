using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBManager.Tests.Helpers
{
    public class MySqlHelper : IDisposable
    {
        private readonly List<ConnectionStructure> _connectionStructures;

        public MySqlHelper()
        {
            _connectionStructures = new List<ConnectionStructure>();
        }

        public MySqlPresenter CreatePresenter(Dictionary<string, string> connectionParameters)
        {
            var connection = new Connection
            {
                Name = NamesGenerator.Generate(),
                Type = EngineType.MySql,
                ConnectionParameters = connectionParameters,
                TrackedQueries = new List<TrackedQuery>()
            };

            var model = new MySqlModel(connection);
            var presenter = new MySqlPresenter(model, null);

            return presenter;
        }

        public MySqlConnection CreateConnection(string connectionString)
        {
            var connection = new MySqlConnection(connectionString);

            var connectionStructure = new ConnectionStructure { Connection = connection };

            _connectionStructures.Add(connectionStructure);

            return connection;
        }

        public async Task<string> CreateDatabase(MySqlConnection connection)
        {
            var databaseName = NamesGenerator.Generate();

            var connectionStructure = _connectionStructures
                .Where(x => x.Connection == connection)
                .Single();

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                command.CommandText = $"CREATE DATABASE IF NOT EXISTS `{databaseName}`;";
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

                        command.CommandText = $"DROP DATABASE IF EXISTS `{databaseName}`;";
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }

        public class ConnectionStructure
        {
            public MySqlConnection Connection { get; set; }
            public List<string> DatabaseNames { get; set; }

            public ConnectionStructure()
            {
                DatabaseNames = new List<string>();
            }
        }
    }
}
