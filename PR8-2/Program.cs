using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PR8_2
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
            Console.Clear();
            faculty.stringShow();

            Console.WriteLine($"Ball sum: {faculty.GetSumBalls()}");



        }

        public static Subject CreateSubject(string name, string fio, string group, int ball) => new Subject { Name = name, FIO = fio, Group = group, TeacherBall = ball };
    }
    public class Subject
    {
        public string Name;
        public string FIO;
        public string Group;
        public int TeacherBall;

        public void ChangeName(string name) { Name = name; }
        public void ChangeGroup(string group) { Group = group; }
        public override string ToString()
        {
            Console.WriteLine(Name);
            return Name;
        }
    }

    public class Faculty
    {
        public List<Subject> Subjects;
        public string Inspector;
        public int HoursCount;

        public void ChangeSubject(string subjectnewname, string subjectoldname) { Subjects.First(x => x.Name == subjectoldname).Name = subjectnewname; }
        public void ChangeInspector(string inspector) { Inspector = inspector; }
        public void ChangeHoursCount(int hours) { HoursCount = hours; }
        public void ChangeTeacherBall(int ball, string subjectoldname) { Subjects.First(x => x.Name == subjectoldname).TeacherBall = ball; }

        public int GetSumBalls() => Subjects.Sum(subject => subject.TeacherBall);
        public int GetCountBalls() => Subjects.Count;
        public void stringShow()
        {
            Subjects.ForEach(x => x.ToString());
        }
    }
}
