using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DBManager.Models.Engines
{
    public class QueryTracker : IQueryTracker
    {
        private readonly List<TrackedQuery> _trackedQueries;
        private readonly Func<string, string, Task<DataTable>> _executeQuery;
        private readonly Timer _timer;

        private uint _minutesAfterStart;

        public QueryTracker(
            List<TrackedQuery> trackedQueries,
            Func<string, string, Task<DataTable>> executeQuery)
        {
            _trackedQueries = trackedQueries;
            _executeQuery = executeQuery;

            _timer = new Timer(
                new TimerCallback(OnUpdateRequest),
                null,
                Constants.QueryTracker.RefreshTimePeriod,
                Constants.QueryTracker.RefreshTimePeriod);
            _minutesAfterStart = 0;
        }

        public List<string> GetTrackedQueryNames(string databaseName)
        {
            return _trackedQueries
                .Where(x => x.DatabaseName == databaseName)
                .Select(x => x.Name)
                .ToList();
        }

        public void AddTrackedQuery(TrackedQuery trackedQuery)
        {
            _trackedQueries.Add(trackedQuery);
        }

        public void RemoveTrackedQuery(string name, string databaseName)
        {
            var result = _trackedQueries
                .RemoveAll(x => x.Name == name && x.DatabaseName == databaseName);

            if (result != 1)
                throw new InvalidOperationException("Removed more than one tracked query.");
        }

        public TrackedQuery GetTrackedQuery(string name, string databaseName)
        {
            return _trackedQueries
                .Where(x => x.Name == name && x.DatabaseName == databaseName)
                .Single();
        }

        private async void OnUpdateRequest(object state)
        {
            _minutesAfterStart++;

            foreach (var trackedQuery in _trackedQueries)
            {
                if (_minutesAfterStart % trackedQuery.TimePeriod == 0)
                {
                    DataTable result = null;
                    try
                    {
                        result = await _executeQuery(trackedQuery.Query, trackedQuery.DatabaseName);
                    }
                    catch (Exception)
                    {

                    }

                    trackedQuery.PreviousQueryResult.DataTableResult = trackedQuery.ActualQueryResult.DataTableResult;
                    trackedQuery.PreviousQueryResult.Updated = trackedQuery.ActualQueryResult.Updated;

                    trackedQuery.ActualQueryResult.DataTableResult = result;
                    trackedQuery.ActualQueryResult.Updated = DateTime.Now;
                }
            }
        }
    }
}
