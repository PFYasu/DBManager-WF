using System;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class ExceptionView : Form
    {
        public ExceptionView(Exception exception)
        {
            InitializeComponent();
            InitializeView(exception);
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeView(Exception exception)
        {
            ExceptionType_Label.Text = exception.GetType().Name;
            StackTrace_RichTextBox.Text = $"{exception.Message}\n\n{exception.StackTrace}";
        }
    }
}
