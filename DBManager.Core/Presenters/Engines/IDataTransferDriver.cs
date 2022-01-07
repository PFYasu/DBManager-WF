using DBManager.Core.Dto.Engines;
using System.Threading.Tasks;

namespace DBManager.Core.Presenters.Engines
{
    public interface IDataTransferDriver
    {
        Task<Response> SendData(SendDataDto dto);
        Response GetConnectionNames();
        Task<Response> GetDatabaseNames(string connectionName);
        Task<Response> GetTableNames(string connectionName, string databaseName);
    }
}
