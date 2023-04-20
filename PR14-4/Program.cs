using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR14_4
{
    internal class Program
    {
        static double x = -20;
        static double y = -20;

        static void Main(string[] args)
        {
            while (true)
            {
                x++; y++;
                if (Math.Abs(x * y) < 2) (new Thread(Func1)).Start();
                else if (Math.Abs(x * y) > 2) (new Thread(Func2)).Start();
                else if (Math.Abs(x * y) == 5) (new Thread(Func3)).Start();
                Console.ReadLine();
            }
        }

        static void Func1()
        {
            Console.WriteLine($"Func1 = {(10.0*x-y)/(1+Math.Pow(x,2))}");
        }
        static void Func2()
        {
            Console.WriteLine($"Func2 = {Math.Pow(x,3)-y}");

        }
        static void Func3()
        {
            Console.WriteLine($"Func3 = {(Math.Pow(x,2)+y+Math.Pow((y-x),2))/(Math.Sqrt(Math.Pow(3*x-y,2))+Math.Pow(y,2))}");

        }
    }
}
