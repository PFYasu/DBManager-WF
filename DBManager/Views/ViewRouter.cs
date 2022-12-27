using DBManager.Views.Engines;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.Views;

public static class ViewRouter
{
    private static IServiceProvider _serviceProvider;

    public static void Initialize(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public static async Task<ConnectionView> GetConnectionView(string connectionName)
    {
        var view = (ConnectionView)_serviceProvider.GetService(typeof(ConnectionView));
        await view.InitializeView(connectionName);

        return view;
    }

    public static async Task<DatabaseView> GetDatabaseView(string connectionName, string databaseName)
    {
        var view = (DatabaseView)_serviceProvider.GetService(typeof(DatabaseView));
        await view.InitializeView(connectionName, databaseName);

        return view;
    }

    public static async Task<TableView> GetTableView(string connectionName, string databaseName, string tableName)
    {
        var view = (TableView)_serviceProvider.GetService(typeof(TableView));
        await view.InitializeView(connectionName, databaseName, tableName);

        return view;
    }

    public static DataTransferView GetDataTransferView(DataTable dataToTransfer)
    {
        var view = (DataTransferView)_serviceProvider.GetService(typeof(DataTransferView));
        view.InitializeView(dataToTransfer);

        return view;
    }

    public static NewTrackedQueryView GetNewTrackedQueryView(string connectionName, string databaseName, string queryPreview)
    {
        var view = (NewTrackedQueryView)_serviceProvider.GetService(typeof(NewTrackedQueryView));
        view.InitializeView(connectionName, databaseName, queryPreview);

        return view;
    }

    public static async Task<QueryView> GetQueryView(string connectionName, string databaseName)
    {
        var view = (QueryView)_serviceProvider.GetService(typeof(QueryView));
        await view.InitializeView(connectionName, databaseName);

        return view;
    }

    public static TrackedQueriesView GetTrackedQueriesView(string connectionName, string databaseName)
    {
        var view = (TrackedQueriesView)_serviceProvider.GetService(typeof(TrackedQueriesView));
        view.InitializeView(connectionName, databaseName);

        return view;
    }
}
