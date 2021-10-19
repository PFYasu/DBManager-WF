using DBManager.Dto.Engines;
using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using DBManager.Utils;
using Npgsql;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.PostgreSQL
{
    public class GetDatabaseTableColumnsTests
    {
        private readonly PostgreSQLPresenter _presenter;

        public GetDatabaseTableColumnsTests()
        {
            var connection = new Connection
            {
                Name = "dbmanager_postgresql_test",
                Type = EngineType.PostgreSQL,
                ConnectionParameters = ConnectionParameters.PostgreSQL.ConnectionParameters,
                TrackedQueries = new List<TrackedQuery>()
            };

            var model = new PostgreSQLModel(connection);
            _presenter = new PostgreSQLPresenter(model, null);
        }

        [Fact]
        public async Task ForSpecificDatabase_GetTableColumns_FromAllTables()
        {
            var databaseName = NamesGenerator.Generate();

            const string tableName = "employees";
            const string firstColumn = "id";
            const string secondColumn = "name";

            var connection = new NpgsqlConnection(ConnectionParameters.PostgreSQL.ConnectionString);

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);

            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                command.CommandText = $"CREATE DATABASE {databaseName};";
                await command.ExecuteNonQueryAsync();

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


            var result = await Act(databaseName);


            Assert.Equal(ResponseType.Ok, result.Type);

            var payload = result.Payload as DatabaseTableColumnsResponseDto;
            Assert.NotNull(payload);

            Assert.Single(payload.DatabaseTableColumns);

            var databaseTablesColumns = payload.DatabaseTableColumns;
            Assert.NotNull(databaseTablesColumns[tableName]);
            Assert.Contains(firstColumn, databaseTablesColumns[tableName]);
            Assert.Contains(secondColumn, databaseTablesColumns[tableName]);

            await PostgreSQLHelper.RemoveDatabase(connection, databaseName);
        }


        public async Task<Response> Act(string databaseName)
        {
            var result = await _presenter.GetDatabaseTableColumns(databaseName);

            return result;
        }
    }
}
