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
        private readonly MessageHelper _messageHelper;

        public MySqlConnectorView(DBManagerPresenterBase presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DBManager - MySQL connector");

            InitializeComponent();
            port.Controls[0].Hide();
        }

        private async void save_Click(object sender, EventArgs e)
        {
            if (IsValidForm(out string error) == false)
                _messageHelper.ShowError(error);
            else
            {
                var dto = PrepareDto();

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

        private AddConnectionDto PrepareDto()
        {
            var parameters = new Dictionary<string, string>();

            parameters["Server"] = serverUrl.Text;
            parameters["Port"] = port.Value.ToString();
            parameters["Uid"] = username.Text;
            parameters["Pwd"] = password.Text;

            var dto = new AddConnectionDto
            {
                Type = EngineType.MySql,
                ConnectionParameters = parameters,
                Name = name.Text
            };

            return dto;
        }
    }
}
