using DBManager.Presenters.Engines;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlTableView : Form
    {
        private readonly EnginePresenterBase _presenter;

        public MySqlTableView(EnginePresenterBase presenter)
        {
            InitializeComponent();

            _presenter = presenter;
        }
    }
}
