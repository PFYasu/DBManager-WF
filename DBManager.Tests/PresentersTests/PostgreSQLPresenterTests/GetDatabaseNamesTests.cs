using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQLPresenterTests
{
    public class GetDatabaseNamesTests : IDisposable
    {
        private readonly PostgreSQLHelper _postgreSQLHelper;

        public GetDatabaseNamesTests()
        {
            _postgreSQLHelper = new PostgreSQLHelper(ConnectionParameters.PostgreSQL.EscapeDatabase);
        }

        [Fact]
        public async Task ForSpecificDatabases_GetCorrectDatabaseNames()
        {
            var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
            var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            var firstDatabaseName = await _postgreSQLHelper.CreateDatabase(connection);
            var secondDatabaseName = await _postgreSQLHelper.CreateDatabase(connection);


            var result = await Act(presenter);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as DatabaseNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Contains(firstDatabaseName, payload.Names);
            Assert.Contains(secondDatabaseName, payload.Names);
        }


        public async Task<Response> Act(PostgreSQLPresenter presenter)
        {
            var result = await presenter.GetDatabaseNames();

            return result;
        }


        public void Dispose()
        {
            _postgreSQLHelper.Dispose();
        }
    }
}
