using DBManager.Dto.Engines;
using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using DBManager.Utils;
using Npgsql;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQL
{
    public class GetConnectionDetailsTests
    {
        private readonly PostgreSQLPresenter _presenter;

        public GetConnectionDetailsTests()
        {
            var connection = new Connection
            {
                Name = "dbmanager_postgresql_test",
                Type = EngineType.PostgreSQL,
                ConnectionParameters = ConnectionParameters.PostgreSQL.ConnectionParameters,
                TrackedQueries = new List<TrackedQuery>()
            };

            var model = new PostgreSQLModel(connection);
            _presenter = new PostgreSQLPresenter(model, null);
        }

        [Fact]
        public async Task ForSpecificConnection_GetConnectionDetails()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";

            var connection = new NpgsqlConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                command.CommandText = $"CREATE DATABASE {databaseName};";
                await command.ExecuteNonQueryAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                command.CommandText =
                    $"CREATE TABLE {tableName} (" +
                        $"id INT," +
                        $"name VARCHAR(20));";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act();


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as ConnectionDetailsResponseDto;
            Assert.NotNull(payload);

            Assert.Equal("dbmanager_postgresql_test", payload.Name);
            Assert.Equal(EngineType.PostgreSQL, payload.Type);
            Assert.Equal(ConnectionParameters.PostgreSQL.ConnectionParameters["Uid"], payload.Uid);
            Assert.Equal(ConnectionParameters.PostgreSQL.ConnectionParameters["Server"], payload.Server);
            Assert.Equal(ConnectionParameters.PostgreSQL.ConnectionParameters["Port"], payload.Port.ToString());

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act()
        {
            var result = await _presenter.GetConnectionDetails();

            return result;
        }
    }
}
