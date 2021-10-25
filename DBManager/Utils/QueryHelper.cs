using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DBManager.Utils
{
    public static class QueryHelper
    {
        public static class QueryTypeResolver
        {
            private static readonly Regex _regex;

            static QueryTypeResolver()
            {
                _regex = new Regex("^(?i)select (.*?)(?i)from ");
            }

            public static QueryType GetQueryType(string query)
            {
                query = query.Replace("\n", " ");

                var match = _regex.Match(query);

                if (match.Success)
                    return QueryType.Query;

                return QueryType.NonQuery;
            }
        }

        public static class HardcodedQuery
        {
            public static string Select(string tableName, List<string> columns)
            {
                var query = "";

                query += "SELECT\r\n";

                foreach (var column in columns)
                {
                    query += $"{column}, ";
                }
                query = query.RemoveLastCharacters(2) + " ";

                query += "\r\nFROM ";

                query += $"{tableName};";

                return query;
            }

            public static string InsertInto(string tableName, List<string> columns)
            {
                var query = "";

                query += $"INSERT INTO {tableName}\r\n";

                query += "(";
                foreach (var column in columns)
                {
                    query += $"{column}, ";
                }
                query = query.RemoveLastCharacters(2) + " ";
                query += ")";

                query += "\r\nVALUES\r\n";

                query += "(";
                for (int i = 0; i < columns.Count; i++)
                {
                    query += $"expression{i}, ";
                }
                query = query.RemoveLastCharacters(2) + " ";
                query += ");";

                return query;
            }

            public static string Delete(string tableName)
            {
                var query = "";

                query += $"DELETE FROM {tableName}\r\n";

                query += "WHERE condition;";

                return query;
            }

            public static string Update(string tableName, List<string> columns)
            {
                var query = "";

                query += $"UPDATE {tableName} SET \r\n";

                int i = 0;
                foreach (var column in columns)
                {
                    query += $"{column} = value{i++}, ";
                }
                query = query.RemoveLastCharacters(2) + " ";

                query += "\r\nWHERE condition;";

                return query;
            }
        }
    }
}
