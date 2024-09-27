using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.model
{
    internal class TextFileHandling
    {
        public static void ReadText()
        {
            string filePath = "D:\\monocept\\tasks\\FileHandling\\model\\read_text.txt";

            //check if file exist in specific path
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nc) reading text data =>\n");

                //if file exist read content from the file and store in variable
                string content = File.ReadAllText(filePath);
                Console.WriteLine("text file contents ");

                //output will display the contents from text file
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("text file does not exist");
            }
        }

        public static void WriteText()
        {
            string filePath = "D:\\monocept\\tasks\\FileHandling\\model\\write_text.txt";

            //this is xml data that i will going to send to file write_text.xml file
            string content = "this is basic text file \n it having no contents";

            //write content to file if file exist it will overwrite the old content
            File.WriteAllText(filePath, content);

            //confirmation message that data has been written in the file
            Console.WriteLine("c) text data has been written to the file which is write_text.txt\n");
        }
    }
}
