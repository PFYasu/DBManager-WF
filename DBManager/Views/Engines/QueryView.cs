using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Utils;
using DBManager.Core.Views.Helpers;
using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    [ToolboxItem(true)]
    public partial class QueryView : UserControl
    {
        private readonly IEnginePresenter _presenter;
        private readonly string _databaseName;
        private readonly Dictionary<string, List<string>> _databaseTableColumns;
        private readonly MessageHelper _messageHelper;

        public QueryView(
            IEnginePresenter presenter,
            string databaseName,
            Dictionary<string, List<string>> databaseTableColumns)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _databaseTableColumns = databaseTableColumns;
            _messageHelper = new MessageHelper("DBManager - database query view");

            InitializeComponent();
        }

        public void InitializeView()
        {
            DatabaseStructure_ListView.Columns[0].Width = -2;
            TableStructure_ListView.Columns[0].Width = -2;

            CopyData_Button.Visible = false;
            QueryType_Label.Visible = false;

            Name_Label.Text = $"Name: {_databaseName}";

            DatabaseStructure_ListView.Items.Clear();

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

            var response = await _presenter.SendQuery(_databaseName, query);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get table details.", response);
                return;
            }

            var payload = response.Payload as QueryResponseDto;

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

            using var form = new NewTrackedQueryView(_presenter, _databaseName, query);

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                _messageHelper.ShowInformation("Tracked query was added successfully.");
        }

        private void CopyData_Button_Click(object sender, EventArgs e)
        {
            var dataToTransfer = QueryResult_DataGridView.DataSource as DataTable;

            using var form = new DataTransferView(_presenter, dataToTransfer);
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
