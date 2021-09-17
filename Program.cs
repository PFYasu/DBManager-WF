using DBManager.Models;
using DBManager.Presenters;
using DBManager.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    static class Program
    {
        [STAThread]
        static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = await DBManagerModel.Initialize();
            var presenter = new DBManagerPresenter(model);
            var view = new DBManagerView(presenter);

            Application.Run(view);
        }
    }
}
