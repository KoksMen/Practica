using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameValidator name = new NameValidator();
            name.Name = "Никита";
            var genric1 = new OneParam<NameValidator>(name);
            var generic3 = new ThreeParam<string, string, int>("Никита", "Нишпор", 18);
            genric1.Print();
            generic3.Print();

            Console.ReadLine();
        }
    }

    class NameValidator
    {
        public string Name;
    }

    class OneParam<T> where T : NameValidator
    {
        private readonly T _name;

        public OneParam(T name)
        {
            _name = name;
        }

        public void Print()
        {
            Console.WriteLine(_name.Name);
        }
    }

    class ThreeParam<T1, T2, T3>
    {
        private readonly T1 _firstName;
        private readonly T2 _lastName;
        private readonly T3 _age;

        public ThreeParam(T1 firstName, T2 lastName, T3 age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public void Print()
        {
            Console.WriteLine($"{_firstName} {_lastName}, возраст {_age}");
        }
    }
}
