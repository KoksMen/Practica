using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SignalManager signalManager = new SignalManager();
            signalManager.incorrectPasswordEvent += SignalManager_incorrectPasswordEvent;
            signalManager.CheckPassword();

            Console.ReadLine();
        }

        private static void SignalManager_incorrectPasswordEvent()
        {
            Console.WriteLine("Вы исчерпали все попытки ввода пароля. Доступ закрыт.");
            Environment.Exit(0);
        }
    }

    class SignalManager
    {
        string password = "NikitaNishpor";
        int attemptsLeft = 3;
        string inputPassword;

        public event Action incorrectPasswordEvent;

        public void CheckPassword()
        {
            do
            {
                Console.Write("Введите пароль: ");
                inputPassword = Console.ReadLine();
                if (inputPassword != password)
                {
                    Console.WriteLine("Неверный пароль.");
                    attemptsLeft--;
                    if (attemptsLeft == 0)
                    {
                        incorrectPasswordEvent?.Invoke();
                    }
                }
                else
                {
                    Console.WriteLine("Доступ разрешен. Секретное сообщение: Го в Геншин");
                    break;
                }
            } while (attemptsLeft > 0);
        }
    }
}
