using DBManager.Core;
using DBManager.EngineModule.MySql;

namespace DBManager.Module.MySql
{
    [EngineModule("MySql", typeof(MySqlModel), typeof(MySqlPresenter), typeof(MySqlConnectorView))]
    public class MySqlAttribute
    {
    }
}