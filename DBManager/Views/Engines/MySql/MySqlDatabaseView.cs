using DBManager.Presenters.Engines;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlDatabaseView : Form
    {
        private readonly EnginePresenterBase _presenter;
        private readonly string _databaseName;

        public MySqlDatabaseView(EnginePresenterBase presenter, string databaseName)
        {
            _presenter = presenter;
            _databaseName = databaseName;

            InitializeComponent();
        }
    }
}
