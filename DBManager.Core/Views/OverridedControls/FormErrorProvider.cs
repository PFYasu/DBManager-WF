using System.ComponentModel;
using System.Windows.Forms;

namespace DBManager.Core.Views.OverridedControls;

[ToolboxItem(true)]
public class FormErrorProvider : ErrorProvider
{
    public int ErrorCount { get; private set; } = 0;

    public new void SetError(Control control, string errorMessage)
    {
        base.SetError(control, errorMessage);
        ErrorCount++;
    }

    public new void Clear()
    {
        base.Clear();
        ErrorCount = 0;
    }
}
