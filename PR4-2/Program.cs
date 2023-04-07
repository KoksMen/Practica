using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeFourZadanieTwo pr4z2 = new PracticeFourZadanieTwo();

            pr4z2.GetIfError(0);
            pr4z2.GetTryCatchError(0);
        }
    }

    public class PracticeFourZadanieTwo
    {
        public void GetIfError(int x)
        {
            int result;
            if (x != 0)
            {
                result = ((int)Math.Pow(x, 2) + 23) / x;
                Console.WriteLine($"Result = {result}");
            }
            else
            {
                Console.WriteLine("Произошла ошибка деления на 0");
            }
        }

        public void GetTryCatchError(int x)
        {
            try
            {
                int result;

                result = (int)Math.Pow(x, 2) + 23 / x;

                Console.WriteLine($"Result = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Произошла ошибка деления на  0: {ex.Message}");
            }
        }
    }
}
