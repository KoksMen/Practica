using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int variant = 14; 

            string directoryPath = @"D:\NishporPR16";
            string fileName = "Nishpor.txt";
            string filePath = Path.Combine(directoryPath, fileName);

            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    long result = 1;
                    for (int i = 1; i <= 100; i++)
                    {
                        result = i * variant;
                        sw.Write($"{result} ");
                    }

                }

                Console.WriteLine($"Файл {filePath} успешно создан.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка создания файла: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
