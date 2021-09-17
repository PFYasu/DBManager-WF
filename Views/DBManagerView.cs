using DBManager.Dto;
using DBManager.Presenters;
using DBManager.Utils;
using DBManager.Views.Engines.MySql;
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
        }

        private void LoadConnections()
        {
            var response = _presenter.GetConnectionNames();

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load connection list", response);
                return;
            }

            connectionList.Items.Clear();

            var dto = response.Payload as ConnectionNamesDto;

            foreach (var name in dto.Names)
            {
                connectionList.Items.Add(name);
            }

            statusStrip.Items["numberOfConnections"].Text = $"Connections: {dto.Names.Count}";
        }

        private void addConnection_Click(object sender, System.EventArgs e)
        {
            using var form = new ConnectorSelectorView(_presenter);
            form.ShowDialog();

            LoadConnections();
        }

        private async void removeConnection_Click(object sender, System.EventArgs e)
        {
            if (connectionList.SelectedItems.Count != 1)
                return;

            string connectionName = connectionList.SelectedItems[0].Text;
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

        private void connectionList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (connectionList.SelectedItems.Count != 1)
            {
                removeConnection.Enabled = false;
                setConnectionConfig.Enabled = false;

                return;
            }

            var connectionName = connectionList.SelectedItems[0].Text;

            removeConnection.Enabled = true;
            setConnectionConfig.Enabled = true;
            statusStrip.Items["activeConnection"].Text = $"Active: {connectionName}";

            var response = _presenter.GetPresenter(connectionName);

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to remove {connectionName} connection", response);
                return;
            }

            var payload = response.Payload as PresenterResponseDto;

            Form form;

            switch (payload.Type)
            {
                case EngineType.MySql:
                    form = new MySqlView(payload.Presenter);
                    break;
                default:
                    _messageHelper.ShowError("Unable to create view - incorrect engine type");
                    return;
            }

            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            form.Text = connectionName;

            if(connectionsLayout.Controls.Count == 1)
            {
                connectionsLayout.Controls[0].Dispose();
                connectionsLayout.Controls.Clear();

            }
            connectionsLayout.Controls.Add(form);

            form.Show();
        }
    }
}
