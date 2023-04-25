using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int perem1 = 24;
            string perem2 = "Nishpor!";
            int? perem3 = null;

            if (perem1 == null)
            {
                Console.WriteLine("Переменная perem1 содержит null.");
                perem1 = 24;
                Console.WriteLine("Переменная perem1 содержит значение: " + perem1);
            }
            else
            {
                Console.WriteLine("Переменная perem1 содержит значение: " + perem1);
            }

            if (perem2 == null)
            {
                Console.WriteLine("Переменная perem2 содержит null.");
                perem2 = "Nikita Nishpor";
                Console.WriteLine("Переменная perem2 содержит значение: " + perem2);
            }
            else
            {
                Console.WriteLine("Переменная perem2 содержит значение: " + perem2);
            }

            if (perem3 == null)
            {
                Console.WriteLine("Переменная perem3 содержит null.");
                perem3 = 10;
                Console.WriteLine("Переменная perem3 теперь содержит значение: " + perem3);
            }
            else
            {
                Console.WriteLine("Переменная perem3 содержит значение: " + perem3);
            }

            Console.ReadKey();
        }
    }
}
