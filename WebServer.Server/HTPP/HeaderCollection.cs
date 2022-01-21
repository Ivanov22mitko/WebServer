using System.Collections;

namespace WebServer.Server.HTPP
{
    public class HeaderCollection : IEnumerable<Header>
    {
        private readonly Dictionary<string, Header> Headers = new Dictionary<string, Header>();

        public int Count => this.Headers.Count;

        public void Add(string name, string value)
        {
            var header = new Header(name, value);

            this.Headers.Add(name, header);
        }

        public IEnumerator<Header> GetEnumerator()
            => this.Headers.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
