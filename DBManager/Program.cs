using DBManager.Models;
using DBManager.Presenters;
using DBManager.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    public static class Program
    {
        [STAThread]
        public static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                await RunDBManagerComponents();
            }
            catch (Exception exception)
            {
                ShowException(exception);
            }
        }

        private static async Task RunDBManagerComponents()
        {
            await using (var model = await DBManagerModel.Initialize())
            {
                var presenter = new DBManagerPresenter(model);
                var view = new DBManagerView(presenter);
                Application.Run(view);
            }
        }

        private static void ShowException(Exception exception)
        {
            var exceptionView = new ExceptionView(exception);
            Application.Run(exceptionView);
        }
    }
}
