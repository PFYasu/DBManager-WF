using DBManager.Dto.Engines;
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

        public TrackedQuery()
        {
            ActualQueryResult = new QueryResult();
            PreviousQueryResult = new QueryResult();
        }

        public static TrackedQuery FromModel(NewTrackedQueryDto dto)
        {
            return new TrackedQuery
            {
                Name = dto.Name,
                DatabaseName = dto.DatabaseName,
                Query = dto.Query,
                TimePeriod = dto.TimePeriod,
            };
        }
    }

    public class QueryResult
    {
        public DataTable DataTableResult { get; set; }
        public DateTime? Updated { get; set; }
    }
}
