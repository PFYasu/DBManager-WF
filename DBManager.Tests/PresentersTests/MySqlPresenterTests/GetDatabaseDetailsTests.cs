﻿using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.MySqlPresenterTests
{
    public class GetDatabaseDetailsTests : IDisposable
    {
        private readonly MySqlHelper _mySqlHelper;

        public GetDatabaseDetailsTests()
        {
            _mySqlHelper = new MySqlHelper();
        }

        [Fact]
        public async Task ForSpecificDatabase_GetDatabaseDetails()
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


        public async Task<Response> Act(MySqlPresenter presenter, string databaseName)
        {
            var result = await presenter.GetDatabaseDetails(databaseName);

            return result;
        }


        public void Dispose()
        {
            _mySqlHelper.Dispose();
        }
    }
}