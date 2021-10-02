using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlDatabaseView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly MessageHelper _messageHelper;

        public MySqlDatabaseView(EnginePresenterBase presenter, string databaseName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _messageHelper = new MessageHelper("DBManager - database view");

            InitializeComponent();
        }

        private async void MySqlDatabaseView_Shown(object sender, System.EventArgs e)
        {
            await InitializeView();
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
        }
    }
}
