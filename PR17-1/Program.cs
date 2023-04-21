using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

            try
            {
                int result = 1 / (x + n);
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Деление на ноль!");
            }
        }
    }
}
