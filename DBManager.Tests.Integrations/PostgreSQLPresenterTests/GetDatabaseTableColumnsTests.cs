using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.PostgreSQLPresenterTests;

public class GetDatabaseTableColumnsTests : IDisposable
{
    private readonly PostgreSQLHelper _postgreSQLHelper = new(ConnectionParameters.PostgreSQL.EscapeDatabase);

    [Fact]
    public async Task ForSpecificDatabase_GetTableColumns_FromAllTables()
    {
        var presenter = _postgreSQLHelper.CreatePresenter(ConnectionParameters.PostgreSQL.ConnectionParameters);
        var connection = _postgreSQLHelper.CreateConnection(ConnectionParameters.PostgreSQL.ConnectionString);

        var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
        const string tableName = "employees";
        const string firstColumn = "id";
        const string secondColumn = "name";

        using (var command = connection.CreateCommand())
        {
            await connection.OpenAsync();

            await connection.ChangeDatabaseAsync(databaseName);

            command.CommandText =
                $"CREATE TABLE {tableName} (" +
                    $"{firstColumn} INT," +
                    $"{secondColumn} VARCHAR(20));";
            await command.ExecuteNonQueryAsync();

            command.CommandText = $"INSERT INTO {tableName} VALUES (1, 'test');";
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        var result = await Act(presenter, databaseName);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload as DatabaseTableColumnsResponseDto;
        Assert.NotNull(payload);

        Assert.Single(payload.DatabaseTableColumns);

        var databaseTablesColumns = payload.DatabaseTableColumns;
        Assert.NotNull(databaseTablesColumns[tableName]);
        Assert.Contains(firstColumn, databaseTablesColumns[tableName]);
        Assert.Contains(secondColumn, databaseTablesColumns[tableName]);
    }

    public static Task<Response> Act(PostgreSQLPresenter presenter, string databaseName) 
        => presenter.GetDatabaseTableColumns(databaseName);

    public void Dispose() => _postgreSQLHelper.Dispose();
}
