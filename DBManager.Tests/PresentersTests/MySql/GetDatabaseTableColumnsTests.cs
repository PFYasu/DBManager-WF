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
    public class GetDatabaseTableColumnsTests
    {
        private readonly MySqlPresenter _presenter;

        public GetDatabaseTableColumnsTests()
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
        public async Task ForSpecificDatabase_GetTableColumns_FromAllTables()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";
            const string firstColumn = "id";
            const string secondColumn = "name";

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
                        $"{firstColumn} INT," +
                        $"{secondColumn} VARCHAR(20));";
                await cmd.ExecuteNonQueryAsync();

                cmd.CommandText = $"INSERT INTO `{tableName}` VALUES (1, 'test');";
                await cmd.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act(databaseName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as DatabaseTableColumnsResponseDto;
            Assert.NotNull(payload);

            Assert.Single(payload.DatabaseTableColumns);

            var databaseTablesColumns = payload.DatabaseTableColumns;
            Assert.NotNull(databaseTablesColumns[tableName]);
            Assert.Contains(firstColumn, databaseTablesColumns[tableName]);
            Assert.Contains(secondColumn, databaseTablesColumns[tableName]);

            await RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act(string databaseName)
        {
            var result = await _presenter.GetDatabaseTableColumns(databaseName);

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
