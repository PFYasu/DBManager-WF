using DBManager.Core.Models;
using DBManager.Core.Utils.Log;
using DBManager.Utils.Files;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DBManager.Utils;

public class TrackedQueriesRefresher
{
    private readonly IFileManager _fileManager;
    private readonly IEngineModuleResolver _engineModuleResolver;
    private readonly Timer _timer;

    private uint _minutesAfterStart = 0;

    public TrackedQueriesRefresher(IFileManager fileManager, IEngineModuleResolver engineModuleResolver)
    {
        _fileManager = fileManager;
        _engineModuleResolver = engineModuleResolver;

        _timer = new Timer(
            new TimerCallback(OnUpdateRequest),
            state: null,
            dueTime: 60000,
            period: 60000);
    }

    private async void OnUpdateRequest(object state)
    {
        _minutesAfterStart++;

        var connections = _fileManager.LoadMany<Connection>(Router.ToConnectionRepository());

        foreach (var connection in connections)
        {
            await UpdateConnection(connection);
        }
    }

    private async Task UpdateConnection(Connection connection)
    {
        var trackedQueries = connection.TrackedQueries;
        var model = _engineModuleResolver.CreateEngineModel(connection);

        foreach (var trackedQuery in trackedQueries)
        {
            if (_minutesAfterStart % trackedQuery.TimePeriod != 0)
                continue;

            try
            {
                var executeQueryResult = await model.ExecuteQuery(trackedQuery.Query, trackedQuery.DatabaseName);
                if (TryApplyNewSnapshot(trackedQuery, executeQueryResult, out var snapshot))
                {
                    trackedQuery.QuerySnapshots.Add(snapshot);
                    _fileManager.Save(connection, Router.ToConnection(connection.Name));
                }

                Logger.Log(
                    LogType.Information,
                    "Successfully received Tracked Query result.\n" +
                    $"Query: {trackedQuery.Query}\n" +
                    $"Database: {trackedQuery.DatabaseName}");
            }
            catch (Exception exception)
            {
                Logger.Log(
                    LogType.Error,
                    "Error updating Tracked Query.\n" +
                    $"Query: {trackedQuery.Query}\n" +
                    $"Database: {trackedQuery.DatabaseName}\n" +
                    $"Message:\n{exception.Message}");
            }
        }
    }

    private static bool TryApplyNewSnapshot(TrackedQuery trackedQuery, DataTable dataTable, out QuerySnapshot querySnapshot)
    {
        var lastSnapshot = trackedQuery.QuerySnapshots
            .OrderBy(x => x.Updated)
            .LastOrDefault();

        var data = NormalizeData(dataTable);

        if (lastSnapshot != null)
        {
            var differences = TrackedQueriesUtils.GetDataTableDifferences(data, lastSnapshot.Data);

            if (differences.Rows.Count == 0)
            {
                querySnapshot = null;
                return false;
            }
        }

        var updated = DateTime.Now;

        querySnapshot = new QuerySnapshot
        {
            Data = data,
            Updated = updated
        };

        return true;
    }

    private static DataTable NormalizeData(DataTable dataTable)
    {
        var serialization = JsonConvert.SerializeObject(dataTable);
        var deserialization = JsonConvert.DeserializeObject<DataTable>(serialization);

        return deserialization;
    }
}
