using DBManager.Presenters;
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

        serviceCollection.AddSingleton<IEngineModuleResolver, EngineModuleResolver>();
        serviceCollection.AddSingleton<IFileManager, FileManager>();

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
    }
}
