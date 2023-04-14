using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PR9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arith = new Arithmetic();
            double num1, num2;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("result addition num1 and num2: {0}", arith.Addition(num1, num2));
            Console.WriteLine("result subtraction num1 and num2: {0}", arith.Subtraction(num1, num2));
            Console.WriteLine("result multiplication num1 and num2: {0}", arith.Multiplication(num1, num2));
            Console.WriteLine("result division num1 and num2: {0}", arith.Division(num1, num2));
            Console.WriteLine("result Powing num1 to num2: {0}", arith.Powing(num1, num2));
            Console.WriteLine("result sqrting num1: {0}", arith.Sqrting(num1));
            Console.WriteLine("result abcsigng num2: {0}", arith.Abcsing(num2));

        }
    }
        public interface IArithmetic
        {
            double Addition(double a, double b);
            double Subtraction(double a, double b);
            double Multiplication(double a, double b);
            double Division(double a, double b);
            double Powing(double a, double b);
            double Sqrting(double a);
            double Abcsing(double a);
        }

        public class Arithmetic : IArithmetic
        {
            public double Addition(double a, double b)
            {
                return a + b;
            }

            public double Subtraction(double a, double b)
            {
                return a - b;
            }

            public double Multiplication(double a, double b)
            {
                return a * b;
            }

            public double Division(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Divisor cannot be zero");
                }
                return a / b;
            }

            public double Powing(double a, double b)
            {
                return Math.Pow(a, b);
            }

            public double Sqrting(double a)
            {
                return Math.Sqrt(a);
            }

            public double Abcsing(double a)
            {
                return Math.Abs(a);
            }
        }
    
}
