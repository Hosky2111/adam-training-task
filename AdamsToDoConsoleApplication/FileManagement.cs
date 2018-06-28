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
    }
}