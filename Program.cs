using FileHandling.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1) reading files");
            XmlFileHandling.ReadXml();
            HtmlFileHandling.ReadHtml();
            TextFileHandling.ReadText();

            Console.WriteLine();
            
            Console.WriteLine("\n2) writing into files");
            XmlFileHandling.WriteXml();
            HtmlFileHandling.WriteHtml();
            TextFileHandling.WriteText();
            

            Console.WriteLine("\n3) console username database");
            Handler.StoreNamesData();
            Handler.PrintNamesData();

            Console.ReadKey();
        }
    }
}
