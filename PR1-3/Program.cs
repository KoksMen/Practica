using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = -0.19;
            double b = 7.25;
            double c = -0.48;

            double result = getY(a, b, c);

            Console.WriteLine($"Y result = {result}");

        }

        static double getY(double a, double b, double c)
        {
            double y;

            y = (3 * Math.Sin(a * Math.Pow(b, 2)) - Math.Pow(Math.Cos(c), 3)) / (Math.Pow(Math.E, a) - Math.Pow(b, (c+a)));

            return y;
        }
    }
}
