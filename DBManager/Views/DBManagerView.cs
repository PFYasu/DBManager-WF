using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Views.Engines;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class DBManagerView : Form
    {
        private readonly IDBManagerPresenter _presenter;
        private readonly ConnectorMethods _connectorMethods;
        private readonly MessageHelper _messageHelper = new("DBManager");

        public DBManagerView(IDBManagerPresenter presenter)
        {
            _presenter = presenter;

            _connectorMethods = new ConnectorMethods
            {
                AddConnection = presenter.AddConnection,
                GetConnectionSettings = presenter.GetConnectionSettings,
                UpdateConnection = presenter.UpdateConnection
            };

            InitializeComponent();

            ConnectionTree_ConnectionTreeView.OnNodeSelected += ConnectionTree_ConnectionTreeView_OnNodeSelected;
            ConnectionTree_ConnectionTreeView.OnNodeBeforeExpanding += ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding;

            LoadConnections();
        }

        private async void ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding(object sender, TreeNodeElements e)
        {
            var presenter = GetPresenter(e);

            switch (e.Mode)
            {
                case TreeNodeMode.ConnectionSelected:
                    await LoadDatabases(presenter);
                    break;
                case TreeNodeMode.DatabaseSelected:
                    await LoadTables(presenter, e.Database.Text);
                    break;
                case TreeNodeMode.TableSelected:
                    break;
                default:
                    _messageHelper.ShowError("Unable to create view - incorrect engine type.");
                    return;
            }
        }

        private void ConnectionTree_ConnectionTreeView_OnNodeSelected(object sender, TreeNodeElements e)
        {
            var presenter = GetPresenter(e);

            Content_ContentManagerView.ChangeContent(presenter, e);

            RemoveConnection_Button.Enabled = true;
            UpdateConnection_Button.Enabled = true;

            Status_ConnectionStatusStrip.UpdateNodeStatus(e);
        }

        private void AddConnection_Button_Click(object sender, EventArgs e)
        {
            using var form = new ConnectorSelectorView(_presenter);
            form.ShowDialog();

            LoadConnections();
        }

        private async void RemoveConnection_Button_Click(object sender, EventArgs e)
        {
            var nodes = ConnectionTree_ConnectionTreeView.LastSelectedNode;

            if (nodes == null)
                return;

            if (nodes.Mode == TreeNodeMode.NotSupported)
                return;

            var connectionName = nodes.Connection.Text;
            var status = _messageHelper.ShowQuestion($"Are you sure you want to delete the {connectionName} connection?");

            if (status == DialogResult.No)
                return;

            var response = await _presenter.RemoveConnection(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to remove {connectionName} connection.", response.ErrorMessage);
                return;
            }

            if (Content_ContentManagerView.ClearViewIfNeeded(connectionName))
                Status_ConnectionStatusStrip.ClearNodeStatus();

            LoadConnections();
        }

        private void UpdateConnection_Button_Click(object sender, EventArgs e)
        {
            var nodes = ConnectionTree_ConnectionTreeView.LastSelectedNode;

            if (nodes == null)
                return;

            if (nodes.Mode == TreeNodeMode.NotSupported)
                return;

            string connectionName = nodes.Connection.Text;

            var response = _presenter.GetPresenter(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get {nodes.Connection.Text} connection.", response.ErrorMessage);
                return;
            }

            var engineType = response.Payload.EngineType;

            if (EngineModules.Attributes.TryGetValue(engineType, out var engineModuleAttribute) == false)
            {
                _messageHelper.ShowError("Unable to create connector update view - incorrect engine type.");
                return;
            }

            var form = (Form)Activator.CreateInstance(
                engineModuleAttribute.ConnectorView,
                _connectorMethods,
                connectionName);

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                LoadConnections();
        }

        private IEnginePresenter GetPresenter(TreeNodeElements treeNodeElements)
        {
            if (treeNodeElements.Mode == TreeNodeMode.NotSupported)
            {
                RemoveConnection_Button.Enabled = false;
                UpdateConnection_Button.Enabled = false;
                return null;
            }

            var response = _presenter.GetPresenter(treeNodeElements.Connection.Text);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get {treeNodeElements.Connection.Text} connection.", response.ErrorMessage);
                return null;
            }

            return response.Payload.Presenter;
        }

        private void LoadConnections()
        {
            var response = _presenter.GetConnectionNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load connection list.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            ConnectionTree_ConnectionTreeView.LoadConnections(payload.Names);

            Status_ConnectionStatusStrip.UpdateNumberOfConnectionsStatus(payload.Names.Count);
        }

        private async Task LoadDatabases(IEnginePresenter presenter)
        {
            var response = await presenter.GetDatabaseNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to load database list for {presenter.ConnectionName} connection.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            ConnectionTree_ConnectionTreeView.LoadDatabases(presenter.ConnectionName, payload.Names);
        }

        private async Task LoadTables(IEnginePresenter presenter, string databaseName)
        {
            var response = await presenter.GetTableNames(databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to load table list for {presenter.ConnectionName} connection.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            ConnectionTree_ConnectionTreeView.LoadTables(presenter.ConnectionName, databaseName, payload.Names);
        }
    }
}
