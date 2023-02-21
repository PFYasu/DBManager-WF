using System.IO;

namespace DBManager.Utils.Files.Routing;

public class ConnectionRouter : RouterBase
{
    public ConnectionRouter(string currentPath) 
        : base(currentPath)
    {
    }

    public string SettingsPath()
        => Path.Combine(_parentPath, "settings.json");

    public TrackedQueryRouter TrackedQuery(string trackedQueryName)
        => new(Path.Combine(_parentPath, trackedQueryName));
}
