using System.Windows.Forms;

namespace DBManager.Views.Utils
{
    public static class ModelExtensions
    {
        public static bool TryGetControl(this TableLayoutPanel tableLayoutPanel, out Control control)
        {
            control = null;

            if (tableLayoutPanel.Controls.Count == 0)
                return false;

            control = tableLayoutPanel.Controls[0];
            return true;
        }
    }
}
