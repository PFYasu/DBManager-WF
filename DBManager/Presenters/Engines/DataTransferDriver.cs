using DBManager.Dto;
using DBManager.Utils;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines
{
    public class DataTransferDriver : DataTransferDriverBase
    {
        private readonly DBManagerPresenterBase _dbManagerPresenter;

        public DataTransferDriver(DBManagerPresenterBase dbManagerPresenter)
        {
            _dbManagerPresenter = dbManagerPresenter;
        }

        public override async Task<Response> SendData(DataTable dataTable, string connectionName, string databaseName, string tableName)
        {
            var response = _dbManagerPresenter.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Error($"Unable to get {connectionName} connection");

            var payload = response.Payload as PresenterResponseDto;

            var presenter = payload.Presenter;

            var query = CreateQuery(dataTable, tableName);

            var sendQueryResponse = await presenter.SendQuery(databaseName, query);
            if (sendQueryResponse.Type == ResponseType.Error)
                return Error($"Unable to send data: {sendQueryResponse.Payload}");

            var dto = sendQueryResponse.Payload;

            return Ok(dto);
        }

        public override Response GetConnectionNames()
        {
            var response = _dbManagerPresenter.GetConnectionNames();
            if (response.Type == ResponseType.Error)
                return Error("Unable to get connection names");

            var dto = response.Payload;

            return Ok(dto);
        }

        public override async Task<Response> GetDatabaseNames(string connectionName)
        {
            var response = _dbManagerPresenter.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Error($"Unable to get {connectionName} presenter");

            var payload = response.Payload as PresenterResponseDto;

            var presenter = payload.Presenter;

            var databaseNamesResponse = await presenter.GetDatabaseNames();
            if (databaseNamesResponse.Type == ResponseType.Error)
                return Error($"Unable to get information about databases in {connectionName} connection");

            var dto = databaseNamesResponse.Payload;

            return Ok(dto);
        }

        public override async Task<Response> GetTableNames(string connectionName, string databaseName)
        {
            var response = _dbManagerPresenter.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Error($"Unable to get {connectionName} presenter");

            var payload = response.Payload as PresenterResponseDto;

            var presenter = payload.Presenter;

            var tableNamesResponse = await presenter.GetTableNames(databaseName);
            if (tableNamesResponse.Type == ResponseType.Error)
                return Error($"Unable to get information about tables in {databaseName} database in {connectionName} connection");

            var dto = tableNamesResponse.Payload;

            return Ok(dto);
        }

        private string CreateQuery(DataTable dataTable, string tableName)
        {
            var query = "";

            query += $"INSERT INTO {tableName} ";

            query += "(";
            foreach (DataColumn column in dataTable.Columns)
            {
                query += $"{column.ColumnName},";
            }
            query = query.RemoveLastCharacters(1);
            query += ") VALUES ";

            foreach (DataRow row in dataTable.Rows)
            {
                query += "(";
                foreach (var test in row.ItemArray)
                {
                    query += $"'{test}',";
                }
                query = query.RemoveLastCharacters(1);
                query += "),";
            }
            query = query.RemoveLastCharacters(1);

            query += ";";

            return query;
        }
    }
}
