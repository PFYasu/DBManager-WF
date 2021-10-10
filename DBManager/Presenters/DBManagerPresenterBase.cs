using DBManager.Dto;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public abstract class DBManagerPresenterBase : PresenterBase
    {
        public abstract Task<Response> AddConnection(AddConnectionDto dto);
        public abstract Task<Response> RemoveConnection(string connectionName);
        public abstract Task<Response> UpdateConnection(UpdateConnectionDto dto);
        public abstract Response GetConnectionNames();
        public abstract Response GetPresenter(string connectionName);
        public abstract Response GetConnectionSettings(string connectionName);
    }
}
