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
        private readonly IDBManagerPresenter _presenter;
        private readonly ConnectorMode _connectorMode;
        private readonly MessageHelper _messageHelper;
        private readonly string _connectionName;

        public MySqlConnectorView(IDBManagerPresenter presenter)
        {
            _presenter = presenter;
            _connectorMode = ConnectorMode.NewConnection;
            _messageHelper = new MessageHelper("DBManager - MySQL connector");

            InitializeComponent();
            Port_NumericUpDown.Controls[0].Hide();
        }

        public MySqlConnectorView(IDBManagerPresenter presenter, string connectionName)
        {
            _presenter = presenter;
            _connectorMode = ConnectorMode.UpdateConnection;
            _messageHelper = new MessageHelper("DBManager - MySQL update connector");
            _connectionName = connectionName;

            InitializeComponent();
            FillForm(connectionName);

            Port_NumericUpDown.Controls[0].Hide();
        }

        private async void Save_Button_Click(object sender, EventArgs e)
        {
            if (IsValidForm(out string error) == false)
            {
                _messageHelper.ShowError(error);
                return;
            }

            var connectionParameters = PrepareConnectionParameters();
            var type = EngineType.MySql;
            var connectionName = Name_TextBox.Text;

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

        private void Cancel_Button_Click(object sender, EventArgs e)
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
                Name_TextBox.Text = payload.Name;
                ServerUrl_TextBox.Text = payload.ConnectionParameters["Server"];
                Port_NumericUpDown.Value = decimal.Parse(payload.ConnectionParameters["Port"]);
                Username_TextBox.Text = payload.ConnectionParameters["Uid"];
                Password_TextBox.Text = payload.ConnectionParameters["Pwd"];
            }
            catch (Exception exception)
            {
                _messageHelper.ShowError($"Unable to show settings for {connectionName} connection.", exception.Message);
            }
        }

        private bool IsValidForm(out string error)
        {
            if (string.IsNullOrEmpty(Name_TextBox.Text))
                error = "Name cannot be empty.";
            else if (string.IsNullOrEmpty(ServerUrl_TextBox.Text))
                error = "Server URL cannot be empty.";
            else if (string.IsNullOrEmpty(Port_NumericUpDown.Value.ToString()))
                error = "Port cannot be empty.";
            else if (string.IsNullOrEmpty(Username_TextBox.Text))
                error = "Username cannot be empty.";
            else if (string.IsNullOrEmpty(Password_TextBox.Text))
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

            parameters["Server"] = ServerUrl_TextBox.Text;
            parameters["Port"] = Port_NumericUpDown.Value.ToString();
            parameters["Uid"] = Username_TextBox.Text;
            parameters["Pwd"] = Password_TextBox.Text;

            return parameters;
        }
    }
}
