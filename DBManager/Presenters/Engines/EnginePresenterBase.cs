using DBManager.Utils;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines
{
    public abstract class EnginePresenterBase : PresenterBase
    {
        public abstract string ConnectionName { get; }
        public abstract EngineType EngineType { get; }
        public abstract Task<Response> GetDatabaseNames();
        public abstract Task<Response> GetTable(string databaseName, string tableName);
        public abstract Task<Response> GetTableNames(string databaseName);
        public abstract Task<Response> SendQuery(string databaseName, string query);
        public abstract Task<Response> GetTableDetails(string databaseName, string tableName);
        public abstract Task<Response> GetDatabaseDetails(string databaseName);
        public abstract Task<Response> GetDatabaseTableColumns(string databaseName);
        public abstract Task<Response> GetConnectionDetails();
    }
}
