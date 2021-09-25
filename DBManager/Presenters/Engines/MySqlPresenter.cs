using DBManager.Dto.Engines;
using DBManager.Models.Engines;
using DBManager.Utils;
using System;
using System.Collections.Generic;
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
        public override EngineType EngineType => _model.Type;

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
            string query = $"SELECT * FROM {databaseName}.{tableName};";

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
            string query = $"SELECT TABLE_NAME FROM information_schema.TABLES WHERE TABLE_SCHEMA = '{databaseName}';";

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

        public override async Task<Response> GetTableDetails(string databaseName, string tableName)
        {
            string tableQuery = $"SELECT TABLE_NAME, CREATE_TIME, UPDATE_TIME, ROUND(SUM(data_length + index_length) / 1024, 1) AS 'SIZE' " +
                $"FROM TABLES " +
                $"WHERE TABLE_SCHEMA = '{databaseName}' AND TABLE_NAME = '{tableName}';";

            Response tableQueryResponse;
            DataTable tableQueryResult;

            string columnsQuery = $"SELECT COLUMN_NAME, DATA_TYPE, COLLATION_NAME " +
                $"FROM COLUMNS " +
                $"WHERE TABLE_NAME = '{tableName}' AND TABLE_SCHEMA = '{databaseName}';";

            DataTable columnsQueryResult;

            tableQueryResponse = await GetTable(databaseName, tableName);
            if (tableQueryResponse.Type == ResponseType.Error)
                return Error(tableQueryResponse.Payload as string);

            try
            {
                tableQueryResult = await _model.ExecuteQuery(tableQuery);
                columnsQueryResult = await _model.ExecuteQuery(columnsQuery);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var tableQueryPayload = tableQueryResponse.Payload as TableResponseDto;

            var rowsCount = tableQueryPayload.Table.Rows.Count;
            var columnsCount = columnsQueryResult.Rows.Count;
            var createdAt = tableQueryResult.Rows[0].Field<DateTime>("CREATE_TIME");
            var lastUpdate = tableQueryResult.Rows[0].Field<DateTime?>("UPDATE_TIME");
            var size = tableQueryResult.Rows[0].Field<decimal>("SIZE");

            var columnsStructure = new List<ColumnsStructure>();

            foreach (DataRow row in columnsQueryResult.Rows)
            {
                var name = row.Field<string>("COLUMN_NAME");
                var type = row.Field<string>("DATA_TYPE");
                var comparingSubtitlesMethod = row.Field<string>("COLLATION_NAME");

                var columnStructure = new ColumnsStructure
                {
                    Name = name,
                    Type = type,
                    ComparingSubtitlesMethod = comparingSubtitlesMethod
                };

                columnsStructure.Add(columnStructure);
            }

            var dto = new TableDetailsResponseDto
            {
                Table = tableQueryPayload.Table,
                RowsCount = rowsCount,
                ColumnsCount = columnsCount,
                ColumnsStructure = columnsStructure,
                Size = size,
                CreatedAt = createdAt,
                LastUpdate = lastUpdate
            };

            return Ok(dto);
        }
    }
}
