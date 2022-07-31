using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.MySql;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.MySqlPresenterTests;

public class GetTableDetailsTests : IDisposable
{
    private readonly MySqlHelper _mySqlHelper = new();

    [Fact]
    public async Task ForSpecificTable_GetTableDetails()
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

        var result = await Act(presenter, databaseName, tableName);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload as TableDetailsResponseDto;
        Assert.NotNull(payload);

        Assert.NotNull(payload.Table);
        Assert.Equal(1, payload.RowsCount);
        Assert.Equal(2, payload.ColumnsCount);
        Assert.Equal(2, payload.ColumnsStructure.Count);
    }

    public static Task<Response> Act(MySqlPresenter presenter, string databaseName, string tableName) 
        => presenter.GetTableDetails(databaseName, tableName);

    public void Dispose() => _mySqlHelper.Dispose();
}
