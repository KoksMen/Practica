using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeThreeZadanieFour pr3z4 = new PracticeThreeZadanieFour();
            pr3z4.getNum();
        }
    }

    public class PracticeThreeZadanieFour
    {
        public void getNum()
        {
            int x, y;
            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());

            double MathResult = Math.Abs(x * y);
            if (MathResult < 2)
            {
                double result = Calculate(x, y, "fixtive");
                Console.WriteLine($"Result = {result}");
            }
            else if (MathResult > 2)
            {
                double result = Calculate(x, y, 0.0);
                Console.WriteLine($"Result = {result}");
            }
            else if (MathResult == 5)
            {
                double result = Calculate(x, y, null);
                Console.WriteLine($"Result = {result}");
            }
        }

        private double Calculate(double x, double y, string fictive)
        {
            double func;

            func = (10 * x - y) / (1 + Math.Pow(x, 2));

            return func;
        }

        private double Calculate(double x, double y, double fixtive)
        {
            double func;

            func = Math.Pow(x, 3) - y;

            return func;
        }

        private double Calculate(double x, double y, DateTime fixtive)
        {
            double func;

            func = (Math.Pow(x, 2) + y + Math.Pow((y - x), 2)) / (Math.Sqrt(Math.Pow((3 * x - 2), 2) + Math.Pow(y, 2)));

            return func;
        }
    }
}
