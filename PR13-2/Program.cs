using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаём наши классы
            Product product = new Product("Product1", "Description1");
            product.ProductEvent += () => { Console.WriteLine("Product event invoked..."); };
            Computer computer = new Computer("Computer1", "Description2", 205);
            computer.ProductEvent += () => { Console.WriteLine("This computer product event"); };
            computer.ComputerEvent += () => { Console.WriteLine("Computer event invoked..."); };
            Notebook notebook = new Notebook("Notebook1", "Description3", 12);
            notebook.ProductEvent += () => { Console.WriteLine("This notebook product event"); };
            notebook.NotebookEvent += () => { Console.WriteLine("Notebook event invoked..."); };
            Keyboard keyboard = new Keyboard("Keyboard1", "Desciprion4", 187);
            keyboard.ProductEvent += () => { Console.WriteLine("This keyboard product event"); };
            keyboard.KeyboardEvent += () => { Console.WriteLine("Keyboard event invoked..."); };
            Mouse mouse = new Mouse("Mouse1", "Desciption5", "A4");
            mouse.ProductEvent += () => { Console.WriteLine("This mouse product event"); };
            mouse.MouseEvent += () => { Console.WriteLine("Mouse event invoked..."); };

            //Вызываем события
            Console.WriteLine("---------Product----------");
            product.OnProduct();
            Console.WriteLine("---------Computer----------");
            computer.OnProduct();
            computer.OnComputer();
            Console.WriteLine("---------Notebook----------");
            notebook.OnProduct();
            notebook.OnNotebook();
            Console.WriteLine("---------Keyboard----------");
            keyboard.OnProduct();
            keyboard.OnKeyboard();
            Console.WriteLine("---------Mouse----------");
            mouse.OnProduct();
            mouse.OnMouse();
        }
    }

    public class Product
    {
        public string name;
        public string description;

        public event Action ProductEvent;

        public Product(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void OnProduct()
        {
            ProductEvent?.Invoke();
        }
    }

    public class Computer : Product
    {
        public int price;

        public event Action ComputerEvent;

        public Computer(string name, string description, int price) : base(name, description)
        {
            this.price = price;
        }

        public void OnComputer()
        {
            ComputerEvent?.Invoke();
        }
    }

    public class Notebook : Product
    {
        public int count;

        public event Action NotebookEvent;

        public Notebook(string name, string description, int count) : base(name, description)
        {
            this.count = count;
        }

        public void OnNotebook()
        {
            NotebookEvent?.Invoke();
        }
    }

    public class Keyboard : Product
    {
        public int keycount;

        public event Action KeyboardEvent;

        public Keyboard(string name, string description, int keycount) : base(name, description)
        {
            this.keycount = keycount;
        }

        public void OnKeyboard()
        {
            KeyboardEvent?.Invoke();
        }
    }

    public class Mouse : Product
    {
        public string Creater;

        public event Action MouseEvent;

        public Mouse(string name, string description, string Creater) : base(name, description)
        {
            this.Creater = Creater;
        }

        public void OnMouse()
        {
            MouseEvent?.Invoke();
        }
    }

    public class Headphones : Product
    {
        public string Modifer;

        public event Action ModiferEvent;

        public Headphones(string name, string description, string Modifer) : base(name, description)
        {
            this.Modifer = Modifer;
        }

        public void OnHeadphones()
        {
            ModiferEvent?.Invoke();
        }
    }
}
