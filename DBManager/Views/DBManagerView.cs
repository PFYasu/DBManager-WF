using DBManager.Core.Dto;
using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Views.Engines;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters;
using DBManager.Views.Engines;
using DBManager.Views.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class DBManagerView : Form
    {
        private readonly IDBManagerPresenter _presenter;
        private readonly ConnectorMethods _connectorMethods;
        private readonly MessageHelper _messageHelper;

        public DBManagerView(IDBManagerPresenter presenter)
        {
            _presenter = presenter;

            _connectorMethods = new ConnectorMethods
            {
                AddConnection = presenter.AddConnection,
                GetConnectionSettings = presenter.GetConnectionSettings,
                UpdateConnection = presenter.UpdateConnection
            };

            _messageHelper = new MessageHelper("DbManager");

            InitializeComponent();
            LoadConnections();

            AddConnection_Button.Enabled = true;
            RemoveConnection_Button.Enabled = false;
            UpdateConnection_Button.Enabled = false;

            var imageList = ConnectionImageListHelper.GetImageList();
            Status_StatusStrip.ImageList = imageList;
            ConnectionTree_ConnectionTreeView.InitializeView(imageList);

            ConnectionTree_ConnectionTreeView.OnNodeSelected += ConnectionTree_ConnectionTreeView_OnNodeSelected;
            ConnectionTree_ConnectionTreeView.OnNodeBeforeExpanding += ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding;
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
                    _messageHelper.ShowError("Unable to create view - incorrect engine type");
                    return;
            }
        }

        private void ConnectionTree_ConnectionTreeView_OnNodeSelected(object sender, TreeNodeElements e)
        {
            var presenter = GetPresenter(e);

            Form form;

            switch (e.Mode)
            {
                case TreeNodeMode.ConnectionSelected:
                    form = new ConnectionView(presenter);
                    break;
                case TreeNodeMode.DatabaseSelected:
                    form = new DatabaseView(presenter, e.Database.Text);
                    break;
                case TreeNodeMode.TableSelected:
                    form = new TableView(presenter, e.Database.Text, e.Table.Text);
                    break;
                default:
                    _messageHelper.ShowError("Unable to create view - incorrect engine type");
                    return;
            }

            RemoveConnection_Button.Enabled = true;
            UpdateConnection_Button.Enabled = true;

            UpdateStatusStrip(e);

            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            form.Text = e.Connection.Text;

            if (ConnectionManager_TableLayoutPanel.Controls.Count == 1)
            {
                ConnectionManager_TableLayoutPanel.Controls[0].Dispose();
                ConnectionManager_TableLayoutPanel.Controls.Clear();
            }
            ConnectionManager_TableLayoutPanel.Controls.Add(form);

            form.Show();
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

            string connectionName = nodes.Connection.Text;
            var status = _messageHelper.ShowQuestion($"Are you sure you want to delete the {connectionName} connection?");

            if (status == DialogResult.No)
                return;

            var response = await _presenter.RemoveConnection(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to remove {connectionName} connection", response);
                return;
            }

            if (ConnectionManager_TableLayoutPanel.Controls.Count == 1
                && ConnectionManager_TableLayoutPanel.Controls[0].Text == connectionName)
            {
                ConnectionManager_TableLayoutPanel.Controls[0].Dispose();
                ConnectionManager_TableLayoutPanel.Controls.Clear();
                Status_StatusStrip.Items["activeConnection"].Text = string.Empty;
            }

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
                _messageHelper.ShowError($"Unable to get {nodes.Connection.Text} connection", response);
                return;
            }

            var payload = response.Payload as PresenterResponseDto;

            var engineType = payload.EngineType;

            if (EngineModules.Attributes.TryGetValue(engineType, out var engineModuleAttribute) == false)
            {
                _messageHelper.ShowError("Unable to create connector update view - incorrect engine type");
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
                _messageHelper.ShowError($"Unable to get {treeNodeElements.Connection.Text} connection", response);
                return null;
            }

            var payload = response.Payload as PresenterResponseDto;

            return payload.Presenter;
        }

        private void LoadConnections()
        {
            var response = _presenter.GetConnectionNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load connection list", response);
                return;
            }

            var dto = response.Payload as ConnectionNamesResponseDto;

            ConnectionTree_ConnectionTreeView.LoadConnections(dto.Names);

            Status_StatusStrip.Items["numberOfConnections"].Text = $"Connections: {dto.Names.Count}";
            Status_StatusStrip.Items["numberOfConnections"].ImageIndex = 0;
        }

        private async Task LoadDatabases(IEnginePresenter presenter)
        {
            var response = await presenter.GetDatabaseNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to load database list for {presenter.ConnectionName} connection", response);
                return;
            }

            var payload = response.Payload as DatabaseNamesResponseDto;

            ConnectionTree_ConnectionTreeView.LoadDatabases(presenter.ConnectionName, payload.Names);
        }

        private async Task LoadTables(IEnginePresenter presenter, string databaseName)
        {
            var response = await presenter.GetTableNames(databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to load table list for {presenter.ConnectionName} connection", response);
                return;
            }

            var payload = response.Payload as TableNamesResponseDto;

            ConnectionTree_ConnectionTreeView.LoadTables(presenter.ConnectionName, databaseName, payload.Names);
        }

        private void UpdateStatusStrip(TreeNodeElements nodes)
        {
            Status_StatusStrip.Items["activeConnection"].Text = string.Empty;
            Status_StatusStrip.Items["activeDatabase"].Text = string.Empty;
            Status_StatusStrip.Items["activeTable"].Text = string.Empty;

            Status_StatusStrip.Items["activeConnection"].ImageIndex = -1;
            Status_StatusStrip.Items["activeDatabase"].ImageIndex = -1;
            Status_StatusStrip.Items["activeTable"].ImageIndex = -1;

            if (nodes.Connection != null)
            {
                Status_StatusStrip.Items["activeConnection"].Text = $"Connection: {nodes.Connection.Text}";
                Status_StatusStrip.Items["activeConnection"].ImageIndex = 0;
            }

            if (nodes.Database != null)
            {
                Status_StatusStrip.Items["activeDatabase"].Text = $"Database: {nodes.Database.Text}";
                Status_StatusStrip.Items["activeDatabase"].ImageIndex = 1;
            }

            if (nodes.Table != null)
            {
                Status_StatusStrip.Items["activeTable"].Text = $"Table: {nodes.Table.Text}";
                Status_StatusStrip.Items["activeTable"].ImageIndex = 2;
            }
        }
    }
}
