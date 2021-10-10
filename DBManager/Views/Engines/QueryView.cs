using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using DBManager.Views.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    [ToolboxItem(true)]
    public partial class QueryView : UserControl
    {
        private EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly Dictionary<string, List<string>> _databaseTableColumns;
        private readonly MessageHelper _messageHelper;

        public QueryView(EnginePresenterBase presenter,
            string databaseName,
            Dictionary<string, List<string>> databaseTableColumns)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _databaseTableColumns = databaseTableColumns;
            _messageHelper = new MessageHelper("DBManager - database query view");

            InitializeComponent();
            InitializeView();
        }

        private void query_selectButton_Click(object sender, EventArgs e)
        {
            if (structure_tablesView.SelectedItems.Count == 0)
                return;

            var tableName = structure_tablesView.SelectedItems[0].Text;
            var columns = _databaseTableColumns[tableName];

            var query = QueryHelper.HardcodedQuery.Select(tableName, columns);

            query_queryInput.Text = query;
        }

        private void query_insertButton_Click(object sender, EventArgs e)
        {
            if (structure_tablesView.SelectedItems.Count == 0)
                return;

            var tableName = structure_tablesView.SelectedItems[0].Text;
            var columns = _databaseTableColumns[tableName];

            var query = QueryHelper.HardcodedQuery.InsertInto(tableName, columns);

            query_queryInput.Text = query;
        }

        private void query_deleteButton_Click(object sender, EventArgs e)
        {
            if (structure_tablesView.SelectedItems.Count == 0)
                return;

            var tableName = structure_tablesView.SelectedItems[0].Text;

            var query = QueryHelper.HardcodedQuery.Delete(tableName);

            query_queryInput.Text = query;
        }

        private void query_updateButton_Click(object sender, EventArgs e)
        {
            if (structure_tablesView.SelectedItems.Count == 0)
                return;

            var tableName = structure_tablesView.SelectedItems[0].Text;
            var columns = _databaseTableColumns[tableName];

            var query = QueryHelper.HardcodedQuery.Update(tableName, columns);

            query_queryInput.Text = query;
        }

        private async void query_sendQueryButton_Click(object sender, EventArgs e)
        {
            var query = query_queryInput.Text;

            var response = await _presenter.SendQuery(_databaseName, query);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get table details.", response.Payload);
                return;
            }

            var payload = response.Payload as QueryResponseDto;

            query_DataGridView.DataSource = payload.Table;

            query_queryTypeLabel.Text = $"Type: {payload.Type}";
        }

        private void structure_tablesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (structure_tablesView.SelectedItems.Count == 0)
                return;

            var selectedItem = structure_tablesView.SelectedItems[0].Text;

            structure_tableNameLabel.Text = selectedItem;

            structure_columnsView.Items.Clear();
            foreach (var columnName in _databaseTableColumns[selectedItem])
            {
                structure_columnsView.Items.Add(columnName);
            }
        }

        private void structure_columnsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (structure_columnsView.SelectedItems.Count == 0)
                return;

            var selectedItem = structure_columnsView.SelectedItems[0].Text;

            query_queryInput.Text += selectedItem;
        }

        private void structure_tableNameLabel_Click(object sender, EventArgs e)
        {
            query_queryInput.Text += structure_tableNameLabel.Text;
        }

        public void InitializeView()
        {
            structure_tablesView.Columns[0].Width = -2;
            structure_columnsView.Columns[0].Width = -2;

            query_databaseNameLabel.Text = $"Name: {_databaseName}";

            structure_tablesView.Items.Clear();

            foreach (var table in _databaseTableColumns.Keys)
            {
                structure_tablesView.Items.Add(table);
            }
        }
    }
}
