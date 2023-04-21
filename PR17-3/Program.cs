using ShopAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HatchBack auto1 = new HatchBack("VAZ2109", 160, 80000, 2.5);
            auto1.Inf();
            Console.ReadLine();
        }
    }
}
