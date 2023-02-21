using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters.Engines;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class DataTransferView : Form
    {
        private readonly IDataTransferPresenter _presenter;
        private readonly MessageHelper _messageHelper;
        private DataTable _dataToTransfer;

        public DataTransferView(IDataTransferPresenter presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DBManager - data transfer");

            InitializeComponent();

            ConnectionTree_ConnectionTreeView.OnNodeBeforeExpanding += ConnectionTree_ConnectionTreeView_OnNodeBeforeExpanding;
            ConnectionTree_ConnectionTreeView.OnNodeBeforeCollapsing += ConnectionTree_ConnectionTreeView_OnNodeBeforeCollapsing;
            ConnectionTree_ConnectionTreeView.OnNodeSelected += ConnectionTree_ConnectionTreeView_OnNodeSelected;
        }

        public void InitializeView(DataTable dataToTransfer)
        {
            _dataToTransfer = dataToTransfer;
            LoadConnections();
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

            var response = await _presenter.SendData(sendDataDto);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to send data to selected table.", response.ErrorMessage);
                return;
            }

            _messageHelper.ShowInformation("Selected data has been sent successfully");
        }

        private void LoadConnections()
        {
            var response = _presenter.GetConnectionNames();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to load connection list.", response.ErrorMessage);
                return;
            }

            ConnectionTree_ConnectionTreeView.LoadConnections(response.Payload.Names);
        }

        private async Task LoadDatabases(string connectionName)
        {
            var response = await _presenter.GetDatabaseNames(connectionName);
            if (response.Type == ResponseType.Error)
            {
                ConnectionTree_ConnectionTreeView.CollapseNode(connectionName);
                _messageHelper.ShowError($"Unable to load database list for {connectionName} connection.", response.ErrorMessage);
                return;
            }

            ConnectionTree_ConnectionTreeView.LoadDatabases(connectionName, response.Payload.Names);
        }

        private async Task LoadTables(string connectionName, string databaseName)
        {
            var response = await _presenter.GetTableNames(connectionName, databaseName);
            if (response.Type == ResponseType.Error)
            {
                ConnectionTree_ConnectionTreeView.CollapseNode(connectionName, databaseName);
                _messageHelper.ShowError($"Unable to load table list for {connectionName} connection.", response.ErrorMessage);
                return;
            }

            ConnectionTree_ConnectionTreeView.LoadTables(connectionName, databaseName, response.Payload.Names);
        }
    }
}
