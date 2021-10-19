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
    public class GetDatabaseNamesTests
    {
        private readonly PostgreSQLPresenter _presenter;

        public GetDatabaseNamesTests()
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
        public async Task ForSpecificDatabases_GetCorrectDatabaseNames()
        {
            var firstDatabaseName = NamesGenerator.Generate();
            var secondDatabaseName = NamesGenerator.Generate();

            var databasesToDelete = new List<string>
            {
                firstDatabaseName,
                secondDatabaseName
            };

            var connection = new NpgsqlConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            await PostgreSQLHelper.RemoveDatabase(connection, firstDatabaseName);
            await PostgreSQLHelper.RemoveDatabase(connection, secondDatabaseName);

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                command.CommandText = $"CREATE DATABASE {firstDatabaseName};";
                await command.ExecuteNonQueryAsync();

                command.CommandText = $"CREATE DATABASE {secondDatabaseName};";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act();


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as DatabaseNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Contains(firstDatabaseName, payload.Names);
            Assert.Contains(secondDatabaseName, payload.Names);

            await PostgreSQLHelper.RemoveDatabase(connection, firstDatabaseName);
            await PostgreSQLHelper.RemoveDatabase(connection, secondDatabaseName);
        }


        public async Task<Response> Act()
        {
            var result = await _presenter.GetDatabaseNames();

            return result;
        }
    }
}
