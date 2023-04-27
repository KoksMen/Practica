using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PR19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* #region N1
             XmlDocument doc = new XmlDocument();
             doc.Load(@"C:\Users\xxkok\Source\Repos\KoksMen\Practica\PR19-1\XMLFile1.xml");

             XmlElement root = doc.DocumentElement;

             foreach (XmlNode node in root.ChildNodes)
             {
                 string name = node.Attributes["name"].InnerText;

                 int age = int.Parse(node["Age"].InnerText);

                 bool programmer = bool.Parse(node["Programmer"].InnerText);

                 Console.WriteLine("Name: " + name);
                 Console.WriteLine("Age: " + age);
                 Console.WriteLine("Programmer: " + programmer);
                 Console.WriteLine();

                 Console.WriteLine("Node name: " + node.Name);
                 if (node.Attributes != null)
                 {
                     foreach (XmlAttribute attr in node.Attributes)
                     {
                         Console.WriteLine("Атрибут имени: " + attr.Name);
                         Console.WriteLine("Значение атрибута: " + attr.Value);
                     }
                 }
                 Console.WriteLine();
             }

             Console.ReadLine();
             #endregion*/

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\xxkok\Source\Repos\KoksMen\Practica\PR19-1\XMLFile1.xml");

            PrintNodeInfo(doc.DocumentElement);

        }

        static void PrintNodeInfo(XmlNode node)
        {
            Console.WriteLine("Node Name: " + node.Name);

            if (node.Attributes != null)
            {
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    Console.WriteLine("Attribute: " + attribute.Name + " = " + attribute.Value);
                }
            }

            if (node.NodeType == XmlNodeType.Element && node.HasChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.NodeType == XmlNodeType.Element)
                    {
                        PrintNodeInfo(childNode);
                    }
                    else if (childNode.NodeType == XmlNodeType.Text)
                    {
                        Console.WriteLine("Data: " + childNode.Value);
                    }
                }
            }
        }
    }
}
