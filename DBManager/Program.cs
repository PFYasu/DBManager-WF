using DBManager.Core.Utils.Log;
using DBManager.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
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

                AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

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

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var dllName = new AssemblyName(args.Name).Name;
            var fullDllName = $"{dllName}.dll";
            var currentDirectoryPath = Directory.GetCurrentDirectory();

            var dllPaths = Directory.GetFiles(currentDirectoryPath, fullDllName, SearchOption.AllDirectories);
            var dllPath = dllPaths.FirstOrDefault();

            if (dllPath != null)
            {
                Logger.Log(LogType.Information, $"Discovered {dllPath} to load.");
                return Assembly.LoadFile(dllPath);
            }

            return null;
        }
    }
}
