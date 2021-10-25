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

        public void InitializeView()
        {
            TrackedQueries_ListView.Columns[0].Width = -2;
            TrackedQueries_ListView.Columns[0].Width = -2;

            DisableActionButtons();
            GetTrackedQueriesList();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            FillTrackedQueryDetails();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            var selectedItem = TrackedQueries_ListView.SelectedItems[0].Text;

            var response = _presenter.QueryTrackerDriver.RemoveTrackedQuery(selectedItem, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to remove tracked query.", response.Payload);
                return;
            }

            GetTrackedQueriesList();
            _messageHelper.ShowInformation("Tracked query successfully removed.");
        }

        private void TrackedQueries_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTrackedQueryDetails();
        }

        private void FillTrackedQueryDetails()
        {
            if (TrackedQueries_ListView.SelectedItems.Count == 0)
            {
                DisableActionButtons();
                return;
            }

            EnableActionButtons();

            var selectedItem = TrackedQueries_ListView.SelectedItems[0].Text;

            var response = _presenter.QueryTrackerDriver.GetTrackedQuery(selectedItem, _databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get tracked query.", response.Payload);
                return;
            }

            var payload = response.Payload as TrackedQueryResponseDto;

            var actualQueryResult = payload.TrackedQuery.ActualQueryResult;
            ActualQuery_DataGridView.DataSource = actualQueryResult.DataTableResult;
            ActualQuery_Label.Text = $"Actual query | Updated: {actualQueryResult.Updated}";

            var previousQueryResult = payload.TrackedQuery.PreviousQueryResult;
            PreviousQuery_DataGridView.DataSource = previousQueryResult.DataTableResult;
            PreviousQuery_Label.Text = $"Previous query | Updated: {previousQueryResult.Updated}";

            trackedQueries_timePeriodLabel.Text = $"Refresh every {payload.TrackedQuery.TimePeriod} minutes";
            TrackedQuery_RichTextBox.Text = payload.TrackedQuery.Query;
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

            TrackedQueries_ListView.Items.Clear();

            foreach (var trackedQueryName in _trackedQueryNames)
            {
                TrackedQueries_ListView.Items.Add(trackedQueryName);
            }
        }

        private void DisableActionButtons()
        {
            Remove_Button.Enabled = false;
            Refresh_Button.Enabled = false;

            ActualQuery_Label.Text = "";
            PreviousQuery_Label.Text = "";
            trackedQueries_timePeriodLabel.Text = "Select query from list below";
            TrackedQuery_RichTextBox.Text = "";

            PreviousQuery_DataGridView.DataSource = null;
            ActualQuery_DataGridView.DataSource = null;
        }

        private void EnableActionButtons()
        {
            Remove_Button.Enabled = true;
            Refresh_Button.Enabled = true;
        }
    }
}
