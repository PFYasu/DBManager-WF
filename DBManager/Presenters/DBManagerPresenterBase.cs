using DBManager.Dto;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public abstract class DBManagerPresenterBase : DBManagerPresenterDatabaseOperationBase
    {
        public abstract Task<Response> AddConnection(AddConnectionDto dto);
        public abstract Task<Response> RemoveConnection(string connectionName);
    }
}
