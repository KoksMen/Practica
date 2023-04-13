using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PR7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string pattern = @"[А-Яа-я\s]*в[А-Яа-я\s]*![\s]*";
            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Восклицательные предложения, содержащие букву \"в\":");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }

            Console.ReadKey();
        }
    }
}
