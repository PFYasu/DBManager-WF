using DBManager.Core.Presenters;
using System;
using System.Windows.Forms;

namespace DBManager.Core.Views.Helpers
{
    public class MessageHelper
    {
        private readonly string _viewName;

        public MessageHelper(string viewName)
        {
            _viewName = viewName;
        }

        public void ShowError(string comment, Response response)
        {
            var message = response.Payload as string;
            var errorMessage = $"{comment}\n\n{message}";

            ShowError(errorMessage);
        }

        public void ShowError(string comment, Exception exception)
        {
            var errorMessage = $"{comment}\n\n{exception.Message}";

            ShowError(errorMessage);
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
