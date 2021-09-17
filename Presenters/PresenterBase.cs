using DBManager.Dto;
using DBManager.Utils;

namespace DBManager.Presenters
{
    public abstract class PresenterBase
    {
        protected Response Error(string error)
        {
            return new Response
            {
                Type = ResponseType.Error,
                Payload = error
            };
        }

        protected Response Ok()
        {
            return new Response
            {
                Type = ResponseType.Ok,
                Payload = null
            };
        }

        protected Response Ok(object payload)
        {
            return new Response
            {
                Type = ResponseType.Ok,
                Payload = payload
            };
        }
    }
}
