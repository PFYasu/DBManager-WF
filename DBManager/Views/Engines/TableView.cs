using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class TableView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly string _tableName;
        private readonly MessageHelper _messageHelper;

        public TableView(EnginePresenterBase presenter, string databaseName, string tableName)
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

            Structure_Structure_DataGridView.Rows.Clear();

            for (int i = 0; i < payload.ColumnsStructure.Count; i++)
            {
                Structure_Structure_DataGridView.Rows.Insert(
                    i,
                    i,
                    payload.ColumnsStructure[i].Name,
                    payload.ColumnsStructure[i].Type,
                    payload.ColumnsStructure[i].ComparingSubtitlesMethod);
            }

            Structure_Browse_DataGridView.DataSource = payload.Table;

            Elements_Browse_Label.Text = $"Elements: {payload.RowsCount}";
            Name_Browse_Label.Text = $"Name: {_tableName}";

            Name_Structure_Label.Text = $"Name: {_tableName}";
            CreatedAt_Structure_Label.Text = $"Created at: {payload.CreatedAt}";
            LastUpdate_Structure_Label.Text = $"Last update: {payload.LastUpdate}";
            Size_Structure_Label.Text = $"Size (KB): {payload.Size}";
            Columns_Structure_Label.Text = $"Columns: {payload.ColumnsCount}";
            Records_Structure_Label.Text = $"Records: {payload.RowsCount}";
        }

        private async void MySqlTableView_Load(object sender, EventArgs e)
        {
            await InitializeView();
        }
    }
}