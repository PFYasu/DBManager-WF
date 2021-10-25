using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class DatabaseView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly MessageHelper _messageHelper;

        public DatabaseView(EnginePresenterBase presenter, string databaseName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _messageHelper = new MessageHelper("DBManager - database view");

            InitializeComponent();
        }

        public async Task InitializeView()
        {
            var response = await _presenter.GetDatabaseDetails(_databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get database details.", response.Payload);
                return;
            }

            var payload = response.Payload as DatabaseDetailsResponseDto;

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
            Name_Structure_Label.Text = $"Name: {_databaseName}";
        }

        private async void MySqlDatabaseView_Load(object sender, EventArgs e)
        {
            await InitializeView();
        }

        private async void Query_Enter(object sender, EventArgs e)
        {
            var response = await _presenter.GetDatabaseTableColumns(_databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get database tables columns.", response.Payload);
                return;
            }

            var payload = response.Payload as DatabaseTableColumnsResponseDto;

            var databaseTableColumns = payload.DatabaseTableColumns;

            var queryView = new QueryView(_presenter, _databaseName, databaseTableColumns)
            {
                Dock = DockStyle.Fill
            };

            queryView.InitializeView();

            Query.Controls.Clear();

            Query.Controls.Add(queryView);
        }

        private void TrackedQueries_Enter(object sender, EventArgs e)
        {
            var trackedQueriesView = new TrackedQueriesView(_presenter, _databaseName)
            {
                Dock = DockStyle.Fill
            };

            trackedQueriesView.InitializeView();

            TrackedQueries.Controls.Clear();

            TrackedQueries.Controls.Add(trackedQueriesView);
        }
    }
}
