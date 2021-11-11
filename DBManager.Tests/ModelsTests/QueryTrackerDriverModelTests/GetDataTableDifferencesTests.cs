using DBManager.Models;
using DBManager.Models.Engines;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace DBManager.Tests.ModelsTests.QueryTrackerDriverModelTests
{
    public class GetDataTableDifferencesTests
    {
        [Fact]
        public void ShouldNotFindAnyDifferences_ForIdenticalDataTables()
        {
            var trackedQueries = new List<TrackedQuery>();
            var model = new QueryTrackerDriverModel(trackedQueries);

            string[] firstRow = { "Kujawsko-Pomorskie", "Torun" };
            string[] secondRow = { "Mazowieckie", "Plock" };

            var firstDataTable = SomeDataTable_WithoutRows();
            var secondDataTable = SomeDataTable_WithoutRows();

            firstDataTable.Rows.Add(firstRow);
            firstDataTable.Rows.Add(secondRow);
            secondDataTable.Rows.Add(firstRow);
            secondDataTable.Rows.Add(secondRow);


            var result = Act(model, firstDataTable, secondDataTable);


            Assert.Empty(result.Rows);
        }

        [Fact]
        public void ShouldFindDifferences_ForDifferentDataTables()
        {
            var trackedQueries = new List<TrackedQuery>();
            var model = new QueryTrackerDriverModel(trackedQueries);

            string[] firstDataTableRow = { "Kujawsko-Pomorskie", "Torun" };
            string[] secondDataTableRow = { "Lodzkie", "Lodz" };

            var firstDataTable = SomeDataTable_WithoutRows();
            var secondDataTable = SomeDataTable_WithoutRows();

            firstDataTable.Rows.Add(firstDataTableRow);
            secondDataTable.Rows.Add(secondDataTableRow);


            var result = Act(model, firstDataTable, secondDataTable);


            Assert.Equal(1, result.Rows.Count);
            Assert.Contains(firstDataTableRow[0], result.Rows[0].ItemArray);
            Assert.Contains(firstDataTableRow[1], result.Rows[0].ItemArray);
        }

        [Fact]
        public void NotEmptyDataTableWithDifferences_ContainsCorrectColumnNames()
        {
            var trackedQueries = new List<TrackedQuery>();
            var model = new QueryTrackerDriverModel(trackedQueries);

            const string firstColumn = "voivodeship";
            const string secondColumn = "city";
            string[] dataTableRow = { "Kujawsko-Pomorskie", "Torun" };

            var firstDataTable = new DataTable();
            var secondDataTable = new DataTable();

            firstDataTable.Columns.Add(firstColumn);
            firstDataTable.Columns.Add(secondColumn);
            secondDataTable.Columns.Add(firstColumn);
            secondDataTable.Columns.Add(secondColumn);

            firstDataTable.Rows.Add(dataTableRow);


            var result = Act(model, firstDataTable, secondDataTable);


            Assert.Equal(2, result.Columns.Count);
            Assert.True(result.Columns.Contains(firstColumn));
            Assert.True(result.Columns.Contains(secondColumn));
        }


        private DataTable SomeDataTable_WithoutRows()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("voivodeship");
            dataTable.Columns.Add("city");

            return dataTable;
        }


        public DataTable Act(QueryTrackerDriverModel model, DataTable first, DataTable second)
        {
            var result = model.GetDataTableDifferences(first, second);

            return result;
        }
    }
}
