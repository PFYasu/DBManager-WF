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

namespace DBManager.EngineModule.PostgreSQL
{
    public class PostgreSQLPresenter : IEnginePresenter
    {
        private readonly IEngineModel _model;

        public PostgreSQLPresenter(IEngineModel model, DataTransferMethods dataTransferMethods)
        {
            _model = model;

            QueryTrackerDriver = new QueryTrackerDriver(_model);
            DataTransferDriver = new DataTransferDriver(dataTransferMethods);
        }

        public string ConnectionName => _model.Name;
        public string EngineType => _model.EngineType;
        public IQueryTrackerDriver QueryTrackerDriver { get; }
        public IDataTransferDriver DataTransferDriver { get; }

        public async Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames()
        {
            const string query = "SELECT datname FROM pg_database WHERE datistemplate = false;";
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
                .Select(x => x.Field<string>("datname"))
                .ToList();

            var dto = new DatabaseNamesResponseDto { Names = names };

            return Response<DatabaseNamesResponseDto>.Ok(dto);
        }

        public async Task<Response<TableNamesResponseDto>> GetTableNames(string databaseName)
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
                return Response<TableNamesResponseDto>.Error(exception.Message);
            }

            var names = result
                .AsEnumerable()
                .Select(x => x.TryConvertTo<string>("table_name"))
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
                return Response<TableDetailsResponseDto>.Error(exception.Message);
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

            var customInformations = new Dictionary<string, string>()
            {
                { "Size", size.ToString() }
            };

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
                return Response<DatabaseDetailsResponseDto>.Error(exception.Message);
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

            return Response<DatabaseDetailsResponseDto>.Ok(dto);
        }

        public async Task<Response<DatabaseTableColumnsResponseDto>> GetDatabaseTableColumns(string databaseName)
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
                return Response<DatabaseTableColumnsResponseDto>.Error(exception.Message);
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

            return Response<DatabaseTableColumnsResponseDto>.Ok(dto);
        }

        public async Task<Response<ConnectionDetailsResponseDto>> GetConnectionDetails()
        {
            string query = "SELECT datname FROM pg_database WHERE datistemplate = false;";
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
                var databaseName = row.TryConvertTo<string>("datname");

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
