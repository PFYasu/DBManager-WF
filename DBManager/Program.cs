using DBManager.Core.Utils.Log;
using DBManager.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace DBManager
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Logger.Log(LogType.Information, "DBManager has been started. Initializing DBManager subsystems.");

                var serviceProvider = Startup.Configure();
                var view = serviceProvider.GetService<DBManagerView>();

                Application.Run(view);
            }
            catch (Exception exception)
            {
                ShowException(exception);
            }
        }

        private static void ShowException(Exception exception)
        {
            var exceptionView = new ExceptionView(exception);
            Application.Run(exceptionView);
        }
    }
}
