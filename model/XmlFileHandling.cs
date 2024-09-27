using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.model
{
    internal class XmlFileHandling
    {
        public static void ReadXml()
        {
            //path where my file is located
            string filePath = "D:\\monocept\\tasks\\FileHandling\\model\\read_data.xml";

            //check if file exist in specific path
            if (File.Exists(filePath))
            {
                Console.WriteLine("\n a) reading XML data => \n");

                //if file exist read content from the file and store in variable
                string content = File.ReadAllText(filePath);
                Console.WriteLine("XML file data/content ");

                //output will display the contents from text file
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("XML file do not exist or not found");
            }
        }

        public static void WriteXml()
        {
            string filePath = "D:\\monocept\\tasks\\FileHandling\\model\\write_data.xml";

            //this is xml data that i will going to send to file write_data.xml file
            string content =
                "<Persons>" + "<User><Name>Mohmad Raffi</Name><Age>37</Age><Place>Mumbai</place></User>" + "<User><Name>Kishor Kumar</Name><Age>32</Age><Place>Kolkata</place></User>" + "</Persons>\n";

            //write content to file if file exist it will overwrite the old content
            File.WriteAllText(filePath, content);

            //confirmation message that data has been written in the file
            Console.WriteLine("a) data has been written into the XML file which is write_data.xml\n");
        }
    }
}
