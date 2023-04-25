using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Nasekomoe> nasekomoeList = new List<Nasekomoe>();

            nasekomoeList.Add(new Nasekomoe("Пчела", "желтый", "цветы"));
            nasekomoeList.Add(new Nasekomoe("Муравей", "коричневый", "сахар"));
            nasekomoeList.Add(new Nasekomoe("ОсаУбица", "черно-желтый", "Люди"));
            nasekomoeList.Add(null);

            foreach (Nasekomoe nasekomoe in nasekomoeList)
            {
                if (nasekomoe != null)
                {
                    nasekomoe.Display();
                }
                else
                {
                    Console.WriteLine("Значение имеет Null поэтому, мы ничего не выводим");
                }
            }
        }
    }

    class Nasekomoe
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string FavoriteFood { get; set; }

        public Nasekomoe(string name, string color, string favoriteFood)
        {
            Name = name;
            Color = color;
            FavoriteFood = favoriteFood;
        }

        public void Display()
        {
            Console.WriteLine("Имя насекомого: {0}", Name);
            Console.WriteLine("Цвет насекомого: {0}", Color);
            Console.WriteLine("Любимая еда насекомого: {0}", FavoriteFood);
            Console.WriteLine();
        }
    }
}
