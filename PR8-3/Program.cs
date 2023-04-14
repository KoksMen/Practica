using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR8_2;

namespace PR8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter inspector name: ");
            string inspector = Console.ReadLine();
            Console.Write("Enter hour count: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Faculty faculty = new Faculty() { Inspector = inspector, HoursCount = hour, Subjects = new List<Subject>() };
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter subject name: ");
                string name = Console.ReadLine();
                Console.Write("Enter subject fio: ");
                string fio = Console.ReadLine();
                Console.Write("Enter subject group: ");
                string group = Console.ReadLine();
                Console.Write("Enter subject ball: ");
                int ball = Convert.ToInt32(Console.ReadLine());
                faculty.Subjects.Add(CreateSubject(name, fio, group, ball));
            }

            Console.WriteLine($"Ball sum: {faculty.GetSumBalls()}");

            Console.Write("Enter num subject: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine(faculty.Subjects.First(x => x.Name == TypeSubject.Rus.ToString()).Name);
                    break;
                case 2:
                    Console.WriteLine(faculty.Subjects.First(x => x.Name == TypeSubject.Bel.ToString()).Name);
                    break;
                case 3:
                    Console.WriteLine(faculty.Subjects.First(x => x.Name == TypeSubject.Math.ToString()).Name);
                    break;
                case 4:
                    Console.WriteLine(faculty.Subjects.First(x => x.Name == TypeSubject.Chiemisty.ToString()).Name);
                    break;
                case 5:
                    Console.WriteLine(faculty.Subjects.First(x => x.Name == TypeSubject.Fizra.ToString()).Name);
                    break;
            }
        }

        public static Subject CreateSubject(string name, string fio, string group, int ball) => new Subject { Name = name, FIO = fio, Group = group, TeacherBall = ball };

        public enum TypeSubject
        {
            Rus,
            Bel,
            Math,
            Chiemisty,
            Fizra
        }

        public struct Subject
        {
            public string Name;
            public string FIO;
            public string Group;
            public int TeacherBall;

            public void ChangeName(string name) { Name = name; }
            public void ChangeFIO(string fio) { FIO = fio; }
            public void ChangeGroup(string group) { Group = group; }
        }

        public struct Faculty
        {
            public List<Subject> Subjects;
            public string Inspector;
            public int HoursCount;

            public void ChangeInspector(string inspector) { Inspector = inspector; }
            public void ChangeHoursCount(int hours) { HoursCount = hours; }

            public int GetSumBalls() => Subjects.Sum(subject => subject.TeacherBall);
            public int GetCountBalls() => Subjects.Count;
        }

    }
}
