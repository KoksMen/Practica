using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "АМФМФАААФМФФМФ";
            PracticeSixZadanieOne pr6z1 = new PracticeSixZadanieOne();

            string newstr = pr6z1.RemoveA(str);
            Console.WriteLine("String after remove A: {0}", newstr);
            int count = pr6z1.GetCountFAfterM(newstr);
            Console.WriteLine("Count F after M: {0}", count);
        }
    }

    public class PracticeSixZadanieOne
    {
        public string RemoveA(string str)
        {
            return (new StringBuilder(str)).Replace("А", "").ToString(); ;
        }

        public int GetCountFAfterM(string str)
        {
            int count = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == 'Ф' && str[i - 1] == 'М')
                {
                    count++;  
                }
            }

            return count;
        }
    }
}
