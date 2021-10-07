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

        private async void MySqlDatabaseView_Load(object sender, EventArgs e)
        {
            await InitializeView();
        }

        private async void query_Enter(object sender, EventArgs e)
        {
            if (query.Controls.Count != 0)
                return;

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

            query.Controls.Add(queryView);
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

            structure_databaseParametersDataGridView.Rows.Clear();

            for (int i = 0; i < payload.TablesStructure.Count; i++)
            {
                structure_databaseParametersDataGridView.Rows.Insert(
                    i,
                    i,
                    payload.TablesStructure[i].Name,
                    payload.TablesStructure[i].Type,
                    payload.TablesStructure[i].Records,
                    payload.TablesStructure[i].Size,
                    payload.TablesStructure[i].ComparingSubtitlesMethod);
            }

            structure_tablesCountLabel.Text = $"Tables: {payload.TablesCount}";
            structure_databaseNameLabel.Text = $"Name: {_databaseName}";
        }
    }
}
