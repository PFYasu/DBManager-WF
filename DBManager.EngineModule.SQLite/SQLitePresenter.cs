using DBManager.Core.Dto.Engines;
using DBManager.Core.Models.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;

namespace DBManager.EngineModule.SQLite;

public class SQLitePresenter : IEnginePresenter
{
    private readonly IEngineModel _model;

    public SQLitePresenter(IEngineModel model)
    {
        _model = model;
    }

    public string ConnectionName => _model.Name;
    public string EngineType => _model.EngineType;

    public Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames()
    {
        throw new NotImplementedException();
    }

    public Task<Response<TableNamesResponseDto>> GetTableNames(string databaseName)
    {
        throw new NotImplementedException();
    }

    public Task<Response<QueryResponseDto>> SendQuery(string databaseName, string query)
    {
        throw new NotImplementedException();
    }

    public Task<Response<TableDetailsResponseDto>> GetTableDetails(string databaseName, string tableName)
    {
        throw new NotImplementedException();
    }

    public Task<Response<DatabaseDetailsResponseDto>> GetDatabaseDetails(string databaseName)
    {
        throw new NotImplementedException();
    }

    public Task<Response<DatabaseTableColumnsResponseDto>> GetDatabaseTableColumns(string databaseName)
    {
        throw new NotImplementedException();
    }

    public Task<Response<ConnectionDetailsResponseDto>> GetConnectionDetails()
    {
        throw new NotImplementedException();
    }
}
