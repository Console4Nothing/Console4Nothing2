using Console4NothingLoader;

namespace Console4Nothing
{
    public class Main
    {
        private static readonly Logger Logger = new Logger();
        
        public static void OnApplicationStart()
        {
            Logger.AddLine("called");
            WebSocketStuff.Main.Init();
            Menu.Init();
        }
    }
}