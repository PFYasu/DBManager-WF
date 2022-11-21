using DBManager.Core.Presenters.Engines;
using DBManager.Core.Views.Helpers;
using DBManager.Views.Engines;
using DBManager.Views.Utils;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBManager.Views.OverridedControls;

[ToolboxItem(true)]
public class ContentTableLayoutPanel : TableLayoutPanel
{
    public event EventHandler<bool> OnFormRequestedChange;

    public void ChangeContent(IEnginePresenter presenter, TreeNodeElements treeNodeElements)
    {
        Form form = treeNodeElements.Mode switch
        {
            TreeNodeMode.ConnectionSelected => new ConnectionView(presenter),
            TreeNodeMode.DatabaseSelected => new DatabaseView(presenter, treeNodeElements.Database.Text),
            TreeNodeMode.TableSelected => new TableView(presenter, treeNodeElements.Database.Text, treeNodeElements.Table.Text),
            _ => throw new NotImplementedException("Unable to create view - incorrect tree node mode.")
        };

        form.TopLevel = false;
        form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        form.Text = treeNodeElements.Connection.Text;

        if (this.TryGetControl(out var control))
        {
            control.Dispose();
            Controls.Clear();
        }

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
