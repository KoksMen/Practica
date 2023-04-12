using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] massive = new int[3, 3] { { 9, 17, 23 }, { 35, 14, 56 }, { 41, 51, 61 } };

            PracticeFiveZadanieFive pr5z5 = new PracticeFiveZadanieFive();

            pr5z5.DoAction(massive, 10, massive.GetLength(0), massive.GetLength(1));
        }
    }

    public class PracticeFiveZadanieFive
    {
        public void DoAction(int[,] T, int A, int K, int M)
        {
            bool found = false;
            for (int i = 0; i < K; i++) 
            {
                for (int j = 0; j < M; j++) 
                {

                    if (T[i, j] < A) 
                    {
                        found = true;
                        Console.WriteLine("Строка содержащая элемент, меньший A, строка {0}", j);
                        break;
                    }
                }
            }
            if (!found) Console.WriteLine("Нет не одной строки которая сожержит элемент, меньший А");
        }
    }
}
