using DBManager.Core.Dto;
using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public interface IDBManagerPresenter
    {
        Response AddConnection(AddConnectionDto dto);
        Response RemoveConnection(string connectionName);
        Response UpdateConnection(UpdateConnectionDto dto);
        Response<ConnectionNamesResponseDto> GetConnectionNames();
        Response<AddConnectionDto> GetConnectionSettings(string connectionName);
        Response<ConnectorViewTypeResponseDto> GetConnectorViewType(string engineType);
        Response<EngineModuleNamesResponseDto> GetEngineModuleNames();
        Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames(string connectionName);
        Task<Response<TableNamesResponseDto>> GetTableNames(string connectionName, string databaseName);
    }
}
