using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assistant assistant = new Assistant("MAche", "chin", 15, 43);
            assistant.AddAssistant += Assistant_AddAssistant;
            assistant.DoSomthing();

            Manager manager = new Manager("Ticho", "novich", 188, 14, 25);
            manager.AddManager += Manager_AddManager;
            manager.DoSomthing();
        }

        private static void Manager_AddManager()
        {
            Console.WriteLine("Manager is added");
        }

        private static void Assistant_AddAssistant()
        {
            Console.WriteLine("Assitant is added");
        }
    }

    public class Person
    {
        public Person(string name, string fIO, int salary)
        {
            Name = name;
            FIO = fIO;
            Salary = salary;
        }

        public string Name { get; set; }
        public string FIO { get; set; }
        public int Salary { get; set; }

    }

    public class Assistant : Person
    {
        public Assistant(string name, string fIO, int salary, int seniority) : base(name, fIO, salary)
        {
            Seniority = seniority;
        }

        public int Seniority { get; set; }
        public virtual double Salarysum => Salary + Seniority * 0.2;

        public void DoSomthing()
        {
            Console.WriteLine("Make something...");
            AddAssistant?.Invoke();
        }

        public event Action AddAssistant;
    }

    public class Manager : Assistant
    {
        public Manager(string name, string fIO, int salary, int seniority, int subordinate) : base(name, fIO, salary, seniority)
        {
            Subordinate = subordinate;
        }

        public int Subordinate { get; set; }

        public override double Salarysum => Salary + Subordinate * 0.2 + Seniority * 0.2;

        public event Action AddManager;

        public void DoSomthing()
        {
            Console.WriteLine("Make something...");
            AddManager?.Invoke();
        }
    }
}
