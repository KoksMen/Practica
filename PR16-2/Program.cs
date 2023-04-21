using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Nishpor.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка чтения файла: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
