using DBManager.Utils;

namespace DBManager.Dto
{
    public class Response
    {
        public ResponseType Type { get; set; }
        public object Payload { get; set; }
    }
}
