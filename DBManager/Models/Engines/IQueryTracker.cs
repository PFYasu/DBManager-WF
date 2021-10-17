using System.Collections.Generic;

namespace DBManager.Models.Engines
{
    public interface IQueryTracker
    {
        List<string> GetTrackedQueryNames(string databaseName);
        void AddTrackedQuery(TrackedQuery trackedQuery);
        void RemoveTrackedQuery(string name, string databaseName);
        TrackedQuery GetTrackedQuery(string name, string databaseName);
    }
}
