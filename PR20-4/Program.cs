using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR20_4
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = new int[,]
            {
            { 11, 20, 31 },
            { 43, 15, 68 },
            { 75, 18, 19 }
            };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            Task<int>[] tasks = new Task<int>[rows];
            for (int i = 0; i < rows; i++)
            {
                int rowIndex = i;
                tasks[i] = Task.Run(() => CalculateRowSum(array, rowIndex));
            }

            Task.WaitAll(tasks);

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += tasks[i].Result;
            }
            double average = (double)sum / (rows * columns);

            Console.WriteLine("Среднее значение: " + average);
        }

        static int CalculateRowSum(int[,] array, int rowIndex)
        {
            int sum = 0;
            int columns = array.GetLength(1);
            for (int j = 0; j < columns; j++)
            {
                sum += array[rowIndex, j];
            }
            Console.WriteLine("Array sum:{0}", sum);
            return sum;
        }
    }
}
