using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[10] { 56, 12, 0, 5, 44, 31, 13, 87, 9, 20 };

            PracticeFiveZadanieThree pr5z3 = new PracticeFiveZadanieThree();
            pr5z3.InsertionSortDescending(ref massive);
        }
    }

    public class PracticeFiveZadanieThree
    {
        public void InsertionSortDescending(ref int[] arr)
        {
            for(int i = arr.Length - 2; i >= 0; i--)
            {
                int key = arr[i];
                int j = i + 1;

                while (j < arr.Length && arr[j] > key)
                {
                    arr[j - 1] = arr[j];
                    j++;
                }

                arr[j - 1] = key;
            }
            foreach (int i in arr) { Console.Write($"{i} => "); }
            Console.WriteLine($"Count = {arr.Length}");
        }
    }
}
