using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.model
{
    internal class Handler
    {
        public static void StoreNamesData()
        { 
            string usernameFilePath = "D:\\monocept\\tasks\\FileHandling\\model\\consoles.txt";

            Console.WriteLine("enter your username ");
            string username = Console.ReadLine();

            //open the file for writing and set true because to make sure new usernames are added
            //without deleting the existing one data means names StreamWriter writes data in the the file
            using (StreamWriter writer = new StreamWriter(usernameFilePath, true))
            {
                writer.WriteLine(username);
            }

            Console.WriteLine("username has been saved in storage");

        }

        public static void PrintNamesData()
        { 
            string usernameFilePath = "D:\\monocept\\tasks\\FileHandling\\model\\consoles.txt";

            //checking if file exist before because we need to read it
            if (File.Exists(usernameFilePath))
            {
                //read all content of file and print it line by line
                string[] allUsernames = File.ReadAllLines(usernameFilePath);
                Console.WriteLine("\nall usernames saved in console.txt are ");
                foreach (string username in allUsernames)
                {
                    Console.WriteLine(username);
                }
            }
            else
            { 
                Console.WriteLine("no username data found or no file exist");
            }
        }
    }
}
