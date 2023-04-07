using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PR4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeFourZadanieFive pr5z5 = new PracticeFourZadanieFive();

            MiniCalculator calculator = pr5z5.getPassword();

            calculator.Multuply();
            calculator.Divide();
            calculator.Add();
            calculator.Substract();
        }
    }

    public class PracticeFourZadanieFive
    {
        public MiniCalculator getPassword()
        {
            string currentPassword = "Nishpor12345";

            Console.Write("Введите пароль:");
            string password = Console.ReadLine();

            if (password == currentPassword)
                return new MiniCalculator();
            else
                throw new Exception("Ошибка ввода пароля");
        }
    }

    public class MiniCalculator
    {
        public void Divide()
        {
            try
            {
                Console.Write("Введите число 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Divide result = {result}");
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException)
                    Console.WriteLine("Ошибка деления на 0");
                else if (ex is FormatException)
                    Console.WriteLine("Ошибка ввода числа");
                else
                    Console.WriteLine($"Другая ошибка, :{ex.Message}");
            }

        }
        public void Multuply()
        {
            try
            {
                Console.Write("Введите число 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 * num2;
                Console.WriteLine($"Multuply result = {result}");
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    Console.WriteLine("Ошибка ввода числа");
                else
                    Console.WriteLine($"Другая ошибка, :{ex.Message}");
            }
        }
        public void Substract()
        {
            try
            {
                Console.Write("Введите число 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 - num2;
                Console.WriteLine($"Substract result = {result}");
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    Console.WriteLine("Ошибка ввода числа");
                else
                    Console.WriteLine($"Другая ошибка, :{ex.Message}");
            }
        }
        public void Add()
        {
            try
            {
                Console.Write("Введите число 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 + num2;
                Console.WriteLine($"Add result = {result}");
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    Console.WriteLine("Ошибка ввода числа");
                else
                    Console.WriteLine($"Другая ошибка, :{ex.Message}");
            }
        }
    }
}
