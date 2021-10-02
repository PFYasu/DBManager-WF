using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlTableView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly string _tableName;
        private readonly MessageHelper _messageHelper;

        public MySqlTableView(EnginePresenterBase presenter, string databaseName, string tableName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _tableName = tableName;
            _messageHelper = new MessageHelper("DBManager - table view");

            InitializeComponent();
        }

        public async Task InitializeView()
        {
            var response = await _presenter.GetTableDetails(_databaseName, _tableName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get table details.", response.Payload);
                return;
            }
            
            var payload = response.Payload as TableDetailsResponseDto;

            structure_tableParametersDataGridView.Rows.Clear();

            for (int i = 0; i < payload.ColumnsStructure.Count; i++)
            {
                structure_tableParametersDataGridView.Rows.Insert(
                    i,
                    i,
                    payload.ColumnsStructure[i].Name,
                    payload.ColumnsStructure[i].Type,
                    payload.ColumnsStructure[i].ComparingSubtitlesMethod);
            }

            tableDataGridView.DataSource = payload.Table;

            browse_rowsCountLabel.Text = $"Elements: {payload.RowsCount}";

            statistics_createdAtLabel.Text = $"Created at: {payload.CreatedAt}";
            statistics_lastUpdateLabel.Text = $"Last update: {payload.LastUpdate}";
            statistics_sizeLabel.Text = $"Size (KB): {payload.Size}";
            statistics_columnsCountLabel.Text = $"Columns: {payload.ColumnsCount}";
            statistics_rowsCountLabel.Text = $"Records: {payload.RowsCount}";
        }

        private async void MySqlTableView_Load(object sender, System.EventArgs e)
        {
            await InitializeView();
        }

        public Label GetLabel(string text)
        {
            return new Label
            {
                Text = text,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black
            };
        }
    }
}
