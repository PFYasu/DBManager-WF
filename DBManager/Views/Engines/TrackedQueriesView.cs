using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.Collections.Generic;
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
        private List<string> _trackedQueryNames;

        public TrackedQueriesView(EnginePresenterBase presenter, string databaseName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _messageHelper = new MessageHelper("DBManager - tracked queries view");
            _trackedQueryNames = new List<string>();

            InitializeComponent();
        }

        private void trackedQueries_trackedQueriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTrackedQueryDetails();
        }

        private void trackedQueries_refreshButton_Click(object sender, EventArgs e)
        {
            FillTrackedQueryDetails();
        }

        private void trackedQueries_removeButton_Click(object sender, EventArgs e)
        {
            var selectedItem = trackedQueries_trackedQueriesList.SelectedItems[0].Text;

            var response = _presenter.QueryTrackerDriver.RemoveTrackedQuery(selectedItem, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to remove tracked query.", response.Payload);
                return;
            }

            GetTrackedQueriesList();
            _messageHelper.ShowInformation("Tracked query successfully removed.");
        }

        private void FillTrackedQueryDetails()
        {
            if (trackedQueries_trackedQueriesList.SelectedItems.Count == 0)
            {
                DisableActionButtons();
                return;
            }

            EnableActionButtons();

            var selectedItem = trackedQueries_trackedQueriesList.SelectedItems[0].Text;

            var response = _presenter.QueryTrackerDriver.GetTrackedQuery(selectedItem, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query.", response.Payload);
                return;
            }

            var payload = response.Payload as TrackedQueryResponseDto;

            var actualQueryResult = payload.TrackedQuery.ActualQueryResult;
            trackedQueries_actualQuery.DataSource = actualQueryResult.DataTableResult;
            trackedQueries_actualQueryInfoLabel.Text = $"Actual query | Updated: {actualQueryResult.Updated}";

            var previousQueryResult = payload.TrackedQuery.PreviousQueryResult;
            trackedQueries_previousQuery.DataSource = previousQueryResult.DataTableResult;
            trackedQueries_previousQueryInfoLabel.Text = $"Previous query | Updated: {previousQueryResult.Updated}";

            trackedQueries_timePeriodLabel.Text = $"Refresh every {payload.TrackedQuery.TimePeriod} minutes";
            trackedQueries_queryPreview.Text = payload.TrackedQuery.Query;
        }

        public void InitializeView()
        {
            trackedQueries_trackedQueriesList.Columns[0].Width = -2;
            trackedQueries_trackedQueriesList.Columns[0].Width = -2;

            DisableActionButtons();
            GetTrackedQueriesList();
        }

        private void GetTrackedQueriesList()
        {
            var response = _presenter.QueryTrackerDriver.GetTrackedQueryNames(_databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query names.", response.Payload);
                return;
            }

            var payload = response.Payload as TrackedQueryNamesResponseDto;

            _trackedQueryNames = payload.Names;

            trackedQueries_trackedQueriesList.Items.Clear();

            foreach (var trackedQueryName in _trackedQueryNames)
            {
                trackedQueries_trackedQueriesList.Items.Add(trackedQueryName);
            }
        }

        private void DisableActionButtons()
        {
            trackedQueries_removeButton.Enabled = false;
            trackedQueries_refreshButton.Enabled = false;

            trackedQueries_actualQueryInfoLabel.Text = "";
            trackedQueries_previousQueryInfoLabel.Text = "";
            trackedQueries_timePeriodLabel.Text = "Select query from list below";
            trackedQueries_queryPreview.Text = "";

            trackedQueries_previousQuery.DataSource = null;
            trackedQueries_actualQuery.DataSource = null;
        }

        private void EnableActionButtons()
        {
            trackedQueries_removeButton.Enabled = true;
            trackedQueries_refreshButton.Enabled = true;
        }
    }
}
