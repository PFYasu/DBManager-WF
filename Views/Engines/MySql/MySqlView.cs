using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly MessageHelper _messageHelper;
        private readonly TreeView _treeView;

        public MySqlView(EnginePresenterBase presenter, TreeView treeView)
        {
            _presenter = presenter;
            _treeView = treeView;
            _messageHelper = new MessageHelper("DBManager - MySql");

            InitializeComponent();
            LoadDatabases();

            _treeView.NodeMouseClick += _treeView_NodeMouseClick;
        }

        private async void _treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var nodes = TreeNodeHelper.GetElements(e.Node);

            var database = nodes.Database;
            var table = nodes.Table;

            if (database == null)
                return;

            if (table != null)
            {
                //show table
            }
            else
            {
                database.Nodes.Clear();

                await LoadTables(database);
                database.Expand();
            }
        }

        private async void sendQuery_Click(object sender, EventArgs e)
        {
            string query = inputQuery.Text;

            var response = await _presenter.SendQuery("test", query); //TODO: another way to determine current database

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to send query.", response.Payload);
                return;
            }

            var payload = response.Payload as ExecuteQueryResponseDto;
            executeQueryResult.DataSource = payload.DataTable;
        }

        private async Task LoadDatabases()
        {
            var response = await _presenter.GetDatabaseNames();

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load database list.", response);
                return;
            }

            _treeView
                .Nodes[_presenter.ConnectionName]
                .Nodes.Clear();

            var dto = response.Payload as DatabaseNamesResponseDto;

            foreach (var name in dto.Names)
            {
                var node = _treeView
                    .Nodes[_presenter.ConnectionName]
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }

            _treeView
                .Nodes[_presenter.ConnectionName]
                .Expand();
        }

        private async Task LoadTables(TreeNode databaseNode)
        {
            var response = await _presenter.GetTableNames(databaseNode.Text);

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load table list.", response);
                return;
            }

            databaseNode.Nodes.Clear();

            var dto = response.Payload as TableNamesResponseDto;

            foreach (var name in dto.Names)
            {
                var node = databaseNode
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
        }
    }
}
