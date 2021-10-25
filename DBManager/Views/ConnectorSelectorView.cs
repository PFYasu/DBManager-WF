using DBManager.Presenters;
using DBManager.Views.Engines.MySql;
using DBManager.Views.Engines.PostgreSQL;
using DBManager.Views.Helpers;
using System;
using System.Windows.Forms;

namespace DBManager.Views
{
    public partial class ConnectorSelectorView : Form
    {
        private readonly DBManagerPresenterBase _presenter;
        private readonly MessageHelper _messageHelper;

        public ConnectorSelectorView(DBManagerPresenterBase presenter)
        {
            _presenter = presenter;
            _messageHelper = new MessageHelper("DBManager - new connection");

            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MySql_Button_Click(object sender, EventArgs e)
        {
            using var form = new MySqlConnectorView(_presenter);

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                DialogResult = DialogResult.OK;
        }

        private void PostgreSQL_Button_Click(object sender, EventArgs e)
        {
            using var form = new PostgreSQLConnectorView(_presenter);

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                DialogResult = DialogResult.OK;
        }
    }
}
