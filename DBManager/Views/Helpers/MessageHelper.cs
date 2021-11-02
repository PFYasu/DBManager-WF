using System.Windows.Forms;

namespace DBManager.Views.Helpers
{
    public class MessageHelper
    {
        private readonly string _viewName;

        public MessageHelper(string viewName)
        {
            _viewName = viewName;
        }

        public void ShowError(string comment, object payload)
        {
            var message = payload as string;
            var errorMessage = $"{comment}\n{message}";

            MessageBox.Show(
                errorMessage,
                _viewName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void ShowError(string comment)
        {
            MessageBox.Show(
                comment,
                _viewName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public DialogResult ShowQuestion(string comment)
        {
            return MessageBox.Show(
                comment,
                _viewName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public void ShowInformation(string comment)
        {
            MessageBox.Show(
                comment,
                _viewName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowWarning(string comment)
        {
            MessageBox.Show(
                comment,
                _viewName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
