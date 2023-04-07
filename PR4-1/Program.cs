using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PracticeFourZadanieOne pr4z1 = new PracticeFourZadanieOne();

            pr4z1.ThrowErrorZadanie();
        }
    }

    public class PracticeFourZadanieOne
    {
        public void ThrowErrorZadanie()
        {
            throw new NotImplementedException("Ошибка для выполнения задания 1");
        }
    }
}
