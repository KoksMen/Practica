using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR20_3
{
    internal class Program
    {
        static void Main()
        {
            int variantNumber = 17;

            string outputFileName = "out.txt";

            Parallel.For(1, 4, taskNumber =>
            {
                string inputFileName = $"{taskNumber}in_{variantNumber}.txt";
                string[] inputLines = File.ReadAllLines(inputFileName);

                double result = 0;

                switch (taskNumber)
                {
                    case 1:
                        result = PerformAction(inputLines[1], ActionType.Addition);
                        break;
                    case 2:
                        result = PerformAction(inputLines[1], ActionType.Multiplication);
                        break;
                    case 3:
                        result = PerformAction(inputLines[1], ActionType.SumOfSquares);
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи.");
                        return;
                }

                lock (outputFileName)
                {
                    File.AppendAllText(outputFileName, result.ToString() + Environment.NewLine);
                }

                Console.WriteLine("Результат для задачи {0} успешно записан в файл.", taskNumber);
            });

            Console.WriteLine("Все задачи выполнены.");
        }

        enum ActionType
        {
            Addition,
            Multiplication,
            SumOfSquares
        }

        static double PerformAction(string numbersString, ActionType actionType)
        {
            double[] numbers = Array.ConvertAll(numbersString.Split(' '), double.Parse);

            double result = 0;

            switch (actionType)
            {
                case ActionType.Addition:
                    result = numbers[0] + numbers[1];
                    break;
                case ActionType.Multiplication:
                    result = numbers[0] * numbers[1];
                    break;
                case ActionType.SumOfSquares:
                    result = Math.Pow(numbers[0], 2) + Math.Pow(numbers[1], 2);
                    break;
            }

            return result;
        }
    }
}
