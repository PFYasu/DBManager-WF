using DBManager.Core.Presenters;
using DBManager.Utils.Files;

namespace DBManager.Tests;

public class DBManagerTestBase
{
    protected FileManagerTestDriver FileManager { get; } = new FileManagerTestDriver();
    protected IEngineModuleResolver EngineModuleResolver { get; } = new EngineModuleResolver();
}
