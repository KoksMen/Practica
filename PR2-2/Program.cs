using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 13.17;
            double x2 = -8.01;
            double x3 = 20.7;

            double result1 = getY(x1);
            double result2 = getY(x2);
            double result3 = getY(x3);

            Console.WriteLine($"Y1 = {result1}");
            Console.WriteLine($"Y2 = {result2}");
            Console.WriteLine($"Y3 = {result3}");
        }

        public static double getY(double x)
        {
            double result;

            if (x < 10 && x != 0)
                result = Math.Tan(x);
            else if (x > 15)
                result = Math.Pow(Math.Sqrt(x), 8);
            else
                result = x / 5;

            return result;
        }
    }
}
