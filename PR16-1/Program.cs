using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\Nishpor.txt";

            if (!CheckFileCommand(file))
            {
                CreateFileCommand(file);
            }
            else
            {
                DeleteFileCommand(file);
            }
        }

        static bool CheckFileCommand(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists) return true;
            return false;
        }

        static void CreateFileCommand(string path)
        {
            FileInfo file = new FileInfo(path);
            file.Create();
            Console.WriteLine("File created");
            Console.ReadLine();
        }

        static void DeleteFileCommand(string path)
        {
            FileInfo file = new FileInfo(path);
            file.Delete();
            Console.WriteLine("File deleted");
            Console.ReadLine();
        }
    }
}
