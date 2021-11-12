using DBManager.Dto;
using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class DataTransferView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly DataTable _dataToTransfer;
        private readonly MessageHelper _messageHelper;

        public DataTransferView(EnginePresenterBase presenter, DataTable dataToTransfer)
        {
            _presenter = presenter;
            _dataToTransfer = dataToTransfer;
            _messageHelper = new MessageHelper("DBManager - data transfer");

            InitializeComponent();
            LoadConnections();

            var imageList = ConnectionImageListHelper.GetImageList();
            ConnectionTree_ConnectionTreeView.InitializeView(imageList);

            TryCopyData_Button.Enabled = false;

            ConnectionTree_ConnectionTreeView.OnSelectedNodeChanged += ConnectionTree_ConnectionTreeView_OnSelectedNodeChanged;
        }

        private async void ConnectionTree_ConnectionTreeView_OnSelectedNodeChanged(object sender, TreeNodeElements e)
        {
            if (e.Mode == TreeNodeMode.NotSupported)
                return;

            TryCopyData_Button.Enabled = false;

            switch (e.Mode)
            {
                case TreeNodeMode.ConnectionSelected:
                    if (e.Connection.IsExpanded)
                    {
                        e.Connection.Collapse();
                        return;
                    }

                    await LoadDatabases(e.Connection.Text);
                    e.Connection.Expand();
                    break;
                case TreeNodeMode.DatabaseSelected:
                    if (e.Database.IsExpanded)
                    {
                        e.Database.Collapse();
                        return;
                    }

                    await LoadTables(e.Connection.Text, e.Database.Text);
                    e.Database.Expand();
                    break;
                case TreeNodeMode.TableSelected:
                    TryCopyData_Button.Enabled = true;
                    break;
            }
        }

        private async void TryCopyData_Button_Click(object sender, EventArgs e)
        {
            var nodes = ConnectionTree_ConnectionTreeView.LastSelectedNode;

            var response = await _presenter.DataTransferDriver.SendData(
                _dataToTransfer,
                nodes.Connection.Text,
                nodes.Database.Text,
                nodes.Table.Text);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to send data to selected table.", response.Payload);
                return;
            }

            _messageHelper.ShowInformation("Selected data has been sent successfully");
        }

        private void LoadConnections()
        {
            var response = _presenter.DataTransferDriver.GetConnectionNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load connection list", response);
                return;
            }

            var dto = response.Payload as ConnectionNamesResponseDto;

            ConnectionTree_ConnectionTreeView.LoadConnections(dto.Names);
        }

        private async Task LoadDatabases(string connectionName)
        {
            var response = await _presenter.DataTransferDriver.GetDatabaseNames(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to load database list for {connectionName} connection", response);
                return;
            }

            var payload = response.Payload as DatabaseNamesResponseDto;

            ConnectionTree_ConnectionTreeView.LoadDatabases(connectionName, payload.Names);
        }

        private async Task LoadTables(string connectionName, string databaseName)
        {
            var response = await _presenter.DataTransferDriver.GetTableNames(connectionName, databaseName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to load table list for {connectionName} connection", response);
                return;
            }

            var payload = response.Payload as TableNamesResponseDto;

            ConnectionTree_ConnectionTreeView.LoadTables(connectionName, databaseName, payload.Names);
        }
    }
}
