using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeThreeZadanieTwo pr3z2 = new PracticeThreeZadanieTwo();
            int averageball = 3;
            string firstname = "Nikita";
            string lastname = "Nishpor";

            pr3z2.doAction();
            pr3z2.doAction(firstname, lastname);
            pr3z2.doAction(firstname, lastname, averageball);
            averageball = 6;
            pr3z2.doAction(firstname, lastname, averageball);
            averageball = 8;
            pr3z2.doAction(firstname, lastname, averageball);
            
        }
    }

    public class PracticeThreeZadanieTwo
    {
        public void doAction()
        {
            Console.WriteLine("Вы забыли ввести данные");
        }
        public void doAction(string FirstName, string LastName)
        {
            Console.WriteLine($"Я {FirstName} {LastName} учащийся(ася) Гомельского Машиностроительного колледжа.");
        }
        public void doAction(string FirstName, string LastName, double AverageBall)
        {
            string stydyLVL;

            if (AverageBall >= 7.5)
                stydyLVL = "хорошо";
            else if (AverageBall < 7.5 && AverageBall > 5)
                stydyLVL = "среднее";
            else
                stydyLVL = "плохо";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Я {FirstName} {LastName} учащийся(ася) Гомельского Машиностроительного колледжа.");
            sb.AppendLine($"Мой средний балл {AverageBall}, я учусь {stydyLVL}.");
            Console.WriteLine(sb.ToString());
        }
    }
}
