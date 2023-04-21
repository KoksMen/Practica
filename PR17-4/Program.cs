using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PR17_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Message.GetMessage();
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
