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
    public class SendQueryTests
    {
        private readonly MySqlPresenter _presenter;

        public SendQueryTests()
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
        public async Task ForSpecificQuery_GetDataTable_WithCorrectRows_AndSelectedColumns()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";
            const string firstColumn = "id";
            const string secondColumn = "name";

            const string query = "SELECT * FROM employees";

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


            var result = await Act(databaseName, query);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as QueryResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(QueryType.Query, payload.Type);

            var dataTable = payload.Table;
            Assert.NotNull(dataTable);
            Assert.NotNull(dataTable.Columns[firstColumn]);
            Assert.NotNull(dataTable.Columns[secondColumn]);
            Assert.Equal(1, dataTable.Rows.Count);

            await RemoveDatabase(connection, databaseName);
        }

        [Fact]
        public async Task ForSpecificNonQuery_GetDataTable_WithRowAffectedColumn_AndCorrectNumberOfAffectedRows()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";

            string query = $"INSERT INTO {tableName} VALUES (2, 'test')";

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


            var result = await Act(databaseName, query);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as QueryResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(QueryType.NonQuery, payload.Type);

            var dataTable = payload.Table;
            Assert.NotNull(dataTable);
            Assert.NotNull(dataTable.Columns["AFFECTED ROWS"]);
            Assert.Single(dataTable.Rows);
            Assert.Equal("1", dataTable.Rows[0].ItemArray[0]);

            await RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act(string databaseName, string query)
        {
            var result = await _presenter.SendQuery(databaseName, query);

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
