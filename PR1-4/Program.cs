using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = -0.19;
            double b = -1; //before 7.25 after -1

            double result = getAlpha(a, b);

            Console.WriteLine($"Alpha result = {result}");
        }

        private static double getAlpha(double a, double b)
        {
            double alpha;

            double ab1 = (a * b + 1);
            double asin = Math.Asin(b);

            alpha = Math.Sqrt(Math.Pow(Math.E, ab1) + asin);

            return alpha;
        }
    }
}
