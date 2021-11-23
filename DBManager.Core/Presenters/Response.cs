namespace DBManager.Core.Presenters
{
    public class Response
    {
        public ResponseType Type { get; set; }
        public object Payload { get; set; }

        public static Response Ok(object payload = null)
        {
            return new Response
            {
                Type = ResponseType.Ok,
                Payload = payload
            };
        }

        public static Response Error(string error)
        {
            return new Response
            {
                Type = ResponseType.Error,
                Payload = error
            };
        }
    }

    public enum ResponseType
    {
        Ok,
        Error
    }
}
