using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeFourZadanieThree pr4z3 = new PracticeFourZadanieThree();

            pr4z3.GetMultiple();
            pr4z3.GetMultiple();
        }
    }

    public class PracticeFourZadanieThree
    {
        public void GetMultiple()
        {
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 == 20 || num2 == 20)
                {
                    throw new NishporException("Ошибка, одно из числе равно варианту");
                }
            }
            catch (Exception ex)
            {
                if (ex is NishporException)
                    Console.WriteLine(ex.Message);
                else if (ex is FormatException)
                    Console.WriteLine("То что вы ввели не является числом: {0}", ex.Message);
            }
        }
    }

    class NishporException : Exception
    {
        public NishporException(string message):base(message) { }
    }
}
