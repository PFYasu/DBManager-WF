using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Views.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class ConnectionView : Form
    {
        private readonly IEnginePresenter _presenter;
        private readonly MessageHelper _messageHelper;

        public ConnectionView(IEnginePresenter presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DBManager - connection view");

            InitializeComponent();
        }

        public async Task InitializeView()
        {
            var response = await _presenter.GetConnectionDetails();
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get connection details.", response);
                return;
            }

            var payload = response.Payload as ConnectionDetailsResponseDto;

            Structure_Structure_DataGridView.Rows.Clear();

            for (int i = 0; i < payload.DatabasesStructure.Count; i++)
            {
                Structure_Structure_DataGridView.Rows.Insert(
                    i,
                    i,
                    payload.DatabasesStructure[i].Name);
            }

            Databases_Structure_Label.Text = $"Databases: {payload.DatabasesCount}";

            Name_Structure_Label.Text = $"Name: {payload.Name}";
            Type_Structure_Label.Text = $"Type: {payload.EngineType}";
            LoggedAs_Structure_Label.Text = $"Logged as: {payload.Uid}";
            Server_Structure_Label.Text = $"Server: {payload.Server}";
            Port_Structure_Label.Text = $"Port: {payload.Port}";
        }

        private async void MySqlConnectionView_Load(object sender, EventArgs e)
        {
            await InitializeView();
        }
    }
}
