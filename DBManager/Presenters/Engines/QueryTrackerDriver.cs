using DBManager.Dto.Engines;
using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Utils;
using System;
using System.Data;
using System.Linq;
using System.Threading;

namespace DBManager.Presenters.Engines
{
    public class QueryTrackerDriver : QueryTrackerDriverBase
    {
        private readonly IEngineModel _model;
        private readonly Timer _timer;

        private uint _minutesAfterStart;

        public QueryTrackerDriver(IEngineModel model)
        {
            _model = model;
            _timer = new Timer(
               new TimerCallback(OnUpdateRequest),
               null,
               Constants.QueryTracker.RefreshTimePeriod,
               Constants.QueryTracker.RefreshTimePeriod);

            _minutesAfterStart = 0;
        }

        public override Response GetTrackedQueryNames(string databaseName)
        {
            var names = _model.TrackedQueries
                .Where(x => x.DatabaseName == databaseName)
                .Select(x => x.Name)
                .ToList();

            var dto = new TrackedQueryNamesResponseDto { Names = names };

            return Ok(dto);
        }

        public override Response AddTrackedQuery(NewTrackedQueryDto dto)
        {
            if (TrackedQueryExists(dto.Name, dto.DatabaseName))
                return Error($"Tracked query with {dto.Name} name already exists");

            var trackedQuery = TrackedQuery.FromModel(dto);

            _model.TrackedQueries.Add(trackedQuery);

            return Ok();
        }

        public override Response RemoveTrackedQuery(string name, string databaseName)
        {
            if (TrackedQueryExists(name, databaseName) == false)
                return Error($"Tracked query with {name} name does not exist");

            var result = _model.TrackedQueries
                .RemoveAll(x => x.Name == name && x.DatabaseName == databaseName);

            if (result != 1)
                return Error("Removed more than one tracked query.");

            return Ok();
        }

        public override Response GetTrackedQuery(string name, string databaseName)
        {
            if (TrackedQueryExists(name, databaseName) == false)
                return Error($"Tracked query with {name} name does not exist");

            var result = _model.TrackedQueries
                .Where(x => x.Name == name && x.DatabaseName == databaseName)
                .Single();

            var dto = new TrackedQueryResponseDto
            {
                TrackedQuery = result
            };

            return Ok(dto);
        }

        private bool TrackedQueryExists(string name, string databaseName)
        {
            var names = _model.TrackedQueries
                .Where(x => x.DatabaseName == databaseName)
                .Select(x => x.Name)
                .ToList();

            return names.Contains(name);
        }

        private async void OnUpdateRequest(object state)
        {
            _minutesAfterStart++;

            foreach (var trackedQuery in _model.TrackedQueries)
            {
                if (_minutesAfterStart % trackedQuery.TimePeriod == 0)
                {
                    DataTable result = null;
                    try
                    {
                        result = await _model.ExecuteQuery(trackedQuery.Query, trackedQuery.DatabaseName);
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
