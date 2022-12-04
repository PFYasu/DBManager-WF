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

        private uint _minutesAfterStart = 0;

        public QueryTrackerDriver(IEngineModel model)
        {
            _model = model;
            _timer = new Timer(
               new TimerCallback(OnUpdateRequest),
               null,
               Constants.QueryTracker.RefreshTimePeriod,
               Constants.QueryTracker.RefreshTimePeriod);
        }

        public Response<TrackedQueriesDetailsResponseDto> GetTrackedQueriesDetails(string databaseName)
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
                    TimePeriod = trackedQuery.TimePeriod,
                    SnapshotsCount = trackedQuery.QuerySnapshots.Count
                };

                trackedQueriesDetails.Add(trackedQueryDetails);
            }

            var dto = new TrackedQueriesDetailsResponseDto { TrackedQueriesDetails = trackedQueriesDetails };

            return Response<TrackedQueriesDetailsResponseDto>.Ok(dto);
        }

        public Response<TrackedQuerySnapshotsDetailsResponseDto> GetTrackedQuerySnapshotsDetails(string trackedQueryName, string databaseName)
        {
            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .SingleOrDefault(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            if (trackedQuery == null)
                return Response<TrackedQuerySnapshotsDetailsResponseDto>
                    .Error($"Tracked query with {trackedQueryName} name does not exist");

            var snapshotNames = trackedQuery.QuerySnapshots
                .Select(x => x.Updated.ToString())
                .ToList();

            var timePeriod = trackedQuery.TimePeriod;

            var dto = new TrackedQuerySnapshotsDetailsResponseDto
            {
                SnapshotNames = snapshotNames,
                TimePeriod = timePeriod
            };

            return Response<TrackedQuerySnapshotsDetailsResponseDto>.Ok(dto);
        }

        public Response<TrackedQuerySnapshotResponseDto> GetSnapshot(string snapshotName, string trackedQueryName, string databaseName)
        {
            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .SingleOrDefault(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            if (trackedQuery == null)
                return Response<TrackedQuerySnapshotResponseDto>
                    .Error($"Tracked query with {trackedQueryName} name does not exist");

            var snapshot = trackedQuery.QuerySnapshots
                .SingleOrDefault(x => x.Updated.ToString() == snapshotName);

            if (snapshot == null)
                return Response<TrackedQuerySnapshotResponseDto>
                    .Error($"Snapshot {snapshotName} in {trackedQueryName} does not exist");

            var updated = snapshot.Updated;
            var data = snapshot.Data;

            var dto = new TrackedQuerySnapshotResponseDto
            {
                Updated = updated,
                Data = data
            };

            return Response<TrackedQuerySnapshotResponseDto>.Ok(dto);
        }

        public Response<TrackedQuerySnapshotDifferencesResponseDto> GetSnapshotDifferences(TrackedQuerySnapshotDifferencesDto dto)
        {
            var firstSnapshotName = dto.FirstSnapshotName;
            var secondSnapshotName = dto.SecondSnapshotName;
            var trackedQueryName = dto.TrackedQueryName;
            var databaseName = dto.DatabaseName;

            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .SingleOrDefault(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            if (trackedQuery == null)
                return Response<TrackedQuerySnapshotDifferencesResponseDto>
                    .Error($"Tracked query with {trackedQueryName} name does not exist");

            var firstSnapshot = trackedQuery.QuerySnapshots
                .SingleOrDefault(x => x.Updated.ToString() == firstSnapshotName);

            if (firstSnapshot == null)
                return Response<TrackedQuerySnapshotDifferencesResponseDto>
                    .Error($"Snapshot {firstSnapshotName} in {trackedQueryName} does not exist");

            var secondSnapshot = trackedQuery.QuerySnapshots
                .SingleOrDefault(x => x.Updated.ToString() == secondSnapshotName);

            if (secondSnapshot == null)
                return Response<TrackedQuerySnapshotDifferencesResponseDto>
                    .Error($"Snapshot {secondSnapshotName} in {trackedQueryName} does not exist");

            var firstSnapshotData = firstSnapshot.Data;
            var secondSnapshotData = secondSnapshot.Data;

            DataTable snapshotDifferencesResult;

            try
            {
                snapshotDifferencesResult = _model.QueryTrackerDriverModel.GetDataTableDifferences(firstSnapshotData, secondSnapshotData);
            }
            catch (Exception exception)
            {
                return Response<TrackedQuerySnapshotDifferencesResponseDto>.Error(exception.Message);
            }

            var differentRows = snapshotDifferencesResult.Rows.Count;

            var responseDto = new TrackedQuerySnapshotDifferencesResponseDto
            {
                Differences = snapshotDifferencesResult,
                DifferentRows = differentRows
            };

            return Response<TrackedQuerySnapshotDifferencesResponseDto>.Ok(responseDto);
        }

        public Response<TrackedQueryPreviewResponseDto> GetPreview(string trackedQueryName, string databaseName)
        {
            var trackedQuery = _model.QueryTrackerDriverModel.TrackedQueries
                .SingleOrDefault(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            if (trackedQuery == null)
                return Response<TrackedQueryPreviewResponseDto>
                    .Error($"Tracked query with {trackedQueryName} name does not exist");

            var dto = new TrackedQueryPreviewResponseDto
            {
                QueryPreview = trackedQuery.Query
            };

            return Response<TrackedQueryPreviewResponseDto>.Ok(dto);
        }

        public Response AddTrackedQuery(NewTrackedQueryDto dto)
        {
            var exists = _model.QueryTrackerDriverModel.TrackedQueries
                .Exists(x => x.Name == dto.Name && x.DatabaseName == dto.DatabaseName);

            if (exists)
                return Response.Error($"Tracked query with {dto.Name} name already exists");

            var trackedQuery = TrackedQuery.FromDto(dto);

            _model.QueryTrackerDriverModel.TrackedQueries.Add(trackedQuery);

            return Response.Ok();
        }

        public Response RemoveTrackedQuery(string trackedQueryName, string databaseName)
        {
            var numberOfDeletedElements = _model.QueryTrackerDriverModel.TrackedQueries
                .RemoveAll(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

            if (numberOfDeletedElements == 0)
                return Response.Error($"Tracked query with {trackedQueryName} name does not exist");

            if (numberOfDeletedElements > 1)
                throw new InvalidOperationException($"Removed more than one tracked query: {numberOfDeletedElements}.");

            return Response.Ok();
        }

        private async void OnUpdateRequest(object state)
        {
            _minutesAfterStart++;

            var trackedQueries = _model.QueryTrackerDriverModel.TrackedQueries;

            foreach (var trackedQuery in trackedQueries)
            {
                if (_minutesAfterStart % trackedQuery.TimePeriod == 0)
                {
                    try
                    {
                        var executeQueryResult = await _model.ExecuteQuery(trackedQuery.Query, trackedQuery.DatabaseName);
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