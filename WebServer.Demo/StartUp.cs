using WebServer.Server;

public class StartUp
{
    public static void Main()
    {
        var server = new HttpServer("127.0.0.1", 8080);
        server.Start();
    }
}