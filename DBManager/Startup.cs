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

        serviceCollection.AddTransient<IEngineModuleResolver, EngineModuleResolver>();
        serviceCollection.AddTransient<IFileManager, FileManager>();
        serviceCollection.AddTransient<IConnectionPresenter, ConnectionPresenter>();
        serviceCollection.AddTransient<IDatabasePresenter, DatabasePresenter>();
        serviceCollection.AddTransient<ITablePresenter, TablePresenter>();
        serviceCollection.AddTransient<IDataTransferPresenter, DataTransferPresenter>();
        serviceCollection.AddTransient<IQueryPresenter, QueryPresenter>();
        serviceCollection.AddTransient<INewTrackedQueryPresenter, NewTrackedQueryPresenter>();
        serviceCollection.AddTransient<ITrackedQueriesPresenter, TrackedQueriesPresenter>();

        serviceCollection.AddTransient<IDBManagerPresenter, DBManagerPresenter>(service =>
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
        serviceCollection.AddTransient<DBManagerView>();
        serviceCollection.AddTransient<ConnectionView>();
        serviceCollection.AddTransient<DatabaseView>();
        serviceCollection.AddTransient<TableView>();
        serviceCollection.AddTransient<DataTransferView>();
        serviceCollection.AddTransient<QueryPresenter>();
        serviceCollection.AddTransient<NewTrackedQueryView>();
        serviceCollection.AddTransient<QueryView>();
        serviceCollection.AddTransient<TrackedQueriesView>();
    }
}
