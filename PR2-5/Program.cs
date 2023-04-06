using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PR2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = -10; x < 10; x++)
            {
                double result = getF(x);
                Console.WriteLine($"func = {result}"); 
            }
        }

        public static double getF(double x)
        {
            double result;

            if (x < 1)
                result = (101)/(x-1)*getMin(x); 
            else if (1 <= x && x <= 5)
                result = Math.Log(x) + 2.0 * x;
            else if (x > 5)
                result = 2.0 * Math.Pow((x * 2.0), 2) + 1 - 1.0 / Math.Sqrt(x);
            else
                throw new ArgumentException("Число не подходит под условие");

            return result;
        }

        private static double getMin(double x)
        {
            double num1 = x / 3;
            double num2 = x - 5;

            if (num1 < num2)
                return num1;
            else if (num2 < num1)
                return num2;
            else
                throw new ArgumentException("Число одинаковое или не корректное");
        }
    }
}
