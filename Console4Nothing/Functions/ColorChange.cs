using System.Drawing;
using Console = Colorful.Console;

namespace Console4Nothing.Functions
{
    public static class ColorChange
    {
        internal static void MainColor() { Console.ForegroundColor = Color.FromArgb(0, 102, 255);}
        internal static void AccentColor() { Console.ForegroundColor = Color.FromArgb(102, 153, 255); }
        internal static void WritingColor() { Console.ForegroundColor = Color.FromArgb(229, 250, 255); }

        internal static void Rgb(int red, int green, int blue) 
        {
           Console.ForegroundColor = Color.FromArgb(red,green,blue); 
        }

    }

}
