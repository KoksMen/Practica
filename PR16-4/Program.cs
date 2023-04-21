using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"D:\NishporPR16";
            string fileName = "NishporInput.txt";
            string inputFilePath = Path.Combine(directoryPath, fileName);
            string outputFileName = "NishporOutPut.txt";
            string outputFilePath = Path.Combine(directoryPath, outputFileName);

            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string inputString;
                using (StreamWriter sw = new StreamWriter(inputFilePath))
                {
                    inputString = "АБАБАБАБАБАБАБАБАБАБАБАБАБГДГДГДГДГДГДГДГГДГДГДГДГД";
                    sw.WriteLine(inputString);
                }

                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    inputString = sr.ReadToEnd();
                }

                string outputString = "";
                int countGD = 0;
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (i < inputString.Length - 1 && inputString[i] == 'А' && inputString[i + 1] == 'Б')
                    {
                        outputString += "АБП";
                    }
                    else
                    {
                        outputString += inputString[i];
                    }

                    if (i < inputString.Length - 1 && inputString[i] == 'Г' && inputString[i + 1] == 'Д')
                    {
                        countGD++;
                    }
                }

                using (StreamWriter sw = new StreamWriter(outputFilePath))
                {
                    sw.WriteLine(outputString);
                    sw.WriteLine("Количество букв Г перед Д: " + countGD);
                }

                Console.WriteLine($"Файл {outputFilePath} успешно создан.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
