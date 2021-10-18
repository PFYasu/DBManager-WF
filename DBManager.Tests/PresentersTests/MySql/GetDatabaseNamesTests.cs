using DBManager.Dto.Engines;
using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using DBManager.Utils;
using MySqlConnector;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.MySql
{
    public class GetDatabaseNamesTests
    {
        private readonly MySqlPresenter _presenter;

        public GetDatabaseNamesTests()
        {
            var connection = new Connection
            {
                Name = "dbmanager_mysql_test",
                Type = EngineType.MySql,
                ConnectionParameters = ConnectionParameters.MySql.ConnectionParameters,
                TrackedQueries = new List<TrackedQuery>()
            };

            var model = new MySqlModel(connection);
            _presenter = new MySqlPresenter(model, null);
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

            var connection = new MySqlConnection(ConnectionParameters.MySql.ConnectionString);

            await RemoveDatabases(connection, databasesToDelete);

            using (var cmd = connection.CreateCommand())
            {
                await connection.OpenAsync();

                cmd.CommandText = $"CREATE DATABASE IF NOT EXISTS `{firstDatabaseName}`;";
                await cmd.ExecuteNonQueryAsync();

                cmd.CommandText = $"CREATE DATABASE IF NOT EXISTS `{secondDatabaseName}`;";
                await cmd.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act();


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as DatabaseNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Contains(firstDatabaseName, payload.Names);
            Assert.Contains(secondDatabaseName, payload.Names);

            await RemoveDatabases(connection, databasesToDelete);
        }


        public async Task<Response> Act()
        {
            var result = await _presenter.GetDatabaseNames();

            return result;
        }


        private async Task RemoveDatabases(MySqlConnection connection, List<string> databaseNames)
        {
            using (var cmd = connection.CreateCommand())
            {
                await connection.OpenAsync();

                foreach (var databaseName in databaseNames)
                {
                    cmd.CommandText = $"DROP DATABASE IF EXISTS `{databaseName}`;";
                    await cmd.ExecuteNonQueryAsync();
                }

                await connection.CloseAsync();
            }
        }
    }
}
