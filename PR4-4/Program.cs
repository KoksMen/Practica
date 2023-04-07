using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeFourZadanieFour pr4z4 = new PracticeFourZadanieFour();

            pr4z4.doAction();
        }
    }

    public class PracticeFourZadanieFour
    {
        public void doAction()
        {
            int[] randomNumbers = new int[] { 64, 0, 54, 12, 5 };
            Console.Write("Введите индекс для поиска числа из массива: ");
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine($"Число под индексом {index} = {randomNumbers[index]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
