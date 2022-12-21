using DBManager.Presenters;
using DBManager.Utils.Files;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DBManager;

public static class Startup
{
    public static IServiceProvider Configure()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddSingleton<IFileManager, FileManager>();
        serviceCollection.AddSingleton<IDBManagerPresenter, DBManagerPresenter>();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        return serviceProvider;
    }
}
