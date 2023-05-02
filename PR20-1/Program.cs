using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR20_1
{
    internal class Program
    {
        static void Main()
        {
            int n = 17; 

            Task[] tasks = new Task[5];
            for (int i = 0; i < 5; i++)
            {
                int taskId = i + 1; 

                tasks[i] = Task.Run(() =>
                {
                    List<int> primes = GetPrimes(n);

                    Console.WriteLine("Задача {0} завершена. Количество простых чисел: {1}", taskId, primes.Count);
                    Console.WriteLine("Простые числа: " + string.Join(", ", primes));
                });
            }

            Task.WaitAll(tasks);
        }

        static List<int> GetPrimes(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 10; i <= n * n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
