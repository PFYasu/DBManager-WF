using System.IO;

namespace DBManager.Utils.Files.Routing;

public class TrackedQueryRouter
{
    private readonly string _parentPath;

    public TrackedQueryRouter(string parentPath)
    {
        _parentPath = parentPath;
    }

    public string SettingsPath()
        => Path.Combine(_parentPath, "settings.json");

    public string QuerySnapshotPath(string querySnapshotName)
        => new(Path.Combine(_parentPath, querySnapshotName + ".json"));
}
