using System.Collections.Generic;
using System.Text;

namespace DBManager.Utils
{
    public static class HardcodedQuery
    {
        public static string Select(string tableName, List<string> columns)
        {
            var queryStringBuilder = new StringBuilder();

            queryStringBuilder.Append("SELECT\r\n");

            foreach (var column in columns)
            {
                queryStringBuilder.Append($"{column}, ");
            }

            queryStringBuilder.Remove(queryStringBuilder.Length - 2, 2);
            queryStringBuilder.Append(" ");

            queryStringBuilder.Append("\r\nFROM ");
            queryStringBuilder.Append($"{tableName};");

            return queryStringBuilder.ToString();
        }

        public static string InsertInto(string tableName, List<string> columns)
        {
            var queryStringBuilder = new StringBuilder();

            queryStringBuilder.Append($"INSERT INTO {tableName}\r\n");
            queryStringBuilder.Append("(");

            foreach (var column in columns)
            {
                queryStringBuilder.Append($"{column}, ");
            }

            queryStringBuilder.Remove(queryStringBuilder.Length - 2, 2);
            queryStringBuilder.Append(" )");

            queryStringBuilder.Append("\r\nVALUES\r\n");
            queryStringBuilder.Append("(");

            for (int i = 0; i < columns.Count; i++)
            {
                queryStringBuilder.Append($"expression{i}, ");
            }

            queryStringBuilder.Remove(queryStringBuilder.Length - 2, 2);
            queryStringBuilder.Append(" );");

            return queryStringBuilder.ToString();
        }

        public static string Delete(string tableName)
        {
            var queryStringBuilder = new StringBuilder();

            queryStringBuilder.Append($"DELETE FROM {tableName}\r\n");
            queryStringBuilder.Append("WHERE condition;");

            return queryStringBuilder.ToString();
        }

        public static string Update(string tableName, List<string> columns)
        {
            var queryStringBuilder = new StringBuilder();

            queryStringBuilder.Append($"UPDATE {tableName} SET \r\n");

            for (int i = 0; i < columns.Count; i++)
            {
                queryStringBuilder.Append($"{columns[i]} = value{i}, ");
            }

            queryStringBuilder.Remove(queryStringBuilder.Length - 2, 2);
            queryStringBuilder.Append(" ");

            queryStringBuilder.Append("\r\nWHERE condition;");

            return queryStringBuilder.ToString();
        }
    }
}
