using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.PostgreSQLPresenterTests;

public class GetDatabaseDetailsTests : IDisposable
{
    private readonly PostgreSQLHelper _postgreSQLHelper = new(ConnectionParameters.PostgreSQL.EscapeDatabase);

    [Fact]
    public async Task ForSpecificDatabase_GetDatabaseDetails()
    {
        var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
        var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

        var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
        const string tableName = "employees";

        using (var command = connection.CreateCommand())
        {
            await connection.OpenAsync();

            await connection.ChangeDatabaseAsync(databaseName);

            command.CommandText =
                $"CREATE TABLE {tableName} (" +
                    $"id INT," +
                    $"name VARCHAR(20));";
            await command.ExecuteNonQueryAsync();

            command.CommandText = $"INSERT INTO {tableName} VALUES (1, 'test');";
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

    private static void WaitForApplyChangesToDatabase(int time = 500) => Thread.Sleep(time);

    public static Task<Response> Act(PostgreSQLPresenter presenter, string databaseName)
    {
        WaitForApplyChangesToDatabase();
        return presenter.GetDatabaseDetails(databaseName);
    }

    public void Dispose() => _postgreSQLHelper.Dispose();
}
