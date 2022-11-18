namespace DBManager.Core.Presenters
{
    public class Response<T> where T : class
    {
        public ResponseType Type { get; set; }
        public T Payload { get; set; }
        public string ErrorMessage { get; set; }

        public static Response<T> Ok(T payload)
            => new()
            {
                Type = ResponseType.Ok,
                Payload = payload,
                ErrorMessage = null
            };

        public static Response<T> Error(string errorMessage)
            => new()
            {
                Type = ResponseType.Error,
                Payload = null,
                ErrorMessage = errorMessage
            };
    }

    public class Response
    {
        public ResponseType Type { get; set; }
        public string ErrorMessage { get; set; }

        public static Response Ok()
            => new()
            {
                Type = ResponseType.Ok,
                ErrorMessage = null
            };

        public static Response Error(string errorMessage)
            => new()
            {
                Type = ResponseType.Error,
                ErrorMessage = errorMessage
            };
    }

    public enum ResponseType
    {
        Ok,
        Error
    }
}
