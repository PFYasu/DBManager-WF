using DBManager.Core.Dto.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Utils;
using DBManager.Core.Views.Helpers;
using DBManager.Presenters.Engines;
using System;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class NewTrackedQueryView : Form
    {
        private readonly INewTrackedQueryPresenter _presenter;
        private readonly MessageHelper _messageHelper;
        private string _connectionName;
        private string _databaseName;

        public NewTrackedQueryView(INewTrackedQueryPresenter presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DBManager - Tracked query configuration");

            InitializeComponent();
        }

        public void InitializeView(string connectionName, string databaseName, string queryPreview)
        {
            _connectionName = connectionName;
            _databaseName = databaseName;

            Query_RichTextBox.Text = queryPreview;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (IsValidForm(out string error) == false)
            {
                _messageHelper.ShowError(error);
                return;
            }

            var dto = PrepareDto();

            var response = _presenter.AddTrackedQuery(dto);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to add new tracked query.", response.ErrorMessage);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValidForm(out string error)
        {
            if (string.IsNullOrEmpty(Name_TextBox.Text))
                error = "Name cannot be empty.";
            else if (string.IsNullOrEmpty(Query_RichTextBox.Text))
                error = "Query cannot be empty.";
            else if (string.IsNullOrEmpty(TimePeriod_NumericUpDown.Value.ToString()))
                error = "Time period cannot be empty.";
            else if (TimePeriod_NumericUpDown.Value <= 0)
                error = "Time period must have a positive value";
            else if (QueryTypeResolver.GetQueryType(Query_RichTextBox.Text) == QueryType.NonQuery)
                error = "Query cannot be non query type.";
            else
            {
                error = null;
                return true;
            }
            return false;
        }

        private NewTrackedQueryDto PrepareDto()
        {
            var dto = new NewTrackedQueryDto
            {
                Name = Name_TextBox.Text,
                ConnectionName = _connectionName,
                DatabaseName = _databaseName,
                Query = Query_RichTextBox.Text,
                TimePeriod = (uint)TimePeriod_NumericUpDown.Value
            };

            return dto;
        }
    }
}
