using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Employee", 100);

            employee.ShowPoles();
            employee.ShowDoxod();

            Console.WriteLine("=====================================");

            Manager manager = new Manager(1, 100);

            manager.ShowPoles();
            manager.ShowDoxod();

            Console.WriteLine("=====================================");

            Ingeener ingeener = new Ingeener(1, 100);

            ingeener.ShowPoles();
            ingeener.ShowDoxod();

            Console.ReadLine();
        }
    }

    public class Employee
    {
        private int Id;
        public string Name;
        public int MinimumSalary { get; set; }
        public Employee() { }

        public Employee(int id, string name, int minimumSalary)
        {
            Id = id;
            Name = name;
            MinimumSalary = minimumSalary;
        }

        public void ShowPoles() => Console.WriteLine($"ID: {Id}, Name: {Name}");
        public void ShowDoxod()
        {
            Console.Write("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Doxod: {k*MinimumSalary}");
        }
    }

    public class Manager: Employee
    {
        private int Id;
        public int SellsInTonas { get; set; }
        public Manager() { }

        public Manager(int id, int sellsInTonas)
        {
            Id = id;
            SellsInTonas = sellsInTonas;
        }

        public void ShowPoles() => Console.WriteLine($"ID: {Id}, Sells In Tonas: {SellsInTonas}");

        public void ShowDoxod()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (SellsInTonas > n)
            {
                Console.WriteLine($"Doxod: {SellsInTonas + SellsInTonas * 0.01}");
            }
            else
            {
                Console.WriteLine($"Doxod: {SellsInTonas}");
            }
        }
    }

    public class Ingeener: Employee
    {
        private int Id;
        public int CountDevelopedProjects { get; set; }
        public Ingeener() { }

        public Ingeener(int id, int countDevelopedProjects)
        {
            Id = id;
            CountDevelopedProjects = countDevelopedProjects;
        }

        public void ShowPoles() => Console.WriteLine($"ID: {Id}, Count developed projects: {CountDevelopedProjects}");

        public void ShowDoxod()
        {
            Console.WriteLine($"Doxod: {4.8 * CountDevelopedProjects}");
        }
    }
}
