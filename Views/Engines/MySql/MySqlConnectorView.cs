using DBManager.Dto;
using DBManager.Presenters;
using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            if (string.IsNullOrEmpty(name.Text))
                _messageHelper.ShowError("Name cannot be empty.");
            else if (string.IsNullOrEmpty(serverUrl.Text))
                _messageHelper.ShowError("Server URL cannot be empty.");
            else if (string.IsNullOrEmpty(port.Value.ToString()))
                _messageHelper.ShowError("Port cannot be empty.");
            else if (string.IsNullOrEmpty(username.Text))
                _messageHelper.ShowError("Username cannot be empty.");
            else if (string.IsNullOrEmpty(password.Text))
                _messageHelper.ShowError("Password cannot be empty.");
            else
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
    }
}
