using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17_5_Library
{
    public class StringModifier
    {
        public int CountLetterA(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A' && i < input.Length - 1 && input[i + 1] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        public int CountLetterS(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == 'O' && input[i + 1] == 'S')
                {
                    count++;
                }
            }
            return count;
        }

        public string ReplaceLetterN(string input)
        {
            return input.Replace("N", "won");
        }

        public List<string> ReadFile(string path)
        {
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            return lines;
        }
    }

}
