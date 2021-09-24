using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBManager.Models
{
    public interface IDBManagerModel
    {
        Task LoadConnections();
        List<string> GetConnectionNames();
        Task AddConnection(Connection connection);
        Connection GetConnection(string connectionName);
        Task RemoveConnection(string connectionName);
    }
}
