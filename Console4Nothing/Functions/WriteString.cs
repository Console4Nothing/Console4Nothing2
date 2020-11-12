using System;
using System.Threading;

using Console4NothingLoader;

namespace Console4Nothing.Functions
{
    public class WriteString
    {

        private static readonly Logger Logger = new Logger();

        private static Random _random = new Random();

        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        public static void WriteString_Rainbow(string Text)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "NekroWorks Console4Nothing | State: -writing";
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.Write(c);
                Logger.AddLine("Wrote char " + c + " to console in RAINBOWS!!!");
                Thread.Sleep(random.Next(50));
            }

            Console.Title = "NekroWorks Console4Nothing";
        }

        public static void WriteString_(string Text)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "NekroWorks Console4Nothing | State: -writing";
                Console.Write(c);
                Logger.AddLine("Wrote char " + c + " to console in like only one color");
                Thread.Sleep(random.Next(50));
            }

            Console.Title = "NekroWorks Console4Nothing";
        }

        public static void WriteString_Delayed(string Text, int Delay)
        {
            Random random = new Random();

            foreach (char c in Text)
            {
                Console.Title = "NekroWorks Console4Nothing | State: -writing";
                Console.Write(c);
                Logger.AddLine("Wrote char " + c + " to console with delay");
                Thread.Sleep(random.Next(Delay));
            }

            Console.Title = "NekroWorks Console4Nothing";
        }

    }
}
