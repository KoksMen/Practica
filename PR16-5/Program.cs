using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("animal1", 15, @"D:\Nishpor.txt");
            Bird bird = new Bird("bird1", 15, @"D:\Nishpor.txt");
            Mlekopit mlekopit = new Mlekopit("mlekopit1", 15, @"D:\Nishpor.txt");
            Parnokopit parnokopit = new Parnokopit("parnokopit1", 15, @"D:\Nishpor.txt");
            AnimalObjet animalobject = new AnimalObjet(@"D:\Nishpor.txt");

            animal.Input();
            bird.Input();
            mlekopit.Input();
            parnokopit.Input();

            animal.Output();
            bird.Output();
            mlekopit.Output();
            parnokopit.Output();
            animalobject.DisplayAnimals();
        }
    }

    class AnimalObjet
    {
        private string FileName;

        public AnimalObjet(string fileName)
        {
            FileName = fileName;
        }

        public void AddAnimal(Animal animal)
        {
            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine($"{animal.Type},{animal.Name},{animal.Age}");
            }
        }

        public void AddBird(Bird bird)
        {
            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine($"{bird.Type},{bird.Name},{bird.Age}");
            }
        }

        public void AddMlekopl(Mlekopit mlekopit)
        {
            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine($"{mlekopit.Type},{mlekopit.Name},{mlekopit.Age}");
            }
        }

        public void AddParnokopit(Parnokopit parnokopit)
        {
            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine($"{parnokopit.Type},{parnokopit.Name},{parnokopit.Age}");
            }
        }

        public void DisplayAnimals()
        {
            using (StreamReader sr = File.OpenText(FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    switch (parts[0])
                    {
                        case "Animal":
                            Animal animal = new Animal(parts[1], int.Parse(parts[2]), FileName);
                            animal.Output();
                            break;
                        case "Bird":
                            Bird bird = new Bird(parts[1], int.Parse(parts[2]), FileName);
                            bird.Output();
                            break;
                        case "Parnokopit":
                            Parnokopit parnokopit = new Parnokopit(parts[1], int.Parse(parts[2]), FileName);
                            parnokopit.Output();
                            break;
                        case "Mlekopit":
                            Mlekopit mlekopit = new Mlekopit(parts[1], int.Parse(parts[2]), FileName);
                            mlekopit.Output();
                            break;
                    }
                }
            }
        }
    }

    class Animal : AnimalObjet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Animal(string name, int age, string fileName) : base(fileName)
        {
            Name = name;
            Age = age;
            Type = "Bird";
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            base.AddAnimal(this);
        }

        public void Output()
        {
            Console.WriteLine($"Type: {Type}, Name: {Name}, Age: {Age}");
        }
    }

    class Bird : AnimalObjet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Bird(string name, int age, string fileName): base(fileName)
        {
            Name = name;
            Age = age;
            Type = "Bird";
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            base.AddBird(this);
        }

        public void Output()
        {
            Console.WriteLine($"Type: {Type}, Name: {Name}, Age: {Age}");
        }
    }

    class Mlekopit : AnimalObjet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Mlekopit(string name, int age, string fileName) : base(fileName)
        {
            Name = name;
            Age = age;
            Type = "Mlekopit";
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            base.AddMlekopl(this);
        }

        public void Output()
        {
            Console.WriteLine($"Type: {Type}, Name: {Name}, Age: {Age}");
        }
    }

    class Parnokopit : AnimalObjet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Parnokopit(string name, int age, string fileName) : base(fileName)
        {
            Name = name;
            Age = age;
            Type = "Parnokopit";
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            base.AddParnokopit(this);
        }

        public void Output()
        {
            Console.WriteLine($"Type: {Type}, Name: {Name}, Age: {Age}");
        }
    }
}
