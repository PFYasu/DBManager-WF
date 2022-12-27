using DBManager.Core.Dto.Engines;
using DBManager.Core.Models.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DBManager.EngineModule.MySql
{
    public class MySqlPresenter : IEnginePresenter
    {
        private readonly IEngineModel _model;

        public MySqlPresenter(IEngineModel model)
        {
            _model = model;

            QueryTrackerDriver = new QueryTrackerDriver(_model);
        }

        public string ConnectionName => _model.Name;
        public string EngineType => _model.EngineType;
        public IQueryTrackerDriver QueryTrackerDriver { get; }

        public async Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames()
        {
            const string query = "SHOW DATABASES;";
            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query);
            }
            catch (Exception exception)
            {
                return Response<DatabaseNamesResponseDto>.Error(exception.Message);
            }

            var names = result
                .AsEnumerable()
                .Select(x => x.TryConvertTo<string>("Database"))
                .ToList();

            var dto = new DatabaseNamesResponseDto { Names = names };

            return Response<DatabaseNamesResponseDto>.Ok(dto);
        }

        public async Task<Response<TableNamesResponseDto>> GetTableNames(string databaseName)
        {
            var query =
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
                return Response<TableNamesResponseDto>.Error(exception.Message);
            }

            var names = result
                .AsEnumerable()
                .Select(x => x.Field<string>("table_name"))
                .ToList();

            var dto = new TableNamesResponseDto { Names = names };

            return Response<TableNamesResponseDto>.Ok(dto);
        }

        public async Task<Response<QueryResponseDto>> SendQuery(string databaseName, string query)
        {
            var queryType = QueryTypeResolver.GetQueryType(query);
            var result = new DataTable();

            try
            {
                switch (queryType)
                {
                    case QueryType.Query:
                        var executeQueryResult = await _model.ExecuteQuery(query, databaseName);
                        result = executeQueryResult;
                        break;
                    case QueryType.NonQuery:
                        var executeNonQueryResult = await _model.ExecuteNonQuery(query, databaseName);
                        result.Columns.Add("AFFECTED ROWS");
                        result.Rows.Add(executeNonQueryResult);
                        break;
                    default:
                        return Response<QueryResponseDto>.Error("Invalid query type.");
                }
            }
            catch (Exception exception)
            {
                return Response<QueryResponseDto>.Error(exception.Message);
            }

            var dto = new QueryResponseDto
            {
                Type = queryType,
                Table = result
            };

            return Response<QueryResponseDto>.Ok(dto);
        }

        public async Task<Response<TableDetailsResponseDto>> GetTableDetails(string databaseName, string tableName)
        {
            var tableQuery =
                $"SELECT " +
                    $"TABLE_NAME, " +
                    $"CREATE_TIME, " +
                    $"ROUND(SUM(data_length + index_length) / 1024, 1) AS 'SIZE' " +
                $"FROM TABLES " +
                $"WHERE TABLE_SCHEMA = '{databaseName}' AND TABLE_NAME = '{tableName}';";
            DataTable tableQueryResult;

            var columnsQuery = $"SELECT COLUMN_NAME, DATA_TYPE, COLLATION_NAME " +
                $"FROM COLUMNS " +
                $"WHERE TABLE_NAME = '{tableName}' AND TABLE_SCHEMA = '{databaseName}';";
            DataTable columnsQueryResult;

            var fullTableQuery = $"SELECT * FROM {tableName}";
            DataTable fullTableResult;

            try
            {
                tableQueryResult = await _model.ExecuteQuery(tableQuery, "information_schema");
                columnsQueryResult = await _model.ExecuteQuery(columnsQuery, "information_schema");
                fullTableResult = await _model.ExecuteQuery(fullTableQuery, databaseName);
            }
            catch (Exception exception)
            {
                return Response<TableDetailsResponseDto>.Error(exception.Message);
            }

            var table = fullTableResult;
            var rowsCount = fullTableResult.Rows.Count;
            var columnsCount = columnsQueryResult.Rows.Count;

            var createdAt = tableQueryResult.Rows[0].TryConvertTo<DateTime>("CREATE_TIME");
            var size = tableQueryResult.Rows[0].TryConvertTo<decimal>("SIZE");

            var customInformations = new Dictionary<string, string>()
            {
                { "Size", size.ToString() },
                { "Created at", createdAt.ToString() }
            };

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
                CustomInformations = customInformations
            };

            return Response<TableDetailsResponseDto>.Ok(dto);
        }

        public async Task<Response<DatabaseDetailsResponseDto>> GetDatabaseDetails(string databaseName)
        {
            var query =
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
                return Response<DatabaseDetailsResponseDto>.Error(exception.Message);
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

            var tablesCount = tablesStructure.Count;

            var dto = new DatabaseDetailsResponseDto
            {
                TablesCount = tablesCount,
                TablesStructure = tablesStructure
            };

            return Response<DatabaseDetailsResponseDto>.Ok(dto);
        }

        public async Task<Response<DatabaseTableColumnsResponseDto>> GetDatabaseTableColumns(string databaseName)
        {
            var query =
                $"SELECT " +
                    $"TABLE_NAME, " +
                    $"COLUMN_NAME " +
                $"FROM COLUMNS " +
                $"WHERE TABLE_SCHEMA = '{databaseName}';";
            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query, "information_schema");
            }
            catch (Exception exception)
            {
                return Response<DatabaseTableColumnsResponseDto>.Error(exception.Message);
            }

            var databaseTableColumns = new Dictionary<string, List<string>>();

            foreach (DataRow row in result.Rows)
            {
                var tableName = row.TryConvertTo<string>("TABLE_NAME");
                var columnName = row.TryConvertTo<string>("COLUMN_NAME");

                if (databaseTableColumns.ContainsKey(tableName) == false)
                    databaseTableColumns.Add(tableName, new List<string>());

                databaseTableColumns[tableName].Add(columnName);
            }

            var dto = new DatabaseTableColumnsResponseDto
            {
                DatabaseTableColumns = databaseTableColumns
            };

            return Response<DatabaseTableColumnsResponseDto>.Ok(dto);
        }

        public async Task<Response<ConnectionDetailsResponseDto>> GetConnectionDetails()
        {
            var query = "SHOW DATABASES;";
            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query);
            }
            catch (Exception exception)
            {
                return Response<ConnectionDetailsResponseDto>.Error(exception.Message);
            }

            var name = _model.Name;
            var engineType = _model.EngineType;

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

            var dto = new ConnectionDetailsResponseDto
            {
                Name = name,
                EngineType = engineType,
                Uid = uid,
                Server = server,
                Port = port,
                DatabasesCount = databasesCount,
                DatabasesStructure = databasesStructure
            };

            return Response<ConnectionDetailsResponseDto>.Ok(dto);
        }
    }
}
