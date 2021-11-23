using System.Text.RegularExpressions;

namespace DBManager.Core.Utils
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
}
