using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR14_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = Thread.CurrentThread;

            Console.WriteLine($"Имя домена приложения: {AppDomain.CurrentDomain.FriendlyName}");
            Console.WriteLine($"ID контекста: {Thread.CurrentContext.ContextID}");
            Console.WriteLine($"Имя потока: {thread1.Name}");
            Console.WriteLine($"Запущен ли поток: {thread1.IsAlive}");
            Console.WriteLine($"Приоритет потока: {thread1.Priority}");
            Console.WriteLine($"Состояние потока: {thread1.ThreadState}");
        }
    }
}
