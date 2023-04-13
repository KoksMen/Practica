using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PR7_3
{
    internal class Program
    {
        static void Main()
        {
            string input = "Lorem 192.168.1.1 ipsum 0x0A000001 dolor 012700000001 sit amet.";

            string pattern = @"(?<![\d\.])(?:\d{1,3}\.){3}\d{1,3}(?![\d\.])|\b0x[0-9a-fA-F]{1,8}\b|\b0[0-7]{1,11}\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            string output = "";
            foreach (Match match in matches)
            {
                string ipAddress = match.Value;

                if (ipAddress.StartsWith("0x"))
                {
                    // Шестнадцатеричное представление
                    uint ipValue = Convert.ToUInt32(ipAddress.Substring(2), 16);
                    ipAddress = new System.Net.IPAddress(ipValue).ToString();
                }
                else if (ipAddress.StartsWith("0"))
                {
                    // Восьмеричное представление
                    uint ipValue = Convert.ToUInt32(ipAddress, 8);
                    ipAddress = new System.Net.IPAddress(ipValue).ToString();
                }

                output += ipAddress + ".";
            }

            output = output.TrimEnd('.');

            Console.WriteLine(output);
        }
    }
}
