using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 21; 
            int timeout = 1000 + n * 10; 

            var cancelationToken = new CancellationTokenSource();

            Thread thread1 = new Thread(() => PrintPi(cancelationToken.Token));
            thread1.Start();

            if (!thread1.Join(timeout))
            {
                cancelationToken.Cancel();
                Console.WriteLine("\nВремя работы потока истекло");
            }
            else
            {
                Console.WriteLine("Работа потока завершена");
            }   
        }

        static void PrintPi(CancellationToken cancellationToken)
        {
            int i = 0;
            while (!cancellationToken.IsCancellationRequested)
            {
                if (i >= Math.PI.ToString().Length)
                {
                    i = 0;
                }

                Console.Write(Math.PI.ToString()[i++]);
                Thread.Sleep(10);
            }
        }
    }
}
