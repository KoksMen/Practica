using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PR7_5
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "text.txt";
            string text = File.ReadAllText(filePath);

            string name = "Nikita";
            string coloredName = "\u001b[31m" + name + "\u001b[0m";
            string pattern = $"{name}(?![\\p{{L}}])";

            string result = Regex.Replace(text, pattern, coloredName);
            Console.WriteLine(result);
        }
    }
}
