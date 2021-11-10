using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.MySql
{
    public class GetTableNamesTests : IDisposable
    {
        private readonly MySqlHelper _mySqlHelper;

        public GetTableNamesTests()
        {
            _mySqlHelper = new MySqlHelper();
        }

        [Fact]
        public async Task ForSpecificDatabase_GetCorrectTableNames()
        {
            var presenter = _mySqlHelper.CreatePresenter(ConnectionParameters.MySql.ConnectionParameters);
            var connection = _mySqlHelper.CreateConnection(ConnectionParameters.MySql.ConnectionString);

            var databaseName = await _mySqlHelper.CreateDatabase(connection);
            const string firstTableName = "employees";
            const string secondTableName = "orders";

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                await connection.ChangeDatabaseAsync(databaseName);

                command.CommandText = $"CREATE TABLE IF NOT EXISTS `{firstTableName}` (id INT);";
                await command.ExecuteNonQueryAsync();

                command.CommandText = $"CREATE TABLE IF NOT EXISTS `{secondTableName}` (id INT);";
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


        public async Task<Response> Act(MySqlPresenter presenter, string databaseName)
        {
            var result = await presenter.GetTableNames(databaseName);

            return result;
        }


        public void Dispose()
        {
            _mySqlHelper.Dispose();
        }
    }
}
