using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            Random rnd = new Random();
            for (int i = 0; i < 40; i++)
            {
                arr.Add(rnd.Next(10));
            }

            Console.WriteLine("Массив до сортировки:");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            arr.Sort();

            Console.WriteLine("Массив после сортировки:");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            int A = 7, B = 21; 
            int sum = 0;
            foreach (int element in arr)
            {
                if (element >= A && element <= B)
                {
                    sum += element;
                }
            }
            Console.WriteLine($"Сумма чисел в промежутке [{A}, {B}]: {sum}");

            int count = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if ((i + 1) % 4 == 0 && (int)arr[i] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество нулей, стоящих на местах, кратных 4: {count}");

            Console.ReadKey();
        }
    }
}
