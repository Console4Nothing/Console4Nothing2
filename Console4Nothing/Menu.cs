using System;
using Console = Colorful.Console;
using Console4Nothing.Functions;

namespace Console4Nothing
{
    internal static class Menu
    {
        private static int MenuDelay = 20;

        internal static void Init()
        {
            // changing the title
            Console.Title = "Console4Nothing²";
            
            // write the menu text
            WriteMenuText();


            Console.ReadKey();
        }

        private static void WriteMenuText(string version = "default")
        {
            if(version == "default")
            {
                Console.WriteLine("\n");
                WriteString.WriteString_Delayed("\tNot suitable for children or those who are easily disturbed.", MenuDelay);
                Console.WriteLine("\n\n");

                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t   ->", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Welcome " + Environment.MachineName + " to Console4Nothing Part 2! ", MenuDelay);
                ColorChange.MainColor();
                WriteString.WriteString_Delayed(" <-", MenuDelay);
                Console.WriteLine("\n");

                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Our current Options!", MenuDelay);
                Console.WriteLine("\n");


                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t   ->", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Calculator", MenuDelay);
                ColorChange.MainColor();
                WriteString.WriteString_Delayed(" <-", MenuDelay);
                Console.WriteLine("\n");
                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Binary to Hex", MenuDelay);
                Console.WriteLine();
                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Binary to Hex", MenuDelay);
                Console.WriteLine();
                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Binary to Hex", MenuDelay);
                Console.WriteLine("\n\n");

                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t   ->", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Games", MenuDelay);
                ColorChange.MainColor();
                WriteString.WriteString_Delayed(" <-", MenuDelay);
                Console.WriteLine("\n");
                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Snake", MenuDelay);
                Console.WriteLine();
                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Tetris", MenuDelay);
                Console.WriteLine();
                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" Tron", MenuDelay);
                Console.WriteLine();
                ColorChange.MainColor();
                WriteString.WriteString_Delayed("\t-", MenuDelay);
                ColorChange.WritingColor();
                WriteString.WriteString_Delayed(" PingPong", MenuDelay);
                Console.WriteLine();
            }
        }
    }
}