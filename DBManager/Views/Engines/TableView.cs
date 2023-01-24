using DBManager.Core.Presenters;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters.Engines;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class TableView : Form
    {
        private readonly ITablePresenter _presenter;
        private readonly List<string> _unsupportedColumns = new();
        private readonly MessageHelper _messageHelper = new("DBManager - table view");

        public TableView(ITablePresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        public async Task InitializeView(string connectionName, string databaseName, string tableName)
        {
            var response = await _presenter.GetTableDetails(connectionName, databaseName, tableName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get table details.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            Structure_Structure_DataGridView.Rows.Clear();

            for (int i = 0; i < payload.ColumnsStructure.Count; i++)
            {
                Structure_Structure_DataGridView.Rows.Insert(
                    i,
                    i,
                    payload.ColumnsStructure[i].Name);
            }

            _unsupportedColumns.Clear();

            Structure_Browse_DataGridView.DataSource = payload.Table;

            Elements_Browse_Label.Text = $"Elements: {payload.RowsCount}";
            Name_Browse_Label.Text = $"Name: {tableName}";

            Name_Structure_Label.Text = $"Name: {tableName}";
            Columns_Structure_Label.Text = $"Columns: {payload.ColumnsCount}";
            Records_Structure_Label.Text = $"Records: {payload.RowsCount}";

            foreach (var customInformation in payload.CustomInformations)
            {
                CustomInformations_Structure_ListView.Items
                    .Add($"{customInformation.Key}: {customInformation.Value}");
            }
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