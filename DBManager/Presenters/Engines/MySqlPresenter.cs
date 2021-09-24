using DBManager.Dto;
using DBManager.Dto.Engines;
using DBManager.Models.Engines;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DBManager.Presenters.Engines
{
    public class MySqlPresenter : EnginePresenterBase
    {
        private readonly IEngineModel _model;
        private readonly DBManagerPresenterDatabaseOperationBase _dbManagerPresenter;

        public MySqlPresenter(IEngineModel model, DBManagerPresenterDatabaseOperationBase dbManagerPresenter)
        {
            _model = model;
            _dbManagerPresenter = dbManagerPresenter;
        }

        public override string ConnectionName => _model.Name;

        public override async Task<Response> GetDatabaseNames()
        {
            const string query = "SHOW DATABASES;";

            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new DatabaseNamesResponseDto();
            dto.Names = result
                .AsEnumerable()
                .Select(x => x.Field<string>("Database"))
                .ToList();

            return Ok(dto);
        }

        public override async Task<Response> GetTable(string databaseName, string tableName)
        {
            string query = $"SELECT * FROM {tableName};";

            DataTable result;

            try
            {
                await _model.ChangeDatabase(databaseName);
                result = await _model.ExecuteQuery(query);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new TableResponseDto { Table = result };

            return Ok(dto);
        }

        public override async Task<Response> GetTableNames(string databaseName)
        {
            string query = $"SELECT table_name FROM information_schema.tables WHERE table_schema = '{databaseName}';";

            DataTable result;

            try
            {
                await _model.ChangeDatabase(databaseName);
                result = await _model.ExecuteQuery(query);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new TableNamesResponseDto();
            dto.Names = result
                .AsEnumerable()
                .Select(x => x.Field<string>("table_name"))
                .ToList();

            return Ok(dto);
        }

        public override async Task<Response> SendQuery(string databaseName, string query)
        {
            DataTable result;

            try
            {
                await _model.ChangeDatabase(databaseName);
                result = await _model.ExecuteQuery(query);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new ExecuteQueryResponseDto { DataTable = result };

            return Ok(dto);
        }
    }
}
