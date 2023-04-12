using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Loreasdqsdqwdqwdqwdqwdwm ipsum dolor sit amet, consectetur adipiscing elit. Sed id magna vitae quam pulvinar facilisis a vel dolor.";
            string[] words = text.Split(' ');
            string firstWord = words[0];
            string maxWord = words.OrderByDescending(w => w.Length).First();
            bool maxFirst = firstWord == maxWord;
            char lastLetter = firstWord[firstWord.Length - 1];
            string[] filteredWords = words.Where(w => w[w.Length - 1] == lastLetter).ToArray();
            
            if (maxFirst)
            {
                words = words.Except(filteredWords).Concat(filteredWords).ToArray();   
            }

            string newText = string.Join(" ", words);

            Console.WriteLine("Исходный текст: " + text);
            Console.WriteLine("Первое слово: " + firstWord);
            Console.WriteLine("Максимальное слово: {0}", maxWord);
            Console.WriteLine($"Слова, заканчивающиеся на {lastLetter}: " + string.Join(", ", filteredWords));
            Console.WriteLine("Новый текст: " + newText);
        }
    }


}
