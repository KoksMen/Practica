using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arith arth = new arith();
            for (double i = -6; i <= 6; i+= 0.5 )
            {
                arth.doaction(i);
            }
        }
    }

    public interface Iarith
    {
        double Func1(double x);
        double Func2(double x);
        double Func3(double x);
    }

    public class arith : Iarith
    {
        public double Func1(double x)
        {
            return Math.Acos(x / 3.0) + Math.Pow(x, 2);
        }

        public double Func2(double x)
        {
            return Math.Log(Math.Pow(x, 2) + 3);
        }

        public double Func3(double x)
        {
            return Math.Sqrt(2 * x + Math.Pow(Math.E, -x));
        }

        public void doaction(double x) 
        {
            if (x > -3 && x < 3)
                Console.WriteLine($"Result is: {Func1(x)}");
            else if (x <= -3)
                Console.WriteLine($"Result is: {Func2(x)}");
            else
                Console.WriteLine($"Result is: {Func3(x)}");
        }
    }
}
