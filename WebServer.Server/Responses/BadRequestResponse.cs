using WebServer.Server.HTPP;

namespace WebServer.Server.Responses
{
    public class BadRequestResponse : Response
    {
        public BadRequestResponse()
            : base(StatusCode.BadRequest)
        {
        }
    }
}
