using DBManager.Core.Views.Helpers;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBManager.Views
{
    [ToolboxItem(true)]
    public partial class StatusStripView : UserControl
    {
        public StatusStripView()
        {
            InitializeComponent();
        }

        public void InitializeView(ImageList imageList)
        {
            Status_StatusStrip.ImageList = imageList;
        }

        private ToolStripItem ConnectionsToolStripItem => Status_StatusStrip.Items["Connections_ToolStripStatusLabel"];
        private ToolStripItem ConnectionToolStripItem => Status_StatusStrip.Items["Connection_ToolStripStatusLabel"];
        private ToolStripItem DatabaseToolStripItem => Status_StatusStrip.Items["Database_ToolStripStatusLabel"];
        private ToolStripItem TableToolStripItem => Status_StatusStrip.Items["Table_ToolStripStatusLabel"];

        public void UpdateNumberOfConnectionsStatus(int numberOfConnections)
        {
            ConnectionsToolStripItem.Text = $"Connections: {numberOfConnections}";
            ConnectionsToolStripItem.ImageIndex = 0;
        }

        public void UpdateNodeStatus(TreeNodeElements nodes)
        {
            ConnectionToolStripItem.Text = string.Empty;
            DatabaseToolStripItem.Text = string.Empty;
            TableToolStripItem.Text = string.Empty;

            ConnectionToolStripItem.ImageIndex = -1;
            DatabaseToolStripItem.ImageIndex = -1;
            TableToolStripItem.ImageIndex = -1;

            if (nodes.Connection != null)
            {
                ConnectionToolStripItem.Text = $"Connection: {nodes.Connection.Text}";
                ConnectionToolStripItem.ImageIndex = 0;
            }

            if (nodes.Database != null)
            {
                DatabaseToolStripItem.Text = $"Database: {nodes.Database.Text}";
                DatabaseToolStripItem.ImageIndex = 1;
            }

            if (nodes.Table != null)
            {
                TableToolStripItem.Text = $"Table: {nodes.Table.Text}";
                TableToolStripItem.ImageIndex = 2;
            }
        }

        public void ClearNodeStatus()
        {
            ConnectionToolStripItem.Text = string.Empty;
            DatabaseToolStripItem.Text = string.Empty;
            TableToolStripItem.Text = string.Empty;
        }
    }
}
