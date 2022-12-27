using DBManager.Core.Presenters;
using DBManager.Core.Utils;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    [ToolboxItem(true)]
    public partial class QueryView : UserControl
    {
        private readonly IQueryPresenter _presenter;
        private readonly MessageHelper _messageHelper = new("DBManager - database query view");
        private Dictionary<string, List<string>> _databaseTableColumns = new();
        private string _connectionName;
        private string _databaseName;

        public QueryView(IQueryPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        public async Task InitializeView(string connectionName, string databaseName)
        {
            _connectionName = connectionName;
            _databaseName = databaseName;

            DatabaseStructure_ListView.Columns[0].Width = -2;
            TableStructure_ListView.Columns[0].Width = -2;

            CopyData_Button.Visible = false;
            QueryType_Label.Visible = false;

            Name_Label.Text = $"Name: {databaseName}";

            DatabaseStructure_ListView.Items.Clear();

            var response = await _presenter.GetDatabaseTableColumns(connectionName, databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get {databaseName} database table columns.", response.ErrorMessage);
                return;
            }

            _databaseTableColumns = response.Payload.DatabaseTableColumns;

            foreach (var table in _databaseTableColumns.Keys)
            {
                DatabaseStructure_ListView.Items.Add(table);
            }
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            if (DatabaseStructure_ListView.SelectedItems.Count == 0)
            {
                _messageHelper.ShowInformation("Please select table from list above");
                return;
            }

            var tableName = DatabaseStructure_ListView.SelectedItems[0].Text;
            var columns = _databaseTableColumns[tableName];

            var query = HardcodedQuery.Select(tableName, columns);

            Query_RichTextBox.Text = query;
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            if (DatabaseStructure_ListView.SelectedItems.Count == 0)
            {
                _messageHelper.ShowInformation("Please select table from list above");
                return;
            }

            var tableName = DatabaseStructure_ListView.SelectedItems[0].Text;
            var columns = _databaseTableColumns[tableName];

            var query = HardcodedQuery.InsertInto(tableName, columns);

            Query_RichTextBox.Text = query;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (DatabaseStructure_ListView.SelectedItems.Count == 0)
            {
                _messageHelper.ShowInformation("Please select table from list above");
                return;
            }

            var tableName = DatabaseStructure_ListView.SelectedItems[0].Text;

            var query = HardcodedQuery.Delete(tableName);

            Query_RichTextBox.Text = query;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (DatabaseStructure_ListView.SelectedItems.Count == 0)
            {
                _messageHelper.ShowInformation("Please select table from list above");
                return;
            }

            var tableName = DatabaseStructure_ListView.SelectedItems[0].Text;
            var columns = _databaseTableColumns[tableName];

            var query = HardcodedQuery.Update(tableName, columns);

            Query_RichTextBox.Text = query;
        }

        private async void SendQuery_Button_Click(object sender, EventArgs e)
        {
            var query = Query_RichTextBox.Text;

            if (string.IsNullOrEmpty(query))
            {
                _messageHelper.ShowInformation("Please insert a SQL statement above");
                return;
            }

            var response = await _presenter.SendQuery(_connectionName, _databaseName, query);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get table details.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            QueryResult_DataGridView.DataSource = payload.Table;

            QueryType_Label.Visible = true;
            QueryType_Label.Text = $"Type: {payload.Type}";

            CopyData_Button.Visible = payload.Type == QueryType.Query;
        }

        private void AddTrackedQuery_Button_Click(object sender, EventArgs e)
        {
            var query = Query_RichTextBox.Text;

            if (string.IsNullOrEmpty(query))
            {
                _messageHelper.ShowInformation("Please insert a SQL statement above");
                return;
            }

            var form = ViewRouter.GetNewTrackedQueryView(_connectionName, _databaseName, query);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                _messageHelper.ShowInformation("Tracked query was added successfully.");
        }

        private void CopyData_Button_Click(object sender, EventArgs e)
        {
            var dataToTransfer = QueryResult_DataGridView.DataSource as DataTable;

            var form = ViewRouter.GetDataTransferView(dataToTransfer);
            form.ShowDialog();
        }

        private void DatabaseStructure_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DatabaseStructure_ListView.SelectedItems.Count == 0)
                return;

            var selectedItem = DatabaseStructure_ListView.SelectedItems[0].Text;

            SelectedDatabase_Label.Text = selectedItem;

            TableStructure_ListView.Items.Clear();
            foreach (var columnName in _databaseTableColumns[selectedItem])
            {
                TableStructure_ListView.Items.Add(columnName);
            }
        }

        private void TableStructure_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TableStructure_ListView.SelectedItems.Count == 0)
                return;

            var selectedItem = TableStructure_ListView.SelectedItems[0].Text;

            Query_RichTextBox.Text += selectedItem;
        }

        private void SelectedDatabase_Label_Click(object sender, EventArgs e)
        {
            Query_RichTextBox.Text += SelectedDatabase_Label.Text;
        }
    }
}
