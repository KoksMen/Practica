using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[10] { 56, 12, 0, 5, 44, 31, 13, 87, 9, 20 };
            int AverageNotNull = Convert.ToInt32(massive.Where(x => x > 0).Average());
            Console.WriteLine("Average: {0}", AverageNotNull);
            int Count = 0;
            int A = 13;
            for (int i = 0; i < massive.Length; i++)
            {
                if (i % 2 == 0 && massive[i] > A)
                    Count++;
            }
            Console.WriteLine("Count: {0}", Count);
        }
    }
}
