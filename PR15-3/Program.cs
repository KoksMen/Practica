using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2.0;
            double b = 3.0;
            double x = 1.0;
            double ab = 30.0;

            double z = CalculateExpression(a, b, x, ab);
            Console.WriteLine($"z = {z}");

            Console.ReadLine();
        }

        static double CalculateExpression<T>(T a, T b, T x, T ab)
        {
            double dA =0;
            double dB = 0;
            double dX = 0;
            double dAb = 0;
            try
            {
               dA = Convert.ToDouble(a);
               dB = Convert.ToDouble(b);
               dX = Convert.ToDouble(x);
               dAb = Convert.ToDouble(ab);
            }
            catch (Exception)
            {
                Console.WriteLine("Выберите другой тип (double, int)");
            }

            double z = 0.9 * dA + Math.Abs(dX + Math.Sin(dAb) / 2.5 * Math.Pow(dB, dA));

            return z;
        }
    }
}
