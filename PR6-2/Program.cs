using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Этот стихотворный текст обладает симметрией, потому что первая строка читается так же, как и последняя.";
            PracticeSixZadanieTwo finder = new PracticeSixZadanieTwo();
            string longestSymmetricWord = finder.FindLongestSymmetricWord(str);
            Console.WriteLine($"Самое длинное симметричное слово в предложении \"{str}\" - \"{longestSymmetricWord}\"");

        }
    }

    public class PracticeSixZadanieTwo
    {
        public string FindLongestSymmetricWord(string str)
        {
            string[] words = str.Split(' ');
            string longestSymmetricWord = "";

            foreach (string word in words)
            {
                if (IsSymmetric(word) && word.Length > longestSymmetricWord.Length)
                {
                    longestSymmetricWord = word;
                }
            }

            return longestSymmetricWord;
        }

        private bool IsSymmetric(string word)
        {
            int length = word.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }

}







