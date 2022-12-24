using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Utils;
using DBManager.EngineModule.PostgreSQL;
using DBManager.Tests.Integrations.Helpers;
using Xunit;

namespace DBManager.Tests.Integrations.PostgreSQLPresenterTests;

public class SendQueryTests : IDisposable
{
    private readonly PostgreSQLHelper _postgreSQLHelper = new();

    [IntegrationTestFact]
    public async Task ForSpecificQuery_GetDataTable_WithCorrectRows_AndSelectedColumns()
    {
        var presenter = _postgreSQLHelper.CreatePresenter();
        var connection = _postgreSQLHelper.CreateConnection();

        var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
        const string tableName = "employees";
        const string firstColumn = "id";
        const string secondColumn = "name";
        const string query = "SELECT * FROM employees";

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

        var result = await Act(presenter, databaseName, query);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload;
        Assert.NotNull(payload);
        Assert.Equal(QueryType.Query, payload.Type);

        var dataTable = payload.Table;
        Assert.NotNull(dataTable);
        Assert.NotNull(dataTable.Columns[firstColumn]);
        Assert.NotNull(dataTable.Columns[secondColumn]);
        Assert.Equal(1, dataTable.Rows.Count);
    }

    [IntegrationTestFact]
    public async Task ForSpecificNonQuery_GetDataTable_WithRowAffectedColumn_AndCorrectNumberOfAffectedRows()
    {
        var presenter = _postgreSQLHelper.CreatePresenter();
        var connection = _postgreSQLHelper.CreateConnection();

        var databaseName = await _postgreSQLHelper.CreateDatabase(connection);
        const string tableName = "employees";
        string query = $"INSERT INTO {tableName} VALUES (2, 'test')";

        using (var command = connection.CreateCommand())
        {
            await connection.OpenAsync();

            await connection.ChangeDatabaseAsync(databaseName);

            command.CommandText =
                $"CREATE TABLE {tableName} (" +
                    $"id INT," +
                    $"name VARCHAR(20));";
            await command.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        var result = await Act(presenter, databaseName, query);

        Assert.Equal(ResponseType.Ok, result.Type);

        var payload = result.Payload;
        Assert.NotNull(payload);
        Assert.Equal(QueryType.NonQuery, payload.Type);

        var dataTable = payload.Table;
        Assert.NotNull(dataTable);
        Assert.NotNull(dataTable.Columns["AFFECTED ROWS"]);
        Assert.Single(dataTable.Rows);
        Assert.Equal("1", dataTable.Rows[0].ItemArray[0]);
    }

    public static Task<Response<QueryResponseDto>> Act(PostgreSQLPresenter presenter, string databaseName, string query) 
        => presenter.SendQuery(databaseName, query);

    public void Dispose() => _postgreSQLHelper.Dispose();
}
