using System.Text;

namespace WebServer.Server.HTPP
{
    public class Response
    {
        public Response(StatusCode statusCode)
        {
            this.StatusCode = statusCode;

            this.Headers.Add(Header.Server, "My Web Server");
            this.Headers.Add(Header.Date, $"{DateTime.UtcNow:R}");

            //this.Headers.Add("Server", "My Web Server");
            //this.Headers.Add("Date", $"{DateTime.UtcNow:R}");
        }

        public StatusCode StatusCode { get; init; }

        public HeaderCollection Headers { get; } = new HeaderCollection();

        public string Body { get; set; }

        public Action<Request, Response> PreRenderAction { get; protected set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"HTTP/1.1 {(int)this.StatusCode} {this.StatusCode}");

            foreach (var header in this.Headers)
            {
                result.AppendLine(header.ToString());
            }

            result.AppendLine();

            if (!string.IsNullOrEmpty(this.Body))
            {
                result.AppendLine(this.Body);
            }

            return result.ToString();
        }
    }
}
