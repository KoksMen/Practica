using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PR7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] surnames = new string[] { "Machechin", "Tichonovich", "Aksenchikov", "Loban", "Mnartyshev", "storogykin", "Maksi menko", " shandarckhych", "danilenko", "By riy", "Nishpor" };

            string pattern = "Nishpor";
            Regex regex = new Regex(pattern);
            foreach (string surname in surnames)
            {
                if (regex.IsMatch(surname))
                {
                    Console.WriteLine($"Ваша фамилия найдена: {surname}");
                }
            }

            string pattern2 = "^[a-z]";
            Regex regex2 = new Regex(pattern2);
            foreach (string surname in surnames)
            {
                if (regex2.IsMatch(surname))
                {
                    Console.WriteLine($"Фамилия с маленькой буквы: {surname}");
                }
            }


            string pattern3 = @"\s";
            Regex regex3 = new Regex(pattern3);
            foreach (string surname in surnames)
            {
                if (regex3.IsMatch(surname))
                {
                    Console.WriteLine($"Фамилия с пробелом: {surname}");
                }
            }

        }
    }
}
