using DBManager.Dto;
using DBManager.Presenters;
using DBManager.Utils;
using DBManager.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlConnectorView : Form
    {
        private readonly DBManagerPresenterBase _presenter;
        private readonly ConnectorMode _connectorMode;
        private readonly MessageHelper _messageHelper;
        private readonly string _connectionName;

        public MySqlConnectorView(DBManagerPresenterBase presenter)
        {
            _presenter = presenter;
            _connectorMode = ConnectorMode.NewConnection;
            _messageHelper = new MessageHelper("DBManager - MySQL connector");

            InitializeComponent();
            port.Controls[0].Hide();
        }

        public MySqlConnectorView(DBManagerPresenterBase presenter, string connectionName)
        {
            _presenter = presenter;
            _connectorMode = ConnectorMode.UpdateConnection;
            _messageHelper = new MessageHelper("DBManager - MySQL update connector");
            _connectionName = connectionName;

            InitializeComponent();
            FillForm(connectionName);

            port.Controls[0].Hide();
        }

        private async void save_Click(object sender, EventArgs e)
        {
            if (IsValidForm(out string error) == false)
            {
                _messageHelper.ShowError(error);
                return;
            }

            var connectionParameters = PrepareConnectionParameters();
            var type = EngineType.MySql;
            var connectionName = name.Text;

            Response response;

            switch (_connectorMode)
            {
                case ConnectorMode.NewConnection:
                    var addConnectionDto = new AddConnectionDto
                    {
                        Type = type,
                        ConnectionParameters = connectionParameters,
                        Name = connectionName
                    };
                    response = await _presenter.AddConnection(addConnectionDto);
                    break;
                case ConnectorMode.UpdateConnection:
                    var updateConnectionDto = new UpdateConnectionDto
                    {
                        Type = type,
                        ConnectionParameters = connectionParameters,
                        Name = connectionName,
                        OldName = _connectionName
                    };
                    response = await _presenter.UpdateConnection(updateConnectionDto);
                    break;
                default:
                    _messageHelper.ShowError("Unable to perform connector action - incorrect connector mode");
                    return;
            }

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to perform connector action for {connectionName} connection.", response.Payload);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillForm(string connectionName)
        {
            var response = _presenter.GetConnectionSettings(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to get settings for {connectionName} connection.", response.Payload);
                return;
            }

            var payload = response.Payload as AddConnectionDto;

            try
            {
                name.Text = payload.Name;
                serverUrl.Text = payload.ConnectionParameters["Server"];
                port.Value = decimal.Parse(payload.ConnectionParameters["Port"]);
                username.Text = payload.ConnectionParameters["Uid"];
                password.Text = payload.ConnectionParameters["Pwd"];
            }
            catch (Exception exception)
            {
                _messageHelper.ShowError($"Unable to show settings for {connectionName} connection.", exception.Message);
            }
        }

        private bool IsValidForm(out string error)
        {
            if (string.IsNullOrEmpty(name.Text))
                error = "Name cannot be empty.";
            else if (string.IsNullOrEmpty(serverUrl.Text))
                error = "Server URL cannot be empty.";
            else if (string.IsNullOrEmpty(port.Value.ToString()))
                error = "Port cannot be empty.";
            else if (string.IsNullOrEmpty(username.Text))
                error = "Username cannot be empty.";
            else if (string.IsNullOrEmpty(password.Text))
                error = "Password cannot be empty.";
            else
            {
                error = null;
                return true;
            }
            return false;
        }

        private Dictionary<string, string> PrepareConnectionParameters()
        {
            var parameters = new Dictionary<string, string>();

            parameters["Server"] = serverUrl.Text;
            parameters["Port"] = port.Value.ToString();
            parameters["Uid"] = username.Text;
            parameters["Pwd"] = password.Text;

            return parameters;
        }
    }
}
