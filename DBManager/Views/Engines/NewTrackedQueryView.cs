using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using DBManager.Views.Helpers;
using System;
using System.Windows.Forms;

namespace DBManager.Views.Engines
{
    public partial class NewTrackedQueryView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly MessageHelper _messageHelper;
        private readonly string _databaseName;

        public NewTrackedQueryView(EnginePresenterBase presenter, string databaseName, string queryPreview = null)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _messageHelper = new MessageHelper("DBManager - Tracked query configuration");

            InitializeComponent();

            if (queryPreview != null)
                query.Text = queryPreview;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (IsValidForm(out string error) == false)
            {
                _messageHelper.ShowError(error);
                return;
            }

            var dto = PrepareDto();

            var response = _presenter.QueryTrackerDriver.AddTrackedQuery(dto);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError($"Unable to add new tracked query.", response.Payload);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValidForm(out string error)
        {
            if (string.IsNullOrEmpty(name.Text))
                error = "Name cannot be empty.";
            else if (string.IsNullOrEmpty(query.Text))
                error = "Query cannot be empty.";
            else if (string.IsNullOrEmpty(timePeriod.Value.ToString()))
                error = "Time period cannot be empty.";
            else if (timePeriod.Value <= 0)
                error = "Time period must have a positive value";
            else if (QueryHelper.QueryTypeResolver.GetQueryType(query.Text) == QueryType.NonQuery)
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
                Name = name.Text,
                DatabaseName = _databaseName,
                Query = query.Text,
                TimePeriod = (uint)timePeriod.Value
            };

            return dto;
        }
    }
}
