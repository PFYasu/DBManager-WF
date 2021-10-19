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
    public class GetTableDetailsTests
    {
        private readonly PostgreSQLPresenter _presenter;

        public GetTableDetailsTests()
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
        public async Task ForSpecificTable_GetTableDetails()
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


            var result = await Act(databaseName, tableName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as TableDetailsResponseDto;
            Assert.NotNull(payload);

            Assert.NotNull(payload.Table);
            Assert.Equal(1, payload.RowsCount);
            Assert.Equal(2, payload.ColumnsCount);
            Assert.Equal(2, payload.ColumnsStructure.Count);

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act(string databaseName, string tableName)
        {
            var result = await _presenter.GetTableDetails(databaseName, tableName);

            return result;
        }
    }
}
