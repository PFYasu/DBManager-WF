using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class ConnectionView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly MessageHelper _messageHelper;

        public ConnectionView(EnginePresenterBase presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DBManager - connection view");

            InitializeComponent();
        }

        private async void MySqlConnectionView_Load(object sender, EventArgs e)
        {
            await InitializeView();
        }

        public async Task InitializeView()
        {
            var response = await _presenter.GetConnectionDetails();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get connection details.", response.Payload);
                return;
            }

            var payload = response.Payload as ConnectionDetailsResponseDto;

            structure_connectionParametersDataGridView.Rows.Clear();

            for (int i = 0; i < payload.DatabasesStructure.Count; i++)
            {
                structure_connectionParametersDataGridView.Rows.Insert(
                    i,
                    i,
                    payload.DatabasesStructure[i].Name);
            }

            structure_databasesCountLabel.Text = $"Databases: {payload.DatabasesCount}";

            informations_connectionNameLabel.Text = $"Name: {payload.Name}";
            informations_typeLabel.Text = $"Type: {payload.Type}";
            informations_loggedAsLabel.Text = $"Logged as: {payload.Uid}";
            informations_serverLabel.Text = $"Server: {payload.Server}";
            informations_portLabel.Text = $"Port: {payload.Port}";
        }
    }
}
