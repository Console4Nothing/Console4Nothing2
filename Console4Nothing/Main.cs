using Console4NothingLoader;

namespace Console4Nothing
{
    public class Main
    {
        private static Logger _logger = new Logger();
        
        public static void OnApplicationStart()
        {
            _logger.AddLine("called");
            // start websocket stuff
            // ToDo: Add websocket connection
            // end websocket stuff
            
        }
    }
}