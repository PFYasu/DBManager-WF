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
    public class GetTableNamesTests
    {
        [Fact]
        public async Task ForSpecificTables_GetCorrectTableNames_ForMySql()
        {
            var someDatabaseName = "Northwind";
            var correctTableNames = CreateCorrectResponseFromModel_ForMySql();

            var presenter = GetPreparedPresenter_ForMySql(correctTableNames);


            var result = await Act(someDatabaseName, presenter);


            AssertCorrectResponse(correctTableNames, result);
        }

        [Fact]
        public async Task ForSpecificTables_GetCorrectTableNames_ForPostgreSQL()
        {
            var someDatabaseName = "Northwind";
            var correctTableNames = CreateCorrectResponseFromModel_ForPostgreSQL();

            var presenter = GetPreparedPresenter_ForPostgreSQL(correctTableNames);


            var result = await Act(someDatabaseName, presenter);


            AssertCorrectResponse(correctTableNames, result);
        }


        private DataTable CreateCorrectResponseFromModel_ForMySql()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("table_name");

            FillDataTableWithCorrectData(dataTable);

            return dataTable;
        }

        private DataTable CreateCorrectResponseFromModel_ForPostgreSQL()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("table_name");

            FillDataTableWithCorrectData(dataTable);

            return dataTable;
        }

        private void FillDataTableWithCorrectData(DataTable dataTable)
        {
            dataTable.Rows.Add("Orders");
            dataTable.Rows.Add("Clients");
            dataTable.Rows.Add("Employees");
        }

        private MySqlPresenter GetPreparedPresenter_ForMySql(DataTable mockedValue)
        {
            var mockedEngine = new Mock<IEngineModel>();

            mockedEngine.Setup(x => x.ExecuteQuery(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(mockedValue);

            var presenter = new MySqlPresenter(mockedEngine.Object, null);

            return presenter;
        }

        private PostgreSQLPresenter GetPreparedPresenter_ForPostgreSQL(DataTable mockedValue)
        {
            var mockedEngine = new Mock<IEngineModel>();

            mockedEngine.Setup(x => x.ExecuteQuery(It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(mockedValue);

            var presenter = new PostgreSQLPresenter(mockedEngine.Object, null);

            return presenter;
        }


        private async Task<Response> Act(string databaseName, EnginePresenterBase presenter)
        {
            var result = await presenter.GetTableNames(databaseName);

            return result;
        }


        private void AssertCorrectResponse(DataTable expected, Response actual)
        {
            Assert.NotNull(actual);
            Assert.Equal(ResponseType.Ok, actual.Type);
            Assert.NotNull(actual.Payload);

            var payload = actual.Payload as TableNamesResponseDto;
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
