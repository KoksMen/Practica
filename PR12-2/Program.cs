using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем продукты и добавляем к ним анонимный метод
            Product product = new Product("Cheese", 15);
            product.productMethod = () => { Console.WriteLine("This is product"); };
            Fruit fruit = new Fruit("Apple", 15, 100);
            fruit.FruitMethod = () => { Console.WriteLine("This is fruit"); };
            Citrus citruc = new Citrus("Orange", 14, "Orange Orange");
            citruc.CitrusMethod = () => { Console.WriteLine("This is orange"); };
            Vegetable vegetable = new Vegetable("Potato", 5, true);
            vegetable.VegetableMethod = () => { Console.WriteLine("This is vegetable"); };
            Greenery greenery = new Greenery("Zelenka", 600, false);
            greenery.GreeneryMethod = () => { Console.WriteLine("This is greenery"); };

            // Вводим данные о продуктах
            product.Edit();
            fruit.Edit();
            citruc.Edit();
            vegetable.Edit();
            greenery.Edit();

            // Выводим информацию о продктах и использование анонимного метода
            Console.WriteLine("\n---Product---");
            product.Show();
            product.productMethod();

            Console.WriteLine("\n---Fruit---");
            fruit.Show();
            fruit.FruitMethod();

            Console.WriteLine("\n---Citrus---");
            citruc.Show();
            citruc.CitrusMethod();

            Console.WriteLine("\n---Vegetable---");
            vegetable.Show();
            vegetable.VegetableMethod();

            Console.WriteLine("\n---Greenery---");
            greenery.Show();
            greenery.GreeneryMethod();

            Console.ReadKey();
        }
    }

    public delegate void CustomMethod();

    public class Product
    {
        protected string Name;
        protected int Price;

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public CustomMethod productMethod;

        public void ShowName() { Console.WriteLine($"Name: {Name}"); }
        public void ShowPrice() { Console.WriteLine($"Price: {Price}"); }
        public void EditName(string newname) { Name = newname; }
        public void EditPrice(int newprice) { Price = newprice; }

        public virtual void Show() { Console.WriteLine($"Name: {Name};\n Price: {Price}"); }
        public virtual void Edit()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter price: ");
            Price = Convert.ToInt32(Console.ReadLine());
        }

    }

    public class Fruit : Product
    {
        protected int Weight;
        public CustomMethod FruitMethod;

        public Fruit(string name, int price, int weight) : base(name, price)
        {
            Weight = weight;
        }

        public void ShowWeight() => Console.WriteLine($"Weight: {Weight}");
        public void EditWeighte(int newweight) { Weight = newweight; }

        public override void Show() { base.Show(); Console.WriteLine($"Weight: {Weight}"); }
        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Enter weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());
        }

    }

    public class Citrus : Product
    {
        protected string Type;
        public CustomMethod CitrusMethod;

        public Citrus(string name, int price, string type) : base(name, price)
        {
            Type = type;
        }

        public void ShowType() => Console.WriteLine($"Type: {Type}");
        public void EditType(string newtype) { Type = newtype; }

        public override void Show() { base.Show(); Console.WriteLine($"Type: {Type}"); }
        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Enter type: ");
            Type = Console.ReadLine();
        }
    }

    public class Vegetable : Product
    {
        protected bool isRipe;
        public CustomMethod VegetableMethod;

        public Vegetable(string name, int price, bool isripe) : base(name, price)
        {
            isRipe = isripe;
        }

        public void ShowRipeStatus() => Console.WriteLine($"Is ripe: {isRipe}");
        public void EditRipeStatus(bool newripestatus) { isRipe = newripestatus; }

        public override void Show() { base.Show(); Console.WriteLine($"Is ripe: {isRipe}"); }
        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Enter ripe status: ");
            isRipe = Convert.ToBoolean(Console.ReadLine());
        }
    }

    public class Greenery : Product
    {
        protected bool isTreated;
        public CustomMethod GreeneryMethod;

        public Greenery(string name, int price, bool istreated) : base(name, price)
        {
            isTreated = istreated;
        }

        public void ShowTreatStatud() => Console.WriteLine($"Is treated: {isTreated}");
        public void EditTreatStatud(bool newtreatedstatus) { isTreated = newtreatedstatus; }

        public override void Show() { base.Show(); Console.WriteLine($"Is treated: {isTreated}"); }
        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Enter treated status: ");
            isTreated = Convert.ToBoolean(Console.ReadLine());
        }
    }
}
