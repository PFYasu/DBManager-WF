using DBManager.Core.Dto.Engines;

namespace DBManager.Core.Presenters.Engines
{
    public interface IQueryTrackerDriver
    {
        Response GetTrackedQueriesDetails(string databaseName);
        Response GetTrackedQuerySnapshotsDetails(string trackedQueryName, string databaseName);
        Response GetSnapshot(string snapshotName, string trackedQueryName, string databaseName);
        Response GetSnapshotDifferences(string firstSnapshotName, string secondSnapshotName, string trackedQueryName, string databaseName);
        Response AddTrackedQuery(NewTrackedQueryDto dto);
        Response RemoveTrackedQuery(string trackedQueryName, string databaseName);
    }
}