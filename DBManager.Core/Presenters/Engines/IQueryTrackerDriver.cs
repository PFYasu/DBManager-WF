using DBManager.Core.Dto.Engines;

namespace DBManager.Core.Presenters.Engines
{
    public interface IQueryTrackerDriver
    {
        Response GetTrackedQueriesDetails(string databaseName);
        Response GetTrackedQuerySnapshotsDetails(string trackedQueryName, string databaseName);
        Response GetSnapshot(string snapshotName, string trackedQueryName, string databaseName);
        Response GetSnapshotDifferences(TrackedQuerySnapshotDifferencesDto dto);
        Response AddTrackedQuery(NewTrackedQueryDto dto);
        Response RemoveTrackedQuery(string trackedQueryName, string databaseName);
    }
}