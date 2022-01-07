using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Models.Engines;
using DBManager.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;

namespace DBManager.Core.Presenters.Engines
{
    public class QueryTrackerDriver : IQueryTrackerDriver
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

        public Response GetTrackedQueriesDetails(string databaseName)
        {
            var trackedQueries = _model.QueryTrackerDriverModel.TrackedQueries
                .Where(x => x.DatabaseName == databaseName)
                .ToList();

            var trackedQueriesDetails = new List<TrackedQueryDetails>();

            foreach (var trackedQuery in trackedQueries)
            {
                var trackedQueryDetails = new TrackedQueryDetails
                {
                    Name = trackedQuery.Name,
                    TimePeriod = trackedQuery.TimePeriod
                };

                trackedQueriesDetails.Add(trackedQueryDetails);
            }

            var dto = new TrackedQueriesDetailsResponseDto { TrackedQueriesDetails = trackedQueriesDetails };

            return Response.Ok(dto);
        }

        public Response GetTrackedQuerySnapshotsDetails(string trackedQueryName, string databaseName)
        {
            if (TrackedQueryExists(trackedQueryName, databaseName) == false)
                return Response.Error($"Tracked query with {trackedQueryName} name does not exist");

            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .Single(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            var snapshotNames = trackedQuery.QuerySnapshots
                .Select(x => x.Updated.ToString())
                .ToList();

            var timePeriod = trackedQuery.TimePeriod;

            var dto = new TrackedQuerySnapshotsDetailsResponseDto
            {
                SnapshotNames = snapshotNames,
                TimePeriod = timePeriod
            };

            return Response.Ok(dto);
        }

        public Response GetSnapshot(string snapshotName, string trackedQueryName, string databaseName)
        {
            if (TrackedQueryExists(trackedQueryName, databaseName) == false)
                return Response.Error($"Tracked query with {trackedQueryName} name does not exist");

            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .Single(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            var snapshot = trackedQuery.QuerySnapshots
                .SingleOrDefault(x => x.Updated.ToString() == snapshotName);

            if (snapshot == null)
                return Response.Error($"Snapshot {snapshotName} in {trackedQueryName} does not exist");

            var updated = snapshot.Updated;
            var data = snapshot.Data;

            var dto = new TrackedQuerySnapshotResponseDto
            {
                Updated = updated,
                Data = data
            };

            return Response.Ok(dto);
        }

        public Response GetSnapshotDifferences(TrackedQuerySnapshotDifferencesDto dto)
        {
            var firstSnapshotName = dto.FirstSnapshotName;
            var secondSnapshotName = dto.SecondSnapshotName;
            var trackedQueryName = dto.TrackedQueryName;
            var databaseName = dto.DatabaseName;

            if (TrackedQueryExists(trackedQueryName, databaseName) == false)
                return Response.Error($"Tracked query with {trackedQueryName} name does not exist");

            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .Single(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            var firstSnapshot = trackedQuery.QuerySnapshots
                .SingleOrDefault(x => x.Updated.ToString() == firstSnapshotName);

            if (firstSnapshot == null)
                return Response.Error($"Snapshot {firstSnapshotName} in {trackedQueryName} does not exist");

            var secondSnapshot = trackedQuery.QuerySnapshots
                .SingleOrDefault(x => x.Updated.ToString() == secondSnapshotName);

            if (secondSnapshot == null)
                return Response.Error($"Snapshot {secondSnapshotName} in {trackedQueryName} does not exist");

            var firstSnapshotData = firstSnapshot.Data;
            var secondSnapshotData = secondSnapshot.Data;

            DataTable snapshotDifferencesResult;

            try
            {
                snapshotDifferencesResult = _model.QueryTrackerDriverModel.GetDataTableDifferences(firstSnapshotData, secondSnapshotData);
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }

            var differentRows = snapshotDifferencesResult.Rows.Count;

            var responseDto = new TrackedQuerySnapshotDifferencesResponseDto
            {
                Differences = snapshotDifferencesResult,
                DifferentRows = differentRows
            };

            return Response.Ok(responseDto);
        }

        public Response AddTrackedQuery(NewTrackedQueryDto dto)
        {
            if (TrackedQueryExists(dto.Name, dto.DatabaseName))
                return Response.Error($"Tracked query with {dto.Name} name already exists");

            var trackedQuery = TrackedQuery.FromDto(dto);

            _model.QueryTrackerDriverModel.TrackedQueries
                .Add(trackedQuery);

            return Response.Ok();
        }

        public Response RemoveTrackedQuery(string trackedQueryName, string databaseName)
        {
            if (TrackedQueryExists(trackedQueryName, databaseName) == false)
                return Response.Error($"Tracked query with {trackedQueryName} name does not exist");

            var result = _model.QueryTrackerDriverModel.TrackedQueries
                .RemoveAll(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            if (result != 1)
                throw new InvalidOperationException("Removed more than one tracked query.");

            return Response.Ok();
        }

        private bool TrackedQueryExists(string name, string databaseName)
        {
            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .Where(x => x.Name == name && x.DatabaseName == databaseName)
                .SingleOrDefault();

            return trackedQuery != null;
        }

        private async void OnUpdateRequest(object state)
        {
            _minutesAfterStart++;

            var trackedQueries = _model.QueryTrackerDriverModel.TrackedQueries;

            foreach (var trackedQuery in trackedQueries)
            {
                if (_minutesAfterStart % trackedQuery.TimePeriod == 0)
                {
                    DataTable executeQueryResult;

                    try
                    {
                        executeQueryResult = await _model.ExecuteQuery(trackedQuery.Query, trackedQuery.DatabaseName);
                        _model.QueryTrackerDriverModel.TryApplyNewSnapshot(trackedQuery, executeQueryResult);
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}