using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Views.Engines;
using DBManager.Core.Views.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class DatabaseView : Form
    {
        private readonly IEnginePresenter _presenter;
        private readonly ConnectionElementIdentity _connectionElementIdentity;
        private readonly MessageHelper _messageHelper = new("DBManager - database view");

        public DatabaseView(IEnginePresenter presenter, ConnectionElementIdentity connectionElementIdentity)
        {
            _presenter = presenter;
            _connectionElementIdentity = connectionElementIdentity;

            InitializeComponent();
        }

        public async Task InitializeView()
        {
            var response = await _presenter.GetDatabaseDetails(_connectionElementIdentity.DatabaseName);
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
            Name_Structure_Label.Text = $"Name: {_connectionElementIdentity.DatabaseName}";
        }

        private async void MySqlDatabaseView_Load(object sender, EventArgs e)
        {
            await InitializeView();
        }

        private void Query_Enter(object sender, EventArgs e)
        {
            var queryView = new QueryView(_presenter, new ConnectionElementIdentity
            {
                ConnectionName = _connectionElementIdentity.ConnectionName,
                DatabaseName = _connectionElementIdentity.DatabaseName
            })
            {
                Dock = DockStyle.Fill
            };
            queryView.InitializeView();

            Query.Controls.Clear();

            Query.Controls.Add(queryView);
        }

        private void TrackedQueries_Enter(object sender, EventArgs e)
        {
            var trackedQueriesView = new TrackedQueriesView(_presenter, _connectionElementIdentity.DatabaseName)
            {
                Dock = DockStyle.Fill
            };

            trackedQueriesView.InitializeView();

            TrackedQueries.Controls.Clear();

            TrackedQueries.Controls.Add(trackedQueriesView);
        }
    }
}
