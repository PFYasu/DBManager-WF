using DBManager.Presenters.Engines;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlDatabaseView : Form
    {
        private readonly EnginePresenterBase _presenter;

        public MySqlDatabaseView(EnginePresenterBase presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }
    }
}
