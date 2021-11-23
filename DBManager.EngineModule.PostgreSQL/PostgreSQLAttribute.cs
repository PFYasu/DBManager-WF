using DBManager.Core;
using DBManager.EngineModule.PostgreSQL;

namespace DBManager.Module.PostgreSQL
{
    [EngineModule("PostgreSQL", typeof(PostgreSQLModel), typeof(PostgreSQLPresenter), typeof(PostgreSQLConnectorView))]
    public class PostgreSQLAttribute
    {
    }
}
