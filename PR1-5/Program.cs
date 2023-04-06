using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tons = 35;
            double germination = 95;

            double result = getCount(tons, germination);

            Console.WriteLine($"Result = {result}");
        }

        private static double getCount(double tons, double germination)
        {
            double result;

            result = (tons / germination) * 100;

            return result;
        }
    }
}
