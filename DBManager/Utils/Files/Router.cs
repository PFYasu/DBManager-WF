using System.IO;

namespace DBManager.Utils.Files;

public static class Router
{
    public static string ToConnection(string connectionName) 
        => Path.Combine(Constants.Paths.ConnectionsRespository, $"{connectionName}.json");

    public static string ToConnectionRepository() => Constants.Paths.ConnectionsRespository;
}
