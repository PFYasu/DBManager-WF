using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.MySql;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.MySqlPresenterTests;

public class GetDatabaseDetailsTests : IDisposable
{
    private readonly MySqlHelper _mySqlHelper = new();

    [Fact]
    public async Task ForSpecificDatabase_GetDatabaseDetails()
    {
        var presenter = _mySqlHelper.CreatePresenter(ConnectionParameters.MySql.ConnectionParameters);
        var connection = _mySqlHelper.CreateConnection(ConnectionParameters.MySql.ConnectionString);

        var databaseName = await _mySqlHelper.CreateDatabase(connection);

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

            command.CommandText = $"INSERT INTO `{tableName}` VALUES (1, 'test');";
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        var result = await Act(presenter, databaseName);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload as DatabaseDetailsResponseDto;
        Assert.NotNull(payload);

        Assert.Equal(1, payload.TablesCount);
        Assert.Single(payload.TablesStructure);

        var tableStructure = payload.TablesStructure[0];
        Assert.Equal(tableName, tableStructure.Name);
        Assert.Equal((ulong)1, tableStructure.Records);
    }

    public static Task<Response> Act(MySqlPresenter presenter, string databaseName) 
        => presenter.GetDatabaseDetails(databaseName);

    public void Dispose() => _mySqlHelper.Dispose();
}
