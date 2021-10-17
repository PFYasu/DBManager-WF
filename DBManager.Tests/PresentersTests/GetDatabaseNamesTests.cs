using DBManager.Dto.Engines;
using DBManager.Models.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using Moq;
using System.Data;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests
{
    public class GetDatabaseNamesTests
    {
        [Fact]
        public async Task ForSpecificDatabases_GetCorrectDatabaseNames_ForMySql()
        {
            var correctDatabaseNames = CreateCorrectResponseFromModel_ForMySql();

            var presenter = GetPreparedPresenter_ForMySql(correctDatabaseNames);


            var result = await Act(presenter);


            AssertCorrectResponse(correctDatabaseNames, result);
        }

        [Fact]
        public async Task ForSpecificDatabases_GetCorrectDatabaseNames_ForPostgreSQL()
        {
            var correctDatabaseNames = CreateCorrectResponseFromModel_ForPostgreSQL();

            var presenter = GetPreparedPresenter_ForPostgreSQL(correctDatabaseNames);


            var result = await Act(presenter);


            AssertCorrectResponse(correctDatabaseNames, result);
        }


        private DataTable CreateCorrectResponseFromModel_ForMySql()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("Database");

            FillDataTableWithCorrectData(dataTable);

            return dataTable;
        }

        private DataTable CreateCorrectResponseFromModel_ForPostgreSQL()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("datname");

            FillDataTableWithCorrectData(dataTable);

            return dataTable;
        }

        private void FillDataTableWithCorrectData(DataTable dataTable)
        {
            dataTable.Rows.Add("Northwind");
            dataTable.Rows.Add("Test");
            dataTable.Rows.Add("NewDb");
        }

        private MySqlPresenter GetPreparedPresenter_ForMySql(DataTable mockedValue)
        {
            var mockedEngine = new Mock<IEngineModel>();

            mockedEngine.Setup(x => x.ExecuteQuery(It.IsAny<string>()))
                .ReturnsAsync(mockedValue);

            var presenter = new MySqlPresenter(mockedEngine.Object, null);

            return presenter;
        }

        private PostgreSQLPresenter GetPreparedPresenter_ForPostgreSQL(DataTable mockedValue)
        {
            var mockedEngine = new Mock<IEngineModel>();

            mockedEngine.Setup(x => x.ExecuteQuery(It.IsAny<string>()))
                .ReturnsAsync(mockedValue);

            var presenter = new PostgreSQLPresenter(mockedEngine.Object, null);

            return presenter;
        }


        private async Task<Response> Act(EnginePresenterBase presenter)
        {
            var result = await presenter.GetDatabaseNames();

            return result;
        }


        private void AssertCorrectResponse(DataTable expected, Response actual)
        {
            Assert.NotNull(actual);
            Assert.Equal(ResponseType.Ok, actual.Type);
            Assert.NotNull(actual.Payload);

            var payload = actual.Payload as DatabaseNamesResponseDto;
            Assert.NotNull(payload);
            Assert.Equal(expected.Rows.Count, payload.Names.Count);

            foreach (DataRow row in expected.Rows)
            {
                var name = row.Field<string>(0);

                Assert.Contains(name, payload.Names);
            }
        }
    }
}
