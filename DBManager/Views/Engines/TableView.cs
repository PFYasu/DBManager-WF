using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class TableView : Form
    {
        private readonly IEnginePresenter _presenter;
        private readonly string _databaseName;
        private readonly string _tableName;
        private readonly List<string> _unsupportedColumns;
        private readonly MessageHelper _messageHelper;

        public TableView(IEnginePresenter presenter, string databaseName, string tableName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _tableName = tableName;
            _unsupportedColumns = new List<string>();
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

            _unsupportedColumns.Clear();

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

        private void Structure_Browse_DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var unsupportedColumnName = Structure_Browse_DataGridView.Columns[e.ColumnIndex]?.Name;

            if (unsupportedColumnName == null)
                return;

            if (_unsupportedColumns.Contains(unsupportedColumnName) == false)
                _unsupportedColumns.Add(unsupportedColumnName);
        }

        private void UnsupportedColumns_Browse_Button_Click(object sender, EventArgs e)
        {
            if (_unsupportedColumns.Count == 0)
            {
                _messageHelper.ShowInformation("No unsupported columns detected");
                return;
            }

            var message = "List of unsupported columns:\n";

            foreach (var unsupportedColumn in _unsupportedColumns)
            {
                message += $"{unsupportedColumn}\n";
            }

            message += "\nUnsupported columns contain 'X' symbol in affected rows";

            _messageHelper.ShowWarning(message);
        }
    }
}