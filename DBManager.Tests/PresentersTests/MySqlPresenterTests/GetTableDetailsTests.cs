﻿using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.MySqlPresenterTests
{
    public class GetTableDetailsTests : IDisposable
    {
        private readonly MySqlHelper _mySqlHelper;

        public GetTableDetailsTests()
        {
            _mySqlHelper = new MySqlHelper();
        }

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


        public async Task<Response> Act(MySqlPresenter presenter, string databaseName, string tableName)
        {
            var result = await presenter.GetTableDetails(databaseName, tableName);

            return result;
        }


        public void Dispose()
        {
            _mySqlHelper.Dispose();
        }
    }
}