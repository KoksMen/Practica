using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 14;
            double b = 12;
            double q = 3;

            double result = getSquare(a, b, q);
            Console.WriteLine($"Result = {result}");

        }

        public static double getSquare(double a, double b, double q)
        {
            double result;

            double h = (Math.Abs(a - b) / 2) * Math.Sin(q * Math.PI / 180) / Math.Cos(q * Math.PI / 180);
            result = ((a + b) * h) / 2;

            return result;
        }
    }
}
