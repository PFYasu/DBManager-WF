using System.Data;
using System.Threading.Tasks;

namespace DBManager.Core.Presenters.Engines
{
    public interface IDataTransferDriver
    {
        Task<Response> SendData(DataTable dataTable, string connectionName, string databaseName, string tableName);
        Response GetConnectionNames();
        Task<Response> GetDatabaseNames(string connectionName);
        Task<Response> GetTableNames(string connectionName, string databaseName);
    }
}
