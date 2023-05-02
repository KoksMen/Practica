using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

namespace PR19_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string docxFilePath = @"C:\Users\xxkok\Desktop\doc.docx";
            string xmlFilePath = @"C:\Users\xxkok\Desktop\xml.xml";

            ConvertDocxToXml(docxFilePath, xmlFilePath);
        }

        public static void ConvertDocxToXml(string docxFilePath, string xmlFilePath)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(docxFilePath, true))
            {
                MainDocumentPart mainPart = doc.MainDocumentPart;
                string xmlContent = mainPart.Document.OuterXml;

                using (StreamWriter sw = new StreamWriter(xmlFilePath))
                {
                    sw.Write(xmlContent);
                }
            }
        }
    }
}
