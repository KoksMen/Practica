using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num mounth: ");
            int numMount = Convert.ToInt32(Console.ReadLine());
            switch (numMount)
            {
                case 1:
                    Console.WriteLine(Month.January.ToString());
                    break;
                case 2:
                    Console.WriteLine(Month.February.ToString());
                    break;
                case 3:
                    Console.WriteLine(Month.March.ToString());
                    break;
                case 4:
                    Console.WriteLine(Month.April.ToString());
                    break;
                case 5:
                    Console.WriteLine(Month.May.ToString());
                    break;
                case 6:
                    Console.WriteLine(Month.June.ToString());
                    break;
                case 7:
                    Console.WriteLine(Month.July.ToString());
                    break;
                case 8:
                    Console.WriteLine(Month.August.ToString());
                    break;
                case 9:
                    Console.WriteLine(Month.September.ToString());
                    break;
                case 10:
                    Console.WriteLine(Month.October.ToString());
                    break;
                case 11:
                    Console.WriteLine(Month.November.ToString());
                    break;
                case 12:
                    Console.WriteLine(Month.December.ToString());
                    break;
            }
            Console.Write("Enter num day: ");
            int numDay = Convert.ToInt32(Console.ReadLine());
            switch (numDay)
            {
                case 1:
                    Console.WriteLine(WeekDays.Monday.ToString());
                    break;
                case 2:
                    Console.WriteLine(WeekDays.Tuesday.ToString());
                    break;
                case 3:
                    Console.WriteLine(WeekDays.Wednesday.ToString());
                    break;
                case 4:
                    Console.WriteLine(WeekDays.Thursday.ToString());
                    break;
                case 5:
                    Console.WriteLine(WeekDays.Friday.ToString());
                    break;
                case 6:
                    Console.WriteLine(WeekDays.Saturday.ToString());
                    break;
                case 7:
                    Console.WriteLine(WeekDays.Sunday.ToString());
                    break;
            }
        }
        public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }
        public enum WeekDays
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }
    }
}
