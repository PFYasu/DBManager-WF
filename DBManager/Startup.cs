using DBManager.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Utils.Files;
using DBManager.Views;
using DBManager.Views.Engines;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DBManager;

public static class Startup
{
    public static IServiceProvider Configure()
    {
        var serviceCollection = new ServiceCollection();

        ConfigureViews(serviceCollection);

        serviceCollection.AddSingleton<IEngineModuleResolver, EngineModuleResolver>();
        serviceCollection.AddSingleton<IFileManager, FileManager>();
        serviceCollection.AddTransient<IConnectionPresenter, ConnectionPresenter>();
        serviceCollection.AddTransient<IDatabasePresenter, DatabasePresenter>();
        serviceCollection.AddTransient<ITablePresenter, TablePresenter>();
        serviceCollection.AddTransient<IDataTransferPresenter, DataTransferPresenter>();

        serviceCollection.AddSingleton<IDBManagerPresenter, DBManagerPresenter>(service =>
        {
            var fileManager = service.GetService<IFileManager>();
            var engineModuleResolver = service.GetService<IEngineModuleResolver>();

            var dbManagerPresenter = new DBManagerPresenter(fileManager, engineModuleResolver);
            dbManagerPresenter.InitializeEnginePresenters();

            return dbManagerPresenter;
        });

        var serviceProvider = serviceCollection.BuildServiceProvider();
            
        return serviceProvider;
    }

    private static void ConfigureViews(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<DBManagerView>();
        serviceCollection.AddSingleton<ConnectionView>();
        serviceCollection.AddSingleton<DatabaseView>();
        serviceCollection.AddSingleton<TableView>();
        serviceCollection.AddSingleton<DataTransferView>();
    }
}
