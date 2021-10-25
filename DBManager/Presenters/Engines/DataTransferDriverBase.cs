using System.Data;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines
{
    public abstract class DataTransferDriverBase : PresenterBase
    {
        public abstract Task<Response> SendData(DataTable dataTable, string connectionName, string databaseName, string tableName);
        public abstract Response GetConnectionNames();
        public abstract Task<Response> GetDatabaseNames(string connectionName);
        public abstract Task<Response> GetTableNames(string connectionName, string databaseName);
    }
}
