using DBManager.Dto;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines
{
    public abstract class EnginePresenterBase : PresenterBase
    {
        public abstract Task<Response> GetDatabaseNames();
        public abstract Task<Response> GetTable(string databaseName, string tableName);
        public abstract Task<Response> GetTableNames(string databaseName);
        public abstract Task<Response> SendQuery(string databaseName, string query);
    }
}
