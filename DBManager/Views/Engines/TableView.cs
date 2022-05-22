using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
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
            Columns_Structure_Label.Text = $"Columns: {payload.ColumnsCount}";
            Records_Structure_Label.Text = $"Records: {payload.RowsCount}";

            foreach (var customInformation in payload.CustomInformations)
            {
                CustomInformations_Structure_ListView.Items
                    .Add($"{customInformation.Key}: {customInformation.Value}");
            }
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

            var messageStringBuilder = new StringBuilder();

            messageStringBuilder.Append("List of unsupported columns:\n");

            foreach (var unsupportedColumn in _unsupportedColumns)
            {
                messageStringBuilder.Append($"{unsupportedColumn}\n");
            }

            messageStringBuilder.Append("\nUnsupported columns contain 'X' symbol in affected rows");

            _messageHelper.ShowWarning(messageStringBuilder.ToString());
        }
    }
}