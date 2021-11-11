using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    [ToolboxItem(true)]
    public partial class TrackedQueriesView : UserControl
    {
        private readonly EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly MessageHelper _messageHelper;
        private string _selectedTrackedQuery;
        private TrackedQuerySnapshotResponseDto _selectedTrackedQuerySnapshot;
        private string _aboveTrackedQuerySnapshotName;
        private string _belowTrackedQuerySnapshotName;

        public TrackedQueriesView(EnginePresenterBase presenter, string databaseName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _messageHelper = new MessageHelper("DBManager - tracked queries view");

            InitializeComponent();
        }

        public void InitializeView()
        {
            ExpandColumnSize();
            HideAll();

            GetTrackedQueriesList();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            FillTrackedQueryDetails();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var trackedQueryName = TrackedQueries_ListView.SelectedItems[0].Text;

            var response = _presenter.QueryTrackerDriver.RemoveTrackedQuery(trackedQueryName, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to remove tracked query.", response.Payload);
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

            var response = _presenter.QueryTrackerDriver.GetSnapshot(snapshotName, _selectedTrackedQuery, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query snapshot.", response.Payload);
                return;
            }

            _selectedTrackedQuerySnapshot = response.Payload as TrackedQuerySnapshotResponseDto;

            Above_Button.Enabled = true;
            Below_Button.Enabled = true;
        }

        private void Above_Button_Click(object sender, EventArgs e)
        {
            if (_selectedTrackedQuerySnapshot == null)
                return;

            var data = _selectedTrackedQuerySnapshot.Data;
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

            var data = _selectedTrackedQuerySnapshot.Data;
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

            var response = _presenter.QueryTrackerDriver.GetSnapshotDifferences(
                _aboveTrackedQuerySnapshotName,
                _belowTrackedQuerySnapshotName,
                _selectedTrackedQuery,
                _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query snapshot.", response.Payload);
                return;
            }

            var payload = response.Payload as TrackedQuerySnapshotDifferencesResponseDto;

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

            _selectedTrackedQuery = TrackedQueries_ListView.SelectedItems[0].Text;

            var response = _presenter.QueryTrackerDriver.GetTrackedQuerySnapshotsDetails(_selectedTrackedQuery, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query snapshots.", response.Payload);
                return;
            }

            var payload = response.Payload as TrackedQuerySnapshotsDetailsResponseDto;

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
            var response = _presenter.QueryTrackerDriver.GetTrackedQueriesDetails(_databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query names.", response.Payload);
                return;
            }

            var payload = response.Payload as TrackedQueriesDetailsResponseDto;

            var trackedQueriesDetails = payload.TrackedQueriesDetails;

            TrackedQueries_ListView.Items.Clear();

            foreach (var trackedQueryDetails in trackedQueriesDetails)
            {
                var listViewItem = new ListViewItem(new[] { trackedQueryDetails.Name, trackedQueryDetails.TimePeriod.ToString() });

                TrackedQueries_ListView.Items.Add(listViewItem);
            }

            ExpandColumnSize();
        }

        private void HideAll()
        {
            Delete_Button.Enabled = false;
            Refresh_Button.Enabled = false;
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
    }
}
