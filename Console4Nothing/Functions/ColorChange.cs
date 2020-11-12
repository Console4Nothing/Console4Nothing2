using System;
using System.Drawing;
using Console = Colorful.Console;
using Console4Nothing.Functions;

namespace Console4Nothing.Functions
{
    public class ColorChange
    {
        public static void MainColor() { Console.ForegroundColor = Color.FromArgb(0, 102, 255);}
        public static void AccentColor() { Console.ForegroundColor = Color.FromArgb(102, 153, 255); }
        public static void WritingColor() { Console.ForegroundColor = Color.FromArgb(229, 250, 255); }

        public static void RGB(int Red, int Green, int Blue) 
        {
           Console.ForegroundColor = Color.FromArgb(Red,Green,Blue); 
        }

    }

}
