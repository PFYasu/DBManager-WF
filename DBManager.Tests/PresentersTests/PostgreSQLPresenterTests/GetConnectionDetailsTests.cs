using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQLPresenterTests
{
    public class GetConnectionDetailsTests : IDisposable
    {
        private readonly PostgreSQLHelper _postgreSQLHelper;

        public GetConnectionDetailsTests()
        {
            _postgreSQLHelper = new PostgreSQLHelper(ConnectionParameters.PostgreSQL.EscapeDatabase);
        }

        [Fact]
        public async Task ForSpecificConnection_GetConnectionDetails()
        {
            var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
            var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            var databaseName = await _postgreSQLHelper.CreateDatabase(connection);

            const string tableName = "employees";
            const string engineType = "PostgreSQL";

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


            var result = await Act(presenter);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as ConnectionDetailsResponseDto;
            Assert.NotNull(payload);

            Assert.Equal(presenter.ConnectionName, payload.Name);
            Assert.Equal(engineType, payload.EngineType);
            Assert.Equal(ConnectionParameters.PostgreSQL.ConnectionParameters["Uid"], payload.Uid);
            Assert.Equal(ConnectionParameters.PostgreSQL.ConnectionParameters["Server"], payload.Server);
            Assert.Equal(ConnectionParameters.PostgreSQL.ConnectionParameters["Port"], payload.Port.ToString());
        }


        public async Task<Response> Act(PostgreSQLPresenter presenter)
        {
            var result = await presenter.GetConnectionDetails();

            return result;
        }


        public void Dispose()
        {
            _postgreSQLHelper.Dispose();
        }
    }
}
