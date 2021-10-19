using DBManager.Dto.Engines;
using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using DBManager.Utils;
using Npgsql;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQL
{
    public class GetDatabaseDetailsTests
    {
        private readonly PostgreSQLPresenter _presenter;

        public GetDatabaseDetailsTests()
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
        public async Task ForSpecificDatabase_GetDatabaseDetails()
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

                command.CommandText = $"INSERT INTO {tableName} VALUES (1, 'test');";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }

            WaitForApplyChangesToDatabase();


            var result = await Act(databaseName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as DatabaseDetailsResponseDto;
            Assert.NotNull(payload);

            Assert.Equal(1, payload.TablesCount);
            Assert.Single(payload.TablesStructure);

            var tableStructure = payload.TablesStructure[0];
            Assert.Equal(tableName, tableStructure.Name);
            Assert.Equal((ulong)1, tableStructure.Records);

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);
        }


        private void WaitForApplyChangesToDatabase(uint time = 500)
        {
            Thread.Sleep(500);
        }


        public async Task<Response> Act(string databaseName)
        {
            var result = await _presenter.GetDatabaseDetails(databaseName);

            return result;
        }
    }
}
