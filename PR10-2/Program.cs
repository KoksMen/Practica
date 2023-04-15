using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Name = "Nikita", Age = 18, Salary = 10000, Post = "Imperator" };

            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Post: {employee.Post}");

            employee.ChangeName("Nikita II");
            employee.ChangeAge(1);
            employee.ChangePost("Son of Imperator");
            employee.ChangeSalary(1000);

            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Post: {employee.Post}");

            employee.CalculateSalary();
        }
    }

    public abstract class Person
    {
        public string Name;
        public int Age;

        public void ChangeName(string newname) => Name = newname;
        public void ChangeAge(int newage) => Age = newage;
    }

    public class Employee : Person
    {
        public string Post;
        public double Salary;

        public void ChangePost(string newpost) => Post = newpost;
        public void ChangeSalary(double newsalary) => Salary = newsalary;

        public void CalculateSalary()
        {
            Console.Write("Write % salary: ");
            int percentage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Current salary: {Salary+(Salary * percentage / 100)}");
        }
    }
}
