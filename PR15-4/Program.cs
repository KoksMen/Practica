using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            double num3 = 2.5;
            double num4 = 10.2;
            string string1 = "Никита, ";
            string string2 = "Нишпор!";

            CalculationDelegate<int> intAdd = Add;
            CalculationDelegate<double> doubleAdd = Add;
            CalculationDelegate<string> stringAdd = Add;

            CalculationDelegate<int> intSubtract = Subtract;
            CalculationDelegate<double> doubleSubtract = Subtract;
            CalculationDelegate<string> stringSubtract = Subtract;

            Calculate(num1, num2, intAdd);
            Calculate(num3, num4, doubleAdd);
            Calculate(string1, string2, stringAdd);

            Calculate(num1, num2, intSubtract);
            Calculate(num3, num4, doubleSubtract);
            Calculate(string1, string2, stringSubtract);

            Console.ReadLine();
        }

        delegate T CalculationDelegate<T>(T a, T b);

        static void Calculate<T>(T a, T b, CalculationDelegate<T> operation)
        {
            T result = operation(a, b);
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static string Add(string a, string b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static string Subtract(string a, string b)
        {
            foreach (char c in b)
            {
                a = a.Replace(c.ToString(), "");
            }
            return a;
        }
    }
}
