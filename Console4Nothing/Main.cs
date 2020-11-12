using Console4NothingLoader;
using Console4Nothing;
namespace Console4Nothing
{
    public class Main
    {
        private static readonly Logger Logger = new Logger();
        
        public static void OnApplicationStart()
        {
            Logger.AddLine("called");
            Menu.Init();
            // start websocket stuff
            // ToDo: Add websocket connection
            // end websocket stuff
            
        }
    }
}