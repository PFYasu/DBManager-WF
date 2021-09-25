namespace DBManager.Presenters
{
    public abstract class DBManagerPresenterDatabaseOperationBase : PresenterBase
    {
        public abstract Response GetConnectionNames();
        public abstract Response GetPresenter(string connectionName);
    }
}
