using DBManager.Dto.Engines;
using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Views.Helpers;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlTableView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly string _databaseName;
        private readonly string _tableName;
        private readonly MessageHelper _messageHelper;

        public MySqlTableView(EnginePresenterBase presenter, string databaseName, string tableName)
        {
            _presenter = presenter;
            _databaseName = databaseName;
            _tableName = tableName;
            _messageHelper = new MessageHelper("DBManager - table view");

            InitializeComponent();

            Test();
        }

        public async Task Test()
        {
            tableParametersLayout.SuspendLayout();

            var response = await _presenter.GetTableDetails(_databaseName, _tableName);
            if (response.Type == ResponseType.Error)
            {
                _messageHelper.ShowError("Unable to get table details.", response.Payload);
                return;
            }
            
            var payload = response.Payload as TableDetailsResponseDto;

            tableParametersLayout.RowCount += payload.ColumnsStructure.Count;

            for (int i = 0; i < payload.ColumnsStructure.Count; i++)
            {
                tableParametersLayout.Controls.Add(GetLabel((i + 1).ToString()), 0, i + 1); //Name = $"Name|{payload.TablesDetails[i].Name}", 
                tableParametersLayout.Controls.Add(GetLabel(payload.ColumnsStructure[i].Name), 1, i + 1);
                tableParametersLayout.Controls.Add(GetLabel(payload.ColumnsStructure[i].Type), 2, i + 1);
                tableParametersLayout.Controls.Add(GetLabel(payload.ColumnsStructure[i].ComparingSubtitlesMethod), 3, i + 1);
            }

            tableDataGridView.DataSource = payload.Table;

            browse_rowsCountLabel.Text = $"Elements: {payload.RowsCount}";
            tableStructure_recordsCountLabel.Text = $"Elements: {payload.ColumnsCount}";

            statistics_createdAtLabel.Text = $"Created at: {payload.CreatedAt}";
            statistics_lastUpdateLabel.Text = $"Last update: {payload.LastUpdate}";
            statistics_sizeLabel.Text = $"Size (KB): {payload.Size}";
            statistics_columnsCountLabel.Text = $"Columns: {payload.ColumnsCount}";
            statistics_recordsCountLabel.Text = $"Records: {payload.RowsCount}";

            tableParametersLayout.ResumeLayout();
        }

        public Label GetLabel(string text)
        {
            return new Label
            {
                Text = text,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
        }
    }
}
