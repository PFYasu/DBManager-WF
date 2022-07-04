using DBManager.Core.Views.Engines;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters;
using System;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class ConnectorSelectorView : Form
    {
        private readonly ConnectorMethods _connectorMethods;
        private readonly MessageHelper _messageHelper;

        public ConnectorSelectorView(IDBManagerPresenter presenter)
        {
            _connectorMethods = new ConnectorMethods
            {
                AddConnection = presenter.AddConnection,
                GetConnectionSettings = presenter.GetConnectionSettings,
                UpdateConnection = presenter.UpdateConnection
            };

            _messageHelper = new MessageHelper("DBManager - new connection");

            InitializeComponent();
            InitializeView();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigureConnection_Button_Click(object sender, EventArgs e)
        {
            if (AvailableConnectionTypes_ListView.SelectedItems.Count == 0)
            {
                ConfigureConnection_Button.Enabled = false;
                return;
            }

            var engineType = AvailableConnectionTypes_ListView.SelectedItems[0].Text;

            if (EngineModules.Attributes.TryGetValue(engineType, out var engineModuleAttribute) == false)
            {
                _messageHelper.ShowError("Unable to create connector update view - incorrect engine type.");
                return;
            }

            var form = (Form)Activator.CreateInstance(
                engineModuleAttribute.ConnectorView,
                _connectorMethods);

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                DialogResult = DialogResult.OK;
        }

        private void AvailableConnectionTypes_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableConnectionTypes_ListView.SelectedItems.Count == 0)
            {
                ConfigureConnection_Button.Enabled = false;
                return;
            }

            ConfigureConnection_Button.Enabled = true;
        }

        private void InitializeView()
        {
            AvailableConnectionTypes_ListView.Columns[0].Width = -2;
            ConfigureConnection_Button.Enabled = false;

            foreach (var engineModuleName in EngineModules.Attributes.Keys)
            {
                var engineType_ListViewItem = new ListViewItem
                {
                    Text = engineModuleName
                };

                AvailableConnectionTypes_ListView.Items.Add(engineType_ListViewItem);
            }
        }
    }
}
