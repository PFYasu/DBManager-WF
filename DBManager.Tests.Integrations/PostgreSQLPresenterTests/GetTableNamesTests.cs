using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.PostgreSQLPresenterTests;

public class GetTableNamesTests : IDisposable
{
    private readonly PostgreSQLHelper _postgreSQLHelper = new(ConnectionParameters.PostgreSQL.EscapeDatabase);

    [Fact]
    public async Task ForSpecificDatabase_GetCorrectTableNames()
    {
        var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
        var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

        var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
        const string firstTableName = "employees";
        const string secondTableName = "orders";

        using (var command = connection.CreateCommand())
        {
            await connection.OpenAsync();

            await connection.ChangeDatabaseAsync(databaseName);

            command.CommandText = $"CREATE TABLE {firstTableName} (id INT);";
            await command.ExecuteNonQueryAsync();

            command.CommandText = $"CREATE TABLE {secondTableName} (id INT);";
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        var result = await Act(presenter, databaseName);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload;
        Assert.NotNull(payload);
        Assert.Equal(2, payload.Names.Count);
        Assert.Contains(firstTableName, payload.Names);
        Assert.Contains(secondTableName, payload.Names);
    }

    public static Task<Response<TableNamesResponseDto>> Act(PostgreSQLPresenter presenter, string databaseName) 
        => presenter.GetTableNames(databaseName);

    public void Dispose() => _postgreSQLHelper.Dispose();
}
