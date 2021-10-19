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
    public class SendQueryTests
    {
        private readonly PostgreSQLPresenter _presenter;

        public SendQueryTests()
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
        public async Task ForSpecificQuery_GetDataTable_WithCorrectRows_AndSelectedColumns()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";
            const string firstColumn = "id";
            const string secondColumn = "name";

            const string query = "SELECT * FROM employees";

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
                        $"{firstColumn} INT," +
                        $"{secondColumn} VARCHAR(20));";
                await command.ExecuteNonQueryAsync();

                command.CommandText = $"INSERT INTO {tableName} VALUES (1, 'test');";
                await command.ExecuteNonQueryAsync();

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

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);
        }

        [Fact]
        public async Task ForSpecificNonQuery_GetDataTable_WithRowAffectedColumn_AndCorrectNumberOfAffectedRows()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";

            string query = $"INSERT INTO {tableName} VALUES (2, 'test')";

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

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act(string databaseName, string query)
        {
            var result = await _presenter.SendQuery(databaseName, query);

            return result;
        }
    }
}
