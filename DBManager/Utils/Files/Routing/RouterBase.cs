namespace DBManager.Utils.Files.Routing;

public abstract class RouterBase
{
    protected string _parentPath;

    public string CurrentDictionaryPath() => _parentPath;
}
