using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PR8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order[] orders = new Order[3];
            
            for (int i = 0; i < orders.Length; i++)
            {
                Console.Write("Enter payeer: ");
                string payeer = Console.ReadLine();
                Console.Write("Enter reciever: ");
                string reciever = Console.ReadLine();
                Console.Write("Enter rubsum: ");
                int rubsum = Convert.ToInt32(Console.ReadLine());
                Order order = CreateOrder(payeer, reciever, rubsum);
                orders[i] = order;
            }

            Array.Sort(orders);

            foreach (Order order in orders)
            {
                Console.WriteLine(order.Payeer);
            }

            Console.Write("\nВведите расчетный счет плательщика для поиска: ");
            string searchAccount = Console.ReadLine();
            double totalAmount = 0;
            bool accountFound = false;
            foreach (Order order in orders)
            {
                if (order.Payeer == searchAccount)
                {
                    totalAmount += order.RubSum;
                    accountFound = true;
                }
            }
            if (accountFound)
            {
                Console.WriteLine("Сумма, снятая с расчетного счета плательщика " + searchAccount + ": " + totalAmount + " руб.");
            }
            else
            {
                Console.WriteLine("Расчетный счет " + searchAccount + " не найден.");
            }
        }

        public static Order CreateOrder(string payeer, string reciever, int rubsum) => new Order { Payeer = payeer, Reciever = reciever, RubSum = rubsum };
    }

    public struct Order: IComparable
    {
        public string Payeer;
        public string Reciever;
        public int RubSum;

        public int CompareTo(object obj)
        {
            if (obj is Order order)
                return Payeer.CompareTo(order.Payeer);
            else
                throw new ArgumentException("");
        }
    }
}
