using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using DBManager.Utils;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.MySqlPresenterTests
{
    public class GetConnectionDetailsTests : IDisposable
    {
        private readonly MySqlHelper _mySqlHelperTest;

        public GetConnectionDetailsTests()
        {
            _mySqlHelperTest = new MySqlHelper();
        }

        [Fact]
        public async Task ForSpecificConnection_GetConnectionDetails()
        {
            var presenter = _mySqlHelperTest.CreatePresenter(ConnectionParameters.MySql.ConnectionParameters);
            var connection = _mySqlHelperTest.CreateConnection(ConnectionParameters.MySql.ConnectionString);

            var databaseName = await _mySqlHelperTest.CreateDatabase(connection);

            const string tableName = "employees";

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                command.CommandText =
                    $"CREATE TABLE IF NOT EXISTS `{tableName}` (" +
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
            Assert.Equal(EngineType.MySql, payload.Type);
            Assert.Equal(ConnectionParameters.MySql.ConnectionParameters["Uid"], payload.Uid);
            Assert.Equal(ConnectionParameters.MySql.ConnectionParameters["Server"], payload.Server);
            Assert.Equal(ConnectionParameters.MySql.ConnectionParameters["Port"], payload.Port.ToString());
        }


        public async Task<Response> Act(MySqlPresenter presenter)
        {
            var result = await presenter.GetConnectionDetails();

            return result;
        }


        public void Dispose()
        {
            _mySqlHelperTest.Dispose();
        }
    }
}
