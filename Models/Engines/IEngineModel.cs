using DBManager.Utils;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.Models.Engines
{
    public interface IEngineModel
    {
        string Name { get; }
        EngineType Type { get; }
        Task<DataTable> ExecuteQuery(string query);
        Task<int> ExecuteNonQuery(string query);
        Task ChangeDatabase(string databaseName);
    }
}
