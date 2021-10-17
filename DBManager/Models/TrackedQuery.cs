using System;
using System.Data;

namespace DBManager.Models
{
    public class TrackedQuery
    {
        public string Name { get; set; }
        public string DatabaseName { get; set; }
        public string Query { get; set; }
        public uint TimePeriod { get; set; }
        public QueryResult ActualQueryResult { get; set; }
        public QueryResult PreviousQueryResult { get; set; }

        public TrackedQuery(string name, string databaseName, string query, uint timePeriod)
        {
            Name = name;
            DatabaseName = databaseName;
            Query = query;
            TimePeriod = timePeriod;

            ActualQueryResult = new QueryResult();
            PreviousQueryResult = new QueryResult();
        }
    }

    public class QueryResult
    {
        public DataTable DataTableResult { get; set; }
        public DateTime? Updated { get; set; }
    }
}
