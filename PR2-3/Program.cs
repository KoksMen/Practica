using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PR2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4.28;
            double b = 12.91;
            double c = 10.56;

            makeRepalace(ref a, ref b, ref c);
            Console.WriteLine($"a = {a} \t b = {b} \t c = {c} ");
        }

        public static double getMin(double a, double b, double c)
        {
            double result;

            if (a < b && a < c)
                result = a;
            else if (b < a && b < c)
                result = b;
            else if (c < a && c < b)
                result = c;
            else throw new ArgumentException("Числа равны, не возможно найти минимальное");

            return result;
        }
        public static double getMax(double a, double b, double c)
        {
            double result;

            if (a > b && a > c)
                result = a;
            else if (b > a && b > c)
                result = b;
            else if (c > a && c > b)
                result = c;
            else throw new ArgumentException("Числа равны, не возможно найти максимальное");

            return result;
        }
        
        public static void makeRepalace(ref double a, ref double b, ref double c)
        {
            double min = getMin(a, b, c);
            double max = getMax(a, b, c);
            double result = max + min; // Тут что то не так

            a = 1.0 / 2.0 * (a * result);
            b = 1.0 / 2.0 * (b * result);
            c = 1.0 / 2.0 * (c * result);
        }
    }
}
