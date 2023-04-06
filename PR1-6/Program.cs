using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1 zadanie1 = new Zadanie1(18);
            zadanie1.setWidthHeightConsole();

            InfoAboutMe NishporInfo = new InfoAboutMe(
                "Nikita",
                "Nishpor",
                "Fedorovich",
                new DateTime(2004, 12, 14),
                "Learn C# in college",
                "MotherName1",
                "MotherSurname1",
                "MotherPatronymic1",
                "FatherName1",
                "FatherSurname1",
                "FatherPatronymic1"
                );
            string _myInfo = NishporInfo.showInfo();
            Console.WriteLine(_myInfo);

            Zadanie3 zadanie3 = new Zadanie3(-0.19, 7.25, -0.48);
            double result3 = zadanie3.getY();
            Console.WriteLine($"Y result = {result3}");

            Zadanie4 zadanie4 = new Zadanie4(-0.19, -1);
            double result4 = zadanie4.getAlpha();
            Console.WriteLine($"Alpha result = {result4}");

            Zadanie5 zadanie5 = new Zadanie5(35, 95);
            double result5 = zadanie5.getCount();
            Console.WriteLine($"Result = {result5}");
        }
    }

    #region Zadanie1
    public class Zadanie1
    {
        private int variant;

        public Zadanie1(int variant)
        {
            this.variant = variant;
        }

        public void setWidthHeightConsole()
        {
            int size = 10 + variant * 4;
            int width = size;
            int height = size;
            Console.SetWindowSize(width, height);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Nishpor Nikita, PC-31, Variant 18, Practice 1, Zadanie 1";
        }
    }
    #endregion
    #region Zadanie2
    public class InfoAboutMe
    {
        private string _myName;
        private string _mySurname;
        private string _myPatronymic;
        private DateTime _myBirthday;
        private string _myHobbie;
        private string _moutherName;
        private string _moutherSurname;
        private string _moutherPatronymic;
        private string _fatherName;
        private string _fatherSurname;
        private string _fatherPatronymic;

        public InfoAboutMe(string myName, string mySurname, string myPatronymic,
            DateTime myBirthday, string myHobbie, string moutherName,
            string moutherSurname, string moutherPatronymic,
            string fatherName, string fatherSurname, string fatherPatronymic)
        {
            _myName = myName;
            _mySurname = mySurname;
            _myPatronymic = myPatronymic;
            _myBirthday = myBirthday;
            _myHobbie = myHobbie;
            _moutherName = moutherName;
            _moutherSurname = moutherSurname;
            _moutherPatronymic = moutherPatronymic;
            _fatherName = fatherName;
            _fatherSurname = fatherSurname;
            _fatherPatronymic = fatherPatronymic;
        }

        public string showInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"My name: {_myName}");
            builder.AppendLine($"My surname: {_mySurname}");
            builder.AppendLine($"My patronymic: {_myPatronymic}");
            builder.AppendLine($"My birthday: {_myBirthday.ToString()}");
            builder.AppendLine($"My hobbie: {_myHobbie}");
            builder.AppendLine($"Mother name: {_moutherName}");
            builder.AppendLine($"Mother surname: {_moutherSurname}");
            builder.AppendLine($"Mother patronymic: {_moutherPatronymic}");
            builder.AppendLine($"Father name: {_fatherName}");
            builder.AppendLine($"Father surname: {_fatherSurname}");
            builder.AppendLine($"Father patronymic: {_fatherPatronymic}");

            string result = builder.ToString();

            return result;
        }
    }
    #endregion
    #region Zadanie3
    public class Zadanie3
    {
        private double a;
        private double b;
        private double c;

        public Zadanie3(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getY()
        {
            double y;

            y = (3 * Math.Sin(a * Math.Pow(b, 2)) - Math.Pow(Math.Cos(c), 3)) / (Math.Pow(Math.E, a) - Math.Pow(b, (c + a)));

            return y;
        }
    }
    #endregion
    #region Zadaini4
    public class Zadanie4
    {
        private double a;
        private double b;

        public Zadanie4(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double getAlpha()
        {
            double alpha;

            double ab1 = (a * b + 1);
            double asin = Math.Asin(b);

            alpha = Math.Sqrt(Math.Pow(Math.E, ab1) + asin);

            return alpha;
        }
    }
    #endregion
    #region Zadanie5
    public class Zadanie5
    {
        private double tons;
        private double germination;

        public Zadanie5(double tons, double germination)
        {
            this.tons = tons;
            this.germination = germination;
        }

        public double getCount()
        {
            double result;

            result = (tons / germination) * 100;

            return result;
        }
    }
    #endregion
}
