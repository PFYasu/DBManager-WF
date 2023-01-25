using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Utils.Files;
using DBManager.Utils.Files.Routing;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines;

public interface ITablePresenter
{
    Task<Response<TableDetailsResponseDto>> GetTableDetails(string connectionName, string databaseName, string tableName);
}

public class TablePresenter : ITablePresenter
{
    private readonly IFileManager _fileManager;
    private readonly IEngineModuleResolver _engineModuleResolver;

    public TablePresenter(IFileManager fileManager, IEngineModuleResolver engineModuleResolver)
    {
        _fileManager = fileManager;
        _engineModuleResolver = engineModuleResolver;
    }

    public async Task<Response<TableDetailsResponseDto>> GetTableDetails(string connectionName, string databaseName, string tableName)
    {
        var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

        if (connection == null)
            return Response<TableDetailsResponseDto>.Error($"Connection with {connectionName} connection name does not exist.");

        var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

        var dto = await presenter.GetTableDetails(databaseName, tableName);

        return dto;
    }
}
