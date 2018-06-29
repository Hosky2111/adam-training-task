using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdamsToDoConsoleApplication
{
    class FileManagement
    {
        public static void ReadFiles(List<Task> taskCollection)
        {
            bool looper = true;
            while (looper == true)
            {
                Console.WriteLine("Enter File path for Xml or Json File: \n");
                var path = Console.ReadLine();
                if (Path.GetExtension(path) == ".Json")
                {
                    looper = false;
                    JsonFileManagement.JsonReadFiles(path, taskCollection);
                }
                if (Path.GetExtension(path) == ".Xml")
                {
                    looper = false;
                    XmlFileManagement.XmlReadFiles(path, taskCollection);
                }
                else
                {
                    Console.WriteLine("Please enter a valid Xml or Json File: \n");
                }
            }
        }
        public static void WrieFiles(List<Task> taskCollection)
        {
            bool looper = true;
            while (looper == true)
            {
                Console.WriteLine("File Type: \n1. JSON File\n2.XML File\n");
                var writeChoice = Console.ReadLine();
                if (writeChoice == "1")
                {
                    looper = false;
                    JsonFileManagement.JsonWriteFiles(taskCollection);
                }
                if (writeChoice == "2")
                {
                    looper = false;
                    XmlFileManagement.XmlWriteFiles(taskCollection);
                }
                else
                {
                    Console.WriteLine("Please choose 1 or 2\n");
                }
            }
        }
    }
}