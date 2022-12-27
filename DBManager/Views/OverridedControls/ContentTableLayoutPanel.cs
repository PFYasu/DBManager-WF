using DBManager.Core.Views.Helpers;
using DBManager.Views.Utils;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.OverridedControls;

[ToolboxItem(true)]
public class ContentTableLayoutPanel : TableLayoutPanel
{
    public event EventHandler<bool> OnFormRequestedChange;

    public async Task ChangeContent(TreeNodeElements treeNodeElements)
    {
        Form form = treeNodeElements.Mode switch
        {
            TreeNodeMode.ConnectionSelected => await ViewRouter.GetConnectionView(treeNodeElements.Connection.Name),
            TreeNodeMode.DatabaseSelected => await ViewRouter.GetDatabaseView(treeNodeElements.Connection.Name, treeNodeElements.Database.Name),
            TreeNodeMode.TableSelected => await ViewRouter.GetTableView(treeNodeElements.Connection.Name, treeNodeElements.Database.Name, treeNodeElements.Table.Name),
            _ => throw new NotImplementedException("Unable to create view - incorrect tree node mode.")
        };

        form.TopLevel = false;
        form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        form.Text = treeNodeElements.Connection.Text;

        Controls.Clear();
        Controls.Add(form);

        form.Show();
    }

    public bool ClearViewIfNeeded(string connectionName)
    {
        if (this.TryGetControl(out var control) == false)
            return false;

        if (control.Text != connectionName)
            return false;

        control.Dispose();
        Controls.Clear();

        return true;
    }
}
