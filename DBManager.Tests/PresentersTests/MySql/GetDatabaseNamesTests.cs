using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.MySql
{
    public class GetDatabaseNamesTests : IDisposable
    {
        private readonly MySqlHelper _mySqlHelper;

        public GetDatabaseNamesTests()
        {
            _mySqlHelper = new MySqlHelper();
        }

        [Fact]
        public async Task ForSpecificDatabases_GetCorrectDatabaseNames()
        {
            var presenter = _mySqlHelper.CreatePresenter(ConnectionParameters.MySql.ConnectionParameters);
            var connection = _mySqlHelper.CreateConnection(ConnectionParameters.MySql.ConnectionString);

            var firstDatabaseName = await _mySqlHelper.CreateDatabase(connection);
            var secondDatabaseName = await _mySqlHelper.CreateDatabase(connection);


            var result = await Act(presenter);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as DatabaseNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Contains(firstDatabaseName, payload.Names);
            Assert.Contains(secondDatabaseName, payload.Names);
        }


        public async Task<Response> Act(MySqlPresenter presenter)
        {
            var result = await presenter.GetDatabaseNames();

            return result;
        }


        public void Dispose()
        {
            _mySqlHelper.Dispose();
        }
    }
}
