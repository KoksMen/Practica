using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace PR19_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type;

            while (true)
            {
                Console.Clear();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("Technical.xml");

                XmlElement RootElement = xDoc.DocumentElement;

                foreach (XmlNode Node in RootElement)
                {
                    if (Node.Attributes.Count > 0)
                    {
                        XmlNode attr = Node.Attributes.GetNamedItem("name");
                        if (attr != null) Console.WriteLine($"Name: {attr.Value}");
                    }
                    foreach (XmlNode ChildNode in Node.ChildNodes)
                    {
                        if (ChildNode.Name == "LastName") Console.Write($"LastName: {ChildNode.InnerText} ");
                        if (ChildNode.Name == "gender") Console.Write($"Gender: {ChildNode.InnerText} ");
                        if (ChildNode.Name == "DataCheck") Console.Write($"Data Check: {ChildNode.InnerText} ");
                        if (ChildNode.Name == "Mark") Console.Write($"Mark: {ChildNode.InnerText}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Enter your action:\n1)Add new,\n2)Edit,\n3)Delete,\n4)Find");
                type = Console.ReadLine();

                switch (type)
                {
                    case "1": //ADD
                        XDocument xDocAdd = XDocument.Load("Technical.xml");
                        XElement root = xDocAdd.Element("Technicks");

                        if (root != null)
                        {
                            Console.WriteLine("Enter name of new student: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter lastname of new student: ");
                            string lastname = Console.ReadLine();
                            Console.WriteLine("Enter gender of new student: ");
                            string gender = Console.ReadLine();
                            Console.WriteLine("Enter datacheck of new student: ");
                            string datacheck = Console.ReadLine();
                            Console.WriteLine("Enter mark of new student: ");
                            string mark = EnterMark();
                            root.Add(new XElement("technick",
                                        new XAttribute("name", name),
                                        new XElement("LastName", lastname),
                                        new XElement("gender", gender),
                                        new XElement("DataCheck", datacheck),
                                        new XElement("Mark", mark)));

                            xDocAdd.Save("Technical.xml");
                        }
                        Console.ReadLine();
                        break;
                    case "2": //EDIT
                        XDocument xDocEdit = XDocument.Load("Technical.xml");
                        Console.WriteLine("Enter technick name, who you want to edit");
                        string Editfindname = Console.ReadLine();
                        var Editfindstudent = xDocEdit.Element("Technicks")?
                            .Elements("technick")
                            .FirstOrDefault(p => p.Attribute("name")?.Value == Editfindname);

                        Console.WriteLine("Enter type edit: 1)all 2)name 3)lastname 4)gender 5)datacheck 6)mark");
                        string typedit = Console.ReadLine();
                        bool Editresult = false;
                        
                        switch (typedit)
                        {
                            case "1":
                                if (Editfindstudent != null)
                                {
                                    Editresult = true;
                                    var name1 = Editfindstudent.Attribute("name");
                                    if (name1 != null)
                                    {
                                        Console.WriteLine("Enter new student name: ");
                                        string newname = Console.ReadLine();
                                        name1.Value = newname;
                                    }
                                    var lastname1 = Editfindstudent.Element("LastName");
                                    if (lastname1 != null)
                                    {
                                        Console.WriteLine("Enter new technick LastName: ");
                                        string newlastname = Console.ReadLine();
                                        lastname1.Value = newlastname;
                                    }
                                    var gender1 = Editfindstudent.Element("gender");
                                    if (gender1 != null)
                                    {
                                        Console.WriteLine("Enter new technick gender: ");
                                        string newgender = Console.ReadLine();
                                        gender1.Value = newgender;
                                    }
                                    var datacheck1 = Editfindstudent.Element("DataCheck");
                                    if (datacheck1 != null)
                                    {
                                        Console.WriteLine("Enter new technick DataCheck: ");
                                        string newdatacheck = Console.ReadLine();
                                        datacheck1.Value = newdatacheck;
                                    }
                                    var mark1 = Editfindstudent.Element("Mark");
                                    if (mark1 != null)
                                    {
                                        Console.WriteLine("Enter new technick Mark: ");
                                        string newmark = EnterMark();
                                        mark1.Value = newmark;
                                    }

                                    xDocEdit.Save("Technical.xml");
                                }
                                break;
                            case "2":
                                Editresult = true;
                                var name = Editfindstudent.Attribute("name");
                                if (name != null)
                                {
                                    Console.WriteLine("Enter new student name: ");
                                    string newname = Console.ReadLine();
                                    name.Value = newname;
                                }
                                xDocEdit.Save("Technical.xml");

                                break;
                            case "3":
                                Editresult = true;
                                var lastname = Editfindstudent.Element("LastName");
                                if (lastname != null)
                                {
                                    Console.WriteLine("Enter new technick LastName: ");
                                    string newlastname = Console.ReadLine();
                                    lastname.Value = newlastname;
                                }
                                xDocEdit.Save("Technical.xml");

                                break;
                            case "4":
                                Editresult = true;
                                var gender = Editfindstudent.Element("gender");
                                if (gender != null)
                                {
                                    Console.WriteLine("Enter new technick gender: ");
                                    string newgender = Console.ReadLine();
                                    gender.Value = newgender;
                                }
                                xDocEdit.Save("Technical.xml");

                                break;
                            case "5":
                                Editresult = true;
                                var datacheck = Editfindstudent.Element("DataCheck");
                                if (datacheck != null)
                                {
                                    Console.WriteLine("Enter new technick DataCheck: ");
                                    string newdatacheck = Console.ReadLine();
                                    datacheck.Value = newdatacheck;
                                }
                                xDocEdit.Save("Technical.xml");

                                break;
                            case "6":
                                Editresult = true;
                                var mark = Editfindstudent.Element("Mark");
                                if (mark != null)
                                {
                                    Console.WriteLine("Enter new technick Mark: ");
                                    string newmark = EnterMark();
                                    mark.Value = newmark;
                                }
                                xDocEdit.Save("Technical.xml");

                                break;
                            default: 
                                Console.WriteLine("Error");
                                break;

                        }

                        
                        if (Editresult == false) Console.WriteLine("Technick not found...");
                        Console.ReadLine();
                        break;
                    case "3": //DELETE
                        XDocument xDocDelete = XDocument.Load("Technical.xml");
                        XElement xRootDelete = xDocDelete.Element("Technicks");

                        bool Deleteresult = false;
                        if (xRootDelete != null)
                        {
                            Console.WriteLine("Enter Technick name, who you want to delete");
                            string Deletefindname = Console.ReadLine();
                            var Deletefindstudent = xRootDelete.Elements("technick")
                                .FirstOrDefault(p => p.Attribute("name")?.Value == Deletefindname);
                            if (Deletefindstudent != null)
                            {
                                Deleteresult = true;
                                Deletefindstudent.Remove();
                                xDocDelete.Save("Technical.xml");
                            }
                            if (Deleteresult == false) Console.WriteLine("Technick not found...");
                        }
                        Console.ReadLine();
                        break;
                    case "4": //FIND
                        XDocument xDocFind = XDocument.Load("Technical.xml");
                        Console.Write("Enter name of find technick:");
                        string findname = Console.ReadLine();
                        var findstudent = xDocFind.Element("Technicks").Elements("technick").
                        Where(x => x.Attribute("name").Value == findname)
                        .Select(p => new
                        {
                            name = p.Attribute("name").Value,
                            lastname = p.Element("LastName").Value,
                            gender = p.Element("gender").Value,
                            dataCheck = p.Element("DataCheck").Value,
                            mark = p.Element("Mark").Value,
                        });
                        bool ResultOfFindStudent = false;
                        if (findstudent != null)
                        {
                            foreach (var student in findstudent)
                            {
                                ResultOfFindStudent = true;
                                Console.WriteLine($"name: {student.name}, " +
                                    $"LastName: {student.lastname}, " +
                                    $"Gender: {student.gender}, " +
                                    $"DataCheck: {student.dataCheck}, " +
                                    $"Mark: {student.mark}  ");
                            }
                        }
                        if (ResultOfFindStudent == false) Console.WriteLine("technick not found");
                        Console.ReadLine();

                        break;
                    default: //TRY AGAIN OR ERROR
                        Console.WriteLine("Error, try again...");
                        Console.ReadLine();
                        break;
                }

            }
            Console.ReadLine();
        }

        static string EnterMark()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (number >= 1 && number <= 10)
                    {
                        Console.WriteLine("Число находится в промежутке от 1 до 10.");
                        return input;
                    }
                    else
                    {
                        Console.WriteLine("Число не находится в промежутке от 1 до 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Введенная строка не является числом.");
                }
            }
        }
    }
}
