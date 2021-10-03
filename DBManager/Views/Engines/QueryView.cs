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
    public partial class QueryView : UserControl
    {
        private EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly MessageHelper _messageHelper;

        public QueryView(EnginePresenterBase presenter, string databaseName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _messageHelper = new MessageHelper("DBManager - database query view");

            InitializeComponent();
            InitializeView();
        }

        private void query_selectButton_Click(object sender, EventArgs e)
        {

        }

        private void query_insertButton_Click(object sender, EventArgs e)
        {

        }

        private void query_deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void query_updateButton_Click(object sender, EventArgs e)
        {

        }

        private async void query_sendQueryButton_Click(object sender, EventArgs e)
        {
            var query = query_queryInput.Text;

            var response = await _presenter.SendQuery(_databaseName, query);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get table details.", response.Payload);
                return;
            }

            var payload = response.Payload as QueryResponseDto;

            query_DataGridView.DataSource = payload.Table;

            query_queryTypeLabel.Text = $"Type: {payload.Type}";
        }

        public void InitializeView()
        {
            query_databaseNameLabel.Text = $"Name: {_databaseName}";
        }
    }
}
