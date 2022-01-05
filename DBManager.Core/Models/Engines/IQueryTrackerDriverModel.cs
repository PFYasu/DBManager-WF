using System.Collections.Generic;
using System.Data;

namespace DBManager.Core.Models.Engines
{
    public interface IQueryTrackerDriverModel
    {
        List<TrackedQuery> TrackedQueries { get; }
        DataTable GetDataTableDifferences(DataTable first, DataTable second);
        void TryApplyNewSnapshot(TrackedQuery trackedQuery, DataTable dataTable);
    }
}
