using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.MySql;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.MySqlPresenterTests;

public class GetDatabaseNamesTests : IDisposable
{
    private readonly MySqlHelper _mySqlHelper = new();

    [Fact]
    public async Task ForSpecificDatabases_GetCorrectDatabaseNames()
    {
        var presenter = _mySqlHelper.CreatePresenter(ConnectionParameters.MySql.ConnectionParameters);
        var connection = _mySqlHelper.CreateConnection(ConnectionParameters.MySql.ConnectionString);

        var firstDatabaseName = await _mySqlHelper.CreateDatabase(connection);
        var secondDatabaseName = await _mySqlHelper.CreateDatabase(connection);

        var result = await Act(presenter);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload;
        Assert.NotNull(payload);
        Assert.Contains(firstDatabaseName, payload.Names);
        Assert.Contains(secondDatabaseName, payload.Names);
    }

    public static Task<Response<DatabaseNamesResponseDto>> Act(MySqlPresenter presenter) 
        => presenter.GetDatabaseNames();

    public void Dispose() => _mySqlHelper.Dispose();
}
