using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeSixZadanieThree pr6z3 = new PracticeSixZadanieThree();

            string newstring = pr6z3.Replaced("аобы слока прока ука нака как рОКо учы");
            Console.WriteLine(newstring);
        }
    }

    public class PracticeSixZadanieThree
    {
        public string Replaced(string str)
        {
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            string[] words = str.Split(' ');
            for (int i  = 0; i < words.Length; i++) 
            {
                char firstLetter = words[i][0];
                if (char.IsLower(firstLetter) && !vowels.Contains(char.ToLower(firstLetter)))
                {
                    words[i] = char.ToUpper(firstLetter) + words[i].Substring(1);
                }
            }

            return string.Join(" ", words);
        }
    }
}
