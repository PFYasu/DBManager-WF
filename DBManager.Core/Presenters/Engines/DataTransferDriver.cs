using DBManager.Core.Dto;
using DBManager.Core.Dto.Engines;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DBManager.Core.Presenters.Engines
{
    public class DataTransferDriver : IDataTransferDriver
    {
        private readonly DataTransferMethods _dataTransferMethods;

        public DataTransferDriver(DataTransferMethods dataTransferMethods)
        {
            _dataTransferMethods = dataTransferMethods;
        }

        public async Task<Response<QueryResponseDto>> SendData(SendDataDto dto)
        {
            var connectionName = dto.ConnectionName;
            var databaseName = dto.DatabaseName;
            var tableName = dto.TableName;
            var dataTable = dto.DataTable;

            var response = _dataTransferMethods.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Response<QueryResponseDto>
                    .Error($"Unable to get {connectionName} connection. Inner error message: {response.ErrorMessage}");

            var presenter = response.Payload.Presenter;

            var query = CreateQuery(dataTable, tableName);

            var sendQueryResponse = await presenter.SendQuery(databaseName, query);
            if (sendQueryResponse.Type == ResponseType.Error)
                return Response<QueryResponseDto>
                    .Error($"Unable to send data: {sendQueryResponse.Payload}. Inner error message: {response.ErrorMessage}");

            var responseDto = sendQueryResponse.Payload;

            return Response<QueryResponseDto>.Ok(responseDto);
        }

        public Response<ConnectionNamesResponseDto> GetConnectionNames()
        {
            var response = _dataTransferMethods.GetConnectionNames();
            if (response.Type == ResponseType.Error)
                return Response<ConnectionNamesResponseDto>
                    .Error($"Unable to get connection names. Inner error message: {response.ErrorMessage}");

            var dto = response.Payload;

            return Response<ConnectionNamesResponseDto>.Ok(dto);
        }

        public async Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames(string connectionName)
        {
            var response = _dataTransferMethods.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Response<DatabaseNamesResponseDto>
                    .Error($"Unable to get {connectionName} presenter. Inner error message: {response.ErrorMessage}");

            var presenter = response.Payload.Presenter;

            var databaseNamesResponse = await presenter.GetDatabaseNames();
            if (databaseNamesResponse.Type == ResponseType.Error)
                return Response<DatabaseNamesResponseDto>
                    .Error($"Unable to get information about databases in {connectionName} connection. Inner error message: {response.ErrorMessage}");

            var dto = databaseNamesResponse.Payload;

            return Response<DatabaseNamesResponseDto>.Ok(dto);
        }

        public async Task<Response<TableNamesResponseDto>> GetTableNames(string connectionName, string databaseName)
        {
            var response = _dataTransferMethods.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
                return Response<TableNamesResponseDto>
                    .Error($"Unable to get {connectionName} presenter. Inner error message: {response.ErrorMessage}");

            var presenter = response.Payload.Presenter;

            var tableNamesResponse = await presenter.GetTableNames(databaseName);
            if (tableNamesResponse.Type == ResponseType.Error)
                return Response<TableNamesResponseDto> 
                    .Error($"Unable to get information about tables in {databaseName} database in {connectionName} connection. Inner error message: {response.ErrorMessage}");

            var dto = tableNamesResponse.Payload;

            return Response<TableNamesResponseDto>.Ok(dto);
        }

        private static string CreateQuery(DataTable dataTable, string tableName)
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
