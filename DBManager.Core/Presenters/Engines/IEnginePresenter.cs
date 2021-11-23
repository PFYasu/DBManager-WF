using System.Threading.Tasks;

namespace DBManager.Core.Presenters.Engines
{
    public interface IEnginePresenter
    {
        string ConnectionName { get; }
        string EngineType { get; }
        IQueryTrackerDriver QueryTrackerDriver { get; }
        IDataTransferDriver DataTransferDriver { get; }
        Task<Response> GetDatabaseNames();
        Task<Response> GetTableNames(string databaseName);
        Task<Response> SendQuery(string databaseName, string query);
        Task<Response> GetTableDetails(string databaseName, string tableName);
        Task<Response> GetDatabaseDetails(string databaseName);
        Task<Response> GetDatabaseTableColumns(string databaseName);
        Task<Response> GetConnectionDetails();
    }
}
