using DBManager.Core.Dto.Engines;
using System.Threading.Tasks;

namespace DBManager.Core.Presenters.Engines
{
    public interface IEnginePresenter
    {
        string ConnectionName { get; }
        string EngineType { get; }
        Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames();
        Task<Response<TableNamesResponseDto>> GetTableNames(string databaseName);
        Task<Response<QueryResponseDto>> SendQuery(string databaseName, string query);
        Task<Response<TableDetailsResponseDto>> GetTableDetails(string databaseName, string tableName);
        Task<Response<DatabaseDetailsResponseDto>> GetDatabaseDetails(string databaseName);
        Task<Response<DatabaseTableColumnsResponseDto>> GetDatabaseTableColumns(string databaseName);
        Task<Response<ConnectionDetailsResponseDto>> GetConnectionDetails();
    }
}
