using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DBManager.Core.Models.Engines
{
    public class QueryTrackerDriverModel : IQueryTrackerDriverModel
    {
        public QueryTrackerDriverModel(List<TrackedQuery> trackedQueries)
        {
            TrackedQueries = trackedQueries;
        }

        public List<TrackedQuery> TrackedQueries { get; }

        public DataTable GetDataTableDifferences(DataTable first, DataTable second)
        {
            var firstDifferences = first
                .AsEnumerable()
                .Except(second.AsEnumerable(), DataRowComparer.Default);

            var secondDifferences = second
                .AsEnumerable()
                .Except(first.AsEnumerable(), DataRowComparer.Default);

            DataTable differencesResult;

            if (firstDifferences.Count() == 0 && secondDifferences.Count() == 0)
                differencesResult = new DataTable();

            else if (firstDifferences.Count() != 0 && secondDifferences.Count() != 0)
            {
                firstDifferences
                    .CopyToDataTable()
                    .Merge(secondDifferences.CopyToDataTable());

                differencesResult = firstDifferences.CopyToDataTable();
            }

            else if (firstDifferences.Count() == 0)
                differencesResult = secondDifferences.CopyToDataTable();

            else if (secondDifferences.Count() == 0)
                differencesResult = firstDifferences.CopyToDataTable();

            else
                throw new InvalidOperationException("Unsupported compare mode for QueryTrackerDriver");

            return differencesResult;
        }

        public void TryApplyNewSnapshot(TrackedQuery trackedQuery, DataTable dataTable)
        {
            var lastSnapshot = trackedQuery.QuerySnapshots
                        .OrderBy(x => x.Updated)
                        .LastOrDefault();

            var data = NormalizeData(dataTable);

            if (lastSnapshot != null)
            {
                var differences = GetDataTableDifferences(data, lastSnapshot.Data);

                if (differences.Rows.Count == 0)
                    return;
            }

            var updated = DateTime.Now;

            var querySnapshot = new QuerySnapshot
            {
                Data = data,
                Updated = updated
            };

            trackedQuery.QuerySnapshots.Add(querySnapshot);
        }

        private DataTable NormalizeData(DataTable dataTable)
        {
            var serialization = JsonConvert.SerializeObject(dataTable);
            var deserialization = JsonConvert.DeserializeObject<DataTable>(serialization);

            return deserialization;
        }
    }
}
