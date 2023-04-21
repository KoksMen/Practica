using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lektsii.Lektsii lektsii = new Lektsii.Lektsii("Lektsii1", 17);
            Laboratornii_raboti.Laboratornii laboratornii = new Laboratornii_raboti.Laboratornii("Lab1", 15);
            Practical_raboti.Practice practice = new Practical_raboti.Practice("pr1", 16);
            Zanatii.Zanatii zanatii = new Zanatii.Zanatii("zanatii1", 17);

            lektsii.Input();
            laboratornii.Input();
            practice.Input();
            zanatii.Input();

            lektsii.Output();
            laboratornii.Output();
            practice.Output();
            zanatii.Output();
        }
    }
}

namespace Lektsii {
    
    public class Lektsii
    {
        public string Name;
        public int Count;

        public Lektsii(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public void Input()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            
            Console.WriteLine("Enter count: ");
            Count = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Lektsii Name {Name}, Count {Count}");
        }
    }
}
namespace Practical_raboti { 
    class Practice
    {
        public string Name;
        public int Count;

        public Practice(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public void Input()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter count: ");
            Count = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"practice Name {Name}, Count {Count}");
        }
    }
}
namespace Laboratornii_raboti {
    class Laboratornii
    {
        public string Name;
        public int Count;

        public Laboratornii(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public void Input()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter count: ");
            Count = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Laboratornii practice Name {Name}, Count {Count}");
        }
    }
}
namespace Zanatii {
    class Zanatii
    {
        public string Name;
        public int Count;

        public Zanatii(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public void Input()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Zanatii Enter count: ");
            Count = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"practice Name {Name}, Count {Count}");
        }
    }
}
