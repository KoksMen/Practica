using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] massive = new int[3, 3] { { 9, 17, 23 }, { 35, 14, 56 }, { 41, 51, 61 } };

            PracticeFiveZadanieFour pr5z4 = new PracticeFiveZadanieFour();

            pr5z4.DoAction(massive);
        }
    }

    public class PracticeFiveZadanieFour
    {
        public void DoAction(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];

                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }

                sum += min;
            }
            Console.WriteLine($"Elements sum = {sum}");
        }
    }
}
