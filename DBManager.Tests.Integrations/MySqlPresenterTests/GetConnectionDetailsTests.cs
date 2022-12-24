using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.MySql;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.MySqlPresenterTests;

public class GetConnectionDetailsTests : IDisposable
{
    private readonly MySqlHelper _mySqlHelper = new();

    [IntegrationTestFact]
    public async Task ForSpecificConnection_GetConnectionDetails()
    {
        var presenter = _mySqlHelper.CreatePresenter();
        var connection = _mySqlHelper.CreateConnection();

        var databaseName = await _mySqlHelper.CreateDatabase(connection);

        const string tableName = "employees";
        const string engineType = "MySql";

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

        var payload = result.Payload;
        Assert.NotNull(payload);

        Assert.Equal(presenter.ConnectionName, payload.Name);
        Assert.Equal(engineType, payload.EngineType);
        Assert.Equal(_mySqlHelper.ConnectionParameters["Uid"], payload.Uid);
        Assert.Equal(_mySqlHelper.ConnectionParameters["Server"], payload.Server);
        Assert.Equal(_mySqlHelper.ConnectionParameters["Port"], payload.Port.ToString());
    }

    public static Task<Response<ConnectionDetailsResponseDto>> Act(MySqlPresenter presenter) 
        => presenter.GetConnectionDetails();

    public void Dispose() =>_mySqlHelper.Dispose();
}
