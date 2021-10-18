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
    public class GetTableNamesTests
    {
        private readonly MySqlPresenter _presenter;

        public GetTableNamesTests()
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
        public async Task ForSpecificDatabase_GetCorrectTableNames()
        {
            var databaseName = NamesGenerator.Generate();

            const string firstTableName = "employees";
            const string secondTableName = "orders";

            var connection = new MySqlConnection(ConnectionParameters.MySql.ConnectionString);

            await RemoveDatabase(connection, databaseName);

            using (var cmd = connection.CreateCommand())
            {
                await connection.OpenAsync();

                cmd.CommandText = $"CREATE DATABASE IF NOT EXISTS `{databaseName}`;";
                await cmd.ExecuteNonQueryAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS `{firstTableName}` (id INT);";
                await cmd.ExecuteNonQueryAsync();

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS `{secondTableName}` (id INT);";
                await cmd.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act(databaseName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as TableNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(2, payload.Names.Count);
            Assert.Contains(firstTableName, payload.Names);
            Assert.Contains(secondTableName, payload.Names);

            await RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act(string databaseName)
        {
            var result = await _presenter.GetTableNames(databaseName);

            return result;
        }


        private async Task RemoveDatabase(MySqlConnection connection, string databaseName)
        {
            using (var cmd = connection.CreateCommand())
            {
                await connection.OpenAsync();

                cmd.CommandText = $"DROP DATABASE IF EXISTS `{databaseName}`;";
                await cmd.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }
        }
    }
}
