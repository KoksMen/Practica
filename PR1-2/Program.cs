using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _myName = "Nikita";
            string _mySurname = "Nishpor";
            string _myPatronymic = "Fedorovich";
            DateTime _myBirthday = new DateTime(2004, 12, 14);
            string _myHobbie = "Learn C# in college";
            string _moutherName = "MotherName1";
            string _moutherSurname = "MotherSurname1";
            string _moutherPatronymic = "MotherPatronymic1";
            string _fatherName = "FatherName1";
            string _fatherSurname = "FatherSurname1";
            string _fatherPatronymic = "FatherPatronymic1";

            InfoAboutMe NishporInfo = new InfoAboutMe(
                _myName,
                _mySurname,
                _myPatronymic,
                _myBirthday,
                _myHobbie,
                _moutherName,
                _moutherSurname,
                _moutherPatronymic,
                _fatherName,
                _fatherSurname,
                _fatherPatronymic
                );

            string _myInfo = NishporInfo.showInfo();
            Console.WriteLine(_myInfo );

        }

    }

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
}
