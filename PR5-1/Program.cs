using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectornumber = new int[10] { 56, 12, 0, 5, 44, 31, 13, 87, 9, 20 };
            PracticeFiveZadanieOne pr5z1 = new PracticeFiveZadanieOne();
            pr5z1.SortVector(vectornumber);
        }
    }

    public class PracticeFiveZadanieOne
    {
        public void SortVector(int[] vectornumber)
        {
            Array.Sort(vectornumber);
            foreach (int i in vectornumber) { Console.Write($"{i} => "); }
            Console.WriteLine($"Count = {vectornumber.Length}");
        }
    }
}
