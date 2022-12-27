using System.Data;
using System;
using System.Linq;

namespace DBManager.Utils;

public static class TrackedQueriesUtils
{
    public static DataTable GetDataTableDifferences(DataTable first, DataTable second)
    {
        var firstDifferences = first
            .AsEnumerable()
            .Except(second.AsEnumerable(), DataRowComparer.Default);

        var secondDifferences = second
            .AsEnumerable()
            .Except(first.AsEnumerable(), DataRowComparer.Default);

        DataTable differencesResult;

        if (firstDifferences.Any() == false && secondDifferences.Any() == false)
            differencesResult = new DataTable();

        else if (firstDifferences.Any() && secondDifferences.Any())
        {
            firstDifferences
                .CopyToDataTable()
                .Merge(secondDifferences.CopyToDataTable());

            differencesResult = firstDifferences.CopyToDataTable();
        }

        else if (firstDifferences.Any() == false)
            differencesResult = secondDifferences.CopyToDataTable();

        else if (secondDifferences.Any() == false)
            differencesResult = firstDifferences.CopyToDataTable();

        else
            throw new InvalidOperationException("Unsupported compare mode for QueryTrackerDriver");

        return differencesResult;
    }
}
