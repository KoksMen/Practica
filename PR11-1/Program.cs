using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем животных
            Insect bee = new Insect("Пчела", 1, "Цветочное поле", "Медовая пчела");
            Amphibian frog = new Amphibian("Лягушка", 2, "Болото", true);
            Bird eagle = new Bird("Орёл", 3, "Горы", "Коричневый");
            Primate chimp = new Primate("Шимпанзе", 4, "Джунгли", "Темно-красная");

            // Вводим данные о животных
            bee.Input();
            frog.Input();
            eagle.Input();
            chimp.Input();

            // Выводим информацию о животных и использование уникального метода
            Console.WriteLine("\n---Насекомое---");
            bee.Output();
            bee.Fly();

            Console.WriteLine("\n---Амфибия---");
            frog.Output();
            frog.Swim();

            Console.WriteLine("\n---Птица---");
            eagle.Output();
            eagle.Fly();

            Console.WriteLine("\n---Примат---");
            chimp.Output();
            chimp.Climb();

            Console.ReadKey();
        }
    }

    class LiveObject
    {
        protected string name;
        protected int age;
        protected string habitat;

        public LiveObject(string name, int age, string habitat)
        {
            this.name = name;
            this.age = age;
            this.habitat = habitat;
        }

        public virtual void Input()
        {
            Console.Write("Введите имя существа: ");
            name = Console.ReadLine();
            Console.Write("Введите возвраст существа: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Введите среду обитания существа: ");
            habitat = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возвраст: {age}");
            Console.WriteLine($"Среда оитания: {habitat}");
        }
    }

    class Insect : LiveObject // Насекомое
    {
        protected string type;

        public Insect(string name, int age, string habitat, string type) : base(name, age, habitat)
        {
            this.type = type;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Введите тип насекомого: ");
            type = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Тип: {type}");
        }

        public void Fly()
        {
            Console.WriteLine($"{name} летает не высоко.");
        }
    }

    class Amphibian : LiveObject //Земноводное
    {
        protected bool hasGills;

        public Amphibian(string name, int age, string habitat, bool hasGills) : base(name, age, habitat)
        {
            this.hasGills = hasGills;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("У амфибии есть жанры? (да/нет): ");
            hasGills = Console.ReadLine().ToLower() == "y";
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Наличие жабр: {hasGills}");
        }

        public void Swim()
        {
            Console.WriteLine($"{name} глубоко плавает.");
        }
    }

    class Bird : LiveObject //Птица
    {
        protected string color;

        public Bird(string name, int age, string habitat, string color) : base(name, age, habitat)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Введите цвет птицы: ");
            color = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Цвет: {color}");
        }

        public void Fly()
        {
            Console.WriteLine($"{name} высоко летает.");
        }
    }

    class Primate : LiveObject //Примат
    {
        protected string species;

        public Primate(string name, int age, string habitat, string species) : base(name, age, habitat)
        {
            this.species = species;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Введите вид приматов: ");
            species = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Вид: {species}");
        }

        public void Climb()
        {
            Console.WriteLine($"{name} лазает по деревьям.");
        }
    }

}
