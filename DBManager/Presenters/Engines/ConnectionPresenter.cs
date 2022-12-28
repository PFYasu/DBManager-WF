using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Utils.Files;
using System;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines;

public interface IConnectionPresenter
{
    Task<Response<ConnectionDetailsResponseDto>> GetConnectionDetails(string connectionName);
}

public class ConnectionPresenter : IConnectionPresenter
{
    private readonly IFileManager _fileManager;
    private readonly IEngineModuleResolver _engineModuleResolver;

    public ConnectionPresenter(IFileManager fileManager, IEngineModuleResolver engineModuleResolver)
    {
        _fileManager = fileManager;
        _engineModuleResolver = engineModuleResolver;
    }

    public async Task<Response<ConnectionDetailsResponseDto>> GetConnectionDetails(string connectionName)
    {
        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response<ConnectionDetailsResponseDto>.Error($"Connection with {connectionName} connection name does not exist.");

        IEnginePresenter presenter;
        try
        {
            presenter = _engineModuleResolver.CreateEnginePresenter(connection);
        }
        catch (Exception exception)
        {
            return Response<ConnectionDetailsResponseDto>.Error(exception.Message);
        }

        var dto = await presenter.GetConnectionDetails();

        return dto;
    }
}
