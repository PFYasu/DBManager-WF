using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Utils.Files;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines;

public interface IDatabasePresenter
{
    Task<Response<DatabaseDetailsResponseDto>> GetDatabaseDetails(string connectionName, string databaseName);
}

public class DatabasePresenter : IDatabasePresenter
{
    private readonly IFileManager _fileManager;
    private readonly IEngineModuleResolver _engineModuleResolver;

    public DatabasePresenter(IFileManager fileManager, IEngineModuleResolver engineModuleResolver)
    {
        _fileManager = fileManager;
        _engineModuleResolver = engineModuleResolver;
    }

    public async Task<Response<DatabaseDetailsResponseDto>> GetDatabaseDetails(string connectionName, string databaseName)
    {
        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response<DatabaseDetailsResponseDto>.Error($"Connection with {connectionName} connection name does not exist.");

        var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

        var dto = await presenter.GetDatabaseDetails(databaseName);

        return dto;
    }
}
