using DBManager.Core.Dto;
using DBManager.Core.Presenters;
using DBManager.Core.Views.Engines;
using DBManager.Core.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBManager.EngineModule.MySql
{
    public partial class MySqlConnectorView : Form
    {
        private readonly ConnectorMethods _connectorMethods;
        private readonly ConnectorMode _connectorMode;
        private readonly MessageHelper _messageHelper;
        private readonly string _connectionName;

        public MySqlConnectorView(ConnectorMethods connectorMethods)
        {
            _connectorMethods = connectorMethods;
            _connectorMode = ConnectorMode.NewConnection;
            _messageHelper = new MessageHelper("DBManager - MySQL connector");

            InitializeComponent();
            Port_NumericUpDown.Controls[0].Hide();
        }

        public MySqlConnectorView(ConnectorMethods connectorMethods, string connectionName)
        {
            _connectorMethods = connectorMethods;
            _connectorMode = ConnectorMode.UpdateConnection;
            _messageHelper = new MessageHelper("DBManager - MySQL update connector");
            _connectionName = connectionName;

            InitializeComponent();
            FillForm(connectionName);

            Port_NumericUpDown.Controls[0].Hide();
        }

        private async void Save_Button_Click(object sender, EventArgs e)
        {
            if (IsValidForm() == false)
                return;

            var status = _messageHelper.ShowQuestion("Are you sure you want to save the connection configuration?");

            if (status == DialogResult.No)
                return;

            var connectionParameters = PrepareConnectionParameters();
            const string engineType = "MySql";
            var connectionName = Name_TextBox.Text;

            Response response;

            switch (_connectorMode)
            {
                case ConnectorMode.NewConnection:
                    var addConnectionDto = new AddConnectionDto
                    {
                        EngineType = engineType,
                        ConnectionParameters = connectionParameters,
                        Name = connectionName
                    };
                    response = await _connectorMethods.AddConnection(addConnectionDto);
                    break;
                case ConnectorMode.UpdateConnection:
                    var updateConnectionDto = new UpdateConnectionDto
                    {
                        EngineType = engineType,
                        ConnectionParameters = connectionParameters,
                        Name = connectionName,
                        OldName = _connectionName
                    };
                    response = await _connectorMethods.UpdateConnection(updateConnectionDto);
                    break;
                default:
                    _messageHelper.ShowError("Unable to perform connector action - incorrect connector mode.");
                    return;
            }

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to perform connector action for {connectionName} connection.", response.ErrorMessage);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillForm(string connectionName)
        {
            var response = _connectorMethods.GetConnectionSettings(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get settings for {connectionName} connection.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

            try
            {
                Name_TextBox.Text = payload.Name;
                ServerUrl_TextBox.Text = payload.ConnectionParameters["Server"];
                Port_NumericUpDown.Value = decimal.Parse(payload.ConnectionParameters["Port"]);
                Username_TextBox.Text = payload.ConnectionParameters["Uid"];
                Password_TextBox.Text = payload.ConnectionParameters["Pwd"];
            }
            catch (Exception exception)
            {
                _messageHelper.ShowError($"Unable to show settings for {connectionName} connection.", exception);
            }
        }

        private bool IsValidForm()
        {
            ErrorProvider_FormErrorProvider.Clear();

            if (string.IsNullOrEmpty(Name_TextBox.Text))
                ErrorProvider_FormErrorProvider.SetError(Name_Label, "Name cannot be empty");

            if (string.IsNullOrEmpty(ServerUrl_TextBox.Text))
                ErrorProvider_FormErrorProvider.SetError(ServerUrl_Label, "Server URL cannot be empty.");

            if (string.IsNullOrEmpty(Port_NumericUpDown.Value.ToString()))
                ErrorProvider_FormErrorProvider.SetError(Port_Label, "Port cannot be empty");

            if (string.IsNullOrEmpty(Username_TextBox.Text))
                ErrorProvider_FormErrorProvider.SetError(Username_Label, "Username cannot be empty.");

            if (string.IsNullOrEmpty(Password_TextBox.Text))
                ErrorProvider_FormErrorProvider.SetError(Password_Label, "Password cannot be empty.");

            return ErrorProvider_FormErrorProvider.ErrorCount == 0;
        }

        private Dictionary<string, string> PrepareConnectionParameters()
        {
            var parameters = new Dictionary<string, string>();

            parameters["Server"] = ServerUrl_TextBox.Text;
            parameters["Port"] = Port_NumericUpDown.Value.ToString();
            parameters["Uid"] = Username_TextBox.Text;
            parameters["Pwd"] = Password_TextBox.Text;

            return parameters;
        }
    }
}
