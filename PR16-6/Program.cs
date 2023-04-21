using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "NishporDirectory";
            string fileName = "NishporInput.txt";
            string outputFileName = "NishporOutPut.txt";
            Directory.CreateDirectory(directoryPath);

            string text = File.ReadAllText(Path.Combine(directoryPath, fileName));

            string[] words = text.Split(' ');
            int wordsCount = words.Length;

            int maxLength = words.Max(w => w.Length);

            if (maxLength < wordsCount)
            {
                text = text.Replace(".", ". ");
                text = text.Replace("...", "... ");
            }

            File.WriteAllText(Path.Combine(directoryPath, outputFileName), text);

            FileInfo outputFile = new FileInfo(Path.Combine(directoryPath, outputFileName));
            Console.WriteLine($"Полное название файла: {outputFile.FullName}");
            Console.WriteLine($"Время создания файла: {outputFile.CreationTime}");

            Console.ReadKey();
        }
    }
}
