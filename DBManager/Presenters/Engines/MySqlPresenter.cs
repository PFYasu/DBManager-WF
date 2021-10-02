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
        private readonly DBManagerPresenterBase _dbManagerPresenter;

        public MySqlPresenter(IEngineModel model, DBManagerPresenterBase dbManagerPresenter)
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
            string query = $"SELECT * FROM {tableName};";

            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query, databaseName);
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
            string query = 
                $"SELECT " +
                    $"TABLE_NAME " +
                $"FROM TABLES " +
                $"WHERE TABLE_SCHEMA = '{databaseName}';";

            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query, "information_schema");
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
                result = await _model.ExecuteQuery(query, databaseName);
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
            string tableQuery = 
                $"SELECT " +
                    $"TABLE_NAME, " +
                    $"CREATE_TIME, " +
                    $"UPDATE_TIME, " +
                    $"ROUND(SUM(data_length + index_length) / 1024, 1) AS 'SIZE' " +
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
                return Error(tableQueryResponse.Payload);

            try
            {
                tableQueryResult = await _model.ExecuteQuery(tableQuery, "information_schema");
                columnsQueryResult = await _model.ExecuteQuery(columnsQuery, "information_schema");
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var tableQueryPayload = tableQueryResponse.Payload as TableResponseDto;

            var table = tableQueryPayload.Table;
            var rowsCount = tableQueryPayload.Table.Rows.Count;
            var columnsCount = columnsQueryResult.Rows.Count;
            var createdAt = tableQueryResult.Rows[0].TryConvertTo<DateTime>("CREATE_TIME");
            var lastUpdate = tableQueryResult.Rows[0].TryConvertTo<DateTime?>("UPDATE_TIME");
            var size = tableQueryResult.Rows[0].TryConvertTo<decimal>("SIZE");

            var columnsStructure = new List<ColumnStructure>();

            foreach (DataRow row in columnsQueryResult.Rows)
            {
                var name = row.TryConvertTo<string>("COLUMN_NAME");
                var type = row.TryConvertTo<string>("DATA_TYPE");
                var comparingSubtitlesMethod = row.TryConvertTo<string>("COLLATION_NAME");

                var columnStructure = new ColumnStructure
                {
                    Name = name,
                    Type = type,
                    ComparingSubtitlesMethod = comparingSubtitlesMethod
                };

                columnsStructure.Add(columnStructure);
            }

            var dto = new TableDetailsResponseDto
            {
                Table = table,
                RowsCount = rowsCount,
                ColumnsCount = columnsCount,
                ColumnsStructure = columnsStructure,
                Size = size,
                CreatedAt = createdAt,
                LastUpdate = lastUpdate
            };

            return Ok(dto);
        }

        public override async Task<Response> GetDatabaseDetails(string databaseName)
        {
            string query = 
                $"SELECT " +
                    $"TABLE_NAME, " +
                    $"TABLE_TYPE, " +
                    $"ROUND(SUM(DATA_LENGTH + INDEX_LENGTH) / 1024, 1) AS 'SIZE', " +
                    $"TABLE_ROWS, " +
                    $"TABLE_COLLATION " +
                $"FROM TABLES " +
                $"WHERE TABLE_SCHEMA = '{databaseName}' " +
                $"GROUP BY TABLE_NAME;";

            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query, "information_schema");
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var tablesStructure = new List<TableStructure>();

            foreach (DataRow row in result.Rows)
            {
                var name = row.TryConvertTo<string>("TABLE_NAME");
                var type = row.TryConvertTo<string>("TABLE_TYPE");
                var records = row.TryConvertTo<UInt64?>("TABLE_ROWS");
                var size = row.TryConvertTo<decimal?>("SIZE");
                var comparingSubtitlesMethod = row.TryConvertTo<string>("TABLE_COLLATION");

                var columnStructure = new TableStructure
                {
                    Name = name,
                    Type = type,
                    Records = records,
                    Size = size,
                    ComparingSubtitlesMethod = comparingSubtitlesMethod
                };

                tablesStructure.Add(columnStructure);
            }

            var dto = new DatabaseDetailsResponseDto
            {
                TablesCount = tablesStructure.Count,
                TablesStructure = tablesStructure
            };

            return Ok(dto);
        }

        public override async Task<Response> GetConnectionDetails()
        {
            string query = "SHOW DATABASES;";

            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var name = _model.Name;
            var type = _model.Type;

            var connectionParameters = _model.ConnectionParameters;
            var uid = connectionParameters["Uid"];
            var server = connectionParameters["Server"];
            var port = int.Parse(connectionParameters["Port"]);

            var databasesCount = result.Rows.Count;

            var databasesStructure = new List<DatabaseStructure>();

            foreach (DataRow row in result.Rows)
            {
                var databaseName = row.TryConvertTo<string>("Database");

                var databaseStructure = new DatabaseStructure { Name = databaseName };

                databasesStructure.Add(databaseStructure);
            }

            var dto = new ConnectionDetailsResponseDto()
            {
                Name = name,
                Type = type,
                Uid = uid,
                Server = server,
                Port = port,
                DatabasesCount = databasesCount,
                DatabasesStructure = databasesStructure
            };

            return Ok(dto);
        }
    }
}
