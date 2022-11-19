using DBManager.Core.Views.Helpers;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBManager.Views.OverridedControls;

[ToolboxItem(true)]
public class ConnectionStatusStrip : StatusStrip
{
    private ToolStripItem ConnectionsToolStripItem => Items["Connections_ToolStripStatusLabel"];
    private ToolStripItem ConnectionToolStripItem => Items["Connection_ToolStripStatusLabel"];
    private ToolStripItem DatabaseToolStripItem => Items["Database_ToolStripStatusLabel"];
    private ToolStripItem TableToolStripItem => Items["Table_ToolStripStatusLabel"];

    public void UpdateNumberOfConnectionsStatus(int numberOfConnections)
    {
        ConnectionsToolStripItem.Text = $"Connections: {numberOfConnections}";
    }

    public void UpdateNodeStatus(TreeNodeElements nodes)
    {
        ClearNodeStatus();

        if (nodes.Connection != null)
        {
            ConnectionToolStripItem.Text = $"Connection: {nodes.Connection.Text}";
            ConnectionToolStripItem.Visible = true;
        }

        if (nodes.Database != null)
        {
            DatabaseToolStripItem.Text = $"Database: {nodes.Database.Text}";
            DatabaseToolStripItem.Visible = true;
        }

        if (nodes.Table != null)
        {
            TableToolStripItem.Text = $"Table: {nodes.Table.Text}";
            TableToolStripItem.Visible = true;
        }
    }

    public void ClearNodeStatus()
    {
        ConnectionToolStripItem.Visible = false;
        DatabaseToolStripItem.Visible = false;
        TableToolStripItem.Visible = false;
    }
}
