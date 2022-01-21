using WebServer.Server.HTPP;

namespace WebServer.Server.Responses
{
    public class UnathorizedResponse : Response
    {
        public UnathorizedResponse()
            : base(StatusCode.Unauthorized)
        {
        }
    }
}
