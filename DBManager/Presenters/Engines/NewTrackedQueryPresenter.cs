using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Utils.Files;
using DBManager.Utils.Files.Routing;

namespace DBManager.Presenters.Engines;

public interface INewTrackedQueryPresenter
{
    Response AddTrackedQuery(NewTrackedQueryDto dto);
}

public class NewTrackedQueryPresenter : INewTrackedQueryPresenter
{
    private readonly IFileManager _fileManager;

    public NewTrackedQueryPresenter(IFileManager fileManager)
    {
        _fileManager = fileManager;
    }

    public Response AddTrackedQuery(NewTrackedQueryDto dto)
    {
        var connection = _fileManager.Load<Connection>(Router.Init().Connection(dto.ConnectionName).SettingsPath());

        if (connection == null)
            return Response.Error($"Connection {dto.ConnectionName} does not exist.");

        var exists = connection.TrackedQueries
            .Exists(x => x.Name == dto.Name && x.DatabaseName == dto.DatabaseName);

        if (exists)
            return Response.Error($"Tracked query with {dto.Name} name already exists");

        var trackedQuery = TrackedQuery.FromDto(dto);

        connection.TrackedQueries.Add(trackedQuery);

        _fileManager.Save(connection, Router.Init().Connection(connection.Name).SettingsPath());

        return Response.Ok();
    }
}
