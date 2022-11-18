using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.PostgreSQLPresenterTests;

public class GetDatabaseNamesTests : IDisposable
{
    private readonly PostgreSQLHelper _postgreSQLHelper = new(ConnectionParameters.PostgreSQL.EscapeDatabase);

    [Fact]
    public async Task ForSpecificDatabases_GetCorrectDatabaseNames()
    {
        var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
        var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

        var firstDatabaseName = await _postgreSQLHelper.CreateDatabase(connection);
        var secondDatabaseName = await _postgreSQLHelper.CreateDatabase(connection);

        var result = await Act(presenter);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload;
        Assert.NotNull(payload);
        Assert.Contains(firstDatabaseName, payload.Names);
        Assert.Contains(secondDatabaseName, payload.Names);
    }

    public static Task<Response<DatabaseNamesResponseDto>> Act(PostgreSQLPresenter presenter) 
        => presenter.GetDatabaseNames();

    public void Dispose() => _postgreSQLHelper.Dispose();
}
