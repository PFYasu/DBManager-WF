using DBManager.Dto;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public interface IDBManagerPresenter
    {
        Task<Response> AddConnection(AddConnectionDto dto);
        Task<Response> RemoveConnection(string connectionName);
        Task<Response> UpdateConnection(UpdateConnectionDto dto);
        Response GetConnectionNames();
        Response GetPresenter(string connectionName);
        Response GetConnectionSettings(string connectionName);
    }
}
