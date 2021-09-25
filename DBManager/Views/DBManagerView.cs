using DBManager.Dto;
using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using DBManager.Views.Engines.MySql;
using DBManager.Views.Helpers;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class DBManagerView : Form
    {
        private readonly DBManagerPresenterBase _presenter;
        private readonly MessageHelper _messageHelper;

        public DBManagerView(DBManagerPresenterBase presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DbManager");

            InitializeComponent();
            LoadConnections();

            addConnection.Enabled = true;
            removeConnection.Enabled = false;
            setConnectionConfig.Enabled = false;

            connectionTree.ImageList = GetImageList();
            statusStrip.ImageList = GetImageList();
            statusStrip.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void addConnection_Click(object sender, System.EventArgs e)
        {
            using var form = new ConnectorSelectorView(_presenter);
            form.ShowDialog();

            LoadConnections();
        }

        private async void removeConnection_Click(object sender, System.EventArgs e)
        {
            if (connectionTree.SelectedNode == null)
                return;

            string connectionName = connectionTree.SelectedNode.Text;
            var status = _messageHelper.ShowQuestion($"Are you sure you want to delete the {connectionName} connection?");

            if (status == DialogResult.No)
                return;

            var response = await _presenter.RemoveConnection(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to remove {connectionName} connection", response);
                return;
            }

            if (connectionsLayout.Controls.Count == 1
                && connectionsLayout.Controls[0].Text == connectionName)
            {
                connectionsLayout.Controls[0].Dispose();
                connectionsLayout.Controls.Clear();
                statusStrip.Items["activeConnection"].Text = string.Empty;
            }

            LoadConnections();
        }

        private void setConnectionConfig_Click(object sender, System.EventArgs e)
        {

        }

        private async void connectionTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var nodes = TreeNodeHelper.GetElements(e.Node);

            if (nodes.Mode == TreeNodeMode.NotSupported)
                return;

            var response = _presenter.GetPresenter(nodes.Connection.Text);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get {nodes.Connection.Text} connection", response);
                return;
            }

            var payload = response.Payload as PresenterResponseDto;
            Form form;

            switch (nodes.Mode)
            {
                case TreeNodeMode.ConnectionSelected:
                    form = new MySqlConnectionView(payload.Presenter);
                    await LoadDatabases(payload.Presenter);
                    break;
                case TreeNodeMode.DatabaseSelected:
                    form = new MySqlDatabaseView(payload.Presenter, nodes.Database.Text);
                    await LoadTables(payload.Presenter, nodes.Database.Text);
                    break;
                case TreeNodeMode.TableSelected:
                    form = new MySqlTableView(payload.Presenter, nodes.Database.Text, nodes.Table.Text);
                    break;
                default:
                    _messageHelper.ShowError("Unable to create view - incorrect engine type");
                    return;
            }

            UpdateStatusStrip(nodes);

            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            form.Text = nodes.Connection.Text;

            if (connectionsLayout.Controls.Count == 1)
            {
                connectionsLayout.Controls[0].Dispose();
                connectionsLayout.Controls.Clear();
            }
            connectionsLayout.Controls.Add(form);

            form.Show();
        }

        private void LoadConnections()
        {
            var response = _presenter.GetConnectionNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load connection list", response);
                return;
            }

            connectionTree.Nodes.Clear();

            var dto = response.Payload as ConnectionNamesDto;

            foreach (var name in dto.Names)
            {
                var node = connectionTree
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }

            statusStrip.Items["numberOfConnections"].Text = $"Connections: {dto.Names.Count}";
            statusStrip.Items["numberOfConnections"].ImageIndex = 0;
        }

        private async Task LoadDatabases(EnginePresenterBase presenter)
        {
            var response = await presenter.GetDatabaseNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get databases for {presenter.ConnectionName} connection", response);
                return;
            }

            var payload = response.Payload as DatabaseNamesResponseDto;

            connectionTree
                .Nodes[presenter.ConnectionName]
                .Nodes.Clear();

            foreach (var name in payload.Names)
            {
                var node = connectionTree
                    .Nodes[presenter.ConnectionName]
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
        }

        private async Task LoadTables(EnginePresenterBase presenter, string databaseName)
        {
            var response = await presenter.GetTableNames(databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get databases for {presenter.ConnectionName} connection", response);
                return;
            }

            var payload = response.Payload as TableNamesResponseDto;

            connectionTree
                .Nodes[presenter.ConnectionName]
                .Nodes[databaseName]
                .Nodes.Clear();

            foreach (var name in payload.Names)
            {
                var node = connectionTree
                    .Nodes[presenter.ConnectionName]
                    .Nodes[databaseName]
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
        }

        private ImageList GetImageList()
        {
            var imageList = new ImageList();

            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/connection.png"));
            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/database.png"));
            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/table.png"));

            return imageList;
        }

        private void UpdateStatusStrip(TreeNodeElements nodes)
        {
            statusStrip.Items["activeConnection"].Text = string.Empty;
            statusStrip.Items["activeDatabase"].Text = string.Empty;
            statusStrip.Items["activeTable"].Text = string.Empty;

            statusStrip.Items["activeConnection"].ImageIndex = -1;
            statusStrip.Items["activeDatabase"].ImageIndex = -1;
            statusStrip.Items["activeTable"].ImageIndex = -1;

            if (nodes.Connection != null)
            {
                statusStrip.Items["activeConnection"].Text = $"Connection: {nodes.Connection.Text}";
                statusStrip.Items["activeConnection"].ImageIndex = 0;
            }

            if (nodes.Database != null)
            {
                statusStrip.Items["activeDatabase"].Text = $"Database: {nodes.Database.Text}";
                statusStrip.Items["activeDatabase"].ImageIndex = 1;
            }


            if (nodes.Table != null)
            {
                statusStrip.Items["activeTable"].Text = $"Table: {nodes.Table.Text}";
                statusStrip.Items["activeTable"].ImageIndex = 2;
            }
        }
    }
}
