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
    public class GetTableNamesTests
    {
        private readonly PostgreSQLPresenter _presenter;

        public GetTableNamesTests()
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
        public async Task ForSpecificDatabase_GetCorrectTableNames()
        {
            var databaseName = NamesGenerator.Generate();

            const string firstTableName = "employees";
            const string secondTableName = "orders";

            var connection = new NpgsqlConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                command.CommandText = $"CREATE DATABASE {databaseName};";
                await command.ExecuteNonQueryAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                command.CommandText = $"CREATE TABLE {firstTableName} (id INT);";
                await command.ExecuteNonQueryAsync();

                command.CommandText = $"CREATE TABLE {secondTableName} (id INT);";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act(databaseName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as TableNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(2, payload.Names.Count);
            Assert.Contains(firstTableName, payload.Names);
            Assert.Contains(secondTableName, payload.Names);

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act(string databaseName)
        {
            var result = await _presenter.GetTableNames(databaseName);

            return result;
        }
    }
}
