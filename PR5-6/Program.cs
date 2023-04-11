using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", PracticeFiveZadanieSix.Power(3, 3));
            Console.ReadKey();
        }
    }

    public class PracticeFiveZadanieSix
    {
        public static double Power(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 1 / Power(x, Math.Abs(n));
            }
            else if (n > 0)
            {
                return x * Power(x, n - 1);
            }
            else
                throw new NotImplementedException();
        }
    }
}
