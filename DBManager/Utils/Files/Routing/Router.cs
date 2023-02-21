using System.IO;

namespace DBManager.Utils.Files.Routing;

public class Router : RouterBase
{
    private Router()
        : base(Constants.Paths.ConnectionsRespository)
    {
    }

    public static Router Init() => new();

    public ConnectionRouter Connection(string connectionName) 
        => new(Path.Combine(_parentPath, connectionName));
}
