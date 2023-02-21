using System.IO;

namespace DBManager.Utils.Files.Routing;

public class TrackedQueryRouter : RouterBase
{
    public TrackedQueryRouter(string parentPath)
        : base(parentPath)
    {
    }

    public string SettingsPath()
        => Path.Combine(_parentPath, "settings.json");

    public string QuerySnapshotPath(string querySnapshotName)
        => new(Path.Combine(_parentPath, querySnapshotName + ".json"));
}
