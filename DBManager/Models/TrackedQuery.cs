using DBManager.Dto.Engines;
using System;
using System.Collections.Generic;
using System.Data;

namespace DBManager.Models
{
    public class TrackedQuery
    {
        public string Name { get; set; }
        public string DatabaseName { get; set; }
        public string Query { get; set; }
        public uint TimePeriod { get; set; }
        public List<QuerySnapshot> QuerySnapshots { get; set; }

        public TrackedQuery()
        {
            QuerySnapshots = new List<QuerySnapshot>();
        }

        public static TrackedQuery FromDto(NewTrackedQueryDto dto)
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

    public class QuerySnapshot
    {
        public DataTable Data;
        public DateTime? Updated { get; set; }
    }
}
