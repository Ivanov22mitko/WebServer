﻿namespace WebServer.Server.HTPP
{
    public class Response
    {
        public Response(StatusCode statusCode)
        {
            this.StatusCode = statusCode;

            this.Headers.Add("Server", "My Web Server");
            this.Headers.Add("Date", $"{DateTime.UtcNow:R}");
        }

        public StatusCode StatusCode { get; init; }

        public HeaderCollection Headers { get; set; }

        public string Body { get; set; }
    }
}