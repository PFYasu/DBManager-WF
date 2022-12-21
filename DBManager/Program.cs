using DBManager.Core.Utils.Log;
using DBManager.Presenters;
using DBManager.Views;
using Microsoft.Extensions.DependencyInjection;
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var serviceProvider = Startup.Configure();
                await RunDBManagerComponents(serviceProvider);
            }
            catch (Exception exception)
            {
                ShowException(exception);
            }
        }

        private static async Task RunDBManagerComponents(IServiceProvider serviceProvider)
        {
            Logger.Log(LogType.Information, "DBManager has been started. Initializing DBManager subsystems.");

            var presenter = (DBManagerPresenter)serviceProvider.GetService<IDBManagerPresenter>();
            presenter.InitializeEnginePresenters();

            var view = new DBManagerView(presenter);
            Application.Run(view);
        }

        private static void ShowException(Exception exception)
        {
            var exceptionView = new ExceptionView(exception);
            Application.Run(exceptionView);
        }
    }
}
