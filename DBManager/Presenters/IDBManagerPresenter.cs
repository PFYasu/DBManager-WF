using DBManager.Core.Dto;
using DBManager.Core.Presenters;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public interface IDBManagerPresenter
    {
        Task<Response> AddConnection(AddConnectionDto dto);
        Task<Response> RemoveConnection(string connectionName);
        Task<Response> UpdateConnection(UpdateConnectionDto dto);
        Response<ConnectionNamesResponseDto> GetConnectionNames();
        Response<PresenterResponseDto> GetPresenter(string connectionName);
        Response<AddConnectionDto> GetConnectionSettings(string connectionName);
    }
}
