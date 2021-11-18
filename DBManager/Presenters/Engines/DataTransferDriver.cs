using DBManager.Dto;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines
{
    public class DataTransferDriver : IDataTransferDriver
    {
        private readonly IDBManagerPresenter _dbManagerPresenter;

        public DataTransferDriver(IDBManagerPresenter dbManagerPresenter)
        {
            _dbManagerPresenter = dbManagerPresenter;
        }

        public async Task<Response> SendData(DataTable dataTable, string connectionName, string databaseName, string tableName)
        {
            var response = _dbManagerPresenter.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Response.Error($"Unable to get {connectionName} connection");

            var payload = response.Payload as PresenterResponseDto;

            var presenter = payload.Presenter;

            var query = CreateQuery(dataTable, tableName);

            var sendQueryResponse = await presenter.SendQuery(databaseName, query);
            if (sendQueryResponse.Type == ResponseType.Error)
                return Response.Error($"Unable to send data: {sendQueryResponse.Payload}");

            var dto = sendQueryResponse.Payload;

            return Response.Ok(dto);
        }

        public Response GetConnectionNames()
        {
            var response = _dbManagerPresenter.GetConnectionNames();
            if (response.Type == ResponseType.Error)
                return Response.Error("Unable to get connection names");

            var dto = response.Payload;

            return Response.Ok(dto);
        }

        public async Task<Response> GetDatabaseNames(string connectionName)
        {
            var response = _dbManagerPresenter.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Response.Error($"Unable to get {connectionName} presenter");

            var payload = response.Payload as PresenterResponseDto;

            var presenter = payload.Presenter;

            var databaseNamesResponse = await presenter.GetDatabaseNames();
            if (databaseNamesResponse.Type == ResponseType.Error)
                return Response.Error($"Unable to get information about databases in {connectionName} connection");

            var dto = databaseNamesResponse.Payload;

            return Response.Ok(dto);
        }

        public async Task<Response> GetTableNames(string connectionName, string databaseName)
        {
            var response = _dbManagerPresenter.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Response.Error($"Unable to get {connectionName} presenter");

            var payload = response.Payload as PresenterResponseDto;

            var presenter = payload.Presenter;

            var tableNamesResponse = await presenter.GetTableNames(databaseName);
            if (tableNamesResponse.Type == ResponseType.Error)
                return Response.Error($"Unable to get information about tables in {databaseName} database in {connectionName} connection");

            var dto = tableNamesResponse.Payload;

            return Response.Ok(dto);
        }

        private string CreateQuery(DataTable dataTable, string tableName)
        {
            var queryStringBuilder = new StringBuilder();

            queryStringBuilder.Append($"INSERT INTO {tableName} ");
            queryStringBuilder.Append("(");

            foreach (DataColumn column in dataTable.Columns)
            {
                queryStringBuilder.Append($"{column.ColumnName},");
            }

            queryStringBuilder.Remove(queryStringBuilder.Length - 1, 1);
            queryStringBuilder.Append(") VALUES ");

            foreach (DataRow row in dataTable.Rows)
            {
                queryStringBuilder.Append("(");

                foreach (var item in row.ItemArray)
                {
                    queryStringBuilder.Append($"'{item}',");
                }

                queryStringBuilder.Remove(queryStringBuilder.Length - 1, 1);
                queryStringBuilder.Append("),");
            }

            queryStringBuilder.Remove(queryStringBuilder.Length - 1, 1);
            queryStringBuilder.Append(";");

            return queryStringBuilder.ToString();
        }
    }
}
