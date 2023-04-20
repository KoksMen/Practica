using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(MakeShowNumbers);
            Thread thread2 = new Thread(MakeShowNumbers);
            Thread thread3 = new Thread(MakeShowNumbers);
            Thread thread4 = new Thread(MakeShowNumbers);
            Thread thread5 = new Thread(MakeShowNumbers);
            Thread thread6 = new Thread(MakeShowNumbers);
            Thread thread7 = new Thread(MakeShowNumbers);
            Thread thread8 = new Thread(MakeShowNumbers);
            Thread thread9 = new Thread(MakeShowNumbers);
            Thread thread10 = new Thread(MakeShowNumbers);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();
            thread9.Start();
            thread10.Start();
        }

        public static void MakeShowNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Число: {i}, Имя потока: {Thread.CurrentThread.Name}, ID потока{Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
