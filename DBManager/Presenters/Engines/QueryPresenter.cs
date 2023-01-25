using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Utils.Files;
using DBManager.Utils.Files.Routing;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines;

public interface IQueryPresenter
{
    Task<Response<DatabaseTableColumnsResponseDto>> GetDatabaseTableColumns(string connectionName, string databaseName);
    Task<Response<QueryResponseDto>> SendQuery(string connectionName, string databaseName, string query);
}

public class QueryPresenter : IQueryPresenter
{
    private readonly IFileManager _fileManager;
    private readonly IEngineModuleResolver _engineModuleResolver;

    public QueryPresenter(IFileManager fileManager, IEngineModuleResolver engineModuleResolver)
    {
        _fileManager = fileManager;
        _engineModuleResolver = engineModuleResolver;
    }

    public async Task<Response<DatabaseTableColumnsResponseDto>> GetDatabaseTableColumns(string connectionName, string databaseName)
    {
        var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

        if (connection == null)
            return Response<DatabaseTableColumnsResponseDto>
                .Error($"Connection {connectionName} does not exist.");

        var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

        if (presenter == null)
            return Response<DatabaseTableColumnsResponseDto>
                .Error($"Unable to activate {connectionName} presenter. Engine type:{connection.EngineType}.");

        var dto = await presenter.GetDatabaseTableColumns(databaseName);

        return dto;
    }

    public async Task<Response<QueryResponseDto>> SendQuery(string connectionName, string databaseName, string query)
    {
        var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

        if (connection == null)
            return Response<QueryResponseDto>
                .Error($"Connection {connectionName} does not exist.");

        var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

        if (presenter == null)
            return Response<QueryResponseDto>
                .Error($"Unable to activate {connectionName} presenter. Engine type:{connection.EngineType}.");

        var dto = await presenter.SendQuery(databaseName, query);

        return dto;
    }
}
