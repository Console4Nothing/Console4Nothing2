using Console4NothingLoader;

namespace Console4Nothing
{
    public class Main
    {
        private static readonly Logger Logger = new Logger();
        
        public static void OnApplicationStart()
        {
            Logger.AddLine("called");
            // start websocket stuff
            // ToDo: Add websocket connection
            // end websocket stuff
            
        }
    }
}