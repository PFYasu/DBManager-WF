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
    public class GetConnectionDetailsTests
    {
        private readonly MySqlPresenter _presenter;

        public GetConnectionDetailsTests()
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
        public async Task ForSpecificConnection_GetConnectionDetails()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";

            var connection = new MySqlConnection(ConnectionParameters.MySql.ConnectionString);

            await RemoveDatabase(connection, databaseName);

            using (var cmd = connection.CreateCommand())
            {
                await connection.OpenAsync();

                cmd.CommandText = $"CREATE DATABASE IF NOT EXISTS `{databaseName}`;";
                await cmd.ExecuteNonQueryAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                cmd.CommandText =
                    $"CREATE TABLE IF NOT EXISTS `{tableName}` (" +
                        $"id INT," +
                        $"name VARCHAR(20));";
                await cmd.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act();


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as ConnectionDetailsResponseDto;
            Assert.NotNull(payload);

            Assert.Equal("dbmanager_mysql_test", payload.Name);
            Assert.Equal(EngineType.MySql, payload.Type);
            Assert.Equal(ConnectionParameters.MySql.ConnectionParameters["Uid"], payload.Uid);
            Assert.Equal(ConnectionParameters.MySql.ConnectionParameters["Server"], payload.Server);
            Assert.Equal(ConnectionParameters.MySql.ConnectionParameters["Port"], payload.Port.ToString());

            await RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act()
        {
            var result = await _presenter.GetConnectionDetails();

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
