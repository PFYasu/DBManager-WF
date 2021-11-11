using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQLPresenterTests
{
    public class GetTableNamesTests : IDisposable
    {
        private readonly PostgreSQLHelper _postgreSQLHelper;

        public GetTableNamesTests()
        {
            _postgreSQLHelper = new PostgreSQLHelper(ConnectionParameters.PostgreSQL.EscapeDatabase);
        }

        [Fact]
        public async Task ForSpecificDatabase_GetCorrectTableNames()
        {
            var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
            var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
            const string firstTableName = "employees";
            const string secondTableName = "orders";

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                command.CommandText = $"CREATE TABLE {firstTableName} (id INT);";
                await command.ExecuteNonQueryAsync();

                command.CommandText = $"CREATE TABLE {secondTableName} (id INT);";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }


            var result = await Act(presenter, databaseName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as TableNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(2, payload.Names.Count);
            Assert.Contains(firstTableName, payload.Names);
            Assert.Contains(secondTableName, payload.Names);
        }


        public async Task<Response> Act(PostgreSQLPresenter presenter, string databaseName)
        {
            var result = await presenter.GetTableNames(databaseName);

            return result;
        }


        public void Dispose()
        {
            _postgreSQLHelper.Dispose();
        }
    }
}
