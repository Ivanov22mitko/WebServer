using WebServer.Server.HTPP;

namespace WebServer.Server.Responses
{
    public class NotFoundResponse : Response
    {
        public NotFoundResponse()
            : base(StatusCode.NotFound)
        {
        }
    }
}
