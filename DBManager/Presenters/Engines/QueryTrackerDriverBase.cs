using DBManager.Dto.Engines;

namespace DBManager.Presenters.Engines
{
    public abstract class QueryTrackerDriverBase : PresenterBase
    {
        public abstract Response GetTrackedQueryNames(string databaseName);
        public abstract Response AddTrackedQuery(NewTrackedQueryDto dto);
        public abstract Response RemoveTrackedQuery(string name, string databaseName);
        public abstract Response GetTrackedQuery(string name, string databaseName);
    }
}
