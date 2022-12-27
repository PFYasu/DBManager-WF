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

        public DatabaseView(IDatabasePresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        public async Task InitializeView(string connectionName, string databaseName)
        {
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
                    payload.TablesStructure[i].Type,
                    payload.TablesStructure[i].Records,
                    payload.TablesStructure[i].Size,
                    payload.TablesStructure[i].ComparingSubtitlesMethod);
            }

            Tables_Structure_Label.Text = $"Tables: {payload.TablesCount}";
            Name_Structure_Label.Text = $"Name: {databaseName}";
        }

        private void Query_Enter(object sender, EventArgs e)
        {
            //var queryView = new QueryView(_presenter, new ConnectionElementIdentity
            //{
            //    ConnectionName = _connectionElementIdentity.ConnectionName,
            //    DatabaseName = _connectionElementIdentity.DatabaseName
            //})
            //{
            //    Dock = DockStyle.Fill
            //};
            //queryView.InitializeView();

            //Query.Controls.Clear();

            //Query.Controls.Add(queryView);
        }

        private void TrackedQueries_Enter(object sender, EventArgs e)
        {
            //var trackedQueriesView = new TrackedQueriesView(_presenter, _connectionElementIdentity.DatabaseName)
            //{
            //    Dock = DockStyle.Fill
            //};

            //trackedQueriesView.InitializeView();

            //TrackedQueries.Controls.Clear();

            //TrackedQueries.Controls.Add(trackedQueriesView);
        }
    }
}
