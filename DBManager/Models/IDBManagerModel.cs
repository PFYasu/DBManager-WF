using DBManager.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBManager.Models
{
    public interface IDBManagerModel
    {
        Task LoadConnections();
        List<string> GetConnectionNames();
        void AddConnection(Connection connection);
        Connection GetConnection(string connectionName);
        void RemoveConnection(string connectionName);
        Task SaveConnections();
    }
}