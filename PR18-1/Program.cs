using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Num1 = 134;
            calc.Num2 = 17;
            calc.Operation = '+';
            calc.Operation = '-';
            calc.Operation = '*';
            calc.Operation = '/';
            calc.Operation = 'd';
        }
    }

    public struct Calculator
    {
        public double num1;
        public double num2;
        private char operation;
        public double Num1 { get { return num1; } set {  num1 = value; } }
        public double Num2 { get { return num2; } set {  num2 = value; } }
        public char Operation { get { return operation; } set { operation = value; if (Num1 != 0 && Num2 != 0) Calculate(); } }

        private void Calculate()
        {
            switch (operation)
            {
                case '+':
                    {
                        Console.WriteLine(num1 + num2);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(num1 - num2);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(num1 * num2);
                        break;
                    }
                case '/':
                    { 
                        if (num2 == 0)
                            throw new DivideByZeroException("Деление на 0 запрещено");
                        else 
                            {
                                Console.WriteLine(num1 / num2);
                                break;
                            } 
                    }
                default:
                    throw new ArgumentException("Неверный знак операции, попробуйте использовать другой");
            }
        }
    }
}
