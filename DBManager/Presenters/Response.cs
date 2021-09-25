namespace DBManager.Presenters
{
    public class Response
    {
        public ResponseType Type { get; set; }
        public object Payload { get; set; }
    }

    public enum ResponseType
    {
        Ok,
        Error
    }
}
