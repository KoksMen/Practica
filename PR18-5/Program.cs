using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            
            if (stack.Count == 0)
            {
                Console.WriteLine("Стек пустой");
            }
            else
            {
                Console.WriteLine("Стек не пустой");
            }

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Верхний элемент стека: {0}", stack.Peek());
            stack.Pop();

            Console.WriteLine("Новый верхний элемент стека: {0}", stack.Peek());

            Console.ReadKey();
        }
    }
}
