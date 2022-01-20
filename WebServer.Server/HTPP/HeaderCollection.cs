namespace WebServer.Server.HTPP
{
    public class HeaderCollection
    {
        private readonly Dictionary<string, Header> Headers = new Dictionary<string, Header>();

        public int Count => this.Headers.Count;

        public void Add(string name, string value)
        {
            var header = new Header(name, value);

            this.Headers.Add(name, header);
        }
    }
}
