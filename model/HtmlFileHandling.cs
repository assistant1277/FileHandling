using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.model
{
    internal class HtmlFileHandling
    {
        public static void ReadHtml()
        { 
            //path where my file is there
            string filePath = "D:\\monocept\\tasks\\FileHandling\\model\\read_html.html";

            //check if file exist in specific path
            if (File.Exists(filePath))
            {
                Console.WriteLine("b) reading html data =>\n");
                //if file exist read content from the file and store in variable
                string content = File.ReadAllText(filePath);
                Console.WriteLine("html file data/content ");

                //output will display the contents from html file
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("file of html(HTML) not found or not exist");
            }
            
           
        }

        public static void WriteHtml()
        {
            string filePath = "D:\\monocept\\tasks\\FileHandling\\model\\write_html.html";

            //this is xml data that i will going to send to file write_html.xml file
            string content = "<html><head><title>html website</title></head><body><h1>Hello This is my Landing page demo</h1><p>Here is my paragraph tag</p></body></html>\n";

            //write content to file if file exist it will overwrite the old content
            File.WriteAllText(filePath, content);

            //confirmation message that data has been written in the file
            Console.WriteLine("b) html(HTML) data has been written into the write_html.html file\n");
        }
    }
}
