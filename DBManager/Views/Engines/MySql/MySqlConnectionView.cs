using DBManager.Presenters.Engines;
using System.Windows.Forms;

namespace DBManager.Views.Engines.MySql
{
    public partial class MySqlConnectionView : Form
    {
        private readonly EnginePresenterBase _presenter;

        public MySqlConnectionView(EnginePresenterBase presenter)
        {
            _presenter = presenter;

            InitializeComponent();
        }
    }
}
