using DBManager.Dto;
using DBManager.Presenters;
using DBManager.Utils;
using DBManager.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBManager.Views.Engines.PostgreSQL
{
    public partial class PostgreSQLConnectorView : Form
    {
        private readonly DBManagerPresenterBase _presenter;
        private readonly MessageHelper _messageHelper;
        private readonly ConnectorMode _connectorMode;

        public PostgreSQLConnectorView(DBManagerPresenterBase presenter)
        {
            _presenter = presenter;
            _connectorMode = ConnectorMode.NewConnection;
            _messageHelper = new MessageHelper("DBManager - PostgreSQL connector");

            InitializeComponent();
            port.Controls[0].Hide();
        }

        public PostgreSQLConnectorView(DBManagerPresenterBase presenter, string connectionName)
        {
            _presenter = presenter;
            _connectorMode = ConnectorMode.UpdateConnection;
            _messageHelper = new MessageHelper("DBManager - PostgreSQL update connector");

            InitializeComponent();
            FillForm(connectionName);

            port.Controls[0].Hide();
        }

        private async void save_Click(object sender, EventArgs e)
        {
            if (IsValidForm(out string error) == false)
                _messageHelper.ShowError(error);
            else
            {
                var dto = PrepareDto();

                if (_connectorMode == ConnectorMode.UpdateConnection)
                {
                    var removeConnectonResponse = await _presenter.RemoveConnection(dto.Name);
                    if (removeConnectonResponse.Type == ResponseType.Error)
                    {
                        _messageHelper.ShowError("Unable to remove connection.", removeConnectonResponse.Payload);
                        return;
                    }
                }

                var response = await _presenter.AddConnection(dto);
                if (response.Type == ResponseType.Error)
                {
                    _messageHelper.ShowError("Unable to add new connection.", response.Payload);
                    return;
                }

                DialogResult = DialogResult.OK;
            }
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

            var payload = response.Payload as ConnectionDto;

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

        private ConnectionDto PrepareDto()
        {
            var parameters = new Dictionary<string, string>();

            parameters["Server"] = serverUrl.Text;
            parameters["Port"] = port.Value.ToString();
            parameters["Uid"] = username.Text;
            parameters["Pwd"] = password.Text;

            var dto = new ConnectionDto
            {
                Type = EngineType.PostgreSQL,
                ConnectionParameters = parameters,
                Name = name.Text
            };

            return dto;
        }
    }
}
