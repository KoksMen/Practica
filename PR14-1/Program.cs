using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Первая буква имени: Н");
                }
            }
            );
            Thread thread2 = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Первая буква фамилии: Н");
                }
            }
            );

            thread1.Start();
            thread2.Start();
        }
    }
}
