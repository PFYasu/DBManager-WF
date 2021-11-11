using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQLPresenterTests
{
    public class GetTableDetailsTests : IDisposable
    {
        private readonly PostgreSQLHelper _postgreSQLHelper;

        public GetTableDetailsTests()
        {
            _postgreSQLHelper = new PostgreSQLHelper(ConnectionParameters.PostgreSQL.EscapeDatabase);
        }

        [Fact]
        public async Task ForSpecificTable_GetTableDetails()
        {
            var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
            var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
            const string tableName = "employees";

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

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


            var result = await Act(presenter, databaseName, tableName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as TableDetailsResponseDto;
            Assert.NotNull(payload);

            Assert.NotNull(payload.Table);
            Assert.Equal(1, payload.RowsCount);
            Assert.Equal(2, payload.ColumnsCount);
            Assert.Equal(2, payload.ColumnsStructure.Count);
        }


        public async Task<Response> Act(PostgreSQLPresenter presenter, string databaseName, string tableName)
        {
            var result = await presenter.GetTableDetails(databaseName, tableName);

            return result;
        }


        public void Dispose()
        {
            _postgreSQLHelper.Dispose();
        }
    }
}
