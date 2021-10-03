using System.Text.RegularExpressions;

namespace DBManager.Utils
{
    public static class QueryHelper
    {
        private static readonly Regex _regex;

        static QueryHelper()
        {
            _regex = new Regex("^(?i)select (.*?)(?i)from ");
        }

        public static QueryType GetQueryType(string query)
        {
            var match = _regex.Match(query);

            if (match.Success)
                return QueryType.Query;

            return QueryType.NonQuery;
        }
    }
}
