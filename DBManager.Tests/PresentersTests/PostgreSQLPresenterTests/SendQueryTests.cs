using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Utils;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQLPresenterTests
{
    public class SendQueryTests : IDisposable
    {
        private readonly PostgreSQLHelper _postgreSQLHelper;

        public SendQueryTests()
        {
            _postgreSQLHelper = new PostgreSQLHelper(ConnectionParameters.PostgreSQL.EscapeDatabase);
        }

        [Fact]
        public async Task ForSpecificQuery_GetDataTable_WithCorrectRows_AndSelectedColumns()
        {
            var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
            var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
            const string tableName = "employees";
            const string firstColumn = "id";
            const string secondColumn = "name";
            const string query = "SELECT * FROM employees";

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

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


            var result = await Act(presenter, databaseName, query);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as QueryResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(QueryType.Query, payload.Type);

            var dataTable = payload.Table;
            Assert.NotNull(dataTable);
            Assert.NotNull(dataTable.Columns[firstColumn]);
            Assert.NotNull(dataTable.Columns[secondColumn]);
            Assert.Equal(1, dataTable.Rows.Count);
        }

        [Fact]
        public async Task ForSpecificNonQuery_GetDataTable_WithRowAffectedColumn_AndCorrectNumberOfAffectedRows()
        {
            var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
            var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
            const string tableName = "employees";
            string query = $"INSERT INTO {tableName} VALUES (2, 'test')";

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                command.CommandText =
                    $"CREATE TABLE {tableName} (" +
                        $"id INT," +
                        $"name VARCHAR(20));";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act(presenter, databaseName, query);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as QueryResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(QueryType.NonQuery, payload.Type);

            var dataTable = payload.Table;
            Assert.NotNull(dataTable);
            Assert.NotNull(dataTable.Columns["AFFECTED ROWS"]);
            Assert.Single(dataTable.Rows);
            Assert.Equal("1", dataTable.Rows[0].ItemArray[0]);
        }


        public async Task<Response> Act(PostgreSQLPresenter presenter, string databaseName, string query)
        {
            var result = await presenter.SendQuery(databaseName, query);

            return result;
        }


        public void Dispose()
        {
            _postgreSQLHelper.Dispose();
        }
    }
}
