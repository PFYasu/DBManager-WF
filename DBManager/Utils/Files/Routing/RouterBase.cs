namespace DBManager.Utils.Files.Routing;

public abstract class RouterBase
{
    protected readonly string _parentPath;

    protected RouterBase(string parentPath)
    {
        _parentPath = parentPath;
    }

    public string CurrentDictionaryPath() => _parentPath;
}
