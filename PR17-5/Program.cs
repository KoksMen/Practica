using PR17_5_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PR17_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "file.txt";
            StringModifier modifier = new StringModifier();

            List<string> lines = modifier.ReadFile(path);

            foreach (string line in lines)
            {
                int countA = modifier.CountLetterA(line);
                int countS = modifier.CountLetterS(line);
                string replacedN = modifier.ReplaceLetterN(line);

                Console.WriteLine("Input: " + line);
                Console.WriteLine("Count of letter A before space: " + countA);
                Console.WriteLine("Count of letter S after O: " + countS);
                Console.WriteLine("Replaced letter N: " + replacedN);
                Console.WriteLine();
            }
        }
    }
}
