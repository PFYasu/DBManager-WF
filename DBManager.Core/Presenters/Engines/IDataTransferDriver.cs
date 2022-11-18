using DBManager.Core.Dto;
using DBManager.Core.Dto.Engines;
using System.Threading.Tasks;

namespace DBManager.Core.Presenters.Engines
{
    public interface IDataTransferDriver
    {
        Task<Response<QueryResponseDto>> SendData(SendDataDto dto);
        Response<ConnectionNamesResponseDto> GetConnectionNames();
        Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames(string connectionName);
        Task<Response<TableNamesResponseDto>> GetTableNames(string connectionName, string databaseName);
    }
}
