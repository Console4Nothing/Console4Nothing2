using System;
using Console = Colorful.Console;
using Console4Nothing.Functions;

namespace Console4Nothing
{
    public class Menu
    {


        internal static void Init()
        {

            int MenuDelay = 20;

            Console.Title = "Console4Nothing²";


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
            Console.WriteLine();
            Console.WriteLine("\n");

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


            Console.ReadKey();
        }
    }
}