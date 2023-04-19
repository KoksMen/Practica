using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            for (int i = 0; i < students.Length; i++)
            {
                Student student = new Student($"Nikita{i}", $"Nishpor{i}");
                student.StudentEvent += Student_StudentEvent;
                students[i] = student;
            }

            while (true)
            {
                Random random = new Random();
                int rnd = random.Next(1, 5);
                students[rnd].OnShouldAnswer();

                Console.ReadLine();
            }
        }

        private static void Student_StudentEvent(Student student)
        {
            Console.WriteLine($"Учащийся {student.LastName} {student.FirstName} должен ответить");
        }
    }

    public delegate void StudentDelegate(Student student);

    public class Student
    {
        public string FirstName;
        public string LastName;

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public event StudentDelegate StudentEvent;

        public void OnShouldAnswer()
        {
            StudentEvent?.Invoke(this);
        }
    }
}
