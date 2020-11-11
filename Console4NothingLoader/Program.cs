using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

namespace Console4NothingLoader
{
    internal class Program
    {
        private static Logger _logger = new Logger();
        
        public static void Main(string[] args)
        {
            _logger.Init();
            _logger.AddLine("loading console4nothing");
#if DEBUG
            try
            {
                Loader.Load(File.ReadAllBytes("Console4Nothing.dll"));
            }
            catch (Exception e)
            {
                _logger.AddLine("Failed to load console4nothing");
                _logger.AddLine(e.ToString());
            }
#endif
            try
            {
                Loader.Load(new WebClient().DownloadData("https://files.nekro-works.de/Console4Nothing.dll"));
            }
            catch (Exception e)
            {
                _logger.AddLine("Failed to load console4nothing");
                _logger.AddLine(e.ToString());
            }

            while (!Logger.loggerDone) Thread.Sleep(100);
        }
    }
}