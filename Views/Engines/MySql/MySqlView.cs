using DBManager.Dto.Engines;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using System;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly MessageHelper _messageHelper;

        public MySqlView(EnginePresenterBase presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DBManager - MySql");

            InitializeComponent();
        }

        private async void sendQuery_Click(object sender, EventArgs e)
        {
            string query = inputQuery.Text;

            var response = await _presenter.SendQuery("test", query); //TODO: another way to determine current database

            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to send query.", response.Payload);
                return;
            }

            var payload = response.Payload as ExecuteQueryResponseDto;
            executeQueryResult.DataSource = payload.DataTable;
        }
    }
}
