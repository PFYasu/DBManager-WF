using DBManager.Core.Dto.Engines;

namespace DBManager.Core.Presenters.Engines
{
    public interface IQueryTrackerDriver
    {
        Response<TrackedQueriesDetailsResponseDto> GetTrackedQueriesDetails(string databaseName);
        Response<TrackedQuerySnapshotsDetailsResponseDto> GetTrackedQuerySnapshotsDetails(string trackedQueryName, string databaseName);
        Response<TrackedQuerySnapshotResponseDto> GetSnapshot(string snapshotName, string trackedQueryName, string databaseName);
        Response<TrackedQuerySnapshotDifferencesResponseDto> GetSnapshotDifferences(TrackedQuerySnapshotDifferencesDto dto);
        Response AddTrackedQuery(NewTrackedQueryDto dto);
        Response RemoveTrackedQuery(string trackedQueryName, string databaseName);
    }
}