using DBManager.Views.Engines;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.Views;

public class ViewRouter
{
    private readonly ConnectionView _connectionView;
    private readonly DatabaseView _databaseView;
    private readonly TableView _tableView;
    private readonly DataTransferView _dataTransferView;

    public ViewRouter(
        ConnectionView connectionView,
        DatabaseView databaseView,
        TableView tableView,
        DataTransferView dataTransferView)
    {
        _connectionView = connectionView;
        _databaseView = databaseView;
        _tableView = tableView;
        _dataTransferView = dataTransferView;
    }

    public async Task<ConnectionView> GetConnectionView(string connectionName)
    {
        await _connectionView.InitializeView(connectionName);
        return _connectionView;
    }

    public async Task<DatabaseView> GetDatabaseView(string connectionName, string databaseName)
    {
        await _databaseView.InitializeView(connectionName, databaseName);
        return _databaseView;
    }

    public async Task<TableView> GetTableView(string connectionName, string databaseName, string tableName)
    {
        await _tableView.InitializeView(connectionName, databaseName, tableName);
        return _tableView;
    }

    public TableView GetDataTransferView(DataTable dataToTransfer)
    {
        _dataTransferView.InitializeView(dataToTransfer);
        return _tableView;
    }
}
