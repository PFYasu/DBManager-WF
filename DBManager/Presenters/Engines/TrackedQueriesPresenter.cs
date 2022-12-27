using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using System.Collections.Generic;
using System.Data;
using System;
using DBManager.Utils.Files;
using System.Linq;
using DBManager.Utils;

namespace DBManager.Presenters.Engines;

public interface ITrackedQueriesPresenter
{
    Response<TrackedQueriesDetailsResponseDto> GetTrackedQueriesDetails(string connectionName, string databaseName);
    Response<TrackedQuerySnapshotsDetailsResponseDto> GetTrackedQuerySnapshotsDetails(string connectionName, string databaseName, string trackedQueryName);
    Response<TrackedQuerySnapshotResponseDto> GetSnapshot(string connectionName, string databaseName, string snapshotName, string trackedQueryName);
    Response<TrackedQuerySnapshotDifferencesResponseDto> GetSnapshotDifferences(TrackedQuerySnapshotDifferencesDto dto);
    Response<TrackedQueryPreviewResponseDto> GetPreview(string connectionName, string databaseName, string trackedQueryName);
    Response RemoveTrackedQuery(string connectionname, string databaseName, string trackedQueryName);
}

public class TrackedQueriesPresenter : ITrackedQueriesPresenter
{
    private readonly IFileManager _fileManager;

    public TrackedQueriesPresenter(IFileManager fileManager)
    {
        _fileManager = fileManager;
    }

    public Response<TrackedQueriesDetailsResponseDto> GetTrackedQueriesDetails(string connectionName, string databaseName)
    {
        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response<TrackedQueriesDetailsResponseDto>.Error(
                $"Connection {connectionName} does not exist.");

        var trackedQueries = connection.TrackedQueries
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

    public Response<TrackedQuerySnapshotsDetailsResponseDto> GetTrackedQuerySnapshotsDetails(
        string connectionName, string databaseName, string trackedQueryName)
    {
        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response<TrackedQuerySnapshotsDetailsResponseDto>.Error(
                $"Connection {connectionName} does not exist.");

        var trackedQuery = connection.TrackedQueries
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

    public Response<TrackedQuerySnapshotResponseDto> GetSnapshot(string connectionName, string databaseName, string snapshotName, string trackedQueryName)
    {
        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response<TrackedQuerySnapshotResponseDto>.Error(
                $"Connection {connectionName} does not exist.");

        var trackedQuery = connection.TrackedQueries
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
        var connectionName = dto.ConnectionName;
        var databaseName = dto.DatabaseName;

        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response<TrackedQuerySnapshotDifferencesResponseDto>.Error(
                $"Connection {connectionName} does not exist.");

        var trackedQuery = connection.TrackedQueries
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
            snapshotDifferencesResult = TrackedQueriesUtils.GetDataTableDifferences(firstSnapshotData, secondSnapshotData);
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

    public Response<TrackedQueryPreviewResponseDto> GetPreview(string connectionName, string databaseName, string trackedQueryName)
    {
        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response<TrackedQueryPreviewResponseDto>.Error(
                $"Connection {connectionName} does not exist.");

        var trackedQuery = connection.TrackedQueries
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

    public Response RemoveTrackedQuery(string connectionName, string databaseName, string trackedQueryName)
    {
        var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

        if (connection == null)
            return Response.Error($"Connection {connectionName} does not exist.");

        var numberOfDeletedElements = connection.TrackedQueries
            .RemoveAll(x => x.Name == trackedQueryName && x.DatabaseName == databaseName);

        if (numberOfDeletedElements == 0)
            return Response.Error($"Tracked query with {trackedQueryName} name does not exist");

        if (numberOfDeletedElements > 1)
            throw new InvalidOperationException($"Removed more than one tracked query: {numberOfDeletedElements}.");

        _fileManager.Save(connection, Router.ToConnection(connection.Name));

        return Response.Ok();
    }
}
