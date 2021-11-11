using DBManager.Dto.Engines;

namespace DBManager.Presenters.Engines
{
    public abstract class QueryTrackerDriverBase : PresenterBase
    {
        public abstract Response GetTrackedQueriesDetails(string databaseName);
        public abstract Response GetTrackedQuerySnapshotsDetails(string trackedQueryName, string databaseName);
        public abstract Response GetSnapshot(string snapshotName, string trackedQueryName, string databaseName);
        public abstract Response GetSnapshotDifferences(string firstSnapshotName, string secondSnapshotName, string trackedQueryName, string databaseName);
        public abstract Response AddTrackedQuery(NewTrackedQueryDto dto);
        public abstract Response RemoveTrackedQuery(string trackedQueryName, string databaseName);
    }
}