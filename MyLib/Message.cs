using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Message
    {
        public static string GetMessage()
        {
            string path = @"D:\in.txt";
            string message = File.ReadAllText(path);
            return message;
        }
    }
}
