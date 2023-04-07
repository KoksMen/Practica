using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PR3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeThreeZadanieFive pr3z5 = new PracticeThreeZadanieFive();
            pr3z5.doResult(27, 3);
            double molarMass = 55.847; // молярная масса железа в г/моль
            double avogadro = 6.02214129272727 * Math.Pow(10, 23); // число Авогадро
            double keyWeight = 100; // вес железного ключа в граммах
            pr3z5.doResult(molarMass, avogadro, keyWeight);
        }
    }

    public class PracticeThreeZadanieFive
    {
        public void doResult(int k, int m)
        {
            List<int> mnumbers = new List<int>();
            int count = 0;
            for (int i = 1; i <= k; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 9 == 0)
                {
                    mnumbers.Add(i);
                    count++;
                    if (count == m)
                    {
                        break;
                    }
                }
            }
            mnumbers.ForEach(mr => Console.WriteLine($"m = {mr}\n"));
        }
        public void doResult(double molarMass, double avogadro, double keyWeight)
        {
            double atomDistance = 0.1;
            double numAtoms = (keyWeight / molarMass) * avogadro;
            double numBonds = numAtoms - 1;
            double chainLength = numBonds * atomDistance;

            Console.WriteLine($"Число атомов в железном ключе: {numAtoms}");
            Console.WriteLine($"Длина цепочки атомов: {chainLength} нм");
        }
    }
}
