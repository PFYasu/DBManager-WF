using DBManager.Core.Dto;
using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Views.Helpers;
using DBManager.Views.Helpers;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class DataTransferView : Form
    {
        private readonly IEnginePresenter _presenter;
        private readonly DataTable _dataToTransfer;
        private readonly MessageHelper _messageHelper;

        public DataTransferView(IEnginePresenter presenter, DataTable dataToTransfer)
        {
            _presenter = presenter;
            _dataToTransfer = dataToTransfer;
            _messageHelper = new MessageHelper("DBManager - data transfer");

            InitializeComponent();
            LoadConnections();

            var imageList = ConnectionImageListHelper.GetImageList();
            ConnectionTree_ConnectionTreeView.InitializeView(imageList);

            TryCopyData_Button.Enabled = false;

            ConnectionTree_ConnectionTreeView.OnNodeBeforeExpanding += ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding;
            ConnectionTree_ConnectionTreeView.OnNodeBeforeCollapsing += ConnectionTree_ConnectionTreeView_OnNodeBeforeCollapsing;
            ConnectionTree_ConnectionTreeView.OnNodeSelected += ConnectionTree_ConnectionTreeView_OnNodeSelected;
        }

        private void ConnectionTree_ConnectionTreeView_OnNodeBeforeCollapsing(object sender, TreeNodeElements e)
        {
            TryCopyData_Button.Enabled = false;
        }

        private void ConnectionTree_ConnectionTreeView_OnNodeSelected(object sender, TreeNodeElements e)
        {
            TryCopyData_Button.Enabled = e.Mode == TreeNodeMode.TableSelected;
        }

        private async void ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding(object sender, TreeNodeElements e)
        {
            if (e.Mode == TreeNodeMode.NotSupported)
                return;

            TryCopyData_Button.Enabled = false;

            switch (e.Mode)
            {
                case TreeNodeMode.ConnectionSelected:
                    await LoadDatabases(e.Connection.Text);
                    break;
                case TreeNodeMode.DatabaseSelected:
                    await LoadTables(e.Connection.Text, e.Database.Text);
                    break;
                case TreeNodeMode.TableSelected:
                    break;
            }
        }


        private async void TryCopyData_Button_Click(object sender, EventArgs e)
        {
            var nodes = ConnectionTree_ConnectionTreeView.LastSelectedNode;

            var sendDataDto = new SendDataDto
            {
                ConnectionName = nodes.Connection.Text,
                DatabaseName = nodes.Database.Text,
                TableName = nodes.Table.Text,
                DataTable = _dataToTransfer
            };

            var response = await _presenter.DataTransferDriver.SendData(sendDataDto);
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
