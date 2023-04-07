using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeThreeZadanieThree pr3z3 = new PracticeThreeZadanieThree();
            double result;

            result = pr3z3.getResult(5.0, 7.13);
            Console.WriteLine($"Result = {result}");
            result = pr3z3.getResult(5.0, 7.13, 9.16, 3.15);
            Console.WriteLine($"Result = {result}");
            result = pr3z3.getResult(result);
            Console.WriteLine($"Result = {result}");

        }
    }

    public class PracticeThreeZadanieThree
    {
        public double getResult(double x, double a)
        {
            double zeta;

            zeta = Math.Sqrt((Math.Pow(Math.Log10(Math.Pow(x,3)+3.0),2)/(Math.Sin(4.0*x)+0.6*a)));

            return zeta;
        }
        public double getResult(double x, double a, double b, double c)
        {
            double lambda;

            lambda = x * (a / b + Math.Log(c));

            return lambda;
        }
        public double getResult(double z)
        {
            double beta;

            beta = Math.Pow((z * Math.E), (1.0 / 3.0));

            return beta;
        }
    }
}
