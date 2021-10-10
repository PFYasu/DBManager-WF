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
    public class PostgreSQLPresenter : EnginePresenterBase
    {
        private readonly IEngineModel _model;
        private readonly DBManagerPresenterBase _dbManagerPresenter;

        public PostgreSQLPresenter(IEngineModel model, DBManagerPresenterBase dbManagerPresenter)
        {
            _model = model;
            _dbManagerPresenter = dbManagerPresenter;
        }

        public override string ConnectionName => _model.Name;
        public override EngineType EngineType => _model.Type;

        public override async Task<Response> GetDatabaseNames()
        {
            const string query = "SELECT datname FROM pg_database WHERE datistemplate = false;";
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
                .Select(x => x.Field<string>("datname"))
                .ToList();

            return Ok(dto);
        }

        public override async Task<Response> GetTableNames(string databaseName)
        {
            string query =
                $"SELECT " +
                    $"table_name " +
                $"FROM information_schema.tables " +
                $"WHERE table_schema = 'public' " +
                $"ORDER BY table_name;";
            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query, databaseName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var names = result
                .AsEnumerable()
                .Select(x => x.TryConvertTo<string>("table_name"))
                .ToList();

            var dto = new TableNamesResponseDto { Names = names };

            return Ok(dto);
        }

        public override async Task<Response> SendQuery(string databaseName, string query)
        {
            var queryType = QueryHelper.QueryTypeResolver.GetQueryType(query);
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
                        return Error("Invalid query type.");
                }
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new QueryResponseDto
            {
                Type = queryType,
                Table = result
            };

            return Ok(dto);
        }

        public override async Task<Response> GetTableDetails(string databaseName, string tableName)
        {
            var tableSizeQuery = $"SELECT pg_total_relation_size('{tableName}') AS SIZE;";
            DataTable tableSizeQueryResult;

            var fullTableQuery = $"SELECT * FROM {tableName}";
            DataTable fullTableQueryResult;

            var columnsQuery =
                $"SELECT " +
                    $"column_name, " +
                    $"data_type, " +
                    $"collation_name " +
                $"FROM information_schema.columns " +
                $"WHERE table_name = '{tableName}' AND table_catalog = '{databaseName}';";
            DataTable columnsQueryResult;

            try
            {
                tableSizeQueryResult = await _model.ExecuteQuery(tableSizeQuery, databaseName);
                fullTableQueryResult = await _model.ExecuteQuery(fullTableQuery, databaseName);
                columnsQueryResult = await _model.ExecuteQuery(columnsQuery, databaseName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var table = fullTableQueryResult;
            var rowsCount = fullTableQueryResult.Rows.Count;

            var columnsCount = columnsQueryResult.Rows.Count;
            var sizeInt64Format = tableSizeQueryResult.Rows[0].TryConvertTo<Int64>("SIZE");
            var size = (decimal)(sizeInt64Format * 0.001);

            var columnsStructure = new List<ColumnStructure>();

            foreach (DataRow row in columnsQueryResult.Rows)
            {
                var name = row.TryConvertTo<string>("column_name");
                var type = row.TryConvertTo<string>("data_type");
                var comparingSubtitlesMethod = row.TryConvertTo<string>("collation_name");

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
                CreatedAt = null,
                LastUpdate = null
            };

            return Ok(dto);
        }

        public override async Task<Response> GetDatabaseDetails(string databaseName)
        {
            var tableQuery =
                $"SELECT " +
                    $"table_name, " +
                    $"table_type, " +
                    $"pg_total_relation_size(\'\"\'||table_schema||\'\".\"\'||table_name||\'\"\') AS SIZE " +
                $"FROM information_schema.tables " +
                $"WHERE table_catalog = '{databaseName}' AND table_schema = 'public';";
            DataTable tableQueryResult;

            var tableSizeQuery =
                $"SELECT " +
                    $"relname as name, " +
                    $"n_live_tup as rows " +
                $"FROM pg_stat_user_tables";
            DataTable tableSizeQueryResult;

            try
            {
                tableQueryResult = await _model.ExecuteQuery(tableQuery, databaseName);
                tableSizeQueryResult = await _model.ExecuteQuery(tableSizeQuery, databaseName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var tablesAndRowsCount = new Dictionary<string, ulong>();

            foreach (DataRow row in tableSizeQueryResult.Rows)
            {
                var name = row.TryConvertTo<string>("name");

                var rowsInt64 = row.TryConvertTo<Int64>("rows");
                var rows = (ulong)rowsInt64;

                tablesAndRowsCount.Add(name, rows);
            }

            var tablesStructure = new List<TableStructure>();

            foreach (DataRow row in tableQueryResult.Rows)
            {
                var name = row.TryConvertTo<string>("table_name");
                var type = row.TryConvertTo<string>("table_type");
                var records = tablesAndRowsCount[name];

                var sizeInt64Format = row.TryConvertTo<Int64>("SIZE");
                var size = (decimal)(sizeInt64Format * 0.001);

                var columnStructure = new TableStructure
                {
                    Name = name,
                    Type = type,
                    Records = records,
                    Size = size,
                    ComparingSubtitlesMethod = null
                };

                tablesStructure.Add(columnStructure);
            }

            var tablesCount = tablesStructure.Count;

            var dto = new DatabaseDetailsResponseDto
            {
                TablesCount = tablesCount,
                TablesStructure = tablesStructure
            };

            return Ok(dto);
        }

        public override async Task<Response> GetDatabaseTableColumns(string databaseName)
        {
            string query =
                $"SELECT " +
                    $"table_name, " +
                    $"column_name " +
                $"FROM information_schema.columns " +
                $"WHERE table_catalog = '{databaseName}' AND table_schema = 'public';";
            DataTable result;

            try
            {
                result = await _model.ExecuteQuery(query, databaseName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var databaseTableColumns = new Dictionary<string, List<string>>();

            foreach (DataRow row in result.Rows)
            {
                var tableName = row.TryConvertTo<string>("table_name");
                var columnName = row.TryConvertTo<string>("column_name");

                if (databaseTableColumns.ContainsKey(tableName) == false)
                    databaseTableColumns.Add(tableName, new List<string>());

                databaseTableColumns[tableName].Add(columnName);
            }

            var dto = new DatabaseTableColumnsResponseDto
            {
                DatabaseTableColumns = databaseTableColumns
            };

            return Ok(dto);
        }

        public override async Task<Response> GetConnectionDetails()
        {
            string query = "SELECT datname FROM pg_database WHERE datistemplate = false;";
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
                var databaseName = row.TryConvertTo<string>("datname");

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
