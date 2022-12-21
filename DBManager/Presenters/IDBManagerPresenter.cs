using DBManager.Core.Dto;
using DBManager.Core.Presenters;

namespace DBManager.Presenters
{
    public interface IDBManagerPresenter
    {
        Response AddConnection(AddConnectionDto dto);
        Response RemoveConnection(string connectionName);
        Response UpdateConnection(UpdateConnectionDto dto);
        Response<ConnectionNamesResponseDto> GetConnectionNames();
        Response<PresenterResponseDto> GetPresenter(string connectionName);
        Response<AddConnectionDto> GetConnectionSettings(string connectionName);
    }
}
