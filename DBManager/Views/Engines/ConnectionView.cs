using DBManager.Core.Presenters;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters.Engines;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class ConnectionView : Form
    {
        private readonly IConnectionPresenter _presenter;
        private readonly MessageHelper _messageHelper = new("DBManager - connection view");

        public ConnectionView(IConnectionPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }

        public async Task InitializeView(string connectionName)
        {
            var response = await _presenter.GetConnectionDetails(connectionName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get connection details.", response.ErrorMessage);
                return;
            }

            var payload = response.Payload;

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
    }
}
