using DBManager.Models;
using DBManager.Models.Engines;
using System;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace DBManager.Tests.ModelsTests.QueryTrackerDriverModelTests
{
    public class TryApplyNewSnapshotTests
    {
        [Fact]
        public void ForDifferentNewDataTable_ShouldAddNewSnapshotToTrackedQuery()
        {
            var trackedQueries = new List<TrackedQuery>();
            var model = new QueryTrackerDriverModel(trackedQueries);

            string[] rowForExistingDataTable = { "Kujawsko-Pomorskie", "Torun" };
            string[] rowForNewDataTable = { "Lodzkie", "Lodz" };

            var existingDataTable = SomeDataTable_WithoutRows();
            var newDataTable = SomeDataTable_WithoutRows();

            existingDataTable.Rows.Add(rowForExistingDataTable);
            newDataTable.Rows.Add(rowForNewDataTable);

            var existingQuerySnapshot = new QuerySnapshot
            {
                Data = existingDataTable,
                Updated = SomeDateTime
            };

            var trackedQuery = SomeTrackedQuery_WithEmptyQuerySnapshotList;
            trackedQuery.QuerySnapshots.Add(existingQuerySnapshot);

            trackedQueries.Add(trackedQuery);


            Act(model, trackedQuery, newDataTable);


            Assert.Single(model.TrackedQueries);
            Assert.Equal(2, model.TrackedQueries[0].QuerySnapshots.Count);

            var lastQuerySnapshot = model.TrackedQueries[0].QuerySnapshots[1];
            AssertDataTableEquality(newDataTable, lastQuerySnapshot.Data);
        }

        [Fact]
        public void ForEqualNewDataTable_ToPreviousDataTable_ShouldNotAddNewQuerySnapshotToTrackedQuery()
        {
            var trackedQueries = new List<TrackedQuery>();
            var model = new QueryTrackerDriverModel(trackedQueries);

            string[] dataTableRow = { "Kujawsko-Pomorskie", "Torun" };

            var existingDataTable = SomeDataTable_WithoutRows();
            var newDataTable = SomeDataTable_WithoutRows();

            existingDataTable.Rows.Add(dataTableRow);
            newDataTable.Rows.Add(dataTableRow);

            var existingQuerySnapshot = new QuerySnapshot
            {
                Data = existingDataTable,
                Updated = SomeDateTime
            };

            var trackedQuery = SomeTrackedQuery_WithEmptyQuerySnapshotList;
            trackedQuery.QuerySnapshots.Add(existingQuerySnapshot);

            trackedQueries.Add(trackedQuery);


            Act(model, trackedQuery, newDataTable);


            Assert.Single(model.TrackedQueries);
            Assert.Single(model.TrackedQueries[0].QuerySnapshots);
        }


        private DateTime SomeDateTime => new DateTime(2015, 10, 10, 0, 0, 0, DateTimeKind.Utc);

        private TrackedQuery SomeTrackedQuery_WithEmptyQuerySnapshotList => new TrackedQuery
        {
            DatabaseName = "dbName",
            Name = "trackedQueryName",
            Query = "select * from dbTable",
            TimePeriod = 1
        };

        private DataTable SomeDataTable_WithoutRows()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("voivodeship", typeof(string));
            dataTable.Columns.Add("city", typeof(string));

            return dataTable;
        }


        private void Act(QueryTrackerDriverModel model, TrackedQuery trackedQuery, DataTable dataTable)
        {
            model.TryApplyNewSnapshot(trackedQuery, dataTable, skipDataNormalization: true);
        }


        private void AssertDataTableEquality(DataTable first, DataTable second)
        {
            Assert.Equal(first.Columns.Count, second.Columns.Count);
            Assert.Equal(first.Rows.Count, second.Rows.Count);

            for (int i = 0; i < first.Rows.Count; i++)
            {
                Assert.Equal(first.Rows[i], second.Rows[i]);
            }
        }
    }
}
