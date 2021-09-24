using DBManager.Dto;
using DBManager.Presenters;
using DBManager.Utils;
using DBManager.Views.Engines.MySql;
using DBManager.Views.Helpers;
using System.Drawing;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class DBManagerView : Form, IDBManagerView
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
                statusStrip.Items["activeConnection"].Text = "";
            }

            LoadConnections();
        }

        private void setConnectionConfig_Click(object sender, System.EventArgs e)
        {

        }

        private void connectionTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var nodes = TreeNodeHelper.GetElements(e.Node);

            var connection = nodes.Connection;
            var database = nodes.Database;

            if (connection == null)
                return;

            if (database != null)
                return;

            removeConnection.Enabled = true;
            setConnectionConfig.Enabled = true;
            statusStrip.Items["activeConnection"].Text = $"Active: {connection.Text}";

            var response = _presenter.GetPresenter(connection.Text);

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to remove {connection.Text} connection", response);
                return;
            }

            var payload = response.Payload as PresenterResponseDto;

            Form form;

            switch (payload.Type)
            {
                case EngineType.MySql:
                    form = new MySqlView(payload.Presenter, connectionTree);
                    break;
                default:
                    _messageHelper.ShowError("Unable to create view - incorrect engine type");
                    return;
            }

            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            form.Text = connection.Text;

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
        }

        private ImageList GetImageList()
        {
            var imageList = new ImageList();

            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/connection.png"));
            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/database.png"));
            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/table.png"));

            return imageList;
        }
    }
}
