using DBManager.Presenters;
using DBManager.Utils;
using DBManager.Utils.Files;
using DBManager.Views;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DBManager;

public static class Startup
{
    public static IServiceProvider Configure()
    {
        var serviceCollection = new ServiceCollection();

        ConfigureViews(serviceCollection);

        serviceCollection.AddSingleton<IDBManagerActivator, DBManagerActivator>();
        serviceCollection.AddSingleton<IFileManager, FileManager>();

        serviceCollection.AddSingleton<IDBManagerPresenter, DBManagerPresenter>(service =>
        {
            var fileManager = service.GetService<IFileManager>();
            var dbManagerActivator = service.GetService<IDBManagerActivator>();

            var dbManagerPresenter = new DBManagerPresenter(fileManager, dbManagerActivator);
            dbManagerPresenter.InitializeEnginePresenters();

            return dbManagerPresenter;
        });

        var serviceProvider = serviceCollection.BuildServiceProvider();

        return serviceProvider;
    }

    private static void ConfigureViews(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<DBManagerView>();
    }
}
