using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR20_2
{
    internal class Program
    {
        static void Main()
        {
            

            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() =>
            {
                double x = 3.0;
                double y = -2.0;
                double result = Func1(x, y);
                Console.WriteLine("Результат Func1: " + result);
            });

            tasks[1] = Task.Run(() =>
            {
                double x = 3.0;
                double y = 2.0;
                double result = Func2(x, y);
                Console.WriteLine("Результат Func2: " + result);
            });

            tasks[2] = Task.Run(() =>
            {
                double x = 3.0;
                double y = 0.0;
                double result = Func3(x, y);
                Console.WriteLine("Результат Func3: " + result);
            });

            Task.WaitAll(tasks);
        }

        static double Func1(double x, double y)
        {
            double xy = x * y;
            if (xy < 0)
            {
                return (Math.Log10(Math.Abs(xy)) + 1) / (1 + Math.Pow(y, 2) - x);
            }
            throw new NotImplementedException("Error in Func1");
        }

        static double Func2(double x, double y)
        {
            double xy = x * y;
            if (xy > 0)
            {
                return Math.Sqrt(Math.Abs(Math.Sin(x)) + xy);
            }
            throw new NotImplementedException("Error in Func2");
        }

        static double Func3(double x, double y)
        {
            double xy = x * y;
            if (xy == 0)
            {
                return xy / (1 - Math.Pow(x, 2) + Math.Pow(y, 3));
            }
            throw new NotImplementedException("Error in Func3");
        }
    }
}
