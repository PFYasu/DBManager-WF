using DBManager.Core.Presenters;
using System.Threading.Tasks;
using DBManager.Utils.Files;
using System.Linq;
using DBManager.Core.Models;
using DBManager.Core.Dto.Engines;
using DBManager.Core.Dto;
using System.Data;
using System.Text;
using DBManager.Utils.Files.Routing;

namespace DBManager.Presenters.Engines;

public interface IDataTransferPresenter
{
    Task<Response<QueryResponseDto>> SendData(SendDataDto dto);
    Response<ConnectionNamesResponseDto> GetConnectionNames();
    Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames(string connectionName);
    Task<Response<TableNamesResponseDto>> GetTableNames(string connectionName, string databaseName);
}

public class DataTransferPresenter : IDataTransferPresenter
{
    private readonly IFileManager _fileManager;
    private readonly IEngineModuleResolver _engineModuleResolver;

    public DataTransferPresenter(IFileManager fileManager, IEngineModuleResolver engineModuleResolver)
    {
        _fileManager = fileManager;
        _engineModuleResolver = engineModuleResolver;
    }

    public Response<ConnectionNamesResponseDto> GetConnectionNames()
    {
        var connectionNames = _fileManager.LoadMany<Connection>(Router.Init().CurrentDictionaryPath())
            .Select(x => x.Name)
            .ToList();

        var dto = new ConnectionNamesResponseDto
        {
            Names = connectionNames
        };

        return Response<ConnectionNamesResponseDto>.Ok(dto);
    }

    public async Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames(string connectionName)
    {
        var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

        if (connection == null)
            return Response<DatabaseNamesResponseDto>
                .Error($"Connection {connectionName} does not exist.");

        var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

        if (presenter == null)
            return Response<DatabaseNamesResponseDto>
                .Error($"Unable to activate {connectionName} presenter. Engine type:{connection.EngineType}.");

        var dto = await presenter.GetDatabaseNames();

        return dto;
    }

    public async Task<Response<TableNamesResponseDto>> GetTableNames(string connectionName, string databaseName)
    {
        var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

        if (connection == null)
            return Response<TableNamesResponseDto>
                .Error($"Connection {connectionName} does not exist.");

        var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

        if (presenter == null)
            return Response<TableNamesResponseDto>
                .Error($"Unable to activate {connectionName} presenter. Engine type:{connection.EngineType}.");

        var dto = await presenter.GetTableNames(databaseName);

        return dto;
    }

    public async Task<Response<QueryResponseDto>> SendData(SendDataDto dto)
    {
        var connectionName = dto.ConnectionName;
        var databaseName = dto.DatabaseName;
        var tableName = dto.TableName;
        var dataTable = dto.DataTable;

        var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

        if (connection == null)
            return Response<QueryResponseDto>
                .Error($"Connection {connectionName} does not exist.");

        var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

        var query = CreateQuery(dataTable, tableName);

        var responseDto = await presenter.SendQuery(databaseName, query);

        return responseDto;
    }

    private static string CreateQuery(DataTable dataTable, string tableName)
    {
        var queryStringBuilder = new StringBuilder();

        queryStringBuilder.Append($"INSERT INTO {tableName} ");
        queryStringBuilder.Append('(');

        foreach (DataColumn column in dataTable.Columns)
        {
            queryStringBuilder.Append($"{column.ColumnName},");
        }

        queryStringBuilder.Remove(queryStringBuilder.Length - 1, 1);
        queryStringBuilder.Append(") VALUES ");

        foreach (DataRow row in dataTable.Rows)
        {
            queryStringBuilder.Append('(');

            foreach (var item in row.ItemArray)
            {
                queryStringBuilder.Append($"'{item}',");
            }

            queryStringBuilder.Remove(queryStringBuilder.Length - 1, 1);
            queryStringBuilder.Append("),");
        }

        queryStringBuilder.Remove(queryStringBuilder.Length - 1, 1);
        queryStringBuilder.Append(';');

        return queryStringBuilder.ToString();
    }
}
