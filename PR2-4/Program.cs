using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xn = -1;
            double xk = 7;
            double xh = 0.4;

            getZ(xn, xk, xh);
        }

        public static void getZ(double xn, double xk, double xh)
        {
            double x = xn;
            while (x <= xk)
            {
                double z = 0;

                if (x <= 1)
                    z = Math.Sqrt(Math.Abs(x - Math.Pow(Math.E, (2 * x)) + 1));
                else if (x > 5)
                    z = Math.Log10(x / 2.0) + Math.Sqrt(2.0 * x);
                else
                    z = Math.Pow(Math.Sin(x / 2.0), 2) - Math.Pow(x, 3.0);

                Console.WriteLine($"x = {x}, \tZ = {z}");

                x += xh;
            }
        }
    }
}
