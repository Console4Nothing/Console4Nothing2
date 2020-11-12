using System;
using System.Threading;
using Console4NothingLoader;

namespace Console4Nothing.Functions
{
    internal static class WriteString
    {

        private static readonly Logger Logger = new Logger();

        private static readonly Random Random = new Random();

        private static ConsoleColor GetRandomConsoleColor()
        {
            Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(Random.Next(consoleColors.Length));
        }

        internal static void WriteString_Rainbow(string text)
        {
            Random random = new Random();

            foreach (char c in text)
            {
                Console.Title = "NekroWorks Console4Nothing | State: -writing";
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.Write(c);
                Logger.AddLine("Wrote char " + c + " to console in RAINBOWS!!!");
                Thread.Sleep(random.Next(50));
            }

            Console.Title = "Console4Nothing²";
        }

        internal static void WriteString_(string text)
        {
            Random random = new Random();

            foreach (char c in text)
            {
                Console.Title = "NekroWorks Console4Nothing | State: -writing";
                Console.Write(c);
                Logger.AddLine("Wrote char " + c + " to console in like only one color");
                Thread.Sleep(random.Next(50));
            }

            Console.Title = "Console4Nothing²";
        }

        internal static void WriteString_Delayed(string text, int delay)
        {
            Random random = new Random();

            foreach (char c in text)
            {
                Console.Title = "NekroWorks Console4Nothing | State: -writing";
                Console.Write(c);
                Logger.AddLine("Wrote char " + c + " to console with delay");
                Thread.Sleep(random.Next(delay));
            }

            Console.Title = "Console4Nothing²";
        }

    }
}
