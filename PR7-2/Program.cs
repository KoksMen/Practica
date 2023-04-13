using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PR7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadAllText("numbers.txt");
            string[] lines = line.Split(' ');
            int[] numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                if (Regex.IsMatch(lines[i], @"^\d+$"))
                {
                    int.TryParse(lines[i], out numbers[i]);
                    Console.Write($"{numbers[i]}  "); 
                }
            }
            Console.WriteLine();


            int myVariant = 24;
            Console.WriteLine($"Мой вариант: {myVariant}");


            for (int i = 0; i < numbers.Length; i++)
            {
                if (!Regex.IsMatch(numbers[i].ToString(), @"\b24\b"))
                {
                    numbers[i] *= myVariant;
                }
            }

            string[] lines1 = new string[lines.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                lines1[i] = numbers[i].ToString();
            }

            string regexPattern = myVariant.ToString();
            for (int i = 0; i < lines.Length; i++)
            {
                if (Regex.IsMatch(lines1[i], regexPattern))
                {
                    lines1[i] += " Это мой вариант";
                }
            }

            for (int i = 0; i < lines1.Length; i++)
            {
                Console.Write($"{lines1[i]}  ");
            }
        }
    }
}
