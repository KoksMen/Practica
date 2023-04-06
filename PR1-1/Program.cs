using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int variant = 18;
            setWidthHeightConsole(variant);
        }

        private static void setWidthHeightConsole(int variant)
        {
            int size = 10 + variant * 4;
            int width = size;
            int height = size;
            Console.SetWindowSize(width, height);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Nishpor Nikita, PC-31, Variant 18, Practice 1, Zadanie 1";
        }
    }
}
