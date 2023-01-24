using DBManager.Core.Presenters;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters.Engines;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class DatabaseView : Form
    {
        private readonly IDatabasePresenter _presenter;
        private readonly MessageHelper _messageHelper = new("DBManager - database view");
        private string _connectionName;
        private string _databaseName;

        public DatabaseView(IDatabasePresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        public async Task InitializeView(string connectionName, string databaseName)
        {
            _connectionName = connectionName;
            _databaseName = databaseName;

            var response = await _presenter.GetDatabaseDetails(connectionName, databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get database details.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            Structure_Structure_DataGridView.Rows.Clear();

            for (int i = 0; i < payload.TablesStructure.Count; i++)
            {
                Structure_Structure_DataGridView.Rows.Insert(
                    i,
                    i,
                    payload.TablesStructure[i].Name,
                    payload.TablesStructure[i].Records);
            }

            Tables_Structure_Label.Text = $"Tables: {payload.TablesCount}";
            Name_Structure_Label.Text = $"Name: {databaseName}";
        }

        private async void Query_Enter(object sender, EventArgs e)
        {
            var form = await ViewRouter.GetQueryView(_connectionName, _databaseName);

            form.Dock = DockStyle.Fill;

            Query.Controls.Clear();

            Query.Controls.Add(form);
        }

        private void TrackedQueries_Enter(object sender, EventArgs e)
        {
            var form = ViewRouter.GetTrackedQueriesView(_connectionName, _databaseName);
            form.Dock = DockStyle.Fill;

            TrackedQueries.Controls.Clear();

            TrackedQueries.Controls.Add(form);
        }
    }
}
