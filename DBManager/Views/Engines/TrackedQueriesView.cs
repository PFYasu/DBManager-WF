using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters.Engines;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    [ToolboxItem(true)]
    public partial class TrackedQueriesView : UserControl
    {
        private readonly ITrackedQueriesPresenter _presenter;
        private readonly MessageHelper _messageHelper = new("DBManager - tracked queries view");
        private string _connectionName;
        private string _databaseName;

        private TrackedQuerySnapshotResponseDto _selectedTrackedQuerySnapshot;
        private string _selectedTrackedQuery;
        private string _aboveTrackedQuerySnapshotName;
        private string _belowTrackedQuerySnapshotName;

        public TrackedQueriesView(ITrackedQueriesPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        public void InitializeView(string connectionName, string databaseName)
        {
            _connectionName = connectionName;
            _databaseName = databaseName;

            ExpandColumnSize();
            HideAll();

            GetTrackedQueriesList();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            FillTrackedQueryDetails();
        }

        private void Preview_Button_Click(object sender, EventArgs e)
        {
            var trackedQueryName = TrackedQueries_ListView.SelectedItems[0].Text;

            var response = _presenter.GetPreview(_connectionName, _databaseName, trackedQueryName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to remove tracked query.", response.ErrorMessage);
                return;
            }

            _messageHelper.ShowInformation(response.Payload.QueryPreview);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var trackedQueryName = TrackedQueries_ListView.SelectedItems[0].Text;

            var status = _messageHelper.ShowQuestion($"Are you sure you want to delete the {trackedQueryName} tracked query?");

            if (status == DialogResult.No)
                return;

            var response = _presenter.RemoveTrackedQuery(_connectionName, _databaseName, trackedQueryName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to remove tracked query.", response.ErrorMessage);
                return;
            }

            TrackedQueriesSnapshots_ListView.Items.Clear();

            GetTrackedQueriesList();
            _messageHelper.ShowInformation("Tracked query successfully removed.");
        }

        private void TrackedQueries_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTrackedQueryDetails();
        }

        private void TrackedQueriesSnapshots_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrackedQueriesSnapshots_ListView.SelectedItems.Count == 0)
                return;

            var snapshotName = TrackedQueriesSnapshots_ListView.SelectedItems[0].Text;

            var response = _presenter.GetSnapshot(_connectionName, _databaseName, snapshotName, _selectedTrackedQuery);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query snapshot.", response.ErrorMessage);
                return;
            }

            _selectedTrackedQuerySnapshot = response.Payload;

            Above_Button.Enabled = true;
            Below_Button.Enabled = true;
        }

        private void Above_Button_Click(object sender, EventArgs e)
        {
            if (_selectedTrackedQuerySnapshot == null)
                return;

            var data = _selectedTrackedQuerySnapshot.Data.Columns.Count != 0
                ? _selectedTrackedQuerySnapshot.Data
                : DataTableWithoutSchema();

            var updated = _selectedTrackedQuerySnapshot.Updated;

            FirstQuerySnapshot_DataGridView.DataSource = data;
            FirstQueryUpdateTime_Label.Text = $"Updated: {updated}";

            _aboveTrackedQuerySnapshotName = updated.ToString();

            Above_Button.Enabled = false;
            Below_Button.Enabled = false;

            if (FirstQuerySnapshot_DataGridView.DataSource != null
                && SecondQuerySnapshot_DataGridView.DataSource != null)
                ShowDifferences();
        }

        private void Below_Button_Click(object sender, EventArgs e)
        {
            if (_selectedTrackedQuerySnapshot == null)
                return;

            var data = _selectedTrackedQuerySnapshot.Data.Columns.Count != 0
                ? _selectedTrackedQuerySnapshot.Data
                : DataTableWithoutSchema();

            var updated = _selectedTrackedQuerySnapshot.Updated;

            SecondQuerySnapshot_DataGridView.DataSource = data;
            SecondQueryUpdateTime_Label.Text = $"Updated: {updated}";

            _belowTrackedQuerySnapshotName = updated.ToString();

            Above_Button.Enabled = false;
            Below_Button.Enabled = false;

            if (FirstQuerySnapshot_DataGridView.DataSource != null
                && SecondQuerySnapshot_DataGridView.DataSource != null)
                ShowDifferences();
        }

        private void ShowDifferences()
        {
            if (FirstQuerySnapshot_DataGridView.DataSource == null
                && SecondQuerySnapshot_DataGridView.DataSource == null)
                return;

            if (string.IsNullOrEmpty(_aboveTrackedQuerySnapshotName)
                && string.IsNullOrEmpty(_belowTrackedQuerySnapshotName))
                return;

            var trackedQuerySnapshotDifferencesDto = new TrackedQuerySnapshotDifferencesDto
            {
                FirstSnapshotName = _aboveTrackedQuerySnapshotName,
                SecondSnapshotName = _belowTrackedQuerySnapshotName,
                TrackedQueryName = _selectedTrackedQuery,
                ConnectionName = _connectionName,
                DatabaseName = _databaseName
            };

            var response = _presenter.GetSnapshotDifferences(trackedQuerySnapshotDifferencesDto);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query snapshot.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            var differences = payload.Differences;
            var differentRows = payload.DifferentRows;

            TrackedQueriesDifference_DataGridView.DataSource = differences;

            QuerySummary_Label.Text = $"Different rows: {differentRows}";
        }

        private void FillTrackedQueryDetails()
        {
            if (TrackedQueries_ListView.SelectedItems.Count == 0)
            {
                TrackedQueriesSnapshots_ListView.Items.Clear();

                HideAll();
                return;
            }

            Delete_Button.Enabled = true;
            Refresh_Button.Enabled = true;
            Preview_Button.Enabled = true;

            _selectedTrackedQuery = TrackedQueries_ListView.SelectedItems[0].Text;

            var response = _presenter.GetTrackedQuerySnapshotsDetails(_connectionName, _databaseName, _selectedTrackedQuery);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query snapshots.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            var snapshotNames = payload.SnapshotNames;
            var timePeriod = payload.TimePeriod;

            TrackedQueriesSnapshots_ListView.Items.Clear();

            foreach (var snapshotName in snapshotNames)
            {
                TrackedQueriesSnapshots_ListView.Items.Add(snapshotName);
            }

            TimePeriod_Label.Text = $"Update every {timePeriod} minutes";
        }

        private void GetTrackedQueriesList()
        {
            var response = _presenter.GetTrackedQueriesDetails(_connectionName, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query names.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            var trackedQueriesDetails = payload.TrackedQueriesDetails;

            TrackedQueries_ListView.Items.Clear();

            foreach (var trackedQueryDetails in trackedQueriesDetails)
            {
                var listViewItem = new ListViewItem(new[] 
                { 
                    trackedQueryDetails.Name, 
                    trackedQueryDetails.TimePeriod.ToString(),
                    trackedQueryDetails.SnapshotsCount.ToString()
                });

                TrackedQueries_ListView.Items.Add(listViewItem);
            }

            ExpandColumnSize();
        }

        private void HideAll()
        {
            Delete_Button.Enabled = false;
            Refresh_Button.Enabled = false;
            Preview_Button.Enabled = false;
            Above_Button.Enabled = false;
            Below_Button.Enabled = false;

            FirstQueryUpdateTime_Label.Text = "Put first query snapshot";
            SecondQueryUpdateTime_Label.Text = "Put second query snapshot";
            TimePeriod_Label.Text = "Select tracked query from list below";
            QuerySummary_Label.Text = "Put two snapshots to get summary";

            FirstQuerySnapshot_DataGridView.DataSource = null;
            SecondQuerySnapshot_DataGridView.DataSource = null;
            TrackedQueriesDifference_DataGridView.DataSource = null;

            _selectedTrackedQuery = null;
            _selectedTrackedQuerySnapshot = null;
            _aboveTrackedQuerySnapshotName = null;
            _belowTrackedQuerySnapshotName = null;
        }

        private void ExpandColumnSize()
        {
            TrackedQueries_ListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            TrackedQueries_ListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private static DataTable DataTableWithoutSchema()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("This table is empty");
            return dataTable;
        }
    }
}
